<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmemployee))
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.cbarea = New System.Windows.Forms.ComboBox
        Me.btn4 = New System.Windows.Forms.Button
        Me.txtjoindate = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.btn7 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cbrole = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.btnattach = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.mtxtcontact = New System.Windows.Forms.MaskedTextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblcompany = New System.Windows.Forms.Label
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.cmbsearch = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.AxAgent1 = New AxAgentObjects.AxAgent
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn8 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pbemp = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(30, 211)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 39
        Me.btn3.Text = "&Close"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(30, 144)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 35
        Me.btn2.Text = "C&lear"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(30, 177)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 36
        Me.btn1.Text = "C&ancel"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'cbarea
        '
        Me.cbarea.DisplayMember = "0"
        Me.cbarea.Enabled = False
        Me.cbarea.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbarea.ForeColor = System.Drawing.Color.Black
        Me.cbarea.FormattingEnabled = True
        Me.cbarea.Items.AddRange(New Object() {"Adajan", "Athwagate", "Citilight", "Piplod", "Nanpura", "Rander", "Palanpur patia", "Parvat patia", "Varacha", "Udhna"})
        Me.cbarea.Location = New System.Drawing.Point(312, 193)
        Me.cbarea.Name = "cbarea"
        Me.cbarea.Size = New System.Drawing.Size(113, 21)
        Me.cbarea.TabIndex = 8
        Me.cbarea.ValueMember = "0"
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(30, 111)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 34
        Me.btn4.Text = "&Delete"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'txtjoindate
        '
        Me.txtjoindate.Enabled = False
        Me.txtjoindate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjoindate.ForeColor = System.Drawing.Color.Black
        Me.txtjoindate.Location = New System.Drawing.Point(312, 234)
        Me.txtjoindate.Name = "txtjoindate"
        Me.txtjoindate.Size = New System.Drawing.Size(140, 21)
        Me.txtjoindate.TabIndex = 8
        '
        'txtemail
        '
        Me.txtemail.Enabled = False
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(25, 194)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(160, 21)
        Me.txtemail.TabIndex = 6
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(30, 45)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 23)
        Me.btn7.TabIndex = 1
        Me.btn7.Text = "&Save"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(10, 388)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 128)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emplyee list"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 102)
        Me.DataGridView1.TabIndex = 0
        '
        'cbrole
        '
        Me.cbrole.Enabled = False
        Me.cbrole.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbrole.ForeColor = System.Drawing.Color.Black
        Me.cbrole.FormattingEnabled = True
        Me.cbrole.Items.AddRange(New Object() {"Finance", "Engineer", "ServiceMan", "Admin"})
        Me.cbrole.Location = New System.Drawing.Point(26, 154)
        Me.cbrole.Name = "cbrole"
        Me.cbrole.Size = New System.Drawing.Size(113, 21)
        Me.cbrole.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(304, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Location"
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(30, 12)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 23)
        Me.btn6.TabIndex = 0
        Me.btn6.Text = "&New"
        Me.btn6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(30, 78)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 38
        Me.btn5.Text = "&Edit"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'txtlname
        '
        Me.txtlname.Enabled = False
        Me.txtlname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.Black
        Me.txtlname.Location = New System.Drawing.Point(25, 63)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(160, 21)
        Me.txtlname.TabIndex = 3
        '
        'btnattach
        '
        Me.btnattach.Enabled = False
        Me.btnattach.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnattach.ForeColor = System.Drawing.Color.Black
        Me.btnattach.Location = New System.Drawing.Point(6, 128)
        Me.btnattach.Name = "btnattach"
        Me.btnattach.Size = New System.Drawing.Size(103, 23)
        Me.btnattach.TabIndex = 9
        Me.btnattach.Text = "Attach photo"
        Me.btnattach.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 14)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Employee Details"
        '
        'txtfname
        '
        Me.txtfname.Enabled = False
        Me.txtfname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(25, 26)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(160, 21)
        Me.txtfname.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Update Photo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(304, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Join Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact No.(Mobile)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Role in Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnattach)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(304, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 157)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Photo"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(26, 104)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(186, 28)
        Me.txtaddress.TabIndex = 4
        '
        'mtxtcontact
        '
        Me.mtxtcontact.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtcontact.ForeColor = System.Drawing.Color.Black
        Me.mtxtcontact.Location = New System.Drawing.Point(25, 238)
        Me.mtxtcontact.Mask = "##########"
        Me.mtxtcontact.Name = "mtxtcontact"
        Me.mtxtcontact.Size = New System.Drawing.Size(160, 21)
        Me.mtxtcontact.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblcompany)
        Me.Panel4.Location = New System.Drawing.Point(1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(627, 63)
        Me.Panel4.TabIndex = 50
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.BackColor = System.Drawing.Color.Transparent
        Me.lblcompany.Font = New System.Drawing.Font("Tw Cen MT Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.Color.White
        Me.lblcompany.Location = New System.Drawing.Point(3, 2)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(425, 56)
        Me.lblcompany.TabIndex = 0
        Me.lblcompany.Text = "TITLE OF THE COMPANY"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(276, 360)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(157, 21)
        Me.txtsearch.TabIndex = 48
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(440, 359)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 49
        Me.btnsearch.Text = "Searc&h"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cmbsearch
        '
        Me.cmbsearch.ForeColor = System.Drawing.Color.Black
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"All", "Telephone", "EmployeeName", "Area"})
        Me.cmbsearch.Location = New System.Drawing.Point(148, 360)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(122, 21)
        Me.cmbsearch.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 361)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 14)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Search By Category"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(30, 188)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 36
        Me.btncancel.Text = "C&ancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnclose)
        Me.Panel5.Controls.Add(Me.btncancel)
        Me.Panel5.Controls.Add(Me.btnclear)
        Me.Panel5.Controls.Add(Me.btndelete)
        Me.Panel5.Controls.Add(Me.btnsave)
        Me.Panel5.Controls.Add(Me.btnnew)
        Me.Panel5.Controls.Add(Me.btnedit)
        Me.Panel5.Controls.Add(Me.btnupdate)
        Me.Panel5.Location = New System.Drawing.Point(482, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(135, 266)
        Me.Panel5.TabIndex = 44
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(30, 221)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 39
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Location = New System.Drawing.Point(30, 155)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 35
        Me.btnclear.Text = "C&lear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(30, 122)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 34
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(30, 56)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Black
        Me.btnnew.Location = New System.Drawing.Point(30, 23)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "&New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Black
        Me.btnedit.Location = New System.Drawing.Point(30, 89)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 38
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Enabled = False
        Me.btnupdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(30, 90)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 37
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        Me.btnupdate.Visible = False
        '
        'AxAgent1
        '
        Me.AxAgent1.Enabled = True
        Me.AxAgent1.Location = New System.Drawing.Point(229, 181)
        Me.AxAgent1.Name = "AxAgent1"
        Me.AxAgent1.OcxState = CType(resources.GetObject("AxAgent1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent1.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent1.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btn3)
        Me.Panel3.Controls.Add(Me.btn1)
        Me.Panel3.Controls.Add(Me.btn2)
        Me.Panel3.Controls.Add(Me.btn4)
        Me.Panel3.Controls.Add(Me.btn7)
        Me.Panel3.Controls.Add(Me.btn6)
        Me.Panel3.Controls.Add(Me.btn5)
        Me.Panel3.Controls.Add(Me.btn8)
        Me.Panel3.Location = New System.Drawing.Point(482, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 266)
        Me.Panel3.TabIndex = 45
        '
        'btn8
        '
        Me.btn8.Enabled = False
        Me.btn8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(30, 79)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 23)
        Me.btn8.TabIndex = 37
        Me.btn8.Text = "&Update"
        Me.btn8.UseVisualStyleBackColor = True
        Me.btn8.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AxAgent1)
        Me.Panel2.Controls.Add(Me.mtxtcontact)
        Me.Panel2.Controls.Add(Me.txtaddress)
        Me.Panel2.Controls.Add(Me.cbarea)
        Me.Panel2.Controls.Add(Me.pbemp)
        Me.Panel2.Controls.Add(Me.cbrole)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtjoindate)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.txtlname)
        Me.Panel2.Controls.Add(Me.txtfname)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(11, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 266)
        Me.Panel2.TabIndex = 43
        '
        'pbemp
        '
        Me.pbemp.BackColor = System.Drawing.Color.White
        Me.pbemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbemp.Location = New System.Drawing.Point(312, 26)
        Me.pbemp.Name = "pbemp"
        Me.pbemp.Size = New System.Drawing.Size(103, 106)
        Me.pbemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbemp.TabIndex = 0
        Me.pbemp.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.cmbsearch)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents cbarea As System.Windows.Forms.ComboBox
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents txtjoindate As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbrole As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents btnattach As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents mtxtcontact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents AxAgent1 As AxAgentObjects.AxAgent
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pbemp As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
