' Programmer:   JennaRae Burich on 11/15/2016

Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '04: SubString
        Dim strItem As String = txt04.Text
        Dim strColor As String = txt04.Text
        strColor = strItem.Substring(2, 4)
        lbl04Substring.Text = strColor

        '05a: Length
        Dim strLength As String = txt05a.Text
        Dim intNumChars As Integer
        intNumChars = strLength.Length
        lbl05aLength.Text = intNumChars.ToString

        '05b: Trim
        Dim strPlace As String = txt05b.Text
        strPlace = txt05b.Text.Trim
        lbl05bTrim.Text = strPlace

        '05c: Remove/Insert
        Dim strWord5c As String = txt05c.Text
        strWord5c = strWord5c.Remove(1, 1)
        strWord5c = strWord5c.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strWord5c

        '05d: Insert
        Dim strWord5d As String = txt05d.Text
        strWord5d = strWord5d.Insert(0, "Mon")
        lbl05dInsert.Text = strWord5d

        '05e Pad

        Dim decPay As Decimal
        Dim strPayFormatted As String
        Decimal.TryParse(txt05e.Text, decPay)
        strPayFormatted = decPay.ToString("N2")
        strPayFormatted = strPayFormatted.PadLeft(10, "*"c)
        lbl05ePad.Text = strPayFormatted

        '06: Remove
        Dim strNum As String = txt06.Text
        strNum = strNum.Remove(1, 1)
        strNum = strNum.Remove(4, 1)
        lbl06Remove.Text = strNum

        '07: Contains
        Dim strStreet As String = txt07.Text
        Dim strAddress As String = "Jeff St. Found"

        If strStreet.ToUpper.Contains("JEFFERSON STREET") Then
            lbl07Contains.Text = strAddress
        Else
            lbl07Contains.Text = strStreet
        End If

        '12:Len/Remove
        Dim strPercent As String = txt12.Text
        Dim dblTax As Double = 10
        Dim dblPercent As Double
        Dim dblTotal As Double

        If strPercent.Substring(strPercent.Length - 1) = "%" Then
            strPercent = strPercent.Remove(strPercent.Length - 1)
        End If

        Double.TryParse(strPercent, dblPercent)

        dblTotal = dblPercent * dblTax


        lbl12LenRemove.Text = dblTotal.ToString

        '13: Like
        Dim strNum13 As String = txt13.Text
        If strNum13 Like "605##" Then
            lbl13Like.Text = "Shipping is $25"

        ElseIf strNum13 Like "606##" Then
            lbl13Like.Text = "Shipping is $30"

        Else
            lbl13Like.Text = "Invalid Code"
        End If
        'lbl13Like
    End Sub
End Class
