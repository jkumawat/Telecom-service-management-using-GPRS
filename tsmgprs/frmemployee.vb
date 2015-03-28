Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports Utilities.FTP

Public Class frmemployee
    Dim idx As String
    Dim empid As String
    Dim query, query1, str As String
    Dim path As String
    Public genie As AgentObjects.IAgentCtlCharacterEx
    Private Sub frmemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxAgent1.Characters.Load("merlin", "merlin.acs")
        genie = AxAgent1.Characters("merlin")
        path = ""
        query1 = "select emp_id as 'EmployeeId',fname as 'First Name',lname as 'Last Name',location as 'Allocated Area',address as 'Postal address',Role as 'Role Of Company',email as 'Email Id',contactno as 'Mobile Number',joindate as 'Registration Date' from employee"
        query = query1
        myconnect()
        getinfo()
        endis(False)
        lblcompany.Text = id3
        cbrole.SelectedIndex = 0
        cbarea.SelectedIndex = 0
        cmbsearch.SelectedIndex = 0
        btnsave.Enabled = False
        DataGridView1.Enabled = True
        bindgrid()
        DataGridView1.Focus()
        'data grid view to textbox
        If empid = "" Then
            btndelete.Enabled = False
            btnedit.Enabled = False
            Dim pat As String
            pat = Application.ExecutablePath()
            pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
            pbemp.Image = System.Drawing.Image.FromFile(pat & "emp.jpg")
        Else
            btndelete.Enabled = True
            cbrole.SelectedIndex = 0
            btnedit.Enabled = True
            btnclear.Enabled = True
            btncancel.Enabled = True
        End If
    End Sub
    Public Sub bindgrid()
        Dim da As New SqlDataAdapter(query, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "temp")
        DataGridView1.DataSource = ds.Tables("temp")
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        'date code to initialize
        Dim d As Date
        Dim str As String
        path = ""
        d = Date.Now()
        str = d.ToString()
        txtjoindate.Text = str

        btnattach.Enabled = True
        txtfname.Enabled = True
        txtlname.Enabled = True
        mtxtcontact.Enabled = True
        txtemail.Enabled = True
        txtjoindate.Enabled = True
        txtsearch.Enabled = True
        cbrole.Enabled = True
        txtaddress.Enabled = True
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnattach.Enabled = True
        btnsave.Enabled = True
        btnclear.Enabled = True
        btnattach.Enabled = True
        btnnew.Enabled = False
        cbarea.Enabled = True
        cbarea.SelectedIndex = 0
        cbrole.SelectedIndex = 0
        Dim pat As String
        pat = Application.ExecutablePath()
        pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
        pbemp.Image = System.Drawing.Image.FromFile(pat & "emp.jpg")
        Textclear()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'MsgBox(idx)
        If DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString() <> "" Then
            idx = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            empid = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            txtfname.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            txtlname.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            cbarea.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
            txtaddress.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
            cbrole.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
            txtemail.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
            mtxtcontact.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
            txtjoindate.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
            'Fetch Photo of customer
            If btnsave.Enabled = False Then
                table = "AccessEmp"
                column = "@emp_id"
                Dim result As Byte() = accessFileFromDatabase(table, column, idx, 0)
                Dim ms As MemoryStream = New MemoryStream(result, 0, result.Length)
                Dim im As Image = Image.FromStream(ms)
                pbemp.Image = im
            End If
            btnedit.Enabled = True
            btndelete.Enabled = True
        Else
            btnnew.Enabled = True
            btncancel.Enabled = True
            btnedit.Enabled = False
            btndelete.Enabled = False
            cbarea.SelectedIndex = 0
            cbrole.SelectedIndex = 0
            'Fetch default photo
            Dim pat As String
            pat = Application.ExecutablePath()
            pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
            pbemp.Image = System.Drawing.Image.FromFile(pat & "emp.jpg")

            txtfname.Text = ""
            txtlname.Text = ""
            txtaddress.Text = ""
            txtemail.Text = ""
            mtxtcontact.Text = ""
            txtjoindate.Text = ""
            'endis(False)
        End If

        If empid = "" Then
            btnedit.Enabled = False
            btndelete.Enabled = False
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'validation check
        Dim msg As String
        msg = ""
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.alphaCheck2(txtfname.Text)
        If ret = False Then
            msg = msg & "Invalid Fist Name" & Chr(13)
        End If

        ret = valid.alphaCheck2(txtlname.Text)
        If ret = False Then
            msg = msg & "Invalid Last Name" & Chr(13)
        End If

        ret = valid.emailcheck(txtemail.Text)
        If ret = False Then
            msg = msg & "Invalid Email" & Chr(13)
        End If

        ret = valid.numCheck(mtxtcontact.Text)
        If ret = False Then
            msg = msg & "Invalid Contact No." & Chr(13)
        End If

        If msg.Length > 0 Then
            MsgBox(msg, MsgBoxStyle.ApplicationModal, "Error")
            'genie.Show(True)
            'genie.MoveTo(200, 200)
            'genie.Speak(msg, "")
            'genie.Hide()
        End If
        btnattach.Enabled = False

        If path.Length = 0 Then
            MsgBox("Pls. select photo first", MsgBoxStyle.OkOnly)
        ElseIf msg.Length = 0 And path.Length > 0 Then
            cmd = New SqlCommand("insert into employee(fname,lname,address,role,email,contactno,location,joindate)values ('" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & cbrole.SelectedItem.ToString() & "','" & txtemail.Text & "','" & mtxtcontact.Text & "','" & cbarea.SelectedItem.ToString() & "','" & txtjoindate.Text & "' )")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader
            cmd = New SqlCommand("select max(emp_id) from employee")
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            While (dr.Read())
                empid = dr(0).ToString()
            End While
            dr.Close()

            MsgBox("Employee Id is" & empid)

            Dim filedialog As String
            filedialog = OpenFileDialog1.FileName
            OpenFileDialog1.Dispose()
            table = "SaveEmp"
            column = "@emp_id"
            'photo save code 
            Dim value As String = SavePhoto(table, column, filedialog, empid)
            'data entry
            Dim emp As String
            emp = "emp" & empid

            cmd = New SqlCommand("insert into login values ('" & emp & "','" & emp & "','" & cbrole.SelectedItem.ToString() & "')")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            MsgBox("Entry Successfully done!!Employee id is " & emp & " and Password " & emp)
            bindgrid()
            Textclear()
            btnnew.Enabled = True
            btnsave.Enabled = False
            endis(False)
            btnedit.Enabled = True
            btndelete.Enabled = True
            msg = ""
            fun()
        End If

    End Sub

    Public Sub Textclear()
        mtxtcontact.Text = ""
        txtemail.Text = ""
        txtfname.Text = ""
        ' txtjoindate.Text = ""
        txtlname.Text = ""
        txtsearch.Text = ""
        txtaddress.Text = ""
        cbrole.SelectedIndex = 0
        cbarea.SelectedIndex = 0
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Textclear()
        path = ""
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim dr As SqlDataReader
        Dim cnt As String
        Dim pat As String
        path = ""

        cnt = 0
        cmd = New SqlCommand("select emp_id from employee")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cnt = cnt + 1
        End While
        dr.Close()
        If cnt > 0 Then
            If (MsgBox("Are you sure to delete Entry from Employee where EmployeeId =" & idx & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                If cnt = 1 Then
                    cmd = New SqlCommand("truncate table employee")
                Else
                    cmd = New SqlCommand("delete from employee where emp_id='" & idx & "'")
                End If
                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                bindgrid()
                DataGridView1.Focus()
                btnnew.Enabled = True

                pat = Application.ExecutablePath()
                pat = pat.Substring(0, pat.LastIndexOf("\") + 1)
                pbemp.Image = System.Drawing.Image.FromFile(pat & "emp.jpg")
            End If
            fun()
        Else
            MsgBox("You can't delete ! Because there is no any entry?", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        btnedit.Visible = False
        btnupdate.Visible = True
        btnupdate.Enabled = True
        btnnew.Enabled = True
        btncancel.Enabled = True
        endis(True)
        btnsave.Enabled = False
        btnnew.Enabled = False
        btndelete.Enabled = False
    End Sub
    Public Sub endis(ByVal en As Boolean)
        txtfname.Enabled = en
        txtaddress.Enabled = en
        txtemail.Enabled = en
        txtjoindate.Enabled = en
        txtlname.Enabled = en
        mtxtcontact.Enabled = en
        cbarea.Enabled = en
        cbrole.Enabled = en
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Dim msg As String
        msg = ""
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.alphaCheck2(txtfname.Text)
        If ret = False Then
            msg = msg & "Invalid Fist Name" & Chr(13)
        End If

        ret = valid.alphaCheck2(txtlname.Text)
        If ret = False Then
            msg = msg & "Invalid Last Name" & Chr(13)
        End If

        ret = valid.emailcheck(txtemail.Text)
        If ret = False Then
            msg = msg & "Invalid Email" & Chr(13)
        End If

        ret = valid.numCheck(mtxtcontact.Text)
        If ret = False Then
            msg = msg & "Invalid Contact No." & Chr(13)
        End If

        If msg.Length > 0 Then
            MsgBox(msg, MsgBoxStyle.ApplicationModal, "Error")
        End If

        If msg.Length = 0 Then
            'data update
            cmd = New SqlCommand("update employee set fname='" & txtfname.Text & "',lname='" & txtlname.Text & "',address='" & txtaddress.Text & "',role='" & cbrole.SelectedItem.ToString() & "',email='" & txtemail.Text & "',contactno='" & mtxtcontact.Text & "',location='" & cbarea.SelectedItem.ToString() & "',joindate='" & txtjoindate.Text & "' where emp_id='" & idx & "'")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully done!")
            bindgrid()
            DataGridView1.Focus()
            btnnew.Enabled = True
            btnedit.Visible = True
            btnupdate.Visible = False
            btncancel.Enabled = True
            btnclear.Enabled = True
            btndelete.Enabled = True
            endis(False)
        End If

    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtlname.Focus()
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub cbrole_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            mtxtcontact.Focus()
        End If
    End Sub

    Private Sub mtxtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cbarea.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    cbrole.Focus()
        'End If
    End Sub

    Private Sub cbarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtjoindate.Focus()
        End If
    End Sub

    Private Sub txtjoindate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            btnattach.Focus()
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        str = ""
        If cmbsearch.SelectedIndex = 1 Then
            str = "contactno"
        ElseIf cmbsearch.SelectedIndex = 2 Then
            str = "fname"
        ElseIf cmbsearch.SelectedIndex = 3 Then
            str = "area"
        End If
        If cmbsearch.SelectedIndex = 1 Then
            Dim valid As New validclass
            Dim ret As Boolean
            ret = valid.numCheck(txtsearch.Text)
            If ret = False Or txtsearch.Text.Length <> 10 Then
                MsgBox("Invalid Telephone no")
            Else
                query = query1 & " where " & str & " = " & txtsearch.Text
            End If
        ElseIf cmbsearch.SelectedIndex = 0 Then
            query = query1
        Else
            query = query1 & " where " & str & " like " & "'" & txtsearch.Text & "%'"
        End If

        Dim da As New SqlDataAdapter(query, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "temp")
        DataGridView1.DataSource = ds.Tables("temp")
        txtsearch.Text = ""
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        If empid = "" Then
            btndelete.Enabled = False
            btnedit.Enabled = False
        Else
            btnedit.Enabled = True
            btnupdate.Visible = False
            btndelete.Enabled = True
            btnnew.Enabled = True
        End If
        btnsave.Enabled = False
        btncancel.Enabled = True
        endis(False)
        bindgrid()
        DataGridView1.Focus()
    End Sub

    Private Sub btnattach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        pbemp.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub cmbsearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtsearch.Enabled = True
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbsearch.SelectedIndex = 0 Then
            txtsearch.Enabled = False
        Else
            txtsearch.Enabled = True
        End If
    End Sub

    Private Sub fun()
        Dim bytes As Byte()
        Dim pat As String
        pat = Application.ExecutablePath()
        pat = pat.Substring(0, pat.LastIndexOf("\")) & "\employee.txt"
        If System.IO.File.Exists(pat) = True Then
            System.IO.File.Delete(pat)
        End If
        Dim dr As SqlDataReader
        Dim str2 As String
        str2 = ""
        cmd = New SqlCommand("select emp_id from employee")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        While dr.Read
            str2 = "emp" & dr(0) & "@emp" & dr(0)
            Dim file_stream As New FileStream(pat, FileMode.Append, FileAccess.Write, FileShare.Write)
            bytes = New UTF8Encoding().GetBytes(str2 & vbNewLine)
            file_stream.Write(bytes, 0, bytes.Length)
            file_stream.Flush()
            file_stream.Close()
        End While
        Dim ftp = New FTPclient("www.gapsap.info", uname, passwd)
        ftp.CurrentDirectory = "/public_html/telecom/"

        ftp.Upload(pat, "employee.txt")

        MsgBox(pat & " ---employee.txt")
        
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AxAgent1_ActivateInput(ByVal sender As System.Object, ByVal e As AxAgentObjects._AgentEvents_ActivateInputEvent) Handles AxAgent1.ActivateInput

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub txtlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtjoindate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjoindate.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub cbrole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrole.SelectedIndexChanged

    End Sub

    Private Sub cbarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbarea.SelectedIndexChanged

    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub mtxtcontact_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtxtcontact.MaskInputRejected

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class