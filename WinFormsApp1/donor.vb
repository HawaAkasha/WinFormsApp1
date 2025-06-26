Imports System.Data.SqlClient

Public Class donor
    ' الاتصال بقاعدة البيانات
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub donor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox_donationtype.Visible = False
        TextBox_cloth.Visible = False
        TextBox_eat.Visible = False
        TextBox_medi.Visible = False
    End Sub

    ' منع إدخال إلا الحروف لاسم المتبرع
    Private Sub donor_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donor_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    ' منع إدخال إلا الأرقام لرقم الهاتف
    Private Sub donor_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donor_number.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' منع إدخال إلا الأرقام لرقم البطاقة
    Private Sub donor_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donor_id.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' منع إدخال إلا الأرقام للكمية
    Private Sub TextBox_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_quantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' إظهار خيارات طرق التبرع عند اختيار مالي
    Private Sub CheckBox_money_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_money.CheckedChanged
        GroupBox_donationtype.Visible = CheckBox_money.Checked
    End Sub

    ' إظهار حقل التفاصيل عند اختيار مواد غذائية
    Private Sub CheckBox_eat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_eat.CheckedChanged
        TextBox_eat.Visible = CheckBox_eat.Checked
    End Sub

    ' إظهار حقل التفاصيل عند اختيار ملابس
    Private Sub CheckBox_clothes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_clothes.CheckedChanged
        TextBox_cloth.Visible = CheckBox_clothes.Checked
    End Sub

    ' إظهار حقل التفاصيل عند اختيار مستلزمات طبية
    Private Sub CheckBox_medicine_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_medicine.CheckedChanged
        TextBox_medi.Visible = CheckBox_medicine.Checked
    End Sub

    ' زر تسجيل التبرع

    Private Sub Button_donation_Click(sender As Object, e As EventArgs) Handles Button_donation.Click
        If donor_name.Text = "" OrElse donor_id.Text = "" OrElse donor_number.Text = "" OrElse TextBox_quantity.Text = "" Then
            MessageBox.Show("يرجى تعبئة جميع الحقول.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' نوع التبرع
        Dim donationType As String = ""
        If CheckBox_money.Checked Then donationType &= "مالي, "
        If CheckBox_eat.Checked Then donationType &= "مواد غذائية, "
        If CheckBox_clothes.Checked Then donationType &= "ملابس, "
        If CheckBox_medicine.Checked Then donationType &= "مستلزمات طبية, "
        donationType = donationType.TrimEnd(", ".ToCharArray())

        ' طرق الدفع
        Dim paymentMethod As String = ""
        If cash.Checked Then paymentMethod &= "نقدي, "
        If delivery.Checked Then paymentMethod &= "توصيل, "
        If trance.Checked Then paymentMethod &= "تحويل, "
        paymentMethod = paymentMethod.TrimEnd(", ".ToCharArray())

        Try
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Donors_table 
            (DonorName, PhoneNumber, DNational_id) 
            VALUES (@name, @nid, @phone)", conn)

            cmd.Parameters.AddWithValue("@name", donor_name.Text)
            cmd.Parameters.AddWithValue("@nid", donor_id.Text)
            cmd.Parameters.AddWithValue("@phone", donor_number.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("تمت إضافة التبرع بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("خطأ أثناء الإضافة: " & ex.Message)
            conn.Close()
        End Try


        '///////////////////////////////////////////////////////////////

        ' فتح شاشة التبرع وتمرير البيانات
        ' بعد إضافة المتبرع إلى قاعدة البيانات
        Dim donationForm As New Donation()

        donationForm.Show()
        donationForm.LoadDonations() ' تحديث القريد فيو مباشرة



        ' Dim donationForm As New Donation()

        ' donationForm.DonorName = donor_name.Text
        ' donationForm.DonorPhone = donor_number.Text
        'donationForm.DonationQuantity = TextBox_quantity.Text

        ' توليد نوع التبرع من CheckBox
        ' Dim donation_type As String = ""
        ' If CheckBox_money.Checked Then donationType &= "مالي, "
        ' If CheckBox_eat.Checked Then donationType &= "مواد غذائية, "
        ' If CheckBox_clothes.Checked Then donationType &= "ملابس, "
        ' If CheckBox_medicine.Checked Then donationType &= "مستلزمات طبية, "
        'donationType = donationType.TrimEnd(", ".ToCharArray())

        'donationForm.DonationType = donationType
        'donationForm.DonationDate = Date.Today

        'donationForm.ShowDialog()







        '//////////////////////////////////////////////
    End Sub

    ' زر حذف المتبرع
    'مرات نلغيه
    ' Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
    '    If donor_id.Text = "" Then
    '   MessageBox.Show("يرجى إدخال رقم البطاقة لحذف المتبرع.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '   Exit Sub
    '   End If

    '  Try
    '  conn.Open()
    '  Dim cmd As New SqlCommand("DELETE FROM Donors_table WHERE Donor_id = @Donor_id", conn)
    '  cmd.Parameters.AddWithValue("@Donor_id", donor_id.Text)

    ' Dim rows = cmd.ExecuteNonQuery()
    '  conn.Close()

    ' If rows > 0 Then
    ' MessageBox.Show("تم حذف المتبرع بنجاح.", "نجاح")
    ' ClearFields()
    ''  Else
    '  MessageBox.Show("لم يتم العثور على متبرع بهذا الرقم.", "معلومة")
    '  End If

    '  Catch ex As Exception
    '   MessageBox.Show("خطأ في الحذف: " & ex.Message)
    ' conn.Close()
    'End Try
    ' End Sub

    ' تصفير الحقول
    Private Sub ClearFields()
        donor_name.Clear()
        donor_number.Clear()
        donor_id.Clear()
        TextBox_quantity.Clear()
        TextBox_cloth.Clear()
        TextBox_eat.Clear()
        TextBox_medi.Clear()
        CheckBox_money.Checked = False
        CheckBox_eat.Checked = False
        CheckBox_clothes.Checked = False
        CheckBox_medicine.Checked = False
        cash.Checked = False
        trance.Checked = False
        delivery.Checked = False
        GroupBox_donationtype.Visible = False
        TextBox_cloth.Visible = False
        TextBox_eat.Visible = False
        TextBox_medi.Visible = False
    End Sub


End Class