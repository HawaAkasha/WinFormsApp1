'Imports System.Data.SqlClient

Imports System.Security.Cryptography.X509Certificates

Class LOGIN_FORM

    Public id As Integer ' رمز المستخدم، غير ضروري هنا لكن نتركه
    Public userType As String ' لتحديد الصلاحية: "مدير" أو "موظف"

    ' Dim con As New SqlConnection("Data Source =DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True") 'connection




    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click

        Dim username As String = TextBox_name.Text.Trim().ToLower()
        Dim password As String = TextBox_password.Text

        ' تحقق يدوي من اسم المستخدم وكلمة المرور
        If username = "admin" And password = "admin123" Then
            ' userType = "مدير"
        ElseIf username = "emp" And password = "emp123" Then
            'userType = "موظف"
        Else
            MsgBox("اسم المستخدم أو كلمة المرور غير صحيحة", MsgBoxStyle.Critical, "خطأ")
            TextBox_name.Clear()
            TextBox_password.Clear()
            Exit Sub
        End If

        ' تعديل الواجهة بعد الدخول
        Button_login.Visible = False
        Button_logout.Visible = True
        TextBox_name.Visible = False
        TextBox_password.Visible = False

        ' تعيين الصلاحيات
        If username = "admin" Then
            EnableAll()
            ' Else
            ' EnableLimited()

        End If
        If username = "emp" Then
            EnableLimited()
        End If
        'Me.AcceptButton = Button_login
        ' ResetUI()
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


    Private Sub Button_subscriber_Click(sender As Object, e As EventArgs) Handles Button_subscriber.Click
        Subscriber.Show()
    End Sub



    Private Sub Button_users_Click(sender As Object, e As EventArgs) Handles Button_users.Click
        user_form.Show()
    End Sub
    Private Sub Button_logout_Click(sender As Object, e As EventArgs) Handles Button_logout.Click
        ResetUI()
        TextBox_name.Clear()
        TextBox_password.Clear()
        TextBox_name.Visible = True
        TextBox_password.Visible = True
        Button_login.Visible = True
        Button_logout.Visible = False
    End Sub

    Private Sub LOGIN_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetUI()

        TextBox_name.Visible = True
        TextBox_password.Visible = True
        Button_login.Visible = True
        Button_logout.Visible = True
    End Sub
End Class
