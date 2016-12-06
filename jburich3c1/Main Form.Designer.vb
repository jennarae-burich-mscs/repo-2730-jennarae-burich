<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radSubCentimeters = New System.Windows.Forms.RadioButton()
        Me.radSubInches = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radFuncInches = New System.Windows.Forms.RadioButton()
        Me.radFuncCentimeters = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboPlanets = New System.Windows.Forms.ComboBox()
        Me.lblPlanetWeight = New System.Windows.Forms.Label()
        Me.txtEarthWeight = New System.Windows.Forms.TextBox()
        Me.radPlanetSub = New System.Windows.Forms.RadioButton()
        Me.radPlanetFunc = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radSubCentimeters
        '
        Me.radSubCentimeters.Checked = True
        Me.radSubCentimeters.Location = New System.Drawing.Point(154, 37)
        Me.radSubCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubCentimeters.Name = "radSubCentimeters"
        Me.radSubCentimeters.Size = New System.Drawing.Size(208, 26)
        Me.radSubCentimeters.TabIndex = 2
        Me.radSubCentimeters.TabStop = True
        Me.radSubCentimeters.Text = "Sub: Inches to &Centimeters"
        '
        'radSubInches
        '
        Me.radSubInches.Location = New System.Drawing.Point(154, 71)
        Me.radSubInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubInches.Name = "radSubInches"
        Me.radSubInches.Size = New System.Drawing.Size(208, 26)
        Me.radSubInches.TabIndex = 3
        Me.radSubInches.Text = "Sub: Centimeters to &Inches"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Measurement:"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(19, 60)
        Me.txtMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(55, 27)
        Me.txtMeasurement.TabIndex = 1
        Me.txtMeasurement.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(19, 136)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(81, 30)
        Me.lblResult.TabIndex = 7
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(170, 393)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        '
        'radFuncInches
        '
        Me.radFuncInches.Location = New System.Drawing.Point(154, 139)
        Me.radFuncInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncInches.Name = "radFuncInches"
        Me.radFuncInches.Size = New System.Drawing.Size(208, 26)
        Me.radFuncInches.TabIndex = 9
        Me.radFuncInches.Text = "Func: Centimeters to &Inches"
        '
        'radFuncCentimeters
        '
        Me.radFuncCentimeters.Location = New System.Drawing.Point(154, 105)
        Me.radFuncCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncCentimeters.Name = "radFuncCentimeters"
        Me.radFuncCentimeters.Size = New System.Drawing.Size(208, 26)
        Me.radFuncCentimeters.TabIndex = 8
        Me.radFuncCentimeters.Text = "Func: Inches to &Centimeters"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.radFuncInches)
        Me.GroupBox1.Controls.Add(Me.radSubCentimeters)
        Me.GroupBox1.Controls.Add(Me.radFuncCentimeters)
        Me.GroupBox1.Controls.Add(Me.radSubInches)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 216)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p418 #15-16 Measurement Converter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboPlanets)
        Me.GroupBox2.Controls.Add(Me.lblPlanetWeight)
        Me.GroupBox2.Controls.Add(Me.txtEarthWeight)
        Me.GroupBox2.Controls.Add(Me.radPlanetSub)
        Me.GroupBox2.Controls.Add(Me.radPlanetFunc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 153)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p426-427 #4-6 Weight on other planets"
        '
        'cboPlanets
        '
        Me.cboPlanets.FormattingEnabled = True
        Me.cboPlanets.Location = New System.Drawing.Point(126, 62)
        Me.cboPlanets.Name = "cboPlanets"
        Me.cboPlanets.Size = New System.Drawing.Size(121, 28)
        Me.cboPlanets.TabIndex = 14
        '
        'lblPlanetWeight
        '
        Me.lblPlanetWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlanetWeight.Location = New System.Drawing.Point(126, 96)
        Me.lblPlanetWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlanetWeight.Name = "lblPlanetWeight"
        Me.lblPlanetWeight.Size = New System.Drawing.Size(81, 30)
        Me.lblPlanetWeight.TabIndex = 13
        Me.lblPlanetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEarthWeight
        '
        Me.txtEarthWeight.Location = New System.Drawing.Point(11, 62)
        Me.txtEarthWeight.Name = "txtEarthWeight"
        Me.txtEarthWeight.Size = New System.Drawing.Size(100, 27)
        Me.txtEarthWeight.TabIndex = 12
        Me.txtEarthWeight.Text = "100"
        '
        'radPlanetSub
        '
        Me.radPlanetSub.Checked = True
        Me.radPlanetSub.Location = New System.Drawing.Point(268, 62)
        Me.radPlanetSub.Margin = New System.Windows.Forms.Padding(2)
        Me.radPlanetSub.Name = "radPlanetSub"
        Me.radPlanetSub.Size = New System.Drawing.Size(108, 26)
        Me.radPlanetSub.TabIndex = 10
        Me.radPlanetSub.TabStop = True
        Me.radPlanetSub.Text = "Sub"
        '
        'radPlanetFunc
        '
        Me.radPlanetFunc.Location = New System.Drawing.Point(268, 96)
        Me.radPlanetFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.radPlanetFunc.Name = "radPlanetFunc"
        Me.radPlanetFunc.Size = New System.Drawing.Size(108, 26)
        Me.radPlanetFunc.TabIndex = 11
        Me.radPlanetFunc.Text = "Function"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Calculate using:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Weight on:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Earth weight:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jburich 3c1 Measurement Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radSubCentimeters As System.Windows.Forms.RadioButton
    Friend WithEvents radSubInches As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radFuncInches As RadioButton
    Friend WithEvents radFuncCentimeters As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPlanetWeight As Label
    Friend WithEvents txtEarthWeight As TextBox
    Friend WithEvents radPlanetSub As RadioButton
    Friend WithEvents radPlanetFunc As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboPlanets As ComboBox
End Class
