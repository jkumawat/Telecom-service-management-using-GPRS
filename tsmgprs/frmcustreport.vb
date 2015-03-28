Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Public Class frmcustreport
    Dim d As Date
    Dim str, str1 As String
    Dim objRpt As New dailycustreport
    Dim query, query1 As String
    Private Sub frmcustreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myconnect()

    End Sub

    Private Sub btngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerate.Click
        If cballrecords.Checked = False Then
            If cbarea.Checked = True Then
                If rbannual.Checked = True Or rbmonthly.Checked = True Then
                    query1 = "select cu.cust_id sas CustomerId,cu.custname as CustomerName,cu.postadd as Address,cu.postarea as Area,cu.mobile as ContactNo,cu.regdate as RegistrationDate,comp.companyname as company from customer cu,company comp where postarea='" & cmbarea.SelectedItem.ToString() & "' and regdate between '" & dtp1.Text() & "' and '" & dtp2.Text() & "' "
                ElseIf rbdaily.Checked = True Then
                    query1 = "select cu.cust_id as CustomerId,cu.custname as CustomerName,cu.postadd as Address,cu.postarea as Area,cu.mobile as ContactNo,cu.regdate as RegistrationDate,comp.companyname as company from customer cu,company comp where postarea='" & cmbarea.SelectedItem.ToString() & "' and regdate ='" & dtp1.Text() & "' "
                End If
            Else
                If rbannual.Checked = True Or rbmonthly.Checked = True Then
                    query1 = "select cu.cust_id as CustomerId,cu.custname as CustomerName,cu.postadd as Address,cu.postarea as Area,cu.mobile as ContactNo,cu.regdate as RegistrationDate,comp.companyname as company from customer cu,company comp where regdate between '" & dtp1.Text() & "' and '" & dtp2.Text() & "' "
                ElseIf rbdaily.Checked = True Then
                    'MsgBox("hi")
                    query1 = "select cu.cust_id as CustomerId,cu.custname as CustomerName,cu.postadd as Address,cu.postarea as Area,cu.mobile as ContactNo,cu.regdate as RegistrationDate,comp.companyname as company from customer cu,company comp where regdate = '" & dtp1.Text() & "'"
                End If
            End If
        Else

            'query1 = "select compno as No,comptname as Name from complain cu where compdate = '02-24-2009'"
            'query2 = "select companyname as c from company"
            If cbarea.Checked = True Then
                query1 = "select cu.cust_id as CustomerId,cu.custname as CustomerName,cu.postadd as Address,cu.postarea as Area,cu.mobile as ContactNo,cu.regdate as RegistrationDate,comp.companyname as company from customer cu,company comp where postarea='" & cmbarea.Text & "'"
            Else
                query1 = "select cu.cust_id as CustomerId,cu.custname as CustomerName,cu.postadd as Address,cu.postarea as Area,cu.mobile as ContactNo,cu.regdate as RegistrationDate,comp.companyname as company from customer cu,company comp"
            End If

        End If
        query = query1
        Dim dscmd As New SqlDataAdapter(query, cn)
        Dim ds As New dailycust
        dscmd.Fill(ds, "temp")
        objRpt.SetDataSource(ds.Tables("temp"))
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub rbdaily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdaily.CheckedChanged
        If rbdaily.Checked = True Then
            lblmode.Text = "Daily"
            cbarea.Checked = False
            lblto.Visible = False
            dtp2.Visible = False
        End If
    End Sub
    Private Sub rbmonthly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmonthly.CheckedChanged
        If rbmonthly.Checked = True Then
            lblmode.Text = "Monthly"
            lblto.Visible = True
            dtp2.Visible = True
            cbarea.Checked = False
        End If
    End Sub

    Private Sub rbannual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbannual.CheckedChanged
        If rbannual.Checked = True Then
            lblmode.Text = "Annualy"
            lblto.Visible = True
            dtp2.Visible = True
            cbarea.Checked = False
        End If
    End Sub

    Private Sub cbarea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbarea.CheckedChanged
        cmbarea.SelectedIndex = 0
        If cbarea.Checked = True Then
            lblarea1.Visible = True
            cmbarea.Visible = True
        Else
            lblarea1.Visible = False
            cmbarea.Visible = False
        End If
    End Sub

    Private Sub cballrecords_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cballrecords.CheckedChanged
        If cballrecords.Checked = True Then
            lbldate1.Enabled = False
            dtp1.Enabled = False
            dtp2.Enabled = False
            lblto.Enabled = False
            lblarea1.Enabled = False
            cmbarea.Enabled = True
            cbarea.Enabled = True
        Else
            lbldate1.Enabled = True
            dtp1.Enabled = True
            dtp2.Enabled = True
            lblto.Enabled = True
            lblarea1.Enabled = True
            cmbarea.Enabled = True
            cbarea.Enabled = True
        End If
    End Sub

    
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub lblmode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmode.Click

    End Sub
    Private Sub lbldate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldate1.Click

    End Sub
    Private Sub lblto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblto.Click

    End Sub
    Private Sub cmbarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbarea.SelectedIndexChanged

    End Sub
    Private Sub lblarea1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblarea1.Click

    End Sub
End Class