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
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnLoopWhile = New System.Windows.Forms.Button()
        Me.btnLoopUntil = New System.Windows.Forms.Button()
        Me.btnPretestFor = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblList = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(198, 50)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(123, 30)
        Me.btnDoWhile.TabIndex = 1
        Me.btnDoWhile.Text = "Pretest: Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(198, 88)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(123, 30)
        Me.btnDoUntil.TabIndex = 2
        Me.btnDoUntil.Text = "Pretest: Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnLoopWhile
        '
        Me.btnLoopWhile.Location = New System.Drawing.Point(198, 126)
        Me.btnLoopWhile.Name = "btnLoopWhile"
        Me.btnLoopWhile.Size = New System.Drawing.Size(123, 30)
        Me.btnLoopWhile.TabIndex = 3
        Me.btnLoopWhile.Text = "Posttest: Loop While"
        Me.btnLoopWhile.UseVisualStyleBackColor = True
        '
        'btnLoopUntil
        '
        Me.btnLoopUntil.Location = New System.Drawing.Point(198, 164)
        Me.btnLoopUntil.Name = "btnLoopUntil"
        Me.btnLoopUntil.Size = New System.Drawing.Size(123, 30)
        Me.btnLoopUntil.TabIndex = 4
        Me.btnLoopUntil.Text = "Posttest: Loop Until"
        Me.btnLoopUntil.UseVisualStyleBackColor = True
        '
        'btnPretestFor
        '
        Me.btnPretestFor.Location = New System.Drawing.Point(198, 202)
        Me.btnPretestFor.Name = "btnPretestFor"
        Me.btnPretestFor.Size = New System.Drawing.Size(123, 30)
        Me.btnPretestFor.TabIndex = 5
        Me.btnPretestFor.Text = "Pretest: For"
        Me.btnPretestFor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.btnPretestFor)
        Me.GroupBox1.Controls.Add(Me.btnDoWhile)
        Me.GroupBox1.Controls.Add(Me.btnLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnLoopWhile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 262)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 Loop 2-20"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(15, 36)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(155, 210)
        Me.lblEven.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblList)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 262)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332-348 #22 Addition"
        '
        'lblList
        '
        Me.lblList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblList.Location = New System.Drawing.Point(14, 36)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(155, 210)
        Me.lblList.TabIndex = 9
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCount.Location = New System.Drawing.Point(273, 58)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(57, 35)
        Me.lblCount.TabIndex = 8
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAvg.Location = New System.Drawing.Point(201, 58)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(57, 35)
        Me.lblAvg.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Count:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Average:"
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(198, 202)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(123, 30)
        Me.btnSumForNext.TabIndex = 5
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(198, 164)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(123, 30)
        Me.btnSumLoopUntil.TabIndex = 4
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(198, 126)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(123, 30)
        Me.btnSumDoWhile.TabIndex = 3
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 291)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnLoopWhile As Button
    Friend WithEvents btnLoopUntil As Button
    Friend WithEvents btnPretestFor As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents lblList As Label
End Class
