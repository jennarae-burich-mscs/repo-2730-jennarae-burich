' Name:         Photo Workshop Payroll
' Purpose:      Calculates payroll taxes
' Programmer:   JennaRae Burich on 9/18/2016

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHours.Text = String.Empty
        txtName.Text = String.Empty
        txtRate.Text = String.Empty
        lblCalcFICA.Text = String.Empty
        lblCalcFWT.Text = String.Empty
        lblCalcGross.Text = String.Empty
        lblCalcNet.Text = String.Empty
        lblCalcState.Text = String.Empty
        txtName.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblCalcGross.Text = Format(Val(txtHours.Text) * Val(txtRate.Text), "fixed")
        lblCalcFWT.Text = Format(Val(lblCalcGross.Text) * 0.2, "fixed")
        lblCalcFICA.Text = Format(Val(lblCalcGross.Text) * 0.08, "fixed")
        lblCalcState.Text = Format(Val(lblCalcGross.Text) * 0.03, "fixed")
        lblCalcNet.Text = Format(Val(lblCalcGross.Text) - (Val(lblCalcFWT.Text) + Val(lblCalcFICA.Text) + Val(lblCalcState.Text)), "fixed")
    End Sub
End Class