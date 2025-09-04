Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Report
    Private reportType As String
    Private dataToPrint As New List(Of String)
    Private Const connectionString As String = "Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True"
    Private yPos As Integer = 100
    Private currentLineIndex As Integer = 0

    Private Sub Frm_PrintReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxReportType.Items.AddRange({
            "تقرير احتياج",
            "تقرير مادة واردة",
            "تقرير نواقص",
            "تقرير مصروف",
            "تقرير امراض",
            "تقرير الفئات العمرية",
            "تقرير الحاله الاجتماعيه"
        })

        ' فترة مبدئية
        DateTimePicker_From.Value = Date.Today.AddDays(-7)
        DateTimePicker_To.Value = Date.Today

        ' تعبية ComboBox الأعمار
        For i As Integer = 1 To 100
            ComboBox_Age.Items.Add(i)
        Next

        ' إضافة الحالات الاجتماعية إلى ComboBox
        ' تأكد من أن هذا الـ ComboBox تم تسميته بـ ComboBox_MaritalStatus في واجهة المستخدم
        ComboBox_MaritalStatus.Items.AddRange({
            "اعزب",
            "متزوج",
            "ارمله",
            "مطلق"
        })
    End Sub

    Private Sub ButtonShowReport_Click_1(sender As Object, e As EventArgs) Handles ButtonShowReport.Click
        If ComboBoxReportType.SelectedItem Is Nothing Then
            MessageBox.Show("الرجاء اختيار نوع التقرير")
            Return
        End If

        reportType = ComboBoxReportType.SelectedItem.ToString()

        ' فحص جديد للحالة الاجتماعية
        If reportType = "تقرير الحاله الاجتماعيه" And ComboBox_MaritalStatus.SelectedItem Is Nothing Then
            MessageBox.Show("الرجاء اختيار الحالة الاجتماعية")
            Return
        End If

        LoadReportData()
        currentLineIndex = 0
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub LoadReportData()
        dataToPrint.Clear()

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query As String = ""
            Dim useDateFilter As Boolean = False

            Select Case reportType
                Case "تقرير احتياج"
                    query = "SELECT s.Subscriber_id, i.item_name, n.need_type, n.FamilyNumbe
                             FROM Needs_table n
                             LEFT JOIN subscribers_table s ON n.Subscriber_id = s.National_id
                             JOIN Item_table i ON n.Item_id = i.Item_id"

                Case "تقرير مادة واردة"
                    query = "SELECT d.Donor_id, i.item_id, i.item_name, d.Donation_date
                             FROM Donations_table d
                             JOIN Item_table i ON d.Item_id = i.Item_id
                             WHERE d.Donation_date BETWEEN @from AND @to"
                    useDateFilter = True

                Case "تقرير نواقص"
                    query = "SELECT Item_id, Item_category, Item_name, Item_quantity FROM Item_table"

                Case "تقرير مصروف"
                    query = "SELECT s.full_name, i.item_id, i.item_name, n.FamilyNumbe
                             FROM Needs_table n
                             LEFT JOIN subscribers_table s ON n.Subscriber_id = s.National_id
                             JOIN Item_table i ON n.Item_id = i.Item_id"

                Case "تقرير امراض"
                    query = "
        SELECT s.Full_name AS Name, s.Age AS Age, Disease_id AS Disease
        FROM Subscribers_table s
        UNION ALL
        SELECT f.Name AS Name, f.Age AS Age, Disease_id AS Disease
        FROM Family_table f
        UNION ALL
        SELECT s.Full_name AS Name, m.Age AS Age, m.Disease_type AS Disease
        FROM Subscribers_table s
        JOIN MedicaRecord m ON s.National_id = m.Patient_id"


                Case "تقرير الفئات العمرية"
                    query = "
SELECT Full_name, Age, 'مشترك' AS PersonType
FROM Subscribers_table
WHERE Age = @age

UNION ALL

SELECT Name AS Full_name, Age, 'عائلة' AS PersonType
FROM Family_table
WHERE Age = @age
"
                Case "تقرير الحاله الاجتماعيه"
                    query = "SELECT Full_name, Marital_status FROM Subscribers_table WHERE Marital_status = @maritalStatus"

            End Select

            Using cmd As New SqlCommand(query, conn)
                ' إضافة باراميترات إذا فيه فلترة تواريخ
                If useDateFilter Then
                    cmd.Parameters.AddWithValue("@from", DateTimePicker_From.Value.Date)
                    cmd.Parameters.AddWithValue("@to", DateTimePicker_To.Value.Date)
                End If

                ' إضافة باراميتر العمر
                If reportType = "تقرير الفئات العمرية" Then
                    If ComboBox_Age.SelectedItem Is Nothing Then
                        MessageBox.Show("الرجاء اختيار العمر")
                        Return
                    End If
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(ComboBox_Age.SelectedItem))
                End If

                ' إضافة باراميتر الحالة الاجتماعية
                If reportType = "تقرير الحاله الاجتماعيه" Then
                    cmd.Parameters.AddWithValue("@maritalStatus", ComboBox_MaritalStatus.SelectedItem.ToString())
                End If

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim line As String = ""

                        Select Case reportType
                            Case "تقرير احتياج"
                                line = $"رقم المشترك: {reader("Subscriber_id")} | اسم المادة: {reader("item_name")} | نوع الاحتياج: {reader("need_type")} | عدد الأسرة: {reader("FamilyNumbe")}"

                            Case "تقرير مادة واردة"
                                line = $"رقم المتبرع: {reader("Donor_id")} | رقم المادة: {reader("item_id")} | اسم المادة: {reader("item_name")} | التاريخ: {Convert.ToDateTime(reader("Donation_date")).ToShortDateString()}"

                            Case "تقرير نواقص"
                                line = $"رقم المادة: {reader("Item_id")} | التصنيف: {reader("Item_category")} | الاسم: {reader("Item_name")} | الكمية: {reader("Item_quantity")}"

                            Case "تقرير مصروف"
                                line = $"اسم المشترك: {reader("full_name")} | رقم المادة: {reader("item_id")} | اسم المادة: {reader("item_name")} | عدد الأسرة: {reader("FamilyNumbe")}"

                            Case "تقرير امراض"
                                line = $"الاسم: {reader("Name")} | العمر: {reader("Age")} | المرض: {If(IsDBNull(reader("Disease")), "-", reader("Disease"))}"

                            Case "تقرير الفئات العمرية"
                                line = $"الاسم: {reader("Full_name")} | العمر: {reader("Age")}"

                            Case "تقرير الحاله الاجتماعيه"
                                line = $"الاسم: {reader("Full_name")} | الحالة الاجتماعيه: {reader("Marital_status")}"

                        End Select

                        dataToPrint.Add(line)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        Dim pageWidth As Integer = e.PageBounds.Width
        Dim reportTitle As String = reportType
        Dim titleSize As SizeF = e.Graphics.MeasureString(reportTitle, titleFont)
        Dim titleX As Integer = (pageWidth - titleSize.Width) \ 2
        Dim titleY As Integer = 50
        e.Graphics.DrawString(reportTitle, titleFont, brush, titleX, titleY)

        ' طباعة الفترة إذا كان فيها فلترة
        If reportType = "تقرير مادة واردة" Then
            Dim period As String = $"الفترة: {DateTimePicker_From.Value.ToShortDateString()} إلى {DateTimePicker_To.Value.ToShortDateString()}"
            e.Graphics.DrawString(period, dataFont, brush, titleX, titleY + titleSize.Height + 5)
        End If

        Dim startY As Integer = titleY + titleSize.Height + 40
        Dim lineHeight As Integer = dataFont.Height + 10

        While currentLineIndex < dataToPrint.Count
            Dim text As String = dataToPrint(currentLineIndex)
            Dim textSize As SizeF = e.Graphics.MeasureString(text, dataFont)

            If startY + textSize.Height > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If

            Dim xRight As Integer = pageWidth - 50 - textSize.Width
            e.Graphics.DrawString(text, dataFont, brush, xRight, startY)
            startY += lineHeight
            currentLineIndex += 1
        End While

        e.HasMorePages = False
    End Sub

End Class