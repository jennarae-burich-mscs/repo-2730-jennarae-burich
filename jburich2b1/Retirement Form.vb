Public Class frmRetirement

    ' Name:         Retierment Form
    ' Purpose:      Calculates annual retierment
    '               contributions
    ' Programmer:   JennaRae Burich on 10/06/2016

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decWeeklyPay As Decimal
        Dim decPamContrib As Decimal
        Dim decEmContrib As Decimal
        Dim decPamAnContrib As Decimal
        Dim decEmAnContrib As Decimal
        Dim decTotalAnContrib As Decimal

        Decimal.TryParse(txtWeeklyPay.Text, decWeeklyPay)
        Decimal.TryParse(txtPamContrib.Text, decPamContrib)
        Decimal.TryParse(txtEmContrib.Text, decEmContrib)

        decPamAnContrib = (decWeeklyPay * 52) * decPamContrib
        decEmAnContrib = (decWeeklyPay * 52) * decEmContrib

        decTotalAnContrib = decPamAnContrib + decEmAnContrib

        lblPamAnContrib.Text = decPamAnContrib.ToString("C2")
        lblEmAnContrib.Text = decEmAnContrib.ToString("C2")
        lblTotalAnContrib.Text = decTotalAnContrib.ToString("C2")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPamContrib.Text = String.Empty
        txtEmContrib.Text = String.Empty
        txtWeeklyPay.Text = String.Empty
        lblTotalAnContrib.Text = String.Empty
        lblPamAnContrib.Text = String.Empty
        lblEmAnContrib.Text = String.Empty

        txtWeeklyPay.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class