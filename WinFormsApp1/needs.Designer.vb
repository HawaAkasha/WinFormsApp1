<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class needs
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
        TextBox_sub_name = New TextBox()
        TextBox_quantity = New TextBox()
        TextBox_item_name = New TextBox()
        TextBox_item_type = New TextBox()
        family_relate = New TextBox()
        GroupBox_priority = New GroupBox()
        RadioButton_high = New RadioButton()
        RadioButton_low = New RadioButton()
        RadioButton_mid = New RadioButton()
        DataGridView_need = New DataGridView()
        Button_save = New Button()
        Button_delete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox_priority.SuspendLayout()
        CType(DataGridView_need, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox_sub_name
        ' 
        TextBox_sub_name.Location = New Point(22, 70)
        TextBox_sub_name.Name = "TextBox_sub_name"
        TextBox_sub_name.Size = New Size(209, 27)
        TextBox_sub_name.TabIndex = 0
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(22, 393)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(209, 27)
        TextBox_quantity.TabIndex = 1
        ' 
        ' TextBox_item_name
        ' 
        TextBox_item_name.Location = New Point(22, 308)
        TextBox_item_name.Name = "TextBox_item_name"
        TextBox_item_name.Size = New Size(209, 27)
        TextBox_item_name.TabIndex = 2
        ' 
        ' TextBox_item_type
        ' 
        TextBox_item_type.Location = New Point(22, 232)
        TextBox_item_type.Name = "TextBox_item_type"
        TextBox_item_type.Size = New Size(209, 27)
        TextBox_item_type.TabIndex = 3
        ' 
        ' family_relate
        ' 
        family_relate.Location = New Point(22, 149)
        family_relate.Name = "family_relate"
        family_relate.Size = New Size(209, 27)
        family_relate.TabIndex = 4
        ' 
        ' GroupBox_priority
        ' 
        GroupBox_priority.Controls.Add(RadioButton_high)
        GroupBox_priority.Controls.Add(RadioButton_low)
        GroupBox_priority.Controls.Add(RadioButton_mid)
        GroupBox_priority.Location = New Point(308, 51)
        GroupBox_priority.Name = "GroupBox_priority"
        GroupBox_priority.Size = New Size(250, 65)
        GroupBox_priority.TabIndex = 5
        GroupBox_priority.TabStop = False
        GroupBox_priority.Text = "الاولوية"
        ' 
        ' RadioButton_high
        ' 
        RadioButton_high.AutoSize = True
        RadioButton_high.Location = New Point(182, 26)
        RadioButton_high.Name = "RadioButton_high"
        RadioButton_high.Size = New Size(62, 24)
        RadioButton_high.TabIndex = 6
        RadioButton_high.TabStop = True
        RadioButton_high.Text = "عاجل"
        RadioButton_high.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_low
        ' 
        RadioButton_low.AutoSize = True
        RadioButton_low.Location = New Point(11, 26)
        RadioButton_low.Name = "RadioButton_low"
        RadioButton_low.Size = New Size(81, 24)
        RadioButton_low.TabIndex = 7
        RadioButton_low.TabStop = True
        RadioButton_low.Text = "منخفض"
        RadioButton_low.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_mid
        ' 
        RadioButton_mid.AutoSize = True
        RadioButton_mid.Location = New Point(98, 26)
        RadioButton_mid.Name = "RadioButton_mid"
        RadioButton_mid.Size = New Size(78, 24)
        RadioButton_mid.TabIndex = 8
        RadioButton_mid.TabStop = True
        RadioButton_mid.Text = "متوسط"
        RadioButton_mid.UseVisualStyleBackColor = True
        ' 
        ' DataGridView_need
        ' 
        DataGridView_need.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_need.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_need.Location = New Point(308, 138)
        DataGridView_need.Name = "DataGridView_need"
        DataGridView_need.RowHeadersWidth = 51
        DataGridView_need.Size = New Size(262, 249)
        DataGridView_need.TabIndex = 6
        ' 
        ' Button_save
        ' 
        Button_save.Location = New Point(379, 393)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(94, 29)
        Button_save.TabIndex = 7
        Button_save.Text = "حفظ"
        Button_save.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(476, 393)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(94, 29)
        Button_delete.TabIndex = 8
        Button_delete.Text = "حذف"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 9
        Label1.Text = "اسم المشتلرك"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 20)
        Label2.TabIndex = 10
        Label2.Text = "العائلة المرتبطة بالمشترك"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 11
        Label3.Text = "نوع المادة المطلوبة"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 20)
        Label4.TabIndex = 12
        Label4.Text = "اسم المادة المطلوبة"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 367)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 13
        Label5.Text = "الكمية"
        ' 
        ' needs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(607, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_delete)
        Controls.Add(Button_save)
        Controls.Add(DataGridView_need)
        Controls.Add(GroupBox_priority)
        Controls.Add(family_relate)
        Controls.Add(TextBox_item_type)
        Controls.Add(TextBox_item_name)
        Controls.Add(TextBox_quantity)
        Controls.Add(TextBox_sub_name)
        MaximizeBox = False
        MinimizeBox = False
        Name = "needs"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل احتياج"
        GroupBox_priority.ResumeLayout(False)
        GroupBox_priority.PerformLayout()
        CType(DataGridView_need, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_sub_name As TextBox
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents TextBox_item_name As TextBox
    Friend WithEvents TextBox_item_type As TextBox
    Friend WithEvents family_relate As TextBox
    Friend WithEvents GroupBox_priority As GroupBox
    Friend WithEvents RadioButton_high As RadioButton
    Friend WithEvents RadioButton_low As RadioButton
    Friend WithEvents RadioButton_mid As RadioButton
    Friend WithEvents DataGridView_need As DataGridView
    Friend WithEvents Button_save As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
