<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicalRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medicalRecord))
        patient_age = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        patient_id = New TextBox()
        patient_name = New TextBox()
        suber_id = New TextBox()
        TextBox_istability = New TextBox()
        Label_siketype = New Label()
        CheckBox_sikeBenignant = New CheckBox()
        CheckBox_sikeHindring = New CheckBox()
        CheckBox_sikeSly = New CheckBox()
        CheckBox_sikeSuger = New CheckBox()
        CheckBox_sikePressure = New CheckBox()
        DataGridView_Medical = New DataGridView()
        Button_patient_save = New Button()
        Button_patient_close = New Button()
        Button_patient_delete = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(DataGridView_Medical, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' patient_age
        ' 
        patient_age.BackColor = Color.Azure
        patient_age.Location = New Point(64, 256)
        patient_age.Name = "patient_age"
        patient_age.Size = New Size(184, 27)
        patient_age.TabIndex = 71
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(62, 233)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 70
        Label6.Text = "العمر"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(64, 177)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 69
        Label5.Text = "اسم المريض"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 68
        Label3.Text = "رقم المريض"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 67
        Label1.Text = "رقم المشترك"
        ' 
        ' patient_id
        ' 
        patient_id.BackColor = Color.Azure
        patient_id.Location = New Point(64, 129)
        patient_id.Name = "patient_id"
        patient_id.Size = New Size(184, 27)
        patient_id.TabIndex = 66
        ' 
        ' patient_name
        ' 
        patient_name.BackColor = Color.Azure
        patient_name.Location = New Point(62, 200)
        patient_name.Name = "patient_name"
        patient_name.Size = New Size(184, 27)
        patient_name.TabIndex = 65
        ' 
        ' suber_id
        ' 
        suber_id.BackColor = Color.Azure
        suber_id.Location = New Point(64, 60)
        suber_id.Name = "suber_id"
        suber_id.Size = New Size(184, 27)
        suber_id.TabIndex = 64
        ' 
        ' TextBox_istability
        ' 
        TextBox_istability.BackColor = Color.Azure
        TextBox_istability.Location = New Point(149, 409)
        TextBox_istability.Name = "TextBox_istability"
        TextBox_istability.Size = New Size(119, 27)
        TextBox_istability.TabIndex = 78
        TextBox_istability.Text = "ادخل نوع الاعاقة"
        ' 
        ' Label_siketype
        ' 
        Label_siketype.AutoSize = True
        Label_siketype.Location = New Point(64, 324)
        Label_siketype.Name = "Label_siketype"
        Label_siketype.Size = New Size(78, 20)
        Label_siketype.TabIndex = 77
        Label_siketype.Text = "نوع المرض"
        ' 
        ' CheckBox_sikeBenignant
        ' 
        CheckBox_sikeBenignant.AutoSize = True
        CheckBox_sikeBenignant.Location = New Point(64, 469)
        CheckBox_sikeBenignant.Name = "CheckBox_sikeBenignant"
        CheckBox_sikeBenignant.Size = New Size(116, 24)
        CheckBox_sikeBenignant.TabIndex = 76
        CheckBox_sikeBenignant.Text = "امراض حميدة"
        CheckBox_sikeBenignant.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeHindring
        ' 
        CheckBox_sikeHindring.AutoSize = True
        CheckBox_sikeHindring.Location = New Point(64, 409)
        CheckBox_sikeHindring.Name = "CheckBox_sikeHindring"
        CheckBox_sikeHindring.Size = New Size(64, 24)
        CheckBox_sikeHindring.TabIndex = 75
        CheckBox_sikeHindring.Text = "اعاقة"
        CheckBox_sikeHindring.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSly
        ' 
        CheckBox_sikeSly.AutoSize = True
        CheckBox_sikeSly.Location = New Point(64, 439)
        CheckBox_sikeSly.Name = "CheckBox_sikeSly"
        CheckBox_sikeSly.Size = New Size(109, 24)
        CheckBox_sikeSly.TabIndex = 74
        CheckBox_sikeSly.Text = "امراض خبيثة"
        CheckBox_sikeSly.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSuger
        ' 
        CheckBox_sikeSuger.AutoSize = True
        CheckBox_sikeSuger.Location = New Point(64, 379)
        CheckBox_sikeSuger.Name = "CheckBox_sikeSuger"
        CheckBox_sikeSuger.Size = New Size(58, 24)
        CheckBox_sikeSuger.TabIndex = 73
        CheckBox_sikeSuger.Text = "سكر"
        CheckBox_sikeSuger.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikePressure
        ' 
        CheckBox_sikePressure.AutoSize = True
        CheckBox_sikePressure.Location = New Point(64, 349)
        CheckBox_sikePressure.Name = "CheckBox_sikePressure"
        CheckBox_sikePressure.Size = New Size(68, 24)
        CheckBox_sikePressure.TabIndex = 72
        CheckBox_sikePressure.Text = "ضغط"
        CheckBox_sikePressure.UseVisualStyleBackColor = True
        ' 
        ' DataGridView_Medical
        ' 
        DataGridView_Medical.BackgroundColor = Color.Azure
        DataGridView_Medical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Medical.Location = New Point(274, 127)
        DataGridView_Medical.Name = "DataGridView_Medical"
        DataGridView_Medical.RowHeadersWidth = 51
        DataGridView_Medical.Size = New Size(284, 366)
        DataGridView_Medical.TabIndex = 81
        ' 
        ' Button_patient_save
        ' 
        Button_patient_save.Location = New Point(55, 513)
        Button_patient_save.Name = "Button_patient_save"
        Button_patient_save.Size = New Size(94, 29)
        Button_patient_save.TabIndex = 82
        Button_patient_save.Text = "حفظ"
        Button_patient_save.UseVisualStyleBackColor = True
        ' 
        ' Button_patient_close
        ' 
        Button_patient_close.Location = New Point(464, 535)
        Button_patient_close.Name = "Button_patient_close"
        Button_patient_close.Size = New Size(94, 27)
        Button_patient_close.TabIndex = 83
        Button_patient_close.Text = "إلغاء"
        Button_patient_close.UseVisualStyleBackColor = True
        ' 
        ' Button_patient_delete
        ' 
        Button_patient_delete.Location = New Point(55, 548)
        Button_patient_delete.Name = "Button_patient_delete"
        Button_patient_delete.Size = New Size(94, 29)
        Button_patient_delete.TabIndex = 84
        Button_patient_delete.Text = "حذف"
        Button_patient_delete.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(409, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 85
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_06_26_19_43_38
        PictureBox2.Location = New Point(22, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 86
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_26_20_05_041
        PictureBox3.Location = New Point(22, 546)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 87
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.photo_2025_06_26_20_45_55
        PictureBox4.Location = New Point(431, 535)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(36, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 88
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.photo_2025_06_26_19_36_411
        PictureBox5.Location = New Point(22, 513)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(36, 27)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 89
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.photo_2025_06_26_19_36_34
        PictureBox6.Location = New Point(22, 256)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(36, 27)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 90
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.photo_2025_06_26_20_44_42
        PictureBox7.Location = New Point(22, 200)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(36, 27)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 91
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.photo_2025_06_26_20_44_40
        PictureBox8.Location = New Point(22, 129)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(36, 27)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 92
        PictureBox8.TabStop = False
        ' 
        ' medicalRecord
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(559, 588)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button_patient_delete)
        Controls.Add(Button_patient_close)
        Controls.Add(Button_patient_save)
        Controls.Add(DataGridView_Medical)
        Controls.Add(TextBox_istability)
        Controls.Add(Label_siketype)
        Controls.Add(CheckBox_sikeBenignant)
        Controls.Add(CheckBox_sikeHindring)
        Controls.Add(CheckBox_sikeSly)
        Controls.Add(CheckBox_sikeSuger)
        Controls.Add(CheckBox_sikePressure)
        Controls.Add(patient_age)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(patient_id)
        Controls.Add(patient_name)
        Controls.Add(suber_id)
        MaximizeBox = False
        MinimizeBox = False
        Name = "medicalRecord"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة السجل الطبي"
        CType(DataGridView_Medical, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents patient_age As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents patient_id As TextBox
    Friend WithEvents patient_name As TextBox
    Friend WithEvents suber_id As TextBox
    Friend WithEvents TextBox_istability As TextBox
    Friend WithEvents Label_siketype As Label
    Friend WithEvents CheckBox_sikeBenignant As CheckBox
    Friend WithEvents CheckBox_sikeHindring As CheckBox
    Friend WithEvents CheckBox_sikeSly As CheckBox
    Friend WithEvents CheckBox_sikeSuger As CheckBox
    Friend WithEvents CheckBox_sikePressure As CheckBox
    Friend WithEvents DataGridView_Medical As DataGridView
    Friend WithEvents Button_patient_save As Button
    Friend WithEvents Button_patient_close As Button
    Friend WithEvents Button_patient_delete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox

End Class
