Public Class adverticement
    Dim i As Integer
    Private Sub adverticement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getinfo()
        lblcompany.Text = id3

        i = id
        If i = 1 Then
            btnoffer.Visible = True
            btnoffer.Enabled = True
            gboffer.Visible = True
            lblo1.Visible = True
            lblo2.Visible = True
            lblo3.Visible = True
            cboffer1.Visible = True
            cboffer2.Visible = True
            cboffer3.Visible = True
        ElseIf i = 2 Then
            btnbill.Visible = True
            cbbill.Visible = True
            gbbilling.Visible = True
            lblbill.Visible = True
        Else
            btngreeting.Visible = True
            gbgreeting.Visible = True
            lblg1.Visible = True
            lblg2.Visible = True
            lblg3.Visible = True
            cbgreet1.Visible = True
            cbgreet2.Visible = True
            cbgreet3.Visible = True
        End If
    End Sub

    Private Sub cbg2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboffer2.CheckedChanged

    End Sub

    Private Sub btnoffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoffer.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub cbgreet2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbgreet2.CheckedChanged

    End Sub

    Private Sub cbgreet3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbgreet3.CheckedChanged

    End Sub

    Private Sub lblg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblg2.Click

    End Sub

    Private Sub lblg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblg1.Click

    End Sub

    Private Sub cbgreet1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbgreet1.CheckedChanged

    End Sub

    Private Sub lblg3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblg3.Click

    End Sub

    Private Sub gbgreeting_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbgreeting.Enter

    End Sub

    Private Sub lblbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbill.Click

    End Sub

    Private Sub cbbill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbill.CheckedChanged

    End Sub

    Private Sub gbbilling_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbbilling.Enter

    End Sub

    Private Sub cboffer3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboffer3.CheckedChanged

    End Sub

    Private Sub lblo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblo2.Click

    End Sub

    Private Sub lblo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblo1.Click

    End Sub

    Private Sub cboffer1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboffer1.CheckedChanged

    End Sub

    Private Sub lblo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblo3.Click

    End Sub

    Private Sub gboffer_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gboffer.Enter

    End Sub

    Private Sub btngreeting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngreeting.Click

    End Sub

    Private Sub btnbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbill.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsend.Click

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class