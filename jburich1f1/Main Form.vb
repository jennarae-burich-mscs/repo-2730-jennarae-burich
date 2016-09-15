' Name:         Cranston Berries Project
' Purpose:      Calculates projected sales
' Programmer:   JennaRae Burich on 9/12/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblProjRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
