<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donation
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
        donor_date = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        donor_name = New TextBox()
        donor_number = New TextBox()
        Label_type_donation = New Label()
        CheckBox_medicine = New CheckBox()
        CheckBox_eat = New CheckBox()
        CheckBox_clothes = New CheckBox()
        CheckBox_money = New CheckBox()
        Label4 = New Label()
        TextBox_quantity = New TextBox()
        Button_save = New Button()
        DataGridView_donation = New DataGridView()
        CType(DataGridView_donation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' donor_date
        ' 
        donor_date.Location = New Point(26, 397)
        donor_date.Name = "donor_date"
        donor_date.Size = New Size(184, 27)
        donor_date.TabIndex = 69
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 68
        Label6.Text = "تاريخ التبرع"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 67
        Label5.Text = "رقم الهاتف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 66
        Label3.Text = "الاسم المتبرع"
        ' 
        ' donor_name
        ' 
        donor_name.Location = New Point(26, 92)
        donor_name.Name = "donor_name"
        donor_name.Size = New Size(184, 27)
        donor_name.TabIndex = 65
        ' 
        ' donor_number
        ' 
        donor_number.Location = New Point(24, 163)
        donor_number.Name = "donor_number"
        donor_number.Size = New Size(184, 27)
        donor_number.TabIndex = 64
        ' 
        ' Label_type_donation
        ' 
        Label_type_donation.AutoSize = True
        Label_type_donation.Location = New Point(33, 219)
        Label_type_donation.Name = "Label_type_donation"
        Label_type_donation.Size = New Size(69, 20)
        Label_type_donation.TabIndex = 74
        Label_type_donation.Text = "نوع التبرع"
        ' 
        ' CheckBox_medicine
        ' 
        CheckBox_medicine.AutoSize = True
        CheckBox_medicine.Location = New Point(33, 332)
        CheckBox_medicine.Name = "CheckBox_medicine"
        CheckBox_medicine.Size = New Size(136, 24)
        CheckBox_medicine.TabIndex = 73
        CheckBox_medicine.Text = "مستلزمات صحية"
        CheckBox_medicine.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_eat
        ' 
        CheckBox_eat.AutoSize = True
        CheckBox_eat.Location = New Point(33, 272)
        CheckBox_eat.Name = "CheckBox_eat"
        CheckBox_eat.Size = New Size(103, 24)
        CheckBox_eat.TabIndex = 72
        CheckBox_eat.Text = "مواد غذائية"
        CheckBox_eat.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_clothes
        ' 
        CheckBox_clothes.AutoSize = True
        CheckBox_clothes.Location = New Point(33, 302)
        CheckBox_clothes.Name = "CheckBox_clothes"
        CheckBox_clothes.Size = New Size(72, 24)
        CheckBox_clothes.TabIndex = 71
        CheckBox_clothes.Text = "ملابس"
        CheckBox_clothes.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_money
        ' 
        CheckBox_money.AutoSize = True
        CheckBox_money.Location = New Point(33, 242)
        CheckBox_money.Name = "CheckBox_money"
        CheckBox_money.Size = New Size(62, 24)
        CheckBox_money.TabIndex = 70
        CheckBox_money.Text = "مالي"
        CheckBox_money.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(272, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 77
        Label4.Text = "الكمية/القيمة"
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(274, 92)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(184, 27)
        TextBox_quantity.TabIndex = 76
        ' 
        ' Button_save
        ' 
        Button_save.Location = New Point(454, 446)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(94, 29)
        Button_save.TabIndex = 78
        Button_save.Text = "حفظ"
        Button_save.UseVisualStyleBackColor = True
        ' 
        ' DataGridView_donation
        ' 
        DataGridView_donation.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_donation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_donation.Location = New Point(272, 140)
        DataGridView_donation.Name = "DataGridView_donation"
        DataGridView_donation.RowHeadersWidth = 51
        DataGridView_donation.Size = New Size(276, 287)
        DataGridView_donation.TabIndex = 79
        ' 
        ' Donation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(571, 495)
        Controls.Add(DataGridView_donation)
        Controls.Add(Button_save)
        Controls.Add(Label4)
        Controls.Add(TextBox_quantity)
        Controls.Add(Label_type_donation)
        Controls.Add(CheckBox_medicine)
        Controls.Add(CheckBox_eat)
        Controls.Add(CheckBox_clothes)
        Controls.Add(CheckBox_money)
        Controls.Add(donor_date)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(donor_name)
        Controls.Add(donor_number)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Donation"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل التبرع"
        CType(DataGridView_donation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents donor_date As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents donor_name As TextBox
    Friend WithEvents donor_number As TextBox
    Friend WithEvents Label_type_donation As Label
    Friend WithEvents CheckBox_medicine As CheckBox
    Friend WithEvents CheckBox_eat As CheckBox
    Friend WithEvents CheckBox_clothes As CheckBox
    Friend WithEvents CheckBox_money As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents Button_save As Button
    Friend WithEvents DataGridView_donation As DataGridView
End Class
