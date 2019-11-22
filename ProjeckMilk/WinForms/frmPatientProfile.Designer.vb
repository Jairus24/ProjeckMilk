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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblPFmaritalF = New System.Windows.Forms.Label()
        Me.gbPF01 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServiceRecIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceRecordDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToothImageDBDataSet = New ProjeckMilk.ToothImageDBDataSet()
        Me.btnPFclose = New System.Windows.Forms.Button()
        Me.btnPFadd = New System.Windows.Forms.Button()
        Me.txtPFsh = New System.Windows.Forms.Label()
        Me.ServiceRecordDBTableAdapter = New ProjeckMilk.ToothImageDBDataSetTableAdapters.ServiceRecordDBTableAdapter()
        Me.lblPFBdate = New System.Windows.Forms.Label()
        Me.lblPFBdateF = New System.Windows.Forms.Label()
        Me.gbPF01.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceRecordDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblPFcontact.Location = New System.Drawing.Point(384, 100)
        Me.lblPFcontact.Name = "lblPFcontact"
        Me.lblPFcontact.Size = New System.Drawing.Size(144, 20)
        Me.lblPFcontact.TabIndex = 2
        Me.lblPFcontact.Text = "Contact Number:"
        '
        'lblPFoccupation
        '
        Me.lblPFoccupation.AutoSize = True
        Me.lblPFoccupation.BackColor = System.Drawing.Color.Transparent
        Me.lblPFoccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFoccupation.Location = New System.Drawing.Point(423, 80)
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
        Me.lblPFage.Location = New System.Drawing.Point(95, 80)
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
        Me.lblPFmarital.Location = New System.Drawing.Point(15, 100)
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
        Me.lblPFcontactF.Location = New System.Drawing.Point(534, 100)
        Me.lblPFcontactF.Name = "lblPFcontactF"
        Me.lblPFcontactF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFcontactF.TabIndex = 8
        '
        'lblPFOccupationF
        '
        Me.lblPFOccupationF.AutoSize = True
        Me.lblPFOccupationF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFOccupationF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFOccupationF.Location = New System.Drawing.Point(534, 80)
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
        Me.lblPFageF.Location = New System.Drawing.Point(147, 80)
        Me.lblPFageF.Name = "lblPFageF"
        Me.lblPFageF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFageF.TabIndex = 11
        '
        'lblPFmaritalF
        '
        Me.lblPFmaritalF.AutoSize = True
        Me.lblPFmaritalF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFmaritalF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFmaritalF.Location = New System.Drawing.Point(147, 100)
        Me.lblPFmaritalF.Name = "lblPFmaritalF"
        Me.lblPFmaritalF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFmaritalF.TabIndex = 12
        '
        'gbPF01
        '
        Me.gbPF01.BackColor = System.Drawing.Color.Transparent
        Me.gbPF01.Controls.Add(Me.lblPFmaritalF)
        Me.gbPF01.Controls.Add(Me.lblPFBdateF)
        Me.gbPF01.Controls.Add(Me.lblPFBdate)
        Me.gbPF01.Controls.Add(Me.lblPFageF)
        Me.gbPF01.Controls.Add(Me.DataGridView1)
        Me.gbPF01.Controls.Add(Me.btnPFclose)
        Me.gbPF01.Controls.Add(Me.btnPFadd)
        Me.gbPF01.Controls.Add(Me.lblPFcontactF)
        Me.gbPF01.Controls.Add(Me.lblPFage)
        Me.gbPF01.Controls.Add(Me.lblPFOccupationF)
        Me.gbPF01.Controls.Add(Me.lblPFmarital)
        Me.gbPF01.Controls.Add(Me.txtPFsh)
        Me.gbPF01.Controls.Add(Me.lblPFoccupation)
        Me.gbPF01.Controls.Add(Me.lblPFcontact)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceRecIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.MedsDataGridViewTextBoxColumn, Me.DentistDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.RemainingBalanceDataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.PatientAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiceRecordDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(823, 262)
        Me.DataGridView1.TabIndex = 19
        '
        'ServiceRecIDDataGridViewTextBoxColumn
        '
        Me.ServiceRecIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceRecID"
        Me.ServiceRecIDDataGridViewTextBoxColumn.HeaderText = "ServiceRecID"
        Me.ServiceRecIDDataGridViewTextBoxColumn.Name = "ServiceRecIDDataGridViewTextBoxColumn"
        Me.ServiceRecIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceRecIDDataGridViewTextBoxColumn.Visible = False
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientNameDataGridViewTextBoxColumn.Visible = False
        '
        'DentalServiceDataGridViewTextBoxColumn
        '
        Me.DentalServiceDataGridViewTextBoxColumn.DataPropertyName = "DentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.HeaderText = "Dental Service"
        Me.DentalServiceDataGridViewTextBoxColumn.Name = "DentalServiceDataGridViewTextBoxColumn"
        Me.DentalServiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DentalServiceDataGridViewTextBoxColumn.Width = 150
        '
        'ServiceDateDataGridViewTextBoxColumn
        '
        Me.ServiceDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDate"
        Me.ServiceDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.ServiceDateDataGridViewTextBoxColumn.Name = "ServiceDateDataGridViewTextBoxColumn"
        Me.ServiceDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToothNumberDataGridViewTextBoxColumn
        '
        Me.ToothNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "Tooth No."
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        Me.ToothNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedsDataGridViewTextBoxColumn
        '
        Me.MedsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MedsDataGridViewTextBoxColumn.DataPropertyName = "Meds"
        Me.MedsDataGridViewTextBoxColumn.HeaderText = "Meds"
        Me.MedsDataGridViewTextBoxColumn.Name = "MedsDataGridViewTextBoxColumn"
        Me.MedsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DentistDataGridViewTextBoxColumn
        '
        Me.DentistDataGridViewTextBoxColumn.DataPropertyName = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.Name = "DentistDataGridViewTextBoxColumn"
        Me.DentistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceAmountDataGridViewTextBoxColumn
        '
        Me.ServiceAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceAmountDataGridViewTextBoxColumn.DataPropertyName = "ServiceAmount"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.ServiceAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ServiceAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Name = "ServiceAmountDataGridViewTextBoxColumn"
        Me.ServiceAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemainingBalanceDataGridViewTextBoxColumn
        '
        Me.RemainingBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RemainingBalanceDataGridViewTextBoxColumn.DataPropertyName = "RemainingBalance"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.RemainingBalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RemainingBalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.RemainingBalanceDataGridViewTextBoxColumn.Name = "RemainingBalanceDataGridViewTextBoxColumn"
        Me.RemainingBalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountPaidDataGridViewTextBoxColumn
        '
        Me.AmountPaidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.AmountPaidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.AmountPaidDataGridViewTextBoxColumn.HeaderText = "Paid Amount"
        Me.AmountPaidDataGridViewTextBoxColumn.Name = "AmountPaidDataGridViewTextBoxColumn"
        Me.AmountPaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ServiceTime"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ServiceTime"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'PatientAddressDataGridViewTextBoxColumn
        '
        Me.PatientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.HeaderText = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.Name = "PatientAddressDataGridViewTextBoxColumn"
        Me.PatientAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientAddressDataGridViewTextBoxColumn.Visible = False
        '
        'ServiceRecordDBBindingSource
        '
        Me.ServiceRecordDBBindingSource.DataMember = "ServiceRecordDB"
        Me.ServiceRecordDBBindingSource.DataSource = Me.ToothImageDBDataSet
        '
        'ToothImageDBDataSet
        '
        Me.ToothImageDBDataSet.DataSetName = "ToothImageDBDataSet"
        Me.ToothImageDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPFclose
        '
        Me.btnPFclose.Location = New System.Drawing.Point(733, 145)
        Me.btnPFclose.Name = "btnPFclose"
        Me.btnPFclose.Size = New System.Drawing.Size(109, 40)
        Me.btnPFclose.TabIndex = 2
        Me.btnPFclose.Text = "Close"
        Me.btnPFclose.UseVisualStyleBackColor = True
        '
        'btnPFadd
        '
        Me.btnPFadd.Location = New System.Drawing.Point(618, 145)
        Me.btnPFadd.Name = "btnPFadd"
        Me.btnPFadd.Size = New System.Drawing.Size(109, 40)
        Me.btnPFadd.TabIndex = 1
        Me.btnPFadd.Text = "Add To Patient Queue"
        Me.btnPFadd.UseVisualStyleBackColor = True
        '
        'txtPFsh
        '
        Me.txtPFsh.AutoSize = True
        Me.txtPFsh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPFsh.Location = New System.Drawing.Point(15, 165)
        Me.txtPFsh.Name = "txtPFsh"
        Me.txtPFsh.Size = New System.Drawing.Size(132, 20)
        Me.txtPFsh.TabIndex = 15
        Me.txtPFsh.Text = "Patient History:"
        '
        'ServiceRecordDBTableAdapter
        '
        Me.ServiceRecordDBTableAdapter.ClearBeforeFill = True
        '
        'lblPFBdate
        '
        Me.lblPFBdate.AutoSize = True
        Me.lblPFBdate.BackColor = System.Drawing.Color.Transparent
        Me.lblPFBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFBdate.Location = New System.Drawing.Point(45, 60)
        Me.lblPFBdate.Name = "lblPFBdate"
        Me.lblPFBdate.Size = New System.Drawing.Size(96, 20)
        Me.lblPFBdate.TabIndex = 15
        Me.lblPFBdate.Text = "Birth Date:"
        '
        'lblPFBdateF
        '
        Me.lblPFBdateF.AutoSize = True
        Me.lblPFBdateF.BackColor = System.Drawing.Color.Transparent
        Me.lblPFBdateF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFBdateF.Location = New System.Drawing.Point(147, 60)
        Me.lblPFBdateF.Name = "lblPFBdateF"
        Me.lblPFBdateF.Size = New System.Drawing.Size(0, 20)
        Me.lblPFBdateF.TabIndex = 20
        '
        'frmPatientProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 480)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.lblPFaddressF)
        Me.Controls.Add(Me.lblPFnameF)
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
        CType(Me.ServiceRecordDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblPFmaritalF As System.Windows.Forms.Label
    Friend WithEvents gbPF01 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPFsh As System.Windows.Forms.Label
    Friend WithEvents btnPFclose As System.Windows.Forms.Button
    Friend WithEvents btnPFadd As System.Windows.Forms.Button
    Friend WithEvents ServiceTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToothImageDBDataSet As ToothImageDBDataSet
    Friend WithEvents ServiceRecordDBBindingSource As BindingSource
    Friend WithEvents ServiceRecordDBTableAdapter As ToothImageDBDataSetTableAdapters.ServiceRecordDBTableAdapter
    Friend WithEvents ServiceRecIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentalServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblPFBdateF As Label
    Friend WithEvents lblPFBdate As Label
End Class
