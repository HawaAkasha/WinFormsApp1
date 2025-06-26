<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        ComboBox_report_type = New ComboBox()
        DateTimePicker_OF = New DateTimePicker()
        DateTimePicker_TO = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button_Show_report = New Button()
        Button_Print_report = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox_report_type
        ' 
        ComboBox_report_type.BackColor = Color.Azure
        ComboBox_report_type.FormattingEnabled = True
        ComboBox_report_type.Location = New Point(57, 56)
        ComboBox_report_type.Name = "ComboBox_report_type"
        ComboBox_report_type.Size = New Size(151, 28)
        ComboBox_report_type.TabIndex = 0
        ' 
        ' DateTimePicker_OF
        ' 
        DateTimePicker_OF.Location = New Point(226, 56)
        DateTimePicker_OF.Name = "DateTimePicker_OF"
        DateTimePicker_OF.Size = New Size(83, 27)
        DateTimePicker_OF.TabIndex = 1
        ' 
        ' DateTimePicker_TO
        ' 
        DateTimePicker_TO.Location = New Point(338, 55)
        DateTimePicker_TO.Name = "DateTimePicker_TO"
        DateTimePicker_TO.Size = New Size(83, 27)
        DateTimePicker_TO.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 3
        Label1.Text = "نوع التقرير"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(226, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 20)
        Label2.TabIndex = 4
        Label2.Text = "من"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(338, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 20)
        Label3.TabIndex = 5
        Label3.Text = "الي"
        ' 
        ' Button_Show_report
        ' 
        Button_Show_report.Location = New Point(475, 18)
        Button_Show_report.Name = "Button_Show_report"
        Button_Show_report.Size = New Size(119, 29)
        Button_Show_report.TabIndex = 6
        Button_Show_report.Text = "عرض التقرير"
        Button_Show_report.UseVisualStyleBackColor = True
        ' 
        ' Button_Print_report
        ' 
        Button_Print_report.Location = New Point(475, 53)
        Button_Print_report.Name = "Button_Print_report"
        Button_Print_report.Size = New Size(119, 29)
        Button_Print_report.TabIndex = 7
        Button_Print_report.Text = "طباعة التقرير"
        Button_Print_report.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_06_26_19_36_381
        PictureBox1.Location = New Point(12, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_2025_06_27_00_07_13
        PictureBox2.Location = New Point(435, 53)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_10_18_07_411
        PictureBox3.Location = New Point(435, 18)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.photo_2025_06_26_19_53_58
        PictureBox4.Location = New Point(600, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(85, 84)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(685, 450)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button_Print_report)
        Controls.Add(Button_Show_report)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker_TO)
        Controls.Add(DateTimePicker_OF)
        Controls.Add(ComboBox_report_type)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Report"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        Text = "شاشة انشاء تقارير"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox_report_type As ComboBox
    Friend WithEvents DateTimePicker_OF As DateTimePicker
    Friend WithEvents DateTimePicker_TO As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Show_report As Button
    Friend WithEvents Button_Print_report As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
