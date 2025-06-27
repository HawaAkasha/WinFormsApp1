<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button_close = New Button()
        Button_delete = New Button()
        Button_save = New Button()
        DataGridView_item = New DataGridView()
        Label2 = New Label()
        item_quantity = New TextBox()
        DateTimePicker_TO = New DateTimePicker()
        DateTimePicker_OF = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        item_id = New TextBox()
        item_name = New TextBox()
        ComboBox_item_class = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(DataGridView_item, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Button_close
        ' 
        Button_close.Location = New Point(474, 433)
        Button_close.Name = "Button_close"
        Button_close.Size = New Size(91, 29)
        Button_close.TabIndex = 94
        Button_close.Text = "إالغاء"
        Button_close.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(49, 433)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(91, 29)
        Button_delete.TabIndex = 93
        Button_delete.Text = "حذف"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' Button_save
        ' 
        Button_save.Location = New Point(47, 397)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(91, 29)
        Button_save.TabIndex = 92
        Button_save.Text = "حفظ"
        Button_save.UseVisualStyleBackColor = True
        ' 
        ' DataGridView_item
        ' 
        DataGridView_item.BackgroundColor = Color.Azure
        DataGridView_item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView_item.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView_item.Location = New Point(265, 97)
        DataGridView_item.Name = "DataGridView_item"
        DataGridView_item.ReadOnly = True
        DataGridView_item.RowHeadersWidth = 51
        DataGridView_item.Size = New Size(300, 330)
        DataGridView_item.TabIndex = 91
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 90
        Label2.Text = "الكمية"
        ' 
        ' item_quantity
        ' 
        item_quantity.BackColor = Color.Azure
        item_quantity.Location = New Point(47, 256)
        item_quantity.Name = "item_quantity"
        item_quantity.Size = New Size(190, 27)
        item_quantity.TabIndex = 89
        ' 
        ' DateTimePicker_TO
        ' 
        DateTimePicker_TO.Location = New Point(148, 344)
        DateTimePicker_TO.Name = "DateTimePicker_TO"
        DateTimePicker_TO.Size = New Size(91, 27)
        DateTimePicker_TO.TabIndex = 88
        ' 
        ' DateTimePicker_OF
        ' 
        DateTimePicker_OF.Location = New Point(47, 344)
        DateTimePicker_OF.Name = "DateTimePicker_OF"
        DateTimePicker_OF.Size = New Size(91, 27)
        DateTimePicker_OF.TabIndex = 87
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(49, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 86
        Label6.Text = "تاريخ التبرع"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(51, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 20)
        Label5.TabIndex = 85
        Label5.Text = "تصنيف المادة"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 84
        Label3.Text = "رقم المادة"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 83
        Label1.Text = "اسم المادة"
        ' 
        ' item_id
        ' 
        item_id.BackColor = Color.Azure
        item_id.Location = New Point(51, 64)
        item_id.Name = "item_id"
        item_id.Size = New Size(188, 27)
        item_id.TabIndex = 82
        ' 
        ' item_name
        ' 
        item_name.BackColor = Color.Azure
        item_name.Location = New Point(51, 129)
        item_name.Name = "item_name"
        item_name.Size = New Size(188, 27)
        item_name.TabIndex = 80
        ' 
        ' ComboBox_item_class
        ' 
        ComboBox_item_class.BackColor = Color.Azure
        ComboBox_item_class.FormattingEnabled = True
        ComboBox_item_class.Items.AddRange(New Object() {"ملابس", "مواد غذائية", "مستلزمات صحية", "تبرع مالي"})
        ComboBox_item_class.Location = New Point(49, 202)
        ComboBox_item_class.Name = "ComboBox_item_class"
        ComboBox_item_class.Size = New Size(188, 28)
        ComboBox_item_class.TabIndex = 95
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_06_26_19_53_581
        PictureBox1.Location = New Point(440, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 96
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_06_10_19_19_19
        PictureBox2.Location = New Point(12, 129)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 97
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_10_19_18_26
        PictureBox3.Location = New Point(12, 202)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 28)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 98
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.photo_2025_06_27_00_07_10
        PictureBox4.Location = New Point(12, 64)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 99
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.photo_2025_06_26_19_36_29
        PictureBox5.Location = New Point(12, 256)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(38, 27)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 100
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.photo_2025_06_26_20_05_041
        PictureBox6.Location = New Point(12, 435)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(38, 27)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 101
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.photo_2025_06_26_19_36_411
        PictureBox7.Location = New Point(12, 400)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(38, 27)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 102
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.photo_2025_06_26_20_45_55
        PictureBox8.Location = New Point(440, 435)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(38, 27)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 103
        PictureBox8.TabStop = False
        ' 
        ' Item
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(568, 474)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox_item_class)
        Controls.Add(Button_close)
        Controls.Add(Button_delete)
        Controls.Add(Button_save)
        Controls.Add(DataGridView_item)
        Controls.Add(Label2)
        Controls.Add(item_quantity)
        Controls.Add(DateTimePicker_TO)
        Controls.Add(DateTimePicker_OF)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(item_id)
        Controls.Add(item_name)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Item"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل مادة"
        CType(DataGridView_item, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents Button_close As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_save As Button
    Friend WithEvents DataGridView_item As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents item_quantity As TextBox
    Friend WithEvents DateTimePicker_TO As DateTimePicker
    Friend WithEvents DateTimePicker_OF As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents item_id As TextBox
    Friend WithEvents item_name As TextBox
    Friend WithEvents ComboBox_item_class As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
