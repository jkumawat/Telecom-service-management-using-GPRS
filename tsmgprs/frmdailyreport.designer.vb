<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdailyreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdailyreport))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rbdaily = New System.Windows.Forms.RadioButton
        Me.rbmonthly = New System.Windows.Forms.RadioButton
        Me.rbannual = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cballrecords = New System.Windows.Forms.CheckBox
        Me.lblarea1 = New System.Windows.Forms.Label
        Me.cmbarea = New System.Windows.Forms.ComboBox
        Me.cbarea = New System.Windows.Forms.CheckBox
        Me.dtp2 = New System.Windows.Forms.DateTimePicker
        Me.lblto = New System.Windows.Forms.Label
        Me.btngenerate = New System.Windows.Forms.Button
        Me.lbldate1 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.lblmode = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(12, 139)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 402)
        Me.Panel2.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(632, 400)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'rbdaily
        '
        Me.rbdaily.AutoSize = True
        Me.rbdaily.Checked = True
        Me.rbdaily.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbdaily.ForeColor = System.Drawing.Color.Black
        Me.rbdaily.Location = New System.Drawing.Point(25, 22)
        Me.rbdaily.Name = "rbdaily"
        Me.rbdaily.Size = New System.Drawing.Size(54, 17)
        Me.rbdaily.TabIndex = 0
        Me.rbdaily.TabStop = True
        Me.rbdaily.Text = "Daily"
        Me.rbdaily.UseVisualStyleBackColor = True
        '
        'rbmonthly
        '
        Me.rbmonthly.AutoSize = True
        Me.rbmonthly.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbmonthly.ForeColor = System.Drawing.Color.Black
        Me.rbmonthly.Location = New System.Drawing.Point(25, 54)
        Me.rbmonthly.Name = "rbmonthly"
        Me.rbmonthly.Size = New System.Drawing.Size(69, 17)
        Me.rbmonthly.TabIndex = 1
        Me.rbmonthly.Text = "Monthly"
        Me.rbmonthly.UseVisualStyleBackColor = True
        '
        'rbannual
        '
        Me.rbannual.AutoSize = True
        Me.rbannual.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbannual.ForeColor = System.Drawing.Color.Black
        Me.rbannual.Location = New System.Drawing.Point(25, 86)
        Me.rbannual.Name = "rbannual"
        Me.rbannual.Size = New System.Drawing.Size(64, 17)
        Me.rbannual.TabIndex = 2
        Me.rbannual.Text = "Annual"
        Me.rbannual.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbannual)
        Me.GroupBox1.Controls.Add(Me.rbdaily)
        Me.GroupBox1.Controls.Add(Me.rbmonthly)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Report Mode"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cballrecords)
        Me.Panel1.Controls.Add(Me.lblarea1)
        Me.Panel1.Controls.Add(Me.cmbarea)
        Me.Panel1.Controls.Add(Me.cbarea)
        Me.Panel1.Controls.Add(Me.dtp2)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.btngenerate)
        Me.Panel1.Controls.Add(Me.lbldate1)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.lblmode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(169, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 110)
        Me.Panel1.TabIndex = 4
        '
        'cballrecords
        '
        Me.cballrecords.AutoSize = True
        Me.cballrecords.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cballrecords.ForeColor = System.Drawing.Color.Black
        Me.cballrecords.Location = New System.Drawing.Point(182, 4)
        Me.cballrecords.Name = "cballrecords"
        Me.cballrecords.Size = New System.Drawing.Size(90, 17)
        Me.cballrecords.TabIndex = 9
        Me.cballrecords.Text = "All Records"
        Me.cballrecords.UseVisualStyleBackColor = True
        '
        'lblarea1
        '
        Me.lblarea1.AutoSize = True
        Me.lblarea1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblarea1.ForeColor = System.Drawing.Color.Black
        Me.lblarea1.Location = New System.Drawing.Point(154, 57)
        Me.lblarea1.Name = "lblarea1"
        Me.lblarea1.Size = New System.Drawing.Size(78, 13)
        Me.lblarea1.TabIndex = 8
        Me.lblarea1.Text = "Select Area:"
        Me.lblarea1.Visible = False
        '
        'cmbarea
        '
        Me.cmbarea.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cmbarea.ForeColor = System.Drawing.Color.Black
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Items.AddRange(New Object() {"Adajan", "Athwagate", "Citilight", "Nanpura", "Rander", "Palanpur patia", "Parvat patia", "Piplod", "Varacha", "Udhna"})
        Me.cmbarea.Location = New System.Drawing.Point(234, 52)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(121, 21)
        Me.cmbarea.TabIndex = 7
        Me.cmbarea.Visible = False
        '
        'cbarea
        '
        Me.cbarea.AutoSize = True
        Me.cbarea.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cbarea.ForeColor = System.Drawing.Color.Black
        Me.cbarea.Location = New System.Drawing.Point(16, 54)
        Me.cbarea.Name = "cbarea"
        Me.cbarea.Size = New System.Drawing.Size(126, 17)
        Me.cbarea.TabIndex = 6
        Me.cbarea.Text = "Area Wise Report"
        Me.cbarea.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "MM-dd-yyyy"
        Me.dtp2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(280, 27)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(138, 21)
        Me.dtp2.TabIndex = 5
        Me.dtp2.Visible = False
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblto.ForeColor = System.Drawing.Color.Black
        Me.lblto.Location = New System.Drawing.Point(255, 31)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(21, 13)
        Me.lblto.TabIndex = 4
        Me.lblto.Text = "To"
        Me.lblto.Visible = False
        '
        'btngenerate
        '
        Me.btngenerate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btngenerate.ForeColor = System.Drawing.Color.Black
        Me.btngenerate.Location = New System.Drawing.Point(16, 78)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(123, 23)
        Me.btngenerate.TabIndex = 3
        Me.btngenerate.Text = "Generate Report!"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'lbldate1
        '
        Me.lbldate1.AutoSize = True
        Me.lbldate1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lbldate1.ForeColor = System.Drawing.Color.Black
        Me.lbldate1.Location = New System.Drawing.Point(13, 30)
        Me.lbldate1.Name = "lbldate1"
        Me.lbldate1.Size = New System.Drawing.Size(78, 13)
        Me.lbldate1.TabIndex = 1
        Me.lbldate1.Text = "Select Date:"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "MM-dd-yyyy"
        Me.dtp1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(94, 27)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(144, 21)
        Me.dtp1.TabIndex = 2
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblmode.ForeColor = System.Drawing.Color.Black
        Me.lblmode.Location = New System.Drawing.Point(126, 4)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(0, 13)
        Me.lblmode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your  Selected  Mode:"
        '
        'frmdailyreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(658, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdailyreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DailyReport"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rbdaily As System.Windows.Forms.RadioButton
    Friend WithEvents rbmonthly As System.Windows.Forms.RadioButton
    Friend WithEvents rbannual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents lbldate1 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblarea1 As System.Windows.Forms.Label
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents cbarea As System.Windows.Forms.CheckBox
    Friend WithEvents cballrecords As System.Windows.Forms.CheckBox
End Class
