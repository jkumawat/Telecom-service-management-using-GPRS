<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcust))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblcompany = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AxAgent1 = New AxAgentObjects.AxAgent
        Me.mtxtcontact = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbpco = New System.Windows.Forms.RadioButton
        Me.rbtele = New System.Windows.Forms.RadioButton
        Me.chksame = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbresident = New System.Windows.Forms.RadioButton
        Me.rbbusiness = New System.Windows.Forms.RadioButton
        Me.gbgender = New System.Windows.Forms.GroupBox
        Me.rbfemale = New System.Windows.Forms.RadioButton
        Me.rbmale = New System.Windows.Forms.RadioButton
        Me.chkhotline = New System.Windows.Forms.CheckBox
        Me.chkconference = New System.Windows.Forms.CheckBox
        Me.mtxttele = New System.Windows.Forms.MaskedTextBox
        Me.chkisd = New System.Windows.Forms.CheckBox
        Me.chkstd = New System.Windows.Forms.CheckBox
        Me.cmbbarea = New System.Windows.Forms.ComboBox
        Me.txtbadd2 = New System.Windows.Forms.TextBox
        Me.txtbadd1 = New System.Windows.Forms.TextBox
        Me.cmbarea = New System.Windows.Forms.ComboBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtadd1 = New System.Windows.Forms.TextBox
        Me.txtadd2 = New System.Windows.Forms.TextBox
        Me.txtpan = New System.Windows.Forms.TextBox
        Me.txtnominee = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnview = New System.Windows.Forms.Button
        Me.btnattach = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbsearch = New System.Windows.Forms.ComboBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.pbphoto = New System.Windows.Forms.PictureBox
        Me.btnbrowse = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbgender.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pbphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblcompany)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 67)
        Me.Panel1.TabIndex = 4
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.BackColor = System.Drawing.Color.Transparent
        Me.lblcompany.Font = New System.Drawing.Font("Tw Cen MT Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblcompany.Location = New System.Drawing.Point(6, 4)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(425, 56)
        Me.lblcompany.TabIndex = 0
        Me.lblcompany.Text = "TITLE OF THE COMPANY"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AxAgent1)
        Me.Panel2.Controls.Add(Me.mtxtcontact)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.chksame)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.gbgender)
        Me.Panel2.Controls.Add(Me.chkhotline)
        Me.Panel2.Controls.Add(Me.chkconference)
        Me.Panel2.Controls.Add(Me.mtxttele)
        Me.Panel2.Controls.Add(Me.chkisd)
        Me.Panel2.Controls.Add(Me.chkstd)
        Me.Panel2.Controls.Add(Me.cmbbarea)
        Me.Panel2.Controls.Add(Me.txtbadd2)
        Me.Panel2.Controls.Add(Me.txtbadd1)
        Me.Panel2.Controls.Add(Me.cmbarea)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.txtadd1)
        Me.Panel2.Controls.Add(Me.txtadd2)
        Me.Panel2.Controls.Add(Me.txtpan)
        Me.Panel2.Controls.Add(Me.txtnominee)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnview)
        Me.Panel2.Controls.Add(Me.btnattach)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 399)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Tag = ""
        '
        'AxAgent1
        '
        Me.AxAgent1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAgent1.Enabled = True
        Me.AxAgent1.Location = New System.Drawing.Point(500, 500)
        Me.AxAgent1.Name = "AxAgent1"
        Me.AxAgent1.OcxState = CType(resources.GetObject("AxAgent1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent1.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent1.TabIndex = 37
        '
        'mtxtcontact
        '
        Me.mtxtcontact.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtcontact.ForeColor = System.Drawing.Color.Black
        Me.mtxtcontact.Location = New System.Drawing.Point(33, 324)
        Me.mtxtcontact.Mask = "##########"
        Me.mtxtcontact.Name = "mtxtcontact"
        Me.mtxtcontact.Size = New System.Drawing.Size(168, 21)
        Me.mtxtcontact.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 14)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Mobile No."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbpco)
        Me.GroupBox3.Controls.Add(Me.rbtele)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(347, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 63)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TelePhone/PCO"
        '
        'rbpco
        '
        Me.rbpco.AutoSize = True
        Me.rbpco.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbpco.ForeColor = System.Drawing.Color.Black
        Me.rbpco.Location = New System.Drawing.Point(5, 36)
        Me.rbpco.Name = "rbpco"
        Me.rbpco.Size = New System.Drawing.Size(50, 17)
        Me.rbpco.TabIndex = 23
        Me.rbpco.Text = "PCO"
        Me.rbpco.UseVisualStyleBackColor = True
        '
        'rbtele
        '
        Me.rbtele.AutoSize = True
        Me.rbtele.Checked = True
        Me.rbtele.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbtele.ForeColor = System.Drawing.Color.Black
        Me.rbtele.Location = New System.Drawing.Point(5, 17)
        Me.rbtele.Name = "rbtele"
        Me.rbtele.Size = New System.Drawing.Size(84, 17)
        Me.rbtele.TabIndex = 22
        Me.rbtele.TabStop = True
        Me.rbtele.Text = "Telephone"
        Me.rbtele.UseVisualStyleBackColor = True
        '
        'chksame
        '
        Me.chksame.AutoSize = True
        Me.chksame.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksame.ForeColor = System.Drawing.Color.Black
        Me.chksame.Location = New System.Drawing.Point(125, 221)
        Me.chksame.Name = "chksame"
        Me.chksame.Size = New System.Drawing.Size(123, 18)
        Me.chksame.TabIndex = 7
        Me.chksame.Text = "Same As Above"
        Me.chksame.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbresident)
        Me.GroupBox2.Controls.Add(Me.rbbusiness)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(347, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 63)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purpose"
        '
        'rbresident
        '
        Me.rbresident.AutoSize = True
        Me.rbresident.Checked = True
        Me.rbresident.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbresident.ForeColor = System.Drawing.Color.Black
        Me.rbresident.Location = New System.Drawing.Point(9, 19)
        Me.rbresident.Name = "rbresident"
        Me.rbresident.Size = New System.Drawing.Size(83, 17)
        Me.rbresident.TabIndex = 20
        Me.rbresident.TabStop = True
        Me.rbresident.Text = "Residence"
        Me.rbresident.UseVisualStyleBackColor = True
        '
        'rbbusiness
        '
        Me.rbbusiness.AutoSize = True
        Me.rbbusiness.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbbusiness.ForeColor = System.Drawing.Color.Black
        Me.rbbusiness.Location = New System.Drawing.Point(9, 41)
        Me.rbbusiness.Name = "rbbusiness"
        Me.rbbusiness.Size = New System.Drawing.Size(75, 17)
        Me.rbbusiness.TabIndex = 21
        Me.rbbusiness.Text = "Business"
        Me.rbbusiness.UseVisualStyleBackColor = True
        '
        'gbgender
        '
        Me.gbgender.Controls.Add(Me.rbfemale)
        Me.gbgender.Controls.Add(Me.rbmale)
        Me.gbgender.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbgender.ForeColor = System.Drawing.Color.Black
        Me.gbgender.Location = New System.Drawing.Point(341, 11)
        Me.gbgender.Name = "gbgender"
        Me.gbgender.Size = New System.Drawing.Size(184, 40)
        Me.gbgender.TabIndex = 33
        Me.gbgender.TabStop = False
        Me.gbgender.Text = "Gender"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbfemale.ForeColor = System.Drawing.Color.Black
        Me.rbfemale.Location = New System.Drawing.Point(98, 13)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(66, 17)
        Me.rbfemale.TabIndex = 14
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Checked = True
        Me.rbmale.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbmale.ForeColor = System.Drawing.Color.Black
        Me.rbmale.Location = New System.Drawing.Point(32, 13)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(51, 17)
        Me.rbmale.TabIndex = 13
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'chkhotline
        '
        Me.chkhotline.AutoSize = True
        Me.chkhotline.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkhotline.ForeColor = System.Drawing.Color.Black
        Me.chkhotline.Location = New System.Drawing.Point(356, 136)
        Me.chkhotline.Name = "chkhotline"
        Me.chkhotline.Size = New System.Drawing.Size(76, 17)
        Me.chkhotline.TabIndex = 17
        Me.chkhotline.Text = "HOTLINE"
        Me.chkhotline.UseVisualStyleBackColor = True
        '
        'chkconference
        '
        Me.chkconference.AutoSize = True
        Me.chkconference.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkconference.ForeColor = System.Drawing.Color.Black
        Me.chkconference.Location = New System.Drawing.Point(356, 177)
        Me.chkconference.Name = "chkconference"
        Me.chkconference.Size = New System.Drawing.Size(119, 17)
        Me.chkconference.TabIndex = 19
        Me.chkconference.Text = "CONFERENCING"
        Me.chkconference.UseVisualStyleBackColor = True
        '
        'mtxttele
        '
        Me.mtxttele.Enabled = False
        Me.mtxttele.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxttele.ForeColor = System.Drawing.Color.Black
        Me.mtxttele.Location = New System.Drawing.Point(33, 367)
        Me.mtxttele.Mask = "#######"
        Me.mtxttele.Name = "mtxttele"
        Me.mtxttele.Size = New System.Drawing.Size(168, 21)
        Me.mtxttele.TabIndex = 12
        '
        'chkisd
        '
        Me.chkisd.AutoSize = True
        Me.chkisd.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkisd.ForeColor = System.Drawing.Color.Black
        Me.chkisd.Location = New System.Drawing.Point(356, 157)
        Me.chkisd.Name = "chkisd"
        Me.chkisd.Size = New System.Drawing.Size(48, 17)
        Me.chkisd.TabIndex = 18
        Me.chkisd.Text = "ISD"
        Me.chkisd.UseVisualStyleBackColor = True
        '
        'chkstd
        '
        Me.chkstd.AutoSize = True
        Me.chkstd.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.chkstd.ForeColor = System.Drawing.Color.Black
        Me.chkstd.Location = New System.Drawing.Point(356, 115)
        Me.chkstd.Name = "chkstd"
        Me.chkstd.Size = New System.Drawing.Size(50, 17)
        Me.chkstd.TabIndex = 16
        Me.chkstd.Text = "STD"
        Me.chkstd.UseVisualStyleBackColor = True
        '
        'cmbbarea
        '
        Me.cmbbarea.DisplayMember = "0"
        Me.cmbbarea.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbarea.ForeColor = System.Drawing.Color.Black
        Me.cmbbarea.FormattingEnabled = True
        Me.cmbbarea.Items.AddRange(New Object() {"Select Area", "Adajan", "Athwagate", "Citilight", "Piplod", "Nanpura", "Rander", "Palanpur patia", "Parvat patia", "Varacha", "Udhna"})
        Me.cmbbarea.Location = New System.Drawing.Point(33, 285)
        Me.cmbbarea.Name = "cmbbarea"
        Me.cmbbarea.Size = New System.Drawing.Size(113, 21)
        Me.cmbbarea.TabIndex = 10
        Me.cmbbarea.ValueMember = "0"
        '
        'txtbadd2
        '
        Me.txtbadd2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbadd2.ForeColor = System.Drawing.Color.Black
        Me.txtbadd2.Location = New System.Drawing.Point(33, 262)
        Me.txtbadd2.Name = "txtbadd2"
        Me.txtbadd2.Size = New System.Drawing.Size(205, 21)
        Me.txtbadd2.TabIndex = 9
        '
        'txtbadd1
        '
        Me.txtbadd1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbadd1.ForeColor = System.Drawing.Color.Black
        Me.txtbadd1.Location = New System.Drawing.Point(33, 240)
        Me.txtbadd1.Name = "txtbadd1"
        Me.txtbadd1.Size = New System.Drawing.Size(206, 21)
        Me.txtbadd1.TabIndex = 8
        '
        'cmbarea
        '
        Me.cmbarea.DisplayMember = "0"
        Me.cmbarea.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbarea.ForeColor = System.Drawing.Color.Black
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Items.AddRange(New Object() {"Select Area", "Adajan", "Athwagate", "Citilight", "Piplod", "Nanpura", "Rander", "Palanpur patia", "Parvat patia", "Varacha", "Udhna"})
        Me.cmbarea.Location = New System.Drawing.Point(33, 198)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(113, 21)
        Me.cmbarea.TabIndex = 6
        Me.cmbarea.ValueMember = "0"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(356, 71)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(190, 21)
        Me.txtemail.TabIndex = 15
        '
        'txtadd1
        '
        Me.txtadd1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd1.ForeColor = System.Drawing.Color.Black
        Me.txtadd1.Location = New System.Drawing.Point(33, 154)
        Me.txtadd1.Name = "txtadd1"
        Me.txtadd1.Size = New System.Drawing.Size(206, 21)
        Me.txtadd1.TabIndex = 4
        '
        'txtadd2
        '
        Me.txtadd2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd2.ForeColor = System.Drawing.Color.Black
        Me.txtadd2.Location = New System.Drawing.Point(33, 176)
        Me.txtadd2.Name = "txtadd2"
        Me.txtadd2.Size = New System.Drawing.Size(206, 21)
        Me.txtadd2.TabIndex = 5
        '
        'txtpan
        '
        Me.txtpan.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpan.ForeColor = System.Drawing.Color.Black
        Me.txtpan.Location = New System.Drawing.Point(34, 112)
        Me.txtpan.Name = "txtpan"
        Me.txtpan.Size = New System.Drawing.Size(180, 21)
        Me.txtpan.TabIndex = 3
        Me.txtpan.Text = "ytte878786"
        '
        'txtnominee
        '
        Me.txtnominee.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnominee.ForeColor = System.Drawing.Color.Black
        Me.txtnominee.Location = New System.Drawing.Point(34, 71)
        Me.txtnominee.Name = "txtnominee"
        Me.txtnominee.Size = New System.Drawing.Size(216, 21)
        Me.txtnominee.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(33, 30)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(217, 21)
        Me.txtname.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(338, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 14)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = " Facilities Required "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(343, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 14)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(22, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Billing Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Complete Postal Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tel No. (Allocated)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PAN /GIR NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name of the Nominee  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Name"
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnview.ForeColor = System.Drawing.Color.Black
        Me.btnview.Location = New System.Drawing.Point(353, 341)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(90, 23)
        Me.btnview.TabIndex = 38
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnattach
        '
        Me.btnattach.Enabled = False
        Me.btnattach.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnattach.ForeColor = System.Drawing.Color.Black
        Me.btnattach.Location = New System.Drawing.Point(353, 342)
        Me.btnattach.Name = "btnattach"
        Me.btnattach.Size = New System.Drawing.Size(90, 23)
        Me.btnattach.TabIndex = 26
        Me.btnattach.Text = "Attachments"
        Me.btnattach.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btncancel)
        Me.Panel3.Controls.Add(Me.btnclear)
        Me.Panel3.Controls.Add(Me.btnnew)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.btnedit)
        Me.Panel3.Controls.Add(Me.btnupdate)
        Me.Panel3.Location = New System.Drawing.Point(618, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(110, 240)
        Me.Panel3.TabIndex = 3
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(16, 199)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 31
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(16, 166)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 30
        Me.btncancel.Text = "C&ancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Enabled = False
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Location = New System.Drawing.Point(16, 137)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 29
        Me.btnclear.Text = "C&lear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Enabled = False
        Me.btnnew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Black
        Me.btnnew.Location = New System.Drawing.Point(16, 15)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "&New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(16, 106)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 28
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(16, 47)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 25
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Enabled = False
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Black
        Me.btnedit.Location = New System.Drawing.Point(16, 77)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 27
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Enabled = False
        Me.btnupdate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(17, 76)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 24)
        Me.btnupdate.TabIndex = 31
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        Me.btnupdate.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(705, 104)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(35, 499)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 14)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Search By Category"
        '
        'cmbsearch
        '
        Me.cmbsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsearch.ForeColor = System.Drawing.Color.Black
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"All", "Telephone", "Name", "Area"})
        Me.cmbsearch.Location = New System.Drawing.Point(169, 499)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(122, 21)
        Me.cmbsearch.TabIndex = 32
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(463, 497)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.Text = "Searc&h"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(299, 500)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(157, 21)
        Me.txtsearch.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.pbphoto)
        Me.Panel4.Controls.Add(Me.btnbrowse)
        Me.Panel4.Location = New System.Drawing.Point(618, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(110, 150)
        Me.Panel4.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Photograph "
        '
        'pbphoto
        '
        Me.pbphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbphoto.Location = New System.Drawing.Point(5, 15)
        Me.pbphoto.Name = "pbphoto"
        Me.pbphoto.Size = New System.Drawing.Size(98, 104)
        Me.pbphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbphoto.TabIndex = 0
        Me.pbphoto.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.Enabled = False
        Me.btnbrowse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.Black
        Me.btnbrowse.Location = New System.Drawing.Point(11, 121)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(85, 25)
        Me.btnbrowse.TabIndex = 24
        Me.btnbrowse.Text = "&Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 18)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Customer Details"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 519)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 129)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer list"
        '
        'Frmcust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 650)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.cmbsearch)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbgender.ResumeLayout(False)
        Me.gbgender.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pbphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtadd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpan As System.Windows.Forms.TextBox
    Friend WithEvents txtnominee As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtbadd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbadd1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cmbbarea As System.Windows.Forms.ComboBox
    Friend WithEvents chkisd As System.Windows.Forms.CheckBox
    Friend WithEvents chkstd As System.Windows.Forms.CheckBox
    Friend WithEvents chkhotline As System.Windows.Forms.CheckBox
    Friend WithEvents chkconference As System.Windows.Forms.CheckBox
    Friend WithEvents mtxttele As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents rbresident As System.Windows.Forms.RadioButton
    Friend WithEvents rbbusiness As System.Windows.Forms.RadioButton
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnattach As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents gbgender As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chksame As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbpco As System.Windows.Forms.RadioButton
    Friend WithEvents rbtele As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbphoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtadd1 As System.Windows.Forms.TextBox
    Friend WithEvents mtxtcontact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxAgent1 As AxAgentObjects.AxAgent
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
