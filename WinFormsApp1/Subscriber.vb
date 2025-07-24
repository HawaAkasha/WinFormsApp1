
Imports System.Data.SqlClient
Public Class Subscriber
    Dim conn As New SqlConnection("Data Source=DESKTOP-OA3F4SP\SQLEXPRESS;Initial Catalog=Project_DB;Integrated Security=True")

    Sub clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        family.Show
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


        'اضافه في الداتا بيز 

        Try

            ' قراءة الجنسية 
            Dim nationality As String = ""
            If RadioButton_libyan.Checked Then
                nationality = "ليبي"
            ElseIf RadioButton_nonlibyan.Checked Then
                nationality = "غير ليبي"
            End If

            ' قراءة نوع السكن 
            Dim housingType As String = ""
            If RadioButton_living1.Checked Then
                housingType = "ملك"
            ElseIf RadioButtonliving2.Checked Then

                housingType = "إيجار"
            ElseIf RadioButton_living3.Checked Then
                housingType = "سكن مشترك"
            End If

            ' قراءة الحالة الصحية 
            Dim hasDisease As String = ""
            If RadioButton_sikeyes.Checked Then
                hasDisease = "نعم"
            ElseIf RadioButton_sikeno.Checked Then
                hasDisease = "لا"

            End If

            ' حساب نوع المرض
            Dim diseaseType As String = "غير محدد"
            If CheckBox_sikePressure.Checked Then
                diseaseType = "ضغط"
            ElseIf CheckBox_sikeSuger.Checked Then
                diseaseType = "سكر"
            ElseIf CheckBox_sikeHind.Checked Then
                diseaseType = "اعاقة"
            ElseIf CheckBox_sikeSly.Checked Then
                diseaseType = "خبيث"
            ElseIf CheckBox_sikeBenignant.Checked Then
                diseaseType = "حميد"
            End If

            If diseaseType.EndsWith("،") Then
                diseaseType = diseaseType.Substring(0, diseaseType.Length - 1)
            End If

            conn.Open()

            Dim cmd As New SqlCommand("INSERT INTO Subscribers_table  
            (National_id, Nationality, National_number,Passport_number,Full_name,Age,Phone_number,Address,Employment_state,Work_p,Income_source,has_disease,Disease_id)  
            VALUES (@National_id, @Nationality, @National_number,@Passport_number,@Full_name,@Age,@Phone_number,@Address,@Employment_state,@Work_p,@Income_source,@has_disease,@diseaseType)", conn)

            cmd.Parameters.AddWithValue("@National_id", sup_id.Text)
            cmd.Parameters.AddWithValue("@Nationality", nationality)
            cmd.Parameters.AddWithValue("@National_number", sup_pasport.Text)
            cmd.Parameters.AddWithValue("@Passport_number", sup_pasport.Text)
            cmd.Parameters.AddWithValue("@Full_name", sup_name.Text)
            cmd.Parameters.AddWithValue("@Age", sup_age.Text)
            cmd.Parameters.AddWithValue("@Phone_number", sup_number.Text)
            cmd.Parameters.AddWithValue("@Address", sup_living.Text)
            cmd.Parameters.AddWithValue("@Employment_state", housingType)
            cmd.Parameters.AddWithValue("@Work_p", TextBox_workplace.Text)
            cmd.Parameters.AddWithValue("@Income_source", source_income.Text)
            cmd.Parameters.AddWithValue("@has_disease", hasDisease)
            cmd.Parameters.AddWithValue("@diseaseType", diseaseType)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("تمت إضافة المشترك بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()


        Catch ex As Exception
            MessageBox.Show("خطأ أثناء الإضافة: " & ex.Message)
            conn.Close()
        End Try
        ' إذا كان المشترك لديه مرض → افتح سجل طبي تلقائيًا 
        If RadioButton_sikeyes.Checked Or CheckBox_sikePressure.Checked Or CheckBox_sikeSuger.Checked Or CheckBox_sikeSly.Checked Or CheckBox_sikeBenignant.Checked Then

            Dim medical As New medicalRecord()
            medical.SubscriberID = sup_id.Text
            medical.SubscriberName = sup_name.Text
            medical.SubscriberAge = sup_age.Text


        End If
        'هل يملك المشترك عائلة 
        Dim hasFamily As DialogResult = MessageBox.Show("هل يمتلك هذا المشترك عائلة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasFamily = DialogResult.Yes Then
            ' تمرير رقم المشترك إلى نموذج العائلة 
            family.SubscriberID = sup_id.Text
            family.ShowDialog() ' إظهار فورم العائلة كنافذة مؤقتة 
        End If



        ' تحديد نوع الاحتياج 
        Dim needType As String = ""
        Dim itemName As String = ""
        Dim quantity As Integer = 0 'عدليها 

        If CheckBox_money.Checked Then
            needType = "مالي"
            itemName = "قيمة مالية"


        ElseIf CheckBox_eat.Checked Then
            needType = "مواد غذائية"
            itemName = TextBox_item.Text
            Integer.TryParse(item_quntity.Text, quantity)

        ElseIf CheckBox_clothes.Checked Then
            needType = "ملابس"
            itemName = TextBox_cloth.Text
            Integer.TryParse(cloth_quntity.Text, quantity)

        ElseIf CheckBox_medicine.Checked Then
            needType = "مستلزمات صحية"
            itemName = TextBox_med.Text
            Integer.TryParse(med_quntity.Text, quantity)

        Else
            MessageBox.Show("يرجى اختيار نوع احتياج.")
            Exit Sub

        End If
        'الربط بالحتياج 




        Try
            ' تجهيز بيانات المادة 
            Dim itemNam As String = ""
            Dim itemQty As Integer = 0


            Dim itemCategory As String = ""

            If CheckBox_money.Checked Then
                itemNam = "مالي"
                itemCategory = "مالي"
                itemQty = TextBox_moneyy.Text
            ElseIf CheckBox_eat.Checked Then
                itemNam = TextBox_item.Text
                itemCategory = "مواد غذائية"
                Integer.TryParse(item_quntity.Text, itemQty)
            ElseIf CheckBox_clothes.Checked Then
                itemNam = TextBox_cloth.Text
                itemCategory = "ملابس"
                Integer.TryParse(cloth_quntity.Text, itemQty)
            ElseIf CheckBox_medicine.Checked Then
                itemNam = TextBox_med.Text
                itemCategory = "مستلزمات صحية"
                Integer.TryParse(med_quntity.Text, itemQty)
            Else
                MessageBox.Show("يرجى اختيار نوع احتياج.")
                Exit Sub
            End If

            conn.Open()

            ' 1. إضافة المادة 
            Dim cmdItem As New SqlCommand("INSERT INTO Item_table (Item_name, Item_quantity, Item_category, Expir_date) 
                                   OUTPUT INSERTED.Item_id 
                                   VALUES (@name, @qty, @cat, @exp)", conn)
            cmdItem.Parameters.AddWithValue("@name", itemNam)
            cmdItem.Parameters.AddWithValue("@qty", itemQty)
            cmdItem.Parameters.AddWithValue("@cat", itemCategory)
            cmdItem.Parameters.AddWithValue("@exp", DateTime.Today)
            Dim itemId As Integer = CInt(cmdItem.ExecuteScalar())

            ' 2. ربطها بالمشترك في جدول الاحتياج 
            Dim cmdNeed As New SqlCommand("INSERT INTO Needs_table ( item_id, Subscriber_id, Need_type, FamilyNumbe) 
                                   VALUES (@itemId, @subId, @type, @family)", conn)
            cmdNeed.Parameters.AddWithValue("@itemId", itemId)
            cmdNeed.Parameters.AddWithValue("@subId", sup_id.Text)
            cmdNeed.Parameters.AddWithValue("@type", itemCategory)
            cmdNeed.Parameters.AddWithValue("@family", family_total.Text)
            cmdNeed.ExecuteNonQuery()

            ' تحميل البيانات في فورم الاحتياج   
            Dim needForm As New needs()
            needForm.LoadNeedsFromSubscribers()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("❌ خطأ أثناء الربط: " & ex.Message)

        End Try

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
        TextBox_istability.Visible = False
        TextBox_item.Visible = False
        item_quntity.Visible = False
        TextBox_cloth.Visible = False
        cloth_quntity.Visible = False
        TextBox_med.Visible = False
        med_quntity.Visible = False
        TextBox_moneyy.Visible = False
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

        TextBox_item.Visible = False
        item_quntity.Visible = False
        TextBox_cloth.Visible = False
        cloth_quntity.Visible = False
        TextBox_med.Visible = False
        med_quntity.Visible = False
        TextBox_moneyy.Visible = False

        ' إخفاء الحقول الخاصة بالأمراض 
        GroupBox_sik.Visible = False
        TextBox_istability.Visible = False

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

    Private Sub CheckBox_eat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_eat.CheckedChanged
        TextBox_item.Visible = CheckBox_eat.Checked
        item_quntity.Visible = CheckBox_eat.Checked
    End Sub

    Private Sub CheckBox_clothes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_clothes.CheckedChanged
        TextBox_cloth.Visible = CheckBox_clothes.Checked
        cloth_quntity.Visible = CheckBox_clothes.Checked
    End Sub

    Private Sub CheckBox_medicine_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_medicine.CheckedChanged
        TextBox_med.Visible = CheckBox_medicine.Checked
        med_quntity.Visible = CheckBox_medicine.Checked
    End Sub

    Private Sub CheckBox_money_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_money.CheckedChanged
        TextBox_moneyy.Visible = CheckBox_money.Checked
    End Sub


End Class