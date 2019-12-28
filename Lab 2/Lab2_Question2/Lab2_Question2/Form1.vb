Public Class Form1     ' Ilker Hadzhalaran 

    Dim dblMassPlanet As Double
    Dim dblMassObject As Double
    Const dblGRAVITY_CONST As Double = 0.00000000006674
    Const dblR_ON_PLANET As Double = 6380000
    Dim dblDistanceBetweenPlanetAndObject As Double
    Dim dblResultWeight As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rad100Above.Checked = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Using TryParse to find/fix errors
        If Not Double.TryParse(txtInputMassPlanet.Text, dblMassPlanet) Then
            MsgBox("Invalid Mass of Planet value", , "Error")

        ElseIf Not Double.TryParse(txtInputMassObject.Text, dblMassObject) Then
            MsgBox("Invalid Mass of Object value", , "Error")

        End If

        dblMassPlanet = CDbl(txtInputMassPlanet.Text)
        dblMassObject = CDbl(txtInputMassObject.Text)


        'Radio buttons
        If radOnPlanet.Checked = True Then
            dblDistanceBetweenPlanetAndObject = dblR_ON_PLANET

        ElseIf rad100Above.Checked = True Then
            dblDistanceBetweenPlanetAndObject = CDbl(dblR_ON_PLANET + 100000)

        Else
            dblDistanceBetweenPlanetAndObject = CDbl(dblR_ON_PLANET + 500000)

        End If


        'The calculation
        dblResultWeight = CDbl(dblGRAVITY_CONST * (dblMassPlanet * dblMassObject) / Math.Pow(dblDistanceBetweenPlanetAndObject, 2))

        'Displaying the inputs and outputs
        lblResultWeight.Text = "Result Weight (N): " & dblResultWeight.ToString("e")
        lblDisplayPlanetMass.Text = "Planet Mass (kg): " & dblMassPlanet.ToString("e")
        lblDisplayObjectMass.Text = "Object Mass (kg): " & dblMassObject.ToString("e")

    End Sub


End Class
