﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(donor))
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
        Label_money = New Label()
        Label_trance = New Label()
        TextBox_eat = New TextBox()
        TextBox_cloth = New TextBox()
        TextBox_medi = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        donation_type = New GroupBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        Label_delivery = New Label()
        GroupBox_donationtype.SuspendLayout()
        donation_type.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 62
        Label6.Text = "تاريخ التبرع"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(47, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 61
        Label5.Text = "رقم الهاتف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 59
        Label3.Text = "الاسم"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 20)
        Label1.TabIndex = 57
        Label1.Text = "رقم البطاقة الشخصية"
        ' 
        ' donor_name
        ' 
        donor_name.BackColor = Color.Azure
        donor_name.Location = New Point(47, 128)
        donor_name.Name = "donor_name"
        donor_name.Size = New Size(184, 27)
        donor_name.TabIndex = 55
        ' 
        ' donor_number
        ' 
        donor_number.BackColor = Color.Azure
        donor_number.Location = New Point(45, 199)
        donor_number.Name = "donor_number"
        donor_number.Size = New Size(184, 27)
        donor_number.TabIndex = 53
        ' 
        ' donor_id
        ' 
        donor_id.BackColor = Color.Azure
        donor_id.Location = New Point(47, 59)
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
        trance.Location = New Point(141, 73)
        trance.Name = "trance"
        trance.Size = New Size(69, 24)
        trance.TabIndex = 71
        trance.Text = "تحويل"
        trance.UseVisualStyleBackColor = True
        ' 
        ' delivery
        ' 
        delivery.AutoSize = True
        delivery.Location = New Point(298, 410)
        delivery.Name = "delivery"
        delivery.Size = New Size(74, 24)
        delivery.TabIndex = 70
        delivery.Text = "توصيل"
        delivery.UseVisualStyleBackColor = True
        ' 
        ' cash
        ' 
        cash.AutoSize = True
        cash.Location = New Point(147, 34)
        cash.Name = "cash"
        cash.Size = New Size(63, 24)
        cash.TabIndex = 69
        cash.Text = "نقدي"
        cash.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(298, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 75
        Label4.Text = "الكمية/القيمة"
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.BackColor = Color.Azure
        TextBox_quantity.Location = New Point(298, 130)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(184, 27)
        TextBox_quantity.TabIndex = 74
        ' 
        ' Button_donation
        ' 
        Button_donation.Location = New Point(389, 496)
        Button_donation.Name = "Button_donation"
        Button_donation.Size = New Size(115, 29)
        Button_donation.TabIndex = 76
        Button_donation.Text = "تبرع الان"
        Button_donation.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_donationtype
        ' 
        GroupBox_donationtype.Controls.Add(Label_money)
        GroupBox_donationtype.Controls.Add(Label_trance)
        GroupBox_donationtype.Controls.Add(cash)
        GroupBox_donationtype.Controls.Add(trance)
        GroupBox_donationtype.Location = New Point(266, 176)
        GroupBox_donationtype.Name = "GroupBox_donationtype"
        GroupBox_donationtype.Size = New Size(216, 114)
        GroupBox_donationtype.TabIndex = 77
        GroupBox_donationtype.TabStop = False
        GroupBox_donationtype.Text = "طريقة التبرع"
        ' 
        ' Label_money
        ' 
        Label_money.AutoSize = True
        Label_money.Location = New Point(58, 38)
        Label_money.Name = "Label_money"
        Label_money.Size = New Size(43, 20)
        Label_money.TabIndex = 95
        Label_money.Text = "هاتف"
        ' 
        ' Label_trance
        ' 
        Label_trance.AutoSize = True
        Label_trance.Location = New Point(58, 73)
        Label_trance.Name = "Label_trance"
        Label_trance.Size = New Size(49, 20)
        Label_trance.TabIndex = 94
        Label_trance.Text = "حساب"
        ' 
        ' TextBox_eat
        ' 
        TextBox_eat.BackColor = Color.Azure
        TextBox_eat.Location = New Point(6, 67)
        TextBox_eat.Name = "TextBox_eat"
        TextBox_eat.Size = New Size(125, 27)
        TextBox_eat.TabIndex = 78
        ' 
        ' TextBox_cloth
        ' 
        TextBox_cloth.BackColor = Color.Azure
        TextBox_cloth.Location = New Point(6, 109)
        TextBox_cloth.Name = "TextBox_cloth"
        TextBox_cloth.Size = New Size(125, 27)
        TextBox_cloth.TabIndex = 79
        ' 
        ' TextBox_medi
        ' 
        TextBox_medi.BackColor = Color.Azure
        TextBox_medi.Location = New Point(6, 158)
        TextBox_medi.Name = "TextBox_medi"
        TextBox_medi.Size = New Size(125, 27)
        TextBox_medi.TabIndex = 80
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = Color.Azure
        DateTimePicker1.Location = New Point(45, 279)
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
        donation_type.Location = New Point(12, 340)
        donation_type.Name = "donation_type"
        donation_type.Size = New Size(280, 191)
        donation_type.TabIndex = 83
        donation_type.TabStop = False
        donation_type.Text = "نوع التبرع"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 84
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_06_26_19_36_32
        PictureBox2.Location = New Point(12, 199)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 85
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_26_19_43_38
        PictureBox3.Location = New Point(12, 128)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(35, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 86
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.photo_2025_06_26_19_38_40
        PictureBox4.Location = New Point(12, 279)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(35, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 87
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.photo_2025_06_26_19_36_35
        PictureBox5.Location = New Point(356, 498)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(35, 27)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 88
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.photo_2025_06_26_19_36_29
        PictureBox6.Location = New Point(266, 130)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(35, 27)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 89
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(389, -1)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(125, 128)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 90
        PictureBox7.TabStop = False
        ' 
        ' Label_delivery
        ' 
        Label_delivery.AutoSize = True
        Label_delivery.Location = New Point(378, 411)
        Label_delivery.Name = "Label_delivery"
        Label_delivery.Size = New Size(49, 20)
        Label_delivery.TabIndex = 93
        Label_delivery.Text = "المكان"
        ' 
        ' donor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(516, 543)
        Controls.Add(delivery)
        Controls.Add(Label_delivery)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label_delivery As Label
    Friend WithEvents Label_trance As Label
    Friend WithEvents Label_money As Label
End Class
