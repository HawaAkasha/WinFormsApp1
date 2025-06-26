Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles
Public Class Donation
    Private Sub Donation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDonations()

    End Sub
    Public Sub LoadDonations()
        Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim da As New SqlDataAdapter("SELECT DonorName, PhoneNumber, GETDATE() AS DonationDate FROM Donors_table", conn)
            da.Fill(dt)
            conn.Close()

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل التبرعات: " & ex.Message)
        End Try
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' تعبئة TextBoxes
            donor_name.Text = row.Cells("DonorName").Value.ToString()
            donor_number.Text = row.Cells("PhoneNumber").Value.ToString()
            TextBox_quantity.Text = row.Cells("quantity").Value.ToString()

            ' تعبئة CheckBoxes لنوع التبرع
            Dim dtype As String = row.Cells("Donation_type").Value.ToString()
            CheckBox_money.Checked = dtype.Contains("مالي")
            CheckBox_eat.Checked = dtype.Contains("مواد غذائية")
            CheckBox_clothes.Checked = dtype.Contains("ملابس")
            CheckBox_medicine.Checked = dtype.Contains("مستلزمات طبية")

            ' تعبئة CheckBoxes لطريقة التبرع
            Dim method As String = row.Cells("Donation_method").Value.ToString()
            cash.Checked = method.Contains("نقدي")
            trance.Checked = method.Contains("تحويل")
            delivery.Checked = method.Contains("توصيل")
        End If
    End Sub
End Class
