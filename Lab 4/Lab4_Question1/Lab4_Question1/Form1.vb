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

        For intCounter As Integer = 1 To 5 Step 1

            getProperties(dblA, dblB, dblC, dblPerimeter, dblHalfPerimeter, dblArea)
            lstDisplayResults.Items.Add(dblA.ToString("n1") & "            " & dblB.ToString("n1") & "            " & dblC.ToString("n1") & "             " & dblPerimeter.ToString("n1") & "             " & dblArea.ToString("n1"))

        Next intCounter

    End Sub



    Private Sub getTriangleSides(ByRef dblA As Double, ByRef dblB As Double, ByRef dblC As Double)
        
        dblA = 0
        dblB = 0
        dblC = 0

        Do Until ((dblA + dblB > dblC) And (dblB + dblC > dblA) And (dblA + dblC > dblB))
           
            Static Dim rand As New Random() 'initialize it as a static variable, so the same one does not keep being saved
            Randomize()
            
            dblA = rand.Next(10)
            dblB = rand.Next(10)
            dblC = rand.Next(10)

        Loop

    End Sub



    Private Sub getProperties(ByRef dblA As Double, ByRef dblB As Double, ByRef dblC As Double, ByRef dblPerimeter As Double, ByRef dblHalfPerimeter As Double, ByRef dblArea As Double)

        getTriangleSides(dblA, dblB, dblC)

        dblPerimeter = dblA + dblB + dblC
        dblHalfPerimeter = dblPerimeter / 2

        dblArea = (dblHalfPerimeter * (dblHalfPerimeter - dblA) * (dblHalfPerimeter - dblB) * (dblHalfPerimeter - dblC)) ^ 0.5

    End Sub


End Class

