Imports System.Data.SqlClient

Public Class Needs


    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub Needs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNeedsFromSubscribers()
    End Sub
    'مشكلة في عدد العائلة
    Public Sub LoadNeedsFromSubscribers()
        Dim dt As New DataTable()
        Try
            conn.Open()

            Dim query As String = "
            SELECT 
                s.Subscriber_id,
                s.Full_name AS [اسم المشترك],
                s.Age AS [العمر],
                s.Phone_number AS [رقم الهاتف],
                ISNULL(f.FamilyNumbe,'-') AS [عدد أفراد العائلة],
                ISNULL(i.Item_category, '-') AS [نوع المادة],
                ISNULL(i.Item_name, '-') AS [اسم المادة],
                ISNULL(i.Item_quantity, '-') AS [الكمية]
            FROM Subscribers_table s
            LEFT JOIN Needs_table f ON f.Subscriber_id = s.Subscriber_id
            LEFT JOIN Item_table i ON i.Item_id = s.Subscriber_id  -- فقط لو كنتِ تربطي الـ Item_id بنفس رقم المشترك!
            ORDER BY s.Full_name;
            "

            Dim adapter As New SqlDataAdapter(query, conn)
            adapter.Fill(dt)
            conn.Close()

            DataGridView_need.DataSource = dt

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ في تحميل البيانات: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_need_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_need.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView_need.Rows(e.RowIndex)

            TextBox_sub_name.Text = row.Cells("اسم المشترك").Value.ToString()
            family_relate.Text = row.Cells("عدد أفراد العائلة").Value.ToString()
            TextBox_item_type.Text = row.Cells("نوع المادة").Value.ToString()
            TextBox_item_name.Text = row.Cells("اسم المادة").Value.ToString()
            TextBox_quantity.Text = row.Cells("الكمية").Value.ToString()
        End If
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Try
            ' التحقق من الحقول
            If TextBox_sub_name.Text = "" Or TextBox_item_name.Text = "" Then
                MessageBox.Show("يرجى تعبئة جميع الحقول.")
                Exit Sub
            End If

            ' 🔹 جلب رقم المشترك بناءً على الاسم الحقيقي
            Dim subscriberId As Integer = 0
            Dim getSubIdCmd As New SqlCommand("SELECT Subscriber_id FROM Subscribers_table WHERE Full_name = @name", conn)
            getSubIdCmd.Parameters.AddWithValue("@name", TextBox_sub_name.Text)

            conn.Open()
            Dim resultSub = getSubIdCmd.ExecuteScalar()
            conn.Close()

            If resultSub Is Nothing Then
                MessageBox.Show("❌ المشترك غير موجود في قاعدة البيانات.")
                Exit Sub
            Else
                subscriberId = Convert.ToInt32(resultSub)
            End If

            ' 🔹 جلب رقم المادة بناءً على الاسم الحقيقي
            Dim itemId As Integer = 0
            Dim getItemIdCmd As New SqlCommand("SELECT TOP 1 Item_id FROM Item_table WHERE Item_name = @name ORDER BY Item_id DESC", conn)
            getItemIdCmd.Parameters.AddWithValue("@name", TextBox_item_name.Text)

            conn.Open()
            Dim resultItem = getItemIdCmd.ExecuteScalar()
            conn.Close()

            If resultItem Is Nothing Then
                MessageBox.Show("❌ المادة غير موجودة في قاعدة البيانات.")
                Exit Sub
            Else
                itemId = Convert.ToInt32(resultItem)
            End If

            ' 🔹 إضافة الاحتياج إلى جدول Needs_table
            Dim insertCmd As New SqlCommand("INSERT INTO Needs_table (Subscriber_id, Need_type, FamilyNumbe)
                                         VALUES (@subId, @type, @family)", conn)
            'insertCmd.Parameters.AddWithValue("@itemId", itemId)
            insertCmd.Parameters.AddWithValue("@subId", subscriberId)
            insertCmd.Parameters.AddWithValue("@type", TextBox_item_type.Text)
            insertCmd.Parameters.AddWithValue("@family", Convert.ToInt32(family_relate.Text))

            conn.Open()
            insertCmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("✔️ تم حفظ الاحتياج بنجاح.")

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء الحفظ: " & ex.Message)
        End Try
    End Sub

End Class