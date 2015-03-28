Imports System.Data.SqlClient
Imports System.IO
Imports System.DateTimeOffset


Public Class frmrecipent
    Dim str, str1 As String
    Dim d As Date
    Dim bank, cheque, paytype, strpaid As String
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcheque.CheckedChanged
        If rbcheque.Checked = True Then
            cbbank.Enabled = True
            txtcheque.Enabled = True
            cbbank.SelectedIndex = 0
        Else
            cbbank.Enabled = False
            txtcheque.Enabled = False
        End If
    End Sub

    Private Sub frmrecipent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myconnect()
        getinfo()
        lblcompany.Text = id3

        Dim d As Date

        d = Date.Now.ToLocalTime
        str = d.ToString
        str1 = str.Substring(0, str.IndexOf(" "))
        cbbank.SelectedIndex = 0
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from receipt")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            cmd = New SqlCommand("select max(receiptno) from receipt")
            cmd.Connection = cn
            dr.Close()
            dr = cmd.ExecuteReader()
            'Dim t As Integer
            If dr.HasRows Then
                dr.Read()
                lblno.Text = Integer.Parse(dr(0).ToString) + 1
            End If
        Else
            lblno.Text = "100"
        End If
        dr.Close()

    End Sub

    Public Sub endis(ByVal en As Boolean)
        txtcontact.Enabled = en
        txtname.Enabled = en
        txtamount.Enabled = en 
        btnsave.Enabled = en
        rbcash.Enabled = en
        rbcheque.Enabled = en
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim dr1 As SqlDataReader
        Dim cmd1 As SqlCommand
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.numCheck(txtsearch.Text)
        txtdate.Text = str1

        If ret = False Or txtsearch.Text.Length <> 7 Then
            MsgBox("Enter Correct Telephone No.")
        Else
            cmd1 = New SqlCommand("select * from bill where contactno='" & txtsearch.Text & "'")
            cmd1.Connection = cn
            dr1 = cmd1.ExecuteReader()
            If dr1.HasRows Then
                dr1.Read()
                txtamount.Text = dr1(8).ToString
                txtname.Text = dr1(1).ToString
                txtcontact.Text = dr1(4).ToString
                endis(True)         
                txtamount.Enabled = True
                dr1.Close()
                btncancel.Enabled = True
            Else
                MsgBox("No Record Found!!Sorry!! Try Again Later")
            End If
        End If



    End Sub

    Private Sub txtsearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.GotFocus
        txtsearch.Text = ""
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cmd1 As SqlCommand
        Dim msg As String = ""
        If rbcash.Checked = True Then
            bank = "No Bank"
            cheque = "No cheque"
            paytype = "cash"
        Else
            bank = cbbank.SelectedItem.ToString()
            cheque = txtcheque.Text
            paytype = "cheque"
            If txtcheque.Text.Length <> 6 Then
                MsgBox("please Enter valid cheque no")
                msg = "Error"
            End If

        End If
        If msg.Length = 0 Then
            cmd = New SqlCommand("insert into receipt(custname,contactno,pamount,paytype,bank,cheque,pdate) values ('" & txtname.Text & "','" & txtcontact.Text & "','" & txtamount.Text & "','" & paytype & "','" & bank & "','" & cheque & "','" & str1 & "')")
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            strpaid = "paid"
            cmd1 = New SqlCommand("update bill set paymentstatus='" & strpaid & "' where contactno='" & txtsearch.Text & "'")
            cmd1.Connection = cn
            cmd1.ExecuteNonQuery()

            MsgBox("Receipt Generated Successfully")
            btncancel.Enabled = False
            clear()
            endis(False)
            Dim dr As SqlDataReader
            cmd = New SqlCommand("select max(receiptno) from receipt")
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            dr.Read()
            lblno.Text = Integer.Parse(dr(0).ToString) + 1
            dr.Close()
            btnsave.Enabled = False
            btnclose.Enabled = True
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Me.Close()
    End Sub

    
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clear()
        endis(False)
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from receipt")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            cmd = New SqlCommand("select max(receiptno) from receipt")
            cmd.Connection = cn
            dr.Close()
            dr = cmd.ExecuteReader()
            'Dim t As Integer
            If dr.HasRows Then
                dr.Read()
                lblno.Text = Integer.Parse(dr(0).ToString) + 1
            End If
        Else
            lblno.Text = "100"
        End If
        dr.Close()
    End Sub

    Sub clear()
        txtname.Text = ""
        txtcontact.Text = ""
        txtamount.Text = ""
        txtcheque.Text = ""
        txtsearch.Text = ""
        cbbank.SelectedIndex = 0
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub rbcash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcash.CheckedChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtcheque_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcheque.TextChanged

    End Sub

    Private Sub txtdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.TextChanged

    End Sub

    Private Sub cbbank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbank.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub lblno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblno.Click

    End Sub
End Class