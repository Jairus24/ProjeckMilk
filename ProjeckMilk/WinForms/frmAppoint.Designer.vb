<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppoint))
        Me.gbAppList = New System.Windows.Forms.GroupBox()
        Me.btnAppntReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApptDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApptTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApptmntBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDBDataSet = New ProjeckMilk.PLDBDataSet()
        Me.btnAppBack = New System.Windows.Forms.Button()
        Me.btnAppCancel = New System.Windows.Forms.Button()
        Me.btnAppQueue = New System.Windows.Forms.Button()
        Me.btnAppNew = New System.Windows.Forms.Button()
        Me.ApptmntTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.apptmntTableAdapter()
        Me.gbAppList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApptmntBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbAppList
        '
        Me.gbAppList.BackColor = System.Drawing.Color.Transparent
        Me.gbAppList.Controls.Add(Me.btnAppntReset)
        Me.gbAppList.Controls.Add(Me.Label1)
        Me.gbAppList.Controls.Add(Me.DateTimePicker1)
        Me.gbAppList.Controls.Add(Me.DataGridView1)
        Me.gbAppList.Controls.Add(Me.btnAppBack)
        Me.gbAppList.Controls.Add(Me.btnAppCancel)
        Me.gbAppList.Controls.Add(Me.btnAppQueue)
        Me.gbAppList.Controls.Add(Me.btnAppNew)
        Me.gbAppList.Location = New System.Drawing.Point(13, 12)
        Me.gbAppList.Name = "gbAppList"
        Me.gbAppList.Size = New System.Drawing.Size(612, 382)
        Me.gbAppList.TabIndex = 0
        Me.gbAppList.TabStop = False
        Me.gbAppList.Text = "List of Appointments"
        '
        'btnAppntReset
        '
        Me.btnAppntReset.Location = New System.Drawing.Point(218, 87)
        Me.btnAppntReset.Name = "btnAppntReset"
        Me.btnAppntReset.Size = New System.Drawing.Size(97, 20)
        Me.btnAppntReset.TabIndex = 7
        Me.btnAppntReset.Text = "View All"
        Me.btnAppntReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter by Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 87)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.ApptDateDataGridViewTextBoxColumn, Me.ApptTimeDataGridViewTextBoxColumn, Me.ServiceTypeDataGridViewTextBoxColumn, Me.PDentistDataGridViewTextBoxColumn, Me.PAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ApptmntBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 110)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(600, 266)
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
        Me.PNameDataGridViewTextBoxColumn.Width = 200
        '
        'ApptDateDataGridViewTextBoxColumn
        '
        Me.ApptDateDataGridViewTextBoxColumn.DataPropertyName = "apptDate"
        Me.ApptDateDataGridViewTextBoxColumn.Frozen = True
        Me.ApptDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.ApptDateDataGridViewTextBoxColumn.Name = "ApptDateDataGridViewTextBoxColumn"
        Me.ApptDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApptDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApptDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ApptDateDataGridViewTextBoxColumn.Width = 110
        '
        'ApptTimeDataGridViewTextBoxColumn
        '
        Me.ApptTimeDataGridViewTextBoxColumn.DataPropertyName = "apptTime"
        Me.ApptTimeDataGridViewTextBoxColumn.Frozen = True
        Me.ApptTimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.ApptTimeDataGridViewTextBoxColumn.Name = "ApptTimeDataGridViewTextBoxColumn"
        Me.ApptTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApptTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApptTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ApptTimeDataGridViewTextBoxColumn.Width = 110
        '
        'ServiceTypeDataGridViewTextBoxColumn
        '
        Me.ServiceTypeDataGridViewTextBoxColumn.DataPropertyName = "serviceType"
        Me.ServiceTypeDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceTypeDataGridViewTextBoxColumn.HeaderText = "serviceType"
        Me.ServiceTypeDataGridViewTextBoxColumn.Name = "ServiceTypeDataGridViewTextBoxColumn"
        Me.ServiceTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceTypeDataGridViewTextBoxColumn.Visible = False
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
        Me.PDentistDataGridViewTextBoxColumn.Width = 176
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
        'ApptmntBindingSource
        '
        Me.ApptmntBindingSource.DataMember = "apptmnt"
        Me.ApptmntBindingSource.DataSource = Me.PLDBDataSet
        '
        'PLDBDataSet
        '
        Me.PLDBDataSet.DataSetName = "PLDBDataSet"
        Me.PLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAppBack
        '
        Me.btnAppBack.Location = New System.Drawing.Point(494, 69)
        Me.btnAppBack.Name = "btnAppBack"
        Me.btnAppBack.Size = New System.Drawing.Size(112, 35)
        Me.btnAppBack.TabIndex = 4
        Me.btnAppBack.Text = "Back"
        Me.btnAppBack.UseVisualStyleBackColor = True
        '
        'btnAppCancel
        '
        Me.btnAppCancel.Location = New System.Drawing.Point(494, 28)
        Me.btnAppCancel.Name = "btnAppCancel"
        Me.btnAppCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnAppCancel.TabIndex = 3
        Me.btnAppCancel.Text = "Cancel Appointment"
        Me.btnAppCancel.UseVisualStyleBackColor = True
        '
        'btnAppQueue
        '
        Me.btnAppQueue.Location = New System.Drawing.Point(361, 69)
        Me.btnAppQueue.Name = "btnAppQueue"
        Me.btnAppQueue.Size = New System.Drawing.Size(112, 35)
        Me.btnAppQueue.TabIndex = 2
        Me.btnAppQueue.Text = "Move to Waiting List"
        Me.btnAppQueue.UseVisualStyleBackColor = True
        '
        'btnAppNew
        '
        Me.btnAppNew.Location = New System.Drawing.Point(361, 28)
        Me.btnAppNew.Name = "btnAppNew"
        Me.btnAppNew.Size = New System.Drawing.Size(112, 35)
        Me.btnAppNew.TabIndex = 1
        Me.btnAppNew.Text = "New Appointment"
        Me.btnAppNew.UseVisualStyleBackColor = True
        '
        'ApptmntTableAdapter
        '
        Me.ApptmntTableAdapter.ClearBeforeFill = True
        '
        'frmAppoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 406)
        Me.Controls.Add(Me.gbAppList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointments"
        Me.gbAppList.ResumeLayout(False)
        Me.gbAppList.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApptmntBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbAppList As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAppBack As System.Windows.Forms.Button
    Friend WithEvents btnAppCancel As System.Windows.Forms.Button
    Friend WithEvents btnAppQueue As System.Windows.Forms.Button
    Friend WithEvents btnAppNew As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAppntReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PLDBDataSet As ProjeckMilk.PLDBDataSet
    Friend WithEvents ApptmntBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApptmntTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.apptmntTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApptDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApptTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDentistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
