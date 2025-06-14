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
        donor_date = New TextBox()
        Label_type_donation = New Label()
        CheckBox_medicine = New CheckBox()
        CheckBox_eat = New CheckBox()
        CheckBox_clothes = New CheckBox()
        CheckBox_money = New CheckBox()
        Label_donationmethod = New Label()
        trance = New CheckBox()
        delivery = New CheckBox()
        cash = New CheckBox()
        Label4 = New Label()
        TextBox_quantity = New TextBox()
        Button_donation = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 277)
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
        ' donor_date
        ' 
        donor_date.Location = New Point(42, 319)
        donor_date.Name = "donor_date"
        donor_date.Size = New Size(184, 27)
        donor_date.TabIndex = 63
        ' 
        ' Label_type_donation
        ' 
        Label_type_donation.AutoSize = True
        Label_type_donation.Location = New Point(325, 81)
        Label_type_donation.Name = "Label_type_donation"
        Label_type_donation.Size = New Size(69, 20)
        Label_type_donation.TabIndex = 68
        Label_type_donation.Text = "نوع التبرع"
        ' 
        ' CheckBox_medicine
        ' 
        CheckBox_medicine.AutoSize = True
        CheckBox_medicine.Location = New Point(325, 194)
        CheckBox_medicine.Name = "CheckBox_medicine"
        CheckBox_medicine.Size = New Size(136, 24)
        CheckBox_medicine.TabIndex = 67
        CheckBox_medicine.Text = "مستلزمات صحية"
        CheckBox_medicine.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_eat
        ' 
        CheckBox_eat.AutoSize = True
        CheckBox_eat.Location = New Point(325, 134)
        CheckBox_eat.Name = "CheckBox_eat"
        CheckBox_eat.Size = New Size(103, 24)
        CheckBox_eat.TabIndex = 66
        CheckBox_eat.Text = "مواد غذائية"
        CheckBox_eat.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_clothes
        ' 
        CheckBox_clothes.AutoSize = True
        CheckBox_clothes.Location = New Point(325, 164)
        CheckBox_clothes.Name = "CheckBox_clothes"
        CheckBox_clothes.Size = New Size(72, 24)
        CheckBox_clothes.TabIndex = 65
        CheckBox_clothes.Text = "ملابس"
        CheckBox_clothes.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_money
        ' 
        CheckBox_money.AutoSize = True
        CheckBox_money.Location = New Point(325, 104)
        CheckBox_money.Name = "CheckBox_money"
        CheckBox_money.Size = New Size(62, 24)
        CheckBox_money.TabIndex = 64
        CheckBox_money.Text = "مالي"
        CheckBox_money.UseVisualStyleBackColor = True
        ' 
        ' Label_donationmethod
        ' 
        Label_donationmethod.AutoSize = True
        Label_donationmethod.Location = New Point(325, 244)
        Label_donationmethod.Name = "Label_donationmethod"
        Label_donationmethod.Size = New Size(88, 20)
        Label_donationmethod.TabIndex = 73
        Label_donationmethod.Text = "طريقة التبرع"
        ' 
        ' trance
        ' 
        trance.AutoSize = True
        trance.Location = New Point(325, 297)
        trance.Name = "trance"
        trance.Size = New Size(69, 24)
        trance.TabIndex = 71
        trance.Text = "تحويل"
        trance.UseVisualStyleBackColor = True
        ' 
        ' delivery
        ' 
        delivery.AutoSize = True
        delivery.Location = New Point(325, 327)
        delivery.Name = "delivery"
        delivery.Size = New Size(74, 24)
        delivery.TabIndex = 70
        delivery.Text = "توصيل"
        delivery.UseVisualStyleBackColor = True
        ' 
        ' cash
        ' 
        cash.AutoSize = True
        cash.Location = New Point(325, 267)
        cash.Name = "cash"
        cash.Size = New Size(63, 24)
        cash.TabIndex = 69
        cash.Text = "نقدي"
        cash.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(323, 365)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 75
        Label4.Text = "الكمية/القيمة"
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(325, 388)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(184, 27)
        TextBox_quantity.TabIndex = 74
        ' 
        ' Button_donation
        ' 
        Button_donation.Location = New Point(448, 467)
        Button_donation.Name = "Button_donation"
        Button_donation.Size = New Size(94, 29)
        Button_donation.TabIndex = 76
        Button_donation.Text = "تبرع الان"
        Button_donation.UseVisualStyleBackColor = True
        ' 
        ' donor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(576, 522)
        Controls.Add(Button_donation)
        Controls.Add(Label4)
        Controls.Add(TextBox_quantity)
        Controls.Add(Label_donationmethod)
        Controls.Add(trance)
        Controls.Add(delivery)
        Controls.Add(cash)
        Controls.Add(Label_type_donation)
        Controls.Add(CheckBox_medicine)
        Controls.Add(CheckBox_eat)
        Controls.Add(CheckBox_clothes)
        Controls.Add(CheckBox_money)
        Controls.Add(donor_date)
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
    Friend WithEvents donor_date As TextBox
    Friend WithEvents Label_type_donation As Label
    Friend WithEvents CheckBox_medicine As CheckBox
    Friend WithEvents CheckBox_eat As CheckBox
    Friend WithEvents CheckBox_clothes As CheckBox
    Friend WithEvents CheckBox_money As CheckBox
    Friend WithEvents Label_donationmethod As Label
    Friend WithEvents trance As CheckBox
    Friend WithEvents delivery As CheckBox
    Friend WithEvents cash As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents Button_donation As Button
End Class
