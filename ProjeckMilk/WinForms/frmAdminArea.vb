Imports System
Imports System.IO
Public Class frmAdminArea

    Private Sub frmAdminArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PLDBDataSet.adminDB' table. You can move, or remove it, as needed.
        Try
            Me.AdminDBTableAdapter.Fill(Me.PLDBDataSet.adminDB)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
        mtxtAdminOP.Text = ""
        mtxtAdminNP.Text = ""
        mtxtAdminREN.Text = ""
        txtNewUN.Text = MainFormMetro.admin
    End Sub

    Private Sub btnAdminBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        MainFormMetro.Enabled = True
        MainFormMetro.BringToFront()
    End Sub

    Private Sub btnAdminDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminDB.Click
        Dim apPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        Try
            My.Computer.FileSystem.CopyDirectory(apPath + "\DataSources", "C:\Data_Backups", True)
            MsgBox("Backup Complete!", vbInformation, "Done")
        Catch ex As Exception
            Directory.CreateDirectory("C:\Data_Backups")
            My.Computer.FileSystem.CopyDirectory(apPath + "\DataSources", "C:\Data_Backups", True)
            MsgBox("Backup Complete!", vbInformation, "Done")
        End Try
    End Sub
    Public Shared Sub CopyDirectory( _
 ByVal sourceDirectoryName As String, _
 ByVal destinationDirectoryName As String _
)
    End Sub

    Private Sub btnAdminSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminSave.Click
        If txtNewUN.Text <> "" And mtxtAdminNP.Text <> "" And mtxtAdminOP.Text <> "" And mtxtAdminREN.Text <> "" And mtxtAdminNP.Text = mtxtAdminREN.Text Then
            If MainFormMetro.admin = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString And mtxtAdminOP.Text = Me.DataGridView1.CurrentRow.Cells(1).Value.ToString And mtxtAdminNP.Text = mtxtAdminREN.Text Then
                DataGridView1.CurrentRow.Cells(0).Value = txtNewUN.Text
                DataGridView1.CurrentRow.Cells(1).Value = mtxtAdminNP.Text
                ValidateChildren()
                DataGridView1.EndEdit()
                AdminDBTableAdapter.Update(Me.PLDBDataSet.adminDB)
                AdminDBTableAdapter.Fill(Me.PLDBDataSet.adminDB)
                MsgBox("Administrator account information has been changed.", vbInformation, "Admin Change")
                frmLogin.n = txtNewUN.Text
                frmLogin.txtLoginPass.Text = ""
                Close()
                MainFormMetro.Hide()
                frmLogin.ShowDialog()
                MainFormMetro.Show()
                Exit Sub
            End If
            If mtxtAdminOP.Text <> Me.DataGridView1.CurrentRow.Cells(1).Value.ToString Then
                MsgBox("Incorrect OLD password. Please try again.", vbExclamation, "Password Change")
            End If
        ElseIf mtxtAdminNP.Text <> mtxtAdminREN.Text Then
            MsgBox("The NEW password does not match. Please try again.", vbExclamation, "Password Change")
        Else
            MsgBox("Several information has been left empty. Please fill-in the proper information before proceeding.", vbExclamation, "Warning!")
        End If
    End Sub
    Private Sub txtNewUN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewUN.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtxtAdminOP.Focus()
        End If
    End Sub
    Private Sub txtNewUN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewUN.GotFocus
        txtNewUN.SelectAll()
    End Sub
    Private Sub mtxtAdminOP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtxtAdminOP.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtxtAdminNP.Focus()
        End If
    End Sub
    Private Sub mtxtAdminOP_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtAdminOP.GotFocus
        mtxtAdminOP.SelectAll()
    End Sub
    Private Sub mtxtAdminNP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtxtAdminNP.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtxtAdminREN.Focus()
        End If
    End Sub
    Private Sub mtxtAdminNP_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtAdminNP.GotFocus
        mtxtAdminNP.SelectAll()
    End Sub
    Private Sub mtxtAdminREN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtAdminREN.GotFocus
        mtxtAdminNP.SelectAll()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class