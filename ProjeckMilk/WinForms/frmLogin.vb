Public Class frmLogin
    Dim a As Integer = 0
    Public n As String
    Public c As Integer
    Private Sub btnLoginExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginExit.Click
        MainFormMetro.NotifyIcon1.Visible = False
        MainFormMetro.NotifyIcon1.Dispose()
        End
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PLDBDataSet.adminDB' table. You can move, or remove it, as needed.
        Try
            Me.AdminDBTableAdapter.Fill(Me.PLDBDataSet.adminDB)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
        txtLoginUN.Text = n
        txtLoginPass.Text = ""
        If Me.DataGridView1.Rows(Me.a).Cells(0).Value.ToString = "admin" And Me.DataGridView1.Rows(Me.a).Cells(1).Value.ToString = "admin" Then
            lblLogInNote.Visible = True
            lblNote1.Visible = True
            lblNote2.Visible = True
        End If
        If c = 1 Then
            btnConfirm.Visible = True
            btnCancel.Visible = True
            btnLoginOK.Visible = False
            btnLoginExit.Visible = False
            btnLoginOK.Enabled = False
            btnLoginExit.Enabled = False
            Me.Text = "Confirm Delete\Edit"
        Else
            btnConfirm.Visible = False
            btnCancel.Visible = False
            btnLoginOK.Visible = True
            btnLoginExit.Visible = True
            btnLoginOK.Enabled = True
            btnLoginExit.Enabled = True
            Me.Text = "Administrator Login"
        End If
    End Sub

    Private Sub btnLoginOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginOK.Click
        For Me.a = 0 To (Me.DataGridView1.RowCount - 1)
            If txtLoginUN.Text = Me.DataGridView1.Rows(Me.a).Cells(0).Value.ToString And txtLoginPass.Text = Me.DataGridView1.Rows(Me.a).Cells(1).Value.ToString Then
                MainFormMetro.Text = "Tooth Image Dental Records™ - " + "Administrator: " + txtLoginUN.Text
                MainFormMetro.BackgroundWorker1.RunWorkerAsync()
                MainFormMetro.auth = 1
                MainFormMetro.admin = txtLoginUN.Text
                Me.Close()
                Exit Sub
            Else
                MainFormMetro.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                MainFormMetro.NotifyIcon1.BalloonTipTitle = "Login Failed"
                MainFormMetro.NotifyIcon1.BalloonTipText = "Wrong username or password. Please try again."
                MainFormMetro.NotifyIcon1.ShowBalloonTip(10000)
                txtLoginPass.Text = ""
                txtLoginUN.Focus()
            End If
        Next
    End Sub
    Private Sub frmLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginExit.Click
        MainFormMetro.NotifyIcon1.Dispose()
    End Sub
    Private Sub txtLoginPass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoginPass.KeyDown
        If e.KeyCode = Keys.Enter And c = 0 Then
            btnLoginOK_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter And c = 1 Then
            btnConfirm_Click(sender, e)
        End If
    End Sub
    Private Sub txtLoginUN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoginUN.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLoginPass.Focus()
        End If
    End Sub
    Private Sub txtLoginUN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoginUN.GotFocus
        If txtLoginUN.Text <> "" Then
            txtLoginUN.SelectAll()
        End If
    End Sub
    Private Sub txtLoginPass_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoginPass.GotFocus
        txtLoginPass.SelectAll()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmPatientSearch.b = 2
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        For Me.a = 0 To (Me.DataGridView1.RowCount - 1)
            If txtLoginUN.Text = Me.DataGridView1.Rows(Me.a).Cells(0).Value.ToString And txtLoginPass.Text = Me.DataGridView1.Rows(Me.a).Cells(1).Value.ToString Then
                frmPatientSearch.b = 1
                c = 0
                Me.Close()
                Exit Sub
            Else
                MainFormMetro.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                MainFormMetro.NotifyIcon1.BalloonTipTitle = "Verification Failed"
                MainFormMetro.NotifyIcon1.BalloonTipText = "Wrong username or password. Please try again."
                MainFormMetro.NotifyIcon1.ShowBalloonTip(10000)
                txtLoginPass.Text = ""
                txtLoginUN.Focus()
            End If
        Next
    End Sub
End Class
