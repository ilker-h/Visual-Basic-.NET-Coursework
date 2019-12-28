Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEarth.Click

        lblGravityMeters.Text = 9.81 & " m/s^2"
        lblGravityFeet.Text = 32.19 & " m/s^2"

        lblGravityMeters.TextAlign = ContentAlignment.MiddleLeft
        lblGravityFeet.TextAlign = ContentAlignment.BottomLeft

        lblGravityMeters.ForeColor = Color.Blue
        lblGravityFeet.ForeColor = Color.Red

        lblGravityMeters.BackColor = Color.Yellow
        lblGravityFeet.BackColor = Color.Cyan

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblGravityMeters.Click

    End Sub


    Private Sub btnMercury_Click(sender As Object, e As EventArgs) Handles btnMercury.Click

        lblGravityMeters.Text = 3.61 & " m/s^2"
        lblGravityFeet.Text = 11.84 & " m/s^2"

        lblGravityMeters.TextAlign = ContentAlignment.MiddleRight
        lblGravityFeet.TextAlign = ContentAlignment.TopRight

        lblGravityMeters.ForeColor = Color.Red
        lblGravityFeet.ForeColor = Color.Blue

        lblGravityMeters.BackColor = Color.Cyan
        lblGravityFeet.BackColor = Color.Yellow

    End Sub

    Private Sub btnMars_Click(sender As Object, e As EventArgs) Handles btnMars.Click

        lblGravityMeters.Text = 3.75 & " m/s^2"
        lblGravityFeet.Text = 12.3 & " m/s^2"

        lblGravityMeters.TextAlign = ContentAlignment.MiddleCenter
        lblGravityFeet.TextAlign = ContentAlignment.BottomRight

        lblGravityMeters.ForeColor = Color.Green
        lblGravityFeet.ForeColor = Color.Yellow

        lblGravityMeters.BackColor = Color.Yellow
        lblGravityFeet.BackColor = Color.Green

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
