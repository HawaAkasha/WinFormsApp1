Imports System.Data.SqlClient

Public Class family
    Public Property SubscriberID As String
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' التحقق من البيانات
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtAge.Text) OrElse
           String.IsNullOrWhiteSpace(txtRelation.Text) Then

            MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' التحقق من الإعاقة
        If CheckBox_sikeHindring.Checked AndAlso String.IsNullOrWhiteSpace(txtDisabiltyType.Text) Then
            MessageBox.Show("يرجى إدخال نوع الإعاقة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' تجميع نوع المرض
        Dim diseaseTypes As String = ""
        If CheckBox_sikePressure.Checked Then diseaseTypes &= "ضغط، "
        If CheckBox_sikeSuger.Checked Then diseaseTypes &= "سكر، "
        If CheckBox_sikeHindring.Checked Then diseaseTypes &= "إعاقة: " & txtDisabiltyType.Text & "، "
        If CheckBox_sikeSly.Checked Then diseaseTypes &= "أمراض خبيثة، "
        If CheckBox_sikeBenignant.Checked Then diseaseTypes &= "أمراض حميدة، "
        If diseaseTypes.EndsWith("، ") Then diseaseTypes = diseaseTypes.Substring(0, diseaseTypes.Length - 2)

        ' الحالة الوظيفية
        Dim employmentStatus As String = ""
        If rdoWorks.Checked Then
            employmentStatus = "يعمل"
        ElseIf rdoDoesNotWork.Checked Then
            employmentStatus = "لا يعمل"
        End If

        Try
            Dim cmd As New SqlCommand("INSERT INTO Family_table (Subscriber_id, Name, Age, Relationship, Disease_id, Employmentstatus)
                                       VALUES (@Subscriber_id, @Name, @Age, @Relationship, @Disease_id, @Employmentstatus)", conn)

            cmd.Parameters.AddWithValue("@Subscriber_id", SubscriberID)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text))
            cmd.Parameters.AddWithValue("@Relationship", txtRelation.Text)
            cmd.Parameters.AddWithValue("@Disease_id", diseaseTypes)
            cmd.Parameters.AddWithValue("@Employmentstatus", employmentStatus)


            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("✅ تم حفظ أفراد العائلة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearFields()

        Catch ex As Exception
            MessageBox.Show("❌ خطأ أثناء حفظ بيانات العائلة: " & ex.Message)
            conn.Close()
        End Try
        ' بعد حفظ بيانات الفرد، نتحقق هل عنده مرض
        ' إذا تم إدخال مرض → افتح سجل طبي تلقائيًا
        ' بعد حفظ بيانات الفرد، نتحقق هل عنده مرض
        If CheckBox_sikePressure.Checked Or CheckBox_sikeSuger.Checked Or CheckBox_sikeSly.Checked Or CheckBox_sikeBenignant.Checked Then
            Dim medical As New medicalRecord()
            medical.SubscriberID = SubscriberID
            medical.SubscriberName = txtName.Text
            medical.SubscriberAge = txtAge.Text
            ' medical.ShowDialog()
            '/////////////////////////////
            '  medicalRecord.SubscriberNationalID = sup_id.Text  ' أو أي TextBox فيه National_id
            ' medicalRecord.ShowDialog()
        End If
    End Sub

    ' دالة لتصفير الحقول
    Sub clearFields()
        txtName.Clear()
        txtAge.Clear()
        txtRelation.Clear()
        txtTreatmentType.Clear()
        txtNotes.Clear()
        txtDisabiltyType.Clear()

        CheckBox_sikePressure.Checked = False
        CheckBox_sikeSuger.Checked = False
        CheckBox_sikeHindring.Checked = False
        CheckBox_sikeSly.Checked = False
        CheckBox_sikeBenignant.Checked = False

        rdoWorks.Checked = False
        rdoDoesNotWork.Checked = False

        rdoTreatmentYes.Checked = False
        rdoTreatmentNo.Checked = False
        rdoSupportYes.Checked = False
        rdoSupportNo.Checked = False
    End Sub

    Private Sub CheckBox_sikeHindring_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_sikeHindring.CheckedChanged
        txtDisabiltyType.Visible = CheckBox_sikeHindring.Checked
    End Sub

    Private Sub family_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisabiltyType.Visible = False
        clearFields()
        rdoSupportYes.Checked = False
        rdoSupportNo.Checked = False
    End Sub

    Private Sub rdoWorks_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWorks.CheckedChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub
End Class


