Imports System.Data.SqlClient
Imports FastReport.Utils.CompilerException

Public Class donor

    ' الاتصال بقاعدة البيانات
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub donor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox_donationtype.Visible = False
        TextBox_cloth.Visible = False
        TextBox_eat.Visible = False
        TextBox_medi.Visible = False
        delivery.Visible = False
        Label_delivery.Visible = False
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
        Label_money.Visible = CheckBox_money.Checked
        Label_trance.Visible = CheckBox_money.Checked
    End Sub

    ' إظهار حقل التفاصيل عند اختيار مواد غذائية
    Private Sub CheckBox_eat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_eat.CheckedChanged
        TextBox_eat.Visible = CheckBox_eat.Checked
        delivery.Visible = CheckBox_eat.Checked
        Label_delivery.Visible = CheckBox_eat.Checked
    End Sub

    ' إظهار حقل التفاصيل عند اختيار ملابس
    Private Sub CheckBox_clothes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_clothes.CheckedChanged
        TextBox_cloth.Visible = CheckBox_clothes.Checked
        delivery.Visible = CheckBox_clothes.Checked
        Label_delivery.Visible = CheckBox_clothes.Checked
    End Sub

    ' إظهار حقل التفاصيل عند اختيار مستلزمات طبية
    Private Sub CheckBox_medicine_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_medicine.CheckedChanged
        TextBox_medi.Visible = CheckBox_medicine.Checked
        delivery.Visible = CheckBox_medicine.Checked
        Label_delivery.Visible = CheckBox_medicine.Checked
    End Sub

    ' زر تسجيل التبرع


    Private Sub Button_donation_Click(sender As Object, e As EventArgs) Handles Button_donation.Click
        ' التحقق من الحقول الأساسية
        ' If donor_name.Text = "" OrElse donor_id.Text = "" OrElse donor_number.Text = "" OrElse TextBox_quantity.Text = "" Then
        'MessageBox.Show("يرجى تعبئة جميع الحقول.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'Exit Sub
        ' End If

        ' تحديد نوع التبرع
        Dim donationType As String = ""
        If CheckBox_money.Checked Then donationType &= "مالي، "
        If CheckBox_eat.Checked Then donationType &= "مواد غذائية، "
        If CheckBox_clothes.Checked Then donationType &= "ملابس، "
        If CheckBox_medicine.Checked Then donationType &= "مستلزمات طبية، "
        donationType = donationType.TrimEnd(", ".ToCharArray())

        ' تحديد طريقة الدفع
        Dim paymentMethod As String = ""
        If cash.Checked Then paymentMethod &= "نقدي، "
        If trance.Checked Then paymentMethod &= "تحويل، "
        If delivery.Checked Then paymentMethod &= "توصيل، "
        paymentMethod = paymentMethod.TrimEnd(", ".ToCharArray())

        ' تحديد اسم المادة
        Dim itemNameForDB As String = ""
        If CheckBox_money.Checked Then
            itemNameForDB = "تبرع مالي"
        ElseIf CheckBox_eat.Checked Then
            itemNameForDB = If(TextBox_eat.Text.Trim <> "", TextBox_eat.Text, "مواد غذائية")
        ElseIf CheckBox_clothes.Checked Then
            itemNameForDB = If(TextBox_cloth.Text.Trim <> "", TextBox_cloth.Text, "ملابس")
        ElseIf CheckBox_medicine.Checked Then
            itemNameForDB = If(TextBox_medi.Text.Trim <> "", TextBox_medi.Text, "مستلزمات طبية")
        Else
            itemNameForDB = "غير محدد"
        End If

        ' التحقق من أن الكمية رقم صحيح
        Dim quantity As Integer
        If Not Integer.TryParse(TextBox_quantity.Text, quantity) Then
            MessageBox.Show("⚠️ يرجى إدخال رقم صحيح في خانة الكمية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim donorId As Integer = -1
        Dim itemId As Integer = -1

        Try
            ' 1. إضافة المتبرع
            conn.Open()
            Dim cmdDonor As New SqlCommand("
            INSERT INTO Donors_table (DonorName, PhoneNumber, DNational_id)
            OUTPUT INSERTED.Donor_id
            VALUES (@name, @phone, @nid)", conn)

            cmdDonor.Parameters.AddWithValue("@name", donor_name.Text)
            cmdDonor.Parameters.AddWithValue("@phone", donor_number.Text)
            cmdDonor.Parameters.AddWithValue("@nid", donor_id.Text)

            donorId = CInt(cmdDonor.ExecuteScalar())
            conn.Close()

            ' 2. أضف المادة
            conn.Open()
            Dim cmdItem As New SqlCommand("
            INSERT INTO Item_table (Item_name, Item_quantity, Item_category, Expir_date)
            OUTPUT INSERTED.Item_id
            VALUES (@Item_name, @qty, @cat, @exp)", conn)

            cmdItem.Parameters.AddWithValue("@Item_name", itemNameForDB) ' ✅ اسم المادة الصحيح
            cmdItem.Parameters.AddWithValue("@qty", quantity)
            cmdItem.Parameters.AddWithValue("@cat", donationType)
            cmdItem.Parameters.AddWithValue("@exp", Date.Today)

            itemId = CInt(cmdItem.ExecuteScalar()) ' ✅ استرجاع Item_id
            conn.Close()

            ' 3. سجل في جدول التبرعات
            conn.Open()
            Dim cmdDonation As New SqlCommand("
            INSERT INTO Donations_table (Donor_id, Item_id,Donation_type, quantity, Donation_date, Donation_method)
            VALUES (@Donor_id, @Item_id, @type, @qty, @date, @method)", conn)


            cmdDonation.Parameters.AddWithValue("@Donor_id", donorId)
            cmdDonation.Parameters.AddWithValue("@Item_id", itemId)
            cmdDonation.Parameters.AddWithValue("@type", donationType)
            cmdDonation.Parameters.AddWithValue("@qty", quantity)
            cmdDonation.Parameters.AddWithValue("@date", Date.Today)
            cmdDonation.Parameters.AddWithValue("@method", paymentMethod)

            cmdDonation.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("✔️ تم إضافة المتبرع والتبرع بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

            ' تحديث الشاشة
            Dim donationForm As New Donation()
            donationForm.LoadDonations()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء الإضافة: " & ex.Message)
        End Try
    End Sub

    '///////////////////////////////////////////////////////////////




    '//////////////////////////////////////////////




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

    Private Sub Label_money_Click(sender As Object, e As EventArgs) Handles Label_money.Click

    End Sub
End Class