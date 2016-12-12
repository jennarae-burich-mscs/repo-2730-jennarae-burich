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
        Me.cboSearchValues = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblValCount = New System.Windows.Forms.Label()
        Me.lblRangeCount = New System.Windows.Forms.Label()
        Me.lblCommissions = New System.Windows.Forms.Label()
        Me.cboSearchRanges = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboSearchValues
        '
        Me.cboSearchValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchValues.FormattingEnabled = True
        Me.cboSearchValues.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboSearchValues.Location = New System.Drawing.Point(116, 118)
        Me.cboSearchValues.Name = "cboSearchValues"
        Me.cboSearchValues.Size = New System.Drawing.Size(121, 111)
        Me.cboSearchValues.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Commission values:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search for value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Search for range:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Count:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Count:"
        '
        'lblValCount
        '
        Me.lblValCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValCount.Location = New System.Drawing.Point(307, 117)
        Me.lblValCount.Name = "lblValCount"
        Me.lblValCount.Size = New System.Drawing.Size(100, 23)
        Me.lblValCount.TabIndex = 6
        '
        'lblRangeCount
        '
        Me.lblRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeCount.Location = New System.Drawing.Point(307, 241)
        Me.lblRangeCount.Name = "lblRangeCount"
        Me.lblRangeCount.Size = New System.Drawing.Size(100, 23)
        Me.lblRangeCount.TabIndex = 7
        '
        'lblCommissions
        '
        Me.lblCommissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissions.Location = New System.Drawing.Point(127, 40)
        Me.lblCommissions.Name = "lblCommissions"
        Me.lblCommissions.Size = New System.Drawing.Size(280, 54)
        Me.lblCommissions.TabIndex = 8
        '
        'cboSearchRanges
        '
        Me.cboSearchRanges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchRanges.FormattingEnabled = True
        Me.cboSearchRanges.Items.AddRange(New Object() {"    0 - 200", "100 - 300", "700 - 800"})
        Me.cboSearchRanges.Location = New System.Drawing.Point(116, 242)
        Me.cboSearchRanges.Name = "cboSearchRanges"
        Me.cboSearchRanges.Size = New System.Drawing.Size(121, 98)
        Me.cboSearchRanges.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 349)
        Me.Controls.Add(Me.cboSearchRanges)
        Me.Controls.Add(Me.lblCommissions)
        Me.Controls.Add(Me.lblRangeCount)
        Me.Controls.Add(Me.lblValCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSearchValues)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jburich 3e1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSearchValues As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblValCount As Label
    Friend WithEvents lblRangeCount As Label
    Friend WithEvents lblCommissions As Label
    Friend WithEvents cboSearchRanges As ComboBox
End Class
