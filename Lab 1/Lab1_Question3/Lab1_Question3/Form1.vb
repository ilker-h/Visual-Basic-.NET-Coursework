Public Class Form1

    ' Ilker Hadzhalaran

    Dim dblForce1 As Double
    Dim dblForce2 As Double
    Dim dblForce3 As Double
    Dim dblAngle1 As Double
    Dim dblAngle2 As Double
    Dim dblAngle3 As Double
    Dim dblCalculate As Double
    Dim dblSX As Double
    Dim dblSY As Double



    Private Sub txtInputForce1_TextChanged(sender As Object, e As EventArgs) Handles txtInputForce1.TextChanged
        dblForce1 = CDbl(txtInputForce1.Text)
        lblForce1ResultSecondTab.Text = dblForce1.ToString("n3")


    End Sub

    Private Sub txtInputForce2_TextChanged(sender As Object, e As EventArgs) Handles txtInputForce2.TextChanged
        dblForce2 = CDbl(txtInputForce2.Text)
        lblForce2ResultSecondTab.Text = dblForce2.ToString("n3")

    End Sub

    Private Sub txtInputForce3_TextChanged(sender As Object, e As EventArgs) Handles txtInputForce3.TextChanged
        dblForce3 = CDbl(txtInputForce3.Text)
        lblForce3ResultSecondTab.Text = dblForce3.ToString("n3")
    End Sub

    Private Sub txtInputAngle1_TextChanged(sender As Object, e As EventArgs) Handles txtInputAngle1.TextChanged
        dblAngle1 = CDbl(txtInputAngle1.Text)
        lblAngle1ResultSecondTab.Text = dblAngle1.ToString("n3")
    End Sub

    Private Sub txtInputAngle2_TextChanged(sender As Object, e As EventArgs) Handles txtInputAngle2.TextChanged
        dblAngle2 = CDbl(txtInputAngle2.Text)
        lblAngle2ResultSecondTab.Text = dblAngle2.ToString("n3")
    End Sub

    Private Sub txtInputAngle3_TextChanged(sender As Object, e As EventArgs) Handles txtInputAngle3.TextChanged
        dblAngle3 = CDbl(txtInputAngle3.Text)
        lblAngle3ResultSecondTab.Text = dblAngle3.ToString("n3")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        dblSX = dblForce1 * Math.Cos(dblAngle1) + dblForce2 * Math.Cos(dblAngle2) + dblForce3 * Math.Cos(dblAngle3)
        dblSY = dblForce1 * Math.Sin(dblAngle1) + dblForce2 * Math.Sin(dblAngle2) + dblForce3 * Math.Sin(dblAngle3)

        lblSXThirdTab.Text = dblSX.ToString("n3")
        lblSYThirdTab.Text = dblSY.ToString("n3")

        lblF1XThirdTab.Text = (dblForce1 * Math.Cos(dblAngle1)).ToString("n3")
        lblF2XThirdTab.Text = (dblForce2 * Math.Cos(dblAngle2)).ToString("n3")
        lblF3XThirdTab.Text = (dblForce3 * Math.Cos(dblAngle3)).ToString("n3")

        lblF1YThirdTab.Text = (dblForce1 * Math.Sin(dblAngle1)).ToString("n3")
        lblF2YThirdTab.Text = (dblForce2 * Math.Sin(dblAngle2)).ToString("n3")
        lblF3YThirdTab.Text = (dblForce3 * Math.Sin(dblAngle3)).ToString("n3")




        dblCalculate = Math.Sqrt(Math.Pow(dblSX, 2) + Math.Pow(dblSY, 2))
        lblResultantThirdTab.Text = dblCalculate.ToString("n")

        lblInstructionsAfterCalculation.Text = "Your Calculation has been completed. Check the other tabs to see the results."


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



End Class
