Imports System.Data.SqlClient
Imports System.IO
Public Class frmbillgenerate

    Dim status, periodfrom, periodto As String
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from bill")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            lblno.Text = Integer.Parse(dr(0).ToString) + 1
        Else
            lblno.Text = "1000"
        End If
        dr.Close()
        endis(True)
        btnsave.Enabled = True
        btnclose.Enabled = True

    End Sub

    Private Sub frmbillgenerate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myconnect()
        getinfo()
        lblcompany.Text = id3

        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from bill")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            cmd = New SqlCommand("select max(billno) from bill")
            cmd.Connection = cn
            dr.Close()
            dr = cmd.ExecuteReader()
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
        txtadd.Enabled = en
        txtcontact.Enabled = en
        txtname.Enabled = en
        txtarea.Enabled = en
        rbpaid.Enabled = en
        rbunpaid.Enabled = en
        dtpfrom.Enabled = en
        dtpto.Enabled = en
        txtamount.Enabled = en

        End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If rbpaid.Checked = True Then
            status = "paid"
        Else
            status = "unpaid"
        End If
        'MsgBox(status)
        periodfrom = dtpfrom.Text().ToString()
        periodto = dtpto.Text().ToString()
        MsgBox(periodfrom)

        Dim cmd As SqlCommand
        cmd = New SqlCommand("insert into bill(custname,address,area,contactno,paymentstatus,periodfrom,periodto,amount)values('" & txtname.Text & "','" & txtadd.Text & "','" & txtarea.Text & "','" & txtcontact.Text & "','" & status & "','" & periodfrom & "','" & periodto & "','" & txtamount.Text & "')")
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Bill Details Successfully submitted!!")
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select max(billno) from bill")
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        dr.Read()
        lblno.Text = Integer.Parse(dr(0).ToString) + 1
        dr.Close()
        btnsave.Enabled = False
        btnclose.Enabled = True
        clear()
        endis(False)
        'txtsearch.Enabled = False
    End Sub
    Public Sub clear()
        txtname.Text = ""
        txtamount.Text = ""
        txtadd.Text = ""
        txtarea.Text = ""
        txtcontact.Text = ""
        txtsearch.Text = "Phone No."
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim dr As SqlDataReader
        Dim valid As New validclass
        Dim ret As Boolean
        ret = valid.numCheck(txtsearch.Text)
        If ret = False Or txtsearch.Text.Length <> 7 Then
            MsgBox("Enter Correct Telephone No.")
        Else
            cmd = New SqlCommand("select * from customer where telephone='" & txtsearch.Text & "'")
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txtname.Text = dr(1).ToString
                txtadd.Text = dr(5).ToString
                txtarea.Text = dr(6).ToString
                txtcontact.Text = dr(4).ToString

                endis(True)
                btnsave.Enabled = True
                btnclose.Enabled = True
                rbpaid.Enabled = True
                rbunpaid.Enabled = True
                dtpfrom.Enabled = True
                dtpto.Enabled = True
                txtamount.Enabled = True
                dr.Close()
            Else
                MsgBox("No Record Found!!")

            End If
            
        End If

    End Sub

    

    Private Sub txtsearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.GotFocus
        txtsearch.Text = ""
    End Sub

   
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

End Class