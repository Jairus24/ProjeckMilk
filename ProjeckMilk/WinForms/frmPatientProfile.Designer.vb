<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientProfile))
        Me.lblPFname = New System.Windows.Forms.Label()
        Me.lblPFaddress = New System.Windows.Forms.Label()
        Me.lblPFcontact = New System.Windows.Forms.Label()
        Me.lblPFoccupation = New System.Windows.Forms.Label()
        Me.lblPFage = New System.Windows.Forms.Label()
        Me.lblPFmarital = New System.Windows.Forms.Label()
        Me.lblPFnameF = New System.Windows.Forms.Label()
        Me.lblPFaddressF = New System.Windows.Forms.Label()
        Me.lblPFcontactF = New System.Windows.Forms.Label()
        Me.lblPFOccupationF = New System.Windows.Forms.Label()
        Me.v = New System.Windows.Forms.Label()
        Me.lblPFageF = New System.Windows.Forms.Label()
        Me.PatientDBTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.patientDBTableAdapter()
        Me.lblPFmaritalF = New System.Windows.Forms.Label()
        Me.gbPF01 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PldbDataSet = New ProjeckMilk.PLDBDataSet()
        Me.btnPFclose = New System.Windows.Forms.Button()
        Me.btnPFadd = New System.Windows.Forms.Button()
        Me.txtPFsh = New System.Windows.Forms.Label()
        Me.ServiceRecordTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.serviceRecordTableAdapter()
        Me.gbPF01.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPFname
        '
        Me.lblPFname.AutoSize = True
        Me.lblPFname.BackColor = System.Drawing.Color.Transparent
        Me.lblPFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFname.Location = New System.Drawing.Point(94, 32)
        Me.lblPFname.Name = "lblPFname"
        Me.lblPFname.Size = New System.Drawing.Size(60, 20)
        Me.lblPFname.TabIndex = 0
        Me.lblPFname.Text = "Name:"
        '
        'lblPFaddress
        '
        Me.lblPFaddress.AutoSize = True
        Me.lblPFaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblPFaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFaddress.Location = New System.Drawing.Point(74, 52)
        Me.lblPFaddress.Name = "lblPFaddress"
        Me.lblPFaddress.Size = New System.Drawing.Size(80, 20)
        Me.lblPFaddress.TabIndex = 1
        Me.lblPFaddress.Text = "Address:"
        '
        'lblPFcontact
        '
        Me.lblPFcontact.AutoSize = True
        Me.lblPFcontact.BackColor = System.Drawing.Color.Transparent
        Me.lblPFcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFcontact.Location = New System.Drawing.Point(45, 132)
        Me.lblPFcontact.Name = "lblPFcontact"
        Me.lblPFcontact.Size = New System.Drawing.Size(109, 20)
        Me.lblPFcontact.TabIndex = 2
        Me.lblPFcontact.Text = "Contact No.:"
        '
        'lblPFoccupation
        '
        Me.lblPFoccupation.AutoSize = True
        Me.lblPFoccupation.BackColor = System.Drawing.Color.Transparent
        Me.lblPFoccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFoccupation.Location = New System.Drawing.Point(49, 112)
        Me.lblPFoccupation.Name = "lblPFoccupation"
        Me.lblPFoccupation.Size = New System.Drawing.Size(105, 20)
        Me.lblPFoccupation.TabIndex = 3
        Me.lblPFoccupation.Text = "Occupation:"
        '
        'lblPFage
        '
        Me.lblPFage.AutoSize = True
        Me.lblPFage.BackColor = System.Drawing.Color.Transparent
        Me.lblPFage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFage.Location = New System.Drawing.Point(108, 72)
        Me.lblPFage.Name = "lblPFage"
        Me.lblPFage.Size = New System.Drawing.Size(46, 20)
        Me.lblPFage.TabIndex = 4
        Me.lblPFage.Text = "Age:"
        '
        'lblPFmarital
        '
        Me.lblPFmarital.AutoSize = True
        Me.lblPFmarital.BackColor = System.Drawing.Color.Transparent
        Me.lblPFmarital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFmarital.Location = New System.Drawing.Point(28, 92)
        Me.lblPFmarital.Name = "lblPFmarital"
        Me.lblPFmarital.Size = New System.Drawing.Size(126, 20)
        Me.lblPFmarital.TabIndex = 5
        Me.lblPFmarital.Text = "Marital Status:"
        '
        'lblPFnameF
        '
        Me.lblPFnameF.AutoSize = True
        Me.lblPFnameF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFnameF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFnameF.Location = New System.Drawing.Point(160, 32)
        Me.lblPFnameF.Name = "lblPFnameF"
        Me.lblPFnameF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFnameF.TabIndex = 6
        '
        'lblPFaddressF
        '
        Me.lblPFaddressF.AutoSize = True
        Me.lblPFaddressF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFaddressF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFaddressF.Location = New System.Drawing.Point(160, 52)
        Me.lblPFaddressF.Name = "lblPFaddressF"
        Me.lblPFaddressF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFaddressF.TabIndex = 7
        '
        'lblPFcontactF
        '
        Me.lblPFcontactF.AutoSize = True
        Me.lblPFcontactF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFcontactF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFcontactF.Location = New System.Drawing.Point(160, 132)
        Me.lblPFcontactF.Name = "lblPFcontactF"
        Me.lblPFcontactF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFcontactF.TabIndex = 8
        '
        'lblPFOccupationF
        '
        Me.lblPFOccupationF.AutoSize = True
        Me.lblPFOccupationF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFOccupationF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFOccupationF.Location = New System.Drawing.Point(160, 112)
        Me.lblPFOccupationF.Name = "lblPFOccupationF"
        Me.lblPFOccupationF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFOccupationF.TabIndex = 9
        '
        'v
        '
        Me.v.AutoSize = True
        Me.v.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v.Location = New System.Drawing.Point(160, 92)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(0, 20)
        Me.v.TabIndex = 10
        '
        'lblPFageF
        '
        Me.lblPFageF.AutoSize = True
        Me.lblPFageF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFageF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFageF.Location = New System.Drawing.Point(160, 72)
        Me.lblPFageF.Name = "lblPFageF"
        Me.lblPFageF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFageF.TabIndex = 11
        '
        'PatientDBTableAdapter
        '
        Me.PatientDBTableAdapter.ClearBeforeFill = True
        '
        'lblPFmaritalF
        '
        Me.lblPFmaritalF.AutoSize = True
        Me.lblPFmaritalF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFmaritalF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFmaritalF.Location = New System.Drawing.Point(160, 92)
        Me.lblPFmaritalF.Name = "lblPFmaritalF"
        Me.lblPFmaritalF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFmaritalF.TabIndex = 12
        '
        'gbPF01
        '
        Me.gbPF01.BackColor = System.Drawing.Color.Transparent
        Me.gbPF01.Controls.Add(Me.DataGridView1)
        Me.gbPF01.Controls.Add(Me.btnPFclose)
        Me.gbPF01.Controls.Add(Me.btnPFadd)
        Me.gbPF01.Controls.Add(Me.txtPFsh)
        Me.gbPF01.Location = New System.Drawing.Point(13, 12)
        Me.gbPF01.Name = "gbPF01"
        Me.gbPF01.Size = New System.Drawing.Size(866, 456)
        Me.gbPF01.TabIndex = 14
        Me.gbPF01.TabStop = False
        Me.gbPF01.Text = " Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.MedDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.PBalanceDataGridViewTextBoxColumn, Me.PDentistDataGridViewTextBoxColumn, Me.PPaidDataGridViewTextBoxColumn, Me.pAddress})
        Me.DataGridView1.DataSource = Me.ServiceRecordBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(823, 262)
        Me.DataGridView1.TabIndex = 19
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.Frozen = True
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "pName"
        Me.PNameDataGridViewTextBoxColumn.Frozen = True
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "pName"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        Me.PNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PNameDataGridViewTextBoxColumn.Visible = False
        '
        'DentalServiceDataGridViewTextBoxColumn
        '
        Me.DentalServiceDataGridViewTextBoxColumn.DataPropertyName = "dentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.Frozen = True
        Me.DentalServiceDataGridViewTextBoxColumn.HeaderText = "Dental Service"
        Me.DentalServiceDataGridViewTextBoxColumn.Name = "DentalServiceDataGridViewTextBoxColumn"
        Me.DentalServiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DentalServiceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DentalServiceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DentalServiceDataGridViewTextBoxColumn.Width = 200
        '
        'ServiceDateDataGridViewTextBoxColumn
        '
        Me.ServiceDateDataGridViewTextBoxColumn.DataPropertyName = "serviceDate"
        Me.ServiceDateDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceDateDataGridViewTextBoxColumn.HeaderText = "Service Date"
        Me.ServiceDateDataGridViewTextBoxColumn.Name = "ServiceDateDataGridViewTextBoxColumn"
        Me.ServiceDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ToothNumberDataGridViewTextBoxColumn
        '
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "toothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.Frozen = True
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "Tooth Number"
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        Me.ToothNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToothNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ToothNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MedDataGridViewTextBoxColumn
        '
        Me.MedDataGridViewTextBoxColumn.DataPropertyName = "med"
        Me.MedDataGridViewTextBoxColumn.Frozen = True
        Me.MedDataGridViewTextBoxColumn.HeaderText = "Med"
        Me.MedDataGridViewTextBoxColumn.Name = "MedDataGridViewTextBoxColumn"
        Me.MedDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MedDataGridViewTextBoxColumn.Width = 103
        '
        'ServiceAmountDataGridViewTextBoxColumn
        '
        Me.ServiceAmountDataGridViewTextBoxColumn.DataPropertyName = "serviceAmount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Name = "ServiceAmountDataGridViewTextBoxColumn"
        Me.ServiceAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceAmountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiceAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServiceAmountDataGridViewTextBoxColumn.Width = 75
        '
        'PBalanceDataGridViewTextBoxColumn
        '
        Me.PBalanceDataGridViewTextBoxColumn.DataPropertyName = "pBalance"
        Me.PBalanceDataGridViewTextBoxColumn.Frozen = True
        Me.PBalanceDataGridViewTextBoxColumn.HeaderText = "Balance Left"
        Me.PBalanceDataGridViewTextBoxColumn.Name = "PBalanceDataGridViewTextBoxColumn"
        Me.PBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PBalanceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PBalanceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PBalanceDataGridViewTextBoxColumn.Width = 93
        '
        'PDentistDataGridViewTextBoxColumn
        '
        Me.PDentistDataGridViewTextBoxColumn.DataPropertyName = "pDentist"
        Me.PDentistDataGridViewTextBoxColumn.Frozen = True
        Me.PDentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.PDentistDataGridViewTextBoxColumn.Name = "PDentistDataGridViewTextBoxColumn"
        Me.PDentistDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDentistDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PDentistDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PDentistDataGridViewTextBoxColumn.Width = 148
        '
        'PPaidDataGridViewTextBoxColumn
        '
        Me.PPaidDataGridViewTextBoxColumn.DataPropertyName = "pPaid"
        Me.PPaidDataGridViewTextBoxColumn.Frozen = True
        Me.PPaidDataGridViewTextBoxColumn.HeaderText = "pPaid"
        Me.PPaidDataGridViewTextBoxColumn.Name = "PPaidDataGridViewTextBoxColumn"
        Me.PPaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PPaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PPaidDataGridViewTextBoxColumn.Visible = False
        '
        'pAddress
        '
        Me.pAddress.DataPropertyName = "pAddress"
        Me.pAddress.Frozen = True
        Me.pAddress.HeaderText = "pAddress"
        Me.pAddress.Name = "pAddress"
        Me.pAddress.ReadOnly = True
        Me.pAddress.Visible = False
        '
        'ServiceRecordBindingSource
        '
        Me.ServiceRecordBindingSource.DataMember = "serviceRecord"
        Me.ServiceRecordBindingSource.DataSource = Me.PldbDataSet
        '
        'PldbDataSet
        '
        Me.PldbDataSet.DataSetName = "PLDBDataSet"
        Me.PldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPFclose
        '
        Me.btnPFclose.Location = New System.Drawing.Point(733, 154)
        Me.btnPFclose.Name = "btnPFclose"
        Me.btnPFclose.Size = New System.Drawing.Size(109, 31)
        Me.btnPFclose.TabIndex = 2
        Me.btnPFclose.Text = "Close"
        Me.btnPFclose.UseVisualStyleBackColor = True
        '
        'btnPFadd
        '
        Me.btnPFadd.Location = New System.Drawing.Point(618, 154)
        Me.btnPFadd.Name = "btnPFadd"
        Me.btnPFadd.Size = New System.Drawing.Size(109, 31)
        Me.btnPFadd.TabIndex = 1
        Me.btnPFadd.Text = "Add toWaiting List"
        Me.btnPFadd.UseVisualStyleBackColor = True
        '
        'txtPFsh
        '
        Me.txtPFsh.AutoSize = True
        Me.txtPFsh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPFsh.Location = New System.Drawing.Point(15, 165)
        Me.txtPFsh.Name = "txtPFsh"
        Me.txtPFsh.Size = New System.Drawing.Size(134, 20)
        Me.txtPFsh.TabIndex = 15
        Me.txtPFsh.Text = "Service History:"
        '
        'ServiceRecordTableAdapter
        '
        Me.ServiceRecordTableAdapter.ClearBeforeFill = True
        '
        'frmPatientProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 480)
        Me.Controls.Add(Me.lblPFmaritalF)
        Me.Controls.Add(Me.lblPFageF)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.lblPFOccupationF)
        Me.Controls.Add(Me.lblPFcontactF)
        Me.Controls.Add(Me.lblPFaddressF)
        Me.Controls.Add(Me.lblPFnameF)
        Me.Controls.Add(Me.lblPFmarital)
        Me.Controls.Add(Me.lblPFage)
        Me.Controls.Add(Me.lblPFoccupation)
        Me.Controls.Add(Me.lblPFcontact)
        Me.Controls.Add(Me.lblPFaddress)
        Me.Controls.Add(Me.lblPFname)
        Me.Controls.Add(Me.gbPF01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPatientProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPatientProfile"
        Me.gbPF01.ResumeLayout(False)
        Me.gbPF01.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPFname As System.Windows.Forms.Label
    Friend WithEvents lblPFaddress As System.Windows.Forms.Label
    Friend WithEvents lblPFcontact As System.Windows.Forms.Label
    Friend WithEvents lblPFoccupation As System.Windows.Forms.Label
    Friend WithEvents lblPFage As System.Windows.Forms.Label
    Friend WithEvents lblPFmarital As System.Windows.Forms.Label
    Friend WithEvents lblPFnameF As System.Windows.Forms.Label
    Friend WithEvents lblPFaddressF As System.Windows.Forms.Label
    Friend WithEvents lblPFcontactF As System.Windows.Forms.Label
    Friend WithEvents lblPFOccupationF As System.Windows.Forms.Label
    Friend WithEvents v As System.Windows.Forms.Label
    Friend WithEvents lblPFageF As System.Windows.Forms.Label
    Friend WithEvents PatientDBTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.patientDBTableAdapter
    Friend WithEvents lblPFmaritalF As System.Windows.Forms.Label
    Friend WithEvents gbPF01 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPFsh As System.Windows.Forms.Label
    Friend WithEvents btnPFclose As System.Windows.Forms.Button
    Friend WithEvents btnPFadd As System.Windows.Forms.Button
    Friend WithEvents ServiceTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PldbDataSet As ProjeckMilk.PLDBDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceRecordTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.serviceRecordTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DentalServiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDentistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pAddress As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
