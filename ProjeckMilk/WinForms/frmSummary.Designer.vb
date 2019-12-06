<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummary))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSummary = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServiceRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDBDataSet = New ProjeckMilk.PLDBDataSet()
        Me.dtpSummaryFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblSummaryFrom = New System.Windows.Forms.Label()
        Me.lblSummarySH = New System.Windows.Forms.Label()
        Me.lblSummaryTotal = New System.Windows.Forms.Label()
        Me.lblSummaryIncome = New System.Windows.Forms.Label()
        Me.ServiceRecordTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.serviceRecordTableAdapter()
        Me.btnSummaryAll = New System.Windows.Forms.Button()
        Me.gbSummaryTotal = New System.Windows.Forms.GroupBox()
        Me.lblSummaryNote2 = New System.Windows.Forms.Label()
        Me.lblSummaryNote = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PrintDocument = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.PageSetup = New System.Windows.Forms.ToolStripButton()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serviceTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbSummary.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSummaryTotal.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSummary
        '
        Me.gbSummary.BackColor = System.Drawing.Color.Transparent
        Me.gbSummary.Controls.Add(Me.DataGridView1)
        Me.gbSummary.Location = New System.Drawing.Point(12, 149)
        Me.gbSummary.Name = "gbSummary"
        Me.gbSummary.Size = New System.Drawing.Size(512, 314)
        Me.gbSummary.TabIndex = 0
        Me.gbSummary.TabStop = False
        Me.gbSummary.Text = "Rendered Service:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.serviceTime, Me.ToothNumberDataGridViewTextBoxColumn, Me.MedDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.PBalanceDataGridViewTextBoxColumn, Me.PDentistDataGridViewTextBoxColumn, Me.pPaid})
        Me.DataGridView1.DataSource = Me.ServiceRecordBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.Size = New System.Drawing.Size(499, 289)
        Me.DataGridView1.TabIndex = 0
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
        'dtpSummaryFrom
        '
        Me.dtpSummaryFrom.CustomFormat = ""
        Me.dtpSummaryFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSummaryFrom.Location = New System.Drawing.Point(91, 65)
        Me.dtpSummaryFrom.Name = "dtpSummaryFrom"
        Me.dtpSummaryFrom.Size = New System.Drawing.Size(102, 20)
        Me.dtpSummaryFrom.TabIndex = 1
        '
        'lblSummaryFrom
        '
        Me.lblSummaryFrom.AutoSize = True
        Me.lblSummaryFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblSummaryFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryFrom.Location = New System.Drawing.Point(9, 67)
        Me.lblSummaryFrom.Name = "lblSummaryFrom"
        Me.lblSummaryFrom.Size = New System.Drawing.Size(81, 16)
        Me.lblSummaryFrom.TabIndex = 3
        Me.lblSummaryFrom.Text = "Select Date:"
        '
        'lblSummarySH
        '
        Me.lblSummarySH.AutoSize = True
        Me.lblSummarySH.BackColor = System.Drawing.Color.Transparent
        Me.lblSummarySH.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummarySH.Location = New System.Drawing.Point(8, 30)
        Me.lblSummarySH.Name = "lblSummarySH"
        Me.lblSummarySH.Size = New System.Drawing.Size(150, 24)
        Me.lblSummarySH.TabIndex = 5
        Me.lblSummarySH.Text = "Service History"
        '
        'lblSummaryTotal
        '
        Me.lblSummaryTotal.AutoSize = True
        Me.lblSummaryTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSummaryTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryTotal.Location = New System.Drawing.Point(37, 25)
        Me.lblSummaryTotal.Name = "lblSummaryTotal"
        Me.lblSummaryTotal.Size = New System.Drawing.Size(266, 16)
        Me.lblSummaryTotal.TabIndex = 7
        Me.lblSummaryTotal.Text = "Total Income from Rendered Service:"
        Me.lblSummaryTotal.Visible = False
        '
        'lblSummaryIncome
        '
        Me.lblSummaryIncome.AutoSize = True
        Me.lblSummaryIncome.BackColor = System.Drawing.Color.Transparent
        Me.lblSummaryIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryIncome.Location = New System.Drawing.Point(34, 41)
        Me.lblSummaryIncome.Name = "lblSummaryIncome"
        Me.lblSummaryIncome.Size = New System.Drawing.Size(95, 31)
        Me.lblSummaryIncome.TabIndex = 8
        Me.lblSummaryIncome.Text = "Label1"
        Me.lblSummaryIncome.Visible = False
        '
        'ServiceRecordTableAdapter
        '
        Me.ServiceRecordTableAdapter.ClearBeforeFill = True
        '
        'btnSummaryAll
        '
        Me.btnSummaryAll.Location = New System.Drawing.Point(227, 84)
        Me.btnSummaryAll.Name = "btnSummaryAll"
        Me.btnSummaryAll.Size = New System.Drawing.Size(92, 23)
        Me.btnSummaryAll.TabIndex = 2
        Me.btnSummaryAll.Text = "Calculate All"
        Me.btnSummaryAll.UseVisualStyleBackColor = True
        '
        'gbSummaryTotal
        '
        Me.gbSummaryTotal.BackColor = System.Drawing.Color.Transparent
        Me.gbSummaryTotal.Controls.Add(Me.lblSummaryNote2)
        Me.gbSummaryTotal.Controls.Add(Me.lblSummaryNote)
        Me.gbSummaryTotal.Controls.Add(Me.btnSummaryAll)
        Me.gbSummaryTotal.Controls.Add(Me.lblSummaryTotal)
        Me.gbSummaryTotal.Controls.Add(Me.lblSummaryIncome)
        Me.gbSummaryTotal.Location = New System.Drawing.Point(199, 30)
        Me.gbSummaryTotal.Name = "gbSummaryTotal"
        Me.gbSummaryTotal.Size = New System.Drawing.Size(325, 113)
        Me.gbSummaryTotal.TabIndex = 10
        Me.gbSummaryTotal.TabStop = False
        Me.gbSummaryTotal.Text = "Calculated Income"
        '
        'lblSummaryNote2
        '
        Me.lblSummaryNote2.AutoSize = True
        Me.lblSummaryNote2.BackColor = System.Drawing.Color.Transparent
        Me.lblSummaryNote2.Location = New System.Drawing.Point(37, 97)
        Me.lblSummaryNote2.Name = "lblSummaryNote2"
        Me.lblSummaryNote2.Size = New System.Drawing.Size(179, 13)
        Me.lblSummaryNote2.TabIndex = 11
        Me.lblSummaryNote2.Text = "services from start to the latest input."
        Me.lblSummaryNote2.Visible = False
        '
        'lblSummaryNote
        '
        Me.lblSummaryNote.AutoSize = True
        Me.lblSummaryNote.BackColor = System.Drawing.Color.Transparent
        Me.lblSummaryNote.Location = New System.Drawing.Point(6, 84)
        Me.lblSummaryNote.Name = "lblSummaryNote"
        Me.lblSummaryNote.Size = New System.Drawing.Size(215, 13)
        Me.lblSummaryNote.TabIndex = 10
        Me.lblSummaryNote.Text = "Note: Overall income calculates all recorded"
        Me.lblSummaryNote.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintDocument, Me.PrintPreview, Me.PageSetup})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PrintDocument
        '
        Me.PrintDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintDocument.Image = Global.ProjeckMilk.My.Resources.Resources.printIcon
        Me.PrintDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintDocument.Name = "PrintDocument"
        Me.PrintDocument.Size = New System.Drawing.Size(23, 22)
        Me.PrintDocument.Text = "Print"
        '
        'PrintPreview
        '
        Me.PrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPreview.Image = Global.ProjeckMilk.My.Resources.Resources.PrintPreview
        Me.PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(23, 22)
        Me.PrintPreview.Text = "Print Preview"
        '
        'PageSetup
        '
        Me.PageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageSetup.Image = Global.ProjeckMilk.My.Resources.Resources.printSetup
        Me.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageSetup.Name = "PageSetup"
        Me.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.PageSetup.Text = "Page Setup"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Location = New System.Drawing.Point(426, 469)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(92, 23)
        Me.btnExportExcel.TabIndex = 12
        Me.btnExportExcel.Text = "Export To Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.Frozen = True
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Service Ref. No."
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.PNameDataGridViewTextBoxColumn.Width = 160
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
        Me.DentalServiceDataGridViewTextBoxColumn.Width = 125
        '
        'ServiceDateDataGridViewTextBoxColumn
        '
        Me.ServiceDateDataGridViewTextBoxColumn.DataPropertyName = "serviceDate"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ServiceDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ServiceDateDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceDateDataGridViewTextBoxColumn.HeaderText = "Service Date"
        Me.ServiceDateDataGridViewTextBoxColumn.Name = "ServiceDateDataGridViewTextBoxColumn"
        Me.ServiceDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiceDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServiceDateDataGridViewTextBoxColumn.Width = 111
        '
        'serviceTime
        '
        Me.serviceTime.DataPropertyName = "serviceTime"
        Me.serviceTime.HeaderText = "Time"
        Me.serviceTime.Name = "serviceTime"
        Me.serviceTime.ReadOnly = True
        Me.serviceTime.Visible = False
        '
        'ToothNumberDataGridViewTextBoxColumn
        '
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "toothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "Tooth Number"
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        Me.ToothNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToothNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ToothNumberDataGridViewTextBoxColumn.Visible = False
        '
        'MedDataGridViewTextBoxColumn
        '
        Me.MedDataGridViewTextBoxColumn.DataPropertyName = "med"
        Me.MedDataGridViewTextBoxColumn.HeaderText = "Med"
        Me.MedDataGridViewTextBoxColumn.Name = "MedDataGridViewTextBoxColumn"
        Me.MedDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MedDataGridViewTextBoxColumn.Visible = False
        '
        'ServiceAmountDataGridViewTextBoxColumn
        '
        Me.ServiceAmountDataGridViewTextBoxColumn.DataPropertyName = "serviceAmount"
        Me.ServiceAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.ServiceAmountDataGridViewTextBoxColumn.Name = "ServiceAmountDataGridViewTextBoxColumn"
        Me.ServiceAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceAmountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiceAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServiceAmountDataGridViewTextBoxColumn.Visible = False
        '
        'PBalanceDataGridViewTextBoxColumn
        '
        Me.PBalanceDataGridViewTextBoxColumn.DataPropertyName = "pBalance"
        Me.PBalanceDataGridViewTextBoxColumn.HeaderText = "Balance Left"
        Me.PBalanceDataGridViewTextBoxColumn.Name = "PBalanceDataGridViewTextBoxColumn"
        Me.PBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PBalanceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PBalanceDataGridViewTextBoxColumn.Visible = False
        '
        'PDentistDataGridViewTextBoxColumn
        '
        Me.PDentistDataGridViewTextBoxColumn.DataPropertyName = "pDentist"
        Me.PDentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.PDentistDataGridViewTextBoxColumn.Name = "PDentistDataGridViewTextBoxColumn"
        Me.PDentistDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDentistDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PDentistDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PDentistDataGridViewTextBoxColumn.Visible = False
        '
        'pPaid
        '
        Me.pPaid.DataPropertyName = "pPaid"
        Me.pPaid.HeaderText = "Paid Amount"
        Me.pPaid.Name = "pPaid"
        Me.pPaid.ReadOnly = True
        Me.pPaid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(535, 499)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblSummarySH)
        Me.Controls.Add(Me.lblSummaryFrom)
        Me.Controls.Add(Me.dtpSummaryFrom)
        Me.Controls.Add(Me.gbSummary)
        Me.Controls.Add(Me.gbSummaryTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.gbSummary.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSummaryTotal.ResumeLayout(False)
        Me.gbSummaryTotal.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSummary As System.Windows.Forms.GroupBox
    Friend WithEvents dtpSummaryFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSummaryFrom As System.Windows.Forms.Label
    Friend WithEvents lblSummarySH As System.Windows.Forms.Label
    Friend WithEvents lblSummaryTotal As System.Windows.Forms.Label
    Friend WithEvents lblSummaryIncome As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PLDBDataSet As ProjeckMilk.PLDBDataSet
    Friend WithEvents ServiceRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceRecordTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.serviceRecordTableAdapter
    Friend WithEvents btnSummaryAll As System.Windows.Forms.Button
    Friend WithEvents gbSummaryTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblSummaryNote As System.Windows.Forms.Label
    Friend WithEvents lblSummaryNote2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PrintDocument As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents PageSetup As System.Windows.Forms.ToolStripButton
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentalServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents serviceTime As DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pPaid As DataGridViewTextBoxColumn
End Class
