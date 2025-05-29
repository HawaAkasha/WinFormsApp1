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
        SuspendLayout()
        ' 
        ' ComboBox_report_type
        ' 
        ComboBox_report_type.FormattingEnabled = True
        ComboBox_report_type.Location = New Point(12, 55)
        ComboBox_report_type.Name = "ComboBox_report_type"
        ComboBox_report_type.Size = New Size(151, 28)
        ComboBox_report_type.TabIndex = 0
        ' 
        ' DateTimePicker_OF
        ' 
        DateTimePicker_OF.Location = New Point(194, 56)
        DateTimePicker_OF.Name = "DateTimePicker_OF"
        DateTimePicker_OF.Size = New Size(83, 27)
        DateTimePicker_OF.TabIndex = 1
        ' 
        ' DateTimePicker_TO
        ' 
        DateTimePicker_TO.Location = New Point(306, 55)
        DateTimePicker_TO.Name = "DateTimePicker_TO"
        DateTimePicker_TO.Size = New Size(83, 27)
        DateTimePicker_TO.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 3
        Label1.Text = "نوع التقرير"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 20)
        Label2.TabIndex = 4
        Label2.Text = "من"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(306, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 20)
        Label3.TabIndex = 5
        Label3.Text = "الي"
        ' 
        ' Button_Show_report
        ' 
        Button_Show_report.Location = New Point(412, 53)
        Button_Show_report.Name = "Button_Show_report"
        Button_Show_report.Size = New Size(129, 29)
        Button_Show_report.TabIndex = 6
        Button_Show_report.Text = "عرض التقرير"
        Button_Show_report.UseVisualStyleBackColor = True
        ' 
        ' Button_Print_report
        ' 
        Button_Print_report.Location = New Point(557, 53)
        Button_Print_report.Name = "Button_Print_report"
        Button_Print_report.Size = New Size(119, 29)
        Button_Print_report.TabIndex = 7
        Button_Print_report.Text = "طباعة التقرير"
        Button_Print_report.UseVisualStyleBackColor = True
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(685, 450)
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
End Class
