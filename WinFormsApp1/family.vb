Public Class family


    ' زر التسجيل
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtAge.Text) OrElse
           String.IsNullOrWhiteSpace(txtRelation.Text) OrElse
           Not (rdoWorks.Checked Or rdoDoesNotWork.Checked) OrElse
           Not (rdoTreatmentYes.Checked Or rdoTreatmentNo.Checked) OrElse
           Not (rdoSupportYes.Checked Or rdoSupportNo.Checked) OrElse
           String.IsNullOrWhiteSpace(txtTreatmentType.Text) OrElse
           String.IsNullOrWhiteSpace(txtDiseaseDetails.Text) Then

            MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' إذا تم اختيار "إعاقة" يجب إدخال نوع الإعاقة
        If CheckBox_sikeHindring.Checked AndAlso String.IsNullOrWhiteSpace(txtDisabiltyType.Text) Then
            MessageBox.Show("يرجى إدخال نوع الإعاقة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim name As String = txtName.Text
        Dim age As String = txtAge.Text
        Dim relation As String = txtRelation.Text
        Dim employmentStatus As String = If(rdoWorks.Checked, "يعمل", "لا يعمل")
        Dim receivesTreatment As String = If(rdoTreatmentYes.Checked, "نعم", "لا")
        Dim needsSupport As String = If(rdoSupportYes.Checked, "نعم", "لا")
        Dim treatmentType As String = txtTreatmentType.Text
        Dim notes As String = txtNotes.Text
        Dim diseaseDetails As String = txtDiseaseDetails.Text

        ' تجميع الأمراض المحددة
        Dim diseaseTypes As String = ""
        If CheckBox_sikePressure.Checked Then diseaseTypes &= "ضغط، "
        If CheckBox_sikeSuger.Checked Then diseaseTypes &= "سكر، "
        If CheckBox_sikeHindring.Checked Then diseaseTypes &= "إعاقة، "
        If CheckBox_sikeSly.Checked Then diseaseTypes &= "أمراض خبيثة، "
        If CheckBox_sikeBenignant.Checked Then diseaseTypes &= "أمراض حميدة، "

        If diseaseTypes.EndsWith("، ") Then
            diseaseTypes = diseaseTypes.Substring(0, diseaseTypes.Length - 2)
        End If

        ' مثال: عرض البيانات في MessageBox (يمكن استبدالها بعملية إدخال قاعدة بيانات)
        MessageBox.Show("تم تسجيل المريض بنجاح:" & vbCrLf &
                    "الاسم: " & name & vbCrLf &
                    "العمر: " & age & vbCrLf &
                    "القرابة: " & relation & vbCrLf &
                    "الحالة الوظيفية: " & employmentStatus & vbCrLf &
                    "يتلقى علاج: " & receivesTreatment & vbCrLf &
                    "يحتاج دعم: " & needsSupport & vbCrLf &
                    "نوع العلاج: " & treatmentType & vbCrLf &
                    "نوع المرض: " & diseaseTypes & vbCrLf &
                    "تفاصيل: " & diseaseDetails & vbCrLf &
                    "ملاحظات: " & notes)
    End Sub

    ' زر الحذف (لتصفير الحقول)
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAge.Clear()
        txtRelation.Clear()
        txtTreatmentType.Clear()
        txtNotes.Clear()
        txtDiseaseDetails.Clear()

        rdoWorks.Checked = False
        rdoDoesNotWork.Checked = False

        rdoTreatmentYes.Checked = False
        rdoTreatmentNo.Checked = False

        rdoSupportYes.Checked = False
        rdoSupportNo.Checked = False

        CheckBox_sikePressure.Checked = False
        CheckBox_sikeSuger.Checked = False
        CheckBox_sikeHindring.Checked = False
        CheckBox_sikeSly.Checked = False
        CheckBox_sikeBenignant.Checked = False
    End Sub

    Private Sub CheckBox_sikeHindring_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_sikeHindring.CheckedChanged
        txtDisabiltyType.Visible = CheckBox_sikeHindring.Checked
    End Sub

    Private Sub family_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisabiltyType.Visible = False
    End Sub
End Class
