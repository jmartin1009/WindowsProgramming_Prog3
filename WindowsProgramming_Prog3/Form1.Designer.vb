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
        Me.components = New System.ComponentModel.Container()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.HourLabel = New System.Windows.Forms.Label()
        Me.MinLabel = New System.Windows.Forms.Label()
        Me.SecLabel = New System.Windows.Forms.Label()
        Me.ClkHrTextbox = New System.Windows.Forms.TextBox()
        Me.ClkMinTextbox = New System.Windows.Forms.TextBox()
        Me.ClkSecTextbox = New System.Windows.Forms.TextBox()
        Me.SetTime = New System.Windows.Forms.Button()
        Me.Alarm = New System.Windows.Forms.Timer(Me.components)
        Me.Stopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SWHrLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SWMinLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SWSecLabel = New System.Windows.Forms.Label()
        Me.StopwatchLabel = New System.Windows.Forms.Label()
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.SWStartButton = New System.Windows.Forms.Button()
        Me.SWStopButton = New System.Windows.Forms.Button()
        Me.SWResetButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AlarmHrBox = New System.Windows.Forms.ComboBox()
        Me.SetAlarmButton = New System.Windows.Forms.Button()
        Me.AlarmHrLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlarmMinLabel = New System.Windows.Forms.Label()
        Me.AlarmMinBox = New System.Windows.Forms.ComboBox()
        Me.AlarmSecBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AlarmSecLabel = New System.Windows.Forms.Label()
        Me.AlarmLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HourLabel
        '
        Me.HourLabel.AutoSize = True
        Me.HourLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HourLabel.Location = New System.Drawing.Point(19, 119)
        Me.HourLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.HourLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.HourLabel.Name = "HourLabel"
        Me.HourLabel.Size = New System.Drawing.Size(100, 100)
        Me.HourLabel.TabIndex = 3
        Me.HourLabel.Text = "00"
        '
        'MinLabel
        '
        Me.MinLabel.AutoSize = True
        Me.MinLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinLabel.Location = New System.Drawing.Point(125, 119)
        Me.MinLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.MinLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.MinLabel.Name = "MinLabel"
        Me.MinLabel.Size = New System.Drawing.Size(100, 100)
        Me.MinLabel.TabIndex = 4
        Me.MinLabel.Text = "00"
        '
        'SecLabel
        '
        Me.SecLabel.AutoSize = True
        Me.SecLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SecLabel.Location = New System.Drawing.Point(226, 119)
        Me.SecLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.SecLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.SecLabel.Name = "SecLabel"
        Me.SecLabel.Size = New System.Drawing.Size(100, 100)
        Me.SecLabel.TabIndex = 5
        Me.SecLabel.Text = "00"
        '
        'ClkHrTextbox
        '
        Me.ClkHrTextbox.Location = New System.Drawing.Point(33, 254)
        Me.ClkHrTextbox.Name = "ClkHrTextbox"
        Me.ClkHrTextbox.Size = New System.Drawing.Size(51, 23)
        Me.ClkHrTextbox.TabIndex = 6
        '
        'ClkMinTextbox
        '
        Me.ClkMinTextbox.Location = New System.Drawing.Point(115, 253)
        Me.ClkMinTextbox.Name = "ClkMinTextbox"
        Me.ClkMinTextbox.Size = New System.Drawing.Size(51, 23)
        Me.ClkMinTextbox.TabIndex = 7
        '
        'ClkSecTextbox
        '
        Me.ClkSecTextbox.Location = New System.Drawing.Point(194, 253)
        Me.ClkSecTextbox.Name = "ClkSecTextbox"
        Me.ClkSecTextbox.Size = New System.Drawing.Size(51, 23)
        Me.ClkSecTextbox.TabIndex = 8
        '
        'SetTime
        '
        Me.SetTime.Location = New System.Drawing.Point(251, 253)
        Me.SetTime.Name = "SetTime"
        Me.SetTime.Size = New System.Drawing.Size(75, 23)
        Me.SetTime.TabIndex = 9
        Me.SetTime.Text = "Set Time"
        Me.SetTime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(104, 135)
        Me.Label1.MaximumSize = New System.Drawing.Size(25, 50)
        Me.Label1.MinimumSize = New System.Drawing.Size(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 50)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(210, 135)
        Me.Label2.MaximumSize = New System.Drawing.Size(20, 60)
        Me.Label2.MinimumSize = New System.Drawing.Size(25, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 60)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = ":"
        '
        'SWHrLabel
        '
        Me.SWHrLabel.AutoSize = True
        Me.SWHrLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SWHrLabel.Location = New System.Drawing.Point(689, 119)
        Me.SWHrLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.SWHrLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.SWHrLabel.Name = "SWHrLabel"
        Me.SWHrLabel.Size = New System.Drawing.Size(100, 100)
        Me.SWHrLabel.TabIndex = 12
        Me.SWHrLabel.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(779, 135)
        Me.Label4.MaximumSize = New System.Drawing.Size(25, 50)
        Me.Label4.MinimumSize = New System.Drawing.Size(25, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 50)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ":"
        '
        'SWMinLabel
        '
        Me.SWMinLabel.AutoSize = True
        Me.SWMinLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SWMinLabel.Location = New System.Drawing.Point(795, 119)
        Me.SWMinLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.SWMinLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.SWMinLabel.Name = "SWMinLabel"
        Me.SWMinLabel.Size = New System.Drawing.Size(100, 100)
        Me.SWMinLabel.TabIndex = 14
        Me.SWMinLabel.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(881, 135)
        Me.Label6.MaximumSize = New System.Drawing.Size(20, 60)
        Me.Label6.MinimumSize = New System.Drawing.Size(25, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 60)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = ":"
        '
        'SWSecLabel
        '
        Me.SWSecLabel.AutoSize = True
        Me.SWSecLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SWSecLabel.Location = New System.Drawing.Point(901, 119)
        Me.SWSecLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.SWSecLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.SWSecLabel.Name = "SWSecLabel"
        Me.SWSecLabel.Size = New System.Drawing.Size(100, 100)
        Me.SWSecLabel.TabIndex = 16
        Me.SWSecLabel.Text = "00"
        '
        'StopwatchLabel
        '
        Me.StopwatchLabel.AutoSize = True
        Me.StopwatchLabel.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StopwatchLabel.Location = New System.Drawing.Point(755, 56)
        Me.StopwatchLabel.Name = "StopwatchLabel"
        Me.StopwatchLabel.Size = New System.Drawing.Size(195, 50)
        Me.StopwatchLabel.TabIndex = 17
        Me.StopwatchLabel.Text = "Stopwatch"
        '
        'ClockLabel
        '
        Me.ClockLabel.AutoSize = True
        Me.ClockLabel.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClockLabel.Location = New System.Drawing.Point(104, 56)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(111, 50)
        Me.ClockLabel.TabIndex = 18
        Me.ClockLabel.Text = "Clock"
        '
        'SWStartButton
        '
        Me.SWStartButton.Location = New System.Drawing.Point(714, 251)
        Me.SWStartButton.Name = "SWStartButton"
        Me.SWStartButton.Size = New System.Drawing.Size(75, 23)
        Me.SWStartButton.TabIndex = 19
        Me.SWStartButton.Text = "Start"
        Me.SWStartButton.UseVisualStyleBackColor = True
        '
        'SWStopButton
        '
        Me.SWStopButton.Location = New System.Drawing.Point(809, 251)
        Me.SWStopButton.Name = "SWStopButton"
        Me.SWStopButton.Size = New System.Drawing.Size(75, 23)
        Me.SWStopButton.TabIndex = 20
        Me.SWStopButton.Text = "Stop"
        Me.SWStopButton.UseVisualStyleBackColor = True
        '
        'SWResetButton
        '
        Me.SWResetButton.Location = New System.Drawing.Point(901, 251)
        Me.SWResetButton.Name = "SWResetButton"
        Me.SWResetButton.Size = New System.Drawing.Size(75, 23)
        Me.SWResetButton.TabIndex = 21
        Me.SWResetButton.Text = "Reset"
        Me.SWResetButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(172, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(90, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 25)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = ":"
        '
        'AlarmHrBox
        '
        Me.AlarmHrBox.FormattingEnabled = True
        Me.AlarmHrBox.Location = New System.Drawing.Point(373, 252)
        Me.AlarmHrBox.MaxDropDownItems = 3
        Me.AlarmHrBox.Name = "AlarmHrBox"
        Me.AlarmHrBox.Size = New System.Drawing.Size(50, 23)
        Me.AlarmHrBox.TabIndex = 24
        '
        'SetAlarmButton
        '
        Me.SetAlarmButton.Location = New System.Drawing.Point(588, 251)
        Me.SetAlarmButton.Name = "SetAlarmButton"
        Me.SetAlarmButton.Size = New System.Drawing.Size(75, 23)
        Me.SetAlarmButton.TabIndex = 25
        Me.SetAlarmButton.Text = "Set Alarm"
        Me.SetAlarmButton.UseVisualStyleBackColor = True
        '
        'AlarmHrLabel
        '
        Me.AlarmHrLabel.AutoSize = True
        Me.AlarmHrLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmHrLabel.Location = New System.Drawing.Point(374, 119)
        Me.AlarmHrLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.AlarmHrLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.AlarmHrLabel.Name = "AlarmHrLabel"
        Me.AlarmHrLabel.Size = New System.Drawing.Size(100, 100)
        Me.AlarmHrLabel.TabIndex = 26
        Me.AlarmHrLabel.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(458, 135)
        Me.Label3.MaximumSize = New System.Drawing.Size(20, 60)
        Me.Label3.MinimumSize = New System.Drawing.Size(25, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 60)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = ":"
        '
        'AlarmMinLabel
        '
        Me.AlarmMinLabel.AutoSize = True
        Me.AlarmMinLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmMinLabel.Location = New System.Drawing.Point(480, 119)
        Me.AlarmMinLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.AlarmMinLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.AlarmMinLabel.Name = "AlarmMinLabel"
        Me.AlarmMinLabel.Size = New System.Drawing.Size(100, 100)
        Me.AlarmMinLabel.TabIndex = 28
        Me.AlarmMinLabel.Text = "00"
        '
        'AlarmMinBox
        '
        Me.AlarmMinBox.FormattingEnabled = True
        Me.AlarmMinBox.Location = New System.Drawing.Point(451, 252)
        Me.AlarmMinBox.MaxDropDownItems = 3
        Me.AlarmMinBox.Name = "AlarmMinBox"
        Me.AlarmMinBox.Size = New System.Drawing.Size(50, 23)
        Me.AlarmMinBox.TabIndex = 29
        '
        'AlarmSecBox
        '
        Me.AlarmSecBox.FormattingEnabled = True
        Me.AlarmSecBox.Location = New System.Drawing.Point(525, 252)
        Me.AlarmSecBox.MaxDropDownItems = 3
        Me.AlarmSecBox.Name = "AlarmSecBox"
        Me.AlarmSecBox.Size = New System.Drawing.Size(50, 23)
        Me.AlarmSecBox.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(503, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(429, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 25)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(564, 135)
        Me.Label11.MaximumSize = New System.Drawing.Size(20, 60)
        Me.Label11.MinimumSize = New System.Drawing.Size(25, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 60)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = ":"
        '
        'AlarmSecLabel
        '
        Me.AlarmSecLabel.AutoSize = True
        Me.AlarmSecLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmSecLabel.Location = New System.Drawing.Point(574, 119)
        Me.AlarmSecLabel.MaximumSize = New System.Drawing.Size(100, 100)
        Me.AlarmSecLabel.MinimumSize = New System.Drawing.Size(100, 100)
        Me.AlarmSecLabel.Name = "AlarmSecLabel"
        Me.AlarmSecLabel.Size = New System.Drawing.Size(100, 100)
        Me.AlarmSecLabel.TabIndex = 34
        Me.AlarmSecLabel.Text = "00"
        '
        'AlarmLabel
        '
        Me.AlarmLabel.AutoSize = True
        Me.AlarmLabel.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlarmLabel.Location = New System.Drawing.Point(458, 56)
        Me.AlarmLabel.Name = "AlarmLabel"
        Me.AlarmLabel.Size = New System.Drawing.Size(119, 50)
        Me.AlarmLabel.TabIndex = 35
        Me.AlarmLabel.Text = "Alarm"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 529)
        Me.Controls.Add(Me.AlarmLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AlarmSecLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AlarmSecBox)
        Me.Controls.Add(Me.AlarmMinBox)
        Me.Controls.Add(Me.AlarmMinLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AlarmHrLabel)
        Me.Controls.Add(Me.SetAlarmButton)
        Me.Controls.Add(Me.AlarmHrBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SWResetButton)
        Me.Controls.Add(Me.SWStopButton)
        Me.Controls.Add(Me.SWStartButton)
        Me.Controls.Add(Me.ClockLabel)
        Me.Controls.Add(Me.StopwatchLabel)
        Me.Controls.Add(Me.SWSecLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SWMinLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SWHrLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SetTime)
        Me.Controls.Add(Me.ClkSecTextbox)
        Me.Controls.Add(Me.ClkMinTextbox)
        Me.Controls.Add(Me.ClkHrTextbox)
        Me.Controls.Add(Me.SecLabel)
        Me.Controls.Add(Me.MinLabel)
        Me.Controls.Add(Me.HourLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clock As Timer
    Friend WithEvents HourLabel As Label
    Friend WithEvents MinLabel As Label
    Friend WithEvents SecLabel As Label
    Friend WithEvents ClkHrTextbox As TextBox
    Friend WithEvents ClkMinTextbox As TextBox
    Friend WithEvents Clk As TextBox
    Friend WithEvents ClkSecTextbox As TextBox
    Friend WithEvents SetTime As Button
    Friend WithEvents Alarm As Timer
    Friend WithEvents Stopwatch As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SWHrLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SWMinLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SWSecLabel As Label
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents ClockLabel As Label
    Friend WithEvents SWStartButton As Button
    Friend WithEvents SWStopButton As Button
    Friend WithEvents SWResetButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AlarmHrBox As ComboBox
    Friend WithEvents SetAlarmButton As Button
    Friend WithEvents AlarmHrLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AlarmMinLabel As Label
    Friend WithEvents AlarmMinBox As ComboBox
    Friend WithEvents AlarmSecBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents AlarmSecLabel As Label
    Friend WithEvents AlarmLabel As Label
End Class
