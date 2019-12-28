Imports System.IO

Public Class Form1   'Ilker Hadzhalaran

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserInput.Clear()
        lblDisplayResult.Text = String.Empty
        txtAddAddress.Clear()
        txtAddName.Clear()
        lstAddressBook.Items.Clear()
        lstSearchResults.Items.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Dim strName, strAddress, strPhoneNumber As String
        Dim intIndividualNumber As Integer
        Dim blnPhoneNumberIsValid As Boolean = True
        Dim strReadContact As String
        Dim strSearchQuery As String

        Dim outFile As StreamWriter
        outFile = File.AppendText("C:\Users\Ilker\Desktop\Address_Book.txt")

        strName = txtAddName.Text
        strAddress = txtAddAddress.Text
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
            Exit Sub
        End If


        outFile.WriteLine(strName & "," & strAddress & "," & strPhoneNumber)
        outFile.Close()

        Dim inputFile As StreamReader
        inputFile = File.OpenText("C:\Users\Ilker\Desktop\Address_Book.txt")

        strSearchQuery = InputBox("Search for a name: ")

        Do Until inputFile.EndOfStream
            strReadContact = inputFile.ReadLine()
            lstAddressBook.Items.Add(strReadContact)

            If (strReadContact.ToUpper()).IndexOf(strSearchQuery.ToUpper()) Then
                lstSearchResults.Items.Add(strReadContact)
            End If

        Loop

        inputFile.Close()
    End Sub
End Class
