Imports System.IO
Public Class Form1 'Ilker Hadzhalaran


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplayResults.Items.Clear()
        lstDisplayResults.Items.Add("Side A:     Side B:     Side C:     Perimeter:     Area:")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstDisplayResults.Items.Add("Side A:     Side B:     Side C:     Perimeter:     Area:")
    End Sub



    Private Sub btnTriangles_Click(sender As Object, e As EventArgs) Handles btnTriangles.Click

        Dim dblA, dblB, dblC, dblHalfPerimeter, dblPerimeter, dblArea As Double
        Dim rand As New Random()
        Randomize()
        Dim outFile As StreamWriter
        Dim inputFile As StreamReader
        Dim dblReadA, dblReadB, dblReadC As Double

        outFile = File.AppendText("C:\Users\Ilker\Desktop\100_Triangles.txt")


        For intCounter As Integer = 1 To 100 Step 1

            getTriangleSides(dblA, dblB, dblC)

            outFile.WriteLine(dblA)
            outFile.WriteLine(dblB)
            outFile.WriteLine(dblC)

        Next intCounter

        outFile.Close()

        inputFile = File.OpenText("C:\Users\Ilker\Desktop\100_Triangles.txt")

        Do Until inputFile.EndOfStream

            dblReadA = CDbl(inputFile.ReadLine())
            dblReadB = CDbl(inputFile.ReadLine())
            dblReadC = CDbl(inputFile.ReadLine())

            getProperties(dblA, dblB, dblC, dblPerimeter, dblHalfPerimeter, dblArea)

            If dblArea >= 20 And dblArea <= 25 Then
                lstDisplayResults.Items.Add(dblA.ToString("n1") & "            " & dblB.ToString("n1") & "            " & dblC.ToString("n1") & "             " & dblPerimeter.ToString("n1") & "             " & dblArea.ToString("n1"))

            End If

        Loop

        inputFile.Close()


    End Sub



    Private Sub getTriangleSides(ByRef dblA As Double, ByRef dblB As Double, ByRef dblC As Double)

        Do Until (((dblA + dblB) > dblC) And ((dblB + dblC) > dblA) And ((dblA + dblC) > dblB))

            Dim rand As New Random()
            Randomize()

            dblA = rand.Next(10)
            dblB = rand.Next(10)
            dblC = rand.Next(10)
        Loop

    End Sub



    Private Sub getProperties(ByVal dblA As Double, ByVal dblB As Double, ByVal dblC As Double, ByRef dblPerimeter As Double, ByRef dblHalfPerimeter As Double, ByRef dblArea As Double)

        dblPerimeter = dblA + dblB + dblC
        dblHalfPerimeter = dblPerimeter / 2

        dblArea = (dblHalfPerimeter * (dblHalfPerimeter - dblA) * (dblHalfPerimeter - dblB) * (dblHalfPerimeter - dblC)) ^ 0.5



    End Sub


End Class
