Imports System.Data.SqlClient
Imports System.IO
Public Class companyinfo
    Dim path As String
    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim msg As String
        msg = ""
        Dim valid As New validclass
        Dim ret As Boolean

        ret = valid.alphaCheck2(txtcname.Text)
        If ret = False Then
            msg = msg & "Invalid Company Name" & Chr(13)
        End If

        ret = valid.alphaCheck2(txtchairman.Text)
        If ret = False Then
            msg = msg & "Invalid Chirman Name" & Chr(13)
        End If

        ret = valid.numCheck(txtfax.Text)
        If ret = False Or txtfax.Text.Length <> 11 Then
            msg = msg & "Invalid Telephone No." & Chr(13)
        End If

        ret = valid.spacecheck(txtmail.Text)
        If ret = True Then
            msg = msg & "Invalid Email" & Chr(13)
        End If

        ret = valid.spacecheck(txtwebsite.Text)
        If ret = True Then
            msg = msg & "Invalid Website" & Chr(13)
        End If

        'ret = valid.alphaCheck2(txtslogan.Text)
        If txtslogan.Text = "" Then
            msg = msg & "Invalid Slogan" & Chr(13)
        End If

        'ret = valid.alphaCheck2(txtpolicy.Text)
        If txtpolicy.Text = "" Then
            msg = msg & "Invalid Policy" & Chr(13)
        End If

        ret = valid.spacecheck(txtwebsite.Text)
        If ret = True Then
            msg = msg & "Invalid Website" & Chr(13)
        End If

        ret = valid.spacecheck(txtadminname.Text)
        If ret = True Or txtadminname.Text = "" Then
            msg = msg & "Invalid Admin Name" & Chr(13)
        End If

        ret = valid.spacecheck(txtadminpass.Text)
        If ret = True Or txtadminpass.Text = "" Then
            msg = msg & "Invalid Admin Password" & Chr(13)
        End If


        If msg.Length > 0 Then
            MsgBox(msg, MsgBoxStyle.ApplicationModal, "Error")
        End If

        If path.Length = 0 Then
            MsgBox("Please select CompanyLogo first", MsgBoxStyle.OkOnly)
        ElseIf msg.Length = 0 And path.Length > 0 Then
            myconnect()
            Dim role As String
            role = "Admin"
            cmd = New SqlCommand("insert into company values('" & txtcname.Text & "','" & txtadd1.Text & "','" & cbcity.SelectedItem.ToString() & "','" & txtchairman.Text & "','" & txtphone.Text & "','" & txtfax.Text & "','" & txtmail.Text & "','" & txtwebsite.Text & "','" & txtslogan.Text & "','" & txtpolicy.Text & "')")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("insert into login values('" & txtadminname.Text & "','" & txtadminpass.Text & "','" & role & "')")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            Dim pat As String
            pat = Application.ExecutablePath()
            pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
            pblogo.Image.Save(pat & "companylogo.jpg")

            MsgBox("Company Details Submitted")

            'To make new folder of employee.
            'pat = ""
            'pat = Application.ExecutablePath()
            'pat = pat.Substring(0, pat.LastIndexOf("\") + 1) & "employee"
            'Dim mydir As New DirectoryInfo(pat)
            'mydir.Create()
            'Dim flog As New frmlogin
            Me.Hide()
        End If
    End Sub
    Private Sub btnlogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogo.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        If MsgBox(path, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            pblogo.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub companyinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbcity.SelectedIndex = 0
        path = ""
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class