Public Class Form1    'Ilker Hadzhalaran

    Dim intSecondsEntered As Integer

    Dim intSeconds As Integer
    Dim intMinutes As Integer
    Dim intHours As Integer
    Dim intDays As Integer

    Dim intMinutesRemainder As Integer
    Dim intHoursRemainder As Integer
    Dim intDaysRemainder As Integer

    Const SECONDS_IN_MINUTE As Integer = 60
    Const SECONDS_IN_HOUR As Integer = 3600
    Const SECONDS_IN_DAY As Integer = 86400


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If Not (Integer.TryParse(txtEnterSeconds.Text, intSecondsEntered) Or Double.TryParse(txtEnterSeconds.Text, intSecondsEntered)) Then
            MsgBox("Invalid value. Please enter a number only.")
            txtEnterSeconds.Clear()
            txtEnterSeconds.Focus()
            Exit Sub

        End If

        intSecondsEntered = CInt(txtEnterSeconds.Text)

        If (intSecondsEntered <= 0) Then
            MsgBox("Please enter a positive, non-zero number.")
            Exit Sub
        End If

        intDays = intSecondsEntered \ SECONDS_IN_DAY
        intDaysRemainder = intSecondsEntered Mod SECONDS_IN_DAY

        intHours = intDaysRemainder \ SECONDS_IN_HOUR
        intHoursRemainder = intDaysRemainder Mod SECONDS_IN_HOUR

        intMinutes = intHoursRemainder \ SECONDS_IN_MINUTE
        intMinutesRemainder = intDaysRemainder Mod SECONDS_IN_MINUTE

        intSeconds = intMinutesRemainder

        lblDisplayResults.Text = (intDays).ToString & " day(s), " & (intHours).ToString & " hour(s), " & (intMinutes).ToString & " minute(s), " & (intSeconds).ToString & " second(s)"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplayResults.Text = String.Empty
        txtEnterSeconds.Clear()

    End Sub

End Class
