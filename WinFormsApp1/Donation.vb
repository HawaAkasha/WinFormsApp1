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

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged

    End Sub
End Class
