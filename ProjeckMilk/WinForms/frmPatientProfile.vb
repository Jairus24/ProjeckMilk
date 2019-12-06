Public Class frmPatientProfile
    Dim dr As DataRow
    Dim dv As DataView = New DataView()
    Private Sub frmPatientProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PldbDataSet.serviceRecord' table. You can move, or remove it, as needed.
        Try
            Me.ServiceRecordTableAdapter.Fill(Me.PldbDataSet.serviceRecord)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access 2010 Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
        Me.DataGridView1.Columns(0).Visible = False
        dv.Table = PldbDataSet.serviceRecord
        dv.RowFilter = "pName like '" & lblPFnameF.Text & "'"
        dv.RowFilter = "pAddress like '" & lblPFaddressF.Text & "'"
        DataGridView1.DataSource = dv
    End Sub
    Private Sub btnPFclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPFclose.Click
        Me.Close()
        frmPatientSearch.Close()
    End Sub

    Private Sub btnPFadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPFadd.Click
        frmServices.ShowDialog(MainFormMetro)
    End Sub
End Class