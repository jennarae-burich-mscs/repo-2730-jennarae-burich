' Name:         EX 2E #14 and #18
' Purpose:      Determine if customers get free shipping, commissions 
' Programmer:   JennaRae Burich on 10/26/2016

Public Class frmMain

    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim intShipChg As Integer
        Dim decOrder As Decimal
        Dim strYN As String

        Double.TryParse(txtOrder.Text, decOrder)
        strYN = txtYN.Text

        If strYN.ToUpper = "Y" AndAlso decOrder >= 100 Then
            intShipChg = 0
        Else intShipChg = 9
        End If

        lblShipChg.Text = intShipChg.ToString("n2")

    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim intShipChg As Integer
        Dim decOrder As Decimal
        Dim strYN As String


        Double.TryParse(txtOrder.Text, decOrder)
        strYN = txtYN.Text

        If strYN.ToUpper <> "Y" OrElse decOrder < 100 Then
            intShipChg = 9
        Else intShipChg = 0
        End If

        lblShipChg.Text = intShipChg.ToString("n2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtOrder_Enter(sender As Object, e As EventArgs) Handles txtOrder.Enter, txtYN.Enter
        lblShipChg.Text = String.Empty
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim strID As String
        Dim decSales As Decimal
        Dim intComm As Integer

        Double.TryParse(txtSales.Text, decSales)
        strID = txtID.Text

        If strID.ToUpper = "A1" Or
        strID.ToUpper = "B2" Or
        strID.ToUpper = "C3" Then
            intComm = decSales * 0.15
        Else
            intComm = decSales * 0.12
        End If

        lblComm.Text = intComm.ToString("n2")
    End Sub

    Private Sub btnGL_Click(sender As Object, e As EventArgs) Handles btnGL.Click
        Dim strID As String
        Dim decSales As Decimal
        Dim intComm As Integer

        Double.TryParse(txtSales.Text, decSales)
        strID = txtID.Text

        If (decSales >= 25000) And
        (strID.ToUpper = "A1" Or
        strID.ToUpper = "B2" Or
        strID.ToUpper = "C3") Then
            intComm = decSales * 0.15
        Else
            intComm = decSales * 0.12
        End If

        lblComm.Text = intComm.ToString("n2")


    End Sub
End Class
