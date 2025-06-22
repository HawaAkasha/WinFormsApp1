Imports Azure.Core

Public Class needs
    Dim requestList As New BindingSource()
    Private Sub needs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView_need.DataSource = requestList
    End Sub



    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Dim newRequest As New Request With {
        .TextBox_sub_name = TextBox_sub_name.Text,
        .family_relate = family_relate.Text,
        .TextBox_item_type = TextBox_item_type.Text,
        .TextBox_item_name = TextBox_item_name.Text,
        .TextBox_quantity = TextBox_quantity.Text}







        requestList.Add(newRequest)

        ' تنظيف الحقول
        TextBox_sub_name.Clear()
        family_relate.Clear()
        TextBox_item_type.Clear()
        TextBox_item_name.Clear()
        TextBox_quantity.Clear()


    End Sub



    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        ' تحقق إن فيه صف محدد
        If DataGridView_need.CurrentRow IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show("هل أنت متأكد من حذف هذا الصف؟", "تأكيد الحذف", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                requestList.RemoveAt(DataGridView_need.CurrentRow.Index)
            End If
        Else
            MessageBox.Show("يرجى تحديد صف للحذف أولاً.")
        End If

    End Sub

    Private Sub DataGridView_need_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_need.CellContentClick

    End Sub

    ' Private Sub DataGridView_need_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_need.CellContentClick

    ' End Sub

End Class