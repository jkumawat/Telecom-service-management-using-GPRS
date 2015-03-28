<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomplain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcomplain))
        Me.lblcompany = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txttime = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxAgent1 = New AxAgentObjects.AxAgent
        Me.txttelepco = New System.Windows.Forms.TextBox
        Me.txtpurpose = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbtype = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbpriority = New System.Windows.Forms.ComboBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.lblcmpno = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtarea = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.BackColor = System.Drawing.Color.Transparent
        Me.lblcompany.Font = New System.Drawing.Font("Tw Cen MT Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.Color.White
        Me.lblcompany.Location = New System.Drawing.Point(-3, 2)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(425, 56)
        Me.lblcompany.TabIndex = 0
        Me.lblcompany.Text = "TITLE OF THE COMPANY"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblcompany)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 62)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(9, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 273)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txttime)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.AxAgent1)
        Me.Panel4.Controls.Add(Me.txttelepco)
        Me.Panel4.Controls.Add(Me.txtpurpose)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.cbtype)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtdate)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.cbpriority)
        Me.Panel4.Controls.Add(Me.txtemail)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtcontact)
        Me.Panel4.Controls.Add(Me.lblcmpno)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtarea)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtadd)
        Me.Panel4.Controls.Add(Me.txtname)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(3, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(441, 261)
        Me.Panel4.TabIndex = 50
        '
        'txttime
        '
        Me.txttime.Enabled = False
        Me.txttime.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txttime.ForeColor = System.Drawing.Color.Black
        Me.txttime.Location = New System.Drawing.Point(257, 231)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(141, 21)
        Me.txttime.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(233, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 14)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Complain Time"
        '
        'AxAgent1
        '
        Me.AxAgent1.Enabled = True
        Me.AxAgent1.Location = New System.Drawing.Point(192, 211)
        Me.AxAgent1.Name = "AxAgent1"
        Me.AxAgent1.OcxState = CType(resources.GetObject("AxAgent1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent1.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent1.TabIndex = 62
        '
        'txttelepco
        '
        Me.txttelepco.Enabled = False
        Me.txttelepco.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txttelepco.ForeColor = System.Drawing.Color.Black
        Me.txttelepco.Location = New System.Drawing.Point(257, 62)
        Me.txttelepco.Name = "txttelepco"
        Me.txttelepco.Size = New System.Drawing.Size(130, 21)
        Me.txttelepco.TabIndex = 61
        '
        'txtpurpose
        '
        Me.txtpurpose.Enabled = False
        Me.txtpurpose.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtpurpose.ForeColor = System.Drawing.Color.Black
        Me.txtpurpose.Location = New System.Drawing.Point(257, 26)
        Me.txtpurpose.Name = "txtpurpose"
        Me.txtpurpose.Size = New System.Drawing.Size(121, 21)
        Me.txtpurpose.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(233, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 14)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "TelePhone/PCO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(233, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Purpose"
        '
        'cbtype
        '
        Me.cbtype.Enabled = False
        Me.cbtype.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cbtype.ForeColor = System.Drawing.Color.Black
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"Line Dead", "Disturbance", "Cross Line", "Instrument Not Work"})
        Me.cbtype.Location = New System.Drawing.Point(257, 102)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(121, 21)
        Me.cbtype.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(233, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Problem Type"
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Location = New System.Drawing.Point(257, 186)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(168, 21)
        Me.txtdate.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(233, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 14)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Complain Date"
        '
        'cbpriority
        '
        Me.cbpriority.Enabled = False
        Me.cbpriority.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cbpriority.ForeColor = System.Drawing.Color.Black
        Me.cbpriority.FormattingEnabled = True
        Me.cbpriority.Items.AddRange(New Object() {"Low", "High", "Medium"})
        Me.cbpriority.Location = New System.Drawing.Point(257, 144)
        Me.cbpriority.Name = "cbpriority"
        Me.cbpriority.Size = New System.Drawing.Size(121, 21)
        Me.cbpriority.TabIndex = 53
        '
        'txtemail
        '
        Me.txtemail.Enabled = False
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(31, 231)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(147, 21)
        Me.txtemail.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 14)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Email Id:-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(233, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 14)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Priority of problem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Complain No."
        '
        'txtcontact
        '
        Me.txtcontact.Enabled = False
        Me.txtcontact.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcontact.Location = New System.Drawing.Point(31, 186)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(147, 21)
        Me.txtcontact.TabIndex = 48
        '
        'lblcmpno
        '
        Me.lblcmpno.AutoSize = True
        Me.lblcmpno.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblcmpno.ForeColor = System.Drawing.Color.Black
        Me.lblcmpno.Location = New System.Drawing.Point(99, 6)
        Me.lblcmpno.Name = "lblcmpno"
        Me.lblcmpno.Size = New System.Drawing.Size(34, 14)
        Me.lblcmpno.TabIndex = 49
        Me.lblcmpno.Text = "123"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 14)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Contact No."
        '
        'txtarea
        '
        Me.txtarea.Enabled = False
        Me.txtarea.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtarea.ForeColor = System.Drawing.Color.Black
        Me.txtarea.Location = New System.Drawing.Point(31, 147)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(100, 21)
        Me.txtarea.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 14)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Complaintant Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Area"
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtadd.ForeColor = System.Drawing.Color.Black
        Me.txtadd.Location = New System.Drawing.Point(31, 85)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtadd.Size = New System.Drawing.Size(147, 43)
        Me.txtadd.TabIndex = 46
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(30, 47)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(161, 21)
        Me.txtname.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Address"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btncancel)
        Me.Panel3.Controls.Add(Me.btnclear)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Location = New System.Drawing.Point(462, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(119, 260)
        Me.Panel3.TabIndex = 3
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(19, 142)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 40
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(19, 100)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 39
        Me.btncancel.Text = "C&ancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Location = New System.Drawing.Point(19, 60)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 38
        Me.btnclear.Text = "C&lear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(19, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 37
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(275, 382)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(129, 21)
        Me.txtsearch.TabIndex = 37
        Me.txtsearch.Text = "Phone No."
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(410, 380)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(69, 23)
        Me.btnsearch.TabIndex = 38
        Me.btnsearch.Text = "Searc&h"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(113, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 14)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Search By Phone No."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(12, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Complain Detail"
        '
        'frmcomplain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 408)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmcomplain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complain Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblcmpno As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbpriority As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txttelepco As System.Windows.Forms.TextBox
    Friend WithEvents txtpurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AxAgent1 As AxAgentObjects.AxAgent
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
