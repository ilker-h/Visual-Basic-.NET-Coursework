Public Class Form1 ' Ilker Hadzhalaran

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblDiameter, dblHeight, dblDepth, dblSheetThickness, dblSheetWidth, dblVolume, dblForce, dblWorkAtHeight, dblTotalWork As Double
        Dim intN As Integer

        dblDiameter = CDbl(txtInputDiameter.Text)
        dblHeight = CDbl(txtInputHeight.Text)
        dblDepth = CDbl(txtInputDepth.Text)
        dblSheetThickness = CDbl(txtInputSheetThickness.Text)

        If dblHeight < dblDepth Or dblDepth < dblSheetThickness Then
            MsgBox("Height of the tank must be greater than depth of oil, and the depth of oil must be larger than and a multiple of the sheet thickness.")
            Exit Sub

        End If

        lblDiameter.Text = "Diameter (m): " & dblDiameter.ToString("N3")
        lblHeight.Text = "Height (m): " & dblHeight.ToString("N3")
        lblDepth.Text = "Depth (m): " & dblDepth.ToString("N3")
        lblSheetThickness.Text = "Sheet Thickness (m): " & dblSheetThickness.ToString("N3")

        dblSheetWidth = dblDepth * dblDiameter / dblHeight

        dblVolume = CalculateVolume(dblSheetWidth, dblSheetThickness)

        dblForce = CalculateForce(dblVolume)

        dblWorkAtHeight = CalculateWorkAtHeight(dblForce, dblDepth)

        dblTotalWork = 0
        intN = CInt(dblDepth / dblSheetThickness)

        For intCounter As Integer = 1 To intN Step 1

            dblTotalWork += dblWorkAtHeight

        Next intCounter

        lblTotalWork.Text = "Total Work (N): " & dblTotalWork.ToString("N3")

    End Sub

    Private Function CalculateVolume(ByVal dblSheetWidth As Double, ByVal dblSheetThickness As Double) As Double
        Dim dblVolume As Double

        dblVolume = (Math.PI) * (dblSheetWidth / 2) ^ 2 * (dblSheetThickness)
        Return dblVolume



    End Function


    Private Function CalculateForce(ByVal dblVolume As Double) As Double
        Const GRAVITY As Double = 9.8 'in m/s^2
        Const DENSITY As Double = 2000 'in kg/m^3
        Dim dblForce As Double

        dblForce = DENSITY * GRAVITY * dblVolume
        Return dblForce

    End Function

    Private Function CalculateWorkAtHeight(ByVal dblForce As Double, ByVal dblDepth As Double) As Double

        Dim dblWorkAtHeight As Double

        dblWorkAtHeight = dblForce * (20 - dblDepth)
        Return dblWorkAtHeight

    End Function



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDepth.Text = String.Empty
        lblDiameter.Text = String.Empty
        lblHeight.Text = String.Empty
        lblSheetThickness.Text = String.Empty
        lblTotalWork.Text = String.Empty

        txtInputDepth.Clear()
        txtInputDiameter.Clear()
        txtInputHeight.Clear()
        txtInputSheetThickness.Clear()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
