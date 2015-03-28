Imports System.Data.SqlClient
Imports System.IO
Public Class frmcomplain
    Dim d As Date
    Dim str, str1, str2 As String
    Public genie As AgentObjects.IAgentCtlCharacterEx
    Private Sub frmcomplain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxAgent1.Characters.Load("merlin", "merlin.acs")
        genie = AxAgent1.Characters("merlin")
        myconnect()
        getinfo()
        lblcompany.Text = id3
        d = Date.Now.ToLocalTime
        str = d.ToString
        str1 = str.Substring(0, str.IndexOf(" "))
        str2 = str.Substring(str.IndexOf(" ") + 1)
        'MsgBox(str1)
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from complain")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            cmd = New SqlCommand("select max(compno) from complain")
            cmd.Connection = cn
            dr.Close()
            dr = cmd.ExecuteReader()
            'Dim t As Integer
            If dr.HasRows Then
                dr.Read()
                lblcmpno.Text = Integer.Parse(dr(0).ToString) + 1
            End If
        Else
            lblcmpno.Text = "100"
        End If
        dr.Close()
        cbpriority.SelectedIndex = 0
        cbtype.SelectedIndex = 0

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim strpriority, strtype As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from complain where phoneno='" & txtsearch.Text & "' and status='unsolved'")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            MsgBox("Comlian for this number is already registered")
        Else
            dr.Close()
            strpriority = cbpriority.SelectedItem
            strtype = cbtype.SelectedItem
            Dim datestr As String
            d = Date.Now.ToLocalTime
            datestr = d.ToShortDateString
            datestr = d.Year & "-" & d.Month() & "-" & d.Day
            cmd = New SqlCommand("insert into complain(comptname,address,phoneno,area,probtype,priority,compdate,status) values ('" & txtname.Text & "','" & txtadd.Text & "','" & txtsearch.Text & "','" & txtarea.Text & "','" & strtype & "','" & strpriority & "','" & datestr & "','unsolved')")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            MsgBox("complain Entry done Successfuly!!")
            cmd = New SqlCommand("select max(compno) from complain")
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            dr.Read()
            lblcmpno.Text = Integer.Parse(dr(0).ToString) + 1
            dr.Close()
            If MsgBox("Do you want to send it now?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                address = txtadd.Text
                area = txtarea.Text
                phoneno = txtsearch.Text
                Name = txtname.Text
                Dim sms As New frmsms
                Me.Hide()
                sms.ShowDialog()
            End If
            clear()
            btnsave.Enabled = False
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim dr As SqlDataReader
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.numCheck(txtsearch.Text)
        If ret = False Or txtsearch.Text.Length <> 7 Then
            ' MsgBox("Enter Correct Telephone No.")
            genie.Show(True)
            genie.MoveTo(200, 200)
            genie.Speak("Enter Correct Telephone No.", "")
            genie.Hide()
        Else
            cmd = New SqlCommand("select * from customer where telephone='" & txtsearch.Text & "'")
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txtname.Text = dr(1).ToString
                txtadd.Text = dr(5).ToString
                txtarea.Text = dr(6).ToString
                txtcontact.Text = dr(15).ToString
                txtemail.Text = dr(10).ToString
                txtpurpose.Text = dr(12).ToString
                txttelepco.Text = dr(13).ToString
                txtdate.Text = str1
                txttime.Text = str2

                cbpriority.Enabled = True
                cbtype.Enabled = True
                btnsave.Enabled = True
            Else
                'MsgBox("Record Not Found !! ")
                genie.Show(True)
                genie.MoveTo(200, 200)
                genie.Speak("Record Not Found !! ", "")
                genie.Hide()
                clear()
                btnsave.Enabled = False
            End If
            dr.Close()
        End If
    End Sub

    Private Sub txtsearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.GotFocus
        txtsearch.Text = ""
    End Sub

    Public Sub clear()
        txtadd.Text = ""
        txtarea.Text = ""
        txtdate.Text = ""
        txtcontact.Text = ""
        txttime.Text = ""
        txtemail.Text = ""
        txtname.Text = ""
        txtpurpose.Text = ""
        txttelepco.Text = ""
        txtsearch.Text = "Phone No"
        cbpriority.SelectedIndex = 0
        cbtype.SelectedIndex = 0
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clear()
        btnsave.Enabled = False
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Hide()
    End Sub

    
   
 
End Class