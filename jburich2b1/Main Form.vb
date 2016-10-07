' Name:         Cranston Berries Project
' Purpose:      Calculates projected sales
' Programmer:   JennaRae Burich on 10/05/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intStraw As Integer
        Dim intBlue As Integer
        Dim intRasp As Integer
        Dim decProjIncrease As Decimal
        Dim decProjStraw As Decimal
        Dim decProjBlue As Decimal
        Dim decProjRasp As Decimal


        Integer.TryParse(txtStraw.Text, intStraw)
        Integer.TryParse(txtBlue.Text, intBlue)
        Integer.TryParse(txtRasp.Text, intRasp)
        Decimal.TryParse(txtProjIncrease.Text, decProjIncrease)

        decProjStraw = intStraw * (decProjIncrease + 1)
        decProjBlue = intBlue * (decProjIncrease + 1)
        decProjRasp = intRasp * (decProjIncrease + 1)

        lblProjStraw.Text = decProjStraw.ToString("C2")
        lblProjBlue.Text = decProjBlue.ToString("C2")
        lblProjRasp.Text = decProjRasp.ToString("C2")


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

    Private Sub btnRetirement_Click(sender As Object, e As EventArgs) Handles btnRetirement.Click
        frmRetirement.Show()
    End Sub
End Class
