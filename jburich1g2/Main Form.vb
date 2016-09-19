' Name:         Average Test Score Calculator
' Purpose:      Calculates average test score
' Programmer:   JennaRae Burich on 9/14/2016

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
        lblAvgScore.Text = String.Empty
        txtScore1.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblAvgScore.Text = Format((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3, "standard")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class