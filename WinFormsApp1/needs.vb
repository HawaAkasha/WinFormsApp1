
Imports System.Data.SqlClient

Public Class Needs

    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private selectedSubscriberID As Integer = -1
    Private selectedItemID As Integer = -1
    Private isFamilyMember As Boolean = False

    Private Sub Needs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNeedsFromSubscribers()
    End Sub

    Public Sub LoadNeedsFromSubscribers()
        Dim dt As New DataTable()


        Try
            conn.Open()
            Dim sql As String = "
SELECT 
  n.Subscriber_id, 
  s.Full_name AS Fullname, 
  n.FamilyNumbe,
  i.Item_id, 
  i.Item_category, 
  i.Item_name, 
  i.Item_quantity,
  'Subscriber' AS PersonType
FROM Needs_table n
LEFT JOIN Subscribers_table s ON n.Subscriber_id =s.National_id
 JOIN Item_table i ON i.Item_id = n.Item_id

UNION ALL

SELECT 
  n.Subscriber_id,
  f.Name AS Fullname,      
  n.FamilyNumbe,
  i.Item_id, 
  i.Item_category, 
  i.Item_name, 
  i.Item_quantity,
  'FamilyMember' AS PersonType
FROM Needs_table n
LEFT JOIN Family_table f ON n.Subscriber_id = f.Subscriber_id
 JOIN Item_table i ON i.Item_id = n.Item_id

ORDER BY Fullname;"
            Dim da As New SqlDataAdapter(sql, conn)
            da.Fill(dt)
            conn.Close()

            DataGridView_need.DataSource = dt
            DataGridView_need.AllowUserToAddRows = False

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ في التحميل: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_need_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_need.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = DataGridView_need.Rows(e.RowIndex)
        selectedSubscriberID = Convert.ToInt32(row.Cells("Subscriber_id").Value)
        selectedItemID = Convert.ToInt32(row.Cells("Item_id").Value)


        TextBox_sub_name.Text = If(IsDBNull(row.Cells("Fullname").Value), "", row.Cells("Fullname").Value.ToString())
        family_relate.Text = If(IsDBNull(row.Cells("FamilyNumbe").Value), "0", row.Cells("FamilyNumbe").Value.ToString())
        TextBox_item_type.Text = If(IsDBNull(row.Cells("Item_category").Value), "", row.Cells("Item_category").Value.ToString())
        TextBox_item_name.Text = If(IsDBNull(row.Cells("Item_name").Value), "", row.Cells("Item_name").Value.ToString())
        TextBox_quantity.Text = If(IsDBNull(row.Cells("Item_quantity").Value), "0", row.Cells("Item_quantity").Value.ToString())
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        If selectedSubscriberID < 0 Then
            MessageBox.Show(" يرجى تعبية جميع الحقول للحفظ.")
            Return
        End If
        If TextBox_item_name.Text = "" Then
            MessageBox.Show("❌ أرجو تحديد المادة.")
            Return
        End If

        Try
            conn.Open()
            ' أول: أيّجاد Item_id للمادة المختارة (أو يمكنك اختيارها مسبقًا)
            Dim getItemCmd As New SqlCommand("SELECT TOP 1 Item_id FROM Item_table WHERE Item_name=@name", conn)
            getItemCmd.Parameters.AddWithValue("@name", TextBox_item_name.Text)
            Dim iid = getItemCmd.ExecuteScalar()
            If iid Is DBNull.Value OrElse iid Is Nothing Then
                MessageBox.Show("❌ المادة غير موجودة.")
                conn.Close() : Return
            End If
            selectedItemID = Convert.ToInt32(iid)

            ' منع التكرار
            Dim chkCmd As New SqlCommand(
                "SELECT COUNT(*) FROM Needs_table WHERE Subscriber_id=@sid AND Item_id=@iid", conn)
            chkCmd.Parameters.AddWithValue("@sid", selectedSubscriberID)
            chkCmd.Parameters.AddWithValue("@iid", selectedItemID)
            Dim exists = Convert.ToInt32(chkCmd.ExecuteScalar())
            If exists > 0 Then
                MessageBox.Show("✅ هذا الاحتياج مسجل مسبقاً.")
                conn.Close() : Return
            End If

            ' إدراج احتياج جديد
            Dim insCmd As New SqlCommand(
                "INSERT INTO Needs_table (Subscriber_id, Item_id, Need_type, FamilyNumbe) 
                 VALUES(@sid,@iid,@type,@count)", conn)
            insCmd.Parameters.AddWithValue("@sid", selectedSubscriberID)
            insCmd.Parameters.AddWithValue("@iid", selectedItemID)
            insCmd.Parameters.AddWithValue("@type", TextBox_item_type.Text)
            insCmd.Parameters.AddWithValue("@count", Convert.ToInt32(family_relate.Text))
            insCmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("✔️ تم حفظ الحاجة بنجاح.")

            LoadNeedsFromSubscribers()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء الحفظ: " & ex.Message)
        End Try
    End Sub

    Private Sub But_edit_Click(sender As Object, e As EventArgs) Handles But_edit.Click
        If selectedSubscriberID < 0 Then
            MessageBox.Show("❌ يرجى اختيار سجل من القائمة أولاً.")
            Return
        End If

        Try
            conn.Open()

            ' تحديث اسم المشترك أو فرد العائلة
            Dim updateNameSql As String = ""
            If isFamilyMember Then
                updateNameSql = "UPDATE Family_table SET Name=@name WHERE Subscriber_id=@sid"
            Else
                updateNameSql = "UPDATE Subscribers_table SET Full_name=@name WHERE Subscriber_id=@sid"
            End If
            Dim nameCmd As New SqlCommand(updateNameSql, conn)
            nameCmd.Parameters.AddWithValue("@name", TextBox_sub_name.Text)
            nameCmd.Parameters.AddWithValue("@sid", selectedSubscriberID)
            nameCmd.ExecuteNonQuery()

            ' 1. تحديث جدول الاحتياج Needs_table
            Dim updNeedsCmd As New SqlCommand(
            "UPDATE Needs_table 
             SET Need_type = @type, FamilyNumbe = @count 
             WHERE Subscriber_id = @sid AND Item_id = @iid", conn)

            updNeedsCmd.Parameters.AddWithValue("@type", TextBox_item_type.Text)
            updNeedsCmd.Parameters.AddWithValue("@count", Convert.ToInt32(family_relate.Text))
            updNeedsCmd.Parameters.AddWithValue("@sid", selectedSubscriberID)
            updNeedsCmd.Parameters.AddWithValue("@iid", selectedItemID)
            updNeedsCmd.ExecuteNonQuery()

            ' 2. تحديث جدول المادة Item_table
            Dim updItemCmd As New SqlCommand(
            "UPDATE Item_table 
             SET Item_name = @name, Item_category = @cat, Item_quantity = @qty 
             WHERE Item_id = @iid", conn)

            updItemCmd.Parameters.AddWithValue("@name", TextBox_item_name.Text)
            updItemCmd.Parameters.AddWithValue("@cat", TextBox_item_type.Text)
            updItemCmd.Parameters.AddWithValue("@qty", Convert.ToInt32(TextBox_quantity.Text))
            updItemCmd.Parameters.AddWithValue("@iid", selectedItemID)
            updItemCmd.ExecuteNonQuery()


            Dim rows = updItemCmd.ExecuteNonQuery()

            conn.Close()

            If rows = 0 Then
                MessageBox.Show("❌ لم يتم العثور على هذا الاحتياج للتعديل.")
            Else
                MessageBox.Show("✔️ تم التعديل بنجاح.")
                DataGridView_need.DataSource = Nothing
                LoadNeedsFromSubscribers()
            End If

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء التعديل: " & ex.Message)
        End Try
    End Sub

    Private Sub Butt_delete_Click(sender As Object, e As EventArgs) Handles Butt_delete.Click
        If selectedSubscriberID < 0 Then
            MessageBox.Show("❌ يرجى اختيار سجل للحذف.")
            Return
        End If

        If MessageBox.Show("هل تريد فعلاً حذف هذا الاحتياج؟", "تأكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Return
        End If

        Try
            conn.Open()
            Dim delCmd As New SqlCommand(
                "DELETE FROM Needs_table WHERE Subscriber_id=@sid AND Item_id=@iid", conn)
            delCmd.Parameters.AddWithValue("@sid", selectedSubscriberID)
            delCmd.Parameters.AddWithValue("@iid", selectedItemID)
            Dim rows = delCmd.ExecuteNonQuery()
            conn.Close()

            If rows = 0 Then
                MessageBox.Show("❌ لم يتم العثور على هذا الاحتياج للحذف.")
            Else
                MessageBox.Show("✔️ تم الحذف بنجاح.")
                LoadNeedsFromSubscribers()
            End If

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء الحذف: " & ex.Message)
        End Try
    End Sub

End Class

