Imports System.Data.SqlClient

Public Class frmsms
    Private Sub frmsms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtmsg.Text = address
        myconnect()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select contactno,fname,lname from employee where location='" & area & "'")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbto.Items.Add(dr(0).ToString() & "(" & dr(1).ToString() & " " & dr(2).ToString() & ")")
        End While
        dr.Close()
        cmbto.SelectedIndex = 0
    End Sub

    Private Sub btnsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsend.Click

    End Sub
End Class