<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.txtWeeklyPay = New System.Windows.Forms.TextBox()
        Me.txtPamContrib = New System.Windows.Forms.TextBox()
        Me.txtEmContrib = New System.Windows.Forms.TextBox()
        Me.lblPamAnContrib = New System.Windows.Forms.Label()
        Me.lblEmAnContrib = New System.Windows.Forms.Label()
        Me.lblTotalAnContrib = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(65, 297)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(105, 46)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(188, 297)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 46)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(311, 297)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 46)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtWeeklyPay
        '
        Me.txtWeeklyPay.Location = New System.Drawing.Point(320, 38)
        Me.txtWeeklyPay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWeeklyPay.Name = "txtWeeklyPay"
        Me.txtWeeklyPay.Size = New System.Drawing.Size(132, 27)
        Me.txtWeeklyPay.TabIndex = 1
        Me.txtWeeklyPay.Text = "1000"
        Me.txtWeeklyPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPamContrib
        '
        Me.txtPamContrib.Location = New System.Drawing.Point(320, 75)
        Me.txtPamContrib.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPamContrib.Name = "txtPamContrib"
        Me.txtPamContrib.Size = New System.Drawing.Size(132, 27)
        Me.txtPamContrib.TabIndex = 3
        Me.txtPamContrib.Text = "0.05"
        Me.txtPamContrib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmContrib
        '
        Me.txtEmContrib.Location = New System.Drawing.Point(320, 112)
        Me.txtEmContrib.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmContrib.Name = "txtEmContrib"
        Me.txtEmContrib.Size = New System.Drawing.Size(132, 27)
        Me.txtEmContrib.TabIndex = 5
        Me.txtEmContrib.Text = "0.07"
        Me.txtEmContrib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPamAnContrib
        '
        Me.lblPamAnContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPamAnContrib.Location = New System.Drawing.Point(320, 149)
        Me.lblPamAnContrib.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPamAnContrib.Name = "lblPamAnContrib"
        Me.lblPamAnContrib.Size = New System.Drawing.Size(132, 27)
        Me.lblPamAnContrib.TabIndex = 12
        Me.lblPamAnContrib.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEmAnContrib
        '
        Me.lblEmAnContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmAnContrib.Location = New System.Drawing.Point(320, 186)
        Me.lblEmAnContrib.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmAnContrib.Name = "lblEmAnContrib"
        Me.lblEmAnContrib.Size = New System.Drawing.Size(132, 27)
        Me.lblEmAnContrib.TabIndex = 13
        Me.lblEmAnContrib.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalAnContrib
        '
        Me.lblTotalAnContrib.BackColor = System.Drawing.Color.LightYellow
        Me.lblTotalAnContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAnContrib.Location = New System.Drawing.Point(320, 223)
        Me.lblTotalAnContrib.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAnContrib.Name = "lblTotalAnContrib"
        Me.lblTotalAnContrib.Size = New System.Drawing.Size(132, 27)
        Me.lblTotalAnContrib.TabIndex = 14
        Me.lblTotalAnContrib.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Location = New System.Drawing.Point(24, 41)
        Me.Lable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(125, 20)
        Me.Lable1.TabIndex = 0
        Me.Lable1.Text = "&Gross weekly pay:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Employee contribution rate (in decimals):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Employe&r contribution rate (in decimals):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Employee annual contribution:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Employer annual contribution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total contributions:"
        '
        'frmRetirement
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 380)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.lblTotalAnContrib)
        Me.Controls.Add(Me.lblEmAnContrib)
        Me.Controls.Add(Me.lblPamAnContrib)
        Me.Controls.Add(Me.txtEmContrib)
        Me.Controls.Add(Me.txtPamContrib)
        Me.Controls.Add(Me.txtWeeklyPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRetirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtWeeklyPay As TextBox
    Friend WithEvents txtPamContrib As TextBox
    Friend WithEvents txtEmContrib As TextBox
    Friend WithEvents lblPamAnContrib As Label
    Friend WithEvents lblEmAnContrib As Label
    Friend WithEvents lblTotalAnContrib As Label
    Friend WithEvents Lable1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
