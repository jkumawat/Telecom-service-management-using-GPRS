Imports System.IO
Public Class Frmimg

    Private Sub Frmimg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table = "AccessAttach"
        column = "@cust_id"
        Dim ms As MemoryStream = Nothing
        Dim im As Image = Nothing
        Dim result As Byte() = Nothing

        result = accessFileFromDatabase(table, column, id, rowcount)
        ms = New MemoryStream(result, 0, result.Length)
        im = Image.FromStream(ms)
        PictureBox1.Image = im
    End Sub

End Class