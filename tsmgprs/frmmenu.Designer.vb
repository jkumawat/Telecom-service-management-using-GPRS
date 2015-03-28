<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewCustomerEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewEmployeeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplainEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonthlyBillingGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecieptEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerBillingDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvertisingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SmsForSpecialOfferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillingReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HolidayGreetingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttandanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WebExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillingReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.newcustconmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.newempconmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.complainconmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.changepassconmenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplainDistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.ToolStripMenuItem1, Me.ComplainDistributionToolStripMenuItem, Me.AdvertisingToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.UtilityToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(937, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerEntryToolStripMenuItem, Me.NewEmployeeEntryToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "&Master"
        '
        'NewCustomerEntryToolStripMenuItem
        '
        Me.NewCustomerEntryToolStripMenuItem.Name = "NewCustomerEntryToolStripMenuItem"
        Me.NewCustomerEntryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.NewCustomerEntryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.NewCustomerEntryToolStripMenuItem.Text = "New &Customer Entry"
        '
        'NewEmployeeEntryToolStripMenuItem
        '
        Me.NewEmployeeEntryToolStripMenuItem.Name = "NewEmployeeEntryToolStripMenuItem"
        Me.NewEmployeeEntryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.NewEmployeeEntryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.NewEmployeeEntryToolStripMenuItem.Text = "New &Employee Entry"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplainEntryToolStripMenuItem, Me.MonthlyBillingGenerationToolStripMenuItem, Me.RecieptEntryToolStripMenuItem, Me.CustomerBillingDetailsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(81, 20)
        Me.ToolStripMenuItem1.Text = "Transaction"
        '
        'ComplainEntryToolStripMenuItem
        '
        Me.ComplainEntryToolStripMenuItem.Name = "ComplainEntryToolStripMenuItem"
        Me.ComplainEntryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ComplainEntryToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ComplainEntryToolStripMenuItem.Text = "Complain Entry"
        '
        'MonthlyBillingGenerationToolStripMenuItem
        '
        Me.MonthlyBillingGenerationToolStripMenuItem.Name = "MonthlyBillingGenerationToolStripMenuItem"
        Me.MonthlyBillingGenerationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.MonthlyBillingGenerationToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.MonthlyBillingGenerationToolStripMenuItem.Text = "Monthly Billing Generation"
        '
        'RecieptEntryToolStripMenuItem
        '
        Me.RecieptEntryToolStripMenuItem.Name = "RecieptEntryToolStripMenuItem"
        Me.RecieptEntryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.RecieptEntryToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.RecieptEntryToolStripMenuItem.Text = "Reciept Entry"
        '
        'CustomerBillingDetailsToolStripMenuItem
        '
        Me.CustomerBillingDetailsToolStripMenuItem.Name = "CustomerBillingDetailsToolStripMenuItem"
        Me.CustomerBillingDetailsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.CustomerBillingDetailsToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.CustomerBillingDetailsToolStripMenuItem.Text = "Customer Billing Details"
        '
        'AdvertisingToolStripMenuItem
        '
        Me.AdvertisingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmsForSpecialOfferToolStripMenuItem, Me.BillingReminderToolStripMenuItem, Me.HolidayGreetingsToolStripMenuItem})
        Me.AdvertisingToolStripMenuItem.Name = "AdvertisingToolStripMenuItem"
        Me.AdvertisingToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AdvertisingToolStripMenuItem.Text = "SMS Advertising"
        '
        'SmsForSpecialOfferToolStripMenuItem
        '
        Me.SmsForSpecialOfferToolStripMenuItem.Name = "SmsForSpecialOfferToolStripMenuItem"
        Me.SmsForSpecialOfferToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SmsForSpecialOfferToolStripMenuItem.Text = "Sms For Special Offer"
        '
        'BillingReminderToolStripMenuItem
        '
        Me.BillingReminderToolStripMenuItem.Name = "BillingReminderToolStripMenuItem"
        Me.BillingReminderToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.BillingReminderToolStripMenuItem.Text = "Billing Reminder"
        '
        'HolidayGreetingsToolStripMenuItem
        '
        Me.HolidayGreetingsToolStripMenuItem.Name = "HolidayGreetingsToolStripMenuItem"
        Me.HolidayGreetingsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.HolidayGreetingsToolStripMenuItem.Text = "Holiday Greetings"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.AttandanceToolStripMenuItem, Me.WebExplorerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools and Maintanance"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'AttandanceToolStripMenuItem
        '
        Me.AttandanceToolStripMenuItem.Name = "AttandanceToolStripMenuItem"
        Me.AttandanceToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AttandanceToolStripMenuItem.Text = "Attandance"
        '
        'WebExplorerToolStripMenuItem
        '
        Me.WebExplorerToolStripMenuItem.Name = "WebExplorerToolStripMenuItem"
        Me.WebExplorerToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.WebExplorerToolStripMenuItem.Text = "web explorer"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.CalenderToolStripMenuItem})
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "&Utility"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'CalenderToolStripMenuItem
        '
        Me.CalenderToolStripMenuItem.Name = "CalenderToolStripMenuItem"
        Me.CalenderToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CalenderToolStripMenuItem.Text = "Calender"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyToolStripMenuItem, Me.CustomerReportsToolStripMenuItem, Me.BillingReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'DailyToolStripMenuItem
        '
        Me.DailyToolStripMenuItem.Name = "DailyToolStripMenuItem"
        Me.DailyToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DailyToolStripMenuItem.Text = "&Complain Reports"
        '
        'CustomerReportsToolStripMenuItem
        '
        Me.CustomerReportsToolStripMenuItem.Name = "CustomerReportsToolStripMenuItem"
        Me.CustomerReportsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CustomerReportsToolStripMenuItem.Text = "Customer Reports"
        '
        'BillingReportsToolStripMenuItem
        '
        Me.BillingReportsToolStripMenuItem.Name = "BillingReportsToolStripMenuItem"
        Me.BillingReportsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BillingReportsToolStripMenuItem.Text = "Billing Reports"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newcustconmenu, Me.newempconmenu, Me.complainconmenu, Me.changepassconmenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 92)
        '
        'newcustconmenu
        '
        Me.newcustconmenu.Name = "newcustconmenu"
        Me.newcustconmenu.Size = New System.Drawing.Size(183, 22)
        Me.newcustconmenu.Text = "New Customer Entry"
        '
        'newempconmenu
        '
        Me.newempconmenu.Name = "newempconmenu"
        Me.newempconmenu.Size = New System.Drawing.Size(183, 22)
        Me.newempconmenu.Text = "New Employee Entry"
        '
        'complainconmenu
        '
        Me.complainconmenu.Name = "complainconmenu"
        Me.complainconmenu.Size = New System.Drawing.Size(183, 22)
        Me.complainconmenu.Text = "Complain Entry"
        '
        'changepassconmenuItem1
        '
        Me.changepassconmenuItem1.Name = "changepassconmenuItem1"
        Me.changepassconmenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.changepassconmenuItem1.Text = "Change Password"
        '
        'ComplainDistributionToolStripMenuItem
        '
        Me.ComplainDistributionToolStripMenuItem.Name = "ComplainDistributionToolStripMenuItem"
        Me.ComplainDistributionToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.ComplainDistributionToolStripMenuItem.Text = "Complain Distribution"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(937, 537)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenu"
        Me.Text = "TeleCom Service Management Using GPRS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCustomerEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewEmployeeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplainEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyBillingGenerationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecieptEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvertisingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmsForSpecialOfferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingReminderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidayGreetingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerBillingDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttandanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents newcustconmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newempconmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents complainconmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents changepassconmenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplainDistributionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
