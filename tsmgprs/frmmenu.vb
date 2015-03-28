

Public Class frmmenu

    Private Sub NewCustomerEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustomerEntryToolStripMenuItem.Click
        Dim cust As New Frmcust
        cust.ShowDialog()
    End Sub

    Private Sub NewEmployeeEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEmployeeEntryToolStripMenuItem.Click
        Dim emp As New frmemployee
        emp.ShowDialog()
    End Sub

    Private Sub NewComplainEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim comp As New frmcomplain
        comp.ShowDialog()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("Calc.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub CalenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalenderToolStripMenuItem.Click
        'MonthCalendar1.Visible = True
        Dim frmcal As New frmcalender
        frmcal.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TextBox1.Text = MonthCalendar1.SetDate()
    End Sub


    'Private Sub frmmenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    Dim temp As New frmtemp
    '    temp.Close()
    '    Dim frm As New frmmenu
    '    frm.Close()
    'End Sub

    'Private Sub frmmenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Dim temp As New frmtemp
    '    temp.Close()
    '    Dim frm As New frmmenu
    '    frm.Close()
    'End Sub

    'Private Sub frmmenu_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
    '    Dim temp As New frmtemp
    '    temp.Close()
    '    Dim frm As New frmmenu
    '    frm.Close()
    'End Sub

    Private Sub frmmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sesrole <> "Admin" Then
            NewEmployeeEntryToolStripMenuItem.Enabled = False
            AdvertisingToolStripMenuItem.Enabled = False
            ReportsToolStripMenuItem.Enabled = False
        Else
            Dim temp As New frmtemp
            temp.Show()
        End If
    End Sub

    Private Sub ComplainEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplainEntryToolStripMenuItem.Click
        Dim comp As New frmcomplain
        comp.ShowDialog()
    End Sub

    Private Sub SmsForSpecialOfferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsForSpecialOfferToolStripMenuItem.Click
        id = 1
        Dim temp As New adverticement
        temp.ShowDialog()

    End Sub

    Private Sub BillingReminderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingReminderToolStripMenuItem.Click
        id = 2
        Dim temp As New adverticement
        temp.ShowDialog()
    End Sub

    Private Sub HolidayGreetingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayGreetingsToolStripMenuItem.Click
        id = 3
        Dim temp As New adverticement
        temp.ShowDialog()
    End Sub

    Private Sub MonthlyBillingGenerationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyBillingGenerationToolStripMenuItem.Click
        Dim bill As New frmbillgenerate
        bill.ShowDialog()

    End Sub

    Private Sub RecieptEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecieptEntryToolStripMenuItem.Click
        Dim reciept As New frmrecipent
        reciept.ShowDialog()
    End Sub


    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim frmpass As New frmpassword
        frmpass.ShowDialog()
    End Sub

    Private Sub WebExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebExplorerToolStripMenuItem.Click
        Dim frmex As New frmexplorer
        frmex.ShowDialog()
    End Sub

    Private Sub newcustconmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newcustconmenu.Click
        Dim cust As New Frmcust
        cust.ShowDialog()
    End Sub

    Private Sub newempconmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newempconmenu.Click
        Dim emp As New frmemployee
        emp.ShowDialog()
    End Sub

    Private Sub complainconmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles complainconmenu.Click
        Dim comp As New frmcomplain
        comp.ShowDialog()
    End Sub

    Private Sub changepassconmenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepassconmenuItem1.Click
        Dim frmpass As New frmpassword
        frmpass.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Do you want to logout?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            Me.Hide()
            Dim frmlogin As New frmlogin
            frmlogin.ShowDialog()
        End If
    End Sub

    Private Sub DailyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyToolStripMenuItem.Click
        Dim frmcr As New frmdailyreport
        frmcr.ShowDialog()
    End Sub

    Private Sub CustomerReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportsToolStripMenuItem.Click
        Dim frmcustr As New frmcustreport
        frmcustr.ShowDialog()
    End Sub


    Private Sub BillingReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingReportsToolStripMenuItem.Click

    End Sub

    Private Sub CustomerBillingDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerBillingDetailsToolStripMenuItem.Click
        'Dim billing As New frmbillingdetails
        'billing.ShowDialog()
    End Sub

    'Private Sub ComplainReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplainReportsToolStripMenuItem.Click
    '    Dim temp As New frmtemp
    '    temp.ShowDialog()
    'End Sub

    Private Sub ComplainDistributionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplainDistributionToolStripMenuItem.Click
        Dim frmcr As New frmcomplaindistribution
        frmcr.ShowDialog()
    End Sub
End Class