Public Class Form1     'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInputProductCode.Clear()

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        Dim strProductCode As String
        Dim blnAllValid As Boolean = True


        lblDisplayResults.Text = String.Empty

        strProductCode = CStr(txtInputProductCode.Text)

        If Not (strProductCode.Length >= 7 And strProductCode.Length <= 12) Then

            lblDisplayResults.Text &= "-Error: Product Code must be minimum 7 or maximum 12 characters" & vbCr

            blnAllValid = False

        End If



        If strProductCode.Substring(0, 1).ToUpper() <> "A" And strProductCode.Substring(0, 1).ToUpper() <> "M" And strProductCode.Substring(0, 1).ToUpper() <> "P" Then

            lblDisplayResults.Text &= "-Error: Product Code's first character must be A, M or P, either lower or upper case." & vbCr
            blnAllValid = False

        End If


        If Not IsNumeric(strProductCode.Substring(1)) Then

            lblDisplayResults.Text &= "-Error: All of the Product Code's characters other than the first one must be numeric (0 to 9)" & vbCr
            blnAllValid = False

        End If

        If blnAllValid = True Then
            lblDisplayResults.Text = "The Product Code is Valid."
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInputProductCode.Clear()
        lblDisplayResults.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
