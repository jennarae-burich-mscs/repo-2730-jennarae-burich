'Name:          Exercise 3D: Array subscripts, totals, avg, min
'Purpose:       Display the average number sold
'Programmer:    JennaRae Burich on 12/07/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intSold() As Integer = {250, 225, 193, 260}
    Private dblWholeSale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intMonthNum As Integer
        Dim intResultDays As Integer
        Integer.TryParse(txtMonthNum.Text, intMonthNum)

        If intMonthNum >= 1 AndAlso intMonthNum <= 12 Then
            intResultDays = intDaysInMonth(intMonthNum - 1)
        Else
            MessageBox.Show("Invaild Entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        lblNumDays.Text = intResultDays.ToString
        txtMonthNum.Focus()
        txtMonthNum.SelectAll()
    End Sub


    'x   Clear lables
    '   Use loop to calculate total of elements in intoSold array
    '   Calculate and display avg
    '   Use same loop to find and display intoSold elements
    '       lblLessAvg.Text &- intSold(intSub).ToString & ", "
    '   Remove Extra ", " from lblLessAvg.Text:
    '       If lblLessAvg.Text.EndsWith(", ") Then
    '           lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length -2)
    '       End If


    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim intSub As Integer
        Dim intDivide As Integer
        Dim intTotal As Integer

        For intSub = 0 To intHighSub
            intTotal += intSold(intSub)
        Next intSub

        intDivide = intSold.Length

        intTotal = CInt(intTotal / intDivide)

        lblAvg.Text = intTotal.ToString

        For intSub = 0 To intHighSub
            If intSold(intSub) < intTotal Then
                lblLessAvg.Text &= intSold(intSub).ToString & ", "
            End If
        Next
        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intDivide As Integer
        Dim intTotal As Integer

        For Each intAvgTotal As Integer In intSold
            intTotal += intAvgTotal
        Next intAvgTotal

        intDivide = intSold.Length

        intTotal = CInt(intTotal / intDivide)

        lblAvg.Text = intTotal.ToString

        For Each intAvgTotal As Integer In intSold
            If intAvgTotal < intTotal Then
                lblLessAvg.Text &= intAvgTotal.ToString & ", "
            End If
        Next intAvgTotal

        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim intSub As Integer
        Dim intDivide As Integer
        Dim intTotal As Integer

        Do While intSub <= intHighSub
            intTotal += intSold(intSub)
            intSub += 1
        Loop

        intDivide = intSold.Length

        intTotal = CInt(intTotal / intDivide)

        lblAvg.Text = intTotal.ToString

        For intSub = 0 To intHighSub
            If intSold(intSub) < intTotal Then
                lblLessAvg.Text &= intSold(intSub).ToString & ", "
            End If
        Next


        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        Dim dblMarkup As Double
        Double.TryParse(InputBox("Markup Percentage:", "Markup"), dblMarkup)

        If dblMarkup > 0 Then
            dblMarkup = (dblMarkup / 100) + 1
        End If
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            dblWholeSale(intSub) = dblWholeSale(intSub) * dblMarkup
            lstRetail.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            dblWholeSale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub
End Class
