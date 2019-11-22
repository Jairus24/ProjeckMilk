Public Class frmPatientSearch
    Dim pDB As New ToothImageDBDataSetTableAdapters.PatientDBTableAdapter()
    Dim dr As DataRow
    Dim dv As DataView = New DataView()
    Public b As Integer
    Private _day As Object

    Private Property Day(ByVal DateToday As Object) As Object
        Get
            Return _day
        End Get
        Set(ByVal value As Object)
            _day = value
        End Set
    End Property

    Function Age(ByVal Bdate, ByVal DateToday) As Integer
        If Month(DateToday) < Month(Bdate) Or (Month(DateToday) = _
                Month(Bdate) And Day(DateToday) < Day(Bdate)) Then
            Age = Year(DateToday) - Year(Bdate) - 1
        Else
            Age = Year(DateToday) - Year(Bdate)
        End If
        Return Age
    End Function
    Private Sub frmPatientSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PatientDBTableAdapterSQL.Fill(Me.ToothImageDBDataSet.PatientDB)
            'Me.PatientDBTableAdapter.Fill(Me.PLDBDataSet.patientDB)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
            End
        End Try
        If Me.DataGridView1.Rows.Count > 0 Then
            btnAppt.Enabled = True
        Else
            btnAppt.Enabled = False
        End If
        Me.DataGridView1.Columns(0).Visible = False
        txtPSname.Text = ""
    End Sub

    Private Sub btnPScancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPScancel.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        btnPSShow_Click(sender, New System.EventArgs())
    End Sub
    Private Sub btnPSShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSShow.Click
        Dim cRow = DataGridView1.CurrentRow
        frmPatientProfile.lblPFnameF.Text = cRow.Cells(4).Value.ToString()
        frmPatientProfile.lblPFaddressF.Text = cRow.Cells(5).Value.ToString()
        frmPatientProfile.lblPFcontactF.Text = cRow.Cells(6).Value().ToString()
        frmPatientProfile.lblPFOccupationF.Text = cRow.Cells(8).Value.ToString()
        frmPatientProfile.lblPFmaritalF.Text = cRow.Cells(9).Value.ToString()
        Dim Bdate As DateTime
        Bdate = cRow.Cells(7).Value
        frmPatientProfile.lblPFBdateF.Text = Bdate.ToString("MMMM dd, yyyy")
        Dim pBdate As Integer = Age(Bdate, Now)
        frmPatientProfile.lblPFageF.Text = pBdate
        frmPatientProfile.Text = cRow.Cells(4).Value.ToString()
        Me.Close()
        frmPatientProfile.Show(MainFormMetro)
    End Sub

    Private Sub txtPSname_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPSname.KeyUp
        dv.Table = ToothImageDBDataSet.PatientDB
        dv.RowFilter = "FullName like '" & txtPSname.Text & "%'"
        DataGridView1.DataSource = dv
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtPSname.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
    End Sub

    Private Sub btnAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppt.Click
        frmAppoint2.ShowDialog(Me)
    End Sub

    Private Sub btnSearchDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchDelete.Click
        Me.Validate()
        Dim a As MsgBoxResult
        a = MsgBox("Do you really want to delete the record of " + Me.DataGridView1.CurrentRow.Cells(4).Value.ToString + "?", vbYesNo, "Confirmation")
        frmLogin.c = 1
        frmLogin.n = MainFormMetro.admin
        If a = MsgBoxResult.Yes Then
            frmLogin.ShowDialog(Me)
        End If
        Try
            If a = MsgBoxResult.Yes And b = 1 Then
                Me.PatientDBTableAdapterSQL.Delete(DataGridView1.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value, DataGridView1.CurrentRow.Cells(3).Value, DataGridView1.CurrentRow.Cells(4).Value,
                                                DataGridView1.CurrentRow.Cells(5).Value, DataGridView1.CurrentRow.Cells(6).Value, DataGridView1.CurrentRow.Cells(7).Value, DataGridView1.CurrentRow.Cells(8).Value, DataGridView1.CurrentRow.Cells(9).Value)
                Me.PatientDBTableAdapterSQL.Fill(Me.ToothImageDBDataSet.PatientDB)
            ElseIf b = 2 Then
                b = 0
                Exit Sub
            End If
            If Me.DataGridView1.RowCount > 0 Then
                btnPSShow.Enabled = True
                btnSearchDelete.Enabled = True
                btnEditRecord.Enabled = True
            Else
                btnPSShow.Enabled = False
                btnSearchDelete.Enabled = False
                btnEditRecord.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
            End
        End Try
    End Sub

    Private Sub btnEditRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRecord.Click
        frmLogin.c = 1
        frmLogin.n = MainFormMetro.admin
        frmLogin.ShowDialog(Me)
        If b = 1 Then
            frmPatientReg.txtLastName.Text = Me.DataGridView1.CurrentRow.Cells(1).Value.ToString
            frmPatientReg.txtFirstName.Text = Me.DataGridView1.CurrentRow.Cells(2).Value.ToString
            frmPatientReg.txtMiddleName.Text = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString
            frmPatientReg.txtAddress.Text = Me.DataGridView1.CurrentRow.Cells(5).Value.ToString
            frmPatientReg.txtContact.Text = Me.DataGridView1.CurrentRow.Cells(6).Value.ToString
            frmPatientReg.dtpRegBDay.Value = Me.DataGridView1.CurrentRow.Cells(7).Value
            frmPatientReg.txtOccupation.Text = Me.DataGridView1.CurrentRow.Cells(8).Value.ToString
            frmPatientReg.cbRegMarital.Text = Me.DataGridView1.CurrentRow.Cells(9).Value.ToString
            frmPatientReg.Text = "Edit Record of " + Me.DataGridView1.CurrentRow.Cells(4).Value.ToString
            frmPatientReg.btnSaveRecord.Visible = True
            frmPatientReg.btnRegSave.Visible = False
            frmPatientReg.ShowDialog(Me)
        ElseIf b = 2 Then
            b = 0
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.MouseClick
        txtPSname.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub
End Class