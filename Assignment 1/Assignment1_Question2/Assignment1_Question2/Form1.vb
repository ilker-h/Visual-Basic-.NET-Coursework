Public Class Form1       'Ilker Hadzhalaran

    Dim dblUnstretchedLength As Double
    Dim dblUpwardAcceleration As Double
    Dim dblRadius As Double
    Dim dblChangeInLength As Double
    Const YOUNGS_MODULUS As Double = (2.0 * 10 ^ (11))
    Const GRAVITY_CONSTANT As Double = 9.81

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        lstTableofResults.Items.Clear()

        dblUnstretchedLength = CDbl(txtInputUnstretchedLength.Text)
        dblUpwardAcceleration = CDbl(txtInputAccelerationObject.Text)
        dblRadius = CDbl(txtInputRadius.Text)

        lblShowInputLength.Text = "Length: " & dblUnstretchedLength.ToString & " m"
        lblShowInputAcceleration.Text = "Acceleration: " & dblUpwardAcceleration.ToString & " m/s^2"
        lblShowInputRadius.Text = "Radius: " & dblRadius.ToString & " m"

        lstTableofResults.Items.Add("Mass (kg)" & Space(5) & "Change in Length (m)")
        lstTableofResults.Items.Add("----------------------------------")

        For intMass As Integer = 1000 To 5000 Step 200

            dblChangeInLength = intMass * (dblUpwardAcceleration + GRAVITY_CONSTANT) * dblUnstretchedLength / (YOUNGS_MODULUS * (Math.PI * dblRadius ^ 2))

            If (dblChangeInLength >= (0.003 * dblUnstretchedLength)) Then
                lstTableofResults.Items.Add((intMass).ToString & Space(10) & (dblChangeInLength).ToString("e3") & "***")

            Else
                lstTableofResults.Items.Add((intMass).ToString & Space(10) & (dblChangeInLength).ToString("e3"))

            End If


        Next


    End Sub




End Class
