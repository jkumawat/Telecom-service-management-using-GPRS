<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrecipent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrecipent))
        Me.lblcompany = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblno = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbank = New System.Windows.Forms.ComboBox
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txtcheque = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.rbcheque = New System.Windows.Forms.RadioButton
        Me.rbcash = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.BackColor = System.Drawing.Color.Transparent
        Me.lblcompany.Font = New System.Drawing.Font("Tw Cen MT Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.Color.White
        Me.lblcompany.Location = New System.Drawing.Point(1, 2)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(425, 56)
        Me.lblcompany.TabIndex = 0
        Me.lblcompany.Text = "TITLE OF THE COMPANY"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblcompany)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(586, 62)
        Me.Panel4.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblno)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbbank)
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtcheque)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rbcheque)
        Me.GroupBox1.Controls.Add(Me.rbcash)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 216)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment receipt details"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Black
        Me.lblno.Location = New System.Drawing.Point(45, 42)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(39, 13)
        Me.lblno.TabIndex = 34
        Me.lblno.Text = "2100"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(18, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Reciept No."
        '
        'cbbank
        '
        Me.cbbank.Enabled = False
        Me.cbbank.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cbbank.ForeColor = System.Drawing.Color.Black
        Me.cbbank.FormattingEnabled = True
        Me.cbbank.Items.AddRange(New Object() {"BANK  OF BARODA (BOB)", "ABN AMERO Bank", "ICICI BANK", "AXIS BANK", "SBI BANK", "DENA BANK", "SURAT CO-OPRATIVE BANK"})
        Me.cbbank.Location = New System.Drawing.Point(246, 79)
        Me.cbbank.Name = "cbbank"
        Me.cbbank.Size = New System.Drawing.Size(140, 21)
        Me.cbbank.TabIndex = 4
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Location = New System.Drawing.Point(246, 172)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(176, 21)
        Me.txtdate.TabIndex = 6
        '
        'txtcheque
        '
        Me.txtcheque.Enabled = False
        Me.txtcheque.ForeColor = System.Drawing.Color.Black
        Me.txtcheque.Location = New System.Drawing.Point(246, 126)
        Me.txtcheque.Name = "txtcheque"
        Me.txtcheque.Size = New System.Drawing.Size(176, 23)
        Me.txtcheque.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(234, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Cheque No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(234, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Bank"
        '
        'rbcheque
        '
        Me.rbcheque.AutoSize = True
        Me.rbcheque.Enabled = False
        Me.rbcheque.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbcheque.ForeColor = System.Drawing.Color.Black
        Me.rbcheque.Location = New System.Drawing.Point(312, 43)
        Me.rbcheque.Name = "rbcheque"
        Me.rbcheque.Size = New System.Drawing.Size(69, 17)
        Me.rbcheque.TabIndex = 3
        Me.rbcheque.TabStop = True
        Me.rbcheque.Text = "Cheque"
        Me.rbcheque.UseVisualStyleBackColor = True
        '
        'rbcash
        '
        Me.rbcash.AutoSize = True
        Me.rbcash.Checked = True
        Me.rbcash.Enabled = False
        Me.rbcash.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbcash.ForeColor = System.Drawing.Color.Black
        Me.rbcash.Location = New System.Drawing.Point(252, 42)
        Me.rbcash.Name = "rbcash"
        Me.rbcash.Size = New System.Drawing.Size(54, 17)
        Me.rbcash.TabIndex = 3
        Me.rbcash.TabStop = True
        Me.rbcash.Text = "Cash"
        Me.rbcash.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(231, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Payment Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(237, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Payment Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(165, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Rs."
        '
        'txtamount
        '
        Me.txtamount.Enabled = False
        Me.txtamount.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtamount.ForeColor = System.Drawing.Color.Black
        Me.txtamount.Location = New System.Drawing.Point(33, 170)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(126, 21)
        Me.txtamount.TabIndex = 21
        '
        'txtcontact
        '
        Me.txtcontact.Enabled = False
        Me.txtcontact.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcontact.Location = New System.Drawing.Point(33, 124)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(179, 21)
        Me.txtcontact.TabIndex = 20
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(33, 78)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(179, 21)
        Me.txtname.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Amount Due"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contact No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(460, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 127)
        Me.Panel1.TabIndex = 45
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(16, 88)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "C&lose"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(16, 49)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(16, 13)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(96, 291)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(129, 21)
        Me.txtsearch.TabIndex = 1
        Me.txtsearch.Text = "Contact No."
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(233, 290)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 2
        Me.btnsearch.Text = "S&earch"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(31, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Search :"
        '
        'frmrecipent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(585, 318)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrecipent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Reciept"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbcheque As System.Windows.Forms.RadioButton
    Friend WithEvents rbcash As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbbank As System.Windows.Forms.ComboBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtcheque As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
