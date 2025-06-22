
Imports System.Data.SqlClient
Imports System.Data

Public Class Item

    ' الاتصال بقاعدة البيانات
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    ' تحميل البيانات إلى DataGridView
    Private Sub LoadData()
        Try
            Dim query As String = "SELECT * FROM Item_table"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView_item.DataSource = table
        Catch ex As Exception
            MessageBox.Show("❌ خطأ في تحميل البيانات: " & ex.Message)
        End Try
    End Sub

    ' زر الحفظ
    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Try
            Dim cmd As New SqlCommand("INSERT INTO Item_table (Item_name, Item_quantity, Item_category, Expir_date)
                                       VALUES (@Item_name, @Item_quantity, @Item_category, @Expir_date)", conn)

            ' التحقق من الكمية
            Dim quantity As Integer
            If Not Integer.TryParse(item_quantity.Text, quantity) Then
                quantity = 1 ' القيمة الافتراضية
            End If

            ' تمرير البيانات
            cmd.Parameters.AddWithValue("@Item_name", item_name.Text)
            cmd.Parameters.AddWithValue("@Item_quantity", quantity)
            cmd.Parameters.AddWithValue("@Item_category", ComboBox_item_class.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Expir_date", DateTime.Today)

            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("✔️ تم حفظ المادة بنجاح.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("❌ خطأ أثناء الحفظ: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' زر الحذف
    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        Try
            If String.IsNullOrWhiteSpace(item_id.Text) Then
                MessageBox.Show("يرجى إدخال رقم المادة المراد حذفها.")
                Exit Sub
            End If

            Dim cmd As New SqlCommand("DELETE FROM Item_table WHERE Item_id = @Item_id", conn)
            cmd.Parameters.AddWithValue("@Item_id", item_id.Text)

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("✅ تم حذف المادة بنجاح.")
                item_id.Clear()
                item_name.Clear()
                item_quantity.Clear()
                ComboBox_item_class.SelectedIndex = -1
                LoadData()
            Else
                MessageBox.Show("⚠️ لم يتم العثور على المادة بهذا الرقم.")
            End If

        Catch ex As Exception
            MessageBox.Show("❌ خطأ أثناء الحذف: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' تحميل البيانات عند فتح النموذج
    Private Sub Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

End Class