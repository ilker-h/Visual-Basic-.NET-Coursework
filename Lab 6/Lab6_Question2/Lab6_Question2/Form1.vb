Public Class Form1 'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstMaterialsList.Items.Add("Aluminum")
        lstMaterialsList.Items.Add("Brass")
        lstMaterialsList.Items.Add("Copper")
        lstMaterialsList.Items.Add("Nylon")
        lstMaterialsList.Items.Add("Steel")
        lstMaterialsList.Items.Add("Teflon")

        txtInputA.Clear()
        txtInputDeltaL.Clear()
        txtInputLKnot.Clear()
        lblDisplayResults.Text = String.Empty
        lstMaterialsList.SelectedIndex = 0

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblInputA, dblInputLKnot, dblInputDeltaL, dblForceMagnitude As Double
        Dim intIndexOfListBox As Integer
        Dim dblArrayYoungModulus() As Double = {6.9, 9.0, 11.0, 0.37, 21.0, 0.037}

        dblInputA = CDbl(txtInputA.Text)
        dblInputLKnot = CDbl(txtInputLKnot.Text)
        dblInputDeltaL = CDbl(txtInputDeltaL.Text)

        If dblInputA < 0.01 Or dblInputA > 0.2 Then
            MsgBox("0.01 <= A <= 0.2")
            Exit Sub
        End If

        If dblInputLKnot < 10 Or dblInputLKnot > 20 Then
            MsgBox("10 <= L knot <= 20")
            Exit Sub
        End If

        If dblInputDeltaL <= 0 Or dblInputDeltaL > (1.5 * 10 ^ -3) Then
            MsgBox("0 < delta L <= 1.5 * 10^-3")
            Exit Sub
        End If


        Try

            intIndexOfListBox = lstMaterialsList.SelectedIndex

            dblForceMagnitude = (dblArrayYoungModulus(intIndexOfListBox) * 10 ^ 10) * (dblInputDeltaL / dblInputLKnot) * dblInputA
            lblDisplayResults.Text = "Input Values: " & (dblInputA).ToString("e3") & " m^2," & Space(5) & (dblInputLKnot).ToString("e3") & " m," & Space(5) & (dblInputDeltaL).ToString("e3") & " m," & Space(5) & "Material: " & lstMaterialsList.SelectedItem
            lblDisplayResults.Text &= vbCr & "Magnitude of Force: " & (dblForceMagnitude).ToString("e3") & " N"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInputA.Clear()
        txtInputDeltaL.Clear()
        txtInputLKnot.Clear()
        lblDisplayResults.Text = String.Empty
        lstMaterialsList.SelectedIndex = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
