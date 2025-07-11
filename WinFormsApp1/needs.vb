Imports System.Data.SqlClient

Public Class Needs


    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub Needs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNeedsFromSubscribers()
    End Sub

    Public Sub LoadNeedsFromSubscribers()


        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "
SELECT 
    s.Subscriber_id AS SubscriberID,
    s.Full_name AS FullName,
    f.FamilyNumbe AS FamilyCount,
    i.Item_category AS ItemType,
    i.Item_name AS ItemName,
    i.Item_quantity AS Quantity,
    'Subscriber' AS PersonType
FROM Subscribers_table s
LEFT JOIN Needs_table f ON f.Subscriber_id = s.Subscriber_id
LEFT JOIN Item_table i ON i.Item_id = s.Subscriber_id

UNION ALL

SELECT 
    F.Subscriber_id AS SubscriberID,
    F.Name AS FullName,
    NULL AS FamilyCount,
   i.Item_category AS ItemType,
   i.Item_name AS ItemName,
   i.Item_quantity AS Quantity,
    'FamilyMember' AS PersonType
FROM Family_table F
LEFT JOIN Needs_table n ON n.Subscriber_id = F.Subscriber_id
LEFT JOIN Item_table i ON i.Item_id =  n.Item_id

ORDER BY FullName;"

            Dim adapter As New SqlDataAdapter(query, conn)
            adapter.Fill(dt)
            conn.Close()

            DataGridView_need.DataSource = dt

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ في تحميل البيانات: " & ex.Message)
        End Try
    End Sub



    Private Sub DataGridView_need_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_need.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView_need.Rows(e.RowIndex)
            TextBox_sub_name.Text = row.Cells("FullName").Value.ToString()
            family_relate.Text = row.Cells("FamilyCount").Value.ToString()
            TextBox_item_type.Text = row.Cells("ItemType").Value.ToString()
            TextBox_item_name.Text = row.Cells("ItemName").Value.ToString()
            TextBox_quantity.Text = row.Cells("Quantity").Value.ToString()

        End If
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click


        Try
            ' التحقق من الحقول
            If TextBox_sub_name.Text = "" Or TextBox_item_name.Text = "" Then
                MessageBox.Show(" يرجى تعبئة جميع الحقول للحفظ.")
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

            insertCmd.Parameters.AddWithValue("@subId", subscriberId)
            insertCmd.Parameters.AddWithValue("@type", TextBox_item_type.Text)
            insertCmd.Parameters.AddWithValue("@family", Convert.ToInt32(family_relate.Text))

            conn.Open()
            insertCmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("✔️ تم حفظ الاحتياج بنجاح.")
            LoadNeedsFromSubscribers()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء الحفظ: " & ex.Message)
        End Try
    End Sub


    Private Sub Butt_delete_Click(sender As Object, e As EventArgs) Handles Butt_delete.Click

        If DataGridView_need.SelectedRows.Count = 0 Then
            MessageBox.Show("يرجى تحديد صف لحذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView_need.SelectedRows(0)
        Dim subscriberName As String = selectedRow.Cells("FullName").Value.ToString()

        If MessageBox.Show("هل أنت متأكد من حذف هذا الاحتياج ؟", "تأكيد", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                conn.Open()

                ' الحصول على رقم المشترك من الاسم
                Dim getSubIdCmd As New SqlCommand("SELECT Subscriber_id FROM Subscribers_table WHERE Full_name = @name", conn)
                getSubIdCmd.Parameters.AddWithValue("@name", subscriberName)
                Dim result = getSubIdCmd.ExecuteScalar()

                If result Is Nothing Then
                    conn.Close()
                    MessageBox.Show("❌ لا يمكن العثور على هذا المشترك.")
                    Return
                End If

                Dim subscriberId As Integer = Convert.ToInt32(result)

                ' حذف  من جدول الاحتياج
                Dim deleteNeedCmd As New SqlCommand("DELETE FROM Needs_table WHERE Subscriber_id = @subId", conn)
                deleteNeedCmd.Parameters.AddWithValue("@subId", subscriberId)
                deleteNeedCmd.ExecuteNonQuery()

                ' تحديث جدول المشتركين: حذف المشترك نهائياً إن أردت
                Dim deleteSubCmd As New SqlCommand("DELETE FROM Subscribers_table WHERE Subscriber_id = @subId", conn)
                deleteSubCmd.Parameters.AddWithValue("@subId", subscriberId)
                deleteSubCmd.ExecuteNonQuery()

                ' أو تحديث جدول العائلة إذا كان الرقم خاص بفرد عائلة
                Dim deleteFamilyCmd As New SqlCommand("DELETE FROM Family_table WHERE FNational_id = @subId", conn)
                deleteFamilyCmd.Parameters.AddWithValue("@subId", subscriberId)
                deleteFamilyCmd.ExecuteNonQuery()

                conn.Close()

                MessageBox.Show("✔️ تم الحذف وتحديث الجداول بنجاح.")
                LoadNeedsFromSubscribers()

            Catch ex As Exception
                conn.Close()
                MessageBox.Show("❌ خطأ أثناء الحذف: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub But_edit_Click(sender As Object, e As EventArgs) Handles But_edit.Click

        If DataGridView_need.SelectedRows.Count = 0 Then
            MessageBox.Show("يرجى تحديد صف لتعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim selectedRow As DataGridViewRow = DataGridView_need.SelectedRows(0)
            Dim oldSubscriberName As String = selectedRow.Cells("FullName").Value.ToString()
            Dim oldItemName As String = selectedRow.Cells("ItemName").Value.ToString()

            ' جلب Subscriber_id
            Dim subscriberId As Integer
            Dim getSubIdCmd As New SqlCommand("SELECT Subscriber_id FROM Subscribers_table WHERE Full_name = @name", conn)
            getSubIdCmd.Parameters.AddWithValue("@name", oldSubscriberName)
            conn.Open()
            Dim result = getSubIdCmd.ExecuteScalar()
            conn.Close()

            If result Is Nothing Then
                MessageBox.Show("❌ لا يمكن العثور على هذا المشترك.")
                Return
            Else
                subscriberId = Convert.ToInt32(result)
            End If

            ' تحديث اسم المشترك
            Dim updateSubCmd As New SqlCommand("UPDATE Subscribers_table SET Full_name = @newName WHERE Subscriber_id = @subId", conn)
            updateSubCmd.Parameters.AddWithValue("@newName", TextBox_sub_name.Text)
            updateSubCmd.Parameters.AddWithValue("@subId", subscriberId)
            conn.Open()
            updateSubCmd.ExecuteNonQuery()
            conn.Close()

            ' تحديث عدد أفراد العائلة في جدول Needs_table
            Dim updateNeedCmd As New SqlCommand("UPDATE Needs_table SET FamilyNumbe = @family WHERE Subscriber_id = @subId", conn)
            updateNeedCmd.Parameters.AddWithValue("@family", Convert.ToInt32(family_relate.Text))
            updateNeedCmd.Parameters.AddWithValue("@subId", subscriberId)
            conn.Open()
            updateNeedCmd.ExecuteNonQuery()
            conn.Close()

            ' تحديث نوع المادة واسمها وكميتها في جدول Item_table
            Dim updateItemCmd As New SqlCommand("UPDATE Item_table 
                                             SET Item_category = @category, 
                                                 Item_name = @newItem, 
                                                 Item_quantity = @qty 
                                             WHERE Item_name = @oldItem", conn)
            updateItemCmd.Parameters.AddWithValue("@category", TextBox_item_type.Text)
            updateItemCmd.Parameters.AddWithValue("@newItem", TextBox_item_name.Text)
            updateItemCmd.Parameters.AddWithValue("@qty", Convert.ToInt32(TextBox_quantity.Text))
            updateItemCmd.Parameters.AddWithValue("@oldItem", oldItemName)
            conn.Open()
            updateItemCmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("✔️ تم التعديل بنجاح.")
            LoadNeedsFromSubscribers()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء التعديل: " & ex.Message)
        End Try
    End Sub

End Class