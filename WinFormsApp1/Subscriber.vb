Imports System.Data.SqlClient
Public Class Subscriber
    Dim con As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True", con)

    Sub clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_yeshave.Click
        family.Show()
    End Sub



    Private Sub Button_register_save_Click(sender As Object, e As EventArgs) Handles Button_register_save.Click

        ' قراءة البيانات من الفورم
        Dim info As String = ""
        TextBox_istability.Visible = False
        info &= "رقم البطاقة: " & sup_id.Text & vbCrLf
        info &= "رقم الجواز: " & sup_pasport.Text & vbCrLf
        info &= "الاسم: " & sup_name.Text & vbCrLf
        info &= "العمر: " & sup_age.Text & vbCrLf
        info &= "رقم الهاتف: " & sup_number.Text & vbCrLf
        info &= "عنوان السكن: " & sup_living.Text & vbCrLf
        info &= "عدد أفراد العائلة: " & family_total.Text & vbCrLf
        info &= "جهة العمل: " & TextBox_workplace.Text & vbCrLf

        ' الجنسية
        info &= "الجنسية: " & If(RadioButton_libyan.Checked, "ليبي", "غير ليبي") & vbCrLf

        ' نوع السكن
        If RadioButton_living1.Checked Then
            info &= "نوع السكن: مالك" & vbCrLf
        ElseIf RadioButtonliving2.Checked Then
            info &= "نوع السكن: إيجار" & vbCrLf
        ElseIf RadioButton_living3.Checked Then
            info &= "نوع السكن: سكن مشترك" & vbCrLf
        End If

        ' مدى استقرار السكن
        If RadioButton_stability1.Checked Then
            info &= "مكان السكن: دائم" & vbCrLf
        ElseIf RadioButton_stability2.Checked Then
            info &= "مكان السكن: مؤقت" & vbCrLf
        ElseIf RadioButton_stability3.Checked Then
            info &= "مكان السكن: نازح" & vbCrLf
        End If
        'الحالة الوظيفية
        If RadioButton_working.Checked Then
            info &= "الحالة الوظيفية: يعمل" & vbCrLf
        ElseIf RadioButton_nonworking.Checked Then
            info &= "الحالة الوظيفية: لايعمل" & vbCrLf
        End If

        ' نوع الاحتياج
        info &= "نوع الاحتياج: "
        If CheckBox_money.Checked Then info &= "مال، "
        If CheckBox_eat.Checked Then info &= "مواد غذائية، "
        If CheckBox_clothes.Checked Then info &= "ملابس، "
        If CheckBox_medicine.Checked Then info &= "مستلزمات صحية، "
        info &= vbCrLf

        ' مصدر الدخل
        info &= "مصدر الدخل: " & source_income.Text & vbCrLf

        ' أمراض
        info &= "يوجد مرض: " & If(RadioButton_sikeyes.Checked, "نعم", "لا") & vbCrLf
        If CheckBox_sikePressure.Checked Then info &= "- ضغط" & vbCrLf
        If CheckBox_sikeSuger.Checked Then info &= "- سكر" & vbCrLf
        If CheckBox_sikeSly.Checked Then info &= "- أمراض خبيثة" & vbCrLf
        If CheckBox_sikeBenignant.Checked Then info &= "- أمراض حميدة" & vbCrLf

        ' حالات إضافية
        info &= "يوجد معيل للأسرة: " & If(RadioButton_fatherfamily_yes.Checked, "نعم", "لا") & vbCrLf
        info &= "هل تتلقى الأسرة مساعدات خارجية: " & If(RadioButton_helpfamilly_yes.Checked, "نعم", "لا") & vbCrLf
        info &= "هل  يوجد تأمين طبي: " & If(medical_insurance_yes.Checked, "نعم", "لا") & vbCrLf



        ' التحقق من الحقول الفارغة والأرقام والحروف
        If Trim(sup_id.Text) = "" Then
            MsgBox("يرجى إدخال رقم البطاقة", MsgBoxStyle.Exclamation)
            sup_id.Focus()
            Exit Sub
        ElseIf Not IsNumeric(sup_id.Text) Then
            MsgBox("رقم البطاقة يجب أن يكون أرقام فقط", MsgBoxStyle.Exclamation)
            sup_id.Focus()
            Exit Sub
        End If

        If Trim(sup_pasport.Text) = "" Then
            MsgBox("يرجى إدخال رقم الجواز", MsgBoxStyle.Exclamation)
            sup_pasport.Focus()
            Exit Sub
            ' ElseIf Not IsNumeric(sup_pasport.Text) Then
            ' MsgBox("رقم الجواز يجب أن يكون أرقام فقط", MsgBoxStyle.Exclamation)
            ' sup_pasport.Focus()
            ' Exit Sub
        End If

        If Trim(sup_name.Text) = "" Then
            MsgBox("يرجى إدخال الاسم", MsgBoxStyle.Exclamation)
            sup_name.Focus()
            Exit Sub
        ElseIf Not IsAlpha(sup_name.Text) Then
            MsgBox("الاسم يجب أن يحتوي على حروف فقط", MsgBoxStyle.Exclamation)
            sup_name.Focus()
            Exit Sub
        End If

        If Trim(sup_age.Text) = "" Then
            MsgBox("يرجى إدخال العمر", MsgBoxStyle.Exclamation)
            sup_age.Focus()
            Exit Sub
        ElseIf Not IsNumeric(sup_age.Text) Then
            MsgBox("العمر يجب أن يكون رقماً فقط", MsgBoxStyle.Exclamation)
            sup_age.Focus()
            Exit Sub
        End If

        If Trim(sup_number.Text) = "" Then
            MsgBox("يرجى إدخال رقم الهاتف", MsgBoxStyle.Exclamation)
            sup_number.Focus()
            Exit Sub
        ElseIf Not IsNumeric(sup_number.Text) Then
            MsgBox("رقم الهاتف يجب أن يكون رقماً فقط", MsgBoxStyle.Exclamation)
            sup_number.Focus()
            Exit Sub
        End If

        If Trim(sup_living.Text) = "" Then
            MsgBox("يرجى إدخال عنوان السكن", MsgBoxStyle.Exclamation)
            sup_living.Focus()
            Exit Sub
        End If

        If Trim(family_total.Text) = "" Then
            MsgBox("يرجى إدخال عدد أفراد الأسرة", MsgBoxStyle.Exclamation)
            family_total.Focus()
            Exit Sub
        ElseIf Not IsNumeric(family_total.Text) Then
            MsgBox("عدد أفراد الأسرة يجب أن يكون رقماً فقط", MsgBoxStyle.Exclamation)
            family_total.Focus()
            Exit Sub
        End If

        If Trim(TextBox_workplace.Text) = "" Then
            MsgBox("يرجى إدخال جهة العمل", MsgBoxStyle.Exclamation)
            TextBox_workplace.Focus()
            Exit Sub
        ElseIf Not IsAlpha(TextBox_workplace.Text) Then
            MsgBox("جهة العمل يجب أن تحتوي على حروف فقط", MsgBoxStyle.Exclamation)
            TextBox_workplace.Focus()
            Exit Sub
        End If

        If Not (RadioButton_libyan.Checked Or RadioButton_nonlibyan.Checked) Then
            MsgBox("يرجى اختيار الجنسية", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not (RadioButton_living1.Checked Or RadioButtonliving2.Checked Or RadioButton_living3.Checked) Then
            MsgBox("يرجى اختيار نوع السكن", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not (RadioButton_stability1.Checked Or RadioButton_stability2.Checked Or RadioButton_stability3.Checked) Then
            MsgBox("يرجى اختيار مدى استقرار السكن", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not (RadioButton_working.Checked Or RadioButton_nonworking.Checked) Then
            MsgBox("يرجى اختيار الحالة الوظيفية", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not (RadioButton_sikeyes.Checked Or RadioButton_sikeno.Checked) Then
            MsgBox("يرجى تحديد إذا كان يوجد مرض", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not (RadioButton_fatherfamily_yes.Checked Or RadioButton_fatherfamily_no.Checked) Then
            MsgBox("يرجى تحديد إذا كان يوجد معيل للأسرة", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not (RadioButton_helpfamilly_yes.Checked Or RadioButton_helpfamilly_no.Checked) Then
            MsgBox("يرجى تحديد ما إذا كانت الأسرة تتلقى مساعدات خارجية", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("INSERT INTO Subscribers_table 
(Subscriber_id, National_id, Nationality, National_number, Passport_number, Full_name, Age, Phone_number, Address, Employment_state, Workplase, Income_source, has_disease) 
VALUES 
(@Subscriber_id, @National_id, @Nationality, @National_number, @Passport_number, @Full_name, @Age, @Phone_number, @Address, @Employment_state, @Workplase, @Income_source, @has_disease, @income_source, @has_disease", con)


        'يبيلهن تعديللللللللللللللللللللللللللللللللللللل
        ' cmd.Parameters.AddWithValue("@Subscriber_id", sup_id.Text)
        'cmd.Parameters.AddWithValue("@National_id", National_id.Text)
        'cmd.Parameters.AddWithValue("@sup_name", sup_name.Text)
        'cmd.Parameters.AddWithValue("@sup_age", sup_age.Text)
        ' cmd.Parameters.AddWithValue("@sup_number", sup_number.Text)
        ' cmd.Parameters.AddWithValue("@sup_living", sup_living.Text)
        'cmd.Parameters.AddWithValue("@family_total", family_total.Text)
        'cmd.Parameters.AddWithValue("@workplace", TextBox_workplace.Text)
        ' cmd.Parameters.AddWithValue("@nationality", If(RadioButton_libyan.Checked, "ليبي", "غير ليبي"))
        ' cmd.Parameters.AddWithValue("@living_type", If(RadioButton_living1.Checked, "مالك", If(RadioButtonliving2.Checked, "إيجار", "سكن مشترك")))
        'cmd.Parameters.AddWithValue("@stability", If(RadioButton_stability1.Checked, "دائم", If(RadioButton_stability2.Checked, "مؤقت", "نازح")))
        ' cmd.Parameters.AddWithValue("@working_status", If(RadioButton_working.Checked, "يعمل", "لايعمل"))
        '//////////////////////////////////////////////////////////////////////

        ' تجميع نوع الاحتياج
        Dim needs As String = ""
        If CheckBox_money.Checked Then needs &= "مال،"
        If CheckBox_eat.Checked Then needs &= "مواد غذائية،"
        If CheckBox_clothes.Checked Then needs &= "ملابس،"
        If CheckBox_medicine.Checked Then needs &= "مستلزمات صحية،"
        cmd.Parameters.AddWithValue("@needs", needs.TrimEnd(","))

        cmd.Parameters.AddWithValue("@income_source", source_income.Text)
        cmd.Parameters.AddWithValue("@has_disease", If(RadioButton_sikeyes.Checked, "نعم", "لا"))

        ' تجميع تفاصيل الأمراض
        Dim diseases As String = ""
        If CheckBox_sikePressure.Checked Then diseases &= "ضغط،"
        If CheckBox_sikeSuger.Checked Then diseases &= "سكر،"
        If CheckBox_sikeSly.Checked Then diseases &= "خبيثة،"
        If CheckBox_sikeBenignant.Checked Then diseases &= "حميدة،"
        If CheckBox_sikeHind.Checked Then diseases &= TextBox_istability.Text & "،"
        cmd.Parameters.AddWithValue("@disease_details", diseases.TrimEnd(","))

        cmd.Parameters.AddWithValue("@has_family_support", If(RadioButton_fatherfamily_yes.Checked, "نعم", "لا"))
        cmd.Parameters.AddWithValue("@has_external_support", If(RadioButton_helpfamilly_yes.Checked, "نعم", "لا"))
        cmd.Parameters.AddWithValue("@has_insurance", If(medical_insurance_yes.Checked, "نعم", "لا"))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم حفظ البيانات في قاعدة البيانات بنجاح", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("حدث خطأ أثناء حفظ البيانات: " & ex.Message)
        Finally
            con.Close()
        End Try



        ' إذا كل شيء صحيح
        MsgBox("تم تسجيل البيانات بنجاح", MsgBoxStyle.Information)

        ' عرض النتيجة
        MessageBox.Show(info, "بيانات المشترك")
    End Sub

    Private Sub CheckBox_sikeHind_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_sikeHind.CheckedChanged
        TextBox_istability.Visible = False
        TextBox_istability.Visible = CheckBox_sikeHind.Checked
    End Sub

    Private Sub RadioButton_sikeyes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_sikeyes.CheckedChanged
        GroupBox_sik.Visible = RadioButton_sikeyes.Checked
    End Sub

    Private Sub RadioButton_sikeno_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_sikeno.CheckedChanged
        If RadioButton_sikeno.Checked Then
            GroupBox_sik.Visible = False
            CheckBox_sikePressure.Checked = False
            CheckBox_sikeSuger.Checked = False
            CheckBox_sikeSly.Checked = False
            CheckBox_sikeBenignant.Checked = False
        End If
    End Sub

    Private Sub Subscriber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox_sik.Visible = False
    End Sub

    Private Sub Button_register_delete_Click(sender As Object, e As EventArgs) Handles Button_register_delete.Click


        ' تصفير الحقول النصية
        sup_id.Text = ""
        sup_pasport.Text = ""
        sup_name.Text = ""
        sup_age.Text = ""
        sup_number.Text = ""
        sup_living.Text = ""
        family_total.Text = ""
        TextBox_workplace.Text = ""
        source_income.Text = ""
        TextBox_istability.Text = ""

        ' تصفير الخيارات (RadioButtons)
        RadioButton_libyan.Checked = False
        RadioButton_nonlibyan.Checked = False

        RadioButton_living1.Checked = False
        RadioButtonliving2.Checked = False
        RadioButton_living3.Checked = False

        RadioButton_stability1.Checked = False
        RadioButton_stability2.Checked = False
        RadioButton_stability3.Checked = False

        RadioButton_working.Checked = False
        RadioButton_nonworking.Checked = False

        RadioButton_fatherfamily_yes.Checked = False
        RadioButton_fatherfamily_no.Checked = False

        RadioButton_helpfamilly_yes.Checked = False
        RadioButton_helpfamilly_no.Checked = False

        RadioButton_sikeyes.Checked = False
        RadioButton_sikeno.Checked = False
        medical_insurance_yes.Checked = False
        medical_insurance_no.Checked = False
        ' تصفير المربعات (CheckBoxes)
        CheckBox_money.Checked = False
        CheckBox_eat.Checked = False
        CheckBox_clothes.Checked = False
        CheckBox_medicine.Checked = False

        CheckBox_sikePressure.Checked = False
        CheckBox_sikeSuger.Checked = False
        CheckBox_sikeSly.Checked = False
        CheckBox_sikeBenignant.Checked = False
        CheckBox_sikeHind.Checked = False

        ' إخفاء الحقول الخاصة بالأمراض
        GroupBox_sik.Visible = False
        TextBox_istability.Visible = False

        If MsgBox("هل تريد حذف هذا المشترك؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cmd As New SqlCommand("DELETE FROM Subscribers WHERE Subscriber_id = @Subscriber_id", con)
            cmd.Parameters.AddWithValue("@Subscriber_id", sup_id.Text)

            Try
                con.Open()
                Dim rows = cmd.ExecuteNonQuery()
                If rows > 0 Then
                    MsgBox("تم حذف المشترك بنجاح", MsgBoxStyle.Information)
                Else
                    MsgBox("لم يتم العثور على مشترك بهذا الرقم", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("حدث خطأ أثناء الحذف: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    ' دالة التحقق من أن النص يحتوي على حروف فقط
    Private Function IsAlpha(input As String) As Boolean
        For Each c As Char In input
            If Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c) Then
                Return False
            End If
        Next
        Return True
    End Function


End Class