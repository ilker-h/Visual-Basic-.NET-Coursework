Public Class Form1   ' Ilker Hadzhalaran

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkShowAll.Checked = False
        radRed.Checked = True
        radYellow.Checked = False

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strItemName As String
        Dim intQuantity As Integer
        Dim dblPostedPrice As Double
        Dim dblSubtotal As Double
        Dim dblTotalAmount As Double

        If Not Integer.TryParse(txtQuantity.Text, intQuantity) Then
            MsgBox("Please enter quantity as an integer number.")

        ElseIf Not Double.TryParse(txtPostedPrice.Text, dblPostedPrice) Then
            MsgBox("Please enter the posted price as a number.")

        End If

        strItemName = txtItemName.Text
        intQuantity = CInt(txtQuantity.Text)
        dblPostedPrice = CDbl(txtPostedPrice.Text)

        dblSubtotal = price(strItemName, intQuantity, dblPostedPrice)

        dblTotalAmount = dblSubtotal * 1.13


        If chkShowAll.Checked Then
            lblShowAll.Text = "Subtotal: " & dblSubtotal.ToString("c") & ", HST: " & (dblSubtotal * 0.13).ToString("c") & ", Total Amount: " & dblTotalAmount.ToString("c")

        End If

        lstItems.Items.Add("Item Name: " & strItemName)
        lstItems.Items.Add("Quantity: " & intQuantity.ToString("f0"))
        lstItems.Items.Add("Posted Price: " & dblPostedPrice.ToString("c"))
        lstItems.Items.Add("Total Amount: " & dblTotalAmount.ToString("c"))

        txtItemName.Text = String.Empty
        txtPostedPrice.Text = String.Empty
        txtQuantity.Text = String.Empty

    End Sub


    Private Function price(ByVal strItemName As String, ByVal intQuantity As Integer, dblPostedPrice As Double)
        Dim dblSubtotal As Double


        If radRed.Checked Then


            If intQuantity = 1 Then
                dblSubtotal = intQuantity * dblPostedPrice * 0.8

            ElseIf intQuantity = 2 Then
                dblSubtotal = intQuantity * dblPostedPrice * 0.7

            ElseIf intQuantity = 3 Then
                dblSubtotal = intQuantity * dblPostedPrice * 0.6

            Else
                dblSubtotal = intQuantity * dblPostedPrice

            End If


        ElseIf radYellow.Checked Then


            If intQuantity = 2 Then
                dblSubtotal = intQuantity * dblPostedPrice * 0.9

            ElseIf intQuantity > 2 Then
                dblSubtotal = intQuantity * dblPostedPrice * 0.85
            Else
                dblSubtotal = intQuantity * dblPostedPrice

            End If

        End If

        Return dblSubtotal

    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemName.Text = String.Empty
        txtPostedPrice.Text = String.Empty
        txtQuantity.Text = String.Empty
        radRed.Checked = True
        chkShowAll.Checked = False
        lstItems.Items.Clear()
        lblShowAll.Text = String.Empty

    End Sub
End Class
