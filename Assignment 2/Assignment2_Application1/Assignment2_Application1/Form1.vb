Public Class Form1 ' Ilker Hadzhalaran

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblPo, dblK, dblTime As Double

        dblPo = CDbl(txtInputPo.Text)
        dblK = CDbl(txtInputK.Text)


        If dblK < -0.08 Or dblK > 0.08 Then
            MsgBox("The k value must be: -0.08 <= k <= 0.08")
            Exit Sub

        ElseIf dblPo <= 0 Then
            MsgBox("The P value must be greater than 0")
            Exit Sub
        End If

        If dblK > 0 Then
            lblModelType.Text = "This is a growth model"

            dblTime = GrowthModel(dblPo, dblK)

            lblDoubleOrHalfTime.Text = "The doubling time is " & (dblTime / 60).ToString("n3") & " min"

        Else
            lblModelType.Text = "This is a decay model"

            dblTime = DecayModel(dblPo, dblK)

            lblDoubleOrHalfTime.Text = "The half life time is " & (dblTime / 60).ToString("n3") & " min"

        End If




    End Sub

    Private Function GrowthModel(ByVal dblPo As Double, ByVal dblK As Double) As Double

        Dim dblTime As Double

        dblTime = (Math.Log(2)) / dblK
        Return dblTime

    End Function


    Private Function DecayModel(ByVal dblPo As Double, ByVal dblK As Double) As Double

        Dim dblTime As Double

        dblTime = (Math.Log(0.5)) / dblK
        Return dblTime

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDoubleOrHalfTime.Text = String.Empty
        lblModelType.Text = String.Empty
        txtInputPo.Clear()
        txtInputK.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
