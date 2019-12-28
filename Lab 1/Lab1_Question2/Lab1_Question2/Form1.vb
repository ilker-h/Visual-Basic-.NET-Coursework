Public Class Form1

    Dim lngMass As Long
    Dim lngSpeed As Long
    Dim lngPathRadius As Long
    Dim lngCharge As Long
    Dim lngCalculate As Long



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInputInstructions.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblMass.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblCharge.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInputMass.TextChanged

        lngMass = CLng(txtInputMass.Text)
        lblDisplayMass.Text = lngMass.ToString("e5")


    End Sub

    Private Sub txtInputSpeed_TextChanged(sender As Object, e As EventArgs) Handles txtInputSpeed.TextChanged
        lngSpeed = CLng(txtInputSpeed.Text)
        lblDisplaySpeed.Text = lngSpeed.ToString("e5")



    End Sub

    Private Sub txtInputRadius_TextChanged(sender As Object, e As EventArgs) Handles txtInputPathRadius.TextChanged
        lngPathRadius = CLng(txtInputPathRadius.Text)
        lblDisplayPathRadius.Text = lngPathRadius.ToString("n5")



    End Sub

    Private Sub txtInputCharge_TextChanged(sender As Object, e As EventArgs) Handles txtInputCharge.TextChanged
        lngCharge = CLng(txtInputCharge.Text)
        lblDisplayCharge.Text = lngCharge.ToString("e5")

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        lngCalculate = (lngMass * lngSpeed / lngPathRadius / lngCharge)

        lblResult.Text = "Result = " & lngCalculate.ToString("n3")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

