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
        vality.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox_nameuser
        ' 
        TextBox_nameuser.Location = New Point(12, 48)
        TextBox_nameuser.Name = "TextBox_nameuser"
        TextBox_nameuser.Size = New Size(201, 27)
        TextBox_nameuser.TabIndex = 0
        ' 
        ' TextBox_passuser2
        ' 
        TextBox_passuser2.Location = New Point(12, 226)
        TextBox_passuser2.Name = "TextBox_passuser2"
        TextBox_passuser2.Size = New Size(201, 27)
        TextBox_passuser2.TabIndex = 1
        ' 
        ' TextBox_passuser1
        ' 
        TextBox_passuser1.Location = New Point(12, 135)
        TextBox_passuser1.Name = "TextBox_passuser1"
        TextBox_passuser1.Size = New Size(201, 27)
        TextBox_passuser1.TabIndex = 2
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(315, 48)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(201, 27)
        TextBox_id.TabIndex = 3
        ' 
        ' Button_edit
        ' 
        Button_edit.Location = New Point(12, 409)
        Button_edit.Name = "Button_edit"
        Button_edit.Size = New Size(132, 29)
        Button_edit.TabIndex = 4
        Button_edit.Text = "تعديل البيانات"
        Button_edit.UseVisualStyleBackColor = True
        ' 
        ' Button_add
        ' 
        Button_add.Location = New Point(12, 374)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(132, 29)
        Button_add.TabIndex = 5
        Button_add.Text = "حفظ البيانات"
        Button_add.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(165, 409)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(132, 29)
        Button_delete.TabIndex = 6
        Button_delete.Text = "حذف البيانات"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' Button_search
        ' 
        Button_search.Location = New Point(550, 48)
        Button_search.Name = "Button_search"
        Button_search.Size = New Size(132, 29)
        Button_search.TabIndex = 7
        Button_search.Text = "عرض البيانات"
        Button_search.UseVisualStyleBackColor = True
        ' 
        ' vality
        ' 
        vality.Controls.Add(Radio_employee)
        vality.Controls.Add(Radio_admin)
        vality.Location = New Point(12, 275)
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
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(315, 112)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(367, 326)
        DataGridView1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 10
        Label1.Text = "اسم المستخدم"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 11
        Label2.Text = "كلمة المرور"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 203)
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
        ' user_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(687, 441)
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
End Class
