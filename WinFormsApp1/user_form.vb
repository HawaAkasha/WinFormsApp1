
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
        ' التحقق من الاسم المكرر بدقة
        Try
            conn.Open()
            Dim checkCmd As New SqlCommand(" SELECT COUNT(*) FROM users_table 
            WHERE LTRIM(RTRIM(user_name)) COLLATE Arabic_CI_AI = LTRIM(RTRIM(@name)) COLLATE Arabic_CI_AI", conn)

            checkCmd.Parameters.AddWithValue("@name", TextBox_nameuser.Text.Trim())
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            conn.Close()

            If count > 0 Then
                MsgBox("❌ اسم المستخدم مسجل من قبل، يرجى إدخال اسم مختلف", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("خطأ أثناء التحقق من الاسم: " & ex.Message, MsgBoxStyle.Critical)
            conn.Close()
            Exit Sub
        End Try

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


        Catch ex As Exception
            MessageBox.Show("خطأ أثناء الإضافة: " & ex.Message)
            conn.Close()
        End Try
        LoadAllUsers() 'الظهور فيgridview
        Button_add.Visible = False

        Button_delete.Visible = True
        Button_edit.Visible = True


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
        If result = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            conn.Open()
            Dim validity As Boolean
            If Radio_admin.Checked Then
                validity = True
            Else
                validity = False
            End If

            Dim cmd As New SqlCommand("UPDATE users_table SET user_password = @password, user_name = @name, user_validity = @validity WHERE user_id = @id", conn)
            cmd.Parameters.AddWithValue("@password", TextBox_passuser1.Text)
            cmd.Parameters.AddWithValue("@name", TextBox_nameuser.Text)
            cmd.Parameters.AddWithValue("@validity", validity)
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

        LoadAllUsers()
        Button_add.Visible = True
        Button_delete.Visible = True
        Button_edit.Visible = True
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

        Button_add.Visible = True
        Button_delete.Visible = True
        Button_edit.Visible = True
    End Sub


    ' زر البحث
    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If TextBox_id.Text = "" Or Not IsNumeric(TextBox_id.Text) Then
            MsgBox("يرجى إدخال رقم معرف صحيح", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM users_table WHERE user_id = @id", conn)
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox_id.Text))
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' تعبئة الحقول
                TextBox_nameuser.Text = reader("user_name").ToString()
                TextBox_passuser1.Text = reader("user_password").ToString()
                TextBox_passuser2.Text = reader("user_password").ToString()

                Dim validity As Boolean = Convert.ToBoolean(reader("user_validity"))
                If validity Then
                    Radio_admin.Checked = True
                Else
                    Radio_employee.Checked = True
                End If
            Else
                MsgBox("لم يتم العثور على مستخدم بهذا الرقم", MsgBoxStyle.Information)
                clear()
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("حدث خطأ أثناء جلب البيانات: " & ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
        Button_add.Visible = True
        Button_delete.Visible = True
        Button_edit.Visible = True
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


    'زر اظهار  بيانات الممستخدم عند النقر على الصف
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBox_id.Text = row.Cells("user_id").Value.ToString()
            TextBox_nameuser.Text = row.Cells("user_name").Value.ToString()
            TextBox_passuser1.Text = row.Cells("user_password").Value.ToString()
            TextBox_passuser2.Text = row.Cells("user_password").Value.ToString()

            Dim validity As Boolean = Convert.ToBoolean(row.Cells("user_validity").Value)
            If validity Then
                Radio_admin.Checked = True
            Else
                Radio_employee.Checked = True
            End If
        End If
    End Sub

    Private Sub user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllUsers()
    End Sub
End Class














