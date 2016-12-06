' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   JennaRae Burich 12/05/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
            Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged,
            radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = GetNewMeasCenti(dblMeasurement, dblResult)
        ElseIf radFuncInches.Checked Then
            dblResult = GetNewMeasInches(dblMeasurement, dblResult)
        End If

        lblResult.Text = dblResult.ToString("n2")

    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function GetNewMeasCenti(ByVal dblMeas As Double, ByRef dblRes As Double) As Double
        Return dblMeas * 2.54
    End Function
    Private Function GetNewMeasInches(ByVal dblMeas As Double, ByRef dblRes As Double) As Double
        Return dblMeas / 2.54
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add planets to cboPlanets
        'set selected item to earth

        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"

    End Sub

    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        'Only allow numbers and the backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        'Select all text in txtEarthWeight
        txtEarthWeight.SelectAll()
    End Sub

    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double
        'Set dblGravity according to the selected text in cboPlanets
        'Calculate and return weight
        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Mars"
                dblGravity = 0.38
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        Return intWeight * dblGravity

    End Function

    Private Sub CalcweightSub(ByVal intWeight As Integer, ByRef dblWeightOnPlanet As Double)
        'Set dblGravity according to selected text in cboPlanets
        'calculate weight
        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Mars"
                dblGravity = 0.38
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        dblWeightOnPlanet = intWeight * dblGravity

    End Sub

    Private Sub WeightInputChanged(sender As Object, e As EventArgs) Handles txtEarthWeight.TextChanged, cboPlanets.SelectedIndexChanged, radPlanetFunc.CheckedChanged, radPlanetSub.CheckedChanged
        'parse value in txtEarthWeight
        'If user selected "sub" radio button
        '   Use Sub to calculate weight
        'Elseif user selected "func" radio button
        '   Use Function to calculate weight
        'End If
        'Display Weight

        Dim dblGravity As Double = 0.0
        Dim intWeight As Integer = 0
        Dim dblWeightOnPlanet As Double

        Integer.TryParse(txtEarthWeight.Text, intWeight)

        If radPlanetSub.Checked Then
            CalcweightSub(intWeight, dblWeightOnPlanet)
        ElseIf radPlanetFunc.Checked Then
            dblWeightOnPlanet = CalcWeightFunc(intWeight)
        End If

        lblPlanetWeight.Text = dblWeightOnPlanet.ToString("n2")

    End Sub
End Class