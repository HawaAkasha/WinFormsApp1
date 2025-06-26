<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_form
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
        TextBox_nameuser = New TextBox()
        TextBox_passuser2 = New TextBox()
        TextBox_passuser1 = New TextBox()
        TextBox_id = New TextBox()
        Button_edit = New Button()
        Button_add = New Button()
        Button_delete = New Button()
        Button_search = New Button()
        vality = New GroupBox()
        Radio_employee = New RadioButton()
        Radio_admin = New RadioButton()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        vality.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' TextBox_nameuser
        ' 
        TextBox_nameuser.BackColor = Color.Azure
        TextBox_nameuser.Location = New Point(45, 48)
        TextBox_nameuser.Name = "TextBox_nameuser"
        TextBox_nameuser.Size = New Size(201, 27)
        TextBox_nameuser.TabIndex = 0
        ' 
        ' TextBox_passuser2
        ' 
        TextBox_passuser2.BackColor = Color.Azure
        TextBox_passuser2.Location = New Point(45, 226)
        TextBox_passuser2.Name = "TextBox_passuser2"
        TextBox_passuser2.Size = New Size(201, 27)
        TextBox_passuser2.TabIndex = 1
        ' 
        ' TextBox_passuser1
        ' 
        TextBox_passuser1.BackColor = Color.Azure
        TextBox_passuser1.Location = New Point(45, 135)
        TextBox_passuser1.Name = "TextBox_passuser1"
        TextBox_passuser1.Size = New Size(201, 27)
        TextBox_passuser1.TabIndex = 2
        ' 
        ' TextBox_id
        ' 
        TextBox_id.BackColor = Color.Azure
        TextBox_id.Location = New Point(313, 50)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(201, 27)
        TextBox_id.TabIndex = 3
        ' 
        ' Button_edit
        ' 
        Button_edit.Location = New Point(53, 423)
        Button_edit.Name = "Button_edit"
        Button_edit.Size = New Size(132, 29)
        Button_edit.TabIndex = 4
        Button_edit.Text = "تعديل البيانات"
        Button_edit.UseVisualStyleBackColor = True
        ' 
        ' Button_add
        ' 
        Button_add.Location = New Point(53, 388)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(132, 29)
        Button_add.TabIndex = 5
        Button_add.Text = "حفظ البيانات"
        Button_add.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(53, 458)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(132, 29)
        Button_delete.TabIndex = 6
        Button_delete.Text = "حذف البيانات"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' Button_search
        ' 
        Button_search.Location = New Point(552, 48)
        Button_search.Name = "Button_search"
        Button_search.Size = New Size(130, 29)
        Button_search.TabIndex = 7
        Button_search.Text = "عرض البيانات"
        Button_search.UseVisualStyleBackColor = True
        ' 
        ' vality
        ' 
        vality.Controls.Add(Radio_employee)
        vality.Controls.Add(Radio_admin)
        vality.Location = New Point(45, 275)
        vality.Name = "vality"
        vality.Size = New Size(201, 72)
        vality.TabIndex = 8
        vality.TabStop = False
        vality.Text = "صلاحية المستخدم"
        ' 
        ' Radio_employee
        ' 
        Radio_employee.AutoSize = True
        Radio_employee.Location = New Point(19, 26)
        Radio_employee.Name = "Radio_employee"
        Radio_employee.Size = New Size(75, 24)
        Radio_employee.TabIndex = 10
        Radio_employee.TabStop = True
        Radio_employee.Text = "موظف"
        Radio_employee.UseVisualStyleBackColor = True
        ' 
        ' Radio_admin
        ' 
        Radio_admin.AutoSize = True
        Radio_admin.Location = New Point(100, 26)
        Radio_admin.Name = "Radio_admin"
        Radio_admin.Size = New Size(93, 24)
        Radio_admin.TabIndex = 9
        Radio_admin.TabStop = True
        Radio_admin.Text = "مدير نظام"
        Radio_admin.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Azure
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(279, 112)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(403, 375)
        DataGridView1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(45, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 10
        Label1.Text = "اسم المستخدم"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 11
        Label2.Text = "كلمة المرور"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 12
        Label3.Text = "تاكيد كلمة المرور"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(313, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 13
        Label4.Text = "كود المستخدم"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_05_21_14_40_41
        PictureBox1.Location = New Point(12, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_05_21_14_40_52
        PictureBox2.Location = New Point(12, 224)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(33, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_05_21_14_40_52
        PictureBox3.Location = New Point(12, 135)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(33, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(12, 458)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(33, 29)
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Location = New Point(12, 423)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(33, 29)
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Location = New Point(12, 388)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(33, 29)
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Location = New Point(279, 48)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(33, 29)
        PictureBox7.TabIndex = 20
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Location = New Point(522, 48)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(33, 29)
        PictureBox8.TabIndex = 21
        PictureBox8.TabStop = False
        ' 
        ' user_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(700, 499)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(vality)
        Controls.Add(Button_search)
        Controls.Add(Button_delete)
        Controls.Add(Button_add)
        Controls.Add(Button_edit)
        Controls.Add(TextBox_id)
        Controls.Add(TextBox_passuser1)
        Controls.Add(TextBox_passuser2)
        Controls.Add(TextBox_nameuser)
        MaximizeBox = False
        MinimizeBox = False
        Name = "user_form"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "المستخدمين"
        vality.ResumeLayout(False)
        vality.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents TextBox_nameuser As TextBox
    Friend WithEvents TextBox_passuser2 As TextBox
    Friend WithEvents TextBox_passuser1 As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Button_edit As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_search As Button
    Friend WithEvents vality As GroupBox
    Friend WithEvents Radio_employee As RadioButton
    Friend WithEvents Radio_admin As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
