<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HourLabel = New System.Windows.Forms.Label()
        Me.MinLabel = New System.Windows.Forms.Label()
        Me.SecLabel = New System.Windows.Forms.Label()
        Me.ClkHr = New System.Windows.Forms.TextBox()
        Me.ClkMin = New System.Windows.Forms.TextBox()
        Me.ClkSec = New System.Windows.Forms.TextBox()
        Me.SetTime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StWtchMin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StWtchSec = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StWtchFraction = New System.Windows.Forms.Label()
        Me.StopwatchLabel = New System.Windows.Forms.Label()
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.SWStartButton = New System.Windows.Forms.Button()
        Me.SWStopButton = New System.Windows.Forms.Button()
        Me.SWResetButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AlarmHr = New System.Windows.Forms.ComboBox()
        Me.SetAlarm = New System.Windows.Forms.Button()
        Me.AlarmHrLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlarmMinLabel = New System.Windows.Forms.Label()
        Me.AlarmMin = New System.Windows.Forms.ComboBox()
        Me.AlarmSec = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AlarmSecLabel = New System.Windows.Forms.Label()
        Me.AlarmLabel = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.SuspendLayout()
        '
        'HourLabel
        '
        Me.HourLabel.AutoSize = True
        Me.HourLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HourLabel.Location = New System.Drawing.Point(22, 159)
        Me.HourLabel.MaximumSize = New System.Drawing.Size(114, 133)
        Me.HourLabel.MinimumSize = New System.Drawing.Size(114, 133)
        Me.HourLabel.Name = "HourLabel"
        Me.HourLabel.Size = New System.Drawing.Size(114, 133)
        Me.HourLabel.TabIndex = 3
        Me.HourLabel.Text = "00"
        '
        'MinLabel
        '
        Me.MinLabel.AutoSize = True
        Me.MinLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinLabel.Location = New System.Drawing.Point(143, 159)
        Me.MinLabel.MaximumSize = New System.Drawing.Size(114, 133)
        Me.MinLabel.MinimumSize = New System.Drawing.Size(114, 133)
        Me.MinLabel.Name = "MinLabel"
        Me.MinLabel.Size = New System.Drawing.Size(114, 133)
        Me.MinLabel.TabIndex = 4
        Me.MinLabel.Text = "00"
        '
        'SecLabel
        '
        Me.SecLabel.AutoSize = True
        Me.SecLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SecLabel.Location = New System.Drawing.Point(258, 159)
        Me.SecLabel.MaximumSize = New System.Drawing.Size(114, 133)
        Me.SecLabel.MinimumSize = New System.Drawing.Size(114, 133)
        Me.SecLabel.Name = "SecLabel"
        Me.SecLabel.Size = New System.Drawing.Size(114, 133)
        Me.SecLabel.TabIndex = 5
        Me.SecLabel.Text = "00"
        '
        'ClkHr
        '
        Me.ClkHr.Location = New System.Drawing.Point(38, 339)
        Me.ClkHr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClkHr.Name = "ClkHr"
        Me.ClkHr.Size = New System.Drawing.Size(58, 27)
        Me.ClkHr.TabIndex = 6
        '
        'ClkMin
        '
        Me.ClkMin.Location = New System.Drawing.Point(131, 337)
        Me.ClkMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClkMin.Name = "ClkMin"
        Me.ClkMin.Size = New System.Drawing.Size(58, 27)
        Me.ClkMin.TabIndex = 7
        '
        'ClkSec
        '
        Me.ClkSec.Location = New System.Drawing.Point(222, 337)
        Me.ClkSec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClkSec.Name = "ClkSec"
        Me.ClkSec.Size = New System.Drawing.Size(58, 27)
        Me.ClkSec.TabIndex = 8
        '
        'SetTime
        '
        Me.SetTime.Location = New System.Drawing.Point(287, 337)
        Me.SetTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SetTime.Name = "SetTime"
        Me.SetTime.Size = New System.Drawing.Size(86, 31)
        Me.SetTime.TabIndex = 9
        Me.SetTime.Text = "Set Time"
        Me.SetTime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(119, 180)
        Me.Label1.MaximumSize = New System.Drawing.Size(29, 67)
        Me.Label1.MinimumSize = New System.Drawing.Size(29, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 67)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(240, 180)
        Me.Label2.MaximumSize = New System.Drawing.Size(23, 80)
        Me.Label2.MinimumSize = New System.Drawing.Size(29, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 80)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = ":"
        '
        'StWtchMin
        '
        Me.StWtchMin.AutoSize = True
        Me.StWtchMin.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StWtchMin.Location = New System.Drawing.Point(787, 159)
        Me.StWtchMin.MaximumSize = New System.Drawing.Size(114, 133)
        Me.StWtchMin.MinimumSize = New System.Drawing.Size(114, 133)
        Me.StWtchMin.Name = "StWtchMin"
        Me.StWtchMin.Size = New System.Drawing.Size(114, 133)
        Me.StWtchMin.TabIndex = 12
        Me.StWtchMin.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(890, 180)
        Me.Label4.MaximumSize = New System.Drawing.Size(29, 67)
        Me.Label4.MinimumSize = New System.Drawing.Size(29, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 67)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ":"
        '
        'StWtchSec
        '
        Me.StWtchSec.AutoSize = True
        Me.StWtchSec.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StWtchSec.Location = New System.Drawing.Point(909, 159)
        Me.StWtchSec.MaximumSize = New System.Drawing.Size(114, 133)
        Me.StWtchSec.MinimumSize = New System.Drawing.Size(114, 133)
        Me.StWtchSec.Name = "StWtchSec"
        Me.StWtchSec.Size = New System.Drawing.Size(114, 133)
        Me.StWtchSec.TabIndex = 14
        Me.StWtchSec.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1007, 180)
        Me.Label6.MaximumSize = New System.Drawing.Size(23, 80)
        Me.Label6.MinimumSize = New System.Drawing.Size(29, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 80)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = ":"
        '
        'StWtchFraction
        '
        Me.StWtchFraction.AutoSize = True
        Me.StWtchFraction.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StWtchFraction.Location = New System.Drawing.Point(1030, 159)
        Me.StWtchFraction.MaximumSize = New System.Drawing.Size(114, 133)
        Me.StWtchFraction.MinimumSize = New System.Drawing.Size(114, 133)
        Me.StWtchFraction.Name = "StWtchFraction"
        Me.StWtchFraction.Size = New System.Drawing.Size(114, 133)
        Me.StWtchFraction.TabIndex = 16
        Me.StWtchFraction.Text = "00"
        '
        'StopwatchLabel
        '
        Me.StopwatchLabel.AutoSize = True
        Me.StopwatchLabel.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StopwatchLabel.Location = New System.Drawing.Point(863, 75)
        Me.StopwatchLabel.Name = "StopwatchLabel"
        Me.StopwatchLabel.Size = New System.Drawing.Size(245, 62)
        Me.StopwatchLabel.TabIndex = 17
        Me.StopwatchLabel.Text = "Stopwatch"
        '
        'ClockLabel
        '
        Me.ClockLabel.AutoSize = True
        Me.ClockLabel.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClockLabel.Location = New System.Drawing.Point(119, 75)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(140, 62)
        Me.ClockLabel.TabIndex = 18
        Me.ClockLabel.Text = "Clock"
        '
        'SWStartButton
        '
        Me.SWStartButton.Location = New System.Drawing.Point(816, 335)
        Me.SWStartButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SWStartButton.Name = "SWStartButton"
        Me.SWStartButton.Size = New System.Drawing.Size(86, 31)
        Me.SWStartButton.TabIndex = 19
        Me.SWStartButton.Text = "Start"
        Me.SWStartButton.UseVisualStyleBackColor = True
        '
        'SWStopButton
        '
        Me.SWStopButton.Location = New System.Drawing.Point(925, 335)
        Me.SWStopButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SWStopButton.Name = "SWStopButton"
        Me.SWStopButton.Size = New System.Drawing.Size(86, 31)
        Me.SWStopButton.TabIndex = 20
        Me.SWStopButton.Text = "Stop"
        Me.SWStopButton.UseVisualStyleBackColor = True
        '
        'SWResetButton
        '
        Me.SWResetButton.Location = New System.Drawing.Point(1030, 335)
        Me.SWResetButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SWResetButton.Name = "SWResetButton"
        Me.SWResetButton.Size = New System.Drawing.Size(86, 31)
        Me.SWResetButton.TabIndex = 21
        Me.SWResetButton.Text = "Reset"
        Me.SWResetButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(197, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 32)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(103, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 32)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = ":"
        '
        'AlarmHr
        '
        Me.AlarmHr.FormattingEnabled = True
        Me.AlarmHr.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.AlarmHr.Location = New System.Drawing.Point(426, 336)
        Me.AlarmHr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AlarmHr.MaxDropDownItems = 10
        Me.AlarmHr.Name = "AlarmHr"
        Me.AlarmHr.Size = New System.Drawing.Size(57, 28)
        Me.AlarmHr.TabIndex = 24
        '
        'SetAlarm
        '
        Me.SetAlarm.Location = New System.Drawing.Point(672, 335)
        Me.SetAlarm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SetAlarm.Name = "SetAlarm"
        Me.SetAlarm.Size = New System.Drawing.Size(86, 31)
        Me.SetAlarm.TabIndex = 25
        Me.SetAlarm.Text = "Set Alarm"
        Me.SetAlarm.UseVisualStyleBackColor = True
        '
        'AlarmHrLabel
        '
        Me.AlarmHrLabel.AutoSize = True
        Me.AlarmHrLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmHrLabel.Location = New System.Drawing.Point(427, 159)
        Me.AlarmHrLabel.MaximumSize = New System.Drawing.Size(114, 133)
        Me.AlarmHrLabel.MinimumSize = New System.Drawing.Size(114, 133)
        Me.AlarmHrLabel.Name = "AlarmHrLabel"
        Me.AlarmHrLabel.Size = New System.Drawing.Size(114, 133)
        Me.AlarmHrLabel.TabIndex = 26
        Me.AlarmHrLabel.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(523, 180)
        Me.Label3.MaximumSize = New System.Drawing.Size(23, 80)
        Me.Label3.MinimumSize = New System.Drawing.Size(29, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 80)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = ":"
        '
        'AlarmMinLabel
        '
        Me.AlarmMinLabel.AutoSize = True
        Me.AlarmMinLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmMinLabel.Location = New System.Drawing.Point(549, 159)
        Me.AlarmMinLabel.MaximumSize = New System.Drawing.Size(114, 133)
        Me.AlarmMinLabel.MinimumSize = New System.Drawing.Size(114, 133)
        Me.AlarmMinLabel.Name = "AlarmMinLabel"
        Me.AlarmMinLabel.Size = New System.Drawing.Size(114, 133)
        Me.AlarmMinLabel.TabIndex = 28
        Me.AlarmMinLabel.Text = "00"
        '
        'AlarmMin
        '
        Me.AlarmMin.FormattingEnabled = True
        Me.AlarmMin.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.AlarmMin.Location = New System.Drawing.Point(515, 336)
        Me.AlarmMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AlarmMin.MaxDropDownItems = 10
        Me.AlarmMin.Name = "AlarmMin"
        Me.AlarmMin.Size = New System.Drawing.Size(57, 28)
        Me.AlarmMin.TabIndex = 29
        '
        'AlarmSec
        '
        Me.AlarmSec.FormattingEnabled = True
        Me.AlarmSec.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.AlarmSec.Location = New System.Drawing.Point(600, 336)
        Me.AlarmSec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AlarmSec.MaxDropDownItems = 10
        Me.AlarmSec.Name = "AlarmSec"
        Me.AlarmSec.Size = New System.Drawing.Size(57, 28)
        Me.AlarmSec.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(575, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 32)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(490, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 32)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(645, 180)
        Me.Label11.MaximumSize = New System.Drawing.Size(23, 80)
        Me.Label11.MinimumSize = New System.Drawing.Size(29, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 80)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = ":"
        '
        'AlarmSecLabel
        '
        Me.AlarmSecLabel.AutoSize = True
        Me.AlarmSecLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmSecLabel.Location = New System.Drawing.Point(667, 159)
        Me.AlarmSecLabel.MaximumSize = New System.Drawing.Size(114, 133)
        Me.AlarmSecLabel.MinimumSize = New System.Drawing.Size(114, 133)
        Me.AlarmSecLabel.Name = "AlarmSecLabel"
        Me.AlarmSecLabel.Size = New System.Drawing.Size(114, 133)
        Me.AlarmSecLabel.TabIndex = 34
        Me.AlarmSecLabel.Text = "00"
        '
        'AlarmLabel
        '
        Me.AlarmLabel.AutoSize = True
        Me.AlarmLabel.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmLabel.Location = New System.Drawing.Point(523, 75)
        Me.AlarmLabel.Name = "AlarmLabel"
        Me.AlarmLabel.Size = New System.Drawing.Size(148, 62)
        Me.AlarmLabel.TabIndex = 35
        Me.AlarmLabel.Text = "Alarm"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 705)
        Me.Splitter1.TabIndex = 36
        Me.Splitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 705)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.AlarmLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AlarmSecLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AlarmSec)
        Me.Controls.Add(Me.AlarmMin)
        Me.Controls.Add(Me.AlarmMinLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AlarmHrLabel)
        Me.Controls.Add(Me.SetAlarm)
        Me.Controls.Add(Me.AlarmHr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SWResetButton)
        Me.Controls.Add(Me.SWStopButton)
        Me.Controls.Add(Me.SWStartButton)
        Me.Controls.Add(Me.ClockLabel)
        Me.Controls.Add(Me.StopwatchLabel)
        Me.Controls.Add(Me.StWtchFraction)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StWtchSec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StWtchMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SetTime)
        Me.Controls.Add(Me.ClkSec)
        Me.Controls.Add(Me.ClkMin)
        Me.Controls.Add(Me.ClkHr)
        Me.Controls.Add(Me.SecLabel)
        Me.Controls.Add(Me.MinLabel)
        Me.Controls.Add(Me.HourLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HourLabel As Label
    Friend WithEvents MinLabel As Label
    Friend WithEvents SecLabel As Label
    Friend WithEvents ClkHr As TextBox
    Friend WithEvents ClkMin As TextBox
    Friend WithEvents Clk As TextBox
    Friend WithEvents ClkSec As TextBox
    Friend WithEvents SetTime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StWtchMin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StWtchSec As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StWtchFraction As Label
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents ClockLabel As Label
    Friend WithEvents SWStartButton As Button
    Friend WithEvents SWStopButton As Button
    Friend WithEvents SWResetButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AlarmHr As ComboBox
    Friend WithEvents SetAlarm As Button
    Friend WithEvents AlarmHrLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AlarmMinLabel As Label
    Friend WithEvents AlarmMin As ComboBox
    Friend WithEvents AlarmSec As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents AlarmSecLabel As Label
    Friend WithEvents AlarmLabel As Label
    Friend WithEvents Splitter1 As Splitter
End Class
