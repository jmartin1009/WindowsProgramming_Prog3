Public Class Form1
    Dim clkHour As Int16
    Dim clkMins As Int16
    Dim clkSecs As Int16
    Dim clockThreadHr As System.Threading.Thread
    Dim clockThreadMin As System.Threading.Thread
    Dim clockThreadSec As System.Threading.Thread
    Dim alarmThread As System.Threading.Thread
    Dim swThread As System.Threading.Thread

    Private Sub SetTime_Click(sender As Object, e As EventArgs) Handles SetTime.Click
        If (ClkHr.Text = "" Or ClkMin.Text = "" Or ClkSec.Text = "") Then
            MessageBox.Show("Please enter a valid time")
        Else
            If (clockThreadSec.IsAlive) Then
                clockThreadSec.Abort()
            End If
            Dim hour As String = ClkHr.Text
            Dim min As String = ClkMin.Text
            Dim sec As String = ClkSec.Text
            HourLabel.Text = hour
            MinLabel.Text = min
            SecLabel.Text = sec
            clkHour = CInt(hour)
            clkMins = CInt(min)
            clkSecs = CInt(sec)
            clockThreadSec = New System.Threading.Thread(AddressOf timeUpSec)
            clockThreadMin = New System.Threading.Thread(AddressOf timeUpMin)
            clockThreadHr = New System.Threading.Thread(AddressOf timeUpHr)
            clockThreadSec.Start()
        End If
    End Sub

    Private Sub timeUpSec()
        Do While clkSecs >= -1
            If (clkSecs = 60) Then
                clkMins = clkMins + 1
                clkSecs = -1
                clockThreadMin.Interrupt()
                clockThreadMin = New System.Threading.Thread(AddressOf timeUpMin)
                clockThreadMin.Start()
            End If
            clkSecs = clkSecs + 1
            SecLabel.Text = clkSecs.ToString
            Me.Refresh()
            clockThreadSec.Sleep(1000)
        Loop

    End Sub

    Private Sub timeUpMin()
        If (clkMins < 60) Then
            MinLabel.Text = clkMins.ToString
        Else
            clkMins = 0
            MinLabel.Text = "00"
            clkHour = clkHour + 1
            clockThreadHr.Interrupt()
            clockThreadHr = New System.Threading.Thread(AddressOf timeUpHr)
            clockThreadHr.Start()
        End If
        Me.Refresh()
        clockThreadMin.Interrupt()
    End Sub
    Private Sub timeUpHr()


    End Sub

    Private Sub SetAlarmButton_Click(sender As Object, e As EventArgs) Handles SetAlarm.Click

    End Sub

    Private Sub SWStartButton_Click(sender As Object, e As EventArgs) Handles SWStartButton.Click

    End Sub

    Private Sub SWStopButton_Click(sender As Object, e As EventArgs) Handles SWStopButton.Click

    End Sub

    Private Sub SWResetButton_Click(sender As Object, e As EventArgs) Handles SWResetButton.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
        clockThreadSec = New System.Threading.Thread(AddressOf timeUpSec)
        clockThreadMin = New System.Threading.Thread(AddressOf timeUpMin)
        clockThreadHr = New System.Threading.Thread(AddressOf timeUpHr)
    End Sub
End Class
