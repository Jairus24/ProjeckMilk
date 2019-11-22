<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalance))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServiceRecordDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToothImageDBDataSet = New ProjeckMilk.ToothImageDBDataSet()
        Me.gbBalBal = New System.Windows.Forms.GroupBox()
        Me.btnBalPaid = New System.Windows.Forms.Button()
        Me.ServiceRecordDBTableAdapter = New ProjeckMilk.ToothImageDBDataSetTableAdapters.ServiceRecordDBTableAdapter()
        Me.ServiceRecIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceRecordDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBalBal.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceRecIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.MedsDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.RemainingBalanceDataGridViewTextBoxColumn, Me.DentistDataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.ServiceTimeDataGridViewTextBoxColumn, Me.PatientAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiceRecordDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 61)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(803, 317)
        Me.DataGridView1.TabIndex = 0
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
        'gbBalBal
        '
        Me.gbBalBal.BackColor = System.Drawing.Color.Transparent
        Me.gbBalBal.Controls.Add(Me.DataGridView1)
        Me.gbBalBal.Controls.Add(Me.btnBalPaid)
        Me.gbBalBal.Location = New System.Drawing.Point(12, 12)
        Me.gbBalBal.Name = "gbBalBal"
        Me.gbBalBal.Size = New System.Drawing.Size(815, 384)
        Me.gbBalBal.TabIndex = 1
        Me.gbBalBal.TabStop = False
        Me.gbBalBal.Text = "Patients With Remaining Balance"
        '
        'btnBalPaid
        '
        Me.btnBalPaid.Location = New System.Drawing.Point(702, 19)
        Me.btnBalPaid.Name = "btnBalPaid"
        Me.btnBalPaid.Size = New System.Drawing.Size(107, 39)
        Me.btnBalPaid.TabIndex = 4
        Me.btnBalPaid.Text = "Pay Balance"
        Me.btnBalPaid.UseVisualStyleBackColor = True
        '
        'ServiceRecordDBTableAdapter
        '
        Me.ServiceRecordDBTableAdapter.ClearBeforeFill = True
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
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientNameDataGridViewTextBoxColumn.Width = 150
        '
        'DentalServiceDataGridViewTextBoxColumn
        '
        Me.DentalServiceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DentalServiceDataGridViewTextBoxColumn.DataPropertyName = "DentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.HeaderText = "Dental Service"
        Me.DentalServiceDataGridViewTextBoxColumn.Name = "DentalServiceDataGridViewTextBoxColumn"
        Me.DentalServiceDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        Me.ToothNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToothNumberDataGridViewTextBoxColumn.Visible = False
        '
        'MedsDataGridViewTextBoxColumn
        '
        Me.MedsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MedsDataGridViewTextBoxColumn.DataPropertyName = "Meds"
        Me.MedsDataGridViewTextBoxColumn.HeaderText = "Meds"
        Me.MedsDataGridViewTextBoxColumn.Name = "MedsDataGridViewTextBoxColumn"
        Me.MedsDataGridViewTextBoxColumn.ReadOnly = True
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
        'DentistDataGridViewTextBoxColumn
        '
        Me.DentistDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DentistDataGridViewTextBoxColumn.DataPropertyName = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.Name = "DentistDataGridViewTextBoxColumn"
        Me.DentistDataGridViewTextBoxColumn.ReadOnly = True
        Me.DentistDataGridViewTextBoxColumn.Visible = False
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
        'ServiceTimeDataGridViewTextBoxColumn
        '
        Me.ServiceTimeDataGridViewTextBoxColumn.DataPropertyName = "ServiceTime"
        Me.ServiceTimeDataGridViewTextBoxColumn.HeaderText = "ServiceTime"
        Me.ServiceTimeDataGridViewTextBoxColumn.Name = "ServiceTimeDataGridViewTextBoxColumn"
        Me.ServiceTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceTimeDataGridViewTextBoxColumn.Visible = False
        '
        'PatientAddressDataGridViewTextBoxColumn
        '
        Me.PatientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.HeaderText = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.Name = "PatientAddressDataGridViewTextBoxColumn"
        Me.PatientAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientAddressDataGridViewTextBoxColumn.Visible = False
        '
        'frmBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 406)
        Me.Controls.Add(Me.gbBalBal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceRecordDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBalBal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gbBalBal As System.Windows.Forms.GroupBox
    Friend WithEvents btnBalPaid As System.Windows.Forms.Button
    Friend WithEvents ToothImageDBDataSet As ToothImageDBDataSet
    Friend WithEvents ServiceRecordDBBindingSource As BindingSource
    Friend WithEvents ServiceRecordDBTableAdapter As ToothImageDBDataSetTableAdapters.ServiceRecordDBTableAdapter
    Friend WithEvents ServiceRecIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentalServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
