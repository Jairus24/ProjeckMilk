<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminArea
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminArea))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDBDataSet = New ProjeckMilk.PLDBDataSet()
        Me.AdminDBTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.adminDBTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tpAdminChange = New System.Windows.Forms.TabPage()
        Me.gbAdminChange = New System.Windows.Forms.GroupBox()
        Me.txtNewUN = New System.Windows.Forms.TextBox()
        Me.lblNewUN = New System.Windows.Forms.Label()
        Me.btnAdminSave = New System.Windows.Forms.Button()
        Me.lblMainNP = New System.Windows.Forms.Label()
        Me.mtxtAdminREN = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAdminOP = New System.Windows.Forms.MaskedTextBox()
        Me.lblMainREN = New System.Windows.Forms.Label()
        Me.lblAdminOP = New System.Windows.Forms.Label()
        Me.mtxtAdminNP = New System.Windows.Forms.MaskedTextBox()
        Me.tbAdminDB = New System.Windows.Forms.TabPage()
        Me.gbAdminDB = New System.Windows.Forms.GroupBox()
        Me.lblLocationPath = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnAdminDB = New System.Windows.Forms.Button()
        Me.tcAdminChange = New System.Windows.Forms.TabControl()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAdminChange.SuspendLayout()
        Me.gbAdminChange.SuspendLayout()
        Me.tbAdminDB.SuspendLayout()
        Me.gbAdminDB.SuspendLayout()
        Me.tcAdminChange.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AdminDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(64, 22)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.Visible = False
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'AdminDBBindingSource
        '
        Me.AdminDBBindingSource.DataMember = "adminDB"
        Me.AdminDBBindingSource.DataSource = Me.PLDBDataSet
        '
        'PLDBDataSet
        '
        Me.PLDBDataSet.DataSetName = "PLDBDataSet"
        Me.PLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminDBTableAdapter
        '
        Me.AdminDBTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(266, 302)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tpAdminChange
        '
        Me.tpAdminChange.Controls.Add(Me.gbAdminChange)
        Me.tpAdminChange.Location = New System.Drawing.Point(4, 22)
        Me.tpAdminChange.Name = "tpAdminChange"
        Me.tpAdminChange.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdminChange.Size = New System.Drawing.Size(341, 269)
        Me.tpAdminChange.TabIndex = 0
        Me.tpAdminChange.Text = "Change Admin Info"
        Me.tpAdminChange.UseVisualStyleBackColor = True
        '
        'gbAdminChange
        '
        Me.gbAdminChange.Controls.Add(Me.txtNewUN)
        Me.gbAdminChange.Controls.Add(Me.lblNewUN)
        Me.gbAdminChange.Controls.Add(Me.btnAdminSave)
        Me.gbAdminChange.Controls.Add(Me.lblMainNP)
        Me.gbAdminChange.Controls.Add(Me.mtxtAdminREN)
        Me.gbAdminChange.Controls.Add(Me.mtxtAdminOP)
        Me.gbAdminChange.Controls.Add(Me.lblMainREN)
        Me.gbAdminChange.Controls.Add(Me.lblAdminOP)
        Me.gbAdminChange.Controls.Add(Me.mtxtAdminNP)
        Me.gbAdminChange.Location = New System.Drawing.Point(0, 0)
        Me.gbAdminChange.Name = "gbAdminChange"
        Me.gbAdminChange.Size = New System.Drawing.Size(338, 263)
        Me.gbAdminChange.TabIndex = 7
        Me.gbAdminChange.TabStop = False
        Me.gbAdminChange.Text = "Account Manager"
        '
        'txtNewUN
        '
        Me.txtNewUN.Location = New System.Drawing.Point(158, 51)
        Me.txtNewUN.Name = "txtNewUN"
        Me.txtNewUN.Size = New System.Drawing.Size(141, 20)
        Me.txtNewUN.TabIndex = 1
        Me.txtNewUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNewUN
        '
        Me.lblNewUN.AutoSize = True
        Me.lblNewUN.Location = New System.Drawing.Point(44, 54)
        Me.lblNewUN.Name = "lblNewUN"
        Me.lblNewUN.Size = New System.Drawing.Size(108, 13)
        Me.lblNewUN.TabIndex = 7
        Me.lblNewUN.Text = "Enter New Username"
        '
        'btnAdminSave
        '
        Me.btnAdminSave.Location = New System.Drawing.Point(224, 213)
        Me.btnAdminSave.Name = "btnAdminSave"
        Me.btnAdminSave.Size = New System.Drawing.Size(75, 23)
        Me.btnAdminSave.TabIndex = 5
        Me.btnAdminSave.Text = "Save"
        Me.btnAdminSave.UseVisualStyleBackColor = True
        '
        'lblMainNP
        '
        Me.lblMainNP.AutoSize = True
        Me.lblMainNP.Location = New System.Drawing.Point(47, 135)
        Me.lblMainNP.Name = "lblMainNP"
        Me.lblMainNP.Size = New System.Drawing.Size(109, 13)
        Me.lblMainNP.TabIndex = 1
        Me.lblMainNP.Text = "Enter New Password:"
        '
        'mtxtAdminREN
        '
        Me.mtxtAdminREN.Location = New System.Drawing.Point(158, 168)
        Me.mtxtAdminREN.Name = "mtxtAdminREN"
        Me.mtxtAdminREN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mtxtAdminREN.Size = New System.Drawing.Size(141, 20)
        Me.mtxtAdminREN.TabIndex = 4
        Me.mtxtAdminREN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtAdminOP
        '
        Me.mtxtAdminOP.Location = New System.Drawing.Point(158, 92)
        Me.mtxtAdminOP.Name = "mtxtAdminOP"
        Me.mtxtAdminOP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mtxtAdminOP.Size = New System.Drawing.Size(141, 20)
        Me.mtxtAdminOP.TabIndex = 2
        Me.mtxtAdminOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMainREN
        '
        Me.lblMainREN.AutoSize = True
        Me.lblMainREN.Location = New System.Drawing.Point(30, 171)
        Me.lblMainREN.Name = "lblMainREN"
        Me.lblMainREN.Size = New System.Drawing.Size(126, 13)
        Me.lblMainREN.TabIndex = 2
        Me.lblMainREN.Text = "Re-Enter New Password:"
        '
        'lblAdminOP
        '
        Me.lblAdminOP.AutoSize = True
        Me.lblAdminOP.Location = New System.Drawing.Point(53, 95)
        Me.lblAdminOP.Name = "lblAdminOP"
        Me.lblAdminOP.Size = New System.Drawing.Size(103, 13)
        Me.lblAdminOP.TabIndex = 0
        Me.lblAdminOP.Text = "Enter Old Password:"
        '
        'mtxtAdminNP
        '
        Me.mtxtAdminNP.Location = New System.Drawing.Point(158, 132)
        Me.mtxtAdminNP.Name = "mtxtAdminNP"
        Me.mtxtAdminNP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mtxtAdminNP.Size = New System.Drawing.Size(141, 20)
        Me.mtxtAdminNP.TabIndex = 3
        Me.mtxtAdminNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbAdminDB
        '
        Me.tbAdminDB.Controls.Add(Me.gbAdminDB)
        Me.tbAdminDB.Location = New System.Drawing.Point(4, 22)
        Me.tbAdminDB.Name = "tbAdminDB"
        Me.tbAdminDB.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAdminDB.Size = New System.Drawing.Size(341, 269)
        Me.tbAdminDB.TabIndex = 1
        Me.tbAdminDB.Text = "Database Backup"
        Me.tbAdminDB.UseVisualStyleBackColor = True
        '
        'gbAdminDB
        '
        Me.gbAdminDB.Controls.Add(Me.lblLocationPath)
        Me.gbAdminDB.Controls.Add(Me.lblLocation)
        Me.gbAdminDB.Controls.Add(Me.btnAdminDB)
        Me.gbAdminDB.Location = New System.Drawing.Point(0, 0)
        Me.gbAdminDB.Name = "gbAdminDB"
        Me.gbAdminDB.Size = New System.Drawing.Size(338, 263)
        Me.gbAdminDB.TabIndex = 1
        Me.gbAdminDB.TabStop = False
        Me.gbAdminDB.Text = "Database Manager"
        '
        'lblLocationPath
        '
        Me.lblLocationPath.AutoSize = True
        Me.lblLocationPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationPath.Location = New System.Drawing.Point(107, 68)
        Me.lblLocationPath.Name = "lblLocationPath"
        Me.lblLocationPath.Size = New System.Drawing.Size(134, 20)
        Me.lblLocationPath.TabIndex = 2
        Me.lblLocationPath.Text = "C:\Data_Backups"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(9, 16)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(204, 20)
        Me.lblLocation.TabIndex = 1
        Me.lblLocation.Text = "Backup Folder Location:"
        '
        'btnAdminDB
        '
        Me.btnAdminDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminDB.Location = New System.Drawing.Point(67, 132)
        Me.btnAdminDB.Name = "btnAdminDB"
        Me.btnAdminDB.Size = New System.Drawing.Size(216, 28)
        Me.btnAdminDB.TabIndex = 0
        Me.btnAdminDB.Text = "BACKUP DATABASE"
        Me.btnAdminDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdminDB.UseVisualStyleBackColor = True
        '
        'tcAdminChange
        '
        Me.tcAdminChange.Controls.Add(Me.tbAdminDB)
        Me.tcAdminChange.Controls.Add(Me.tpAdminChange)
        Me.tcAdminChange.Location = New System.Drawing.Point(-1, 1)
        Me.tcAdminChange.Name = "tcAdminChange"
        Me.tcAdminChange.SelectedIndex = 0
        Me.tcAdminChange.Size = New System.Drawing.Size(349, 295)
        Me.tcAdminChange.TabIndex = 0
        '
        'frmAdminArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tcAdminChange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdminArea"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Area"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAdminChange.ResumeLayout(False)
        Me.gbAdminChange.ResumeLayout(False)
        Me.gbAdminChange.PerformLayout()
        Me.tbAdminDB.ResumeLayout(False)
        Me.gbAdminDB.ResumeLayout(False)
        Me.gbAdminDB.PerformLayout()
        Me.tcAdminChange.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PLDBDataSet As ProjeckMilk.PLDBDataSet
    Friend WithEvents AdminDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminDBTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.adminDBTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tpAdminChange As System.Windows.Forms.TabPage
    Friend WithEvents gbAdminChange As System.Windows.Forms.GroupBox
    Friend WithEvents txtNewUN As System.Windows.Forms.TextBox
    Friend WithEvents lblNewUN As System.Windows.Forms.Label
    Friend WithEvents btnAdminSave As System.Windows.Forms.Button
    Friend WithEvents lblMainNP As System.Windows.Forms.Label
    Friend WithEvents mtxtAdminREN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAdminOP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblMainREN As System.Windows.Forms.Label
    Friend WithEvents lblAdminOP As System.Windows.Forms.Label
    Friend WithEvents mtxtAdminNP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbAdminDB As System.Windows.Forms.TabPage
    Friend WithEvents gbAdminDB As System.Windows.Forms.GroupBox
    Friend WithEvents lblLocationPath As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btnAdminDB As System.Windows.Forms.Button
    Friend WithEvents tcAdminChange As System.Windows.Forms.TabControl
End Class
