<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class donor
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
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        donor_name = New TextBox()
        donor_number = New TextBox()
        donor_id = New TextBox()
        CheckBox_medicine = New CheckBox()
        CheckBox_eat = New CheckBox()
        CheckBox_clothes = New CheckBox()
        CheckBox_money = New CheckBox()
        trance = New CheckBox()
        delivery = New CheckBox()
        cash = New CheckBox()
        Label4 = New Label()
        TextBox_quantity = New TextBox()
        Button_donation = New Button()
        GroupBox_donationtype = New GroupBox()
        TextBox_eat = New TextBox()
        TextBox_cloth = New TextBox()
        TextBox_medi = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        donation_type = New GroupBox()
        GroupBox_donationtype.SuspendLayout()
        donation_type.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 62
        Label6.Text = "تاريخ التبرع"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 61
        Label5.Text = "رقم الهاتف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 59
        Label3.Text = "الاسم"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 20)
        Label1.TabIndex = 57
        Label1.Text = "رقم البطاقة الشخصية"
        ' 
        ' donor_name
        ' 
        donor_name.Location = New Point(15, 128)
        donor_name.Name = "donor_name"
        donor_name.Size = New Size(184, 27)
        donor_name.TabIndex = 55
        ' 
        ' donor_number
        ' 
        donor_number.Location = New Point(13, 199)
        donor_number.Name = "donor_number"
        donor_number.Size = New Size(184, 27)
        donor_number.TabIndex = 53
        ' 
        ' donor_id
        ' 
        donor_id.Location = New Point(15, 59)
        donor_id.Name = "donor_id"
        donor_id.Size = New Size(184, 27)
        donor_id.TabIndex = 52
        ' 
        ' CheckBox_medicine
        ' 
        CheckBox_medicine.AutoSize = True
        CheckBox_medicine.Location = New Point(133, 161)
        CheckBox_medicine.Name = "CheckBox_medicine"
        CheckBox_medicine.Size = New Size(136, 24)
        CheckBox_medicine.TabIndex = 67
        CheckBox_medicine.Text = "مستلزمات صحية"
        CheckBox_medicine.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_eat
        ' 
        CheckBox_eat.AutoSize = True
        CheckBox_eat.Location = New Point(164, 67)
        CheckBox_eat.Name = "CheckBox_eat"
        CheckBox_eat.Size = New Size(103, 24)
        CheckBox_eat.TabIndex = 66
        CheckBox_eat.Text = "مواد غذائية"
        CheckBox_eat.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_clothes
        ' 
        CheckBox_clothes.AutoSize = True
        CheckBox_clothes.Location = New Point(195, 112)
        CheckBox_clothes.Name = "CheckBox_clothes"
        CheckBox_clothes.Size = New Size(72, 24)
        CheckBox_clothes.TabIndex = 65
        CheckBox_clothes.Text = "ملابس"
        CheckBox_clothes.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_money
        ' 
        CheckBox_money.AutoSize = True
        CheckBox_money.Location = New Point(205, 26)
        CheckBox_money.Name = "CheckBox_money"
        CheckBox_money.Size = New Size(62, 24)
        CheckBox_money.TabIndex = 64
        CheckBox_money.Text = "مالي"
        CheckBox_money.UseVisualStyleBackColor = True
        ' 
        ' trance
        ' 
        trance.AutoSize = True
        trance.Location = New Point(43, 56)
        trance.Name = "trance"
        trance.Size = New Size(69, 24)
        trance.TabIndex = 71
        trance.Text = "تحويل"
        trance.UseVisualStyleBackColor = True
        ' 
        ' delivery
        ' 
        delivery.AutoSize = True
        delivery.Location = New Point(38, 86)
        delivery.Name = "delivery"
        delivery.Size = New Size(74, 24)
        delivery.TabIndex = 70
        delivery.Text = "توصيل"
        delivery.UseVisualStyleBackColor = True
        ' 
        ' cash
        ' 
        cash.AutoSize = True
        cash.Location = New Point(49, 26)
        cash.Name = "cash"
        cash.Size = New Size(63, 24)
        cash.TabIndex = 69
        cash.Text = "نقدي"
        cash.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(258, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 75
        Label4.Text = "الكمية/القيمة"
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(258, 276)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(184, 27)
        TextBox_quantity.TabIndex = 74
        ' 
        ' Button_donation
        ' 
        Button_donation.Location = New Point(12, 424)
        Button_donation.Name = "Button_donation"
        Button_donation.Size = New Size(94, 29)
        Button_donation.TabIndex = 76
        Button_donation.Text = "تبرع الان"
        Button_donation.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_donationtype
        ' 
        GroupBox_donationtype.Controls.Add(cash)
        GroupBox_donationtype.Controls.Add(delivery)
        GroupBox_donationtype.Controls.Add(trance)
        GroupBox_donationtype.Location = New Point(258, 321)
        GroupBox_donationtype.Name = "GroupBox_donationtype"
        GroupBox_donationtype.Size = New Size(119, 125)
        GroupBox_donationtype.TabIndex = 77
        GroupBox_donationtype.TabStop = False
        GroupBox_donationtype.Text = "طريقة التبرع"
        ' 
        ' TextBox_eat
        ' 
        TextBox_eat.Location = New Point(6, 67)
        TextBox_eat.Name = "TextBox_eat"
        TextBox_eat.Size = New Size(125, 27)
        TextBox_eat.TabIndex = 78
        ' 
        ' TextBox_cloth
        ' 
        TextBox_cloth.Location = New Point(6, 109)
        TextBox_cloth.Name = "TextBox_cloth"
        TextBox_cloth.Size = New Size(125, 27)
        TextBox_cloth.TabIndex = 79
        ' 
        ' TextBox_medi
        ' 
        TextBox_medi.Location = New Point(6, 158)
        TextBox_medi.Name = "TextBox_medi"
        TextBox_medi.Size = New Size(125, 27)
        TextBox_medi.TabIndex = 80
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(13, 279)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(184, 27)
        DateTimePicker1.TabIndex = 81
        ' 
        ' donation_type
        ' 
        donation_type.Controls.Add(CheckBox_money)
        donation_type.Controls.Add(CheckBox_eat)
        donation_type.Controls.Add(CheckBox_clothes)
        donation_type.Controls.Add(TextBox_medi)
        donation_type.Controls.Add(CheckBox_medicine)
        donation_type.Controls.Add(TextBox_cloth)
        donation_type.Controls.Add(TextBox_eat)
        donation_type.Location = New Point(258, 35)
        donation_type.Name = "donation_type"
        donation_type.Size = New Size(280, 191)
        donation_type.TabIndex = 83
        donation_type.TabStop = False
        donation_type.Text = "نوع التبرع"
        ' 
        ' donor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(581, 465)
        Controls.Add(donation_type)
        Controls.Add(DateTimePicker1)
        Controls.Add(GroupBox_donationtype)
        Controls.Add(Button_donation)
        Controls.Add(Label4)
        Controls.Add(TextBox_quantity)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(donor_name)
        Controls.Add(donor_number)
        Controls.Add(donor_id)
        MaximizeBox = False
        MinimizeBox = False
        Name = "donor"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل متبرع"
        GroupBox_donationtype.ResumeLayout(False)
        GroupBox_donationtype.PerformLayout()
        donation_type.ResumeLayout(False)
        donation_type.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents donor_name As TextBox
    Friend WithEvents donor_number As TextBox
    Friend WithEvents donor_id As TextBox
    Friend WithEvents CheckBox_medicine As CheckBox
    Friend WithEvents CheckBox_eat As CheckBox
    Friend WithEvents CheckBox_clothes As CheckBox
    Friend WithEvents CheckBox_money As CheckBox
    Friend WithEvents trance As CheckBox
    Friend WithEvents delivery As CheckBox
    Friend WithEvents cash As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents Button_donation As Button
    Friend WithEvents GroupBox_donationtype As GroupBox
    Friend WithEvents TextBox_eat As TextBox
    Friend WithEvents TextBox_cloth As TextBox
    Friend WithEvents TextBox_medi As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents donation_type As GroupBox
End Class
