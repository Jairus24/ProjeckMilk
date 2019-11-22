Public Class frmAppoint2
    Dim den As String
    Dim a As String = ""
    Private Sub frmAppoint2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAdd02.Format = DateTimePickerFormat.Custom
        dtpAdd02.CustomFormat = "hh:mm tt"
        txtAdd02.Text = ""
    End Sub

    Private Sub btnAddCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCancel.Click
        Me.Close()
        frmPatientSearch.Close()
    End Sub

    Private Sub btnAddAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAdd.Click
        den = StrConv(txtAdd02.Text, VbStrConv.ProperCase)
        If txtAdd02.Text = "" Then
            MsgBox("You cannot leave a category empty! Please fill in with proper information.", vbExclamation, "Warning!")
        Else
            Try
                frmAppoint.AppointmentsDBTableAdapter.Insert(frmPatientSearch.DataGridView1.CurrentRow.Cells(4).Value.ToString(), dtpAdd01.Value.ToShortDateString(), dtpAdd02.Value.ToShortTimeString(), a, den, frmPatientSearch.DataGridView1.CurrentRow.Cells(5).Value.ToString())
                frmAppoint.AppointmentsDBTableAdapter.Fill(frmAppoint.ToothImageDBDataSet.AppointmentsDB)
            Catch ex As Exception
                MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
                End
            End Try
            If frmAppoint.DataGridView1.Rows.Count > 0 Then
                frmAppoint.btnAppCancel.Enabled = True
                frmAppoint.btnAppQueue.Enabled = True
            Else
                frmAppoint.btnAppCancel.Enabled = False
                frmAppoint.btnAppQueue.Enabled = False
            End If
            MainFormMetro.n = 1
            MainFormMetro.i = 1
            Me.Close()
            frmPatientSearch.Close()
        End If
    End Sub

    Private Sub txtAdd02_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd02.GotFocus
        txtAdd02.SelectAll()
    End Sub
End Class