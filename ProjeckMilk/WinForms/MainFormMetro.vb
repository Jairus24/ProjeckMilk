Imports System.Drawing.Text
Imports Syncfusion.WinForms.Controls
Imports System.Runtime.InteropServices

Public Class MainFormMetro
    Inherits SfForm
    Private _pfc As PrivateFontCollection = Nothing
    Dim day As Integer
    Public i As Integer = 1
    Dim h As Integer = 0
    Public m As Integer
    Public n As Integer = 0
    Dim o As Integer = m + 1
    Public auth As Integer = 0
    Dim ite As Integer = 0
    Public admin As String
    Public stats As String
    Public tang As Integer

    Public Sub New()
        InitializeComponent()

        'Me.Style.TitleBar.Height = 26
        'Me.Style.TitleBar.BackColor = Color.White
        'Me.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212)
        'Me.BackColor = Color.White
        'Me.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434")
        dateLabel.Text = "Today is " + Date.Now.ToString("dddd")
        day = Date.Now.ToString("dd")
        dateLabel2.Text = day.ToString + DaySuffix(day) + " of " + Date.Now.ToString("MMMM yyyy")
        dateLabel3.Text = ""
        Try
            _pfc = New PrivateFontCollection
            Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.Cancellaresca_Script.Length)
            Marshal.Copy(My.Resources.Cancellaresca_Script, 0, fontMemPointer, My.Resources.Cancellaresca_Script.Length)
            _pfc.AddMemoryFont(fontMemPointer, My.Resources.Cancellaresca_Script.Length)
            Marshal.FreeCoTaskMem(fontMemPointer)
        Catch ex As Exception
            'E
        End Try
        'Label3.UseCompatibleTextRendering = True
        'Label4.UseCompatibleTextRendering = True
        'Label3.Font = New Font(_pfc.Families(0), 70, FontStyle.Regular)
        'Label4.Font = New Font(_pfc.Families(0), 50, FontStyle.Regular)
        Style.Border = New Pen(Color.White, 0)
        Me.Style.TitleBar.CloseButtonForeColor = Color.DarkGray
        Me.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray
        Me.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray
        Me.Style.TitleBar.HelpButtonForeColor = Color.DarkGray
        Me.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Style.TitleBar.Font = Me.Font
        Me.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center
        Me.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center
    End Sub

    Private Sub btnSQDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataGridView1.Rows(0).Selected = True
        frmMed.ShowDialog(Me)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.Rows(0).Selected = True Then
            Dim mrslt As Integer
            mrslt = MsgBox("Is " + DataGridView1.CurrentRow.Cells(1).Value.ToString + " done with the service?", MsgBoxStyle.YesNo, "Out " + DataGridView1.CurrentRow.Cells(1).Value.ToString)
            If mrslt = MsgBoxResult.Yes Then
                btnSQDone_Click(sender, New System.EventArgs())
            End If
        Else
            ButtonAdv5_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub MainFormMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        frmLogin.ShowDialog(Me)
        m = Date.Now.Minute
        i = 1
        Try

            Me.ServiceQueueTableAdapter.Fill(Me.PLDBDataSet.serviceQueue)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access Database Engine is installed.", vbCritical, "Database Error")
            'End
        End Try
        DataGridView1.Columns(0).Visible = False
        If DataGridView1.Rows.Count > 0 Then
            ButtonAdv4.Enabled = True
            ButtonAdv5.Enabled = True
        Else
            ButtonAdv4.Enabled = False
            ButtonAdv5.Enabled = False
        End If
        Timer1.Start()
    End Sub

    Function DaySuffix(dayTemp As Integer) As String
        Select Case dayTemp
            Case 1
            Case 21
            Case 31
                Return "st"
            Case 2
            Case 22
                Return "nd"
            Case 3
            Case 23
                Return "rd"
            Case Else
                Return "th"
                Exit Select
        End Select
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        dateLabel.Text = "Today is " + Date.Now.ToString("dddd")
        day = Date.Now.ToString("dd")
        dateLabel2.Text = day.ToString + DaySuffix(day) + " of " + Date.Now.ToString("MMMM yyyy")
        dateLabel3.Text = TimeOfDay.ToLongTimeString
        If IsKeyLocked(Keys.CapsLock) = True Then
            'ToolStripStatusLabel6.Text = "CAPS"
            'ToolStripStatusLabel6.Enabled = True
        Else
            'ToolStripStatusLabel6.Text = "CAPS"
            'ToolStripStatusLabel6.Enabled = False
        End If
        If IsKeyLocked(Keys.NumLock) = True Then
            'ToolStripStatusLabel7.Text = "NUM"
            'ToolStripStatusLabel7.Enabled = True
        Else
            'ToolStripStatusLabel7.Text = "NUM"
            'ToolStripStatusLabel7.Enabled = False
        End If
        If n = 1 Then
            n = 0
            Try
                BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception
            End Try
        ElseIf BackgroundWorker1.WorkerSupportsCancellation = True Then
            BackgroundWorker1.CancelAsync()
        End If
        If m = o Then
            n = 1
        End If
        m = Date.Now.Minute
    End Sub

    Private Sub BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending = True Then
            e.Cancel = True
        End If
        Dim dv As DataView = New DataView
        Me.ApptmntTableAdapter.Fill(Me.PLDBDataSet.apptmnt)
        dv.Table = PLDBDataSet.apptmnt
        dv.RowFilter = "apptDate = '" & Date.Now.ToShortDateString() & "'"
        Me.DataGridView2.DataSource = dv
        h = Me.DataGridView2.RowCount - 1
        For z As Integer = 0 To Me.DataGridView2.RowCount - 1
            If Me.DataGridView2.Rows(z).Cells(3).Value = Date.Now.ToShortTimeString Then
                ite += 1
            End If
        Next
        If ite = 1 Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Appointments Alert"
            NotifyIcon1.BalloonTipText = ite.ToString + " patient has an appointment scheduled at " + Date.Now.ToShortTimeString + ". Please check the appointments section."
            NotifyIcon1.ShowBalloonTip(20000)
            ite = 0
            i = 0
        ElseIf ite > 1 Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Appointments Alert"
            NotifyIcon1.BalloonTipText = ite.ToString + " patients has an appointment scheduled at " + Date.Now.ToShortTimeString + ". Please check the appointments section."
            NotifyIcon1.ShowBalloonTip(20000)
            ite = 0
            i = 0
        End If
        If i = 1 And h > 0 Then
            If h = 1 Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipTitle = "Appointments Alert"
                NotifyIcon1.BalloonTipText = "There are " + h.ToString + " appointment scheduled for today. Check the appointments section for more details."
                NotifyIcon1.ShowBalloonTip(20000)
                i = 0
            ElseIf h > 1 Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipTitle = "Appointments Alert"
                NotifyIcon1.BalloonTipText = "There are " + h.ToString + " appointments scheduled for today. Check the appointments section for more details."
                NotifyIcon1.ShowBalloonTip(20000)
                i = 0
            End If
        End If
        If i = 1 And h = 0 Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Appointments Alert"
            NotifyIcon1.BalloonTipText = "There is no any appointments scheduled for today."
            NotifyIcon1.ShowBalloonTip(20000)
            i = 0
        End If
        If m >= 59 Then
            o = 0
        Else
            o = m + 1
        End If
    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click
        frmPatientCard.ShowDialog(Me)
    End Sub

    Private Sub ButtonAdv3_Click(sender As Object, e As EventArgs) Handles ButtonAdv3.Click
        frmSummary.Show(Me)
        ButtonAdv3.Enabled = False
    End Sub

    Private Sub ButtonAdv5_Click(sender As Object, e As EventArgs) Handles ButtonAdv5.Click
        Dim conf As Integer
        conf = MsgBox("Do you really want to remove " + Me.DataGridView1.CurrentRow.Cells(1).Value.ToString + " from the queue list?", MsgBoxStyle.YesNo, "Confirm Cancelation")
        If conf = MsgBoxResult.Yes Then
            Me.ServiceQueueTableAdapter.Delete(Me.DataGridView1.CurrentRow.Cells(0).Value, Me.DataGridView1.CurrentRow.Cells(1).Value.ToString _
                                                                  , Me.DataGridView1.CurrentRow.Cells(2).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(3).Value _
                                                                  , Me.DataGridView1.CurrentRow.Cells(4).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(5).Value.ToString() _
                                                                  , Me.DataGridView1.CurrentRow.Cells(6).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(7).Value.ToString())
            Me.ServiceQueueTableAdapter.Fill(Me.PLDBDataSet.serviceQueue)
            If DataGridView1.Rows.Count > 0 Then
                ButtonAdv4.Enabled = True
                ButtonAdv5.Enabled = True
            Else
                ButtonAdv4.Enabled = False
                ButtonAdv5.Enabled = False
            End If
        End If
    End Sub

    Private Sub ButtonAdv6_Click(sender As Object, e As EventArgs) Handles ButtonAdv6.Click
        frmAdminArea.ShowDialog(Me)
    End Sub

    Private Sub ButtonAdv7_Click(sender As Object, e As EventArgs) Handles ButtonAdv7.Click
        frmAbout.ShowDialog(Me)
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        frmAppoint.Show(Me)
        ButtonAdv2.Enabled = False
    End Sub

    Private Sub MainFormMetro_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        End
    End Sub

    Private Sub ButtonAdv4_Click(sender As Object, e As EventArgs) Handles ButtonAdv4.Click
        DataGridView1.Rows(0).Selected = True
        Dim z As String = Me.DataGridView1.CurrentRow.Cells(5).Value.ToString
        If z = "0.0000" Or z = "0" Or tang = 1 Then
            Dim aa As String = "N/A"
            Dim bal As String = "0.0000"
            Dim dat As Date = Me.DataGridView1.CurrentRow.Cells(3).Value
            frmPatientProfile.ServiceRecordTableAdapter.Insert(Me.DataGridView1.CurrentRow.Cells(1).Value.ToString, Me.DataGridView1.CurrentRow.Cells(2).Value.ToString _
                                                               , dat.ToShortDateString, Me.DataGridView1.CurrentRow.Cells(4).Value.ToString, aa, Me.DataGridView1.CurrentRow.Cells(5).Value, bal _
                                                               , Me.DataGridView1.CurrentRow.Cells(6).Value.ToString, bal, dat.ToShortTimeString, Me.DataGridView1.CurrentRow.Cells(7).Value.ToString)
            Me.ServiceQueueTableAdapter.Delete(Me.DataGridView1.CurrentRow.Cells(0).Value, Me.DataGridView1.CurrentRow.Cells(1).Value.ToString _
                                                                  , Me.DataGridView1.CurrentRow.Cells(2).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(3).Value _
                                                                  , Me.DataGridView1.CurrentRow.Cells(4).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(5).Value.ToString() _
                                                                  , Me.DataGridView1.CurrentRow.Cells(6).Value.ToString(), Me.DataGridView1.CurrentRow.Cells(7).Value.ToString())
            Me.ServiceQueueTableAdapter.Fill(Me.PLDBDataSet.serviceQueue)
            If DataGridView1.Rows.Count > 0 Then
                ButtonAdv4.Enabled = True
                ButtonAdv5.Enabled = True
            Else
                ButtonAdv4.Enabled = False
                ButtonAdv5.Enabled = False
            End If
        Else
            frmMed.ShowDialog(Me)
        End If
    End Sub
End Class
