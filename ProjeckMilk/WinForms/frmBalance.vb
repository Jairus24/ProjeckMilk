Public Class frmBalance
    Dim dv As DataView = New DataView
    Dim dat As String = "0.0000"
    Public sum As Integer
    Private Sub frmBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PLDBDataSet.serviceRecord' table. You can move, or remove it, as needed.
        Try
            Me.ServiceRecordTableAdapter.Fill(Me.PLDBDataSet.serviceRecord)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access 2010 Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
        Me.DataGridView1.Columns(0).Visible = False
        dv.Table = PLDBDataSet.serviceRecord
        dv.RowFilter = "pBalance <> '" & dat & "'"
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
    Private Sub btnBalPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalPaid.Click
        frmPayBal.ShowDialog(Me)
    End Sub
End Class