Imports System.IO
Public Class frmattach

    Dim path As String
    Dim pat() As String = New String(4) {}
    Private Sub chklicence_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklicence.CheckStateChanged
        If chklicence.Checked = True Then
            btnlicence.Enabled = True
            btnsubmit.Enabled = True
            btnclear.Enabled = True
            pblicence.Enabled = True
            pblicence.Visible = True
        Else
            btnlicence.Enabled = False
        End If

    End Sub

    Private Sub chkpan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpan.CheckedChanged
        If chkpan.Checked = True Then
            btnpan.Enabled = True
            btnsubmit.Enabled = True
            btnclear.Enabled = True
            pbpan.Enabled = True
            pbpan.Visible = True
        Else
            btnpan.Enabled = False
        End If

    End Sub

    Private Sub chkration_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkration.CheckedChanged
        If chkration.Checked = True Then
            btnration.Enabled = True
            btnsubmit.Enabled = True
            btnclear.Enabled = True
            pbration.Enabled = True
            pbration.Visible = True
        Else
            btnration.Enabled = False
        End If

    End Sub

    Private Sub chkbank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbank.CheckedChanged
        If chkbank.Checked = True Then
            btnbank.Enabled = True
            btnsubmit.Enabled = True
            btnclear.Enabled = True
            pbbank.Enabled = True
            pbbank.Visible = True
        Else
            btnbank.Enabled = False
        End If
    End Sub

    Private Sub frmattach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim result As Byte() = Nothing
        If us = 0 Then
            'MsgBox(id)
            btnsubmit.Enabled = False
            btnclear.Enabled = False
            pblicence.Enabled = False
            pbration.Enabled = False
            pbpan.Enabled = False
            pbbank.Enabled = False
        Else
            'MsgBox(id1)
            Dim pat As String
            id = id1
            pat = Application.ExecutablePath()
            pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
            table = "AccessAttach"
            column = "@cust_id"
            Dim ms As MemoryStream = Nothing
            Dim im As Image = Nothing
            Try
                result = accessFileFromDatabase(table, column, id, 0)
                ms = New MemoryStream(result, 0, result.Length)
                im = Image.FromStream(ms)
                pblicence.Image = im
                chklicence.Enabled = False
            Catch ex As Exception
                pblicence.Image = System.Drawing.Image.FromFile(pat & "licence.jpg")
            End Try

            Try
                result = accessFileFromDatabase(table, column, id, 1)
                ms = New MemoryStream(result, 0, result.Length)
                im = Image.FromStream(ms)
                pbpan.Image = im
                chkpan.Enabled = False
            Catch ex As Exception
                pbpan.Image = System.Drawing.Image.FromFile(pat & "pancard.jpg")
            End Try

            Try
                result = accessFileFromDatabase(table, column, id, 2)
                ms = New MemoryStream(result, 0, result.Length)
                im = Image.FromStream(ms)
                pbration.Image = im
                chkration.Enabled = False
            Catch ex As Exception
                pbration.Image = System.Drawing.Image.FromFile(pat & "rationcard.jpg")
            End Try

            Try
                result = accessFileFromDatabase(table, column, id, 3)
                ms = New MemoryStream(result, 0, result.Length)
                im = Image.FromStream(ms)
                pbbank.Image = im
                chkbank.Enabled = False
            Catch ex As Exception
                pbbank.Image = System.Drawing.Image.FromFile(pat & "bankbook.jpg")
            End Try
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        chkbank.Checked = False
        chklicence.Checked = False
        chkration.Checked = False
        chkpan.Checked = False
        pblicence.Visible = False
        pbpan.Visible = False
        pbration.Visible = False
        pbbank.Visible = False
    End Sub

    Private Sub btnlicence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlicence.Click
        OpenFileDialog1.ShowDialog()

        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        If OpenFileDialog1.FileName = "" Or OpenFileDialog1.FileName = "OpenFileDialog1" Then

        Else
            pat(0) = OpenFileDialog1.FileName
            pblicence.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpan.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        If OpenFileDialog1.FileName = "" Or OpenFileDialog1.FileName = "OpenFileDialog1" Then

        Else
            pat(1) = OpenFileDialog1.FileName
            pbpan.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnration.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        If OpenFileDialog1.FileName = "" Or OpenFileDialog1.FileName = "OpenFileDialog1" Then

        Else
            pat(2) = OpenFileDialog1.FileName
            pbration.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnbank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbank.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        If OpenFileDialog1.FileName = "" Or OpenFileDialog1.FileName = "OpenFileDialog1" Then

        Else
            pat(3) = OpenFileDialog1.FileName
            pbbank.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If chklicence.Checked <> True Then
            pat(0) = ""
        End If
        If chkpan.Checked <> True Then
            pat(1) = ""
        End If
        If chkration.Checked <> True Then
            pat(2) = ""
        End If
        If chkbank.Checked <> True Then
            pat(3) = ""
        End If

        Dim value As String = SaveAttach(pat(0), pat(1), pat(2), pat(3), id)

        If MsgBox("Successfully saved all attachments,Now back to previous", MsgBoxStyle.OkOnly, "SAVED") = MsgBoxResult.Ok Then
            Me.Hide()
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub pblicence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pblicence.Click

    End Sub
End Class