<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpassword))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.AxAgent1 = New AxAgentObjects.AxAgent
        Me.txtoldpass = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtreenter = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnewpass = New System.Windows.Forms.TextBox
        Me.txtlogin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblcompany = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AxAgent1)
        Me.GroupBox1.Controls.Add(Me.txtoldpass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtreenter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnewpass)
        Me.GroupBox1.Controls.Add(Me.txtlogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(42, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 185)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'AxAgent1
        '
        Me.AxAgent1.Enabled = True
        Me.AxAgent1.Location = New System.Drawing.Point(-37, 33)
        Me.AxAgent1.Name = "AxAgent1"
        Me.AxAgent1.OcxState = CType(resources.GetObject("AxAgent1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent1.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent1.TabIndex = 12
        '
        'txtoldpass
        '
        Me.txtoldpass.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtoldpass.ForeColor = System.Drawing.Color.Black
        Me.txtoldpass.Location = New System.Drawing.Point(178, 69)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpass.Size = New System.Drawing.Size(126, 21)
        Me.txtoldpass.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(70, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 14)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Old Password  :"
        '
        'txtreenter
        '
        Me.txtreenter.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtreenter.ForeColor = System.Drawing.Color.Black
        Me.txtreenter.Location = New System.Drawing.Point(178, 138)
        Me.txtreenter.Name = "txtreenter"
        Me.txtreenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtreenter.Size = New System.Drawing.Size(126, 21)
        Me.txtreenter.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ReEnter Password  :"
        '
        'txtnewpass
        '
        Me.txtnewpass.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtnewpass.ForeColor = System.Drawing.Color.Black
        Me.txtnewpass.Location = New System.Drawing.Point(178, 105)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(126, 21)
        Me.txtnewpass.TabIndex = 2
        '
        'txtlogin
        '
        Me.txtlogin.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtlogin.ForeColor = System.Drawing.Color.Black
        Me.txtlogin.Location = New System.Drawing.Point(178, 33)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(126, 21)
        Me.txtlogin.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "New Password  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "User Name  :"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblcompany)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 50)
        Me.Panel1.TabIndex = 9
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.BackColor = System.Drawing.Color.Transparent
        Me.lblcompany.Font = New System.Drawing.Font("Tw Cen MT Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.Color.White
        Me.lblcompany.Location = New System.Drawing.Point(32, -4)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(125, 56)
        Me.lblcompany.TabIndex = 1
        Me.lblcompany.Text = "TITLE "
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(328, 247)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(82, 28)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnok.ForeColor = System.Drawing.Color.Black
        Me.btnok.Location = New System.Drawing.Point(239, 247)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(83, 28)
        Me.btnok.TabIndex = 4
        Me.btnok.Text = "&OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'frmpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 290)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtreenter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents AxAgent1 As AxAgentObjects.AxAgent
End Class
