Public Class frmPatientCard

    Private Sub btnPSsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSsearch.Click
        Me.Close()
        frmPatientSearch.btnPSShow.Visible = True
        frmPatientSearch.btnAppt.Visible = False
        frmPatientSearch.btnEditRecord.Visible = True
        frmPatientSearch.btnSearchDelete.Visible = True
        frmPatientSearch.ShowDialog(MainFormMetro)
        If frmPatientSearch.DataGridView1.RowCount > 0 Then
            frmPatientSearch.btnPSShow.Enabled = True
            frmPatientSearch.btnSearchDelete.Enabled = True
            frmPatientSearch.btnEditRecord.Enabled = True
        Else
            frmPatientSearch.btnPSShow.Enabled = False
            frmPatientSearch.btnSearchDelete.Enabled = False
            frmPatientSearch.btnEditRecord.Enabled = False
        End If
    End Sub
    Private Sub btnPSback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSback.Click
        Me.Close()
    End Sub

    Private Sub btnPSregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSregister.Click
        Me.Close()
        frmPatientReg.txtLastName.Text = ""
        frmPatientReg.txtFirstName.Text = ""
        frmPatientReg.txtMiddleName.Text = ""
        frmPatientReg.txtOccupation.Text = ""
        frmPatientReg.txtAddress.Text = ""
        frmPatientReg.txtContact.Text = ""
        frmPatientReg.cbRegMarital.Text = "Single"
        frmPatientReg.btnRegSave.Visible = True
        frmPatientReg.btnSaveRecord.Visible = False
        frmPatientReg.ShowDialog(MainFormMetro)
    End Sub

    Private Sub btnPSbalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSbalance.Click
        Me.Close()
        frmBalance.Show(MainFormMetro)
    End Sub
End Class