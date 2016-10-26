' Name:         Ch4 Lesson B, If statements, message boxes
' Purpose:      Currency, Tea, Electric, Quotient
' Programmer:   JennaRae Burich on 10/25/2016


Option Explicit On
Option Strict On
Option Infer Off


' NUMBER 1 

Public Class frmMain
    Private Sub btnConvertEq_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        ' convert American dollars to the Euro, the British pound, and the South African rand

        Const dblEURO_RATE As Double = 0.92
        Const dblPOUND_RATE As Double = 0.82
        Const dblRAND_RATE As Double = 13.76
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American Dollars.", "Currency Converter",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAmDollar)
            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE
        End If

        lblEuro.Text = dblEuro.ToString("c2")
        lblPound.Text = dblPound.ToString("C2")
        lblRand.Text = dblRand.ToString("C2")
    End Sub

    Private Sub btnConvertLG_Click(sender As Object, e As EventArgs) Handles btnConvertLG.Click
        Const dblEURO_RATE As Double = 0.92
        Const dblPOUND_RATE As Double = 0.82
        Const dblRAND_RATE As Double = 13.76
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text <> String.Empty Then
            Double.TryParse(txtAmDollar.Text, dblAmDollar)
            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE
        Else
            MessageBox.Show("Please enter the number of American Dollars.", "Currency Converter",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End If

        lblEuro.Text = dblEuro.ToString("c2")
        lblPound.Text = dblPound.ToString("C2")
        lblRand.Text = dblRand.ToString("C2")
    End Sub

    Private Sub txtAmDollar_Enter(sender As Object, e As EventArgs) Handles txtAmDollar.Enter
        txtAmDollar.SelectAll()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtAmDollar.TextChanged
        ' clear calculated amounts

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty
    End Sub

    ' NUMBER 3

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click

        Dim dblOrder As Double
        Dim dblPrice As Double
        Dim dblTeaTotal As Double
        Dim dlgButton As DialogResult
        dlgButton =
            MessageBox.Show("Charge $15 for shipping?", "Tea Time Company",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Exclamation)
        If dlgButton = DialogResult.Yes Then
            Double.TryParse(txtOrder.Text, dblOrder)
            Double.TryParse(txtPrice.Text, dblPrice)
            dblTeaTotal = dblPrice * dblOrder + 15
        Else
            dlgButton = DialogResult.No
            Double.TryParse(txtOrder.Text, dblOrder)
            Double.TryParse(txtPrice.Text, dblPrice)
            dblTeaTotal = dblPrice * dblOrder
        End If

        lblTeaTotal.Text = dblTeaTotal.ToString("C2")

    End Sub

    Private Sub txtOrder_Enter(sender As Object, e As EventArgs) Handles txtOrder.Enter, txtPrice.Enter
        lblTeaTotal.Text = String.Empty
    End Sub

    ' NUMBER 4

    Private Sub btnCaclElec_Click(sender As Object, e As EventArgs) Handles btnCaclElec.Click

        Const dblELECRATE As Double = 0.13
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblBill As Double

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)

        If txtCurrent.Text = String.Empty Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading", "Triple County Electric",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation)
        ElseIf txtPrevious.Text = String.Empty Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading", "Triple County Electric",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation)
        ElseIf dblPrevious > dblCurrent Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading", "Triple County Electric",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
        Else
            dblBill = (dblCurrent - dblPrevious) * dblELECRATE
        End If

        lblBill.Text = dblBill.ToString("C2")
        txtCurrent.Text = dblCurrent.ToString
        txtPrevious.Text = dblPrevious.ToString

    End Sub


    ' NUMBER 5

    Private Sub btnCalcDiv_Click(sender As Object, e As EventArgs) Handles btnCalcDiv.Click
        Dim decFirstNum As Decimal
        Dim decSecNum As Decimal
        Dim dblQuot As Double

        Decimal.TryParse(txtFirstNum.Text, decFirstNum)
        Decimal.TryParse(txtSecNum.Text, decSecNum)

        If txtFirstNum.Text = "0" Then
            MessageBox.Show("Cannot divide by zero", "Dividing Application",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation)

        ElseIf txtSecNum.Text = "0" Then
            MessageBox.Show("Cannot divide by zero", "Dividing Application",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation)

        ElseIf decFirstNum < decSecNum Then
            Dim decTemp As Decimal
            decTemp = decSecNum
            decSecNum = decFirstNum
            decFirstNum = decTemp

            dblQuot = decTemp / decSecNum

        Else dblQuot = decFirstNum / decSecNum

        End If

        lblQuot.Text = dblQuot.ToString("n2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
