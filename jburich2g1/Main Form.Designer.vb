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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalcNestIf = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalcIf = New System.Windows.Forms.Button()
        Me.btnCalcIfElseIf = New System.Windows.Forms.Button()
        Me.btnCalcSelect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(39, 176)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(87, 27)
        Me.txtPrice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(137, 176)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(87, 27)
        Me.txtQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount:"
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(235, 174)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(87, 29)
        Me.lblDiscount.TabIndex = 7
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(333, 174)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(87, 29)
        Me.lblTotalDue.TabIndex = 9
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcNestIf
        '
        Me.btnCalcNestIf.Location = New System.Drawing.Point(114, 221)
        Me.btnCalcNestIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcNestIf.Name = "btnCalcNestIf"
        Me.btnCalcNestIf.Size = New System.Drawing.Size(112, 32)
        Me.btnCalcNestIf.TabIndex = 4
        Me.btnCalcNestIf.Text = "Calc: Nested If"
        Me.btnCalcNestIf.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(189, 274)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalcIf
        '
        Me.btnCalcIf.Location = New System.Drawing.Point(17, 221)
        Me.btnCalcIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcIf.Name = "btnCalcIf"
        Me.btnCalcIf.Size = New System.Drawing.Size(86, 32)
        Me.btnCalcIf.TabIndex = 10
        Me.btnCalcIf.Text = "Calc: If"
        Me.btnCalcIf.UseVisualStyleBackColor = True
        '
        'btnCalcIfElseIf
        '
        Me.btnCalcIfElseIf.Location = New System.Drawing.Point(232, 221)
        Me.btnCalcIfElseIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcIfElseIf.Name = "btnCalcIfElseIf"
        Me.btnCalcIfElseIf.Size = New System.Drawing.Size(112, 32)
        Me.btnCalcIfElseIf.TabIndex = 11
        Me.btnCalcIfElseIf.Text = "Calc: If-ElseIf"
        Me.btnCalcIfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalcSelect
        '
        Me.btnCalcSelect.Location = New System.Drawing.Point(350, 221)
        Me.btnCalcSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcSelect.Name = "btnCalcSelect"
        Me.btnCalcSelect.Size = New System.Drawing.Size(95, 32)
        Me.btnCalcSelect.TabIndex = 12
        Me.btnCalcSelect.Text = "Calc: Select"
        Me.btnCalcSelect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 120)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount rates:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 80)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "0%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.5%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 80)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "1 - 10 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "11 - 15:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16 - 20:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">20:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 120)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sample results:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 80)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$9"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 80)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "$10. Qty 10: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$10. Qty 15: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$10. Qty 20: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$10. Qty 30: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 334)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalcSelect)
        Me.Controls.Add(Me.btnCalcIfElseIf)
        Me.Controls.Add(Me.btnCalcIf)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcNestIf)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jetters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnCalcNestIf As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalcIf As Button
    Friend WithEvents btnCalcIfElseIf As Button
    Friend WithEvents btnCalcSelect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
