Imports System.Data.SqlClient

Class LOGIN_FORM

    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub LOGIN_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تهيئة واجهة المستخدم عند بدء النموذج
        ResetUI()
        Button_logout.Visible = False
        TextBox_name.Visible = True
        TextBox_password.Visible = True
        Button_login.Visible = True
        Me.AcceptButton = Button_login 'زر الانتر لدخول

    End Sub

    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click

        Dim username As String = TextBox_name.Text.Trim()
        Dim password As String = TextBox_password.Text

        If username = "" Or password = "" Then
            MsgBox("يرجى إدخال اسم المستخدم وكلمة المرور", MsgBoxStyle.Critical, "خطأ")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT user_password, user_validity FROM users_table WHERE LTRIM(RTRIM(user_name)) COLLATE Arabic_CI_AI = @username", conn)
            cmd.Parameters.AddWithValue("@username", username)

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim dbPassword As String = dr("user_password").ToString()
                Dim isAdmin As Boolean = Convert.ToBoolean(dr("user_validity"))
                dr.Close()
                conn.Close()

                If password = dbPassword Then
                    ' كلمة المرور صحيحة

                    ' تعديل الواجهة بعد الدخول
                    Button_login.Visible = False
                    Button_logout.Visible = True
                    TextBox_name.Visible = False
                    TextBox_password.Visible = False

                    ' تعيين الصلاحيات بناءً على isAdmin
                    If isAdmin Then
                        EnableAll()
                        MessageBox.Show("تم تسجيل الدخول كمدير", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        EnableLimited()
                        MessageBox.Show("تم تسجيل الدخول كموظف", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    MsgBox("كلمة المرور غير صحيحة", MsgBoxStyle.Critical, "خطأ")
                    TextBox_password.Clear()
                End If
            Else
                MsgBox("اسم المستخدم غير موجود", MsgBoxStyle.Critical, "خطأ")
                TextBox_name.Clear()
                TextBox_password.Clear()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox("حدث خطأ في الاتصال بقاعدة البيانات: " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try


    End Sub

    Private Sub Button_logout_Click(sender As Object, e As EventArgs) Handles Button_logout.Click
        ' إعادة تعيين الواجهة للوضع قبل تسجيل الدخول
        ResetUI()
        TextBox_name.Clear()
        TextBox_password.Clear()
        TextBox_name.Visible = True
        TextBox_password.Visible = True
        Button_login.Visible = True
        Button_logout.Visible = False
        MessageBox.Show("تم تسجيل الخروج بنجاح", "خروج", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ResetUI()
        Button_users.Enabled = False
        Button_subscriber.Enabled = False
        Button_donor.Enabled = False
        Button_family.Enabled = False
        Button_item.Enabled = False
        Button_need.Enabled = False
        Button_donation.Enabled = False
        Button_medical.Enabled = False
        Button_report.Enabled = False
    End Sub

    Private Sub EnableAll()
        Button_users.Enabled = True
        Button_subscriber.Enabled = True
        Button_donor.Enabled = True
        Button_family.Enabled = True
        Button_item.Enabled = True
        Button_need.Enabled = True
        Button_donation.Enabled = True
        Button_medical.Enabled = True
        Button_report.Enabled = True
    End Sub

    Private Sub EnableLimited()
        Button_users.Enabled = False
        Button_subscriber.Enabled = True
        Button_donor.Enabled = True
        Button_family.Enabled = True
        Button_item.Enabled = True
        Button_need.Enabled = True
        Button_donation.Enabled = True
        Button_medical.Enabled = False
        Button_report.Enabled = True
    End Sub

    ' فتح النماذج المختلفة حسب الأزرار
    Private Sub Button_users_Click(sender As Object, e As EventArgs) Handles Button_users.Click
        user_form.Show()
    End Sub

    Private Sub Button_subscriber_Click(sender As Object, e As EventArgs) Handles Button_subscriber.Click
        Subscriber.Show()
    End Sub

    Private Sub Button_donor_Click(sender As Object, e As EventArgs) Handles Button_donor.Click
        donor.Show()
    End Sub

    Private Sub Button_family_Click(sender As Object, e As EventArgs) Handles Button_family.Click
        family.Show()
    End Sub

    Private Sub Button_item_Click(sender As Object, e As EventArgs) Handles Button_item.Click
        Item.Show()
    End Sub

    Private Sub Button_need_Click(sender As Object, e As EventArgs) Handles Button_need.Click
        needs.Show()
    End Sub

    Private Sub Button_donation_Click(sender As Object, e As EventArgs) Handles Button_donation.Click
        Donation.Show()
    End Sub

    Private Sub Button_report_Click(sender As Object, e As EventArgs) Handles Button_report.Click
        Report.Show()
    End Sub

    Private Sub Button_medical_Click(sender As Object, e As EventArgs) Handles Button_medical.Click
        MedicalRecord.Show()
    End Sub

    Private Sub Button_ShowPassword_Click(sender As Object, e As EventArgs) Handles Button_ShowPassword.Click

        If TextBox_password.UseSystemPasswordChar = True Then
            TextBox_password.UseSystemPasswordChar = False
            Button_ShowPassword.Text = "إخفاء"
        Else
            TextBox_password.UseSystemPasswordChar = True
            Button_ShowPassword.Text = "إظهار"

        End If

    End Sub
End Class
