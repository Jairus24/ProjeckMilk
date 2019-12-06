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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalance))
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
        Me.ServiceTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDBDataSet = New ProjeckMilk.PLDBDataSet()
        Me.gbBalBal = New System.Windows.Forms.GroupBox()
        Me.btnBalPaid = New System.Windows.Forms.Button()
        Me.ServiceRecordTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.serviceRecordTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.MedDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.PBalanceDataGridViewTextBoxColumn, Me.PDentistDataGridViewTextBoxColumn, Me.PPaidDataGridViewTextBoxColumn, Me.ServiceTimeDataGridViewTextBoxColumn, Me.PAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiceRecordBindingSource
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.Frozen = True
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "pName"
        Me.PNameDataGridViewTextBoxColumn.Frozen = True
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        Me.PNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PNameDataGridViewTextBoxColumn.Width = 180
        '
        'DentalServiceDataGridViewTextBoxColumn
        '
        Me.DentalServiceDataGridViewTextBoxColumn.DataPropertyName = "dentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.Frozen = True
        Me.DentalServiceDataGridViewTextBoxColumn.HeaderText = "Service Type"
        Me.DentalServiceDataGridViewTextBoxColumn.Name = "DentalServiceDataGridViewTextBoxColumn"
        Me.DentalServiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DentalServiceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DentalServiceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DentalServiceDataGridViewTextBoxColumn.Width = 124
        '
        'ServiceDateDataGridViewTextBoxColumn
        '
        Me.ServiceDateDataGridViewTextBoxColumn.DataPropertyName = "serviceDate"
        Me.ServiceDateDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceDateDataGridViewTextBoxColumn.HeaderText = "Date"
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
        Me.ToothNumberDataGridViewTextBoxColumn.Visible = False
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
        Me.MedDataGridViewTextBoxColumn.Width = 150
        '
        'ServiceAmountDataGridViewTextBoxColumn
        '
        Me.ServiceAmountDataGridViewTextBoxColumn.DataPropertyName = "serviceAmount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceAmountDataGridViewTextBoxColumn.HeaderText = "Service Amount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Name = "ServiceAmountDataGridViewTextBoxColumn"
        Me.ServiceAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceAmountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiceAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PBalanceDataGridViewTextBoxColumn
        '
        Me.PBalanceDataGridViewTextBoxColumn.DataPropertyName = "pBalance"
        Me.PBalanceDataGridViewTextBoxColumn.Frozen = True
        Me.PBalanceDataGridViewTextBoxColumn.HeaderText = "Balance Left"
        Me.PBalanceDataGridViewTextBoxColumn.Name = "PBalanceDataGridViewTextBoxColumn"
        Me.PBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PBalanceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PBalanceDataGridViewTextBoxColumn.Width = 145
        '
        'PDentistDataGridViewTextBoxColumn
        '
        Me.PDentistDataGridViewTextBoxColumn.DataPropertyName = "pDentist"
        Me.PDentistDataGridViewTextBoxColumn.Frozen = True
        Me.PDentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.PDentistDataGridViewTextBoxColumn.Name = "PDentistDataGridViewTextBoxColumn"
        Me.PDentistDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDentistDataGridViewTextBoxColumn.Visible = False
        '
        'PPaidDataGridViewTextBoxColumn
        '
        Me.PPaidDataGridViewTextBoxColumn.DataPropertyName = "pPaid"
        Me.PPaidDataGridViewTextBoxColumn.Frozen = True
        Me.PPaidDataGridViewTextBoxColumn.HeaderText = "Paid Amount"
        Me.PPaidDataGridViewTextBoxColumn.Name = "PPaidDataGridViewTextBoxColumn"
        Me.PPaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PPaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PPaidDataGridViewTextBoxColumn.Visible = False
        Me.PPaidDataGridViewTextBoxColumn.Width = 120
        '
        'ServiceTimeDataGridViewTextBoxColumn
        '
        Me.ServiceTimeDataGridViewTextBoxColumn.DataPropertyName = "serviceTime"
        Me.ServiceTimeDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceTimeDataGridViewTextBoxColumn.HeaderText = "serviceTime"
        Me.ServiceTimeDataGridViewTextBoxColumn.Name = "ServiceTimeDataGridViewTextBoxColumn"
        Me.ServiceTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceTimeDataGridViewTextBoxColumn.Visible = False
        '
        'PAddressDataGridViewTextBoxColumn
        '
        Me.PAddressDataGridViewTextBoxColumn.DataPropertyName = "pAddress"
        Me.PAddressDataGridViewTextBoxColumn.Frozen = True
        Me.PAddressDataGridViewTextBoxColumn.HeaderText = "pAddress"
        Me.PAddressDataGridViewTextBoxColumn.Name = "PAddressDataGridViewTextBoxColumn"
        Me.PAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAddressDataGridViewTextBoxColumn.Visible = False
        '
        'ServiceRecordBindingSource
        '
        Me.ServiceRecordBindingSource.DataMember = "serviceRecord"
        Me.ServiceRecordBindingSource.DataSource = Me.PLDBDataSet
        '
        'PLDBDataSet
        '
        Me.PLDBDataSet.DataSetName = "PLDBDataSet"
        Me.PLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ServiceRecordTableAdapter
        '
        Me.ServiceRecordTableAdapter.ClearBeforeFill = True
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
        CType(Me.ServiceRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBalBal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gbBalBal As System.Windows.Forms.GroupBox
    Friend WithEvents btnBalPaid As System.Windows.Forms.Button
    Friend WithEvents PLDBDataSet As ProjeckMilk.PLDBDataSet
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
    Friend WithEvents ServiceTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
