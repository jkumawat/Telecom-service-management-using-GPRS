<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbillgenerate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbillgenerate))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblcompany = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtarea = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblno = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.rbunpaid = New System.Windows.Forms.RadioButton
        Me.rbpaid = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblcompany)
        Me.Panel4.Location = New System.Drawing.Point(-2, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(598, 62)
        Me.Panel4.TabIndex = 42
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtarea)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblno)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.rbunpaid)
        Me.GroupBox1.Controls.Add(Me.rbpaid)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpto)
        Me.GroupBox1.Controls.Add(Me.dtpfrom)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(9, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 234)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill Information"
        '
        'txtarea
        '
        Me.txtarea.Enabled = False
        Me.txtarea.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtarea.ForeColor = System.Drawing.Color.Black
        Me.txtarea.Location = New System.Drawing.Point(36, 159)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(179, 21)
        Me.txtarea.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(15, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 14)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Area"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Black
        Me.lblno.Location = New System.Drawing.Point(67, 21)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(39, 13)
        Me.lblno.TabIndex = 19
        Me.lblno.Text = "1000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Bill No."
        '
        'rbunpaid
        '
        Me.rbunpaid.AutoSize = True
        Me.rbunpaid.Checked = True
        Me.rbunpaid.Enabled = False
        Me.rbunpaid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbunpaid.ForeColor = System.Drawing.Color.Black
        Me.rbunpaid.Location = New System.Drawing.Point(325, 59)
        Me.rbunpaid.Name = "rbunpaid"
        Me.rbunpaid.Size = New System.Drawing.Size(64, 17)
        Me.rbunpaid.TabIndex = 17
        Me.rbunpaid.TabStop = True
        Me.rbunpaid.Text = "Unpaid"
        Me.rbunpaid.UseVisualStyleBackColor = True
        '
        'rbpaid
        '
        Me.rbpaid.AutoSize = True
        Me.rbpaid.Enabled = False
        Me.rbpaid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbpaid.ForeColor = System.Drawing.Color.Black
        Me.rbpaid.Location = New System.Drawing.Point(267, 59)
        Me.rbpaid.Name = "rbpaid"
        Me.rbpaid.Size = New System.Drawing.Size(49, 17)
        Me.rbpaid.TabIndex = 16
        Me.rbpaid.Text = "Paid"
        Me.rbpaid.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(399, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 14)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Rs."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(248, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(249, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "From"
        '
        'dtpto
        '
        Me.dtpto.Enabled = False
        Me.dtpto.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(267, 156)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(141, 21)
        Me.dtpto.TabIndex = 12
        '
        'dtpfrom
        '
        Me.dtpfrom.AllowDrop = True
        Me.dtpfrom.Enabled = False
        Me.dtpfrom.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(267, 119)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(141, 21)
        Me.dtpfrom.TabIndex = 11
        '
        'txtamount
        '
        Me.txtamount.Enabled = False
        Me.txtamount.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtamount.ForeColor = System.Drawing.Color.Black
        Me.txtamount.Location = New System.Drawing.Point(267, 202)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(126, 21)
        Me.txtamount.TabIndex = 9
        '
        'txtcontact
        '
        Me.txtcontact.Enabled = False
        Me.txtcontact.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcontact.Location = New System.Drawing.Point(36, 202)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(179, 21)
        Me.txtcontact.TabIndex = 8
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtadd.ForeColor = System.Drawing.Color.Black
        Me.txtadd.Location = New System.Drawing.Point(35, 102)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(179, 36)
        Me.txtadd.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(33, 59)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(179, 21)
        Me.txtname.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(246, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Amount Due"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(246, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Payment Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(246, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bill Period"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Location = New System.Drawing.Point(465, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 129)
        Me.Panel1.TabIndex = 44
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(22, 11)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(22, 85)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "C&lose"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Enabled = False
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Location = New System.Drawing.Point(22, 49)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 307)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Search :"
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(216, 305)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 46
        Me.btnsearch.Text = "S&earch"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(79, 306)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(129, 21)
        Me.txtsearch.TabIndex = 47
        Me.txtsearch.Text = "Phone No."
        '
        'frmbillgenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 335)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbillgenerate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Generator"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbunpaid As System.Windows.Forms.RadioButton
    Friend WithEvents rbpaid As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
End Class
