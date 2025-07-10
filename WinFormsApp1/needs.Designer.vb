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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(needs))
        TextBox_sub_name = New TextBox()
        TextBox_quantity = New TextBox()
        TextBox_item_name = New TextBox()
        TextBox_item_type = New TextBox()
        family_relate = New TextBox()
        DataGridView_need = New DataGridView()
        Button_save = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        Butt_delete = New Button()
        But_edit = New Button()
        PictureBox8 = New PictureBox()
        PictureBox10 = New PictureBox()
        CType(DataGridView_need, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox_sub_name
        ' 
        TextBox_sub_name.BackColor = Color.Azure
        TextBox_sub_name.Location = New Point(53, 71)
        TextBox_sub_name.Name = "TextBox_sub_name"
        TextBox_sub_name.Size = New Size(209, 27)
        TextBox_sub_name.TabIndex = 0
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.BackColor = Color.Azure
        TextBox_quantity.Location = New Point(53, 385)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(209, 27)
        TextBox_quantity.TabIndex = 1
        ' 
        ' TextBox_item_name
        ' 
        TextBox_item_name.BackColor = Color.Azure
        TextBox_item_name.Location = New Point(53, 310)
        TextBox_item_name.Name = "TextBox_item_name"
        TextBox_item_name.Size = New Size(209, 27)
        TextBox_item_name.TabIndex = 2
        ' 
        ' TextBox_item_type
        ' 
        TextBox_item_type.BackColor = Color.Azure
        TextBox_item_type.Location = New Point(53, 234)
        TextBox_item_type.Name = "TextBox_item_type"
        TextBox_item_type.Size = New Size(209, 27)
        TextBox_item_type.TabIndex = 3
        ' 
        ' family_relate
        ' 
        family_relate.BackColor = Color.Azure
        family_relate.Location = New Point(53, 151)
        family_relate.Name = "family_relate"
        family_relate.Size = New Size(209, 27)
        family_relate.TabIndex = 4
        ' 
        ' DataGridView_need
        ' 
        DataGridView_need.BackgroundColor = Color.Azure
        DataGridView_need.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_need.Location = New Point(299, 98)
        DataGridView_need.Name = "DataGridView_need"
        DataGridView_need.ReadOnly = True
        DataGridView_need.RowHeadersWidth = 51
        DataGridView_need.Size = New Size(262, 314)
        DataGridView_need.TabIndex = 6
        ' 
        ' Button_save
        ' 
        Button_save.Location = New Point(467, 429)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(94, 29)
        Button_save.TabIndex = 7
        Button_save.Text = "حفظ"
        Button_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 9
        Label1.Text = "اسم المشترك"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 20)
        Label2.TabIndex = 10
        Label2.Text = "عدد افراد العائلة المرتبطة"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 11
        Label3.Text = "نوع المادة المطلوبة"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 20)
        Label4.TabIndex = 12
        Label4.Text = "اسم المادة المطلوبة"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 359)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 13
        Label5.Text = "الكمية"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(433, -7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_06_26_19_43_38
        PictureBox2.Location = New Point(12, 72)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_10_19_19_19
        PictureBox3.Location = New Point(12, 310)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(39, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.photo_2025_06_10_19_18_26
        PictureBox4.Location = New Point(12, 234)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(39, 26)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.photo_2025_06_10_18_07_38
        PictureBox5.Location = New Point(12, 151)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(39, 26)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.photo_2025_06_26_19_36_411
        PictureBox6.Location = New Point(433, 430)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(39, 26)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.photo_2025_06_26_19_36_29
        PictureBox7.Location = New Point(12, 385)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(39, 26)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 20
        PictureBox7.TabStop = False
        ' 
        ' Butt_delete
        ' 
        Butt_delete.Location = New Point(467, 462)
        Butt_delete.Name = "Butt_delete"
        Butt_delete.Size = New Size(94, 29)
        Butt_delete.TabIndex = 21
        Butt_delete.Text = "حذف"
        Butt_delete.UseVisualStyleBackColor = True
        ' 
        ' But_edit
        ' 
        But_edit.Location = New Point(467, 497)
        But_edit.Name = "But_edit"
        But_edit.Size = New Size(94, 29)
        But_edit.TabIndex = 22
        But_edit.Text = "تعديل"
        But_edit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.photo_2025_06_26_20_05_041
        PictureBox8.Location = New Point(433, 465)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(39, 26)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 23
        PictureBox8.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = My.Resources.Resources.photo_2025_06_26_19_36_40
        PictureBox10.Location = New Point(439, 497)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(33, 26)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 92
        PictureBox10.TabStop = False
        ' 
        ' needs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(561, 531)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox8)
        Controls.Add(But_edit)
        Controls.Add(Butt_delete)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_save)
        Controls.Add(DataGridView_need)
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
        CType(DataGridView_need, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Butt_delete As Button
    Friend WithEvents But_edit As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
End Class
