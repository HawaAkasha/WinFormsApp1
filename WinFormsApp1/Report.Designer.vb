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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        ComboBoxReportType = New ComboBox()
        DateTimePicker_From = New DateTimePicker()
        DateTimePicker_To = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ButtonShowReport = New Button()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        ComboBox_Age = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox_MaritalStatus = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBoxReportType
        ' 
        ComboBoxReportType.BackColor = Color.Azure
        ComboBoxReportType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxReportType.FormattingEnabled = True
        ComboBoxReportType.Location = New Point(57, 56)
        ComboBoxReportType.Name = "ComboBoxReportType"
        ComboBoxReportType.Size = New Size(151, 28)
        ComboBoxReportType.TabIndex = 0
        ' 
        ' DateTimePicker_From
        ' 
        DateTimePicker_From.Location = New Point(226, 56)
        DateTimePicker_From.Name = "DateTimePicker_From"
        DateTimePicker_From.Size = New Size(83, 27)
        DateTimePicker_From.TabIndex = 1
        ' 
        ' DateTimePicker_To
        ' 
        DateTimePicker_To.Location = New Point(338, 55)
        DateTimePicker_To.Name = "DateTimePicker_To"
        DateTimePicker_To.Size = New Size(83, 27)
        DateTimePicker_To.TabIndex = 2
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
        ' ButtonShowReport
        ' 
        ButtonShowReport.Location = New Point(475, 53)
        ButtonShowReport.Name = "ButtonShowReport"
        ButtonShowReport.Size = New Size(119, 29)
        ButtonShowReport.TabIndex = 6
        ButtonShowReport.Text = "عرض التقرير"
        ButtonShowReport.UseVisualStyleBackColor = True
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
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_2025_06_10_18_07_411
        PictureBox3.Location = New Point(435, 53)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(590, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(95, 84)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' ComboBox_Age
        ' 
        ComboBox_Age.BackColor = Color.Azure
        ComboBox_Age.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Age.FormattingEnabled = True
        ComboBox_Age.Location = New Point(57, 115)
        ComboBox_Age.Name = "ComboBox_Age"
        ComboBox_Age.Size = New Size(151, 28)
        ComboBox_Age.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 13
        Label4.Text = "العمر"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(247, 92)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 15
        Label5.Text = "الحالة الاجتماعيه"
        ' 
        ' ComboBox_MaritalStatus
        ' 
        ComboBox_MaritalStatus.BackColor = Color.Azure
        ComboBox_MaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_MaritalStatus.FormattingEnabled = True
        ComboBox_MaritalStatus.Location = New Point(247, 115)
        ComboBox_MaritalStatus.Name = "ComboBox_MaritalStatus"
        ComboBox_MaritalStatus.Size = New Size(151, 28)
        ComboBox_MaritalStatus.TabIndex = 14
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(685, 450)
        Controls.Add(Label5)
        Controls.Add(ComboBox_MaritalStatus)
        Controls.Add(Label4)
        Controls.Add(ComboBox_Age)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(ButtonShowReport)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker_To)
        Controls.Add(DateTimePicker_From)
        Controls.Add(ComboBoxReportType)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Report"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "شاشة انشاء تقارير"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxReportType As ComboBox
    Friend WithEvents DateTimePicker_From As DateTimePicker
    Friend WithEvents DateTimePicker_To As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonShowReport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ComboBox_Age As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_MaritalStatus As ComboBox
End Class
