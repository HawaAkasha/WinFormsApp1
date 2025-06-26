

Imports System.Data.SqlClient

    Public Class medicalRecord
    Public Property SubscriberID As String
    Public Property SubscriberName As String
    Public Property SubscriberAge As String

    Public Property SubscriberNationalID As String

    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

        Private Sub medicalRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadMedicalRecords()
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

            ' المشتركين اللي عندهم مرض
            Dim cmdSub As New SqlCommand("SELECT National_id, Full_name, Age, has_disease FROM Subscribers_table WHERE has_disease = 'نعم'", conn)
            Dim readerSub As SqlDataReader = cmdSub.ExecuteReader()
                While readerSub.Read()
                    Dim row As DataRow = dt.NewRow()
                    row("National_id") = readerSub("National_id").ToString()
                    row("Patient_id") = "S" & readerSub("National_id").ToString()
                    row("Full_name") = readerSub("Full_name").ToString()
                    row("Age") = readerSub("Age").ToString()
                    row("Disease_type") = "غير محدد"
                    row("Person_type") = "مشترك"
                    dt.Rows.Add(row)
                End While
                readerSub.Close()

                ' أفراد العائلة اللي عندهم مرض
                Dim cmdFam As New SqlCommand("SELECT Subscriber_id, Name, Age, Disease_id FROM Family_table WHERE Disease_id IS NOT NULL AND Disease_id <> ''", conn)
                Dim readerFam As SqlDataReader = cmdFam.ExecuteReader()
                While readerFam.Read()
                    Dim row As DataRow = dt.NewRow()
                    row("National_id") = readerFam("Subscriber_id").ToString()
                    row("Patient_id") = "F" & readerFam("Subscriber_id").ToString() & readerFam("Name").ToString().Substring(0, 1).ToUpper()
                    row("Full_name") = readerFam("Name").ToString()
                    row("Age") = readerFam("Age").ToString()
                    row("Disease_type") = readerFam("Disease_id").ToString()
                    row("Person_type") = "فرد عائلة"
                    dt.Rows.Add(row)
                End While
                readerFam.Close()

                conn.Close()
                DataGridView_Medical.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("❌ خطأ أثناء تحميل السجلات: " & ex.Message)
                conn.Close()
            End Try
        End Sub

        Private Sub DataGridView_Medical_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Medical.CellContentClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridView_Medical.Rows(e.RowIndex)
                suber_id.Text = row.Cells("National_id").Value.ToString()
                patient_name.Text = row.Cells("Full_name").Value.ToString()
                patient_age.Text = row.Cells("Age").Value.ToString()

                ' تفريغ checkboxes أولاً
                CheckBox_sikePressure.Checked = False
                CheckBox_sikeSuger.Checked = False
                CheckBox_sikeSly.Checked = False
                CheckBox_sikeBenignant.Checked = False

                ' تحديد نوع المرض
                Dim diseases As String = row.Cells("Disease_type").Value.ToString()
                If diseases.Contains("ضغط") Then CheckBox_sikePressure.Checked = True
                If diseases.Contains("سكر") Then CheckBox_sikeSuger.Checked = True
                If diseases.Contains("خبيث") Then CheckBox_sikeSly.Checked = True
                If diseases.Contains("حميد") Then CheckBox_sikeBenignant.Checked = True
            End If
        End Sub

        Private Sub Button_patient_save_Click(sender As Object, e As EventArgs) Handles Button_patient_save.Click

        If suber_id.Text = "" Then
                MessageBox.Show("يرجى إدخال رقم المشترك (رقم البطاقة).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                conn.Open()

                ' جلب الاسم والعمر من جدول المشتركين أو العائلة
                Dim name As String = ""
                Dim age As String = ""
                Dim personType As String = ""

                ' أولاً نحاول من جدول المشتركين
                Dim cmd1 As New SqlCommand("SELECT Full_name, Age FROM Subscribers_table WHERE National_id = @nid", conn)
                cmd1.Parameters.AddWithValue("@nid", suber_id.Text)
                Dim reader = cmd1.ExecuteReader()
                If reader.Read() Then
                    name = reader("Full_name").ToString()
                    age = reader("Age").ToString()
                    personType = "مشترك"
                End If
                reader.Close()

                ' إذا لم يوجد، نحاول من جدول العائلة
                If name = "" Then
                    Dim cmd2 As New SqlCommand("SELECT Name, Age FROM Family_table WHERE Subscriber_id = 
                   (SELECT Subscriber_id FROM Subscribers_table WHERE National_id = @nid)", conn)
                    cmd2.Parameters.AddWithValue("@nid", suber_id.Text)
                    Dim reader2 = cmd2.ExecuteReader()
                    If reader2.Read() Then
                        name = reader2("Name").ToString()
                        age = reader2("Age").ToString()
                        personType = "عائلة"
                    End If
                    reader2.Close()
                End If

                If name = "" Then
                    MessageBox.Show("لم يتم العثور على المشترك أو أحد أفراد العائلة بهذا الرقم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conn.Close()
                    Exit Sub
                End If

                ' تجميع الأمراض
                Dim diseaseTypes As String = ""
                If CheckBox_sikePressure.Checked Then diseaseTypes &= "ضغط، "
                If CheckBox_sikeSuger.Checked Then diseaseTypes &= "سكر، "
                If CheckBox_sikeSly.Checked Then diseaseTypes &= "خبيث، "
                If CheckBox_sikeBenignant.Checked Then diseaseTypes &= "حميد، "
                If diseaseTypes.EndsWith("، ") Then diseaseTypes = diseaseTypes.Substring(0, diseaseTypes.Length - 2)

                ' توليد Patient_id تلقائي بترتيب
                Dim cmdMax As New SqlCommand("SELECT ISNULL(MAX(CAST(Patient_id AS INT)), 0) + 1 FROM MedicalRecord_table", conn)
                Dim newPatientID As String = cmdMax.ExecuteScalar().ToString()

            ' إضافة السجل
            Dim insertCmd As New SqlCommand("INSERT INTO MedicaRecord_table (Patient_id ,Age, Disease_type) 
                                             VALUES (@pid, @age, @disease)", conn)
            insertCmd.Parameters.AddWithValue("@pid", newPatientID)

            insertCmd.Parameters.AddWithValue("@age", age)
                insertCmd.Parameters.AddWithValue("@disease", diseaseTypes)

                insertCmd.ExecuteNonQuery()

                MessageBox.Show("✅ تم حفظ السجل الطبي بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()

                LoadMedicalRecords() ' تحميل البيانات من جديد

            Catch ex As Exception
                MessageBox.Show("❌ خطأ أثناء الحفظ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End Try
        End Sub



    Private Sub button_patient_delete_Click(sender As Object, e As EventArgs) Handles Button_patient_delete.Click
            If DataGridView_Medical.SelectedRows.Count = 0 Then
                MessageBox.Show("يرجى تحديد صف لحذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = DataGridView_Medical.SelectedRows(0)
            Dim patientID As String = selectedRow.Cells("Patient_id").Value.ToString()

            If MessageBox.Show("هل أنت متأكد من حذف هذا السجل؟", "تأكيد", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    conn.Open()
                Dim cmd As New SqlCommand("DELETE FROM MedicaRecord  WHERE Patient_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", patientID)
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    MessageBox.Show("✅ تم حذف السجل بنجاح")
                    LoadMedicalRecords()
                Catch ex As Exception
                    MessageBox.Show("❌ خطأ أثناء الحذف: " & ex.Message)
                    conn.Close()
                End Try
            End If
        End Sub

        Private Sub button_patient_close_Click(sender As Object, e As EventArgs) Handles Button_patient_close.Click
            Me.Close()
        End Sub

    End Class