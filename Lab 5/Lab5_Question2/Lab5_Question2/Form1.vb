Public Class Form1   'Ilker Hadzhalaran

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserInput.Clear()
        lblDisplayResult.Text = String.Empty


    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click


        Dim strPhoneNumber
        Dim intIndividualNumber As Integer
        Dim blnPhoneNumberIsValid As Boolean = True

        strPhoneNumber = txtUserInput.Text




        If Not (Integer.TryParse(strPhoneNumber.Substring(1, 1), intIndividualNumber) And 0 < CInt(strPhoneNumber.Substring(1, 1)) <= 9 And CInt(strPhoneNumber.Substring(1, 1)) <> 0) Then

            blnPhoneNumberIsValid = False

        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(2, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(2, 1) <= 9) Then
            blnPhoneNumberIsValid = False
        End If


        If Not (Integer.TryParse(strPhoneNumber.Substring(3, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(3, 1) <= 9) Then
            blnPhoneNumberIsValid = False
        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(6, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(6, 1) <= 9) Then
            blnPhoneNumberIsValid = False

        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(7, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(7, 1) <= 9) Then

            blnPhoneNumberIsValid = False

        End If


        If Not (Integer.TryParse(strPhoneNumber.Substring(8, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(8, 1) <= 9) Then
            blnPhoneNumberIsValid = False

        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(10, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(10, 1) <= 9) Then

            blnPhoneNumberIsValid = False

        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(11, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(11, 1) <= 9) Then
            blnPhoneNumberIsValid = False

        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(12, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(12, 1) <= 9) Then
            blnPhoneNumberIsValid = False

        End If

        If Not (Integer.TryParse(strPhoneNumber.Substring(13, 1), intIndividualNumber) And 0 <= strPhoneNumber.Substring(13, 1) <= 9) Then

            blnPhoneNumberIsValid = False

        End If

        If Not strPhoneNumber.Substring(0, 1) = "(" Then

            blnPhoneNumberIsValid = False

        End If

        If Not strPhoneNumber.Substring(4, 1) = ")" Then

            blnPhoneNumberIsValid = False

        End If

        If Not strPhoneNumber.Substring(5, 1) = " " Then

            blnPhoneNumberIsValid = False

        End If

        If Not strPhoneNumber.Substring(9, 1) = "-" Then

            blnPhoneNumberIsValid = False

        End If


        If blnPhoneNumberIsValid = True Then
            lblDisplayResult.Text = "The phone number is valid"
        Else
            lblDisplayResult.Text = "The phone number is not valid"
        End If


    End Sub
End Class
