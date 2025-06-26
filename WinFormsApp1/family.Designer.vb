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
        txtName = New TextBox()
        txtAge = New TextBox()
        txtRelation = New TextBox()
        rdoWorks = New RadioButton()
        rdoDoesNotWork = New RadioButton()
        GroupBox_treatment = New GroupBox()
        rdoTreatmentYes = New RadioButton()
        rdoTreatmentNo = New RadioButton()
        GroupBox_NeedSupport = New GroupBox()
        rdoSupportYes = New RadioButton()
        rdoSupportNo = New RadioButton()
        Label2 = New Label()
        Label6 = New Label()
        txtTreatmentType = New TextBox()
        txtNotes = New TextBox()
        btnRegister = New Button()
        btnClear = New Button()
        CheckBox_sikePressure = New CheckBox()
        CheckBox_sikeSuger = New CheckBox()
        CheckBox_sikeHindring = New CheckBox()
        CheckBox_sikeSly = New CheckBox()
        CheckBox_sikeBenignant = New CheckBox()
        txtDisabiltyType = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        GroupBox_treatment.SuspendLayout()
        GroupBox_NeedSupport.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 47
        Label5.Text = "صلة القرابة"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(55, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 46
        Label4.Text = "العمر"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(55, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 45
        Label3.Text = "الاسم"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Azure
        txtName.Location = New Point(55, 59)
        txtName.Name = "txtName"
        txtName.Size = New Size(184, 27)
        txtName.TabIndex = 44
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.Azure
        txtAge.Location = New Point(55, 120)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(184, 27)
        txtAge.TabIndex = 43
        ' 
        ' txtRelation
        ' 
        txtRelation.BackColor = Color.Azure
        txtRelation.Location = New Point(55, 183)
        txtRelation.Name = "txtRelation"
        txtRelation.Size = New Size(184, 27)
        txtRelation.TabIndex = 42
        ' 
        ' rdoWorks
        ' 
        rdoWorks.AutoSize = True
        rdoWorks.Location = New Point(56, 457)
        rdoWorks.Name = "rdoWorks"
        rdoWorks.Size = New Size(63, 24)
        rdoWorks.TabIndex = 17
        rdoWorks.TabStop = True
        rdoWorks.Text = "يعمل"
        rdoWorks.UseVisualStyleBackColor = True
        ' 
        ' rdoDoesNotWork
        ' 
        rdoDoesNotWork.AutoSize = True
        rdoDoesNotWork.Location = New Point(125, 459)
        rdoDoesNotWork.Name = "rdoDoesNotWork"
        rdoDoesNotWork.Size = New Size(76, 24)
        rdoDoesNotWork.TabIndex = 18
        rdoDoesNotWork.TabStop = True
        rdoDoesNotWork.Text = "لا يعمل"
        rdoDoesNotWork.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_treatment
        ' 
        GroupBox_treatment.Controls.Add(rdoTreatmentYes)
        GroupBox_treatment.Controls.Add(rdoTreatmentNo)
        GroupBox_treatment.Location = New Point(296, 39)
        GroupBox_treatment.Name = "GroupBox_treatment"
        GroupBox_treatment.Size = New Size(188, 67)
        GroupBox_treatment.TabIndex = 67
        GroupBox_treatment.TabStop = False
        GroupBox_treatment.Text = "هل يتلقى علاج"
        ' 
        ' rdoTreatmentYes
        ' 
        rdoTreatmentYes.AutoSize = True
        rdoTreatmentYes.Location = New Point(119, 26)
        rdoTreatmentYes.Name = "rdoTreatmentYes"
        rdoTreatmentYes.Size = New Size(53, 24)
        rdoTreatmentYes.TabIndex = 17
        rdoTreatmentYes.TabStop = True
        rdoTreatmentYes.Text = "نعم"
        rdoTreatmentYes.UseVisualStyleBackColor = True
        ' 
        ' rdoTreatmentNo
        ' 
        rdoTreatmentNo.AutoSize = True
        rdoTreatmentNo.Location = New Point(61, 26)
        rdoTreatmentNo.Name = "rdoTreatmentNo"
        rdoTreatmentNo.Size = New Size(39, 24)
        rdoTreatmentNo.TabIndex = 18
        rdoTreatmentNo.TabStop = True
        rdoTreatmentNo.Text = "لا"
        rdoTreatmentNo.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_NeedSupport
        ' 
        GroupBox_NeedSupport.Controls.Add(rdoSupportYes)
        GroupBox_NeedSupport.Controls.Add(rdoSupportNo)
        GroupBox_NeedSupport.Location = New Point(296, 134)
        GroupBox_NeedSupport.Name = "GroupBox_NeedSupport"
        GroupBox_NeedSupport.Size = New Size(188, 67)
        GroupBox_NeedSupport.TabIndex = 68
        GroupBox_NeedSupport.TabStop = False
        GroupBox_NeedSupport.Text = "هل يحتاج لدعم صحي"
        ' 
        ' rdoSupportYes
        ' 
        rdoSupportYes.AutoSize = True
        rdoSupportYes.Location = New Point(119, 26)
        rdoSupportYes.Name = "rdoSupportYes"
        rdoSupportYes.Size = New Size(53, 24)
        rdoSupportYes.TabIndex = 17
        rdoSupportYes.TabStop = True
        rdoSupportYes.Text = "نعم"
        rdoSupportYes.UseVisualStyleBackColor = True
        ' 
        ' rdoSupportNo
        ' 
        rdoSupportNo.AutoSize = True
        rdoSupportNo.Location = New Point(61, 26)
        rdoSupportNo.Name = "rdoSupportNo"
        rdoSupportNo.Size = New Size(39, 24)
        rdoSupportNo.TabIndex = 18
        rdoSupportNo.TabStop = True
        rdoSupportNo.Text = "لا"
        rdoSupportNo.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(300, 305)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 72
        Label2.Text = "ملاحظات اضافية"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(300, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 71
        Label6.Text = "نوع العلاج "
        ' 
        ' txtTreatmentType
        ' 
        txtTreatmentType.BackColor = Color.Azure
        txtTreatmentType.Location = New Point(300, 244)
        txtTreatmentType.Name = "txtTreatmentType"
        txtTreatmentType.Size = New Size(184, 27)
        txtTreatmentType.TabIndex = 70
        ' 
        ' txtNotes
        ' 
        txtNotes.BackColor = Color.Azure
        txtNotes.Location = New Point(300, 328)
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(184, 27)
        txtNotes.TabIndex = 69
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(365, 430)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(119, 27)
        btnRegister.TabIndex = 73
        btnRegister.Text = "سجل الان"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(365, 482)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(119, 33)
        btnClear.TabIndex = 74
        btnClear.Text = "حذف"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikePressure
        ' 
        CheckBox_sikePressure.AutoSize = True
        CheckBox_sikePressure.Location = New Point(57, 264)
        CheckBox_sikePressure.Name = "CheckBox_sikePressure"
        CheckBox_sikePressure.Size = New Size(68, 24)
        CheckBox_sikePressure.TabIndex = 22
        CheckBox_sikePressure.Text = "ضغط"
        CheckBox_sikePressure.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSuger
        ' 
        CheckBox_sikeSuger.AutoSize = True
        CheckBox_sikeSuger.Location = New Point(57, 294)
        CheckBox_sikeSuger.Name = "CheckBox_sikeSuger"
        CheckBox_sikeSuger.Size = New Size(58, 24)
        CheckBox_sikeSuger.TabIndex = 23
        CheckBox_sikeSuger.Text = "سكر"
        CheckBox_sikeSuger.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeHindring
        ' 
        CheckBox_sikeHindring.AutoSize = True
        CheckBox_sikeHindring.Location = New Point(55, 327)
        CheckBox_sikeHindring.Name = "CheckBox_sikeHindring"
        CheckBox_sikeHindring.Size = New Size(64, 24)
        CheckBox_sikeHindring.TabIndex = 25
        CheckBox_sikeHindring.Text = "اعاقة"
        CheckBox_sikeHindring.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSly
        ' 
        CheckBox_sikeSly.AutoSize = True
        CheckBox_sikeSly.Location = New Point(55, 357)
        CheckBox_sikeSly.Name = "CheckBox_sikeSly"
        CheckBox_sikeSly.Size = New Size(109, 24)
        CheckBox_sikeSly.TabIndex = 24
        CheckBox_sikeSly.Text = "امراض خبيثة"
        CheckBox_sikeSly.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeBenignant
        ' 
        CheckBox_sikeBenignant.AutoSize = True
        CheckBox_sikeBenignant.Location = New Point(55, 389)
        CheckBox_sikeBenignant.Name = "CheckBox_sikeBenignant"
        CheckBox_sikeBenignant.Size = New Size(116, 24)
        CheckBox_sikeBenignant.TabIndex = 26
        CheckBox_sikeBenignant.Text = "امراض حميدة"
        CheckBox_sikeBenignant.UseVisualStyleBackColor = True
        ' 
        ' txtDisabiltyType
        ' 
        txtDisabiltyType.BackColor = Color.Azure
        txtDisabiltyType.Location = New Point(125, 328)
        txtDisabiltyType.Name = "txtDisabiltyType"
        txtDisabiltyType.Size = New Size(119, 27)
        txtDisabiltyType.TabIndex = 56
        txtDisabiltyType.Text = "ادخل نوع الاعاقة"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(55, 241)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 20)
        Label7.TabIndex = 75
        Label7.Text = "نوع المرض"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(56, 434)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 20)
        Label8.TabIndex = 76
        Label8.Text = "الحالة الوظيفية"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(266, 244)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 27)
        PictureBox1.TabIndex = 77
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(12, 120)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 27)
        PictureBox2.TabIndex = 78
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(12, 59)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 27)
        PictureBox3.TabIndex = 79
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(266, 328)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(37, 27)
        PictureBox4.TabIndex = 80
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Location = New Point(322, 482)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 27)
        PictureBox5.TabIndex = 81
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Location = New Point(322, 430)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(37, 27)
        PictureBox6.TabIndex = 82
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Location = New Point(12, 183)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(37, 27)
        PictureBox7.TabIndex = 83
        PictureBox7.TabStop = False
        ' 
        ' family
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(515, 555)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(rdoDoesNotWork)
        Controls.Add(rdoWorks)
        Controls.Add(Label7)
        Controls.Add(txtDisabiltyType)
        Controls.Add(CheckBox_sikeBenignant)
        Controls.Add(CheckBox_sikeSly)
        Controls.Add(CheckBox_sikeHindring)
        Controls.Add(CheckBox_sikeSuger)
        Controls.Add(CheckBox_sikePressure)
        Controls.Add(btnClear)
        Controls.Add(btnRegister)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(txtTreatmentType)
        Controls.Add(txtNotes)
        Controls.Add(GroupBox_NeedSupport)
        Controls.Add(GroupBox_treatment)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(txtAge)
        Controls.Add(txtRelation)
        MaximizeBox = False
        MinimizeBox = False
        Name = "family"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل عائلة"
        GroupBox_treatment.ResumeLayout(False)
        GroupBox_treatment.PerformLayout()
        GroupBox_NeedSupport.ResumeLayout(False)
        GroupBox_NeedSupport.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtRelation As TextBox
    Friend WithEvents rdoWorks As RadioButton
    Friend WithEvents rdoDoesNotWork As RadioButton
    Friend WithEvents GroupBox_treatment As GroupBox
    Friend WithEvents rdoTreatmentYes As RadioButton
    Friend WithEvents rdoTreatmentNo As RadioButton
    Friend WithEvents GroupBox_NeedSupport As GroupBox
    Friend WithEvents rdoSupportYes As RadioButton
    Friend WithEvents rdoSupportNo As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTreatmentType As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents CheckBox_sikePressure As CheckBox
    Friend WithEvents CheckBox_sikeSuger As CheckBox
    Friend WithEvents CheckBox_sikeHindring As CheckBox
    Friend WithEvents CheckBox_sikeSly As CheckBox
    Friend WithEvents CheckBox_sikeBenignant As CheckBox
    Friend WithEvents txtDisabiltyType As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
