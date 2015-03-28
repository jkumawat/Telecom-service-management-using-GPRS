Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports Utilities.FTP

Public Class frmtemp

    Dim d As Date
    Dim count, i, j, k, cnt As Integer
    Dim writer As StreamWriter
    Dim str, str2, pat, pat2, q1, datestr, target As String
    Dim dr2 As SqlDataReader

    Private Sub frmtemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myconnect2()
        count = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        pat = Application.ExecutablePath()
        pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
        count += 1
        Label2.Text = count
        If count = 10 Then
            Dim File As String
            File = pat & "complain.txt"
            If System.IO.File.Exists(File) = True Then
                System.IO.File.Delete(File)
            End If

            If System.IO.File.Exists(File) = False Then
                Dim file_stream As New FileStream(File, FileMode.Append, FileAccess.Write, FileShare.Write)
                file_stream.Close()
            End If

            'Take Area in Combo Box....

            cmd2 = New SqlCommand("select area from complain", cn2)
            dr2 = cmd2.ExecuteReader()
            Dim temp As Integer
            i = 0
            temp = 1
            While (dr2.Read())
                Dim comp As String
                comp = dr2(0)
                While i < cmbarea.Items.Count
                    If comp = cmbarea.Items(i).ToString Then
                        temp = 0
                    End If
                    i += 1
                End While
                If temp = 1 Then
                    cmbarea.Items.Add(comp)

                End If
                temp = 1
                i = 0
            End While
            dr2.Close()

            ' Generate Files.....
            Dim bytes As Byte()
            i = 0
            d = Date.Now.ToLocalTime
            datestr = d.ToShortDateString
            datestr = d.Year & "-" & d.Month() & "-" & d.Day

            While i < cmbarea.Items.Count
                str = cmbarea.Items(i).ToString
                cmd2 = New SqlCommand("select emp_id from employee where location='" & str & "' and Role ='Engineer'")
                cmd2.Connection = cn2
                dr2 = cmd2.ExecuteReader()
                j = 0
                cmbeid.Items.Clear()
                While dr2.Read
                    cmbeid.Items.Add(dr2(0).ToString)
                    j += 1
                End While
                k = 0
                dr2.Close()

                cmd2 = New SqlCommand("select compno,comptname,address,phoneno,probtype,priority from complain where compdate = '" & datestr & "'  and area = '" & str & "'")
                cmd2.Connection = cn2     '" & datestr & "'
                dr2 = cmd2.ExecuteReader()
                While (dr2.Read() And j <> 0)
                    cmbeid.SelectedIndex = k
                    str2 = "emp" & cmbeid.Text & "@"
                    cnt = 0
                    While cnt < dr2.FieldCount()
                        str2 &= dr2(cnt)
                        str2 &= "@"
                        cnt += 1
                    End While

                    pat2 = pat & "complain.txt"
                    str2 = str2.Substring(0, str2.Length - 1)
                    Dim file_stream As New FileStream(pat2, FileMode.Append, FileAccess.Write, FileShare.Write)
                    bytes = New UTF8Encoding().GetBytes(str2 & vbNewLine)
                    file_stream.Write(bytes, 0, bytes.Length)
                    file_stream.Flush()
                    file_stream.Close()
                    k = k + 1
                    If k = j Then
                        k = 0
                    End If

                End While
                dr2.Close()
                i = i + 1
            End While

            target = "complain.txt"
            pat2 = pat & "complain.txt"
            Dim ftp = New FTPclient("www.gapsap.info", uname, passwd)
            ftp.CurrentDirectory = "/public_html/telecom/"
            ftp.Upload(pat2, target)
            MsgBox("uploaded!")
            count = 0
        End If ' If is Over
    End Sub

End Class