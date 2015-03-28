<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmattach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmattach))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblattach = New System.Windows.Forms.Label
        Me.btnbank = New System.Windows.Forms.Button
        Me.btnration = New System.Windows.Forms.Button
        Me.btnpan = New System.Windows.Forms.Button
        Me.btnlicence = New System.Windows.Forms.Button
        Me.chkbank = New System.Windows.Forms.CheckBox
        Me.chkration = New System.Windows.Forms.CheckBox
        Me.chkpan = New System.Windows.Forms.CheckBox
        Me.chklicence = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.pblicence = New System.Windows.Forms.PictureBox
        Me.pbpan = New System.Windows.Forms.PictureBox
        Me.pbration = New System.Windows.Forms.PictureBox
        Me.pbbank = New System.Windows.Forms.PictureBox
        Me.lbllicence = New System.Windows.Forms.Label
        Me.lblpan = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblbank = New System.Windows.Forms.Label
        Me.lblration = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pblicence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblattach)
        Me.Panel1.Controls.Add(Me.btnbank)
        Me.Panel1.Controls.Add(Me.btnration)
        Me.Panel1.Controls.Add(Me.btnpan)
        Me.Panel1.Controls.Add(Me.btnlicence)
        Me.Panel1.Controls.Add(Me.chkbank)
        Me.Panel1.Controls.Add(Me.chkration)
        Me.Panel1.Controls.Add(Me.chkpan)
        Me.Panel1.Controls.Add(Me.chklicence)
        Me.Panel1.Location = New System.Drawing.Point(12, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 277)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "(For Address Proof)"
        '
        'lblattach
        '
        Me.lblattach.AutoSize = True
        Me.lblattach.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblattach.ForeColor = System.Drawing.Color.Black
        Me.lblattach.Location = New System.Drawing.Point(8, 6)
        Me.lblattach.Name = "lblattach"
        Me.lblattach.Size = New System.Drawing.Size(107, 16)
        Me.lblattach.TabIndex = 8
        Me.lblattach.Text = "Attachments:"
        '
        'btnbank
        '
        Me.btnbank.Enabled = False
        Me.btnbank.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnbank.ForeColor = System.Drawing.Color.Black
        Me.btnbank.Location = New System.Drawing.Point(12, 230)
        Me.btnbank.Name = "btnbank"
        Me.btnbank.Size = New System.Drawing.Size(92, 22)
        Me.btnbank.TabIndex = 7
        Me.btnbank.Text = "Browse"
        Me.btnbank.UseVisualStyleBackColor = True
        '
        'btnration
        '
        Me.btnration.Enabled = False
        Me.btnration.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnration.ForeColor = System.Drawing.Color.Black
        Me.btnration.Location = New System.Drawing.Point(12, 180)
        Me.btnration.Name = "btnration"
        Me.btnration.Size = New System.Drawing.Size(92, 22)
        Me.btnration.TabIndex = 6
        Me.btnration.Text = "Browse"
        Me.btnration.UseVisualStyleBackColor = True
        '
        'btnpan
        '
        Me.btnpan.Enabled = False
        Me.btnpan.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnpan.ForeColor = System.Drawing.Color.Black
        Me.btnpan.Location = New System.Drawing.Point(12, 131)
        Me.btnpan.Name = "btnpan"
        Me.btnpan.Size = New System.Drawing.Size(92, 22)
        Me.btnpan.TabIndex = 5
        Me.btnpan.Text = "Browse"
        Me.btnpan.UseVisualStyleBackColor = True
        '
        'btnlicence
        '
        Me.btnlicence.Enabled = False
        Me.btnlicence.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnlicence.ForeColor = System.Drawing.Color.Black
        Me.btnlicence.Location = New System.Drawing.Point(12, 83)
        Me.btnlicence.Name = "btnlicence"
        Me.btnlicence.Size = New System.Drawing.Size(92, 22)
        Me.btnlicence.TabIndex = 4
        Me.btnlicence.Text = "Browse"
        Me.btnlicence.UseVisualStyleBackColor = True
        '
        'chkbank
        '
        Me.chkbank.AutoSize = True
        Me.chkbank.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkbank.ForeColor = System.Drawing.Color.Black
        Me.chkbank.Location = New System.Drawing.Point(12, 207)
        Me.chkbank.Name = "chkbank"
        Me.chkbank.Size = New System.Drawing.Size(88, 17)
        Me.chkbank.TabIndex = 3
        Me.chkbank.Text = "Bank Book"
        Me.chkbank.UseVisualStyleBackColor = True
        '
        'chkration
        '
        Me.chkration.AutoSize = True
        Me.chkration.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkration.ForeColor = System.Drawing.Color.Black
        Me.chkration.Location = New System.Drawing.Point(12, 159)
        Me.chkration.Name = "chkration"
        Me.chkration.Size = New System.Drawing.Size(91, 17)
        Me.chkration.TabIndex = 2
        Me.chkration.Text = "Ration card"
        Me.chkration.UseVisualStyleBackColor = True
        '
        'chkpan
        '
        Me.chkpan.AutoSize = True
        Me.chkpan.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkpan.ForeColor = System.Drawing.Color.Black
        Me.chkpan.Location = New System.Drawing.Point(12, 111)
        Me.chkpan.Name = "chkpan"
        Me.chkpan.Size = New System.Drawing.Size(76, 17)
        Me.chkpan.TabIndex = 1
        Me.chkpan.Text = "Pan card"
        Me.chkpan.UseVisualStyleBackColor = True
        '
        'chklicence
        '
        Me.chklicence.AutoSize = True
        Me.chklicence.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chklicence.ForeColor = System.Drawing.Color.Black
        Me.chklicence.Location = New System.Drawing.Point(12, 62)
        Me.chklicence.Name = "chklicence"
        Me.chklicence.Size = New System.Drawing.Size(68, 17)
        Me.chklicence.TabIndex = 0
        Me.chklicence.Text = "Licence"
        Me.chklicence.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btncancel)
        Me.Panel3.Controls.Add(Me.btnclear)
        Me.Panel3.Controls.Add(Me.btnsubmit)
        Me.Panel3.Location = New System.Drawing.Point(12, 295)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(126, 115)
        Me.Panel3.TabIndex = 2
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(23, 75)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(74, 27)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Location = New System.Drawing.Point(23, 42)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(74, 27)
        Me.btnclear.TabIndex = 6
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsubmit.ForeColor = System.Drawing.Color.Black
        Me.btnsubmit.Location = New System.Drawing.Point(23, 8)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(74, 27)
        Me.btnsubmit.TabIndex = 5
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'pblicence
        '
        Me.pblicence.Image = CType(resources.GetObject("pblicence.Image"), System.Drawing.Image)
        Me.pblicence.InitialImage = Nothing
        Me.pblicence.Location = New System.Drawing.Point(19, 27)
        Me.pblicence.Name = "pblicence"
        Me.pblicence.Size = New System.Drawing.Size(200, 135)
        Me.pblicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblicence.TabIndex = 0
        Me.pblicence.TabStop = False
        '
        'pbpan
        '
        Me.pbpan.Image = CType(resources.GetObject("pbpan.Image"), System.Drawing.Image)
        Me.pbpan.Location = New System.Drawing.Point(244, 26)
        Me.pbpan.Name = "pbpan"
        Me.pbpan.Size = New System.Drawing.Size(200, 135)
        Me.pbpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbpan.TabIndex = 1
        Me.pbpan.TabStop = False
        '
        'pbration
        '
        Me.pbration.Image = CType(resources.GetObject("pbration.Image"), System.Drawing.Image)
        Me.pbration.Location = New System.Drawing.Point(19, 205)
        Me.pbration.Name = "pbration"
        Me.pbration.Size = New System.Drawing.Size(200, 135)
        Me.pbration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbration.TabIndex = 2
        Me.pbration.TabStop = False
        '
        'pbbank
        '
        Me.pbbank.Image = CType(resources.GetObject("pbbank.Image"), System.Drawing.Image)
        Me.pbbank.Location = New System.Drawing.Point(244, 205)
        Me.pbbank.Name = "pbbank"
        Me.pbbank.Size = New System.Drawing.Size(200, 135)
        Me.pbbank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbbank.TabIndex = 3
        Me.pbbank.TabStop = False
        '
        'lbllicence
        '
        Me.lbllicence.AutoSize = True
        Me.lbllicence.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbllicence.ForeColor = System.Drawing.Color.Black
        Me.lbllicence.Location = New System.Drawing.Point(58, 168)
        Me.lbllicence.Name = "lbllicence"
        Me.lbllicence.Size = New System.Drawing.Size(115, 17)
        Me.lbllicence.TabIndex = 4
        Me.lbllicence.Text = "Licence Preview"
        '
        'lblpan
        '
        Me.lblpan.AutoSize = True
        Me.lblpan.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblpan.ForeColor = System.Drawing.Color.Black
        Me.lblpan.Location = New System.Drawing.Point(284, 165)
        Me.lblpan.Name = "lblpan"
        Me.lblpan.Size = New System.Drawing.Size(128, 17)
        Me.lblpan.TabIndex = 5
        Me.lblpan.Text = "Pan Card Preview"
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
        Me.GroupBox1.Location = New System.Drawing.Point(144, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 398)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'lblbank
        '
        Me.lblbank.AutoSize = True
        Me.lblbank.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblbank.ForeColor = System.Drawing.Color.Black
        Me.lblbank.Location = New System.Drawing.Point(271, 345)
        Me.lblbank.Name = "lblbank"
        Me.lblbank.Size = New System.Drawing.Size(141, 17)
        Me.lblbank.TabIndex = 7
        Me.lblbank.Text = "Bank Book Preview"
        '
        'lblration
        '
        Me.lblration.AutoSize = True
        Me.lblration.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblration.ForeColor = System.Drawing.Color.Black
        Me.lblration.Location = New System.Drawing.Point(49, 345)
        Me.lblration.Name = "lblration"
        Me.lblration.Size = New System.Drawing.Size(148, 17)
        Me.lblration.TabIndex = 6
        Me.lblration.Text = "Ration Card Preview"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmattach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmattach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attachments"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pblicence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblattach As System.Windows.Forms.Label
    Friend WithEvents btnbank As System.Windows.Forms.Button
    Friend WithEvents btnration As System.Windows.Forms.Button
    Friend WithEvents btnpan As System.Windows.Forms.Button
    Friend WithEvents btnlicence As System.Windows.Forms.Button
    Friend WithEvents chkbank As System.Windows.Forms.CheckBox
    Friend WithEvents chkration As System.Windows.Forms.CheckBox
    Friend WithEvents chkpan As System.Windows.Forms.CheckBox
    Friend WithEvents chklicence As System.Windows.Forms.CheckBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbpan As System.Windows.Forms.PictureBox
    Friend WithEvents pbration As System.Windows.Forms.PictureBox
    Friend WithEvents pbbank As System.Windows.Forms.PictureBox
    Friend WithEvents lbllicence As System.Windows.Forms.Label
    Friend WithEvents lblpan As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblbank As System.Windows.Forms.Label
    Friend WithEvents lblration As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents pblicence As System.Windows.Forms.PictureBox
End Class
