Imports System.Data.SqlClient
Public Class frmpassword
    Dim pwd As String
    Public genie As AgentObjects.IAgentCtlCharacterEx
    Private Sub frmpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxAgent1.Characters.Load("merlin", "merlin.acs")
        genie = AxAgent1.Characters("merlin")
        myconnect()
        txtlogin.Text = sesname
        txtlogin.Enabled = False
        getinfo()
        lblcompany.Text = id3
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        cmd = New SqlCommand("select * from login where uname='" & sesname & "'")
        cmd.Connection = cn
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While (dr.Read())
            pwd = dr(1).ToString()
        End While
        dr.Close()
        Dim pos As Integer
        If pwd = txtoldpass.Text Then
            pos = checkchar(txtnewpass.Text, "'") 'Method in SaveAccess Class 
            'MsgBox("value of->" & pos)
            If pos > 0 Then
                MsgBox("Special Characters (' / \ ,) are not valid")
                txtnewpass.Text = ""
                txtreenter.Text = ""
            Else
                If txtnewpass.Text = txtreenter.Text Then
                    Dim str As String
                    str = "update login set password = '" & txtnewpass.Text & "' where uname = '" & sesname & "' "
                    cmd = New SqlCommand(str)
                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    MsgBox("Your Password is changed ")
                    Me.Close()
                Else
                    ' MsgBox("ReEnter New Password")
                    genie.Show(True)
                    genie.MoveTo(200, 200)
                    genie.Speak("ReEnter New Password", "")
                    genie.Hide()
                End If
            End If
        Else
            ' MsgBox("Your Old Password is Incorrect")
            genie.Show(True)
            genie.MoveTo(200, 200)
            genie.Speak("Your Old Password is Incorrect", "")
            genie.Hide()
        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    
End Class