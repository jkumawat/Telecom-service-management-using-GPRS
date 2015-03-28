Imports System.Data.SqlClient
Imports System.IO
Module SaveAccess
    Dim i As Integer

    Public Function SavePhoto(ByVal tbl As String, ByVal column As String, ByVal FileName As String, ByVal fetch_id As String) As String
        Dim fs As FileStream = Nothing
        fs = New FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read)

        'Finding out the size of the file to be saved
        Dim fi As FileInfo = New FileInfo(FileName)
        Dim temp As Long = fi.Length
        Dim lung As Integer = Convert.ToInt32(temp)
        Dim picture As Byte() = New Byte(lung - 1) {}
        fs.Read(picture, 0, lung)
        fs.Close()
        'MsgBox("2..tbl->" & tbl & " ," & "clm->" & column & " ," & "path->" & FileName & " ," & "id->" & fetch_id & " ," & "picture->" & picture.Length.ToString)
        Dim result As String = SaveToDatabase(tbl, column, picture, fetch_id)
        Return result
    End Function

    Public Function SaveToDatabase(ByVal tbl As String, ByVal column As String, ByVal picture As Byte(), ByVal name_id As String) As String
        Dim FileName As SqlParameter = Nothing
        Dim pict As SqlParameter = Nothing
        Dim result As String
        'MsgBox("3..tbl->" & tbl & " ," & "clm->" & column & " ," & "id->" & name_id & " ," & "picture->" & picture.Length.ToString)
        cmd = New SqlCommand(tbl, cn)
        cmd.CommandType = System.Data.CommandType.StoredProcedure

        FileName = New SqlParameter(column, SqlDbType.VarChar, 50)
        FileName.Value = name_id
        pict = New SqlParameter("@pic", SqlDbType.Image)
        pict.Value = picture

        cmd.Parameters.Add(FileName)
        cmd.Parameters.Add(pict)
        cmd.ExecuteNonQuery()
        result = FileName.Value.ToString()
        Return result

    End Function

    Public Function accessFileFromDatabase(ByVal access As String, ByVal column As String, ByVal name_id As String, ByVal rowcount As Integer) As Byte()

        Dim kFileName As SqlParameter = Nothing
        Dim FName As SqlParameter = Nothing
        Dim dr As SqlDataReader
        Dim result As Byte() = Nothing

        cmd = New SqlCommand(access, cn)
        cmd.CommandType = System.Data.CommandType.StoredProcedure
        FName = New SqlParameter(column, SqlDbType.VarChar, 50)
        FName.Value = name_id

        cmd.Parameters.Add(FName)
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            result = CType(dr.GetValue(rowcount), Byte())
        Catch ex As Exception
            result = Nothing
        End Try
        dr.Close()
        Return result

    End Function


    Public Function SaveAttach(ByVal lic As String, ByVal pan As String, ByVal ration As String, ByVal bank As String, ByVal fetch_id As String) As String
        Dim pat() As String = New String(4) {}
        pat(0) = lic
        pat(1) = pan
        pat(2) = ration
        pat(3) = bank

        Dim result As String
        Dim picture As Byte() = Nothing
        'Dim licB As Byte() = Nothing
        'Dim panB As Byte() = Nothing
        'Dim rationB As Byte() = Nothing
        'Dim bankB As Byte() = Nothing
        result = ""
        For i = 0 To 3
            If pat(i).Length <> 0 Then
                Dim fs As FileStream = Nothing
                fs = New FileStream(pat(i), FileMode.Open, FileAccess.Read, FileShare.Read)

                'Finding out the size of the file to be saved
                Dim fi As FileInfo = New FileInfo(pat(i))
                Dim temp As Long = fi.Length
                Dim lung As Integer = Convert.ToInt32(temp)

                picture = New Byte(lung - 1) {}
                fs.Read(picture, 0, lung)
                fs.Close()
            End If
            If i = 0 Then
                table = "SaveLic"
                column = "@licence"
                result &= Save2Database(picture, table, column, fetch_id)
            End If
            If i = 1 Then
                table = "SavePan"
                column = "@pan"
                result &= Save2Database(picture, table, column, fetch_id)
            End If
            If i = 2 Then
                table = "SaveRation"
                column = "@ration"
                result &= Save2Database(picture, table, column, fetch_id)
            End If
            If i = 3 Then
                table = "SaveBank"
                column = "@bank"
                result &= Save2Database(picture, table, column, fetch_id)
            End If
            picture = Nothing
        Next
        'result &= Save2Database(licB, panB, rationB, bankB, fetch_id)
        Return result
    End Function

    Public Function Save2Database(ByVal picture As Byte(), ByVal procedure As String, ByVal column As String, ByVal name_id As String) As String
        Dim customer_id As SqlParameter = Nothing

        Dim pict As SqlParameter = Nothing
        Dim result As String = Nothing
        'MsgBox("lic->" & lic.Length.ToString & " pan->" & pan.Length.ToString & " ration->" & ration.Length.ToString & " bank->" & bank.Length.ToString)

        cmd = New SqlCommand(procedure, cn)
        cmd.CommandType = System.Data.CommandType.StoredProcedure

        customer_id = New SqlParameter("@cust_id", SqlDbType.VarChar, 50)
        customer_id.Value = name_id
        pict = New SqlParameter(column, SqlDbType.Image)
        pict.Value = picture

        cmd.Parameters.Add(customer_id)
        Try
            cmd.Parameters.Add(pict)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        result = customer_id.Value.ToString()
        Return result

    End Function
    Public Function checkchar(ByVal str As String, ByVal str1 As String) As Integer
        Dim ret As Integer
        ret = InStr(str, str1, CompareMethod.Text)
        Return ret
    End Function

    'Public Function Save2Database(ByVal lic As Byte(), ByVal pan As Byte(), ByVal ration As Byte(), ByVal bank As Byte(), ByVal name_id As String) As String
    '    Dim customer_id As SqlParameter = Nothing

    '    Dim pict() As SqlParameter = New SqlParameter(4) {}
    '    For i = 0 To 3
    '        pict(i) = Nothing
    '    Next
    '    Dim result As String
    '    'MsgBox("lic->" & lic.Length.ToString & " pan->" & pan.Length.ToString & " ration->" & ration.Length.ToString & " bank->" & bank.Length.ToString)
    '    cmd = New SqlCommand("SaveAttach", cn)
    '    cmd.CommandType = System.Data.CommandType.StoredProcedure

    '    customer_id = New SqlParameter("@cust_id", SqlDbType.VarChar, 50)
    '    customer_id.Value = name_id
    '    pict(0) = New SqlParameter("@licence", SqlDbType.Image)
    '    pict(0).Value = lic
    '    pict(1) = New SqlParameter("@pan", SqlDbType.Image)
    '    pict(1).Value = pan
    '    pict(2) = New SqlParameter("@ration", SqlDbType.Image)
    '    pict(2).Value = ration
    '    pict(3) = New SqlParameter("@bank", SqlDbType.Image)
    '    pict(3).Value = bank
    '    cmd.Parameters.Add(customer_id)
    '    For i = 0 To 3
    '        If pict(i).Size <> 0 Then
    '            cmd.Parameters.Add(pict(i))
    '        Else
    '            ' cmd.Parameters.Add(Nothing)
    '        End If
    '    Next
    '    Try
    '        cmd.ExecuteNonQuery()
    '    Catch ex As Exception

    '    End Try
    '            result = customer_id.Value.ToString()
    '            Return result

    'End Function
End Module
