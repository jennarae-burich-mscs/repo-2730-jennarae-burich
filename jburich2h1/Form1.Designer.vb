<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMoreThan10 = New System.Windows.Forms.CheckBox()
        Me.chkTravel = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCommOnly = New System.Windows.Forms.Label()
        Me.lblAddAmt = New System.Windows.Forms.Label()
        Me.lblTotalComm = New System.Windows.Forms.Label()
        Me.btnIfThen = New System.Windows.Forms.Button()
        Me.btnNestedIf = New System.Windows.Forms.Button()
        Me.btnIfElseIf = New System.Windows.Forms.Button()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(22, 30)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales"
        '
        'chkMoreThan10
        '
        Me.chkMoreThan10.AutoSize = True
        Me.chkMoreThan10.Location = New System.Drawing.Point(22, 57)
        Me.chkMoreThan10.Name = "chkMoreThan10"
        Me.chkMoreThan10.Size = New System.Drawing.Size(74, 17)
        Me.chkMoreThan10.TabIndex = 2
        Me.chkMoreThan10.Text = ">10 Years"
        Me.chkMoreThan10.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.AutoSize = True
        Me.chkTravel.Location = New System.Drawing.Point(22, 81)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(72, 17)
        Me.chkTravel.TabIndex = 3
        Me.chkTravel.Text = "Travelling"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Commission only:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Additional Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Commission:"
        '
        'lblCommOnly
        '
        Me.lblCommOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommOnly.Location = New System.Drawing.Point(25, 122)
        Me.lblCommOnly.Name = "lblCommOnly"
        Me.lblCommOnly.Size = New System.Drawing.Size(100, 23)
        Me.lblCommOnly.TabIndex = 7
        '
        'lblAddAmt
        '
        Me.lblAddAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddAmt.Location = New System.Drawing.Point(25, 175)
        Me.lblAddAmt.Name = "lblAddAmt"
        Me.lblAddAmt.Size = New System.Drawing.Size(100, 23)
        Me.lblAddAmt.TabIndex = 8
        '
        'lblTotalComm
        '
        Me.lblTotalComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalComm.Location = New System.Drawing.Point(25, 231)
        Me.lblTotalComm.Name = "lblTotalComm"
        Me.lblTotalComm.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalComm.TabIndex = 9
        '
        'btnIfThen
        '
        Me.btnIfThen.Location = New System.Drawing.Point(161, 30)
        Me.btnIfThen.Name = "btnIfThen"
        Me.btnIfThen.Size = New System.Drawing.Size(75, 23)
        Me.btnIfThen.TabIndex = 10
        Me.btnIfThen.Text = "If Then"
        Me.btnIfThen.UseVisualStyleBackColor = True
        '
        'btnNestedIf
        '
        Me.btnNestedIf.Location = New System.Drawing.Point(161, 60)
        Me.btnNestedIf.Name = "btnNestedIf"
        Me.btnNestedIf.Size = New System.Drawing.Size(75, 23)
        Me.btnNestedIf.TabIndex = 11
        Me.btnNestedIf.Text = "Nested If"
        Me.btnNestedIf.UseVisualStyleBackColor = True
        '
        'btnIfElseIf
        '
        Me.btnIfElseIf.Location = New System.Drawing.Point(161, 90)
        Me.btnIfElseIf.Name = "btnIfElseIf"
        Me.btnIfElseIf.Size = New System.Drawing.Size(75, 23)
        Me.btnIfElseIf.TabIndex = 12
        Me.btnIfElseIf.Text = "If ElseIf"
        Me.btnIfElseIf.UseVisualStyleBackColor = True
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(161, 120)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectCase.TabIndex = 13
        Me.btnSelectCase.Text = "Select Case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(161, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 224)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission calcumations"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(103, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 39)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "$500" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$700"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 65)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Additional amounts:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "> 10 Years" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Travelling"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 65)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "10% of sales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$120 + 13% of sales >6,000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$3,120 + 14% of sales >30,000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 65)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "1 - 5,999.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6,000-29,999.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "> 30,000"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(152, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Commission"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(20, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sales ($)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 277)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectCase)
        Me.Controls.Add(Me.btnIfElseIf)
        Me.Controls.Add(Me.btnNestedIf)
        Me.Controls.Add(Me.btnIfThen)
        Me.Controls.Add(Me.lblTotalComm)
        Me.Controls.Add(Me.lblAddAmt)
        Me.Controls.Add(Me.lblCommOnly)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkTravel)
        Me.Controls.Add(Me.chkMoreThan10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSales)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jburich2h1 Marshall Sales"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMoreThan10 As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCommOnly As Label
    Friend WithEvents lblAddAmt As Label
    Friend WithEvents lblTotalComm As Label
    Friend WithEvents btnIfThen As Button
    Friend WithEvents btnNestedIf As Button
    Friend WithEvents btnIfElseIf As Button
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
