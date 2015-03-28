Imports System.Data.SqlClient
Imports System.IO
Public Class Frmcust
    Dim gender, purpose, facility, facility1, tele_pco As String
    Dim flag, flag1 As Integer
    Dim str, query, query1, path As String
    Public genie As AgentObjects.IAgentCtlCharacterEx
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtname.Text = ""
        txtnominee.Text = ""
        txtpan.Text = ""
        mtxttele.Text = ""
        txtadd1.Text = ""
        txtadd2.Text = ""
        cmbarea.SelectedIndex = 0
        txtbadd1.Text = ""
        txtbadd2.Text = ""
        mtxtcontact.Text = ""
        cmbbarea.SelectedIndex = 0

        rbmale.Checked = True
        txtemail.Text = ""
        rbresident.Checked = True
        rbtele.Checked = True
        chksame.Checked = False
        chkstd.Checked = False
        chkisd.Checked = False
        chkconference.Checked = False
        chkhotline.Checked = False

        btnnew.Enabled = True
        btncancel.Enabled = True
        cmbarea.SelectedIndex = 0
        cmbbarea.SelectedIndex = 0
        endis(False)
        DataGridView1.Enabled = True
        btnattach.SendToBack()

        'txtname.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        btnedit.Visible = False
        btnupdate.Visible = True
        btnupdate.Enabled = True
        btnnew.Enabled = True
        btncancel.Enabled = True
        btnview.Visible = False
        btnattach.Visible = True
        btnattach.Enabled = True
        btndelete.Enabled = False
        DataGridView1.Enabled = False
        us = 1
        endis(True)
        'mtxttele.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click

        If chksame.Checked = True Then
            txtbadd1.Text = txtadd1.Text
            txtbadd2.Text = txtadd2.Text
            cmbbarea.Text = cmbarea.Text
        End If
        txtname.Text = ""
        txtpan.Text = ""
        txtadd1.Text = ""
        txtadd2.Text = ""
        txtbadd1.Text = ""
        txtbadd2.Text = ""
        txtnominee.Text = ""
        txtemail.Text = ""
        mtxttele.Text = ""
        mtxtcontact.Text = ""
        path = ""
        cmbarea.SelectedIndex = 0
        cmbbarea.SelectedIndex = 0
        chksame.Checked = False
        btnnew.Enabled = False
        btnedit.Enabled = False
        btndelete.Enabled = False
        btnsave.Enabled = True
        btnclear.Enabled = True
        btnbrowse.Enabled = True

        endis(True)

        Dim pat As String
        pat = Application.ExecutablePath()
        pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
        pbphoto.Image = System.Drawing.Image.FromFile(pat & "default.jpg")
        'mtxttele.Enabled = True
        rbmale.Checked = True
        rbtele.Checked = True
        rbresident.Checked = True
        chkstd.Checked = False
        chkisd.Checked = False
        chkhotline.Checked = False
        chkconference.Checked = False
        DataGridView1.Enabled = False
        btnview.Visible = False
        btnattach.Visible = True
        btnattach.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        us = 0
        Dim msg As String
        msg = ""
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.alphaCheck2(txtname.Text)
        If ret = False Then
            msg = msg & "Invalid Name," & Chr(13)
        End If

        ret = valid.alphaCheck2(txtnominee.Text)
        If ret = False Then
            msg = msg & "Invalid Joint Applicant Name," & Chr(13)
        End If

        ret = valid.alphanumCheck(txtpan.Text)
        If ret = False Or txtpan.Text.Length <> 10 Then
            msg = msg & "Invalid Pan No.," & Chr(13)
            

        End If

        ret = valid.numCheck(mtxttele.Text)
        If ret = False Then
            msg = msg & "Invalid Telephone No.," & Chr(13)
        End If


        ret = valid.spacecheck(txtemail.Text)
        If ret = True Then
            txtemail.Text = ""
        End If

        If cmbarea.SelectedIndex = 0 Or cmbbarea.SelectedIndex = 0 Then
            msg = msg & "Invalid Area," & Chr(13)
        End If

        If txtemail.Text.Length <> 0 Then
            ret = valid.emailcheck(txtemail.Text)
            If ret = False Then
                msg = msg & "Invalid Email Id," & Chr(13)
            End If
        End If

        If msg.Length > 0 Then
            ' MsgBox(msg, MsgBoxStyle.ApplicationModal, "Error")
            genie.Show(True)
            genie.MoveTo(200, 200)
            genie.Speak(msg, "")
            genie.Hide()
        End If


        If path.Length = 0 Or flag1 = 1 Then
            MsgBox("Pls. select photo first", MsgBoxStyle.OkOnly)
        ElseIf msg.Length = 0 And path.Length > 0 Then
            myconnect()
            path = ""
            Dim postadd As String
            postadd = txtadd1.Text & "|" & txtadd2.Text
            Dim billadd As String
            billadd = txtbadd1.Text & "|" & txtbadd2.Text
            Dim postarea As String
            postarea = cmbarea.SelectedItem
            Dim billarea As String
            billarea = cmbbarea.SelectedItem

            'for gender
            If rbmale.Checked = True Then
                gender = "male"
            Else
                gender = "female"
            End If

            'for facility
            facility = ""

            If chkstd.Checked = True Then
                facility = facility & "|STD"
            End If
            If chkhotline.Checked = True Then
                facility = facility & "|HOTLINE"
            End If
            If chkisd.Checked = True Then
                facility = facility & "|ISD"
            End If
            If chkconference.Checked = True Then
                facility = facility & "|CONFERENCE"
            End If
            facility = facility & "|"
            facility = facility.Substring(1)


            'for purpose
            If rbbusiness.Checked = True Then
                purpose = "BUSINESS"
            Else
                purpose = "RESIDENT"
            End If

            'tele_pco
            If rbtele.Checked = True Then
                tele_pco = "TELEPHONE"
            Else
                tele_pco = "PCO"
            End If
            
            Dim d As Date
            Dim str, str1 As String
            'd = Date.Now.ToLocalTime
            'str = d.ToString
            'str1 = str.Substring(0, str.IndexOf(" "))
            d = Date.Now.ToLocalTime
            str = d.ToShortDateString
            str1 = d.Year & "-" & d.Month() & "-" & d.Day

            cmd = New SqlCommand("insert into customer(custname,custnominee,pan,telephone,postadd,postarea,billadd,billarea,gender,email,facility,purpose,tele_pco,regdate,mobile) values('" & txtname.Text & "','" & txtnominee.Text & "','" & txtpan.Text & "','" & mtxttele.Text & "','" & postadd & "','" & postarea & "','" & billadd & "','" & billarea & "','" & gender & "','" & txtemail.Text & "','" & facility & "','" & purpose & "','" & tele_pco & "','" & str1 & "','" & mtxtcontact.Text & "')")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            'id fetched...
            Dim dr As SqlDataReader
            cmd = New SqlCommand("select max(cust_id) from customer")
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            While (dr.Read())
                id = dr(0).ToString()
            End While
            dr.Close()

            bindgrid()
            btnsave.Enabled = False
            endis(False)
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnnew.Enabled = True
            Dim filedialog As String
            filedialog = OpenFileDialog1.FileName
            OpenFileDialog1.Dispose()
            'photo save code 
            cmd = New SqlCommand("insert into cust_photo(cust_id)values('" & id & "')", cn)
            cmd.ExecuteNonQuery()
            table = "SaveCust"
            column = "@cust_id"
            Dim value As String = SavePhoto(table, column, filedialog, id)

            If value.Length > 0 Then
                If MsgBox("Successfully Entry done!! Your Customer id is : " & id & ". Now attach required papers", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    btnattach.Visible = True
                    btnview.Visible = False
                    btnattach.Enabled = True
                    btnbrowse.Enabled = False
                    DataGridView1.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub cmbbarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbbarea.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mtxtcontact.Focus()
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnominee.Focus()
        End If
    End Sub

    Private Sub txtnominee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnominee.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpan.Focus()
        End If
    End Sub

    Private Sub txtpan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtadd1.Focus()
        End If
    End Sub
    Private Sub txtadd1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtadd2.Focus()
        End If
    End Sub

    Private Sub txtadd2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbarea.Focus()
        End If
    End Sub

    Private Sub txtbadd1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbadd1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtbadd2.Focus()
        End If
    End Sub
    Private Sub cmbarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbarea.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chksame.Focus()
        End If
    End Sub

    Private Sub chksame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksame.CheckedChanged
        If chksame.Checked = True Then
            txtbadd1.Text = txtadd1.Text
            txtbadd2.Text = txtadd2.Text
            cmbbarea.SelectedIndex = cmbarea.SelectedIndex
            mtxtcontact.Focus()
        Else
            txtbadd1.Text = ""
            txtbadd2.Text = ""
            cmbbarea.SelectedIndex = 0
            txtbadd1.Focus()
        End If
    End Sub

    Private Sub txtbadd2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbadd2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbbarea.Focus()
        End If
    End Sub

    Private Sub mtxttele_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxttele.KeyPress
        If Asc(e.KeyChar) = 13 Then
            gbgender.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnbrowse.Focus()
        End If
    End Sub

    Private Sub mtxtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtcontact.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mtxttele.Focus()
        End If
    End Sub

    Private Sub Frmcust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxAgent1.Characters.Load("merlin", "merlin.acs")
        genie = AxAgent1.Characters("merlin")
        flag1 = 1
        path = ""
        query1 = "select cust_id as 'Customer Id',custname as 'Customer Name',custnominee as 'Nominee Of Customer',pan as 'Pancard Number',telephone as 'Allocated phoneno',postadd as 'Postal address',postarea as 'Postal Area',billadd as 'Billing Address',billarea as 'Billing Area',mobile as 'Mobile Number',gender as 'Gender',email as 'Email Id',facility as 'Facility',purpose as 'Purpose',tele_pco as'Telephone/PCO',regdate as 'Registration Date'  from customer"
        query = query1
        myconnect()
        getinfo()
        lblcompany.Text = id3
        cmbarea.SelectedIndex = 0
        cmbbarea.SelectedIndex = 0
        cmbsearch.SelectedIndex = 0
        btnnew.Enabled = True
        btnedit.Enabled = True
        btndelete.Enabled = True
        btncancel.Enabled = True
        endis(False)
        btnattach.Visible = False
        btnview.Visible = True
        DataGridView1.Enabled = True
        bindgrid()
        'MsgBox(id1)
        If id1 = "" Then
            btndelete.Enabled = False
            btnedit.Enabled = False
            btnview.Enabled = False
            btnattach.Enabled = False
            Dim pat As String
            pat = Application.ExecutablePath()
            pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
            pbphoto.Image = System.Drawing.Image.FromFile(pat & "default.jpg")
        End If
    End Sub

    Private Sub btnattach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnattach.Click
        'Me.Close()
        btnattach.Visible = False
        btnview.Visible = True
        Dim atch As New frmattach
        atch.ShowDialog()

    End Sub

    Public Sub bindgrid()
        Dim da As New SqlDataAdapter("select cust_id as 'Customer Id',custname as 'Customer Name',custnominee as 'Nominee Of Customer',pan as 'Pancard Number',telephone as 'Allocated phoneno',postadd as 'Postal address',postarea as 'Postal Area',billadd as 'Billing Address',billarea as 'Billing Area',mobile as 'Mobile Number',gender as 'Gender',email as 'Email Id',facility as 'Facility',purpose as 'Purpose',tele_pco as'Telephone/PCO',regdate as 'Registration Date'  from customer", cn)
        Dim ds As New DataSet()
        da.Fill(ds, "temp")
        DataGridView1.DataSource = ds.Tables("temp")
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString() <> "" Then
            chkstd.Checked = False
            chkisd.Checked = False
            chkhotline.Checked = False
            chkconference.Checked = False
            Dim temptext As String
            Dim ch1() As Char
            gender = ""
            purpose = ""
            tele_pco = ""

            id1 = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            txtname.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            txtnominee.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            txtpan.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
            mtxttele.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value

            temptext = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
            txtadd1.Text = temptext.Substring(0, temptext.IndexOf("|"))
            txtadd2.Text = temptext.Substring(temptext.IndexOf("|") + 1)

            cmbarea.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
            'MsgBox(cmbarea.Text)
            temptext = ""
            temptext = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
            txtbadd1.Text = temptext.Substring(0, temptext.IndexOf("|"))
            txtbadd2.Text = temptext.Substring(temptext.IndexOf("|") + 1)

            cmbbarea.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value

            'MsgBox(cmbbarea.Text)
            mtxtcontact.Text = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value

            'FOR GENDER
            gender = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
            temptext = ""

            If gender = "male" Then
                rbmale.Checked = True
            ElseIf gender = "female" Then
                rbfemale.Checked = True
            End If
            txtemail.Text = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value

            'FOR FACILITY
            temptext = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
            ch1 = temptext.ToCharArray()
            Dim k, count, index(5) As Integer
            count = 0
            index(0) = -1
            For k = 0 To temptext.Length() - 1
                If ch1(k) = "|" Then
                    count = count + 1
                    index(count) = k
                End If
            Next
            facility = ""
            For k = 1 To count
                facility = temptext.Substring(index(k - 1) + 1, index(k) - (index(k - 1) + 1))
                'MsgBox(facility)
                If facility = "STD" Then
                    chkstd.Checked = True

                ElseIf facility = "ISD" Then
                    chkisd.Checked = True

                ElseIf facility = "HOTLINE" Then
                    chkhotline.Checked = True

                ElseIf facility = "CONFERENCE" Then
                    chkconference.Checked = True

                End If
                facility = ""
            Next

            'FOR PURPOSE
            purpose = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
            tele_pco = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value

            If purpose = "BUSINESS" Then
                rbbusiness.Checked = True
            ElseIf purpose = "RESIDENT" Then
                rbresident.Checked = True
            End If

            If tele_pco = "TELEPHONE" Then
                rbtele.Checked = True
            ElseIf tele_pco = "PCO" Then
                rbpco.Checked = True
            End If
            'Fetch Photo of customer
            If btnsave.Enabled = False Then
                table = "AccessCust"
                column = "@cust_id"
                Dim result As Byte() = accessFileFromDatabase(table, column, id1, 0)
                Dim ms As MemoryStream = New MemoryStream(result, 0, result.Length)
                Dim im As Image = Image.FromStream(ms)
                pbphoto.Image = im
            End If
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnview.Visible = True
            btnattach.Visible = False
            btnview.Enabled = True
        Else
            Dim vpat As String
            vpat = Application.ExecutablePath()
            vpat = vpat.Substring(0, vpat.LastIndexOf("\")) & "\"
            pbphoto.Image = System.Drawing.Image.FromFile(vpat & "default.jpg")

            txtname.Text = ""
            txtnominee.Text = ""
            txtpan.Text = ""
            mtxttele.Text = ""
            mtxtcontact.Text = ""
            txtadd1.Text = ""
            txtadd2.Text = ""
            cmbarea.SelectedIndex = 0
            txtbadd1.Text = ""
            txtbadd2.Text = ""
            cmbbarea.SelectedIndex = 0

            rbmale.Checked = True
            txtemail.Text = ""
            rbresident.Checked = True
            rbtele.Checked = True
            chksame.Checked = False
            chkstd.Checked = False
            chkisd.Checked = False
            chkconference.Checked = False
            chkhotline.Checked = False

            btnnew.Enabled = True
            btncancel.Enabled = True
            btnedit.Enabled = False
            btndelete.Enabled = False
            btnview.Visible = False
            btnattach.Visible = True
            btnbrowse.Enabled = False
            btnattach.Enabled = False
            cmbarea.SelectedIndex = 0
            cmbbarea.SelectedIndex = 0

            endis(False)
            DataGridView1.Focus()
        End If
        If id1 = "" Then
            btndelete.Enabled = False
            btnedit.Enabled = False
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim dr As SqlDataReader
        Dim count As String
        Dim pat As String
        count = 0
        cmd = New SqlCommand("select cust_id from customer")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        While (dr.Read())
            count = count + 1
        End While
        dr.Close()
        Dim cmd1 As SqlCommand
        If (MsgBox("Are you sure to delete entry where customer id =" & id1 & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            If count = 1 Then
                cmd = New SqlCommand("truncate table customer")
                cmd1 = New SqlCommand("truncate table cust_photo", cn)
            Else
                cmd = New SqlCommand("delete from customer where cust_id='" & id1 & "'")
                cmd1 = New SqlCommand("delete from cust_photo where cust_id='" & id1 & "'", cn)
            End If
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            bindgrid()
            'For Delete Folder
            
            DataGridView1.Focus()
            pat = Application.ExecutablePath()
            pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
            pbphoto.Image = System.Drawing.Image.FromFile(pat & "default.jpg")
            btnnew.Enabled = True
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btnnew.Enabled = True
        If id1 = "" Then
            btndelete.Enabled = False
            btnedit.Enabled = False
        Else
            btnedit.Enabled = True
            btnedit.Visible = True
            btnupdate.Visible = False
            btndelete.Enabled = True
            btnattach.Visible = False
            btnview.Visible = True
            btnview.Enabled = True
        End If
        btnbrowse.Enabled = False
        btnsave.Enabled = False
        btncancel.Enabled = True
        endis(False)
        DataGridView1.Enabled = True
        bindgrid()
        DataGridView1.Focus()
    End Sub
    Public Sub endis(ByVal en As Boolean)
        txtname.Enabled = en
        txtnominee.Enabled = en
        txtpan.Enabled = en

        chksame.Enabled = en
        mtxttele.Enabled = en
        mtxtcontact.Enabled = en
        txtadd1.Enabled = en
        txtadd2.Enabled = en
        cmbarea.Enabled = en

        txtbadd1.Enabled = en
        txtbadd2.Enabled = en
        cmbbarea.Enabled = en


        rbmale.Enabled = en
        rbfemale.Enabled = en

        txtemail.Enabled = en

        rbresident.Enabled = en
        rbbusiness.Enabled = en
        rbtele.Enabled = en
        rbpco.Enabled = en

        chkstd.Enabled = en
        chkisd.Enabled = en
        chkhotline.Enabled = en
        chkconference.Enabled = en
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        str = ""
        If cmbsearch.SelectedIndex = 1 Then
            str = "telephone"
        ElseIf cmbsearch.SelectedIndex = 2 Then
            str = "custname"
        ElseIf cmbsearch.SelectedIndex = 3 Then
            str = "postarea"
        End If
        'MsgBox(str)
        If cmbsearch.SelectedIndex = 1 Then
            Dim valid As New validclass
            Dim ret As Boolean
            ret = valid.numCheck(txtsearch.Text)
            If ret = False Or txtsearch.Text.Length > 7 Then
                MsgBox("Invalid Telephone no")
                txtsearch.Text = ""
            Else
                query = query1 & " where " & str & " like '" & txtsearch.Text & "%'"

            End If
        ElseIf cmbsearch.SelectedIndex = 0 Then
            query = query1
        Else
            query = query1 & " where " & str & " like '" & txtsearch.Text & "%'"
            MsgBox(query)
        End If
        Dim da As New SqlDataAdapter(query, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "temp")
        DataGridView1.DataSource = ds.Tables("temp")

    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        MsgBox(OpenFileDialog1.FileName)
        If OpenFileDialog1.FileName = "" Or OpenFileDialog1.FileName = "OpenFileDialog1" Then

        Else
            Try
                pbphoto.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
                flag1 = 0
            Catch ex As Exception
                MsgBox("File is not exist")
                flag1 = 1
            End Try
        End If
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Enabled = True
        Dim frmvi As New frmview
        id = id1
        frmvi.ShowDialog()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim msg, gen1, tele_pco1, purpose1 As String
        msg = ""
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.alphaCheck2(txtname.Text)
        If ret = False Then
            msg = msg & "Invalid Name" & Chr(13)
        End If

        ret = valid.alphaCheck2(txtnominee.Text)
        If ret = False Then
            msg = msg & "Invalid Joint Applicant Name" & Chr(13)
        End If

        ret = valid.alphanumCheck(txtpan.Text)
        If ret = False Or txtpan.Text.Length <> 10 Then
            msg = msg & "Invalid Pan No." & Chr(13)
        End If


        ret = valid.spacecheck(txtemail.Text)
        If ret = True Then
            txtemail.Text = ""
        End If

        If cmbarea.SelectedIndex = 0 Or cmbbarea.SelectedIndex = 0 Then
            msg = msg & "Invalid Area" & Chr(13)
        End If

        If txtemail.Text.Length <> 0 Then
            ret = valid.emailcheck(txtemail.Text)
            If ret = False Then
                msg = msg & "Invalid Email Id" & Chr(13)
            End If
        End If

        If msg.Length > 0 Then
            MsgBox(msg, MsgBoxStyle.ApplicationModal, "Error")
        End If

        If msg.Length = 0 Then
            myconnect()
            Dim postadd As String
            postadd = txtadd1.Text & "|" & txtadd2.Text
            Dim billadd As String
            billadd = txtbadd1.Text & "|" & txtbadd2.Text
            Dim postarea As String
            postarea = cmbarea.SelectedItem
            Dim billarea As String
            billarea = cmbbarea.SelectedItem

            'for gender
            If rbmale.Checked = True Then
                gen1 = "male"
            Else
                gen1 = "female"
            End If

            'for facility
            facility1 = ""

            If chkstd.Checked = True Then
                facility1 = facility1 & "|STD"
            End If
            If chkhotline.Checked = True Then
                facility1 = facility1 & "|HOTLINE"
            End If
            If chkisd.Checked = True Then
                facility1 = facility1 & "|ISD"
            End If
            If chkconference.Checked = True Then
                facility1 = facility1 & "|CONFERENCE"
            End If
            facility1 = facility1 & "|"
            facility1 = facility1.Substring(1)


            'for purpose
            If rbbusiness.Checked = True Then
                purpose1 = "BUSINESS"
            Else
                purpose1 = "RESIDENT"
            End If

            'tele_pco
            If rbtele.Checked = True Then
                tele_pco1 = "TELEPHONE"
            Else
                tele_pco1 = "PCO"
            End If

            cmd = New SqlCommand("update customer set custname = '" & txtname.Text & "',custnominee = '" & txtnominee.Text & "',pan = '" & txtpan.Text & "' ,telephone = '" & mtxttele.Text & "',postadd = '" & postadd & "',postarea = '" & postarea & "',billadd = '" & billadd & "',billarea= '" & billarea & "',gender = '" & gen1 & "',email = '" & txtemail.Text & "',facility = '" & facility1 & "',purpose = '" & purpose1 & "',tele_pco = '" & tele_pco1 & "',mobile='" & mtxtcontact.Text & "' where cust_id = '" & id1 & "'")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            bindgrid()
            MsgBox("Updated successfully", MsgBoxStyle.OkOnly)

            endis(False)
            btnupdate.Visible = False
            btnedit.Visible = True
            btnnew.Enabled = True
            btnattach.Visible = False
            btnview.Visible = True
            btnview.Enabled = True
            btndelete.Enabled = True
            DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtsearch.Enabled = False
        Else
            txtsearch.Enabled = True
        End If
    End Sub

    Private Sub chksame_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chksame.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If chksame.Checked = True Then
                mtxtcontact.Focus()
            Else
                txtbadd1.Focus()
            End If
        End If
    End Sub

    

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        str = ""
        
        If cmbsearch.SelectedIndex = 1 Then
            str = "telephone"
        ElseIf cmbsearch.SelectedIndex = 2 Then
            str = "custname"
        ElseIf cmbsearch.SelectedIndex = 3 Then
            str = "postarea"
        End If
        query = query1 & " where " & str & " like '" & txtsearch.Text & "%'"
        Dim da As New SqlDataAdapter(query, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "temp")
        DataGridView1.DataSource = ds.Tables("temp")
        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class