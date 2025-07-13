
Imports System.Data.SqlClient

Public Class medicalRecord
    Public Property SubscriberID As String
    Public Property SubscriberName As String
    Public Property SubscriberAge As String
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub medicalRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicalRecords()
        TextBox_istability.Visible = False
    End Sub

    Private Sub LoadMedicalRecords()
        Try
            conn.Open()
            Dim dt As New DataTable()
            dt.Columns.Add("National_id")
            dt.Columns.Add("Patient_id")
            dt.Columns.Add("Full_name")
            dt.Columns.Add("Age")
            dt.Columns.Add("Disease_type")
            dt.Columns.Add("Person_type")

            ' المشتركين
            Dim cmd1 As New SqlCommand("SELECT National_id, Full_name, Age FROM Subscribers_table WHERE has_disease = 'نعم'", conn)
            Dim r1 = cmd1.ExecuteReader()
            While r1.Read()
                Dim row = dt.NewRow()
                row("National_id") = r1("National_id")
                row("Patient_id") = "S" & r1("National_id")
                row("Full_name") = r1("Full_name")
                row("Age") = r1("Age")
                row("Disease_type") = "غير محدد"
                row("Person_type") = "مشترك"
                dt.Rows.Add(row)
            End While
            r1.Close()

            ' أفراد العائلة
            Dim cmd2 As New SqlCommand("SELECT Subscriber_id, Name, Age, Disease_id FROM Family_table WHERE Disease_id IS NOT NULL AND Disease_id <> ''", conn)
            Dim r2 = cmd2.ExecuteReader()
            While r2.Read()
                Dim row = dt.NewRow()
                row("National_id") = r2("Subscriber_id")
                row("Patient_id") = "F" & r2("Subscriber_id") & r2("Name").ToString().Substring(0, 1).ToUpper()
                row("Full_name") = r2("Name")
                row("Age") = r2("Age")
                row("Disease_type") = r2("Disease_id")
                row("Person_type") = "فرد عائلة"
                dt.Rows.Add(row)
            End While
            r2.Close()

            conn.Close()
            DataGridView_Medical.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("خطأ في التحميل: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView_Medical_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Medical.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView_Medical.Rows(e.RowIndex)
            suber_id.Text = row.Cells("National_id").Value.ToString()
            patient_name.Text = row.Cells("Full_name").Value.ToString()
            patient_age.Text = row.Cells("Age").Value.ToString()

            ' مسح التحديد
            CheckBox_sikePressure.Checked = False
            CheckBox_sikeSuger.Checked = False
            CheckBox_sikeSly.Checked = False
            CheckBox_sikeBenignant.Checked = False

            Dim diseases = row.Cells("Disease_type").Value.ToString()
            If diseases.Contains("ضغط") Then CheckBox_sikePressure.Checked = True
            If diseases.Contains("سكر") Then CheckBox_sikeSuger.Checked = True
            If diseases.Contains("خبيث") Then CheckBox_sikeSly.Checked = True
            If diseases.Contains("حميد") Then CheckBox_sikeBenignant.Checked = True
        End If
    End Sub

    Private Sub Button_patient_save_Click(sender As Object, e As EventArgs) Handles Button_patient_save.Click
        If suber_id.Text = "" Then
            MessageBox.Show("أدخل رقم البطاقة أولاً")
            Return
        End If

        Try
            conn.Open()
            Dim name As String = ""
            Dim age As String = ""
            Dim personType As String = ""

            ' المشترك
            Dim cmd1 As New SqlCommand("SELECT Full_name, Age FROM Subscribers_table WHERE National_id = @nid", conn)
            cmd1.Parameters.AddWithValue("@nid", suber_id.Text)
            Dim r1 = cmd1.ExecuteReader()
            If r1.Read() Then
                name = r1("Full_name")
                age = r1("Age")
                personType = "مشترك"
            End If
            r1.Close()

            ' لو مش موجود، ابحث في أفراد العائلة
            If name = "" Then
                Dim cmd2 As New SqlCommand("SELECT Name, Age FROM Family_table WHERE Subscriber_id = @nid", conn)
                cmd2.Parameters.AddWithValue("@nid", suber_id.Text)
                Dim r2 = cmd2.ExecuteReader()
                If r2.Read() Then
                    name = r2("Name")
                    age = r2("Age")
                    personType = "فرد عائلة"
                End If
                r2.Close()
            End If

            If name = "" Then
                MessageBox.Show("المشترك غير موجود")
                conn.Close()
                Return
            End If

            ' تحديد نوع المرض
            Dim diseases As String = ""
            If CheckBox_sikePressure.Checked Then diseases &= "ضغط، "
            If CheckBox_sikeSuger.Checked Then diseases &= "سكر، "
            If CheckBox_sikeSly.Checked Then diseases &= "خبيث، "
            If CheckBox_sikeBenignant.Checked Then diseases &= "حميد، "
            If diseases.EndsWith("، ") Then diseases = diseases.Substring(0, diseases.Length - 2)

            ' توليد رقم المريض
            Dim cmdMax As New SqlCommand("SELECT ISNULL(MAX(CAST(Patient_id AS INT)), 0) + 1 FROM MedicaRecord", conn)
            Dim pid = cmdMax.ExecuteScalar().ToString()

            ' إضافة في السجل
            Dim cmdInsert As New SqlCommand("INSERT INTO MedicaRecord (Patient_id, Age, Disease_type) VALUES (@pid, @age, @disease)", conn)
            cmdInsert.Parameters.AddWithValue("@pid", pid)
            cmdInsert.Parameters.AddWithValue("@age", age)
            cmdInsert.Parameters.AddWithValue("@disease", diseases)
            cmdInsert.ExecuteNonQuery()

            ' تحديث جدول الحالة
            If personType = "مشترك" Then
                Dim cmdU As New SqlCommand("UPDATE Subscribers_table SET has_disease = 'نعم' WHERE National_id = @nid", conn)
                cmdU.Parameters.AddWithValue("@nid", suber_id.Text)
                cmdU.ExecuteNonQuery()
            Else
                Dim cmdU As New SqlCommand("UPDATE Family_table SET Disease_id = @disease WHERE Subscriber_id = @nid", conn)
                cmdU.Parameters.AddWithValue("@nid", suber_id.Text)
                cmdU.Parameters.AddWithValue("@disease", diseases)
                cmdU.ExecuteNonQuery()
            End If

            conn.Close()
            MessageBox.Show("تم الحفظ بنجاح")
            LoadMedicalRecords()

        Catch ex As Exception
            MessageBox.Show("خطأ أثناء الحفظ: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub button_patient_delete_Click(sender As Object, e As EventArgs) Handles Button_patient_delete.Click
        If DataGridView_Medical.SelectedRows.Count = 0 Then
            MessageBox.Show("اختر صفًا للحذف")
            Return
        End If

        Dim row = DataGridView_Medical.SelectedRows(0)
        Dim nid = row.Cells("National_id").Value.ToString()
        Dim type = row.Cells("Person_type").Value.ToString()

        If MessageBox.Show("تأكيد حذف السجل؟", "تأكيد", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                conn.Open()
                If type = "مشترك" Then
                    Dim cmd = New SqlCommand("UPDATE Subscribers_table SET has_disease = 'لا' WHERE National_id = @nid", conn)
                    cmd.Parameters.AddWithValue("@nid", nid)
                    cmd.ExecuteNonQuery()
                Else
                    Dim cmd = New SqlCommand("UPDATE Family_table SET Disease_id = '' WHERE Subscriber_id = @nid", conn)
                    cmd.Parameters.AddWithValue("@nid", nid)
                    cmd.ExecuteNonQuery()
                End If
                conn.Close()
                MessageBox.Show("تم الحذف")
                LoadMedicalRecords()
            Catch ex As Exception
                MessageBox.Show("خطأ في الحذف: " & ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub CheckBox_sikeHindring_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_sikeHindring.CheckedChanged
        TextBox_istability.Visible = CheckBox_sikeHindring.Checked
    End Sub

    Private Sub button_patient_close_Click(sender As Object, e As EventArgs) Handles Button_patient_close.Click
        Me.Close()
    End Sub
End Class