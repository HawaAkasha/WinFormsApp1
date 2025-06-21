
Imports System.Data.SqlClient


Public Class user_form
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Sub clear()
        TextBox_nameuser.Clear()
        TextBox_passuser1.Clear()
        TextBox_passuser2.Clear()
        Radio_admin.Checked = False
        Radio_employee.Checked = False
        Button_add.Visible = True
        Button_edit.Visible = False
        Button_delete.Visible = False
    End Sub
    ' الاتصال بقاعدة البيانات

    ' '//////////////////////////////////////////////////////////////////////////////////////////////////////////


    'login form1 
    Function login(ByVal user_name)
        Dim cmd As New SqlCommand("select*from users where user_name=@user_name", conn)
        cmd.Parameters.AddWithValue("@user_name", user_name)
        Dim dt As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt)
        Return dt
    End Function


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

        Try
            conn.Open()

            ' تحديد الصلاحية: مدير = True، موظف = False
            Dim validity As Boolean
            If Radio_admin.Checked Then
                validity = True
            ElseIf Radio_employee.Checked Then
                validity = False
            End If

            Dim cmd As New SqlCommand("INSERT INTO users_table (user_password, user_name, user_validity) 
            VALUES (@user_password, @user_name, @user_validity)", conn)

            cmd.Parameters.AddWithValue("@user_password", TextBox_passuser1.Text)
            cmd.Parameters.AddWithValue("@user_name", TextBox_nameuser.Text)
            cmd.Parameters.AddWithValue("@user_validity", validity)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("تمت إضافة المستخدم بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()

        Catch ex As Exception
            MessageBox.Show("خطأ أثناء الإضافة: " & ex.Message)
            conn.Close()
        End Try
        LoadAllUsers() 'الظهور فيgridview

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

        End If


        'التعديل في الداتا بيز

        Try
            conn.Open()
            Dim validity As Boolean
            If Radio_admin.Checked Then
                validity = True
            ElseIf Radio_employee.Checked Then
                validity = False
            End If
            Dim cmd As New SqlCommand("UPDATE users_table  SET user_password = @password, user_name = @name, user_validity = @validity 
        WHERE user_id = @id", conn)

            cmd.Parameters.AddWithValue("@password", TextBox_passuser1.Text)
            cmd.Parameters.AddWithValue("@name", TextBox_nameuser.Text)
            cmd.Parameters.AddWithValue("@validity", vality) ' 1 أو 0 مثلاً حسب CheckBox أو اختيار آخر
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox_id.Text))
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("تم تعديل المستخدم بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Else
                MessageBox.Show("لم يتم العثور على المستخدم لتعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ أثناء التعديل: " & ex.Message)
            conn.Close()
        End Try
        LoadAllUsers() 'الظهور فيgridview
    End Sub

    ' زر الحذف
    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        If TextBox_id.Text.Trim() = "" Then
            MessageBox.Show("يرجى إدخال رقم المستخدم للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("هل أنت متأكد من حذف هذا المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand("DELETE FROM users_table WHERE user_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", TextBox_id.Text)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                conn.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("تم حذف المستخدم بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadAllUsers() ' لتحديث البيانات في DataGridView
                Else
                    MessageBox.Show("لم يتم العثور على مستخدم بهذا الرقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("حدث خطأ أثناء الحذف: " & ex.Message)
                conn.Close()
            End Try
        End If
        LoadAllUsers() 'الظهور فيgridview
    End Sub


    ' زر البحث
    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If TextBox_id.Text = "" Or Not IsNumeric(TextBox_id.Text) Then
            MsgBox("الرجاء إدخال رقم معرف صالح", MsgBoxStyle.Critical)
            Exit Sub
        End If


        SearchUserByID()
        LoadAllUsers() 'الظهور فيgridview
    End Sub
    Private Sub SearchUserByID()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT user_id, user_password, user_name, user_validity FROM users_table WHERE user_id = @id", conn)
            cmd.Parameters.AddWithValue("@id", TextBox_id.Text)

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("لم يتم العثور على مستخدم بهذا الرقم.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ أثناء البحث: " & ex.Message)
            conn.Close()
        End Try

    End Sub

    'الظهور في الشاشه عند عمليات عرض حذ اضافه بحث

    Private Sub LoadAllUsers()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT user_id, user_password, user_name, user_validity FROM users_table", conn)
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("خطأ أثناء تحميل المستخدمين: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class














