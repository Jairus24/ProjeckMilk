<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientCard))
        Me.btnPSsearch = New System.Windows.Forms.Button()
        Me.gbPSmenu = New System.Windows.Forms.GroupBox()
        Me.btnPSbalance = New System.Windows.Forms.Button()
        Me.btnPSback = New System.Windows.Forms.Button()
        Me.btnPSregister = New System.Windows.Forms.Button()
        Me.gbPSmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPSsearch
        '
        Me.btnPSsearch.Location = New System.Drawing.Point(19, 19)
        Me.btnPSsearch.Name = "btnPSsearch"
        Me.btnPSsearch.Size = New System.Drawing.Size(104, 43)
        Me.btnPSsearch.TabIndex = 1
        Me.btnPSsearch.Text = "Search Patient Info"
        Me.btnPSsearch.UseVisualStyleBackColor = True
        '
        'gbPSmenu
        '
        Me.gbPSmenu.BackColor = System.Drawing.Color.Transparent
        Me.gbPSmenu.Controls.Add(Me.btnPSbalance)
        Me.gbPSmenu.Controls.Add(Me.btnPSback)
        Me.gbPSmenu.Controls.Add(Me.btnPSregister)
        Me.gbPSmenu.Controls.Add(Me.btnPSsearch)
        Me.gbPSmenu.Location = New System.Drawing.Point(12, 4)
        Me.gbPSmenu.Name = "gbPSmenu"
        Me.gbPSmenu.Size = New System.Drawing.Size(253, 122)
        Me.gbPSmenu.TabIndex = 1
        Me.gbPSmenu.TabStop = False
        Me.gbPSmenu.Text = "Cabinet Menu"
        '
        'btnPSbalance
        '
        Me.btnPSbalance.Location = New System.Drawing.Point(19, 68)
        Me.btnPSbalance.Name = "btnPSbalance"
        Me.btnPSbalance.Size = New System.Drawing.Size(104, 43)
        Me.btnPSbalance.TabIndex = 3
        Me.btnPSbalance.Text = "Patients with Balance"
        Me.btnPSbalance.UseVisualStyleBackColor = True
        '
        'btnPSback
        '
        Me.btnPSback.Location = New System.Drawing.Point(129, 68)
        Me.btnPSback.Name = "btnPSback"
        Me.btnPSback.Size = New System.Drawing.Size(104, 43)
        Me.btnPSback.TabIndex = 4
        Me.btnPSback.Text = "Back"
        Me.btnPSback.UseVisualStyleBackColor = True
        '
        'btnPSregister
        '
        Me.btnPSregister.Location = New System.Drawing.Point(129, 19)
        Me.btnPSregister.Name = "btnPSregister"
        Me.btnPSregister.Size = New System.Drawing.Size(104, 43)
        Me.btnPSregister.TabIndex = 2
        Me.btnPSregister.Text = "Register New Patient"
        Me.btnPSregister.UseVisualStyleBackColor = True
        '
        'frmPatientCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(275, 134)
        Me.Controls.Add(Me.gbPSmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatientCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Cabinet"
        Me.gbPSmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPSsearch As System.Windows.Forms.Button
    Friend WithEvents gbPSmenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnPSback As System.Windows.Forms.Button
    Friend WithEvents btnPSregister As System.Windows.Forms.Button
    Friend WithEvents btnPSbalance As System.Windows.Forms.Button
End Class
