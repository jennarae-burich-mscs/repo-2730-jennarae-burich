' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   JennaRae Burich on 11/29/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop

        count = 1
        Do
            product = number * count
            lstMultTable.Items.Add("    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString())
            count += 1
        Loop Until count = 10

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop

        count = 1

        For intcount As Integer = 1 To 9 Step 1
            count = intcount
            product = number * count
            lstMultTable.Items.Add("    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString())
        Next intcount

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const dblTAXRATE As Double = 0.05

        ' fill the list box from 1-4

        For dblPrices As Double = 1 To 4 Step 1
            lstPrices.Items.Add(dblPrices.ToString("n2"))
        Next dblPrices


        ' calculate pretax total:
        Dim dblPretaxTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        lstPrices.SelectedIndex = 0


        For index As Integer = 0 To lstPrices.Items.Count - 1

            lstPrices.SelectedIndex = index

            strSelectedItem = lstPrices.SelectedItem.ToString
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPretaxTotal = dblSelectedPrice + dblPretaxTotal

            lblPretax.Text = dblPretaxTotal.ToString("n2")

        Next index

        dblTax = dblPretaxTotal * dblTAXRATE
        lblTax.Text = dblTax.ToString("n2")

        dblTotal = dblTax + dblPretaxTotal
        lblTotal.Text = dblTotal.ToString("n2")

        lstPrices.SelectedIndex = -1


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strPrice As String
        Dim dblPrice As Double
        Const dblTAXRATE As Double = 0.05
        Dim dblPretaxTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        Const strPROMPT As String =
             "Enter a number between 1.00 and 9.99 " &
             ControlChars.NewLine &
             "Click Cancel or leave blank to end."

        Const strTITLE As String = "Number Entry"

        strPrice = InputBox(strPROMPT, strTITLE, "0")

        Double.TryParse(strPrice, dblPrice)

        If dblPrice >= 1 AndAlso dblPrice <= 9.99 Then
            lstPrices.Items.Add(dblPrice.ToString("n2"))


        Else
            Const strPROMPTS As String =
             "Enter a number between 1.00 and 9.99 " &
             ControlChars.NewLine &
             "Click Cancel or leave blank to end."

            Const strTITLES As String = "Invalid Number"

            strPrice = InputBox(strPROMPTS, strTITLES, "0")

        End If

        For index As Integer = 0 To lstPrices.Items.Count - 1

            lstPrices.SelectedIndex = index

            strSelectedItem = lstPrices.SelectedItem.ToString
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPretaxTotal = dblSelectedPrice + dblPretaxTotal

            lblPretax.Text = dblPretaxTotal.ToString("n2")

        Next

        dblTax = dblPretaxTotal * dblTAXRATE
        lblTax.Text = dblTax.ToString("n2")

        dblTotal = dblTax + dblPretaxTotal
        lblTotal.Text = dblTotal.ToString("n2")

        lstPrices.SelectedIndex = -1


    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        Dim dblPretaxTotal As Double = 0
        Dim dblTax As Double
        Dim dblTotal As Double
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Const dblTAXRATE As Double = 0.05

        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)

            lstPrices.SelectedIndex = 0

            For index As Integer = 0 To lstPrices.Items.Count - 1

                lstPrices.SelectedIndex = index

                strSelectedItem = lstPrices.SelectedItem.ToString
                Double.TryParse(strSelectedItem, dblSelectedPrice)
                dblPretaxTotal = dblSelectedPrice + dblPretaxTotal

                lblPretax.Text = dblPretaxTotal.ToString("n2")

            Next index

            dblTax = dblPretaxTotal * dblTAXRATE
            lblTax.Text = dblTax.ToString("n2")

            dblTotal = dblTax + dblPretaxTotal
            lblTotal.Text = dblTotal.ToString("n2")

            lstPrices.SelectedIndex = -1
        End If

    End Sub
End Class
