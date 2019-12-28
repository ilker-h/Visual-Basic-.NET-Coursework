Public Class Form1   'Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click


        Dim g As Graphics = picDrawing.CreateGraphics()
        Dim Pen As New Pen(Color.Yellow)
        Dim Brush As New SolidBrush(Color.Yellow)

        Static intClickCounter = 0
        intClickCounter += 1
        btnClick.Text = "Keep clicking..."


        Select Case intClickCounter
            Case 1
                Pen.Color = Color.LightYellow
                g.DrawEllipse(Pen, 90, 90, 90, 90)
                Brush.Color = Color.Yellow
                g.FillEllipse(Brush, 90, 90, 90, 90)

            Case 2

                Pen.Color = Color.Brown
                g.DrawRectangle(Pen, 70, 300, 90, 90)
                Brush.Color = Color.Brown
                g.FillRectangle(Brush, 70, 300, 90, 90)

            Case 3

                Brush.Color = Color.Red
                Dim A As New Point(115, 250)
                Dim B As New Point(68, 300)
                Dim C As New Point(162, 300)
                Dim triangle As Point() = {A, B, C}
                Pen.Width = 4
                Pen.Color = Color.Red
                g.DrawPolygon(Pen, triangle)
                Brush.Color = Color.Red
                g.FillPolygon(Brush, triangle)

            Case 4

                Brush.Color = Color.Cyan
                g.FillRectangle(Brush, 120, 330, 20, 20)

            Case 5
                Brush.Color = Color.Salmon
                g.FillRectangle(Brush, 80, 351, 20, 40)



            Case 6
                Brush.Color = Color.Brown
                g.FillRectangle(Brush, 305, 270, 30, 120)


            Case 7

                Pen.Color = Color.Green

                For intTreeLeaves As Integer = 250 To 300 Step 1
                    g.DrawArc(Pen, intTreeLeaves, 270, 90, 90, 180, 180)

                Next intTreeLeaves

        End Select




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
