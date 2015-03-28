<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adverticement
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adverticement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsend = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnoffer = New System.Windows.Forms.Button
        Me.btnbill = New System.Windows.Forms.Button
        Me.btngreeting = New System.Windows.Forms.Button
        Me.gboffer = New System.Windows.Forms.GroupBox
        Me.lblo3 = New System.Windows.Forms.Label
        Me.cboffer1 = New System.Windows.Forms.CheckBox
        Me.lblo1 = New System.Windows.Forms.Label
        Me.lblo2 = New System.Windows.Forms.Label
        Me.cboffer3 = New System.Windows.Forms.CheckBox
        Me.cboffer2 = New System.Windows.Forms.CheckBox
        Me.gbbilling = New System.Windows.Forms.GroupBox
        Me.cbbill = New System.Windows.Forms.CheckBox
        Me.lblbill = New System.Windows.Forms.Label
        Me.gbgreeting = New System.Windows.Forms.GroupBox
        Me.lblg3 = New System.Windows.Forms.Label
        Me.cbgreet1 = New System.Windows.Forms.CheckBox
        Me.lblg1 = New System.Windows.Forms.Label
        Me.lblg2 = New System.Windows.Forms.Label
        Me.cbgreet3 = New System.Windows.Forms.CheckBox
        Me.cbgreet2 = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblcompany = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.gboffer.SuspendLayout()
        Me.gbbilling.SuspendLayout()
        Me.gbgreeting.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnsend)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(7, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 271)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adverticement"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(120, 234)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsend
        '
        Me.btnsend.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnsend.ForeColor = System.Drawing.Color.Black
        Me.btnsend.Location = New System.Drawing.Point(38, 234)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(75, 23)
        Me.btnsend.TabIndex = 4
        Me.btnsend.Text = "&Send"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(38, 89)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 138)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(38, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 21)
        Me.TextBox1.TabIndex = 0
        '
        'btnoffer
        '
        Me.btnoffer.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnoffer.ForeColor = System.Drawing.Color.Black
        Me.btnoffer.Location = New System.Drawing.Point(322, 79)
        Me.btnoffer.Name = "btnoffer"
        Me.btnoffer.Size = New System.Drawing.Size(106, 23)
        Me.btnoffer.TabIndex = 43
        Me.btnoffer.Text = "Special Offers!"
        Me.btnoffer.UseVisualStyleBackColor = True
        Me.btnoffer.Visible = False
        '
        'btnbill
        '
        Me.btnbill.ForeColor = System.Drawing.Color.Black
        Me.btnbill.Location = New System.Drawing.Point(322, 79)
        Me.btnbill.Name = "btnbill"
        Me.btnbill.Size = New System.Drawing.Size(106, 23)
        Me.btnbill.TabIndex = 44
        Me.btnbill.Text = "Billing Reminder!"
        Me.btnbill.UseVisualStyleBackColor = True
        Me.btnbill.Visible = False
        '
        'btngreeting
        '
        Me.btngreeting.ForeColor = System.Drawing.Color.Black
        Me.btngreeting.Location = New System.Drawing.Point(322, 79)
        Me.btngreeting.Name = "btngreeting"
        Me.btngreeting.Size = New System.Drawing.Size(106, 23)
        Me.btngreeting.TabIndex = 45
        Me.btngreeting.Text = "Holiday Greetings!"
        Me.btngreeting.UseVisualStyleBackColor = True
        Me.btngreeting.Visible = False
        '
        'gboffer
        '
        Me.gboffer.Controls.Add(Me.lblo3)
        Me.gboffer.Controls.Add(Me.cboffer1)
        Me.gboffer.Controls.Add(Me.lblo1)
        Me.gboffer.Controls.Add(Me.lblo2)
        Me.gboffer.Controls.Add(Me.cboffer3)
        Me.gboffer.Controls.Add(Me.cboffer2)
        Me.gboffer.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.gboffer.ForeColor = System.Drawing.Color.Black
        Me.gboffer.Location = New System.Drawing.Point(328, 204)
        Me.gboffer.Name = "gboffer"
        Me.gboffer.Size = New System.Drawing.Size(282, 83)
        Me.gboffer.TabIndex = 46
        Me.gboffer.TabStop = False
        Me.gboffer.Text = "Special Offers"
        Me.gboffer.Visible = False
        '
        'lblo3
        '
        Me.lblo3.AutoSize = True
        Me.lblo3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblo3.ForeColor = System.Drawing.Color.Black
        Me.lblo3.Location = New System.Drawing.Point(38, 60)
        Me.lblo3.Name = "lblo3"
        Me.lblo3.Size = New System.Drawing.Size(14, 13)
        Me.lblo3.TabIndex = 5
        Me.lblo3.Text = "3"
        Me.lblo3.Visible = False
        '
        'cboffer1
        '
        Me.cboffer1.AutoSize = True
        Me.cboffer1.Location = New System.Drawing.Point(17, 19)
        Me.cboffer1.Name = "cboffer1"
        Me.cboffer1.Size = New System.Drawing.Size(15, 14)
        Me.cboffer1.TabIndex = 0
        Me.cboffer1.UseVisualStyleBackColor = True
        Me.cboffer1.Visible = False
        '
        'lblo1
        '
        Me.lblo1.AutoSize = True
        Me.lblo1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblo1.ForeColor = System.Drawing.Color.Black
        Me.lblo1.Location = New System.Drawing.Point(38, 20)
        Me.lblo1.Name = "lblo1"
        Me.lblo1.Size = New System.Drawing.Size(14, 13)
        Me.lblo1.TabIndex = 3
        Me.lblo1.Text = "1"
        Me.lblo1.Visible = False
        '
        'lblo2
        '
        Me.lblo2.AutoSize = True
        Me.lblo2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblo2.ForeColor = System.Drawing.Color.Black
        Me.lblo2.Location = New System.Drawing.Point(38, 40)
        Me.lblo2.Name = "lblo2"
        Me.lblo2.Size = New System.Drawing.Size(14, 13)
        Me.lblo2.TabIndex = 4
        Me.lblo2.Text = "2"
        Me.lblo2.Visible = False
        '
        'cboffer3
        '
        Me.cboffer3.AutoSize = True
        Me.cboffer3.Location = New System.Drawing.Point(17, 59)
        Me.cboffer3.Name = "cboffer3"
        Me.cboffer3.Size = New System.Drawing.Size(15, 14)
        Me.cboffer3.TabIndex = 2
        Me.cboffer3.UseVisualStyleBackColor = True
        Me.cboffer3.Visible = False
        '
        'cboffer2
        '
        Me.cboffer2.AutoSize = True
        Me.cboffer2.Location = New System.Drawing.Point(17, 39)
        Me.cboffer2.Name = "cboffer2"
        Me.cboffer2.Size = New System.Drawing.Size(15, 14)
        Me.cboffer2.TabIndex = 1
        Me.cboffer2.UseVisualStyleBackColor = True
        Me.cboffer2.Visible = False
        '
        'gbbilling
        '
        Me.gbbilling.Controls.Add(Me.cbbill)
        Me.gbbilling.Controls.Add(Me.lblbill)
        Me.gbbilling.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.gbbilling.ForeColor = System.Drawing.Color.Black
        Me.gbbilling.Location = New System.Drawing.Point(322, 293)
        Me.gbbilling.Name = "gbbilling"
        Me.gbbilling.Size = New System.Drawing.Size(288, 49)
        Me.gbbilling.TabIndex = 47
        Me.gbbilling.TabStop = False
        Me.gbbilling.Text = "Billing Reminder"
        Me.gbbilling.Visible = False
        '
        'cbbill
        '
        Me.cbbill.AutoSize = True
        Me.cbbill.Location = New System.Drawing.Point(14, 23)
        Me.cbbill.Name = "cbbill"
        Me.cbbill.Size = New System.Drawing.Size(15, 14)
        Me.cbbill.TabIndex = 6
        Me.cbbill.UseVisualStyleBackColor = True
        Me.cbbill.Visible = False
        '
        'lblbill
        '
        Me.lblbill.AutoSize = True
        Me.lblbill.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblbill.ForeColor = System.Drawing.Color.Black
        Me.lblbill.Location = New System.Drawing.Point(35, 24)
        Me.lblbill.Name = "lblbill"
        Me.lblbill.Size = New System.Drawing.Size(225, 13)
        Me.lblbill.TabIndex = 9
        Me.lblbill.Text = "Hi dear customer,please pay your bill."
        Me.lblbill.Visible = False
        '
        'gbgreeting
        '
        Me.gbgreeting.Controls.Add(Me.lblg3)
        Me.gbgreeting.Controls.Add(Me.cbgreet1)
        Me.gbgreeting.Controls.Add(Me.lblg1)
        Me.gbgreeting.Controls.Add(Me.lblg2)
        Me.gbgreeting.Controls.Add(Me.cbgreet3)
        Me.gbgreeting.Controls.Add(Me.cbgreet2)
        Me.gbgreeting.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.gbgreeting.ForeColor = System.Drawing.Color.Black
        Me.gbgreeting.Location = New System.Drawing.Point(323, 117)
        Me.gbgreeting.Name = "gbgreeting"
        Me.gbgreeting.Size = New System.Drawing.Size(287, 82)
        Me.gbgreeting.TabIndex = 48
        Me.gbgreeting.TabStop = False
        Me.gbgreeting.Text = "Greetings"
        Me.gbgreeting.Visible = False
        '
        'lblg3
        '
        Me.lblg3.AutoSize = True
        Me.lblg3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblg3.ForeColor = System.Drawing.Color.Black
        Me.lblg3.Location = New System.Drawing.Point(33, 58)
        Me.lblg3.Name = "lblg3"
        Me.lblg3.Size = New System.Drawing.Size(17, 13)
        Me.lblg3.TabIndex = 11
        Me.lblg3.Text = "ki"
        Me.lblg3.Visible = False
        '
        'cbgreet1
        '
        Me.cbgreet1.AutoSize = True
        Me.cbgreet1.Location = New System.Drawing.Point(12, 17)
        Me.cbgreet1.Name = "cbgreet1"
        Me.cbgreet1.Size = New System.Drawing.Size(15, 14)
        Me.cbgreet1.TabIndex = 6
        Me.cbgreet1.UseVisualStyleBackColor = True
        Me.cbgreet1.Visible = False
        '
        'lblg1
        '
        Me.lblg1.AutoSize = True
        Me.lblg1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblg1.ForeColor = System.Drawing.Color.Black
        Me.lblg1.Location = New System.Drawing.Point(33, 18)
        Me.lblg1.Name = "lblg1"
        Me.lblg1.Size = New System.Drawing.Size(14, 13)
        Me.lblg1.TabIndex = 9
        Me.lblg1.Text = "ji"
        Me.lblg1.Visible = False
        '
        'lblg2
        '
        Me.lblg2.AutoSize = True
        Me.lblg2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblg2.ForeColor = System.Drawing.Color.Black
        Me.lblg2.Location = New System.Drawing.Point(33, 38)
        Me.lblg2.Name = "lblg2"
        Me.lblg2.Size = New System.Drawing.Size(13, 13)
        Me.lblg2.TabIndex = 10
        Me.lblg2.Text = "li"
        Me.lblg2.Visible = False
        '
        'cbgreet3
        '
        Me.cbgreet3.AutoSize = True
        Me.cbgreet3.Location = New System.Drawing.Point(12, 57)
        Me.cbgreet3.Name = "cbgreet3"
        Me.cbgreet3.Size = New System.Drawing.Size(15, 14)
        Me.cbgreet3.TabIndex = 8
        Me.cbgreet3.UseVisualStyleBackColor = True
        Me.cbgreet3.Visible = False
        '
        'cbgreet2
        '
        Me.cbgreet2.AutoSize = True
        Me.cbgreet2.Location = New System.Drawing.Point(12, 37)
        Me.cbgreet2.Name = "cbgreet2"
        Me.cbgreet2.Size = New System.Drawing.Size(15, 14)
        Me.cbgreet2.TabIndex = 7
        Me.cbgreet2.UseVisualStyleBackColor = True
        Me.cbgreet2.Visible = False
        '
        'Timer1
        '
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblcompany)
        Me.Panel4.Location = New System.Drawing.Point(-1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(632, 66)
        Me.Panel4.TabIndex = 41
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.BackColor = System.Drawing.Color.Transparent
        Me.lblcompany.Font = New System.Drawing.Font("Tw Cen MT Condensed", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblcompany.ForeColor = System.Drawing.Color.White
        Me.lblcompany.Location = New System.Drawing.Point(4, 4)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(425, 56)
        Me.lblcompany.TabIndex = 0
        Me.lblcompany.Text = "TITLE OF THE COMPANY"
        '
        'adverticement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 375)
        Me.Controls.Add(Me.gbgreeting)
        Me.Controls.Add(Me.gbbilling)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboffer)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnoffer)
        Me.Controls.Add(Me.btngreeting)
        Me.Controls.Add(Me.btnbill)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adverticement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advertisement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboffer.ResumeLayout(False)
        Me.gboffer.PerformLayout()
        Me.gbbilling.ResumeLayout(False)
        Me.gbbilling.PerformLayout()
        Me.gbgreeting.ResumeLayout(False)
        Me.gbgreeting.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnoffer As System.Windows.Forms.Button
    Friend WithEvents btnbill As System.Windows.Forms.Button
    Friend WithEvents btngreeting As System.Windows.Forms.Button
    Friend WithEvents gboffer As System.Windows.Forms.GroupBox
    Friend WithEvents gbbilling As System.Windows.Forms.GroupBox
    Friend WithEvents gbgreeting As System.Windows.Forms.GroupBox
    Friend WithEvents cboffer3 As System.Windows.Forms.CheckBox
    Friend WithEvents cboffer2 As System.Windows.Forms.CheckBox
    Friend WithEvents cboffer1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblo3 As System.Windows.Forms.Label
    Friend WithEvents lblo2 As System.Windows.Forms.Label
    Friend WithEvents lblo1 As System.Windows.Forms.Label
    Friend WithEvents cbbill As System.Windows.Forms.CheckBox
    Friend WithEvents lblbill As System.Windows.Forms.Label
    Friend WithEvents lblg3 As System.Windows.Forms.Label
    Friend WithEvents cbgreet1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblg1 As System.Windows.Forms.Label
    Friend WithEvents lblg2 As System.Windows.Forms.Label
    Friend WithEvents cbgreet3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbgreet2 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
