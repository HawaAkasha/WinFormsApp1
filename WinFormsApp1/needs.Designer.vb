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
        DataGridView_need = New DataGridView()
        Button_save = New Button()
        Button_delete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(DataGridView_need, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox_sub_name
        ' 
        TextBox_sub_name.Location = New Point(19, 52)
        TextBox_sub_name.Margin = New Padding(3, 2, 3, 2)
        TextBox_sub_name.Name = "TextBox_sub_name"
        TextBox_sub_name.Size = New Size(183, 23)
        TextBox_sub_name.TabIndex = 0
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(19, 295)
        TextBox_quantity.Margin = New Padding(3, 2, 3, 2)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(183, 23)
        TextBox_quantity.TabIndex = 1
        ' 
        ' TextBox_item_name
        ' 
        TextBox_item_name.Location = New Point(19, 231)
        TextBox_item_name.Margin = New Padding(3, 2, 3, 2)
        TextBox_item_name.Name = "TextBox_item_name"
        TextBox_item_name.Size = New Size(183, 23)
        TextBox_item_name.TabIndex = 2
        ' 
        ' TextBox_item_type
        ' 
        TextBox_item_type.Location = New Point(19, 174)
        TextBox_item_type.Margin = New Padding(3, 2, 3, 2)
        TextBox_item_type.Name = "TextBox_item_type"
        TextBox_item_type.Size = New Size(183, 23)
        TextBox_item_type.TabIndex = 3
        ' 
        ' family_relate
        ' 
        family_relate.Location = New Point(19, 112)
        family_relate.Margin = New Padding(3, 2, 3, 2)
        family_relate.Name = "family_relate"
        family_relate.Size = New Size(183, 23)
        family_relate.TabIndex = 4
        ' 
        ' DataGridView_need
        ' 
        DataGridView_need.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_need.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_need.Location = New Point(270, 52)
        DataGridView_need.Margin = New Padding(3, 2, 3, 2)
        DataGridView_need.Name = "DataGridView_need"
        DataGridView_need.RowHeadersWidth = 51
        DataGridView_need.Size = New Size(229, 239)
        DataGridView_need.TabIndex = 6
        ' 
        ' Button_save
        ' 
        Button_save.Location = New Point(332, 295)
        Button_save.Margin = New Padding(3, 2, 3, 2)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(82, 22)
        Button_save.TabIndex = 7
        Button_save.Text = "حفظ"
        Button_save.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(416, 295)
        Button_delete.Margin = New Padding(3, 2, 3, 2)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(82, 22)
        Button_delete.TabIndex = 8
        Button_delete.Text = "حذف"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 9
        Label1.Text = "اسم المشتلرك"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 15)
        Label2.TabIndex = 10
        Label2.Text = "العائلة المرتبطة بالمشترك"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 11
        Label3.Text = "نوع المادة المطلوبة"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 15)
        Label4.TabIndex = 12
        Label4.Text = "اسم المادة المطلوبة"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 13
        Label5.Text = "الكمية"
        ' 
        ' needs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(531, 338)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_delete)
        Controls.Add(Button_save)
        Controls.Add(DataGridView_need)
        Controls.Add(family_relate)
        Controls.Add(TextBox_item_type)
        Controls.Add(TextBox_item_name)
        Controls.Add(TextBox_quantity)
        Controls.Add(TextBox_sub_name)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "needs"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة تسجيل احتياج"
        CType(DataGridView_need, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_sub_name As TextBox
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents TextBox_item_name As TextBox
    Friend WithEvents TextBox_item_type As TextBox
    Friend WithEvents family_relate As TextBox
    Friend WithEvents DataGridView_need As DataGridView
    Friend WithEvents Button_save As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
