' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   JennaRae Burich on 11/15/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)

        Select Case itemNum.Substring(3, 1).ToUpper
            Case "B"
                lstColors.Items.Add(itemNum & ": Blue")
            Case "G"
                lstColors.Items.Add(itemNum & ": Green")
            Case "R"
                lstColors.Items.Add(itemNum & ": Red")
            Case "W"
                lstColors.Items.Add(itemNum & ": White")
            Case Else
                lstColors.Items.Add("Invalid:" & itemNum)
        End Select

        If itemNum.Length <> 7 Then
            lstColors.Items.Add("Invalid Code")
        End If

    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)

        Dim strDelivery As String = partNum.Substring(2).ToUpper

        Select Case strDelivery
            Case "MS"
                lstDelivery.Items.Add("Mail - Standard")
            Case "MP"
                lstDelivery.Items.Add("Mail - Priority")
            Case "FS"
                lstDelivery.Items.Add("FedEx - Standard")
            Case "FO"
                lstDelivery.Items.Add("FedEx - Overnight")
            Case "U"
                lstDelivery.Items.Add("UPS")
            Case Else
                lstDelivery.Items.Add("Invalid: " & partNum)
        End Select
    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name
    ' if no last name, write second if code so it doesn't blow up

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click

        'BELOW IS SWITCHING, NOT WHAT YOU'RE TRYING TO DO
        'lblName.Text = strLastName & ", " & strFirstName

        Dim strName As String
        Dim strFirstName As String
        Dim strLowerFirstName As String
        Dim strLastName As String
        Dim strLowerLastName As String
        Dim strPropFirstName As String
        Dim strPropLastName As String
        Dim intIndex As Integer

        strName = txtName.Text.ToLower.Trim
        intIndex = strName.IndexOf(" ")

        If intIndex <> -1 Then
            strFirstName = strName.Substring(0, intIndex)
            strLastName = strName.Substring(intIndex + 1)

            strLowerFirstName = strFirstName.Remove(0, 1)
            strLowerLastName = strLastName.Remove(0, 1)
            strPropFirstName = strFirstName.ToUpper.Remove(1)
            strPropLastName = strLastName.ToUpper.Remove(1)

            lblName.Text = strPropFirstName & strLowerFirstName & " " & strPropLastName & strLowerLastName

        Else
            strFirstName = strName
            strLowerFirstName = strFirstName.Remove(0, 1)
            strPropFirstName = strFirstName.ToUpper.Remove(1)

            lblName.Text = strPropFirstName & strLowerFirstName
        End If

    End Sub

End Class
