Public Class frmPayBal
    Private Sub frmPayBal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPayBal.Text = Format(txtPayBal.Text, "0.00")
    End Sub
    Private Sub txtPayBal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayBal.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim diffs, c As String
            Dim diff, sum As Integer
            If txtPayBal.Text = "" Or "0.00" Then
                MsgBox("You cannot leave the amount field empty! Please fill in the right amount.", vbExclamation, "Warning!")
            Else
                c = txtPayBal.Text
                Convert.ToDouble(c)
                diff = frmBalance.DataGridView1.CurrentRow.Cells(7).Value - c
                diffs = diff
                If c > 0 And c < frmBalance.DataGridView1.CurrentRow.Cells(7).Value Then
                    MsgBox(frmBalance.DataGridView1.CurrentRow.Cells(1).Value.ToString + " has P" + diffs + " balance left.", vbOKOnly, "Balance")
                Else
                    MsgBox("Balance Paid!", vbInformation, "Balance")
                End If
                sum = frmBalance.DataGridView1.CurrentRow.Cells(9).Value + c
                If sum >= frmBalance.DataGridView1.CurrentRow.Cells(6).Value Then
                    frmBalance.DataGridView1.CurrentRow.Cells(9).Value = sum
                ElseIf sum > 0 And sum < frmBalance.DataGridView1.CurrentRow.Cells(6).Value Then
                    frmBalance.DataGridView1.CurrentRow.Cells(9).Value += c
                End If
                frmBalance.DataGridView1.CurrentRow.Cells(7).Value = diff
                frmBalance.DataGridView1.CurrentRow.Selected = False
                Me.Validate()
                frmBalance.ValidateChildren()
                frmBalance.DataGridView1.EndEdit()
                frmBalance.ServiceRecordTableAdapter.Update(frmBalance.PLDBDataSet.serviceRecord)
                frmBalance.ServiceRecordTableAdapter.Fill(frmBalance.PLDBDataSet.serviceRecord)
                Me.Close()
                If frmBalance.DataGridView1.Rows.Count >= 1 Then
                    frmBalance.btnBalPaid.Enabled = True
                Else
                    frmBalance.btnBalPaid.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access 2010 Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
    End Sub

    Private Sub txtPayBal_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayBal.GotFocus
        If txtPayBal.Text = "0.00" Then
            txtPayBal.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class