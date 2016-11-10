' Name:         Marshall Sales
' Purpose:      Calculate Commissions
' Programmer:   JennaRae Burich on 11/2/2016

Public Class Form1
    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged

    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
         e.KeyChar <> ControlChars.Back AndAlso
            e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        lblCommOnly.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalComission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalComission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommOnly.Text = dblCommissionOnly.ToString("c2")
            lblAddAmt.Text = dblAdditional.ToString("c2")
            lblTotalComm.Text = dblTotalComission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click
        lblCommOnly.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalComission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        Else
            If dblSales < 6000.0 Then
                dblCommissionOnly = dblSales * 0.1
            Else
                If dblSales < 30000.0 Then
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Else
                    If dblSales >= 30000.0 Then
                        dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
                    End If
                End If
            End If
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        dblTotalComission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommOnly.Text = dblCommissionOnly.ToString("c2")
            lblAddAmt.Text = dblAdditional.ToString("c2")
            lblTotalComm.Text = dblTotalComission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnIfElseIf_Click(sender As Object, e As EventArgs) Handles btnIfElseIf.Click
        lblCommOnly.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalComission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        ElseIf boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        ElseIf boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalComission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommOnly.Text = dblCommissionOnly.ToString("c2")
            lblAddAmt.Text = dblAdditional.ToString("c2")
            lblTotalComm.Text = dblTotalComission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        lblCommOnly.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalComission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Select Case dblSales
            Case < 1
                dblCommissionOnly = 0.0
            Case 1.0 To 6000.0
                dblCommissionOnly = dblSales * 0.1
            Case 6000.0 To 30000.0
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
            Case > 30000.0
                dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End Select

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalComission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommOnly.Text = dblCommissionOnly.ToString("c2")
            lblAddAmt.Text = dblAdditional.ToString("c2")
            lblTotalComm.Text = dblTotalComission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub ClearComission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkMoreThan10.CheckedChanged, chkTravel.CheckedChanged
        lblCommOnly.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotalComm.Text = String.Empty
    End Sub
End Class
