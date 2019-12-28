Imports System.IO
Public Class Form1   'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFindValue_Click(sender As Object, e As EventArgs) Handles btnFindValue.Click

        Dim inputFile As StreamReader
        Dim outFile As StreamWriter
        Dim strFileReader(2) As String
        Dim dblPressure As Double = 0
        Dim dblTemperature As Double = 0
        Dim dblVolume As Double = 0
        Dim strPropertyName As String
        Const dblMOLE_NUMBER As Double = 1000
        Const dblR_CONSTANT As Double = 8.314

        inputFile = File.OpenText("C:\Users\Ilker\Desktop\idealGas.txt")

        If Not File.Exists("C:\Users\Ilker\Desktop\idealGas.txt") Then

            MsgBox("File does not exist.")
            Exit Sub
        End If


        Do Until inputFile.EndOfStream
            strFileReader = Split(inputFile.ReadLine(), " ")
            strPropertyName = strFileReader(0)

            If strPropertyName = "Pressure" Then
                dblPressure = CDbl(strFileReader(1))

            ElseIf strPropertyName = "Temperature" Then
                dblTemperature = CDbl(strFileReader(1))
            ElseIf strPropertyName = "Volume" Then
                dblVolume = CDbl(strFileReader(1))

            End If


        Loop

        inputFile.Close()

        outFile = File.AppendText("C:\Users\Ilker\Desktop\idealGas.txt")

        If dblPressure = 0 Then
            dblPressure = dblMOLE_NUMBER * dblR_CONSTANT * dblTemperature / dblVolume

            lblDisplayResults.Text &= "Unknown Pressure is: " & dblPressure.ToString("f2") & " Pa" & vbCr

            lblDisplayResults.Text &= "R constant is: " & dblR_CONSTANT.ToString("f2") & " Jk^-1*mol^-1" & vbCr
            lblDisplayResults.Text &= "Number of Moles is: " & dblMOLE_NUMBER.ToString("f2") & " mol" & vbCr
            lblDisplayResults.Text &= "Temperature is: " & dblTemperature.ToString("f2") & " K" & vbCr
            lblDisplayResults.Text &= "Volume is: " & dblVolume.ToString("f2") & " m^3" & vbCr

            outFile.WriteLine("")
            outFile.WriteLine("Pressure " & dblPressure.ToString("f2") & " Pa")

        ElseIf dblTemperature = 0 Then
            dblTemperature = dblPressure * dblVolume / dblMOLE_NUMBER / dblR_CONSTANT

            lblDisplayResults.Text &= "Unknown Temperature is: " & dblTemperature.ToString("f2") & " K" & vbCr

            lblDisplayResults.Text &= "R constant is: " & dblR_CONSTANT.ToString("f2") & " Jk^-1*mol^-1" & vbCr
            lblDisplayResults.Text &= "Number of Moles is: " & dblMOLE_NUMBER.ToString("f2") & " mol" & vbCr
            lblDisplayResults.Text &= "Pressure is: " & dblPressure.ToString("f2") & " Pa" & vbCr
            lblDisplayResults.Text &= "Volume is: " & dblVolume.ToString("f2") & " m^3" & vbCr

            outFile.WriteLine("")
            outFile.WriteLine("Temperature " & dblTemperature.ToString("f2") & " K")

        ElseIf dblVolume = 0 Then
            dblVolume = dblMOLE_NUMBER * dblR_CONSTANT * dblTemperature / dblPressure

            lblDisplayResults.Text &= "Unknown Volume is: " & dblVolume.ToString("f2") & " m^3" & vbCr

            lblDisplayResults.Text &= "R constant is: " & dblR_CONSTANT.ToString("f2") & " Jk^-1*mol^-1" & vbCr
            lblDisplayResults.Text &= "Number of Moles is: " & dblMOLE_NUMBER.ToString("f2") & " mol" & vbCr
            lblDisplayResults.Text &= "Temperature is: " & dblTemperature.ToString("f2") & " K" & vbCr
            lblDisplayResults.Text &= "Pressure is: " & dblPressure.ToString("f2") & " Pa" & vbCr

            outFile.WriteLine("")
            outFile.WriteLine("Volume " & dblVolume.ToString("f2") & " m^3")

        End If

        outFile.Close()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplayResults.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
