<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMed))
        Me.bgMed01 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedsQueueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedsQueueDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToothImageDBDataSet = New ProjeckMilk.ToothImageDBDataSet()
        Me.txtMedBalance = New System.Windows.Forms.TextBox()
        Me.lblMedBalance = New System.Windows.Forms.Label()
        Me.btnMedConfirm = New System.Windows.Forms.Button()
        Me.lblMed02 = New System.Windows.Forms.Label()
        Me.txtMed = New System.Windows.Forms.TextBox()
        Me.lblMed = New System.Windows.Forms.Label()
        Me.MedsQueueDBTableAdapter = New ProjeckMilk.ToothImageDBDataSetTableAdapters.MedsQueueDBTableAdapter()
        Me.bgMed01.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedsQueueDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgMed01
        '
        Me.bgMed01.BackColor = System.Drawing.Color.Transparent
        Me.bgMed01.Controls.Add(Me.DataGridView1)
        Me.bgMed01.Controls.Add(Me.txtMedBalance)
        Me.bgMed01.Controls.Add(Me.lblMedBalance)
        Me.bgMed01.Controls.Add(Me.btnMedConfirm)
        Me.bgMed01.Controls.Add(Me.lblMed02)
        Me.bgMed01.Controls.Add(Me.txtMed)
        Me.bgMed01.Controls.Add(Me.lblMed)
        Me.bgMed01.Location = New System.Drawing.Point(13, 13)
        Me.bgMed01.Name = "bgMed01"
        Me.bgMed01.Size = New System.Drawing.Size(301, 151)
        Me.bgMed01.TabIndex = 0
        Me.bgMed01.TabStop = False
        Me.bgMed01.Text = "Medication"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pAddress, Me.MedsQueueIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.DentistDataGridViewTextBoxColumn, Me.PatientAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedsQueueDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(135, 28)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.Visible = False
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
        'MedsQueueIDDataGridViewTextBoxColumn
        '
        Me.MedsQueueIDDataGridViewTextBoxColumn.DataPropertyName = "medsQueueID"
        Me.MedsQueueIDDataGridViewTextBoxColumn.HeaderText = "medsQueueID"
        Me.MedsQueueIDDataGridViewTextBoxColumn.Name = "MedsQueueIDDataGridViewTextBoxColumn"
        Me.MedsQueueIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DentalServiceDataGridViewTextBoxColumn
        '
        Me.DentalServiceDataGridViewTextBoxColumn.DataPropertyName = "DentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.HeaderText = "DentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.Name = "DentalServiceDataGridViewTextBoxColumn"
        Me.DentalServiceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceDateDataGridViewTextBoxColumn
        '
        Me.ServiceDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDate"
        Me.ServiceDateDataGridViewTextBoxColumn.HeaderText = "ServiceDate"
        Me.ServiceDateDataGridViewTextBoxColumn.Name = "ServiceDateDataGridViewTextBoxColumn"
        Me.ServiceDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToothNumberDataGridViewTextBoxColumn
        '
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        Me.ToothNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceAmountDataGridViewTextBoxColumn
        '
        Me.ServiceAmountDataGridViewTextBoxColumn.DataPropertyName = "ServiceAmount"
        Me.ServiceAmountDataGridViewTextBoxColumn.HeaderText = "ServiceAmount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Name = "ServiceAmountDataGridViewTextBoxColumn"
        Me.ServiceAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DentistDataGridViewTextBoxColumn
        '
        Me.DentistDataGridViewTextBoxColumn.DataPropertyName = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.Name = "DentistDataGridViewTextBoxColumn"
        Me.DentistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientAddressDataGridViewTextBoxColumn
        '
        Me.PatientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.HeaderText = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.Name = "PatientAddressDataGridViewTextBoxColumn"
        Me.PatientAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedsQueueDBBindingSource
        '
        Me.MedsQueueDBBindingSource.DataMember = "MedsQueueDB"
        Me.MedsQueueDBBindingSource.DataSource = Me.ToothImageDBDataSet
        '
        'ToothImageDBDataSet
        '
        Me.ToothImageDBDataSet.DataSetName = "ToothImageDBDataSet"
        Me.ToothImageDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMedBalance
        '
        Me.txtMedBalance.Location = New System.Drawing.Point(10, 91)
        Me.txtMedBalance.Name = "txtMedBalance"
        Me.txtMedBalance.Size = New System.Drawing.Size(284, 20)
        Me.txtMedBalance.TabIndex = 2
        Me.txtMedBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMedBalance
        '
        Me.lblMedBalance.AutoSize = True
        Me.lblMedBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblMedBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedBalance.Location = New System.Drawing.Point(6, 67)
        Me.lblMedBalance.Name = "lblMedBalance"
        Me.lblMedBalance.Size = New System.Drawing.Size(104, 20)
        Me.lblMedBalance.TabIndex = 4
        Me.lblMedBalance.Text = "Amount Paid:"
        '
        'btnMedConfirm
        '
        Me.btnMedConfirm.Location = New System.Drawing.Point(219, 117)
        Me.btnMedConfirm.Name = "btnMedConfirm"
        Me.btnMedConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnMedConfirm.TabIndex = 3
        Me.btnMedConfirm.Text = "Confirm"
        Me.btnMedConfirm.UseVisualStyleBackColor = True
        '
        'lblMed02
        '
        Me.lblMed02.AutoSize = True
        Me.lblMed02.BackColor = System.Drawing.Color.Transparent
        Me.lblMed02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMed02.Location = New System.Drawing.Point(103, 23)
        Me.lblMed02.Name = "lblMed02"
        Me.lblMed02.Size = New System.Drawing.Size(155, 16)
        Me.lblMed02.TabIndex = 2
        Me.lblMed02.Text = "(Leave this blank if none)"
        '
        'txtMed
        '
        Me.txtMed.Location = New System.Drawing.Point(11, 44)
        Me.txtMed.Name = "txtMed"
        Me.txtMed.Size = New System.Drawing.Size(284, 20)
        Me.txtMed.TabIndex = 1
        Me.txtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMed
        '
        Me.lblMed.AutoSize = True
        Me.lblMed.BackColor = System.Drawing.Color.Transparent
        Me.lblMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMed.Location = New System.Drawing.Point(7, 20)
        Me.lblMed.Name = "lblMed"
        Me.lblMed.Size = New System.Drawing.Size(90, 20)
        Me.lblMed.TabIndex = 0
        Me.lblMed.Text = "Medication:"
        '
        'MedsQueueDBTableAdapter
        '
        Me.MedsQueueDBTableAdapter.ClearBeforeFill = True
        '
        'frmMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(326, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.bgMed01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMed"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check-Out"
        Me.bgMed01.ResumeLayout(False)
        Me.bgMed01.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedsQueueDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgMed01 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMedConfirm As System.Windows.Forms.Button
    Friend WithEvents lblMed02 As System.Windows.Forms.Label
    Friend WithEvents txtMed As System.Windows.Forms.TextBox
    Friend WithEvents lblMed As System.Windows.Forms.Label
    Friend WithEvents txtMedBalance As System.Windows.Forms.TextBox
    Friend WithEvents lblMedBalance As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToothImageDBDataSet As ToothImageDBDataSet
    Friend WithEvents MedsQueueDBBindingSource As BindingSource
    Friend WithEvents MedsQueueDBTableAdapter As ToothImageDBDataSetTableAdapters.MedsQueueDBTableAdapter
    Friend WithEvents MedsQueueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentalServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
