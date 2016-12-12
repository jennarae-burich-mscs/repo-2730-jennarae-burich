'Name:          jennaburich3e1
'Purpose:       Display counts of salespeople commissions
'Programmer:    JennaRae Burich on 12/10/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private intCommissions() As Integer = {300, 500, 200, 150, 600, 750, 900, 150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
        cboSearchValues.SelectedIndex = 0
        cboSearchRanges.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommissions()
        Dim intHighCommission As Integer = intCommissions.GetUpperBound(0)
        Dim intSub As Integer

        For intSub = 0 To intHighCommission
            lblCommissions.Text &= intCommissions(intSub).ToString & ", "
        Next

        If lblCommissions.Text.EndsWith(", ") Then
            lblCommissions.Text = lblCommissions.Text.Substring(0, lblCommissions.Text.Length - 2)
        End If

    End Sub

    Private Sub cboSearchValues_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValues.TextChanged

        Dim intSearchValue As Integer
        Dim intHighSearchValue As Integer = intCommissions.GetUpperBound(0)
        'Dim intSub As Integer

        Integer.TryParse(cboSearchValues.Text, intSearchValue)

        If intSearchValue > 0 AndAlso intSearchValue < 1000 Then
            lblValCount.Text = CountValue(intSearchValue).ToString
        Else
            MessageBox.Show("Enter a number between 1 and 1000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer
        Dim intNewCount As Integer
        Dim intCommText As Integer
        Dim intTotal As Integer
        Dim intCommHigh As Integer = intCommissions.GetUpperBound(0)

        Integer.TryParse(cboSearchValues.Text, intCommText)

        For Each intComm As Integer In intCommissions
            If intComm = intSearchValue Then
                intTotal += 1
            Else
                intTotal += 0
            End If
        Next intComm

        intNewCount = intTotal

        Return intNewCount

    End Function


    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intTotal As Integer
        Dim intNewCount As Integer

        For Each intComm As Integer In intCommissions
            If intComm >= intSearchMin AndAlso intComm <= intSearchMax Then
                intTotal += 1
            Else
                intTotal += 0
            End If
        Next intComm

        intNewCount = intTotal

        Return intNewCount

    End Function

    Private Sub cboSearchValues_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSearchValues.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboSearchRanges_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If
    End Sub
End Class
