' Name:         Bakery Project
' Purpose:      Calculates the total number of items sold and the total sales
' Programmer:   JennaRae Burich on 9/6/2016

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale
        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        txtDonuts.Focus()

        ' send the focus to the Doghnuts box
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        lblTotalItems.Text = Val(txtDonuts.Text) + Val(txtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub
End Class
