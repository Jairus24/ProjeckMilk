<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientSearch))
        Me.btnPSShow = New System.Windows.Forms.Button()
        Me.btnPScancel = New System.Windows.Forms.Button()
        Me.gbPSname = New System.Windows.Forms.GroupBox()
        Me.btnEditRecord = New System.Windows.Forms.Button()
        Me.btnSearchDelete = New System.Windows.Forms.Button()
        Me.btnAppt = New System.Windows.Forms.Button()
        Me.txtPSname = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatientDBBindingSourceSQL = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToothImageDBDataSet = New ProjeckMilk.ToothImageDBDataSet()
        Me.lblPSname = New System.Windows.Forms.Label()
        Me.PatientDBTableAdapterSQL = New ProjeckMilk.ToothImageDBDataSetTableAdapters.PatientDBTableAdapter()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbPSname.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDBBindingSourceSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPSShow
        '
        Me.btnPSShow.Location = New System.Drawing.Point(16, 340)
        Me.btnPSShow.Name = "btnPSShow"
        Me.btnPSShow.Size = New System.Drawing.Size(141, 32)
        Me.btnPSShow.TabIndex = 2
        Me.btnPSShow.Text = "Show Patient Profile"
        Me.btnPSShow.UseVisualStyleBackColor = True
        '
        'btnPScancel
        '
        Me.btnPScancel.Location = New System.Drawing.Point(473, 340)
        Me.btnPScancel.Name = "btnPScancel"
        Me.btnPScancel.Size = New System.Drawing.Size(147, 32)
        Me.btnPScancel.TabIndex = 6
        Me.btnPScancel.Text = "Cancel"
        Me.btnPScancel.UseVisualStyleBackColor = True
        '
        'gbPSname
        '
        Me.gbPSname.BackColor = System.Drawing.Color.Transparent
        Me.gbPSname.Controls.Add(Me.btnEditRecord)
        Me.gbPSname.Controls.Add(Me.btnSearchDelete)
        Me.gbPSname.Controls.Add(Me.btnAppt)
        Me.gbPSname.Controls.Add(Me.txtPSname)
        Me.gbPSname.Controls.Add(Me.DataGridView1)
        Me.gbPSname.Controls.Add(Me.lblPSname)
        Me.gbPSname.Controls.Add(Me.btnPScancel)
        Me.gbPSname.Controls.Add(Me.btnPSShow)
        Me.gbPSname.Location = New System.Drawing.Point(12, 1)
        Me.gbPSname.Name = "gbPSname"
        Me.gbPSname.Size = New System.Drawing.Size(638, 378)
        Me.gbPSname.TabIndex = 8
        Me.gbPSname.TabStop = False
        Me.gbPSname.Text = "Search Patient"
        '
        'btnEditRecord
        '
        Me.btnEditRecord.Location = New System.Drawing.Point(163, 340)
        Me.btnEditRecord.Name = "btnEditRecord"
        Me.btnEditRecord.Size = New System.Drawing.Size(146, 32)
        Me.btnEditRecord.TabIndex = 3
        Me.btnEditRecord.Text = "Edit Record"
        Me.btnEditRecord.UseVisualStyleBackColor = True
        '
        'btnSearchDelete
        '
        Me.btnSearchDelete.Location = New System.Drawing.Point(321, 340)
        Me.btnSearchDelete.Name = "btnSearchDelete"
        Me.btnSearchDelete.Size = New System.Drawing.Size(146, 32)
        Me.btnSearchDelete.TabIndex = 4
        Me.btnSearchDelete.Text = "Delete Record"
        Me.btnSearchDelete.UseVisualStyleBackColor = True
        '
        'btnAppt
        '
        Me.btnAppt.Location = New System.Drawing.Point(237, 340)
        Me.btnAppt.Name = "btnAppt"
        Me.btnAppt.Size = New System.Drawing.Size(141, 32)
        Me.btnAppt.TabIndex = 5
        Me.btnAppt.Text = "Make Appointment"
        Me.btnAppt.UseVisualStyleBackColor = True
        '
        'txtPSname
        '
        Me.txtPSname.Location = New System.Drawing.Point(16, 68)
        Me.txtPSname.Name = "txtPSname"
        Me.txtPSname.Size = New System.Drawing.Size(604, 20)
        Me.txtPSname.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientID, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.PatientAddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.OccupationDataGridViewTextBoxColumn, Me.CivilStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientDBBindingSourceSQL
        Me.DataGridView1.Location = New System.Drawing.Point(16, 94)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(604, 240)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.TabStop = False
        '
        'PatientDBBindingSourceSQL
        '
        Me.PatientDBBindingSourceSQL.DataMember = "PatientDB"
        Me.PatientDBBindingSourceSQL.DataSource = Me.ToothImageDBDataSet
        '
        'ToothImageDBDataSet
        '
        Me.ToothImageDBDataSet.DataSetName = "ToothImageDBDataSet"
        Me.ToothImageDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPSname
        '
        Me.lblPSname.AutoSize = True
        Me.lblPSname.BackColor = System.Drawing.Color.Transparent
        Me.lblPSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPSname.Location = New System.Drawing.Point(12, 45)
        Me.lblPSname.Name = "lblPSname"
        Me.lblPSname.Size = New System.Drawing.Size(122, 20)
        Me.lblPSname.TabIndex = 9
        Me.lblPSname.Text = "Patient Name:"
        '
        'PatientDBTableAdapterSQL
        '
        Me.PatientDBTableAdapterSQL.ClearBeforeFill = True
        '
        'PatientID
        '
        Me.PatientID.DataPropertyName = "PatientID"
        Me.PatientID.HeaderText = "PatientID"
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.Visible = False
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Visible = False
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Visible = False
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MiddleNameDataGridViewTextBoxColumn.Visible = False
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullNameDataGridViewTextBoxColumn.Width = 250
        '
        'PatientAddressDataGridViewTextBoxColumn
        '
        Me.PatientAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.HeaderText = "Patient Address"
        Me.PatientAddressDataGridViewTextBoxColumn.Name = "PatientAddressDataGridViewTextBoxColumn"
        Me.PatientAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactDataGridViewTextBoxColumn.Visible = False
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        Me.BirthdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.BirthdayDataGridViewTextBoxColumn.Visible = False
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        Me.OccupationDataGridViewTextBoxColumn.ReadOnly = True
        Me.OccupationDataGridViewTextBoxColumn.Visible = False
        '
        'CivilStatusDataGridViewTextBoxColumn
        '
        Me.CivilStatusDataGridViewTextBoxColumn.DataPropertyName = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.HeaderText = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.Name = "CivilStatusDataGridViewTextBoxColumn"
        Me.CivilStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CivilStatusDataGridViewTextBoxColumn.Visible = False
        '
        'frmPatientSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(662, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbPSname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatientSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Search"
        Me.gbPSname.ResumeLayout(False)
        Me.gbPSname.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDBBindingSourceSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPSShow As System.Windows.Forms.Button
    Friend WithEvents btnPScancel As System.Windows.Forms.Button
    Friend WithEvents gbPSname As System.Windows.Forms.GroupBox
    Friend WithEvents lblPSname As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtPSname As System.Windows.Forms.TextBox
    Friend WithEvents PComplainDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAppt As System.Windows.Forms.Button
    Friend WithEvents btnSearchDelete As System.Windows.Forms.Button
    Friend WithEvents btnEditRecord As System.Windows.Forms.Button
    Friend WithEvents ToothImageDBDataSet As ToothImageDBDataSet
    Friend WithEvents PatientDBBindingSourceSQL As BindingSource
    Friend WithEvents PatientDBTableAdapterSQL As ToothImageDBDataSetTableAdapters.PatientDBTableAdapter
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CivilStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
