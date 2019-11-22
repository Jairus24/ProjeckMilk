Public Class frmMed
    Public a As Integer
    Public aa As Integer
    Public aaa As Integer
    Public aaaa As Integer
    Dim paid As Integer
    Private Sub txtMedBalance_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMedBalance.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmMed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ToothImageDBDataSet.MedsQueueDB' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'PLDBDataSet.medQueue' table. You can move, or remove it, as needed.
        Try
            Me.MedsQueueDBTableAdapter.Fill(Me.ToothImageDBDataSet.MedsQueueDB)
            'Me.MedQueueTableAdapter.Fill(Me.PLDBDataSet.medQueue)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
            End
        End Try
        If aa = 1 Then
            If Me.DataGridView1.CurrentRow.Cells(5).Value = 0 Then
                txtMedBalance.Enabled = False
                a = 1
            ElseIf aa = 1 Then
                txtMedBalance.Enabled = True
                txtMedBalance.Text = Format(txtMedBalance.Text, "0.00")
            End If
        Else
            txtMedBalance.Text = Format(txtMedBalance.Text, "0.00")
        End If
        txtMed.Text = ""
    End Sub
    Private Sub btnMedConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedConfirm.Click
        paid = Val(txtMedBalance.Text)
        If aa = 1 Then
            If txtMedBalance.Text = "" Or txtMedBalance.Text = "0.00" Then
                MsgBox("You cannot leave the amout field empty! Please fill in the right amount.", vbExclamation, "Warning!")
            Else
                Dim dat As Date = Me.DataGridView1.CurrentRow.Cells(3).Value
                Dim bal As Integer = Me.DataGridView1.CurrentRow.Cells(5).Value - Val(txtMedBalance.Text)
                If bal < 0 Then
                    bal = 0
                    paid = Me.DataGridView1.CurrentRow.Cells(5).Value
                End If
                frmPatientProfile.ServiceRecordDBTableAdapter.Insert(Me.DataGridView1.CurrentRow.Cells(1).Value.ToString, Me.DataGridView1.CurrentRow.Cells(2).Value.ToString _
                                                               , Date.Now.ToShortDateString, Me.DataGridView1.CurrentRow.Cells(4).Value.ToString, txtMed.Text, Me.DataGridView1.CurrentRow.Cells(5).Value, bal _
                                                               , Me.DataGridView1.CurrentRow.Cells(6).Value.ToString, paid, Date.Now.ToShortTimeString, Me.DataGridView1.CurrentRow.Cells(7).Value.ToString)
                Me.MedsQueueDBTableAdapter.Delete(Me.DataGridView1.CurrentRow.Cells(0).Value, Me.DataGridView1.CurrentRow.Cells(1).Value.ToString _
                                                                      , Me.DataGridView1.CurrentRow.Cells(2).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(3).Value _
                                                                      , Me.DataGridView1.CurrentRow.Cells(4).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(5).Value.ToString() _
                                                                      , Me.DataGridView1.CurrentRow.Cells(6).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(7).Value.ToString())
                Me.MedsQueueDBTableAdapter.Fill(Me.ToothImageDBDataSet.MedsQueueDB)
                If aaa = 1 Then
                    frmAppoint.AppointmentsDBTableAdapter.Delete(frmAppoint.DataGridView1.CurrentRow.Cells(0).Value, frmAppoint.DataGridView1.CurrentRow.Cells(1).Value, frmAppoint.DataGridView1.CurrentRow.Cells(2).Value, frmAppoint.DataGridView1.CurrentRow.Cells(3).Value _
                                                              , frmAppoint.DataGridView1.CurrentRow.Cells(4).Value, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value)
                    frmAppoint.AppointmentsDBTableAdapter.Fill(frmAppoint.ToothImageDBDataSet.AppointmentsDB)
                    aaa = 0
                End If
                aa = 0
                Me.Close()
                Exit Sub
            End If
        ElseIf a = 1 Then
            Dim dat As Date = MainFormMetro.DataGridView1.CurrentRow.Cells(3).Value
            Dim bal As Integer = MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value - Val(txtMedBalance.Text)
            If bal < 0 Then
                bal = 0
                paid = MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value
            End If
            frmPatientProfile.ServiceRecordDBTableAdapter.Insert(MainFormMetro.DataGridView1.CurrentRow.Cells(1).Value.ToString, MainFormMetro.DataGridView1.CurrentRow.Cells(2).Value.ToString _
                                                               , Date.Now.ToShortDateString, MainFormMetro.DataGridView1.CurrentRow.Cells(4).Value.ToString, txtMed.Text, MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value, bal _
                                                               , MainFormMetro.DataGridView1.CurrentRow.Cells(6).Value.ToString, paid, Date.Now.ToShortTimeString, Me.DataGridView1.CurrentRow.Cells(7).Value.ToString)
            MainFormMetro.ServiceQueueDBTableAdapter.Delete(MainFormMetro.DataGridView1.CurrentRow.Cells(0).Value, MainFormMetro.DataGridView1.CurrentRow.Cells(1).Value.ToString _
                                                                  , MainFormMetro.DataGridView1.CurrentRow.Cells(2).Value.ToString(), MainFormMetro.DataGridView1.CurrentRow.Cells(3).Value _
                                                                  , MainFormMetro.DataGridView1.CurrentRow.Cells(4).Value.ToString(), MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value.ToString() _
                                                                  , MainFormMetro.DataGridView1.CurrentRow.Cells(6).Value.ToString(), MainFormMetro.DataGridView1.CurrentRow.Cells(7).Value.ToString())
            MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
            If MainFormMetro.DataGridView1.Rows.Count >= 1 Then
                MainFormMetro.ButtonAdv4.Enabled = True
                MainFormMetro.ButtonAdv5.Enabled = True
            Else
                MainFormMetro.ButtonAdv4.Enabled = False
                MainFormMetro.ButtonAdv5.Enabled = False
            End If
            a = 0
            Me.Close()
        ElseIf txtMedBalance.Text = "" Or txtMedBalance.Text = "0.00" Then
            MsgBox("The type of service is not a denture follow-up. You cannot leave the amout field empty! Please fill in the right amount.", vbExclamation, "Warning!")
        Else
            Dim dat As Date = MainFormMetro.DataGridView1.CurrentRow.Cells(3).Value
            Dim bal As Integer = MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value - Val(txtMedBalance.Text)
            If bal < 0 Then
                bal = 0
                paid = MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value
            End If

            frmPatientProfile.ServiceRecordDBTableAdapter.Insert(MainFormMetro.DataGridView1.CurrentRow.Cells(1).Value.ToString, MainFormMetro.DataGridView1.CurrentRow.Cells(2).Value.ToString _
                                                               , Date.Now.ToShortDateString, MainFormMetro.DataGridView1.CurrentRow.Cells(4).Value.ToString, txtMed.Text, MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value, bal _
                                                               , MainFormMetro.DataGridView1.CurrentRow.Cells(6).Value.ToString, paid, Date.Now.ToShortTimeString, MainFormMetro.DataGridView1.CurrentRow.Cells(7).Value.ToString)
            MainFormMetro.ServiceQueueDBTableAdapter.Delete(MainFormMetro.DataGridView1.CurrentRow.Cells(0).Value, MainFormMetro.DataGridView1.CurrentRow.Cells(1).Value.ToString _
                                                                  , MainFormMetro.DataGridView1.CurrentRow.Cells(2).Value.ToString(), MainFormMetro.DataGridView1.CurrentRow.Cells(3).Value _
                                                                  , MainFormMetro.DataGridView1.CurrentRow.Cells(4).Value.ToString(), MainFormMetro.DataGridView1.CurrentRow.Cells(5).Value.ToString() _
                                                                  , MainFormMetro.DataGridView1.CurrentRow.Cells(6).Value.ToString(), MainFormMetro.DataGridView1.CurrentRow.Cells(7).Value.ToString())
            MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
            If MainFormMetro.DataGridView1.Rows.Count >= 1 Then
                MainFormMetro.ButtonAdv4.Enabled = True
                MainFormMetro.ButtonAdv5.Enabled = True
            Else
                MainFormMetro.ButtonAdv4.Enabled = False
                MainFormMetro.ButtonAdv5.Enabled = False
            End If
            Me.Close()
        End If
    End Sub
    Private Sub txtMedBalance_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedBalance.GotFocus
        If txtMedBalance.Text = "0.00" Then
            txtMedBalance.Text = ""
        End If
    End Sub
End Class