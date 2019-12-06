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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDBDataSet = New ProjeckMilk.PLDBDataSet()
        Me.lblPSname = New System.Windows.Forms.Label()
        Me.PatientDBTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.patientDBTableAdapter()
        Me.gbPSname.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PLastNameDataGridViewTextBoxColumn, Me.PFirstNameDataGridViewTextBoxColumn, Me.PMiddleNameDataGridViewTextBoxColumn, Me.PFullNameDataGridViewTextBoxColumn, Me.PAddressDataGridViewTextBoxColumn, Me.PContactDataGridViewTextBoxColumn, Me.PBDateDataGridViewTextBoxColumn, Me.POccupationDataGridViewTextBoxColumn, Me.PStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientDBBindingSource
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.Frozen = True
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'PLastNameDataGridViewTextBoxColumn
        '
        Me.PLastNameDataGridViewTextBoxColumn.DataPropertyName = "pLastName"
        Me.PLastNameDataGridViewTextBoxColumn.Frozen = True
        Me.PLastNameDataGridViewTextBoxColumn.HeaderText = "pLastName"
        Me.PLastNameDataGridViewTextBoxColumn.Name = "PLastNameDataGridViewTextBoxColumn"
        Me.PLastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PLastNameDataGridViewTextBoxColumn.Visible = False
        '
        'PFirstNameDataGridViewTextBoxColumn
        '
        Me.PFirstNameDataGridViewTextBoxColumn.DataPropertyName = "pFirstName"
        Me.PFirstNameDataGridViewTextBoxColumn.Frozen = True
        Me.PFirstNameDataGridViewTextBoxColumn.HeaderText = "pFirstName"
        Me.PFirstNameDataGridViewTextBoxColumn.Name = "PFirstNameDataGridViewTextBoxColumn"
        Me.PFirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFirstNameDataGridViewTextBoxColumn.Visible = False
        '
        'PMiddleNameDataGridViewTextBoxColumn
        '
        Me.PMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "pMiddleName"
        Me.PMiddleNameDataGridViewTextBoxColumn.Frozen = True
        Me.PMiddleNameDataGridViewTextBoxColumn.HeaderText = "pMiddleName"
        Me.PMiddleNameDataGridViewTextBoxColumn.Name = "PMiddleNameDataGridViewTextBoxColumn"
        Me.PMiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PMiddleNameDataGridViewTextBoxColumn.Visible = False
        '
        'PFullNameDataGridViewTextBoxColumn
        '
        Me.PFullNameDataGridViewTextBoxColumn.DataPropertyName = "pFullName"
        Me.PFullNameDataGridViewTextBoxColumn.Frozen = True
        Me.PFullNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PFullNameDataGridViewTextBoxColumn.Name = "PFullNameDataGridViewTextBoxColumn"
        Me.PFullNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFullNameDataGridViewTextBoxColumn.Width = 251
        '
        'PAddressDataGridViewTextBoxColumn
        '
        Me.PAddressDataGridViewTextBoxColumn.DataPropertyName = "pAddress"
        Me.PAddressDataGridViewTextBoxColumn.Frozen = True
        Me.PAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.PAddressDataGridViewTextBoxColumn.Name = "PAddressDataGridViewTextBoxColumn"
        Me.PAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAddressDataGridViewTextBoxColumn.Width = 350
        '
        'PContactDataGridViewTextBoxColumn
        '
        Me.PContactDataGridViewTextBoxColumn.DataPropertyName = "pContact"
        Me.PContactDataGridViewTextBoxColumn.Frozen = True
        Me.PContactDataGridViewTextBoxColumn.HeaderText = "pContact"
        Me.PContactDataGridViewTextBoxColumn.Name = "PContactDataGridViewTextBoxColumn"
        Me.PContactDataGridViewTextBoxColumn.ReadOnly = True
        Me.PContactDataGridViewTextBoxColumn.Visible = False
        '
        'PBDateDataGridViewTextBoxColumn
        '
        Me.PBDateDataGridViewTextBoxColumn.DataPropertyName = "pBDate"
        Me.PBDateDataGridViewTextBoxColumn.Frozen = True
        Me.PBDateDataGridViewTextBoxColumn.HeaderText = "pBDate"
        Me.PBDateDataGridViewTextBoxColumn.Name = "PBDateDataGridViewTextBoxColumn"
        Me.PBDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PBDateDataGridViewTextBoxColumn.Visible = False
        '
        'POccupationDataGridViewTextBoxColumn
        '
        Me.POccupationDataGridViewTextBoxColumn.DataPropertyName = "pOccupation"
        Me.POccupationDataGridViewTextBoxColumn.Frozen = True
        Me.POccupationDataGridViewTextBoxColumn.HeaderText = "pOccupation"
        Me.POccupationDataGridViewTextBoxColumn.Name = "POccupationDataGridViewTextBoxColumn"
        Me.POccupationDataGridViewTextBoxColumn.ReadOnly = True
        Me.POccupationDataGridViewTextBoxColumn.Visible = False
        '
        'PStatusDataGridViewTextBoxColumn
        '
        Me.PStatusDataGridViewTextBoxColumn.DataPropertyName = "pStatus"
        Me.PStatusDataGridViewTextBoxColumn.Frozen = True
        Me.PStatusDataGridViewTextBoxColumn.HeaderText = "pStatus"
        Me.PStatusDataGridViewTextBoxColumn.Name = "PStatusDataGridViewTextBoxColumn"
        Me.PStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.PStatusDataGridViewTextBoxColumn.Visible = False
        '
        'PatientDBBindingSource
        '
        Me.PatientDBBindingSource.DataMember = "patientDB"
        Me.PatientDBBindingSource.DataSource = Me.PLDBDataSet
        '
        'PLDBDataSet
        '
        Me.PLDBDataSet.DataSetName = "PLDBDataSet"
        Me.PLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PatientDBTableAdapter
        '
        Me.PatientDBTableAdapter.ClearBeforeFill = True
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
        CType(Me.PatientDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PLDBDataSet As ProjeckMilk.PLDBDataSet
    Friend WithEvents PatientDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientDBTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.patientDBTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PFirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PBDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POccupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
