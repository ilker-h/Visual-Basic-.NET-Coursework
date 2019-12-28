Public Class Form1          'Ilker Hadzhalaran

    Dim intCounter As Integer
    Dim strResults As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intCounter As Integer = 1 To 12 Step 1
            cboMultiplicationTable.Items.Add(intCounter)
        Next

        chkShowAnswers.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblResults.Text = String.Empty
        chkShowAnswers.Checked = False
        cboMultiplicationTable.SelectedIndex = 0

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click



        intCounter = 1



        If chkShowAnswers.Checked Then

            strResults = String.Empty
            lblResults.Text = String.Empty

            Do
                strResults &= intCounter.ToString & " x " & (cboMultiplicationTable.SelectedItem).ToString & " = " & (intCounter * cboMultiplicationTable.SelectedItem).ToString & vbCr
                lblResults.Text = strResults
                intCounter = intCounter + 1

            Loop While (intCounter <= 12)

        Else

            strResults = String.Empty
            lblResults.Text = String.Empty

            Do
                strResults &= intCounter.ToString & " x " & (cboMultiplicationTable.SelectedItem).ToString & " = " & vbCr
                lblResults.Text = strResults
                intCounter = intCounter + 1


            Loop While (intCounter <= 12)

        End If


    End Sub





End Class
