Imports System.IO
Public Class Form1   'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rad1DArray.Checked = True
        lblDisplayResults.Text = String.Empty
        Dim outFile As StreamWriter

        outFile = File.CreateText("C:\Users\Ilker\Desktop\Data.txt")

        outFile.WriteLine("10   5")
        outFile.WriteLine("15   20")
        outFile.WriteLine("20   18")
        outFile.WriteLine("25   40")
        outFile.WriteLine("40   33")
        outFile.WriteLine("50   54")
        outFile.WriteLine("55   70")
        outFile.WriteLine("60   60")
        outFile.WriteLine("75   78")

        outFile.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rad1DArray.Checked = True
        lblDisplayResults.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEstimate_Click(sender As Object, e As EventArgs) Handles btnEstimate.Click

        Dim dblCalculateM, dblCalculateB, dblCalculateAverageT, dblCalculateAverageS, dblCalculateS As Double
        Dim dblTimeEntered As Double
        Const intNUMBER_TERMS As Integer = 9

        lblDisplayResults.Text = String.Empty

        dblTimeEntered = getTime()

        If dblTimeEntered < 10 Or dblTimeEntered > 75 Then
            MsgBox("Time was either less than 10min or more than 75min")
            Exit Sub
        End If


        If rad1DArray.Checked = True Then

            Dim dblTime() As Double = {10, 15, 20, 25, 40, 50, 55, 60, 75}
            Dim dblStrength() As Double = {5, 20, 18, 40, 33, 54, 70, 60, 78}
            Tensile_1D(dblTimeEntered, intNUMBER_TERMS, dblTime, dblStrength, dblCalculateM, dblCalculateB, dblCalculateAverageT, dblCalculateAverageS, dblCalculateS)

            printValues(dblCalculateM, dblCalculateB, dblTimeEntered, dblCalculateS)

        ElseIf rad2DArray.Checked = True Then

            Dim dblTimeAndStrength(,) As Double = {{10, 15, 20, 25, 40, 50, 55, 60, 75}, {5, 20, 18, 40, 33, 54, 70, 60, 78}}

            Tensile_2D(dblTimeEntered, intNUMBER_TERMS, dblTimeAndStrength, dblCalculateM, dblCalculateB, dblCalculateAverageT, dblCalculateAverageS, dblCalculateS)

            printValues(dblCalculateM, dblCalculateB, dblTimeEntered, dblCalculateS)

        ElseIf radFunction.Checked = True Then

            Const intARRAY_ROWS As Integer = 2
            Const intARRAY_COLUMNS As Integer = 9
            Dim dblTimeAndStrength(intARRAY_ROWS - 1, intARRAY_COLUMNS - 1) As Double

            userEnteredArray(dblTimeAndStrength, intARRAY_ROWS, intARRAY_COLUMNS)

            Tensile_2D(dblTimeEntered, intNUMBER_TERMS, dblTimeAndStrength, dblCalculateM, dblCalculateB, dblCalculateAverageT, dblCalculateAverageS, dblCalculateS)

            printValues(dblCalculateM, dblCalculateB, dblTimeEntered, dblCalculateS)

        ElseIf radTextFile.Checked = True Then

            If Not File.Exists("C:\Users\Ilker\Desktop\Data.txt") Then
                MsgBox("Data file does not exist.")
                Exit Sub
            End If

            Dim dblTimeAndStrength(1, 8) As Double
            Dim inputFile As StreamReader
            Dim dblTimeDataPoint, dblStrengthDataPoint As Double
            Dim strDataReader(1) As String
            Dim intCounter As Integer = -1
            inputFile = File.OpenText("C:\Users\Ilker\Desktop\Data.txt")

            Do Until inputFile.EndOfStream

                strDataReader = Split(inputFile.ReadLine(), "   ")

                intCounter += 1
                dblTimeAndStrength(0, intCounter) = CDbl(strDataReader(0))
                dblTimeAndStrength(1, intCounter) = CDbl(strDataReader(1))

            Loop

            inputFile.Close()

            Tensile_2D(dblTimeEntered, intNUMBER_TERMS, dblTimeAndStrength, dblCalculateM, dblCalculateB, dblCalculateAverageT, dblCalculateAverageS, dblCalculateS)

            printValues(dblCalculateM, dblCalculateB, dblTimeEntered, dblCalculateS)

        End If


    End Sub


    Private Function getTime() As Double

        Dim dblTimeEntered As Double

        dblTimeEntered = CInt(InputBox("Enter any time between 10-75min"))

        Return dblTimeEntered


    End Function

    Private Sub Tensile_1D(ByVal dblTimeEntered As Double, ByVal intNUMBER_TERMS As Integer, ByVal dblTime() As Double, ByVal dblStrength() As Double, ByRef dblCalculateM As Double, ByRef dblCalculateB As Double, ByRef dblCalculateAverageT As Double, ByRef dblCalculateAverageS As Double, ByRef dblCalculateS As Double)

        Dim dblTermTS, dblTermT, dblTermS, dblTermTSquared As Double

        For intCounter As Integer = 0 To intNUMBER_TERMS - 1 Step 1

            dblTermTS += dblTime(intCounter) * dblStrength(intCounter)
            dblTermT += dblTime(intCounter)
            dblTermS += dblStrength(intCounter)
            dblTermTSquared += (dblTime(intCounter)) ^ 2

        Next intCounter

        dblCalculateM = (intNUMBER_TERMS * dblTermTS - dblTermT * dblTermS) / (intNUMBER_TERMS * dblTermTSquared - dblTermT ^ 2)
        dblCalculateAverageT = dblTermT / intNUMBER_TERMS
        dblCalculateAverageS = dblTermS / intNUMBER_TERMS
        dblCalculateB = dblCalculateAverageS - dblCalculateM * dblCalculateAverageT
        dblCalculateS = dblCalculateM * dblTimeEntered + dblCalculateB

    End Sub

    Private Sub Tensile_2D(ByVal dblTimeEntered As Double, ByVal intNUMBER_TERMS As Integer, ByVal dblTimeAndStrength(,) As Double, ByRef dblCalculateM As Double, ByRef dblCalculateB As Double, ByRef dblCalculateAverageT As Double, ByRef dblCalculateAverageS As Double, ByRef dblCalculateS As Double)

        Dim dblTermTS, dblTermT, dblTermS, dblTermTSquared As Double

        For intCounter As Integer = 0 To intNUMBER_TERMS - 1 Step 1

            dblTermTS += dblTimeAndStrength(0, intCounter) * dblTimeAndStrength(1, intCounter)
            dblTermT += dblTimeAndStrength(0, intCounter)
            dblTermS += dblTimeAndStrength(1, intCounter)
            dblTermTSquared += dblTimeAndStrength(0, intCounter) ^ 2

        Next intCounter

        dblCalculateM = (intNUMBER_TERMS * dblTermTS - dblTermT * dblTermS) / (intNUMBER_TERMS * dblTermTSquared - dblTermT ^ 2)
        dblCalculateAverageT = dblTermT / intNUMBER_TERMS
        dblCalculateAverageS = dblTermS / intNUMBER_TERMS
        dblCalculateB = dblCalculateAverageS - dblCalculateM * dblCalculateAverageT
        dblCalculateS = dblCalculateM * dblTimeEntered + dblCalculateB

    End Sub

    Private Function userEnteredArray(ByRef dblTimeAndStrength(,) As Double, ByVal intARRAY_ROWS As Integer, ByVal intARRAY_COLUMNS As Integer) As Array

        For intCounter As Integer = 0 To intARRAY_ROWS - 1 Step 1

            If intCounter = 0 Then

                For intCounter2 As Integer = 0 To intARRAY_COLUMNS - 1 Step 1
                    dblTimeAndStrength(intCounter, intCounter2) = CDbl(InputBox("Enter time for datapoint #" & CStr(intCounter2 + 1)))

                Next intCounter2

            ElseIf intCounter = 1 Then

                For intCounter2 As Integer = 0 To intARRAY_COLUMNS - 1 Step 1
                    dblTimeAndStrength(intCounter, intCounter2) = CDbl(InputBox("Enter tensile strength for datapoint #" & CStr(intCounter2 + 1)))

                Next intCounter2

            End If

        Next intCounter

        Return dblTimeAndStrength


    End Function


    Private Sub printValues(ByVal dblCalculateM As Double, ByVal dblCalculateB As Double, ByVal dblTimeEntered As Double, ByVal dblCalculateS As Double)
        lblDisplayResults.Text &= "m = " & dblCalculateM.ToString("f3") & ", b = " & dblCalculateB.ToString("f3") & vbCr
        lblDisplayResults.Text &= "t = " & dblTimeEntered.ToString("f1") & " min, " & "Estimated Tensile Strength = " & dblCalculateS.ToString("f1") & " s"
    End Sub


End Class
