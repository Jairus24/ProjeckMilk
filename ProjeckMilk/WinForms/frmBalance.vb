Public Class frmBalance
    Dim dv As DataView = New DataView
    'Dim dat As String = "0.0000"
    Public sum As Integer
    Private Sub frmBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ToothImageDBDataSet.ServiceRecordDB' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'PLDBDataSet.serviceRecord' table. You can move, or remove it, as needed.
        Try
            ToothImageDBDataSet.Clear()
            ToothImageDBDataSet.EnforceConstraints = False
            Me.ServiceRecordDBTableAdapter.Fill(Me.ToothImageDBDataSet.ServiceRecordDB)
        Catch ex As Exception
            'MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
            MsgBox(ex.ToString, vbCritical, "Exception Error")
            End
        End Try
        Me.DataGridView1.Columns(0).Visible = False
        dv.Table = ToothImageDBDataSet.ServiceRecordDB
        dv.RowFilter = "RemainingBalance <> '0'"
        DataGridView1.DataSource = dv
        For i As Integer = 0 To DataGridView1.RowCount - 1
            sum += DataGridView1.Rows(i).Cells(7).Value
        Next
        If Me.DataGridView1.Rows.Count >= 1 Then
            btnBalPaid.Enabled = True
        Else
            btnBalPaid.Enabled = False
        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        btnBalPaid_Click(sender, New System.EventArgs())
    End Sub
    Private Sub btnBalPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalPaid.Click
        frmPayBal.ShowDialog(Me)
    End Sub
End Class