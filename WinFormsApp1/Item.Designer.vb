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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        CType(DataGridView_item, ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridView_item.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView_item.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView_item.Location = New Point(265, 28)
        DataGridView_item.Name = "DataGridView_item"
        DataGridView_item.ReadOnly = True
        DataGridView_item.RowHeadersWidth = 51
        DataGridView_item.Size = New Size(300, 343)
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
        Label3.Location = New Point(51, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 84
        Label3.Text = "رقم المادة"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 83
        Label1.Text = "اسم المادة"
        ' 
        ' item_id
        ' 
        item_id.Location = New Point(51, 120)
        item_id.Name = "item_id"
        item_id.Size = New Size(188, 27)
        item_id.TabIndex = 82
        ' 
        ' item_name
        ' 
        item_name.Location = New Point(51, 51)
        item_name.Name = "item_name"
        item_name.Size = New Size(188, 27)
        item_name.TabIndex = 80
        ' 
        ' ComboBox_item_class
        ' 
        ComboBox_item_class.FormattingEnabled = True
        ComboBox_item_class.Items.AddRange(New Object() {"ملابس", "مواد غذائية", "مستلزمات صحية", "تبرع مالي"})
        ComboBox_item_class.Location = New Point(49, 202)
        ComboBox_item_class.Name = "ComboBox_item_class"
        ComboBox_item_class.Size = New Size(188, 28)
        ComboBox_item_class.TabIndex = 95
        ' 
        ' Item
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(589, 474)
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
End Class
