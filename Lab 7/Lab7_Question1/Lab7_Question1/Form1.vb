Imports System.IO

Public Class Form1 'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim outFile As StreamWriter

        outFile = File.CreateText("C:\Users\Ilker\Desktop\Materials_And_Y.txt")
        outFile.WriteLine("Aluminum" & "," & 6.9)
        outFile.WriteLine("Brass" & "," & 9.0)
        outFile.WriteLine("Copper" & "," & 11.0)
        outFile.WriteLine("Nylon" & "," & 0.37)
        outFile.WriteLine("Steel" & "," & 21.0)
        outFile.WriteLine("Teflon" & "," & 0.037)

        txtInputA.Clear()
        txtInputDeltaL.Clear()
        txtInputLKnot.Clear()
        lblDisplayResults.Text = String.Empty


        outFile.Close()

        Dim inputFile As StreamReader
        Dim Array(1) As String
        Dim dblArray(5) As Double
        Dim strMaterialName As String

        inputFile = File.OpenText("C:\Users\Ilker\Desktop\Materials_And_Y.txt")

        For intCounter As Integer = 0 To 5 Step 1

            Array = Split(inputFile.ReadLine(), ",")
         
            strMaterialName = Array(0)
            lstMaterialsList.Items.Add(strMaterialName)


        Next intCounter

        inputFile.Close()

        lstMaterialsList.SelectedIndex = 0


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblInputA, dblInputLKnot, dblInputDeltaL, dblForceMagnitude As Double
        Dim intIndexOfListBox As Integer
        Dim dblArrayYoungModulus(5) As Double
        Dim strReadArray(1) As String
        Dim dblYoungMod As Double
        Dim strMaterialName As String

        Dim inputFile As StreamReader
        inputFile = File.OpenText("C:\Users\Ilker\Desktop\Materials_And_Y.txt")

        For intCounter As Integer = 0 To 5 Step 1
            '    
            strReadArray = Split(inputFile.ReadLine(), ",")
         
            strMaterialName = strReadArray(0)
            dblYoungMod = CDbl(strReadArray(1))

            lstMaterialsList.Items.Add(strMaterialName)

            dblArrayYoungModulus(intCounter) = dblYoungMod


        Next intCounter

        inputFile.Close()


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
