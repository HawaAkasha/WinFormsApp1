<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class family
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        family_name = New TextBox()
        family_age = New TextBox()
        relation = New TextBox()
        TextBox10 = New TextBox()
        Label_siketype = New Label()
        CheckBox_sikeBenignant = New CheckBox()
        CheckBox_sikeHindring = New CheckBox()
        CheckBox_sikeSly = New CheckBox()
        CheckBox_sikeSuger = New CheckBox()
        CheckBox_sikePressure = New CheckBox()
        Label1 = New Label()
        sike_deatils = New TextBox()
        GroupBox_work = New GroupBox()
        RadioButton_working = New RadioButton()
        RadioButton_nonworking = New RadioButton()
        GroupBox_treatment = New GroupBox()
        RadioButton_treatment_yes = New RadioButton()
        RadioButton_treatment_no = New RadioButton()
        GroupBox_NeedSupport = New GroupBox()
        RadioButton_NeedSupport_yes = New RadioButton()
        RadioButton_NeedSupport_no = New RadioButton()
        Label2 = New Label()
        Label6 = New Label()
        TextBox_typeOFmedical = New TextBox()
        TextBox_extraNote = New TextBox()
        Button_register = New Button()
        Button_delete_donor = New Button()
        GroupBox_work.SuspendLayout()
        GroupBox_treatment.SuspendLayout()
        GroupBox_NeedSupport.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 47
        Label5.Text = "صلة القرابة"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 46
        Label4.Text = "العمر"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 45
        Label3.Text = "الاسم"
        ' 
        ' family_name
        ' 
        family_name.Location = New Point(40, 63)
        family_name.Name = "family_name"
        family_name.Size = New Size(184, 27)
        family_name.TabIndex = 44
        ' 
        ' family_age
        ' 
        family_age.Location = New Point(40, 124)
        family_age.Name = "family_age"
        family_age.Size = New Size(184, 27)
        family_age.TabIndex = 43
        ' 
        ' relation
        ' 
        relation.Location = New Point(40, 187)
        relation.Name = "relation"
        relation.Size = New Size(184, 27)
        relation.TabIndex = 42
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(125, 331)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(119, 27)
        TextBox10.TabIndex = 63
        TextBox10.Text = "ادخل نوع الاعاقة"
        ' 
        ' Label_siketype
        ' 
        Label_siketype.AutoSize = True
        Label_siketype.Location = New Point(40, 246)
        Label_siketype.Name = "Label_siketype"
        Label_siketype.Size = New Size(78, 20)
        Label_siketype.TabIndex = 62
        Label_siketype.Text = "نوع المرض"
        ' 
        ' CheckBox_sikeBenignant
        ' 
        CheckBox_sikeBenignant.AutoSize = True
        CheckBox_sikeBenignant.Location = New Point(40, 391)
        CheckBox_sikeBenignant.Name = "CheckBox_sikeBenignant"
        CheckBox_sikeBenignant.Size = New Size(116, 24)
        CheckBox_sikeBenignant.TabIndex = 61
        CheckBox_sikeBenignant.Text = "امراض حميدة"
        CheckBox_sikeBenignant.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeHindring
        ' 
        CheckBox_sikeHindring.AutoSize = True
        CheckBox_sikeHindring.Location = New Point(40, 331)
        CheckBox_sikeHindring.Name = "CheckBox_sikeHindring"
        CheckBox_sikeHindring.Size = New Size(64, 24)
        CheckBox_sikeHindring.TabIndex = 60
        CheckBox_sikeHindring.Text = "اعاقة"
        CheckBox_sikeHindring.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSly
        ' 
        CheckBox_sikeSly.AutoSize = True
        CheckBox_sikeSly.Location = New Point(40, 361)
        CheckBox_sikeSly.Name = "CheckBox_sikeSly"
        CheckBox_sikeSly.Size = New Size(109, 24)
        CheckBox_sikeSly.TabIndex = 59
        CheckBox_sikeSly.Text = "امراض خبيثة"
        CheckBox_sikeSly.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSuger
        ' 
        CheckBox_sikeSuger.AutoSize = True
        CheckBox_sikeSuger.Location = New Point(40, 301)
        CheckBox_sikeSuger.Name = "CheckBox_sikeSuger"
        CheckBox_sikeSuger.Size = New Size(58, 24)
        CheckBox_sikeSuger.TabIndex = 58
        CheckBox_sikeSuger.Text = "سكر"
        CheckBox_sikeSuger.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikePressure
        ' 
        CheckBox_sikePressure.AutoSize = True
        CheckBox_sikePressure.Location = New Point(40, 271)
        CheckBox_sikePressure.Name = "CheckBox_sikePressure"
        CheckBox_sikePressure.Size = New Size(68, 24)
        CheckBox_sikePressure.TabIndex = 57
        CheckBox_sikePressure.Text = "ضغط"
        CheckBox_sikePressure.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 433)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 65
        Label1.Text = "تفاصيل المرض"
        ' 
        ' sike_deatils
        ' 
        sike_deatils.Location = New Point(45, 456)
        sike_deatils.Name = "sike_deatils"
        sike_deatils.Size = New Size(184, 27)
        sike_deatils.TabIndex = 64
        ' 
        ' GroupBox_work
        ' 
        GroupBox_work.Controls.Add(RadioButton_working)
        GroupBox_work.Controls.Add(RadioButton_nonworking)
        GroupBox_work.Location = New Point(294, 40)
        GroupBox_work.Name = "GroupBox_work"
        GroupBox_work.Size = New Size(188, 67)
        GroupBox_work.TabIndex = 66
        GroupBox_work.TabStop = False
        GroupBox_work.Text = "الحالة الوظيفية"
        ' 
        ' RadioButton_working
        ' 
        RadioButton_working.AutoSize = True
        RadioButton_working.Location = New Point(119, 26)
        RadioButton_working.Name = "RadioButton_working"
        RadioButton_working.Size = New Size(63, 24)
        RadioButton_working.TabIndex = 17
        RadioButton_working.TabStop = True
        RadioButton_working.Text = "يعمل"
        RadioButton_working.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_nonworking
        ' 
        RadioButton_nonworking.AutoSize = True
        RadioButton_nonworking.Location = New Point(24, 26)
        RadioButton_nonworking.Name = "RadioButton_nonworking"
        RadioButton_nonworking.Size = New Size(76, 24)
        RadioButton_nonworking.TabIndex = 18
        RadioButton_nonworking.TabStop = True
        RadioButton_nonworking.Text = "لا يعمل"
        RadioButton_nonworking.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_treatment
        ' 
        GroupBox_treatment.Controls.Add(RadioButton_treatment_yes)
        GroupBox_treatment.Controls.Add(RadioButton_treatment_no)
        GroupBox_treatment.Location = New Point(294, 133)
        GroupBox_treatment.Name = "GroupBox_treatment"
        GroupBox_treatment.Size = New Size(188, 67)
        GroupBox_treatment.TabIndex = 67
        GroupBox_treatment.TabStop = False
        GroupBox_treatment.Text = "هل يتلقى علاج"
        ' 
        ' RadioButton_treatment_yes
        ' 
        RadioButton_treatment_yes.AutoSize = True
        RadioButton_treatment_yes.Location = New Point(119, 26)
        RadioButton_treatment_yes.Name = "RadioButton_treatment_yes"
        RadioButton_treatment_yes.Size = New Size(53, 24)
        RadioButton_treatment_yes.TabIndex = 17
        RadioButton_treatment_yes.TabStop = True
        RadioButton_treatment_yes.Text = "نعم"
        RadioButton_treatment_yes.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_treatment_no
        ' 
        RadioButton_treatment_no.AutoSize = True
        RadioButton_treatment_no.Location = New Point(61, 26)
        RadioButton_treatment_no.Name = "RadioButton_treatment_no"
        RadioButton_treatment_no.Size = New Size(39, 24)
        RadioButton_treatment_no.TabIndex = 18
        RadioButton_treatment_no.TabStop = True
        RadioButton_treatment_no.Text = "لا"
        RadioButton_treatment_no.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_NeedSupport
        ' 
        GroupBox_NeedSupport.Controls.Add(RadioButton_NeedSupport_yes)
        GroupBox_NeedSupport.Controls.Add(RadioButton_NeedSupport_no)
        GroupBox_NeedSupport.Location = New Point(294, 228)
        GroupBox_NeedSupport.Name = "GroupBox_NeedSupport"
        GroupBox_NeedSupport.Size = New Size(188, 67)
        GroupBox_NeedSupport.TabIndex = 68
        GroupBox_NeedSupport.TabStop = False
        GroupBox_NeedSupport.Text = "هل يحتاج لدعم صحي"
        ' 
        ' RadioButton_NeedSupport_yes
        ' 
        RadioButton_NeedSupport_yes.AutoSize = True
        RadioButton_NeedSupport_yes.Location = New Point(119, 26)
        RadioButton_NeedSupport_yes.Name = "RadioButton_NeedSupport_yes"
        RadioButton_NeedSupport_yes.Size = New Size(53, 24)
        RadioButton_NeedSupport_yes.TabIndex = 17
        RadioButton_NeedSupport_yes.TabStop = True
        RadioButton_NeedSupport_yes.Text = "نعم"
        RadioButton_NeedSupport_yes.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_NeedSupport_no
        ' 
        RadioButton_NeedSupport_no.AutoSize = True
        RadioButton_NeedSupport_no.Location = New Point(61, 26)
        RadioButton_NeedSupport_no.Name = "RadioButton_NeedSupport_no"
        RadioButton_NeedSupport_no.Size = New Size(39, 24)
        RadioButton_NeedSupport_no.TabIndex = 18
        RadioButton_NeedSupport_no.TabStop = True
        RadioButton_NeedSupport_no.Text = "لا"
        RadioButton_NeedSupport_no.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(300, 366)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 72
        Label2.Text = "ملاحظات اضافية"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(300, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 71
        Label6.Text = "نوع العلاج "
        ' 
        ' TextBox_typeOFmedical
        ' 
        TextBox_typeOFmedical.Location = New Point(300, 328)
        TextBox_typeOFmedical.Name = "TextBox_typeOFmedical"
        TextBox_typeOFmedical.Size = New Size(184, 27)
        TextBox_typeOFmedical.TabIndex = 70
        ' 
        ' TextBox_extraNote
        ' 
        TextBox_extraNote.Location = New Point(300, 389)
        TextBox_extraNote.Name = "TextBox_extraNote"
        TextBox_extraNote.Size = New Size(184, 27)
        TextBox_extraNote.TabIndex = 69
        ' 
        ' Button_register
        ' 
        Button_register.Location = New Point(357, 456)
        Button_register.Name = "Button_register"
        Button_register.Size = New Size(119, 36)
        Button_register.TabIndex = 73
        Button_register.Text = "سجل الان"
        Button_register.UseVisualStyleBackColor = True
        ' 
        ' Button_delete_donor
        ' 
        Button_delete_donor.Location = New Point(357, 498)
        Button_delete_donor.Name = "Button_delete_donor"
        Button_delete_donor.Size = New Size(119, 36)
        Button_delete_donor.TabIndex = 74
        Button_delete_donor.Text = "حذف"
        Button_delete_donor.UseVisualStyleBackColor = True
        ' 
        ' family
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(515, 555)
        Controls.Add(Button_delete_donor)
        Controls.Add(Button_register)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(TextBox_typeOFmedical)
        Controls.Add(TextBox_extraNote)
        Controls.Add(GroupBox_NeedSupport)
        Controls.Add(GroupBox_treatment)
        Controls.Add(GroupBox_work)
        Controls.Add(Label1)
        Controls.Add(sike_deatils)
        Controls.Add(TextBox10)
        Controls.Add(Label_siketype)
        Controls.Add(CheckBox_sikeBenignant)
        Controls.Add(CheckBox_sikeHindring)
        Controls.Add(CheckBox_sikeSly)
        Controls.Add(CheckBox_sikeSuger)
        Controls.Add(CheckBox_sikePressure)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(family_name)
        Controls.Add(family_age)
        Controls.Add(relation)
        MaximizeBox = False
        MinimizeBox = False
        Name = "family"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل عائلة"
        GroupBox_work.ResumeLayout(False)
        GroupBox_work.PerformLayout()
        GroupBox_treatment.ResumeLayout(False)
        GroupBox_treatment.PerformLayout()
        GroupBox_NeedSupport.ResumeLayout(False)
        GroupBox_NeedSupport.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents family_name As TextBox
    Friend WithEvents family_age As TextBox
    Friend WithEvents relation As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label_siketype As Label
    Friend WithEvents CheckBox_sikeBenignant As CheckBox
    Friend WithEvents CheckBox_sikeHindring As CheckBox
    Friend WithEvents CheckBox_sikeSly As CheckBox
    Friend WithEvents CheckBox_sikeSuger As CheckBox
    Friend WithEvents CheckBox_sikePressure As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sike_deatils As TextBox
    Friend WithEvents GroupBox_work As GroupBox
    Friend WithEvents RadioButton_working As RadioButton
    Friend WithEvents RadioButton_nonworking As RadioButton
    Friend WithEvents GroupBox_treatment As GroupBox
    Friend WithEvents RadioButton_treatment_yes As RadioButton
    Friend WithEvents RadioButton_treatment_no As RadioButton
    Friend WithEvents GroupBox_NeedSupport As GroupBox
    Friend WithEvents RadioButton_NeedSupport_yes As RadioButton
    Friend WithEvents RadioButton_NeedSupport_no As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_typeOFmedical As TextBox
    Friend WithEvents TextBox_extraNote As TextBox
    Friend WithEvents Button_register As Button
    Friend WithEvents Button_delete_donor As Button
End Class
