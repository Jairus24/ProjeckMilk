Public Class frmToothNo
    Private Sub txtMove_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMove.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMoveS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMoveS.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnMoveC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveC.Click
        Me.Close()
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Try
            If txtMove.Text = "" Or txtMoveS.Text = "" Or txtMoveS.Text = "0.00" Then
                MsgBox("You cannot leave the amout field empty! Please fill in the right amount.", vbExclamation, "Warning!")
            Else
                MainFormMetro.ServiceQueueTableAdapter.Insert(frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(4).Value.ToString() _
                                                              , frmAppoint.DataGridView1.CurrentRow.Cells(2).Value.ToString() + " " + frmAppoint.DataGridView1.CurrentRow.Cells(3).Value.ToString(), txtMove.Text, txtMoveS.Text, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString())
                MainFormMetro.ServiceQueueTableAdapter.Fill(MainFormMetro.PLDBDataSet.serviceQueue)
                frmAppoint.ApptmntTableAdapter.Delete(frmAppoint.DataGridView1.CurrentRow.Cells(0).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(2).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(3).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(4).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString(), frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString())
                frmAppoint.ApptmntTableAdapter.Fill(frmAppoint.PLDBDataSet.apptmnt)
                If frmAppoint.DataGridView1.Rows.Count >= 1 Then
                    frmAppoint.btnAppCancel.Enabled = True
                    frmAppoint.btnAppQueue.Enabled = True
                Else
                    frmAppoint.btnAppCancel.Enabled = False
                    frmAppoint.btnAppQueue.Enabled = False
                End If
                If MainFormMetro.DataGridView1.Rows.Count >= 1 Then
                    MainFormMetro.ButtonAdv4.Enabled = True
                    MainFormMetro.ButtonAdv5.Enabled = True
                Else
                    MainFormMetro.ButtonAdv4.Enabled = False
                    MainFormMetro.ButtonAdv5.Enabled = False
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access 2010 Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
    End Sub

    Private Sub frmToothNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMoveS.Text = Format(txtMoveS.Text, "0.00")
        txtMove.Text = ""
    End Sub
    Private Sub txtMoveS_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMoveS.GotFocus
        If txtMoveS.Text = "0.00" Then
            txtMoveS.Text = ""
        End If
    End Sub
End Class