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
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRasp = New System.Windows.Forms.TextBox()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.lblProjBlue = New System.Windows.Forms.Label()
        Me.lblProjRasp = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.lblCurrentSales = New System.Windows.Forms.Label()
        Me.lblProjSales = New System.Windows.Forms.Label()
        Me.lblProjIncrease = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRetirement = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStraw
        '
        Me.txtStraw.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStraw.Location = New System.Drawing.Point(185, 136)
        Me.txtStraw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(116, 27)
        Me.txtStraw.TabIndex = 2
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(185, 179)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(116, 27)
        Me.txtBlue.TabIndex = 4
        '
        'txtRasp
        '
        Me.txtRasp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRasp.Location = New System.Drawing.Point(185, 222)
        Me.txtRasp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRasp.Name = "txtRasp"
        Me.txtRasp.Size = New System.Drawing.Size(116, 27)
        Me.txtRasp.TabIndex = 6
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjIncrease.Location = New System.Drawing.Point(376, 49)
        Me.txtProjIncrease.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(63, 27)
        Me.txtProjIncrease.TabIndex = 0
        Me.txtProjIncrease.Text = "0.05"
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjStraw.Location = New System.Drawing.Point(327, 138)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(112, 25)
        Me.lblProjStraw.TabIndex = 13
        '
        'lblProjBlue
        '
        Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjBlue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjBlue.Location = New System.Drawing.Point(327, 180)
        Me.lblProjBlue.Name = "lblProjBlue"
        Me.lblProjBlue.Size = New System.Drawing.Size(112, 25)
        Me.lblProjBlue.TabIndex = 14
        '
        'lblProjRasp
        '
        Me.lblProjRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjRasp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjRasp.Location = New System.Drawing.Point(327, 222)
        Me.lblProjRasp.Name = "lblProjRasp"
        Me.lblProjRasp.Size = New System.Drawing.Size(112, 25)
        Me.lblProjRasp.TabIndex = 15
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(49, 272)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 30)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(142, 272)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(364, 272)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraw.Location = New System.Drawing.Point(74, 140)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(94, 20)
        Me.lblStraw.TabIndex = 1
        Me.lblStraw.Text = "&Strawberries:"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(82, 183)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(86, 20)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "&Blueberries:"
        Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRasp
        '
        Me.lblRasp.AutoSize = True
        Me.lblRasp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRasp.Location = New System.Drawing.Point(77, 226)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(89, 20)
        Me.lblRasp.TabIndex = 5
        Me.lblRasp.Text = "&Raspberries:"
        '
        'lblCurrentSales
        '
        Me.lblCurrentSales.AutoSize = True
        Me.lblCurrentSales.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSales.Location = New System.Drawing.Point(196, 97)
        Me.lblCurrentSales.Name = "lblCurrentSales"
        Me.lblCurrentSales.Size = New System.Drawing.Size(95, 20)
        Me.lblCurrentSales.TabIndex = 11
        Me.lblCurrentSales.Text = "Current Sales"
        '
        'lblProjSales
        '
        Me.lblProjSales.AutoSize = True
        Me.lblProjSales.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjSales.Location = New System.Drawing.Point(328, 97)
        Me.lblProjSales.Name = "lblProjSales"
        Me.lblProjSales.Size = New System.Drawing.Size(110, 20)
        Me.lblProjSales.TabIndex = 12
        Me.lblProjSales.Text = "Projected Sales"
        '
        'lblProjIncrease
        '
        Me.lblProjIncrease.AutoSize = True
        Me.lblProjIncrease.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjIncrease.Location = New System.Drawing.Point(181, 42)
        Me.lblProjIncrease.Name = "lblProjIncrease"
        Me.lblProjIncrease.Size = New System.Drawing.Size(149, 40)
        Me.lblProjIncrease.TabIndex = 10
        Me.lblProjIncrease.Text = "Projected &increase %:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(In decimal form)"
        Me.lblProjIncrease.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jburich1f1.My.Resources.Resources.berries
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnRetirement
        '
        Me.btnRetirement.Location = New System.Drawing.Point(236, 272)
        Me.btnRetirement.Name = "btnRetirement"
        Me.btnRetirement.Size = New System.Drawing.Size(122, 30)
        Me.btnRetirement.TabIndex = 18
        Me.btnRetirement.Text = "Retirement Form"
        Me.btnRetirement.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 325)
        Me.Controls.Add(Me.btnRetirement)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblProjIncrease)
        Me.Controls.Add(Me.lblProjSales)
        Me.Controls.Add(Me.lblCurrentSales)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblProjRasp)
        Me.Controls.Add(Me.lblProjBlue)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.txtRasp)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtStraw)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cranston Berries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRasp As TextBox
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents lblProjBlue As Label
    Friend WithEvents lblProjRasp As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents lblCurrentSales As Label
    Friend WithEvents lblProjSales As Label
    Friend WithEvents lblProjIncrease As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRetirement As Button
End Class
