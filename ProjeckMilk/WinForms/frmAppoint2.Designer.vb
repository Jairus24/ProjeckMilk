<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppoint2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppoint2))
        Me.gbAdd01 = New System.Windows.Forms.GroupBox()
        Me.btnAddCancel = New System.Windows.Forms.Button()
        Me.btnAddAdd = New System.Windows.Forms.Button()
        Me.dtpAdd02 = New System.Windows.Forms.DateTimePicker()
        Me.lblAddTime = New System.Windows.Forms.Label()
        Me.dtpAdd01 = New System.Windows.Forms.DateTimePicker()
        Me.lblAddDate = New System.Windows.Forms.Label()
        Me.txtAdd02 = New System.Windows.Forms.TextBox()
        Me.lblAddDentist = New System.Windows.Forms.Label()
        Me.gbAdd01.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAdd01
        '
        Me.gbAdd01.BackColor = System.Drawing.Color.Transparent
        Me.gbAdd01.Controls.Add(Me.btnAddCancel)
        Me.gbAdd01.Controls.Add(Me.btnAddAdd)
        Me.gbAdd01.Controls.Add(Me.dtpAdd02)
        Me.gbAdd01.Controls.Add(Me.lblAddTime)
        Me.gbAdd01.Controls.Add(Me.dtpAdd01)
        Me.gbAdd01.Controls.Add(Me.lblAddDate)
        Me.gbAdd01.Controls.Add(Me.txtAdd02)
        Me.gbAdd01.Controls.Add(Me.lblAddDentist)
        Me.gbAdd01.Location = New System.Drawing.Point(13, 13)
        Me.gbAdd01.Name = "gbAdd01"
        Me.gbAdd01.Size = New System.Drawing.Size(286, 225)
        Me.gbAdd01.TabIndex = 0
        Me.gbAdd01.TabStop = False
        Me.gbAdd01.Text = "Additional Information"
        '
        'btnAddCancel
        '
        Me.btnAddCancel.Location = New System.Drawing.Point(151, 191)
        Me.btnAddCancel.Name = "btnAddCancel"
        Me.btnAddCancel.Size = New System.Drawing.Size(129, 23)
        Me.btnAddCancel.TabIndex = 6
        Me.btnAddCancel.Text = "Cancel"
        Me.btnAddCancel.UseVisualStyleBackColor = True
        '
        'btnAddAdd
        '
        Me.btnAddAdd.Location = New System.Drawing.Point(151, 162)
        Me.btnAddAdd.Name = "btnAddAdd"
        Me.btnAddAdd.Size = New System.Drawing.Size(129, 23)
        Me.btnAddAdd.TabIndex = 5
        Me.btnAddAdd.Text = "Add to Appointments"
        Me.btnAddAdd.UseVisualStyleBackColor = True
        '
        'dtpAdd02
        '
        Me.dtpAdd02.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpAdd02.Location = New System.Drawing.Point(10, 89)
        Me.dtpAdd02.Name = "dtpAdd02"
        Me.dtpAdd02.ShowUpDown = True
        Me.dtpAdd02.Size = New System.Drawing.Size(270, 20)
        Me.dtpAdd02.TabIndex = 3
        '
        'lblAddTime
        '
        Me.lblAddTime.AutoSize = True
        Me.lblAddTime.BackColor = System.Drawing.Color.Transparent
        Me.lblAddTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTime.Location = New System.Drawing.Point(6, 65)
        Me.lblAddTime.Name = "lblAddTime"
        Me.lblAddTime.Size = New System.Drawing.Size(47, 20)
        Me.lblAddTime.TabIndex = 9
        Me.lblAddTime.Text = "Time:"
        '
        'dtpAdd01
        '
        Me.dtpAdd01.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdd01.Location = New System.Drawing.Point(10, 40)
        Me.dtpAdd01.Name = "dtpAdd01"
        Me.dtpAdd01.ShowUpDown = True
        Me.dtpAdd01.Size = New System.Drawing.Size(270, 20)
        Me.dtpAdd01.TabIndex = 2
        '
        'lblAddDate
        '
        Me.lblAddDate.AutoSize = True
        Me.lblAddDate.BackColor = System.Drawing.Color.Transparent
        Me.lblAddDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDate.Location = New System.Drawing.Point(6, 16)
        Me.lblAddDate.Name = "lblAddDate"
        Me.lblAddDate.Size = New System.Drawing.Size(48, 20)
        Me.lblAddDate.TabIndex = 8
        Me.lblAddDate.Text = "Date:"
        '
        'txtAdd02
        '
        Me.txtAdd02.Location = New System.Drawing.Point(10, 136)
        Me.txtAdd02.Name = "txtAdd02"
        Me.txtAdd02.Size = New System.Drawing.Size(270, 20)
        Me.txtAdd02.TabIndex = 4
        '
        'lblAddDentist
        '
        Me.lblAddDentist.AutoSize = True
        Me.lblAddDentist.BackColor = System.Drawing.Color.Transparent
        Me.lblAddDentist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDentist.Location = New System.Drawing.Point(6, 112)
        Me.lblAddDentist.Name = "lblAddDentist"
        Me.lblAddDentist.Size = New System.Drawing.Size(64, 20)
        Me.lblAddDentist.TabIndex = 7
        Me.lblAddDentist.Text = "Dentist:"
        '
        'frmAppoint2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(311, 252)
        Me.Controls.Add(Me.gbAdd01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppoint2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Appointments"
        Me.gbAdd01.ResumeLayout(False)
        Me.gbAdd01.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbAdd01 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddAdd As System.Windows.Forms.Button
    Friend WithEvents dtpAdd02 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAddTime As System.Windows.Forms.Label
    Friend WithEvents dtpAdd01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAddDate As System.Windows.Forms.Label
    Friend WithEvents txtAdd02 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddDentist As System.Windows.Forms.Label
End Class
