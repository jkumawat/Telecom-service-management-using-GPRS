<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmview))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblbank = New System.Windows.Forms.Label
        Me.lblration = New System.Windows.Forms.Label
        Me.lblpan = New System.Windows.Forms.Label
        Me.lbllicence = New System.Windows.Forms.Label
        Me.pbbank = New System.Windows.Forms.PictureBox
        Me.pbration = New System.Windows.Forms.PictureBox
        Me.pbpan = New System.Windows.Forms.PictureBox
        Me.pblicence = New System.Windows.Forms.PictureBox
        Me.btnback = New System.Windows.Forms.Button
        Me.OpenFileDialogView = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblicence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblbank)
        Me.GroupBox1.Controls.Add(Me.lblration)
        Me.GroupBox1.Controls.Add(Me.lblpan)
        Me.GroupBox1.Controls.Add(Me.lbllicence)
        Me.GroupBox1.Controls.Add(Me.pbbank)
        Me.GroupBox1.Controls.Add(Me.pbration)
        Me.GroupBox1.Controls.Add(Me.pbpan)
        Me.GroupBox1.Controls.Add(Me.pblicence)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(56, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 390)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'lblbank
        '
        Me.lblbank.AutoSize = True
        Me.lblbank.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbank.ForeColor = System.Drawing.Color.Black
        Me.lblbank.Location = New System.Drawing.Point(274, 359)
        Me.lblbank.Name = "lblbank"
        Me.lblbank.Size = New System.Drawing.Size(146, 16)
        Me.lblbank.TabIndex = 7
        Me.lblbank.Text = "Bank Book Preview"
        '
        'lblration
        '
        Me.lblration.AutoSize = True
        Me.lblration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblration.ForeColor = System.Drawing.Color.Black
        Me.lblration.Location = New System.Drawing.Point(45, 359)
        Me.lblration.Name = "lblration"
        Me.lblration.Size = New System.Drawing.Size(154, 16)
        Me.lblration.TabIndex = 6
        Me.lblration.Text = "Ration Card Preview"
        '
        'lblpan
        '
        Me.lblpan.AutoSize = True
        Me.lblpan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpan.ForeColor = System.Drawing.Color.Black
        Me.lblpan.Location = New System.Drawing.Point(282, 170)
        Me.lblpan.Name = "lblpan"
        Me.lblpan.Size = New System.Drawing.Size(135, 16)
        Me.lblpan.TabIndex = 5
        Me.lblpan.Text = "Pan Card Preview"
        '
        'lbllicence
        '
        Me.lbllicence.AutoSize = True
        Me.lbllicence.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllicence.ForeColor = System.Drawing.Color.Black
        Me.lbllicence.Location = New System.Drawing.Point(58, 170)
        Me.lbllicence.Name = "lbllicence"
        Me.lbllicence.Size = New System.Drawing.Size(125, 16)
        Me.lbllicence.TabIndex = 4
        Me.lbllicence.Text = "Licence Preview"
        '
        'pbbank
        '
        Me.pbbank.Location = New System.Drawing.Point(247, 213)
        Me.pbbank.Name = "pbbank"
        Me.pbbank.Size = New System.Drawing.Size(200, 135)
        Me.pbbank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbbank.TabIndex = 3
        Me.pbbank.TabStop = False
        '
        'pbration
        '
        Me.pbration.Location = New System.Drawing.Point(22, 213)
        Me.pbration.Name = "pbration"
        Me.pbration.Size = New System.Drawing.Size(200, 135)
        Me.pbration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbration.TabIndex = 2
        Me.pbration.TabStop = False
        '
        'pbpan
        '
        Me.pbpan.Location = New System.Drawing.Point(247, 26)
        Me.pbpan.Name = "pbpan"
        Me.pbpan.Size = New System.Drawing.Size(200, 135)
        Me.pbpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbpan.TabIndex = 1
        Me.pbpan.TabStop = False
        '
        'pblicence
        '
        Me.pblicence.Location = New System.Drawing.Point(22, 27)
        Me.pblicence.Name = "pblicence"
        Me.pblicence.Size = New System.Drawing.Size(200, 135)
        Me.pblicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblicence.TabIndex = 0
        Me.pblicence.TabStop = False
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(545, 367)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(78, 24)
        Me.btnback.TabIndex = 2
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'OpenFileDialogView
        '
        Me.OpenFileDialogView.FileName = "OpenFileDialog1"
        '
        'frmview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 423)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Attachments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblicence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblbank As System.Windows.Forms.Label
    Friend WithEvents lblration As System.Windows.Forms.Label
    Friend WithEvents lblpan As System.Windows.Forms.Label
    Friend WithEvents lbllicence As System.Windows.Forms.Label
    Friend WithEvents pbbank As System.Windows.Forms.PictureBox
    Friend WithEvents pbration As System.Windows.Forms.PictureBox
    Friend WithEvents pbpan As System.Windows.Forms.PictureBox
    Friend WithEvents pblicence As System.Windows.Forms.PictureBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogView As System.Windows.Forms.OpenFileDialog
End Class
