Public Class Form1    ' Ilker Hadzhalaran 

    Dim dblFx As Double
    Dim dblFy As Double
    Dim dblResultantVector As Double
    Dim dblThetaA As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkShowThetaA.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        dblFx = CDbl(txtInputFx.Text)
        dblFy = CDbl(txtInputFy.Text)

        'Ensuring the Fx and Fy values are not 0
        If (dblFx = 0 Or dblFy = 0) Then
            MsgBox("Neither Fx nor Fy can be 0")
        End If

        'Calculation and displaying the result
        dblResultantVector = CDbl(Math.Sqrt(Math.Pow(dblFx, 2) + Math.Pow(dblFy, 2)))
        lblResultantVector.Text = "Resultant Vector: " & (dblResultantVector).ToString("n1")

        dblThetaA = CDbl((Math.Atan(Math.Abs(dblFy / dblFx))) * (180 / (Math.PI)))


        'Checking if checkbox is checked or not and determining which angle to show
        If chkShowThetaA.Checked = True Then
            lblDirectionAngle.Text = "Direction Angle (deg): " & (dblThetaA).ToString("n1")

        ElseIf (chkShowThetaA.Checked = False) Then

            If (dblFx > 0 And dblFy > 0) Then
                lblDirectionAngle.Text = "Direction Angle (deg): " & (dblThetaA).ToString("n1")

            ElseIf (dblFx > 0 And dblFy < 0) Then
                lblDirectionAngle.Text = "Direction Angle (deg): " & (360 - dblThetaA).ToString("n1")

            ElseIf (dblFx < 0 And dblFy > 0) Then
                lblDirectionAngle.Text = "Direction Angle (deg): " & (180 - dblThetaA).ToString("n1")

            ElseIf (dblFx < 0 And dblFy < 0) Then
                lblDirectionAngle.Text = "Direction Angle (deg): " & (180 + dblThetaA).ToString("n1")


            End If

        End If



    End Sub



End Class
