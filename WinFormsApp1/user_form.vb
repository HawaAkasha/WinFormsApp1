
Imports System.Data.SqlClient
Imports Windows.Win32.System
Public Class user_form
    ' الاتصال بقاعدة البيانات

    ' Dim con As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True", con)

    Sub clear()
        TextBox_id.Clear()
        TextBox_nameuser.Clear()
        TextBox_passuser1.Clear()
        TextBox_passuser2.Clear()
        Radio_admin.Checked = False
        Radio_employee.Checked = False
        Button_add.Visible = True
        Button_edit.Visible = False
        Button_delete.Visible = False
    End Sub

    ' تعديل مستخدم
    Sub add_user(ByVal user_name As String, ByVal user_pass As String, ByVal user_validity As Boolean)
        'Dim cmd As New SqlCommand("INSERT INTO users (user_name, user_password, user_validity) VALUES (@user_name, @user_password, @user_validity)", con)
        ' cmd.Parameters.AddWithValue("@user_name", user_name)
        ' cmd.Parameters.AddWithValue("@user_password", user_pass)
        ' cmd.Parameters.AddWithValue("@user_validity", user_validity)
        ' con.Open()
        ' cmd.ExecuteNonQuery()
        ' con.Close()
    End Sub

    ' تعديل مستخدم
    Sub edit_user(ByVal user_pass As String, ByVal user_validity As Boolean, ByVal user_id As Integer)
        ' Dim cmd As New SqlCommand("UPDATE users SET user_password=@user_password, user_validity=@user_validity WHERE user_id=@user_id", con)
        ' cmd.Parameters.AddWithValue("@user_password", user_pass)
        ' cmd.Parameters.AddWithValue("@user_validity", user_validity)
        ' cmd.Parameters.AddWithValue("@user_id", user_id)
        ' con.Open()
        ' cmd.ExecuteNonQuery()
        ' con.Close()
    End Sub

    ' حذف مستخدم
    Sub delete_user(ByVal user_id As Integer)
        ' Dim cmd As New SqlCommand("DELETE FROM users WHERE user_id=@user_id", con)
        ' cmd.Parameters.AddWithValue("@user_id", user_id)
        ' con.Open()
        ' cmd.ExecuteNonQuery()
        ' con.Close()
    End Sub

    ' البحث عن مستخدم
    Function search_user(ByVal user_id As Integer) As DataTable
        ' Dim cmd As New SqlCommand("SELECT * FROM users WHERE user_id=@user_id", con)
        ' cmd.Parameters.AddWithValue("@user_id", user_id)
        ' Dim dt As New DataTable
        ' Dim adp As New SqlDataAdapter(cmd)
        'adp.Fill(dt)
        'Return dt
    End Function
    ' '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' زر الإضافة
    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        If TextBox_nameuser.Text = "" Then
            MsgBox("يرجى إدخال اسم المستخدم", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If TextBox_passuser1.Text = "" Then
            MsgBox("يرجى إدخال كلمة المرور", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If TextBox_passuser1.Text <> TextBox_passuser2.Text Then
            MsgBox("كلمة المرور غير متطابقة", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Not Radio_admin.Checked And Not Radio_employee.Checked Then
            MsgBox("يرجى تحديد صلاحية المستخدم", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim validity As Boolean = Radio_admin.Checked
        add_user(TextBox_nameuser.Text, TextBox_passuser1.Text, validity)
        MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information)
        clear()
    End Sub

    ' زر التعديل
    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If TextBox_id.Text = "" Or Not IsNumeric(TextBox_id.Text) Then
            MsgBox("الرجاء إدخال رقم المعرف بشكل صحيح", MsgBoxStyle.Critical)

            Exit Sub
        End If

        If TextBox_passuser1.Text = "" Then
            MsgBox("يرجى إدخال كلمة المرور", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If TextBox_passuser1.Text <> TextBox_passuser2.Text Then
            MsgBox("كلمة المرور غير متطابقة", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Not Radio_admin.Checked And Not Radio_employee.Checked Then
            MsgBox("يرجى تحديد صلاحية المستخدم", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim result As MsgBoxResult = MsgBox("هل أنت متأكد من التعديل؟", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Dim validity As Boolean = Radio_admin.Checked
            edit_user(TextBox_passuser1.Text, validity, CInt(TextBox_id.Text))
            MsgBox("تم التعديل بنجاح", MsgBoxStyle.Information)
            clear()
        End If
    End Sub

    ' زر الحذف
    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        If TextBox_id.Text = "" Or Not IsNumeric(TextBox_id.Text) Then
            MsgBox("الرجاء إدخال رقم المعرف بشكل صحيح", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim result As MsgBoxResult = MsgBox("هل أنت متأكد من الحذف؟", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            delete_user(CInt(TextBox_id.Text))
            MsgBox("تم الحذف بنجاح", MsgBoxStyle.Information)
            clear()
        End If
    End Sub

    ' زر البحث
    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If TextBox_id.Text = "" Or Not IsNumeric(TextBox_id.Text) Then
            MsgBox("الرجاء إدخال رقم معرف صالح", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim dt As DataTable = search_user(CInt(TextBox_id.Text))
        If dt.Rows.Count > 0 Then
            TextBox_nameuser.Text = dt.Rows(0)("user_name").ToString()
            TextBox_passuser1.Text = dt.Rows(0)("user_password").ToString()
            TextBox_passuser2.Text = dt.Rows(0)("user_password").ToString()
            If CBool(dt.Rows(0)("user_validity")) Then
                Radio_admin.Checked = True
            Else
                Radio_employee.Checked = True
            End If
            Button_add.Visible = False
            Button_edit.Visible = True
            Button_delete.Visible = True
        Else
            MsgBox("لا يوجد مستخدم بهذا الرقم", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class














