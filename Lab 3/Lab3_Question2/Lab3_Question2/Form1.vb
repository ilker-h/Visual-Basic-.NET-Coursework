Public Class Form1   ' Ilker Hadzhalaran

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        Dim intM As Integer
        Dim intN As Integer
        Dim intJ As Integer

        If isInputValid(intM, intN) = False Then

            MsgBox("m and n values must be positive integer numbers, where m is less than n.")
            Exit Sub
        End If

        intM = CInt(txtM.Text)
        intN = CInt(txtN.Text)

        For intCounter As Integer = intM To intN

            If isPrime(intCounter, intJ) = True Then

                lstDisplayPrimeNumbers.Items.Add(intCounter)

            End If

        Next intCounter



    End Sub

    Private Function isInputValid(ByVal intM As Integer, ByVal intN As Integer)

        If Not (Integer.TryParse(txtM.Text, intM) And Integer.TryParse(txtN.Text, intN)) Then

            Return False

        ElseIf intM >= intN Then
            Return False

        ElseIf intM < 1 Or intN < 1 Then
            Return False

        Else
            Return True
        End If

    End Function


    Private Function isPrime(intCounter As Integer, intJ As Integer)

        If intCounter = 2 Then
            Return True
            Exit Function
        End If

        For intJ = 2 To (intCounter - 1)
            If (intCounter Mod intJ = 0) Then
                Return False
                Exit For
            Else
                Return True
                Exit For
            End If

        Next intJ


    End Function


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        resetControls(txtM, txtN, lstDisplayPrimeNumbers)


    End Sub

    Private Sub resetControls(txtM, txtN, lstDisplayPrimeNumbers)

        txtM.Text = String.Empty
        txtN.Text = String.Empty
        lstDisplayPrimeNumbers.Items.Clear()


    End Sub


End Class
