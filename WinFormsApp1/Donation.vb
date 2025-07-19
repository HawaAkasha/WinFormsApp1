
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

            ' جلب المتبرعين مع تبرعاتهم واسم المادة
            Dim query As String = " SELECT
            d.Donor_id,
            d.DonorName,
            d.PhoneNumber,
            i.Item_name AS Item_name,
            t.Donation_type AS Donation_type,
            t.quantity AS quantity,
            t.Donation_method AS Donation_method
        FROM Donors_table d
        LEFT JOIN Donations_table t ON t.Donor_id = d.Donor_id
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

        Try
            If donor_name.Text = "" Or TextBox_quantity.Text = "" Then
                MessageBox.Show("يرجى تعبئة الحقول الأساسية")
                Exit Sub
            End If



            ' تحديد اسم المادة
            Dim itemNames As New List(Of String)
            If CheckBox_money.Checked Then itemNames.Add("مالي")
            If CheckBox_eat.Checked Then itemNames.Add(TextBox_eat.Text)
            If CheckBox_clothes.Checked Then itemNames.Add(TextBox_cloth.Text)
            If CheckBox_medicine.Checked Then itemNames.Add(TextBox_medi.Text)
            Dim itemName As String = String.Join(", ", itemNames)


            ' نوع التبرع
            Dim dType As String = ""
            If CheckBox_money.Checked Then dType &= "مالي, "
            If CheckBox_eat.Checked Then dType &= "مواد غذائية, "
            If CheckBox_clothes.Checked Then dType &= "ملابس, "
            If CheckBox_medicine.Checked Then dType &= "مستلزمات طبية, "
            dType = dType.TrimEnd(", ".ToCharArray())

            ' طريقة التبرع
            Dim dMethod As String = ""
            If cash.Checked Then dMethod &= "نقدي, "
            If trance.Checked Then dMethod &= "تحويل, "
            If delivery.Checked Then dMethod &= "توصيل, "
            dMethod = dMethod.TrimEnd(", ".ToCharArray())

            ' 1. إضافة المادة
            Dim itemId As Integer
            Dim cmdItem As New SqlCommand("INSERT INTO Item_table (Item_name, Item_quantity, Item_category, Expir_date) 
                                     OUTPUT INSERTED.Item_id 
                                     VALUES (@name, @qty, @cat, @exp)", conn)
            cmdItem.Parameters.AddWithValue("@name", itemName)
            cmdItem.Parameters.AddWithValue("@qty", TextBox_quantity.Text)
            cmdItem.Parameters.AddWithValue("@cat", dType)
            cmdItem.Parameters.AddWithValue("@exp", DateTime.Today)

            conn.Open()
            itemId = CInt(cmdItem.ExecuteScalar())

            ' 2. إضافة التبرع
            Dim cmdDon As New SqlCommand("INSERT INTO Donations_table (Item_id, Donation_type, quantity, Donation_date, Donation_method)
                                    VALUES (@itemId, @type, @qty, @date, @method)", conn)
            cmdDon.Parameters.AddWithValue("@itemId", itemId)
            cmdDon.Parameters.AddWithValue("@type", dType)
            cmdDon.Parameters.AddWithValue("@qty", TextBox_quantity.Text)
            cmdDon.Parameters.AddWithValue("@date", DateTime.Today)
            cmdDon.Parameters.AddWithValue("@method", dMethod)
            cmdDon.ExecuteNonQuery()

            conn.Close()
            MessageBox.Show("✔️ تم تسجيل التبرع بنجاح")
            ClearFields()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ: " & ex.Message)
        End Try

        LoadDonations()
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

    Private Sub Button_edit_don_Click(sender As Object, e As EventArgs) Handles Button_edit_don.Click

        Try
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("يرجى اختيار صف لتعديله.")
                Exit Sub
            End If

            ' استخراج المعرفات
            Dim donorId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Donor_id").Value)
            Dim itemName As String = DataGridView1.SelectedRows(0).Cells("Item_name").Value.ToString()
            Dim itemId As Integer = 0


            Dim getItemIdQuery As String = "SELECT TOP 1 Item_id FROM Item_table WHERE Item_name = @name ORDER BY Item_id DESC"
            Using getItemCmd As New SqlCommand(getItemIdQuery, conn)
                getItemCmd.Parameters.AddWithValue("@name", itemName)
                conn.Open()
                itemId = Convert.ToInt32(getItemCmd.ExecuteScalar())
                conn.Close()
            End Using

            ' نتعديل بيانات المتبرعي)
            If Not String.IsNullOrWhiteSpace(donor_name.Text) Then
                Using cmd As New SqlCommand("UPDATE Donors_table SET DonorName = @name WHERE Donor_id = @id", conn)
                    cmd.Parameters.AddWithValue("@name", donor_name.Text)
                    cmd.Parameters.AddWithValue("@id", donorId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End If

            If Not String.IsNullOrWhiteSpace(donor_number.Text) Then
                Using cmd As New SqlCommand("UPDATE Donors_table SET PhoneNumber = @phone WHERE Donor_id = @id", conn)
                    cmd.Parameters.AddWithValue("@phone", donor_number.Text)
                    cmd.Parameters.AddWithValue("@id", donorId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End If

            ' تجهيز بيانات التبرع (نوعه وطريقته)
            Dim donationType As String = ""
            If CheckBox_money.Checked Then donationType &= "مالي, "
            If CheckBox_eat.Checked Then donationType &= "مواد غذائية, "
            If CheckBox_clothes.Checked Then donationType &= "ملابس, "
            If CheckBox_medicine.Checked Then donationType &= "مستلزمات طبية, "
            donationType = donationType.TrimEnd(", ".ToCharArray())

            Dim method As String = ""
            If cash.Checked Then method &= "نقدي, "
            If trance.Checked Then method &= "تحويل, "
            If delivery.Checked Then method &= "توصيل, "
            method = method.TrimEnd(", ".ToCharArray())

            ' تعديل التبرع
            Using cmd As New SqlCommand("
            UPDATE Donations_table
            SET 
                Donation_type = COALESCE(NULLIF(@type, ''), Donation_type),
                quantity = COALESCE(NULLIF(@qty, ''), quantity),
                Donation_method = COALESCE(NULLIF(@method, ''), Donation_method)
            WHERE Donor_id = @donorId AND Item_id = @itemId", conn)

                cmd.Parameters.AddWithValue("@type", donationType)
                cmd.Parameters.AddWithValue("@qty", If(String.IsNullOrWhiteSpace(TextBox_quantity.Text), DBNull.Value, TextBox_quantity.Text))
                cmd.Parameters.AddWithValue("@method", method)
                cmd.Parameters.AddWithValue("@donorId", donorId)
                cmd.Parameters.AddWithValue("@itemId", itemId)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("✔️ تم تعديل التبرع بنجاح.")

            ClearFields()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء التعديل: " & ex.Message)
        End Try
        LoadDonations()
    End Sub

End Class
