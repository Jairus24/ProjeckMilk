<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLoginOK = New System.Windows.Forms.Button()
        Me.btnLoginExit = New System.Windows.Forms.Button()
        Me.lblLoginUN = New System.Windows.Forms.Label()
        Me.lblLoginPass = New System.Windows.Forms.Label()
        Me.txtLoginUN = New System.Windows.Forms.TextBox()
        Me.txtLoginPass = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AdminIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDBBindingSourceSQL = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToothImageDBDataSet = New ProjeckMilk.ToothImageDBDataSet()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblLogInNote = New System.Windows.Forms.Label()
        Me.lblNote1 = New System.Windows.Forms.Label()
        Me.lblNote2 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.AdminDBTableAdapterSQL = New ProjeckMilk.ToothImageDBDataSetTableAdapters.AdminDBTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDBBindingSourceSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoginOK
        '
        Me.btnLoginOK.Location = New System.Drawing.Point(36, 111)
        Me.btnLoginOK.Name = "btnLoginOK"
        Me.btnLoginOK.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginOK.TabIndex = 3
        Me.btnLoginOK.Text = "Login"
        Me.btnLoginOK.UseVisualStyleBackColor = True
        '
        'btnLoginExit
        '
        Me.btnLoginExit.Location = New System.Drawing.Point(157, 111)
        Me.btnLoginExit.Name = "btnLoginExit"
        Me.btnLoginExit.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginExit.TabIndex = 4
        Me.btnLoginExit.Text = "Exit"
        Me.btnLoginExit.UseVisualStyleBackColor = True
        '
        'lblLoginUN
        '
        Me.lblLoginUN.AutoSize = True
        Me.lblLoginUN.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginUN.Location = New System.Drawing.Point(17, 14)
        Me.lblLoginUN.Name = "lblLoginUN"
        Me.lblLoginUN.Size = New System.Drawing.Size(87, 20)
        Me.lblLoginUN.TabIndex = 2
        Me.lblLoginUN.Text = "Username:"
        '
        'lblLoginPass
        '
        Me.lblLoginPass.AutoSize = True
        Me.lblLoginPass.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPass.ForeColor = System.Drawing.Color.Black
        Me.lblLoginPass.Location = New System.Drawing.Point(22, 43)
        Me.lblLoginPass.Name = "lblLoginPass"
        Me.lblLoginPass.Size = New System.Drawing.Size(82, 20)
        Me.lblLoginPass.TabIndex = 3
        Me.lblLoginPass.Text = "Password:"
        '
        'txtLoginUN
        '
        Me.txtLoginUN.Location = New System.Drawing.Point(110, 16)
        Me.txtLoginUN.MaxLength = 30
        Me.txtLoginUN.Name = "txtLoginUN"
        Me.txtLoginUN.Size = New System.Drawing.Size(144, 20)
        Me.txtLoginUN.TabIndex = 1
        Me.txtLoginUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLoginPass
        '
        Me.txtLoginPass.Location = New System.Drawing.Point(111, 45)
        Me.txtLoginPass.MaxLength = 30
        Me.txtLoginPass.Name = "txtLoginPass"
        Me.txtLoginPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtLoginPass.Size = New System.Drawing.Size(143, 20)
        Me.txtLoginPass.TabIndex = 2
        Me.txtLoginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdminIDDataGridViewTextBoxColumn, Me.AUsernameDataGridViewTextBoxColumn, Me.APasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AdminDBBindingSourceSQL
        Me.DataGridView1.Location = New System.Drawing.Point(14, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(87, 23)
        Me.DataGridView1.TabIndex = 6
        Me.DataGridView1.Visible = False
        '
        'AdminIDDataGridViewTextBoxColumn
        '
        Me.AdminIDDataGridViewTextBoxColumn.DataPropertyName = "AdminID"
        Me.AdminIDDataGridViewTextBoxColumn.HeaderText = "AdminID"
        Me.AdminIDDataGridViewTextBoxColumn.Name = "AdminIDDataGridViewTextBoxColumn"
        Me.AdminIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUsernameDataGridViewTextBoxColumn
        '
        Me.AUsernameDataGridViewTextBoxColumn.DataPropertyName = "AUsername"
        Me.AUsernameDataGridViewTextBoxColumn.HeaderText = "AUsername"
        Me.AUsernameDataGridViewTextBoxColumn.Name = "AUsernameDataGridViewTextBoxColumn"
        Me.AUsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APasswordDataGridViewTextBoxColumn
        '
        Me.APasswordDataGridViewTextBoxColumn.DataPropertyName = "APassword"
        Me.APasswordDataGridViewTextBoxColumn.HeaderText = "APassword"
        Me.APasswordDataGridViewTextBoxColumn.Name = "APasswordDataGridViewTextBoxColumn"
        Me.APasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdminDBBindingSourceSQL
        '
        Me.AdminDBBindingSourceSQL.DataMember = "AdminDB"
        Me.AdminDBBindingSourceSQL.DataSource = Me.ToothImageDBDataSet
        '
        'ToothImageDBDataSet
        '
        Me.ToothImageDBDataSet.DataSetName = "ToothImageDBDataSet"
        Me.ToothImageDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblLogInNote
        '
        Me.lblLogInNote.AutoSize = True
        Me.lblLogInNote.BackColor = System.Drawing.Color.Transparent
        Me.lblLogInNote.Location = New System.Drawing.Point(1, 73)
        Me.lblLogInNote.Name = "lblLogInNote"
        Me.lblLogInNote.Size = New System.Drawing.Size(33, 13)
        Me.lblLogInNote.TabIndex = 7
        Me.lblLogInNote.Text = "Note:"
        Me.lblLogInNote.Visible = False
        '
        'lblNote1
        '
        Me.lblNote1.AutoSize = True
        Me.lblNote1.BackColor = System.Drawing.Color.Transparent
        Me.lblNote1.Location = New System.Drawing.Point(31, 73)
        Me.lblNote1.Name = "lblNote1"
        Me.lblNote1.Size = New System.Drawing.Size(223, 13)
        Me.lblNote1.TabIndex = 8
        Me.lblNote1.Text = "The default username and password is admin."
        Me.lblNote1.Visible = False
        '
        'lblNote2
        '
        Me.lblNote2.AutoSize = True
        Me.lblNote2.BackColor = System.Drawing.Color.Transparent
        Me.lblNote2.Location = New System.Drawing.Point(33, 86)
        Me.lblNote2.Name = "lblNote2"
        Me.lblNote2.Size = New System.Drawing.Size(216, 13)
        Me.lblNote2.TabIndex = 9
        Me.lblNote2.Text = "Please change this at the administrator area."
        Me.lblNote2.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(53, 111)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 10
        Me.btnConfirm.Text = "Comfirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(134, 111)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AdminDBTableAdapterSQL
        '
        Me.AdminDBTableAdapterSQL.ClearBeforeFill = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(261, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblNote2)
        Me.Controls.Add(Me.lblNote1)
        Me.Controls.Add(Me.lblLogInNote)
        Me.Controls.Add(Me.txtLoginPass)
        Me.Controls.Add(Me.txtLoginUN)
        Me.Controls.Add(Me.lblLoginPass)
        Me.Controls.Add(Me.lblLoginUN)
        Me.Controls.Add(Me.btnLoginExit)
        Me.Controls.Add(Me.btnLoginOK)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Login"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDBBindingSourceSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoginOK As System.Windows.Forms.Button
    Friend WithEvents btnLoginExit As System.Windows.Forms.Button
    Friend WithEvents lblLoginUN As System.Windows.Forms.Label
    Friend WithEvents lblLoginPass As System.Windows.Forms.Label
    Friend WithEvents txtLoginUN As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginPass As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLogInNote As System.Windows.Forms.Label
    Friend WithEvents lblNote1 As System.Windows.Forms.Label
    Friend WithEvents lblNote2 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ToothImageDBDataSet As ToothImageDBDataSet
    Friend WithEvents AdminDBBindingSourceSQL As BindingSource
    Friend WithEvents AdminDBTableAdapterSQL As ToothImageDBDataSetTableAdapters.AdminDBTableAdapter
    Friend WithEvents AdminIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
