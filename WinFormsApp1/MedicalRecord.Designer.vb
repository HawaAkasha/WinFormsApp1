<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalRecord
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
        patient_age = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        patient_id = New TextBox()
        patient_name = New TextBox()
        sup_id = New TextBox()
        TextBox10 = New TextBox()
        Label_siketype = New Label()
        CheckBox_sikeBenignant = New CheckBox()
        CheckBox_sikeHindring = New CheckBox()
        CheckBox_sikeSly = New CheckBox()
        CheckBox_sikeSuger = New CheckBox()
        CheckBox_sikePressure = New CheckBox()
        Label2 = New Label()
        sike_deatils = New TextBox()
        DataGridView_patient = New DataGridView()
        Button_patient_save = New Button()
        Button_patient_close = New Button()
        Button_patient_delete = New Button()
        CType(DataGridView_patient, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' patient_age
        ' 
        patient_age.Location = New Point(32, 260)
        patient_age.Name = "patient_age"
        patient_age.Size = New Size(184, 27)
        patient_age.TabIndex = 71
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 70
        Label6.Text = "العمر"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 69
        Label5.Text = "اسم المريض"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 68
        Label3.Text = "رقم المريض"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 67
        Label1.Text = "رقم المشترك"
        ' 
        ' patient_id
        ' 
        patient_id.Location = New Point(32, 133)
        patient_id.Name = "patient_id"
        patient_id.Size = New Size(184, 27)
        patient_id.TabIndex = 66
        ' 
        ' patient_name
        ' 
        patient_name.Location = New Point(30, 204)
        patient_name.Name = "patient_name"
        patient_name.Size = New Size(184, 27)
        patient_name.TabIndex = 65
        ' 
        ' sup_id
        ' 
        sup_id.Location = New Point(32, 64)
        sup_id.Name = "sup_id"
        sup_id.Size = New Size(184, 27)
        sup_id.TabIndex = 64
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(117, 413)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(119, 27)
        TextBox10.TabIndex = 78
        TextBox10.Text = "ادخل نوع الاعاقة"
        ' 
        ' Label_siketype
        ' 
        Label_siketype.AutoSize = True
        Label_siketype.Location = New Point(32, 328)
        Label_siketype.Name = "Label_siketype"
        Label_siketype.Size = New Size(78, 20)
        Label_siketype.TabIndex = 77
        Label_siketype.Text = "نوع المرض"
        ' 
        ' CheckBox_sikeBenignant
        ' 
        CheckBox_sikeBenignant.AutoSize = True
        CheckBox_sikeBenignant.Location = New Point(32, 473)
        CheckBox_sikeBenignant.Name = "CheckBox_sikeBenignant"
        CheckBox_sikeBenignant.Size = New Size(116, 24)
        CheckBox_sikeBenignant.TabIndex = 76
        CheckBox_sikeBenignant.Text = "امراض حميدة"
        CheckBox_sikeBenignant.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeHindring
        ' 
        CheckBox_sikeHindring.AutoSize = True
        CheckBox_sikeHindring.Location = New Point(32, 413)
        CheckBox_sikeHindring.Name = "CheckBox_sikeHindring"
        CheckBox_sikeHindring.Size = New Size(64, 24)
        CheckBox_sikeHindring.TabIndex = 75
        CheckBox_sikeHindring.Text = "اعاقة"
        CheckBox_sikeHindring.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSly
        ' 
        CheckBox_sikeSly.AutoSize = True
        CheckBox_sikeSly.Location = New Point(32, 443)
        CheckBox_sikeSly.Name = "CheckBox_sikeSly"
        CheckBox_sikeSly.Size = New Size(109, 24)
        CheckBox_sikeSly.TabIndex = 74
        CheckBox_sikeSly.Text = "امراض خبيثة"
        CheckBox_sikeSly.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikeSuger
        ' 
        CheckBox_sikeSuger.AutoSize = True
        CheckBox_sikeSuger.Location = New Point(32, 383)
        CheckBox_sikeSuger.Name = "CheckBox_sikeSuger"
        CheckBox_sikeSuger.Size = New Size(58, 24)
        CheckBox_sikeSuger.TabIndex = 73
        CheckBox_sikeSuger.Text = "سكر"
        CheckBox_sikeSuger.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_sikePressure
        ' 
        CheckBox_sikePressure.AutoSize = True
        CheckBox_sikePressure.Location = New Point(32, 353)
        CheckBox_sikePressure.Name = "CheckBox_sikePressure"
        CheckBox_sikePressure.Size = New Size(68, 24)
        CheckBox_sikePressure.TabIndex = 72
        CheckBox_sikePressure.Text = "ضغط"
        CheckBox_sikePressure.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(286, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 80
        Label2.Text = "تفاصيل المرض"
        ' 
        ' sike_deatils
        ' 
        sike_deatils.Location = New Point(291, 64)
        sike_deatils.Name = "sike_deatils"
        sike_deatils.Size = New Size(184, 27)
        sike_deatils.TabIndex = 79
        ' 
        ' DataGridView_patient
        ' 
        DataGridView_patient.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_patient.Location = New Point(284, 122)
        DataGridView_patient.Name = "DataGridView_patient"
        DataGridView_patient.RowHeadersWidth = 51
        DataGridView_patient.Size = New Size(242, 340)
        DataGridView_patient.TabIndex = 81
        ' 
        ' Button_patient_save
        ' 
        Button_patient_save.Location = New Point(23, 537)
        Button_patient_save.Name = "Button_patient_save"
        Button_patient_save.Size = New Size(94, 29)
        Button_patient_save.TabIndex = 82
        Button_patient_save.Text = "حفظ"
        Button_patient_save.UseVisualStyleBackColor = True
        ' 
        ' Button_patient_close
        ' 
        Button_patient_close.Location = New Point(432, 473)
        Button_patient_close.Name = "Button_patient_close"
        Button_patient_close.Size = New Size(94, 35)
        Button_patient_close.TabIndex = 83
        Button_patient_close.Text = "إلغاء"
        Button_patient_close.UseVisualStyleBackColor = True
        ' 
        ' Button_patient_delete
        ' 
        Button_patient_delete.Location = New Point(123, 537)
        Button_patient_delete.Name = "Button_patient_delete"
        Button_patient_delete.Size = New Size(94, 29)
        Button_patient_delete.TabIndex = 84
        Button_patient_delete.Text = "حذف"
        Button_patient_delete.UseVisualStyleBackColor = True
        ' 
        ' MedicalRecord
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(549, 588)
        Controls.Add(Button_patient_delete)
        Controls.Add(Button_patient_close)
        Controls.Add(Button_patient_save)
        Controls.Add(DataGridView_patient)
        Controls.Add(Label2)
        Controls.Add(sike_deatils)
        Controls.Add(TextBox10)
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
        Controls.Add(sup_id)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MedicalRecord"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة السجل الطبي"
        CType(DataGridView_patient, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sup_id As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label_siketype As Label
    Friend WithEvents CheckBox_sikeBenignant As CheckBox
    Friend WithEvents CheckBox_sikeHindring As CheckBox
    Friend WithEvents CheckBox_sikeSly As CheckBox
    Friend WithEvents CheckBox_sikeSuger As CheckBox
    Friend WithEvents CheckBox_sikePressure As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sike_deatils As TextBox
    Friend WithEvents DataGridView_patient As DataGridView
    Friend WithEvents Button_patient_save As Button
    Friend WithEvents Button_patient_close As Button
    Friend WithEvents Button_patient_delete As Button
End Class
