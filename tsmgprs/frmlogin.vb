Imports System.Data.SqlClient
Public Class frmlogin
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myconnect()
        txtuname.Focus()
        cbrole.SelectedIndex = 0
        Dim chkcmd As New SqlCommand("select * from login")
        chkcmd.Connection = cn
        Dim chkdr As SqlDataReader
        chkdr = chkcmd.ExecuteReader()
        If chkdr.HasRows = False Then
            Dim frmcompinfo As New companyinfo
            frmcompinfo.ShowDialog()
        End If
        chkdr.Close()
    End Sub

    

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconnect()
        Dim pos, pos1 As Integer
        pos = 0
        pos1 = 0
        pos = InStr(txtuname.Text, "'", CompareMethod.Text)
        pos1 = checkchar(txtpass.Text, "'") 'Method in SaveAccess Class 

        If pos > 0 And pos1 > 0 Then
            MsgBox("Special Characters (' / \ ,) are not valid")
            txtuname.Text = ""
            txtpass.Text = ""
        Else
            Dim dt As New DataTable()
            cmd = New SqlCommand("select * from login where uname='" & txtuname.Text & "' and password='" & txtpass.Text & "' and role='" & cbrole.Text & "'")
            cmd.Connection = cn
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                sesrole = cbrole.Text
                sesname = txtuname.Text
                dr.Close()
                Me.Hide()
                Dim frmme As New frmmenu
                frmme.ShowDialog()
            Else
                MsgBox("Invalid Login!")
            End If
        End If

    End Sub

    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

End Class