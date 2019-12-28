Public Class Form1 'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayArray.Text = String.Empty
        txtUserEntersNumberOfNumbers.Clear()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim N As Integer
        Dim intArray() As Integer = {}
        Dim rand As New Random()
        Dim intRandomNumber As Integer
        Dim intMin, intMax As Integer

        N = CInt(txtUserEntersNumberOfNumbers.Text)

        If N > 0 Then
            ReDim intArray(N - 1)
        Else
            lblDisplayArray.Text = "Enter a number greater than 0."
            Exit Sub
        End If

        For intCounter As Integer = 0 To intArray.Length - 1 Step 1

            If intCounter Mod 10 = 0 And intCounter <> 0 Then
                lblDisplayArray.Text &= vbCr
            End If

            intRandomNumber = rand.Next(1001) + 1

            intArray(intCounter) = intRandomNumber

            lblDisplayArray.Text &= Space(5) & intArray(intCounter).ToString()
        Next

        FindMinAndMax(intMin, intMax, N, intArray)

        lblDisplayArray.Text &= vbCr & vbCr & "Random Number with the highest value: " & intMax
        lblDisplayArray.Text &= vbCr & "Random Number with the lowest value: " & intMin

    End Sub

    Private Sub FindMinAndMax(ByRef intMin As Integer, ByRef intMax As Integer, ByVal N As Integer, ByVal ParamArray intArray() As Integer)

        intMin = intArray.Min
        intMax = intArray.Max

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplayArray.Text = String.Empty
        txtUserEntersNumberOfNumbers.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
