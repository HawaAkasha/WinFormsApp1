
Imports System.Data.SqlClient

Public Class Donation

    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub Donation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_eat.Visible = False
        TextBox_cloth.Visible = False
        TextBox_medi.Visible = False
        LoadDonations()

    End Sub


    Public Sub LoadDonations()
        Dim dt As New DataTable()

        Try
            conn.Open()

            ' جلب كل المتبرعين مع بيانات تبرعهم إن وُجدت
            Dim query As String = "
       SELECT 
            d.Donor_id,
            d.DonorName,
            d.PhoneNumber,
            i.Item_name,
            t.Donation_type,
            t.quantity,
            t.Donation_date,
            t.Donation_method
        FROM Donors_table d
        LEFT JOIN Donations_table t ON d.Donor_id = t.Donor_id
        LEFT JOIN Item_table i ON t.Item_id = i.Item_id
        ORDER BY d.Donor_id DESC;
        "

            Dim adapter As New SqlDataAdapter(query, conn)
            adapter.Fill(dt)
            conn.Close()

            ' عرضهم في DataGridView
            DataGridView1.DataSource = dt

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء تحميل المتبرعين والتبرعات: " & ex.Message)
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            donor_name.Text = row.Cells("DonorName").Value.ToString()
            donor_number.Text = row.Cells("PhoneNumber").Value.ToString()
            TextBox_quantity.Text = row.Cells("quantity").Value.ToString()

            Dim dtype As String = row.Cells("Donation_type").Value.ToString()
            CheckBox_money.Checked = dtype.Contains("مالي")
            CheckBox_eat.Checked = dtype.Contains("مواد غذائية")
            CheckBox_clothes.Checked = dtype.Contains("ملابس")
            CheckBox_medicine.Checked = dtype.Contains("مستلزمات طبية")

            Dim method As String = row.Cells("Donation_method").Value.ToString()
            cash.Checked = method.Contains("نقدي")
            trance.Checked = method.Contains("تحويل")
            delivery.Checked = method.Contains("توصيل")
        End If
    End Sub

    Private Sub CheckBox_eat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_eat.CheckedChanged
        TextBox_eat.Visible = CheckBox_eat.Checked
    End Sub

    Private Sub CheckBox_clothes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_clothes.CheckedChanged
        TextBox_cloth.Visible = CheckBox_clothes.Checked
    End Sub

    Private Sub CheckBox_medicine_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_medicine.CheckedChanged
        TextBox_medi.Visible = CheckBox_medicine.Checked
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click

        If conn.State = ConnectionState.Closed Then conn.Open()

        Try
            ' تحقق من الحقول الأساسية
            If donor_name.Text = "" Or donor_number.Text = "" Or TextBox_quantity.Text = "" Then
                MessageBox.Show("يرجى تعبئة كل الحقول المطلوبة")
                Exit Sub
            End If

            ' تجهيز اسم المادة
            Dim itemName As String = ""
            If CheckBox_money.Checked Then
                itemName = "مالي"
            ElseIf CheckBox_eat.Checked Then
                itemName = TextBox_eat.Text
            ElseIf CheckBox_clothes.Checked Then
                itemName = TextBox_cloth.Text
            ElseIf CheckBox_medicine.Checked Then
                itemName = TextBox_medi.Text
            Else
                MessageBox.Show("يرجى تحديد نوع التبرع واسم المادة")
                Exit Sub
            End If

            ' تجهيز نوع التبرع
            Dim donationType As String = ""
            If CheckBox_money.Checked Then donationType &= "مالي, "
            If CheckBox_eat.Checked Then donationType &= "مواد غذائية, "
            If CheckBox_clothes.Checked Then donationType &= "ملابس, "
            If CheckBox_medicine.Checked Then donationType &= "مستلزمات طبية, "
            donationType = donationType.TrimEnd(", ".ToCharArray())

            ' تجهيز طريقة التبرع
            Dim method As String = ""
            If cash.Checked Then method &= "نقدي, "
            If trance.Checked Then method &= "تحويل, "
            If delivery.Checked Then method &= "توصيل, "
            method = method.TrimEnd(", ".ToCharArray())

            ' 1. حفظ المادة في Item_table
            Dim itemId As Integer
            Dim itemCmd As New SqlCommand("INSERT INTO Item_table (Item_name, Item_quantity, Item_category, Expir_date)
                                       OUTPUT INSERTED.Item_id
                                       VALUES (@name, @quantity, @category, @expdate)", conn)
            itemCmd.Parameters.AddWithValue("@name", itemName)
            itemCmd.Parameters.AddWithValue("@quantity", CInt(TextBox_quantity.Text))
            itemCmd.Parameters.AddWithValue("@category", donationType)
            itemCmd.Parameters.AddWithValue("@expdate", DateTime.Today)
            itemId = Convert.ToInt32(itemCmd.ExecuteScalar())

            ' 2. حفظ المتبرع في Donors_table (إذا لم يكن موجودًا)
            Dim donorId As Integer
            Dim checkDonorCmd As New SqlCommand("SELECT Donor_id FROM Donors_table WHERE DonorName = @name AND PhoneNumber = @phone", conn)
            checkDonorCmd.Parameters.AddWithValue("@name", donor_name.Text)
            checkDonorCmd.Parameters.AddWithValue("@phone", donor_number.Text)

            Dim result = checkDonorCmd.ExecuteScalar()
            If result IsNot Nothing Then
                donorId = Convert.ToInt32(result)
            Else
                Dim insertDonorCmd As New SqlCommand("INSERT INTO Donors_table (DonorName, PhoneNumber) OUTPUT INSERTED.Donor_id VALUES (@name, @phone)", conn)
                insertDonorCmd.Parameters.AddWithValue("@name", donor_name.Text)
                insertDonorCmd.Parameters.AddWithValue("@phone", donor_number.Text)
                donorId = Convert.ToInt32(insertDonorCmd.ExecuteScalar())
            End If

            ' 3. حفظ التبرع في Donations_table
            Dim donationCmd As New SqlCommand("INSERT INTO Donations_table (Donor_id, Item_id, Donation_type, quantity, Donation_date, Donation_method)
                                           VALUES (@donor, @item, @type, @qty, @date, @method)", conn)
            donationCmd.Parameters.AddWithValue("@donor", donorId)
            donationCmd.Parameters.AddWithValue("@item", itemId)
            donationCmd.Parameters.AddWithValue("@type", donationType)
            donationCmd.Parameters.AddWithValue("@qty", CInt(TextBox_quantity.Text))
            donationCmd.Parameters.AddWithValue("@date", DateTime.Today)
            donationCmd.Parameters.AddWithValue("@method", method)
            donationCmd.ExecuteNonQuery()

            MessageBox.Show("✅ تم تسجيل التبرع بنجاح")

            ' تحديث القريد ڤيو
            LoadDonations()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("❌ خطأ أثناء الإضافة: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        donor_name.Clear()
        donor_number.Clear()
        TextBox_quantity.Clear()
        TextBox_eat.Clear()
        TextBox_cloth.Clear()
        TextBox_medi.Clear()
        CheckBox_money.Checked = False
        CheckBox_eat.Checked = False
        CheckBox_clothes.Checked = False
        CheckBox_medicine.Checked = False
        cash.Checked = False
        trance.Checked = False
        delivery.Checked = False
    End Sub

End Class
