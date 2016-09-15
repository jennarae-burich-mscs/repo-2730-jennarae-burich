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
        Me.lblAvgScore = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAvgScore
        '
        Me.lblAvgScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgScore.Location = New System.Drawing.Point(165, 185)
        Me.lblAvgScore.Name = "lblAvgScore"
        Me.lblAvgScore.Size = New System.Drawing.Size(100, 27)
        Me.lblAvgScore.TabIndex = 21
        Me.lblAvgScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Location = New System.Drawing.Point(21, 188)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(123, 17)
        Me.lblAvg.TabIndex = 20
        Me.lblAvg.Text = "Average Test Score:"
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Location = New System.Drawing.Point(21, 131)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(79, 17)
        Me.lblScore3.TabIndex = 15
        Me.lblScore3.Text = "Test Score &3"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Location = New System.Drawing.Point(21, 82)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(79, 17)
        Me.lblScore2.TabIndex = 13
        Me.lblScore2.Text = "Test Score &2"
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Location = New System.Drawing.Point(21, 33)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(79, 17)
        Me.lblScore1.TabIndex = 11
        Me.lblScore1.Text = "Test Score &1"
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(115, 128)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 25)
        Me.txtScore3.TabIndex = 16
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(115, 79)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 25)
        Me.txtScore2.TabIndex = 14
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(115, 30)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(100, 25)
        Me.txtScore1.TabIndex = 12
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 124)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(254, 72)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(254, 18)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 35)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 240)
        Me.Controls.Add(Me.lblAvgScore)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jburich1g: Average Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAvgScore As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
End Class
