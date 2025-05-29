<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button_login = New Button()
        Button_logout = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        TextBox_loginname = New TextBox()
        TextBox_loginpass = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button_login
        ' 
        Button_login.Location = New Point(125, 345)
        Button_login.Name = "Button_login"
        Button_login.Size = New Size(204, 29)
        Button_login.TabIndex = 0
        Button_login.Text = "الدخول"
        Button_login.UseVisualStyleBackColor = True
        ' 
        ' Button_logout
        ' 
        Button_logout.Location = New Point(125, 380)
        Button_logout.Name = "Button_logout"
        Button_logout.Size = New Size(204, 29)
        Button_logout.TabIndex = 1
        Button_logout.Text = "الخروج"
        Button_logout.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_05_21_15_42_10
        PictureBox1.Location = New Point(80, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(292, 215)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_05_21_14_40_41
        PictureBox2.Location = New Point(80, 226)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_05_21_14_40_52
        PictureBox3.Location = New Point(80, 275)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' TextBox_loginname
        ' 
        TextBox_loginname.Location = New Point(125, 233)
        TextBox_loginname.Name = "TextBox_loginname"
        TextBox_loginname.Size = New Size(204, 27)
        TextBox_loginname.TabIndex = 5
        ' 
        ' TextBox_loginpass
        ' 
        TextBox_loginpass.Location = New Point(125, 282)
        TextBox_loginpass.Name = "TextBox_loginpass"
        TextBox_loginpass.Size = New Size(204, 27)
        TextBox_loginpass.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(453, 450)
        Controls.Add(TextBox_loginpass)
        Controls.Add(TextBox_loginname)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button_logout)
        Controls.Add(Button_login)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        Text = "شاشة تسجيل الدخول"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_login As Button
    Friend WithEvents Button_logout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox_loginname As TextBox
    Friend WithEvents TextBox_loginpass As TextBox

End Class
