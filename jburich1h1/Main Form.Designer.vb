<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblCalcGross = New System.Windows.Forms.Label()
        Me.lblCalcFWT = New System.Windows.Forms.Label()
        Me.lblCalcFICA = New System.Windows.Forms.Label()
        Me.lblCalcNet = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCalcState = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(167, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(487, 56)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(106, 20)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "&Hours Worked:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(639, 56)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(86, 20)
        Me.lblRate.TabIndex = 4
        Me.lblRate.Text = "&Rate of Pay:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(198, 81)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(261, 27)
        Me.txtName.TabIndex = 1
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(505, 80)
        Me.txtHours.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(114, 27)
        Me.txtHours.TabIndex = 3
        Me.txtHours.Text = "0.00"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(657, 80)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(114, 27)
        Me.txtRate.TabIndex = 5
        Me.txtRate.Text = "0.00"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(43, 124)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(76, 20)
        Me.lblGross.TabIndex = 9
        Me.lblGross.Text = "Gross pay:"
        '
        'lblFWT
        '
        Me.lblFWT.AutoSize = True
        Me.lblFWT.Location = New System.Drawing.Point(200, 124)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(41, 20)
        Me.lblFWT.TabIndex = 11
        Me.lblFWT.Text = "FWT:"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Location = New System.Drawing.Point(349, 124)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(42, 20)
        Me.lblFICA.TabIndex = 13
        Me.lblFICA.Text = "FICA:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(635, 124)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(62, 20)
        Me.lblNet.TabIndex = 17
        Me.lblNet.Text = "Net Pay:"
        '
        'lblCalcGross
        '
        Me.lblCalcGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcGross.Location = New System.Drawing.Point(66, 149)
        Me.lblCalcGross.Name = "lblCalcGross"
        Me.lblCalcGross.Size = New System.Drawing.Size(114, 29)
        Me.lblCalcGross.TabIndex = 10
        Me.lblCalcGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCalcFWT
        '
        Me.lblCalcFWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcFWT.Location = New System.Drawing.Point(214, 149)
        Me.lblCalcFWT.Name = "lblCalcFWT"
        Me.lblCalcFWT.Size = New System.Drawing.Size(114, 29)
        Me.lblCalcFWT.TabIndex = 12
        Me.lblCalcFWT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCalcFICA
        '
        Me.lblCalcFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcFICA.Location = New System.Drawing.Point(361, 149)
        Me.lblCalcFICA.Name = "lblCalcFICA"
        Me.lblCalcFICA.Size = New System.Drawing.Size(114, 29)
        Me.lblCalcFICA.TabIndex = 14
        Me.lblCalcFICA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCalcNet
        '
        Me.lblCalcNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcNet.Location = New System.Drawing.Point(656, 149)
        Me.lblCalcNet.Name = "lblCalcNet"
        Me.lblCalcNet.Size = New System.Drawing.Size(114, 29)
        Me.lblCalcNet.TabIndex = 18
        Me.lblCalcNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(494, 124)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 20)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State:"
        '
        'lblCalcState
        '
        Me.lblCalcState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcState.Location = New System.Drawing.Point(509, 149)
        Me.lblCalcState.Name = "lblCalcState"
        Me.lblCalcState.Size = New System.Drawing.Size(114, 29)
        Me.lblCalcState.TabIndex = 16
        Me.lblCalcState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.AutoSize = True
        Me.btnCalc.Location = New System.Drawing.Point(276, 220)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(80, 30)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(376, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(471, 220)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 286)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblCalcState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCalcNet)
        Me.Controls.Add(Me.lblCalcFICA)
        Me.Controls.Add(Me.lblCalcFWT)
        Me.Controls.Add(Me.lblCalcGross)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jburich 1h1 Photo Workshop Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblCalcGross As Label
    Friend WithEvents lblCalcFWT As Label
    Friend WithEvents lblCalcFICA As Label
    Friend WithEvents lblCalcNet As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCalcState As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
