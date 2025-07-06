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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donation))
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        donor_name = New TextBox()
        donor_number = New TextBox()
        Label4 = New Label()
        TextBox_quantity = New TextBox()
        Button_save = New Button()
        DataGridView1 = New DataGridView()
        DateTimePicker = New DateTimePicker()
        Button_edit_don = New Button()
        donation_type = New GroupBox()
        CheckBox_money = New CheckBox()
        CheckBox_eat = New CheckBox()
        CheckBox_clothes = New CheckBox()
        TextBox_medi = New TextBox()
        CheckBox_medicine = New CheckBox()
        TextBox_cloth = New TextBox()
        TextBox_eat = New TextBox()
        GroupBox_donationtype = New GroupBox()
        cash = New CheckBox()
        delivery = New CheckBox()
        trance = New CheckBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        donation_type.SuspendLayout()
        GroupBox_donationtype.SuspendLayout()
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
        Label6.Location = New Point(53, 513)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 68
        Label6.Text = "تاريخ التبرع"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(56, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 67
        Label5.Text = "رقم الهاتف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 66
        Label3.Text = "الاسم المتبرع"
        ' 
        ' donor_name
        ' 
        donor_name.BackColor = Color.Azure
        donor_name.Location = New Point(56, 47)
        donor_name.Name = "donor_name"
        donor_name.Size = New Size(184, 27)
        donor_name.TabIndex = 65
        ' 
        ' donor_number
        ' 
        donor_number.BackColor = Color.Azure
        donor_number.Location = New Point(54, 118)
        donor_number.Name = "donor_number"
        donor_number.Size = New Size(184, 27)
        donor_number.TabIndex = 64
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(349, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 77
        Label4.Text = "الكمية/القيمة"
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.BackColor = Color.Azure
        TextBox_quantity.Location = New Point(351, 46)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(124, 27)
        TextBox_quantity.TabIndex = 76
        ' 
        ' Button_save
        ' 
        Button_save.Location = New Point(503, 523)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(94, 29)
        Button_save.TabIndex = 78
        Button_save.Text = "حفظ"
        Button_save.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Azure
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(321, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(276, 392)
        DataGridView1.TabIndex = 79
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarMonthBackground = Color.Azure
        DateTimePicker.Location = New Point(51, 541)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(184, 27)
        DateTimePicker.TabIndex = 80
        ' 
        ' Button_edit_don
        ' 
        Button_edit_don.Location = New Point(503, 558)
        Button_edit_don.Name = "Button_edit_don"
        Button_edit_don.Size = New Size(94, 29)
        Button_edit_don.TabIndex = 81
        Button_edit_don.Text = "تعديل"
        Button_edit_don.UseVisualStyleBackColor = True
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
        donation_type.Location = New Point(17, 163)
        donation_type.Name = "donation_type"
        donation_type.Size = New Size(280, 191)
        donation_type.TabIndex = 84
        donation_type.TabStop = False
        donation_type.Text = "نوع التبرع"
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
        ' TextBox_medi
        ' 
        TextBox_medi.BackColor = Color.Azure
        TextBox_medi.Location = New Point(6, 158)
        TextBox_medi.Name = "TextBox_medi"
        TextBox_medi.Size = New Size(125, 27)
        TextBox_medi.TabIndex = 80
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
        ' TextBox_cloth
        ' 
        TextBox_cloth.BackColor = Color.Azure
        TextBox_cloth.Location = New Point(6, 109)
        TextBox_cloth.Name = "TextBox_cloth"
        TextBox_cloth.Size = New Size(125, 27)
        TextBox_cloth.TabIndex = 79
        ' 
        ' TextBox_eat
        ' 
        TextBox_eat.BackColor = Color.Azure
        TextBox_eat.Location = New Point(6, 67)
        TextBox_eat.Name = "TextBox_eat"
        TextBox_eat.Size = New Size(125, 27)
        TextBox_eat.TabIndex = 78
        ' 
        ' GroupBox_donationtype
        ' 
        GroupBox_donationtype.Controls.Add(cash)
        GroupBox_donationtype.Controls.Add(delivery)
        GroupBox_donationtype.Controls.Add(trance)
        GroupBox_donationtype.Location = New Point(17, 375)
        GroupBox_donationtype.Name = "GroupBox_donationtype"
        GroupBox_donationtype.Size = New Size(119, 125)
        GroupBox_donationtype.TabIndex = 85
        GroupBox_donationtype.TabStop = False
        GroupBox_donationtype.Text = "طريقة التبرع"
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
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_05_21_14_40_41
        PictureBox1.Location = New Point(17, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 26)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 86
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 119)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(33, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 87
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_26_19_38_40
        PictureBox3.Location = New Point(17, 542)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(33, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 88
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.photo_2025_06_26_19_36_29
        PictureBox4.Location = New Point(321, 47)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(33, 26)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 89
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.photo_2025_06_26_19_36_41
        PictureBox5.Location = New Point(464, 523)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(33, 26)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 90
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.photo_2025_06_26_19_36_40
        PictureBox6.Location = New Point(464, 561)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(33, 26)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 91
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(481, 10)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(109, 92)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 92
        PictureBox7.TabStop = False
        ' 
        ' Donation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(602, 605)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox_donationtype)
        Controls.Add(donation_type)
        Controls.Add(Button_edit_don)
        Controls.Add(DateTimePicker)
        Controls.Add(DataGridView1)
        Controls.Add(Button_save)
        Controls.Add(Label4)
        Controls.Add(TextBox_quantity)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        donation_type.ResumeLayout(False)
        donation_type.PerformLayout()
        GroupBox_donationtype.ResumeLayout(False)
        GroupBox_donationtype.PerformLayout()
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

    Friend WithEvents donor_date As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents donor_name As TextBox
    Friend WithEvents donor_number As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents Button_save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Button_edit_don As Button
    Friend WithEvents donation_type As GroupBox
    Friend WithEvents CheckBox_money As CheckBox
    Friend WithEvents CheckBox_eat As CheckBox
    Friend WithEvents CheckBox_clothes As CheckBox
    Friend WithEvents TextBox_medi As TextBox
    Friend WithEvents CheckBox_medicine As CheckBox
    Friend WithEvents TextBox_cloth As TextBox
    Friend WithEvents TextBox_eat As TextBox
    Friend WithEvents GroupBox_donationtype As GroupBox
    Friend WithEvents cash As CheckBox
    Friend WithEvents delivery As CheckBox
    Friend WithEvents trance As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
