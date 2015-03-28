Imports System.Data.SqlClient

Module connect
    Public cn, cn2 As SqlConnection
    Public cmd, cmd2 As SqlCommand
    Public id, id1, id3 As String
    Public area, address, phoneno, name As String
    Public rowcount As Integer
    Public us As Integer
    Public sesrole As String
    Public sesname As String
    Dim cid As String
    Public table As String = Nothing
    Public column As String = Nothing
    Public uname As String = "urparekh"
    Public passwd As String = "123iamnice"


    Public Sub myconnect()
        
        cn = New SqlConnection("server=AVSSSS\ARUN;uid=sa;pwd=;database=tsm")
        Try
            cn.Open()
        Catch ex As Exception
            MsgBox("Unable To Connect")
        End Try

    End Sub

    Public Sub myconnect2()

        cn2 = New SqlConnection("server=AVSSSS\ARUN;uid=sa;pwd=;database=tsm")
        Try
            cn2.Open()
        Catch ex As Exception
            MsgBox("Unable To Connect")
        End Try

    End Sub
    Public Sub getinfo()
        myconnect()
        cid = ""
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        cmd = New SqlCommand("select * from company")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        dr.Read()
        id3 = dr(0).ToString
        dr.Close()
    End Sub

End Module
