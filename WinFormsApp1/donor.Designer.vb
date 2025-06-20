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
        Label_type_donation = New Label()
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
        DateTimePicker = New DateTimePicker()
        Button_delete = New Button()
        GroupBox_donationtype.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 298)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 62
        Label6.Text = "تاريخ التبرع"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 61
        Label5.Text = "رقم الهاتف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 59
        Label3.Text = "الاسم"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 20)
        Label1.TabIndex = 57
        Label1.Text = "رقم البطاقة الشخصية"
        ' 
        ' donor_name
        ' 
        donor_name.Location = New Point(42, 173)
        donor_name.Name = "donor_name"
        donor_name.Size = New Size(184, 27)
        donor_name.TabIndex = 55
        ' 
        ' donor_number
        ' 
        donor_number.Location = New Point(40, 244)
        donor_number.Name = "donor_number"
        donor_number.Size = New Size(184, 27)
        donor_number.TabIndex = 53
        ' 
        ' donor_id
        ' 
        donor_id.Location = New Point(42, 104)
        donor_id.Name = "donor_id"
        donor_id.Size = New Size(184, 27)
        donor_id.TabIndex = 52
        ' 
        ' Label_type_donation
        ' 
        Label_type_donation.AutoSize = True
        Label_type_donation.Location = New Point(308, 81)
        Label_type_donation.Name = "Label_type_donation"
        Label_type_donation.Size = New Size(69, 20)
        Label_type_donation.TabIndex = 68
        Label_type_donation.Text = "نوع التبرع"
        ' 
        ' CheckBox_medicine
        ' 
        CheckBox_medicine.AutoSize = True
        CheckBox_medicine.Location = New Point(315, 236)
        CheckBox_medicine.Name = "CheckBox_medicine"
        CheckBox_medicine.Size = New Size(136, 24)
        CheckBox_medicine.TabIndex = 67
        CheckBox_medicine.Text = "مستلزمات صحية"
        CheckBox_medicine.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_eat
        ' 
        CheckBox_eat.AutoSize = True
        CheckBox_eat.Location = New Point(315, 146)
        CheckBox_eat.Name = "CheckBox_eat"
        CheckBox_eat.Size = New Size(103, 24)
        CheckBox_eat.TabIndex = 66
        CheckBox_eat.Text = "مواد غذائية"
        CheckBox_eat.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_clothes
        ' 
        CheckBox_clothes.AutoSize = True
        CheckBox_clothes.Location = New Point(315, 187)
        CheckBox_clothes.Name = "CheckBox_clothes"
        CheckBox_clothes.Size = New Size(72, 24)
        CheckBox_clothes.TabIndex = 65
        CheckBox_clothes.Text = "ملابس"
        CheckBox_clothes.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_money
        ' 
        CheckBox_money.AutoSize = True
        CheckBox_money.Location = New Point(315, 104)
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
        Label4.Location = New Point(308, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 75
        Label4.Text = "الكمية/القيمة"
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(310, 321)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(184, 27)
        TextBox_quantity.TabIndex = 74
        ' 
        ' Button_donation
        ' 
        Button_donation.Location = New Point(488, 495)
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
        GroupBox_donationtype.Location = New Point(308, 367)
        GroupBox_donationtype.Name = "GroupBox_donationtype"
        GroupBox_donationtype.Size = New Size(119, 125)
        GroupBox_donationtype.TabIndex = 77
        GroupBox_donationtype.TabStop = False
        GroupBox_donationtype.Text = "طريقة التبرع"
        ' 
        ' TextBox_eat
        ' 
        TextBox_eat.Location = New Point(424, 143)
        TextBox_eat.Name = "TextBox_eat"
        TextBox_eat.Size = New Size(125, 27)
        TextBox_eat.TabIndex = 78
        ' 
        ' TextBox_cloth
        ' 
        TextBox_cloth.Location = New Point(424, 187)
        TextBox_cloth.Name = "TextBox_cloth"
        TextBox_cloth.Size = New Size(125, 27)
        TextBox_cloth.TabIndex = 79
        ' 
        ' TextBox_medi
        ' 
        TextBox_medi.Location = New Point(457, 236)
        TextBox_medi.Name = "TextBox_medi"
        TextBox_medi.Size = New Size(125, 27)
        TextBox_medi.TabIndex = 80
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(40, 324)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(184, 27)
        DateTimePicker.TabIndex = 81
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(476, 531)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(94, 29)
        Button_delete.TabIndex = 82
        Button_delete.Text = "حذف"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' donor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(607, 572)
        Controls.Add(Button_delete)
        Controls.Add(DateTimePicker)
        Controls.Add(TextBox_medi)
        Controls.Add(TextBox_cloth)
        Controls.Add(TextBox_eat)
        Controls.Add(GroupBox_donationtype)
        Controls.Add(Button_donation)
        Controls.Add(Label4)
        Controls.Add(TextBox_quantity)
        Controls.Add(Label_type_donation)
        Controls.Add(CheckBox_medicine)
        Controls.Add(CheckBox_eat)
        Controls.Add(CheckBox_clothes)
        Controls.Add(CheckBox_money)
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
    Friend WithEvents Label_type_donation As Label
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
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Button_delete As Button
End Class
