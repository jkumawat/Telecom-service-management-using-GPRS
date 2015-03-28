Imports System.Data.SqlClient
Public Class frmcomplaindistribution

    Private Sub frmcomplaindistribution_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fun()
        fun2()
    End Sub

    Private Sub frmcomplaindistribution_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        fun()
        fun2()
    End Sub

    Private Sub Frmcomplaindistributuon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fun()
        fun2()
        getinfo()
        lblcompany.Text = id3
    End Sub

    Sub fun()
        myconnect()
        Dim query As String
        Dim dr As SqlDataReader
        cmd = New SqlCommand()
        Dim aarr(10), area, complains, high, medium, low, emp As String
        aarr(0) = "Adajan"
        aarr(1) = "Athwagate"
        aarr(2) = "Citilight"
        aarr(3) = "Nanpura"
        aarr(4) = "Rander"
        aarr(5) = "Palanpur patia"
        aarr(6) = "Parvat patia"
        aarr(7) = "Piplod"
        aarr(8) = "varacha"
        aarr(9) = "Udhna"
        query = "truncate table compdist"
        cmd = New SqlCommand(query)
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        Dim i As Integer
        For i = 0 To 9

            area = aarr(i)
            query = "select count(compno) from complain where area='" & area & "' group by area"
            cmd = New SqlCommand(query)
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()

                complains = dr(0).ToString
            Else
                complains = "0"
            End If
            dr.Close()
            query = "select count(compno) from complain where area='" & area & "' and priority='high' group by area"
            cmd = New SqlCommand(query)
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                high = dr(0).ToString
            Else
                high = "0"
            End If
            dr.Close()
            query = "select count(compno) from complain where area='" & area & "' and priority='medium' group by area"
            cmd = New SqlCommand(query)
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                medium = dr(0).ToString
            Else
                medium = "0"
            End If
            dr.Close()
            query = "select count(compno) from complain where area='" & area & "' and priority='low' group by area"
            cmd = New SqlCommand(query)
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()

                low = dr(0).ToString
            Else
                low = "0"
            End If
            dr.Close()
            query = "select count(emp_id) from employee where location='" & area & "' group by location"
            cmd = New SqlCommand(query)
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()

                emp = dr(0).ToString
            Else
                emp = "0"
            End If
            dr.Close()
            query = "insert into compdist values('" & area & "','" & emp & "','" & complains & "','" & high & "','" & medium & "','" & low & "')"
            cmd = New SqlCommand(query)
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
        Next
    End Sub
    Sub fun2()
        myconnect()
        Dim da As New SqlDataAdapter("select * from compdist", cn)
        Dim ds As New DataSet()
        da.Fill(ds, "temp")
        DataGridView1.DataSource = ds.Tables("temp")
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmcr As New frmemployee
        frmcr.ShowDialog()
    End Sub
End Class