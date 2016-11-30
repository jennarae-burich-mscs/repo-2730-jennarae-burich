Public Class Form1
    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        lblEven.text = "Preset Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        lblEven.Text = "Preset Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
        lblEven.Text = "Preset Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop While i <= 20
    End Sub

    Private Sub btnLoopUntil_Click(sender As Object, e As EventArgs) Handles btnLoopUntil.Click
        lblEven.Text = "Preset Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop Until i > 20
    End Sub

    Private Sub btnPretestFor_Click(sender As Object, e As EventArgs) Handles btnPretestFor.Click
        lblEven.Text = "Preset For" & ControlChars.NewLine
        For i As Integer = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i

    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        lblList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."

        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        strNum = InputBox(strPROMPT, strTITLE, "0")


        Do While strNum > "0"

            Int32.TryParse(strNum, intNum)

            lblList.Text = lblList.Text &
            intNum.ToString & ControlChars.NewLine

            intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPROMPT, strTITLE, "0")
        Loop

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        lblList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."

        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        strNum = InputBox(strPROMPT, strTITLE, "0")


        Do

            Int32.TryParse(strNum, intNum)

            lblList.Text = lblList.Text &
            intNum.ToString & ControlChars.NewLine

            intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPROMPT, strTITLE, "0")
        Loop Until strNum <= "0"

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        lblList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."

        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        Dim intInput As Integer
        Dim strInputCount As String = InputBox("Enter the quanity", "Quanity", "0")
        Integer.TryParse(strInputCount, intInput)

        strNum = InputBox(strPROMPT, strTITLE, "0")

        For i As Integer = 1 To intInput

            Int32.TryParse(strNum, intNum)

            lblList.Text = lblList.Text &
            intNum.ToString & ControlChars.NewLine

            intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPROMPT, strTITLE, "0")
        Next

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
