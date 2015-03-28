Imports System.IO
Public Class frmview
    Dim sl As String
    Dim sr As String
    Dim sp As String
    Dim sb As String
    Private Sub frmview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pat As String
        pat = Application.ExecutablePath()
        pat = pat.Substring(0, pat.LastIndexOf("\")) & "\"
        table = "AccessAttach"
        column = "@cust_id"
        Dim ms As MemoryStream = Nothing
        Dim im As Image = Nothing
        Dim result As Byte() = Nothing
        Try
            sl = ""
            result = accessFileFromDatabase(table, column, id, 0)
            ms = New MemoryStream(result, 0, result.Length)
            im = Image.FromStream(ms)
            pblicence.Image = im
            result = Nothing
        Catch ex As Exception
            sl = pat & "licence.jpg"
            pblicence.Image = System.Drawing.Image.FromFile(pat & "licence.jpg")
        End Try

        Try
            sp = ""
            result = accessFileFromDatabase(table, column, id, 1)
            ms = New MemoryStream(result, 0, result.Length)
            im = Image.FromStream(ms)
            pbpan.Image = im
            result = Nothing
        Catch ex As Exception
            sp = pat & "pancard.jpg"
            pbpan.Image = System.Drawing.Image.FromFile(pat & "pancard.jpg")
        End Try

        Try
            sr = ""
            result = accessFileFromDatabase(table, column, id, 2)
            ms = New MemoryStream(result, 0, result.Length)
            im = Image.FromStream(ms)
            pbration.Image = im
            result = Nothing
        Catch ex As Exception
            sr = pat & "rationcard.jpg"
            pbration.Image = System.Drawing.Image.FromFile(pat & "rationcard.jpg")
        End Try

        Try
            sb = ""
            result = accessFileFromDatabase(table, column, id, 3)
            ms = New MemoryStream(result, 0, result.Length)
            im = Image.FromStream(ms)
            pbbank.Image = im
            result = Nothing
        Catch ex As Exception
            sb = pat & "bankbook.jpg"
            pbbank.Image = System.Drawing.Image.FromFile(pat & "bankbook.jpg")
        End Try
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub

    Private Sub pblicence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pblicence.Click
        If sl = "" Then
            rowcount = 0
            fun()
        End If
    End Sub
    Private Sub fun()
        Dim frm As New Frmimg
        frm.ShowDialog()
    End Sub

    Private Sub pbpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbpan.Click
        If sp = "" Then
            rowcount = 1
            fun()
        End If
    End Sub

    Private Sub pbration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbration.Click
        If sr = "" Then
            rowcount = 2
            fun()
        End If
    End Sub

    Private Sub pbbank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbank.Click
        If sb = "" Then
            rowcount = 3
            fun()
        End If
    End Sub
End Class