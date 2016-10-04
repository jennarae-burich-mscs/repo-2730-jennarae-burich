' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   JennaRae Burich on 10/02/2016

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain

    ' Private strClerk As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        Const strPROMPT As String = "Salesclerk's Name:"
        Const strTITLE As String = "Name Entry"
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTAXRATE As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubTotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)

        intTotalItems = intDonuts + intMuffins

        decSubTotal = intTotalItems * decITEM_PRICE

        decSalesTax = decSubTotal * decTAXRATE

        decTotalSales = decSubTotal + decSalesTax

        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        lblMsg.Text = "The sales tax was " & decSalesTax.ToString("C2") & ". " & ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Const strPROMPT As String = "Salesclerk's Name:"
        ' Const strTITLE As String = "Name Entry"

        ' strClerk = InputBox(strPROMPT, strTITLE)
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
            Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
    End Sub
End Class
