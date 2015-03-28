Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data

Public Class tabctrl

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billingviewer.Load

    End Sub

    Private Sub tabctrl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'myconnect()
        'Dim query, query1 As String
        'Dim objRpt1 As New billingreport

        'query = "select * from bill"
        'Dim dscmd As New SqlDataAdapter(query, cn)
        'Dim ds As New daily
        'dscmd.Fill(ds, "temp")
        'objRpt1.SetDataSource(ds.Tables("temp"))
        'billingviewer.ReportSource = objRpt1
        'billingviewer.Refresh()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        myconnect()
        Dim query As String
        'Dim objRpt1 As New billingreport
        Dim objRpt1 As New billreport
        If TextBox1.Text <> "" Then
            query = "select custname as 'CustomerName',address as 'Address',area as 'Area',contactno as 'ContactNo',paymentstatus as 'PaymentStatus',periodfrom as 'PeriodFrom',periodto as 'PeriodTo',amount as 'Amount' from bill where contactno='" & TextBox1.Text & "'"
        Else
            'query = "select * from bill"
            query = "select custname as CustomerName,address as Address,area as Area,contactno as ContactNo,paymentstatus as PaymentStatus,periodfrom as PeriodFrom,periodto as PeriodTo,amount as Amount from bill"
        End If
        Dim dscmd As New SqlDataAdapter(query, cn)
        Dim ds As New bill
        dscmd.Fill(ds, "temp")
        objRpt1.SetDataSource(ds.Tables("temp"))
        billingviewer.ReportSource = objRpt1
        billingviewer.Refresh()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class