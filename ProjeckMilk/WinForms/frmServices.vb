Public Class frmServices
    Dim pSQ As New ToothImageDBDataSetTableAdapters.ServiceQueueDBTableAdapter()
    Dim pMed As New ToothImageDBDataSetTableAdapters.MedsQueueDBTableAdapter()
    Dim dentst As String
    Dim a As Integer
    Public b As Integer
    Private Sub frmServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServicesAmount.Text = Format(txtServicesAmount.Text, "0.00")
        MainFormMetro.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
        MainFormMetro.NotifyIcon1.BalloonTipTitle = "Verify the Information"
        MainFormMetro.NotifyIcon1.BalloonTipText = "You will not be able to edit the data recorded on patient's profile once submited. Please check all data inputs before proceeding."
        MainFormMetro.NotifyIcon1.ShowBalloonTip(20000)
        txtServicesDentist.Enabled = True
        a = 0
        If b <> 1 Then
            txtServicesDentist.Text = ""
        Else
            txtServicesDentist.Text = frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString
            txtServicesDentist.Enabled = False
        End If
        txtServicesTN.Text = ""
        txtServicesType.Text = ""
        cbDenture1.Text = "Plastic"
        ComboBox1.Text = "Plastic"
        ComboBox2.Text = "OP: Moderate"
        ComboBox2.Enabled = False
        rbDenture1.Select()
        txtServicesTN.Enabled = True
        txtServicesType.Enabled = True
        txtServicesType.Text = ""
        cbTrial.Enabled = False
        cbFinal.Enabled = False
        cbxServices2.Enabled = True
        cbDenture1.Enabled = False
        rbDenture1.Enabled = False
        rbDenture2.Enabled = False
        rbDenture3.Enabled = False
        cbxMedOnly.Checked = False
        rbDenture4.Enabled = False
        rbDenture5.Enabled = False
        cbxServices1.Checked = False
        cbxServices2.Checked = False
        cbTrial.Checked = False
        cbFinal.Checked = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        ComboBox1.Enabled = False
    End Sub

    Private Sub txtServicesAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServicesAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtServicesTN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtServicesTN.KeyDown
        If e.KeyCode = Keys.D0 Or e.KeyCode = Keys.D1 Or e.KeyCode = Keys.D2 Or e.KeyCode = Keys.D3 Or e.KeyCode = Keys.D4 _
            Or e.KeyCode = Keys.D5 Or e.KeyCode = Keys.D6 Or e.KeyCode = Keys.D7 Or e.KeyCode = Keys.D8 Or e.KeyCode = Keys.D9 Or
            e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Or e.KeyCode = Keys.OemSemicolon Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left _
             Or e.KeyCode = Keys.NumPad0 Or e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.NumPad4 _
             Or e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.NumPad9 Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnServicesCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicesCancel.Click
        b = 0
        Me.Close()
    End Sub

    Private Sub btnServicesAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicesAdd.Click
        dentst = StrConv(txtServicesDentist.Text, VbStrConv.ProperCase)
        If a = 3 Then
            If b = 1 Then
                Try
                    If txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                        MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                        Exit Sub
                    Else
                        b = 0
                        Me.Validate()
                        Me.pMed.Insert(frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                      , txtServicesAmount.Text, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString)
                        Me.pMed.Update(frmMed.ToothImageDBDataSet.MedsQueueDB)
                        frmMed.MedsQueueDBTableAdapter.Fill(frmMed.ToothImageDBDataSet.MedsQueueDB)
                        frmMed.aa = 1
                        frmMed.aaa = 1
                        Me.Close()
                        frmPatientProfile.Close()
                        frmMed.ShowDialog(MainFormMetro)
                        Exit Sub
                    End If
                Catch ex As Exception
                    'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                    Exit Sub
                End Try
            ElseIf b <> 1 Then
                If txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    Me.Validate()
                    Me.pMed.Insert(frmPatientProfile.lblPFnameF.Text, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                  , txtServicesAmount.Text, dentst, frmPatientProfile.lblPFaddressF.Text)
                    Me.pMed.Update(frmMed.ToothImageDBDataSet.MedsQueueDB)
                    frmMed.MedsQueueDBTableAdapter.Fill(frmMed.ToothImageDBDataSet.MedsQueueDB)
                    frmMed.aa = 1
                    Me.Close()
                    frmPatientProfile.Close()
                    frmMed.ShowDialog(MainFormMetro)
                    Exit Sub
                End If
            End If
        End If
        If cbTrial.Checked = True Or cbFinal.Checked = True And cbxServices1.Checked = True Then
            If b = 1 Then
                If txtServicesType.Text = "" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    Try
                        MainFormMetro.ServiceQueueDBTableAdapter.Insert(frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                  , txtServicesAmount.Text, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString)
                        MainFormMetro.ServiceQueueDBTableAdapter.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        frmAppoint.AppointmentsDBTableAdapter.Delete(frmAppoint.DataGridView1.CurrentRow.Cells(0).Value, frmAppoint.DataGridView1.CurrentRow.Cells(1).Value, frmAppoint.DataGridView1.CurrentRow.Cells(2).Value, frmAppoint.DataGridView1.CurrentRow.Cells(3).Value _
                                                             , frmAppoint.DataGridView1.CurrentRow.Cells(4).Value, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value)
                        frmAppoint.AppointmentsDBTableAdapter.Fill(frmAppoint.ToothImageDBDataSet.AppointmentsDB)
                        b = 0
                        MainFormMetro.tang = 1
                        If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                            MainFormMetro.ButtonAdv4.Enabled = True
                            MainFormMetro.ButtonAdv5.Enabled = True
                        Else
                            MainFormMetro.ButtonAdv4.Enabled = False
                            MainFormMetro.ButtonAdv5.Enabled = False
                        End If
                        Me.Close()
                        Exit Sub
                    Catch ex As Exception
                        'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                        Exit Sub
                    End Try
                    If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                        MainFormMetro.ButtonAdv4.Enabled = True
                        MainFormMetro.ButtonAdv5.Enabled = True
                    Else
                        MainFormMetro.ButtonAdv4.Enabled = False
                        MainFormMetro.ButtonAdv5.Enabled = False
                    End If
                End If
            ElseIf b <> 1 Then
                If txtServicesType.Text = "" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    MainFormMetro.ServiceQueueDBTableAdapter.Insert(frmPatientProfile.lblPFnameF.Text, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                      , txtServicesAmount.Text, dentst, frmPatientProfile.lblPFaddressF.Text)
                    MainFormMetro.ServiceQueueDBTableAdapter.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                    MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                    MainFormMetro.tang = 1
                    If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                        MainFormMetro.ButtonAdv4.Enabled = True
                        MainFormMetro.ButtonAdv5.Enabled = True
                    Else
                        MainFormMetro.ButtonAdv4.Enabled = False
                        MainFormMetro.ButtonAdv5.Enabled = False
                    End If
                    Me.Close()
                    frmPatientProfile.Close()
                    Exit Sub

                    If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                        MainFormMetro.ButtonAdv4.Enabled = True
                        MainFormMetro.ButtonAdv5.Enabled = True
                    Else
                        MainFormMetro.ButtonAdv4.Enabled = False
                        MainFormMetro.ButtonAdv5.Enabled = False
                    End If
                End If
            End If
        End If
        If a = 1 And cbFinal.Checked = False And cbTrial.Checked = False Then
            If b = 1 Then
                If txtServicesType.Text = "" Or txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    Try
                        Me.Validate()
                        Me.pSQ.Insert(frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                  , txtServicesAmount.Text, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString)
                        Me.pSQ.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        frmAppoint.AppointmentsDBTableAdapter.Delete(frmAppoint.DataGridView1.CurrentRow.Cells(0).Value, frmAppoint.DataGridView1.CurrentRow.Cells(1).Value, frmAppoint.DataGridView1.CurrentRow.Cells(2).Value, frmAppoint.DataGridView1.CurrentRow.Cells(3).Value _
                                                              , frmAppoint.DataGridView1.CurrentRow.Cells(4).Value, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value)
                        frmAppoint.AppointmentsDBTableAdapter.Fill(frmAppoint.ToothImageDBDataSet.AppointmentsDB)
                        b = 0
                        Me.Close()
                        If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                            MainFormMetro.ButtonAdv4.Enabled = True
                            MainFormMetro.ButtonAdv5.Enabled = True
                        Else
                            MainFormMetro.ButtonAdv4.Enabled = False
                            MainFormMetro.ButtonAdv5.Enabled = False
                        End If
                        frmPatientProfile.Close()
                        Exit Sub
                    Catch ex As Exception
                        'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                        Exit Sub
                    End Try
                End If
            ElseIf b <> 1 Then
                If txtServicesType.Text = "" Or txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    Try
                        Me.Validate()
                        'Date.Now.ToShortDateString() + " " + Date.Now.ToLongTimeString()
                        Me.pSQ.Insert(frmPatientProfile.lblPFnameF.Text, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                      , txtServicesAmount.Text, dentst, frmPatientProfile.lblPFaddressF.Text)
                        Me.pSQ.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        MainFormMetro.tang = 1
                        Me.Close()
                        If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                            MainFormMetro.ButtonAdv4.Enabled = True
                            MainFormMetro.ButtonAdv5.Enabled = True
                        Else
                            MainFormMetro.ButtonAdv4.Enabled = False
                            MainFormMetro.ButtonAdv5.Enabled = False
                        End If
                        frmPatientProfile.Close()
                        Exit Sub
                    Catch ex As Exception
                        'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                        Exit Sub
                    End Try
                End If
            End If
        End If
        If a = 2 Then
            If b = 1 Then
                If txtServicesType.Text = "" Or txtServicesTN.Text <> "" Or txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    Try
                        Me.Validate()
                        'frmAppoint.DataGridView1.CurrentRow.Cells(2).Value.ToString + " " + frmAppoint.DataGridView1.CurrentRow.Cells(3).Value.ToString
                        Me.pSQ.Insert(frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                      , txtServicesAmount.Text, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString)
                        Me.pSQ.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        frmAppoint.AppointmentsDBTableAdapter.Delete(frmAppoint.DataGridView1.CurrentRow.Cells(0).Value, frmAppoint.DataGridView1.CurrentRow.Cells(1).Value, frmAppoint.DataGridView1.CurrentRow.Cells(2).Value, frmAppoint.DataGridView1.CurrentRow.Cells(3).Value _
                                                              , frmAppoint.DataGridView1.CurrentRow.Cells(4).Value, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value)
                        frmAppoint.AppointmentsDBTableAdapter.Fill(frmAppoint.ToothImageDBDataSet.AppointmentsDB)
                        b = 0
                        Me.Close()
                        If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                            MainFormMetro.ButtonAdv4.Enabled = True
                            MainFormMetro.ButtonAdv5.Enabled = True
                        Else
                            MainFormMetro.ButtonAdv4.Enabled = False
                            MainFormMetro.ButtonAdv5.Enabled = False
                        End If
                        frmPatientProfile.Close()
                        Exit Sub
                    Catch ex As Exception
                        'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                        Exit Sub
                    End Try
                End If
            ElseIf b <> 1 Then
                If txtServicesType.Text = "" Or txtServicesTN.Text <> "" Or txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                    MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                    Exit Sub
                Else
                    Try
                        Me.Validate()
                        Me.pSQ.Insert(frmPatientProfile.lblPFnameF.Text, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                      , txtServicesAmount.Text, dentst, frmPatientProfile.lblPFaddressF.Text)
                        Me.pSQ.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                        Me.Close()
                        If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                            MainFormMetro.ButtonAdv4.Enabled = True
                            MainFormMetro.ButtonAdv5.Enabled = True
                        Else
                            MainFormMetro.ButtonAdv4.Enabled = False
                            MainFormMetro.ButtonAdv5.Enabled = False
                        End If
                        frmPatientProfile.Close()
                        Exit Sub
                    Catch ex As Exception
                        'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                        Exit Sub
                    End Try
                End If
            End If
        End If
        If b = 1 Then
            If txtServicesType.Text = "" Or txtServicesTN.Text <> "" Or txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
                MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
                Exit Sub
            Else
                Try
                    Me.Validate()
                    Me.pSQ.Insert(frmAppoint.DataGridView1.CurrentRow.Cells(1).Value.ToString, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                                  , txtServicesAmount.Text, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value.ToString, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value.ToString)
                    Me.pSQ.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                    MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                    frmAppoint.AppointmentsDBTableAdapter.Delete(frmAppoint.DataGridView1.CurrentRow.Cells(0).Value, frmAppoint.DataGridView1.CurrentRow.Cells(1).Value, frmAppoint.DataGridView1.CurrentRow.Cells(2).Value, frmAppoint.DataGridView1.CurrentRow.Cells(3).Value _
                                                          , frmAppoint.DataGridView1.CurrentRow.Cells(4).Value, frmAppoint.DataGridView1.CurrentRow.Cells(5).Value, frmAppoint.DataGridView1.CurrentRow.Cells(6).Value)
                    frmAppoint.AppointmentsDBTableAdapter.Fill(frmAppoint.ToothImageDBDataSet.AppointmentsDB)
                    b = 0
                    Me.Close()
                    If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                        MainFormMetro.ButtonAdv4.Enabled = True
                        MainFormMetro.ButtonAdv5.Enabled = True
                    Else
                        MainFormMetro.ButtonAdv4.Enabled = False
                        MainFormMetro.ButtonAdv5.Enabled = False
                    End If
                    frmPatientProfile.Close()
                    Exit Sub
                Catch ex As Exception
                    'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                    Exit Sub
                End Try
            End If
        ElseIf txtServicesType.Text = "" Or txtServicesTN.Text = "" Or txtServicesAmount.Text = "" Or txtServicesAmount.Text = "0.00" Or txtServicesDentist.Text = "" Then
            MsgBox("You cannot leave a category empty! Please fill the missing informations.", vbExclamation, "Warning!")
            Exit Sub
        Else
            Try
                Me.Validate()
                Me.pSQ.Insert(frmPatientProfile.lblPFnameF.Text, txtServicesType.Text, Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString, txtServicesTN.Text _
                              , txtServicesAmount.Text, dentst, frmPatientProfile.lblPFaddressF.Text)
                Me.pSQ.Update(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                MainFormMetro.ServiceQueueDBTableAdapter.Fill(MainFormMetro.ToothImageDBDataSet.ServiceQueueDB)
                Me.Close()
                frmPatientProfile.Close()
                If MainFormMetro.DataGridView1.Rows.Count > 0 Then
                    MainFormMetro.ButtonAdv4.Enabled = True
                    MainFormMetro.ButtonAdv5.Enabled = True
                Else
                    MainFormMetro.ButtonAdv4.Enabled = False
                    MainFormMetro.ButtonAdv5.Enabled = False
                End If
                Exit Sub
            Catch ex As Exception
                'MsgBox("Adding patient to queue failed!", MsgBoxStyle.Critical, "Failed")
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception Error")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub txtServiceAmount_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServicesAmount.GotFocus
        If txtServicesAmount.Text = "0.00" Then
            txtServicesAmount.Text = ""
        End If
    End Sub

    Private Sub cbxServices2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxServices2.CheckedChanged
        If cbxServices2.Checked Then
            a = 2
            txtServicesTN.Text = ""
            txtServicesTN.Enabled = False
            txtServicesType.Text = ComboBox2.Text
            txtServicesType.Enabled = False
            cbxMedOnly.Enabled = False
            cbxServices1.Enabled = False
            cbDenture1.Enabled = False
            rbDenture1.Enabled = False
            rbDenture2.Enabled = False
            rbDenture3.Enabled = False
            ComboBox2.Enabled = True
            cbTrial.Enabled = False
            cbFinal.Enabled = False
            CheckBox1.Enabled = False
        Else
            a = 0
            txtServicesTN.Enabled = True
            txtServicesType.Enabled = True
            txtServicesType.Text = ""
            cbxMedOnly.Enabled = True
            cbxServices1.Enabled = True
            ComboBox2.Enabled = False
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub cbxServices1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxServices1.CheckedChanged
        If cbxServices1.Checked Then
            a = 1
            rbDenture1.Checked = True
            If rbDenture1.Checked = True Then
                txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture1.Text
            End If
            txtServicesTN.Text = ""
            txtServicesTN.Enabled = False
            txtServicesType.Enabled = False
            cbxMedOnly.Enabled = False
            cbxServices2.Enabled = False
            cbTrial.Enabled = True
            cbFinal.Enabled = True
            cbDenture1.Enabled = True
            rbDenture1.Enabled = True
            rbDenture2.Enabled = True
            rbDenture3.Enabled = True
            rbDenture4.Enabled = True
            rbDenture5.Enabled = True
            CheckBox1.Enabled = False
        Else
            a = 0
            txtServicesTN.Enabled = True
            txtServicesType.Enabled = True
            txtServicesType.Text = ""
            cbxMedOnly.Enabled = True
            cbTrial.Enabled = False
            cbFinal.Enabled = False
            cbxServices2.Enabled = True
            cbDenture1.Enabled = False
            rbDenture1.Enabled = False
            rbDenture2.Enabled = False
            rbDenture3.Enabled = False
            rbDenture4.Enabled = False
            rbDenture5.Enabled = False
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub rbDenture1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDenture1.CheckedChanged
        If rbDenture1.Checked = True Then
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture1.Text
        End If
    End Sub

    Private Sub rbDenture2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDenture2.CheckedChanged
        If rbDenture2.Checked = True Then
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture2.Text
        End If
    End Sub

    Private Sub rbDenture3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDenture3.CheckedChanged
        If rbDenture3.Checked = True Then
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture3.Text
        End If
    End Sub

    Private Sub cbTrial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTrial.CheckedChanged
        If cbTrial.Checked = True Then
            txtServicesType.Text = "Denture Follow-Up: " + cbTrial.Text
            cbFinal.Enabled = False
            cbDenture1.Enabled = False
            rbDenture1.Enabled = False
            rbDenture2.Enabled = False
            rbDenture3.Enabled = False
            txtServicesAmount.Enabled = False
        Else
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture1.Text
            cbFinal.Enabled = True
            cbDenture1.Enabled = True
            rbDenture1.Enabled = True
            rbDenture1.Select()
            rbDenture2.Enabled = True
            rbDenture3.Enabled = True
            txtServicesAmount.Enabled = True
        End If
    End Sub

    Private Sub cbFinal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFinal.CheckedChanged
        If cbFinal.Checked = True Then
            txtServicesType.Text = "Denture Follow-Up: " + cbFinal.Text
            cbTrial.Enabled = False
            cbDenture1.Enabled = False
            rbDenture1.Enabled = False
            rbDenture2.Enabled = False
            rbDenture3.Enabled = False
            txtServicesAmount.Enabled = False
        Else
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture1.Text
            cbTrial.Enabled = True
            cbDenture1.Enabled = True
            rbDenture1.Enabled = True
            rbDenture1.Select()
            rbDenture2.Enabled = True
            rbDenture3.Enabled = True
            txtServicesAmount.Enabled = True
        End If
    End Sub

    Private Sub cbDenture1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDenture1.SelectedIndexChanged
        If cbxServices1.Checked Then
            If rbDenture1.Checked = True Then
                txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture1.Text
            End If
            If rbDenture2.Checked = True Then
                txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture2.Text
            End If
            If rbDenture3.Checked = True Then
                txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture3.Text
            End If
            txtServicesTN.Text = ""
            txtServicesTN.Enabled = False
            txtServicesType.Enabled = False
            cbxServices2.Enabled = False
            cbTrial.Enabled = True
            cbFinal.Enabled = True
            cbDenture1.Enabled = True
            rbDenture1.Enabled = True
            rbDenture2.Enabled = True
            rbDenture3.Enabled = True
        End If
    End Sub

    Private Sub cbxMedOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMedOnly.CheckedChanged
        If cbxMedOnly.Checked = True Then
            a = 3
            txtServicesType.Text = "Medication Only"
            txtServicesTN.Text = ""
            txtServicesTN.Enabled = False
            txtServicesType.Enabled = False
            cbxServices1.Enabled = False
            cbxServices2.Enabled = False
            cbTrial.Enabled = False
            cbFinal.Enabled = False
            cbDenture1.Enabled = False
            rbDenture1.Enabled = False
            rbDenture2.Enabled = False
            rbDenture3.Enabled = False
            CheckBox1.Enabled = False
        Else
            a = 0
            txtServicesType.Text = ""
            txtServicesType.Enabled = True
            txtServicesTN.Enabled = True
            cbxServices1.Enabled = True
            cbxServices2.Enabled = True
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub txtServicesType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServicesType.GotFocus
        txtServicesType.SelectAll()
    End Sub

    Private Sub txtServicesAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServicesAmount.GotFocus
        txtServicesAmount.SelectAll()
    End Sub

    Private Sub txtServicesTN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServicesTN.GotFocus
        txtServicesTN.SelectAll()
    End Sub

    Private Sub txtServicesDentist_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServicesDentist.GotFocus
        txtServicesDentist.SelectAll()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtServicesType.Text = "Jacket: " + "(" + ComboBox1.Text + ")"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtServicesType.Text = "Fixed Bridge Jacket: " + "(" + ComboBox1.Text + ")"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If RadioButton1.Checked = True Then
            txtServicesType.Text = "Jacket: " + "(" + ComboBox1.Text + ")"
        ElseIf RadioButton2.Checked = True Then
            txtServicesType.Text = "Fixed Bridge Jacket: " + "(" + ComboBox1.Text + ")"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            RadioButton1.Checked = True
            txtServicesType.Text = "Jacket: " + "(" + ComboBox1.Text + ")"
            txtServicesType.Enabled = False
            cbxServices1.Enabled = False
            cbxServices2.Enabled = False
            cbxMedOnly.Enabled = False
            cbTrial.Enabled = False
            cbFinal.Enabled = False
            cbDenture1.Enabled = False
            rbDenture1.Enabled = False
            rbDenture2.Enabled = False
            rbDenture3.Enabled = False
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            ComboBox1.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            txtServicesType.Text = ""
            txtServicesType.Enabled = True
            cbxServices1.Enabled = True
            cbxServices2.Enabled = True
            cbxMedOnly.Enabled = True
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub rbDenture4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDenture4.CheckedChanged
        If rbDenture4.Checked = True Then
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture4.Text
        End If
    End Sub

    Private Sub rbButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDenture5.CheckedChanged
        If rbDenture5.Checked = True Then
            txtServicesType.Text = "Denture(" + cbDenture1.Text + "): " + rbDenture5.Text
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If cbxServices2.Checked = True Then
            txtServicesType.Text = ComboBox2.Text
        End If
    End Sub
End Class