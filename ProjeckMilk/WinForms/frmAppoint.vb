Public Class frmAppoint
    Public dvn As New DataTable
    Private Sub frmAppoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ToothImageDBDataSet.AppointmentsDB' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PLDBDataSet.apptmnt' table. You can move, or remove it, as needed.
        'Me.ApptmntTableAdapter.Fill(Me.PLDBDataSet.apptmnt)
        'TODO: This line of code loads data into the 'PLDBDataSet.apptmnt' table. You can move, or remove it, as needed.
        Try
            Me.AppointmentsDBTableAdapter.Fill(Me.ToothImageDBDataSet.AppointmentsDB)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
            End
        End Try
        Me.DataGridView1.Columns(0).Visible = False
        If Me.DataGridView1.Rows.Count >= 1 Then
            btnAppCancel.Enabled = True
            btnAppQueue.Enabled = True
        Else
            btnAppCancel.Enabled = False
            btnAppQueue.Enabled = False
        End If
    End Sub

    Private Sub btnAppNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppNew.Click
        frmPatientSearch.btnPSShow.Visible = False
        frmPatientSearch.btnAppt.Visible = True
        frmPatientSearch.btnEditRecord.Visible = False
        frmPatientSearch.btnSearchDelete.Visible = False
        frmPatientSearch.ShowDialog(Me)
    End Sub

    Private Sub btnAppBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppBack.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        btnAppQueue_Click(sender, New System.EventArgs())
    End Sub

    Private Sub btnAppQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppQueue.Click
        frmServices.b = 1
        frmServices.ShowDialog(Me)
        If Me.DataGridView1.Rows.Count >= 1 Then
            btnAppCancel.Enabled = True
            btnAppQueue.Enabled = True
        Else
            btnAppCancel.Enabled = False
            btnAppQueue.Enabled = False
        End If
    End Sub

    Private Sub btnAppCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppCancel.Click
        Dim A As VariantType
        A = MsgBox("Do you really want to cancel the appointment of " + Me.DataGridView1.CurrentRow.Cells(1).Value.ToString() + "?", _
               vbYesNo, "Confirmation")
        If A = MsgBoxResult.Yes Then
            Me.AppointmentsDBTableAdapter.Delete(DataGridView1.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value,
                                          DataGridView1.CurrentRow.Cells(3).Value, DataGridView1.CurrentRow.Cells(4).Value, DataGridView1.CurrentRow.Cells(5).Value, DataGridView1.CurrentRow.Cells(6).Value)
            Me.AppointmentsDBTableAdapter.Fill(Me.ToothImageDBDataSet.AppointmentsDB)
            If Me.DataGridView1.Rows.Count >= 1 Then
                btnAppCancel.Enabled = True
                btnAppQueue.Enabled = True
            Else
                btnAppCancel.Enabled = False
                btnAppQueue.Enabled = False
            End If
        End If
        If Me.DataGridView1.RowCount < 1 Then
            MainFormMetro.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            MainFormMetro.NotifyIcon1.BalloonTipTitle = "Appointments Alert"
            MainFormMetro.NotifyIcon1.BalloonTipText = "There is no any appointments scheduled for today."
            MainFormMetro.NotifyIcon1.ShowBalloonTip(20000)
        End If
    End Sub
    Private Sub frmAppoint_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFormMetro.ButtonAdv2.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dv As DataView = New DataView
        dv.Table = ToothImageDBDataSet.AppointmentsDB
        dv.RowFilter = "apptDate = '" & DateTimePicker1.Value.ToShortDateString & "'"
        Me.DataGridView1.DataSource = dv
    End Sub

    Private Sub btnAppntReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppntReset.Click
        Dim dv As DataView = New DataView
        dv.Table = ToothImageDBDataSet.AppointmentsDB
        DataGridView1.DataSource = dv
        DateTimePicker1.Value = Date.Now.ToShortDateString
    End Sub
End Class