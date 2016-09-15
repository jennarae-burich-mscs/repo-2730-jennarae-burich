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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblAvgScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(258, 33)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 35)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(258, 87)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(258, 139)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(119, 45)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(100, 27)
        Me.txtScore1.TabIndex = 1
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(119, 94)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 27)
        Me.txtScore2.TabIndex = 3
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(119, 143)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 27)
        Me.txtScore3.TabIndex = 5
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Location = New System.Drawing.Point(25, 48)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(88, 20)
        Me.lblScore1.TabIndex = 0
        Me.lblScore1.Text = "Test Score &1"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Location = New System.Drawing.Point(25, 97)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(88, 20)
        Me.lblScore2.TabIndex = 2
        Me.lblScore2.Text = "Test Score &2"
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Location = New System.Drawing.Point(25, 146)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(88, 20)
        Me.lblScore3.TabIndex = 4
        Me.lblScore3.Text = "Test Score &3"
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Location = New System.Drawing.Point(25, 203)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(138, 20)
        Me.lblAvg.TabIndex = 9
        Me.lblAvg.Text = "Average Test Score:"
        '
        'lblAvgScore
        '
        Me.lblAvgScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgScore.Location = New System.Drawing.Point(169, 200)
        Me.lblAvgScore.Name = "lblAvgScore"
        Me.lblAvgScore.Size = New System.Drawing.Size(100, 27)
        Me.lblAvgScore.TabIndex = 10
        Me.lblAvgScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 264)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "jburich1G Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblAvgScore As Label
End Class
