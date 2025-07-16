

Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Report

    Private reportType As String
    Private dataToPrint As New List(Of String)
    Private Const connectionString As String = "Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True"
    Private yPos As Integer = 100
    Private currentLineIndex As Integer = 0

    Private Sub Frm_PrintReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxReportType.Items.AddRange({"تقرير احتياج", "تقرير مادة واردة", "تقرير نواقص", "تقرير مصروف"})
        DateTimePicker_From.Value = Date.Today.AddDays(-7)
        DateTimePicker_To.Value = Date.Today
    End Sub

    Private Sub ButtonShowReport_Click_1(sender As Object, e As EventArgs) Handles ButtonShowReport.Click
        If ComboBoxReportType.SelectedItem Is Nothing Then
            MessageBox.Show("الرجاء اختيار نوع التقرير")
            Return
        End If

        reportType = ComboBoxReportType.SelectedItem.ToString()
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
                    query = "SELECT s.full_name, i.item_name, n.need_type, n.FamilyNumbe 
                             FROM Needs_table n
                           LEFT  JOIN subscribers_table s ON n.Subscriber_id = s.Subscriber_id
                             JOIN Item_table i ON n.Item_id = i.Item_id"

                Case "تقرير مادة واردة"
                    query = "SELECT d.Donor_id, i.item_name, d.Donation_type, d.quantity, d.Donation_date
                             FROM Donations_table d
                             JOIN Item_table i ON d.Item_id = i.Item_id
                             WHERE d.Donation_date BETWEEN @from AND @to"
                    useDateFilter = True

                Case "تقرير نواقص"
                    query = "SELECT Item_category, Item_name, Item_quantity FROM Item_table"

                Case "تقرير مصروف"
                    query = "SELECT s.full_name, i.item_name, n.FamilyNumbe
                             FROM Needs_table n
                            LEFT JOIN subscribers_table s ON n.Subscriber_id = s.Subscriber_id
                             JOIN Item_table i ON n.Item_id = i.Item_id"
            End Select

            Using cmd As New SqlCommand(query, conn)
                If useDateFilter Then
                    cmd.Parameters.AddWithValue("@from", DateTimePicker_From.Value.Date)
                    cmd.Parameters.AddWithValue("@to", DateTimePicker_To.Value.Date)
                End If

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim line As String = ""

                        Select Case reportType
                            Case "تقرير احتياج"
                                line = $"اسم المشترك: {reader("full_name")} | اسم المادة: {reader("item_name")} | نوع الاحتياج: {reader("need_type")} | عدد الأسرة: {reader("FamilyNumbe")}"

                            Case "تقرير مادة واردة"
                                line = $"رقم المتبرع: {reader("Donor_id")} | اسم المادة: {reader("item_name")} | نوع التبرع: {reader("Donation_type")} | الكمية: {reader("quantity")} | التاريخ: {Convert.ToDateTime(reader("Donation_date")).ToShortDateString()}"

                            Case "تقرير نواقص"
                                line = $" التصنيف: {reader("Item_category")} | الاسم: {reader("Item_name")} | الكمية: {reader("Item_quantity")}"

                            Case "تقرير مصروف"

                                line = $"اسم المشترك: {reader("full_name")} | اسم المادة: {reader("item_name")} | عدد الأسرة: {reader("FamilyNumbe")}"
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



