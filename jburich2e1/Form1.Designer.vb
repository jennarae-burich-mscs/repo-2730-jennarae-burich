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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.txtYN = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.lblShipChg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGL = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcOr)
        Me.GroupBox1.Controls.Add(Me.btnCalcAnd)
        Me.GroupBox1.Controls.Add(Me.txtYN)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Controls.Add(Me.lblShipChg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Location = New System.Drawing.Point(362, 67)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(92, 35)
        Me.btnCalcOr.TabIndex = 7
        Me.btnCalcOr.Text = "Calculate (Or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Location = New System.Drawing.Point(362, 26)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(92, 35)
        Me.btnCalcAnd.TabIndex = 6
        Me.btnCalcAnd.Text = "Calculate (And)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'txtYN
        '
        Me.txtYN.Location = New System.Drawing.Point(140, 54)
        Me.txtYN.Name = "txtYN"
        Me.txtYN.Size = New System.Drawing.Size(44, 20)
        Me.txtYN.TabIndex = 5
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(23, 54)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtOrder.TabIndex = 4
        '
        'lblShipChg
        '
        Me.lblShipChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipChg.Location = New System.Drawing.Point(241, 56)
        Me.lblShipChg.Name = "lblShipChg"
        Me.lblShipChg.Size = New System.Drawing.Size(100, 23)
        Me.lblShipChg.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Shipping Charge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Savannah (Y/N):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order amount:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGL)
        Me.GroupBox2.Controls.Add(Me.btnMulti)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.lblComm)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% commission for Sales > 25000 with codes A1, B2, C3"
        '
        'btnGL
        '
        Me.btnGL.Location = New System.Drawing.Point(362, 67)
        Me.btnGL.Name = "btnGL"
        Me.btnGL.Size = New System.Drawing.Size(92, 35)
        Me.btnGL.TabIndex = 7
        Me.btnGL.Text = "Calculate (<>)"
        Me.btnGL.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(362, 26)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(92, 35)
        Me.btnMulti.TabIndex = 6
        Me.btnMulti.Text = "Calculate (*)"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(23, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(44, 20)
        Me.txtID.TabIndex = 5
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(84, 56)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 4
        '
        'lblComm
        '
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComm.Location = New System.Drawing.Point(241, 56)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(100, 23)
        Me.lblComm.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Commission:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "&Sales:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "&ID:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(220, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 326)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jburich 2e1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents txtYN As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents lblShipChg As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGL As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents lblComm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExit As Button
End Class
