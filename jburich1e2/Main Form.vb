' Name:         Richardson County Property Tax Project
' Purpose:      Calculates property taxes
' Programmer:   JennaRae Burich on 9/6/2016

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for next calculation
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        txtAssessed.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub
End Class
