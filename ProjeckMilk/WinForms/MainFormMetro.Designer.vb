<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormMetro
    Inherits Syncfusion.WinForms.Controls.SfForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormMetro))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServiceQueueDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.AppointmentsDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BorderLayout1 = New Syncfusion.Windows.Forms.Tools.BorderLayout(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dateLabel3 = New System.Windows.Forms.Label()
        Me.dateLabel2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonAdv7 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ButtonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ButtonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ButtonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothImageDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToothImageDBDataSet = New ProjeckMilk.ToothImageDBDataSet()
        Me.ServiceQueueDBTableAdapter = New ProjeckMilk.ToothImageDBDataSetTableAdapters.ServiceQueueDBTableAdapter()
        Me.AppointmentsDBTableAdapter = New ProjeckMilk.ToothImageDBDataSetTableAdapters.AppointmentsDBTableAdapter()
        Me.ServiceQueueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceQueueDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceQueueIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn1, Me.DentalServiceDataGridViewTextBoxColumn, Me.ServiceDateDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.ServiceAmountDataGridViewTextBoxColumn, Me.DentistDataGridViewTextBoxColumn1, Me.PatientAddressDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.ServiceQueueDBBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(209, 185)
        Me.BorderLayout1.SetMinimumSize(Me.DataGridView1, New System.Drawing.Size(784, 394))
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.BorderLayout1.SetPreferredSize(Me.DataGridView1, New System.Drawing.Size(774, 442))
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1054, 453)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.TabStop = False
        '
        'ServiceQueueDBBindingSource
        '
        Me.ServiceQueueDBBindingSource.DataMember = "ServiceQueueDB"
        Me.ServiceQueueDBBindingSource.DataSource = Me.ToothImageDBDataSetBindingSource
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.AppointmentDateDataGridViewTextBoxColumn, Me.AppointmentTimeDataGridViewTextBoxColumn, Me.ServiceTypeDataGridViewTextBoxColumn, Me.DentistDataGridViewTextBoxColumn, Me.PatientAddressDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.AppointmentsDBBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Location = New System.Drawing.Point(296, 380)
        Me.BorderLayout1.SetMinimumSize(Me.DataGridView2, New System.Drawing.Size(240, 40))
        Me.DataGridView2.Name = "DataGridView2"
        Me.BorderLayout1.SetPreferredSize(Me.DataGridView2, New System.Drawing.Size(240, 40))
        Me.DataGridView2.Size = New System.Drawing.Size(240, 40)
        Me.DataGridView2.TabIndex = 14
        Me.DataGridView2.TabStop = False
        Me.DataGridView2.Visible = False
        '
        'AppointmentsDBBindingSource
        '
        Me.AppointmentsDBBindingSource.DataMember = "AppointmentsDB"
        Me.AppointmentsDBBindingSource.DataSource = Me.ToothImageDBDataSetBindingSource
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Text = "DentaSmile Patient Filer"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'BackgroundWorker1
        '
        '
        'BorderLayout1
        '
        Me.BorderLayout1.ContainerControl = Me
        Me.BorderLayout1.HGap = 0
        Me.BorderLayout1.VGap = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dateLabel3)
        Me.Panel1.Controls.Add(Me.dateLabel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonAdv7)
        Me.Panel1.Controls.Add(Me.ButtonAdv6)
        Me.Panel1.Controls.Add(Me.ButtonAdv3)
        Me.Panel1.Controls.Add(Me.dateLabel)
        Me.Panel1.Controls.Add(Me.ButtonAdv2)
        Me.Panel1.Controls.Add(Me.ButtonAdv1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.BorderLayout1.SetMinimumSize(Me.Panel1, New System.Drawing.Size(170, 551))
        Me.Panel1.Name = "Panel1"
        Me.BorderLayout1.SetPreferredSize(Me.Panel1, New System.Drawing.Size(206, 636))
        Me.Panel1.Size = New System.Drawing.Size(206, 654)
        Me.Panel1.TabIndex = 0
        '
        'dateLabel3
        '
        Me.dateLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dateLabel3.AutoSize = True
        Me.dateLabel3.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel3.ForeColor = System.Drawing.Color.White
        Me.dateLabel3.Location = New System.Drawing.Point(3, 615)
        Me.dateLabel3.Name = "dateLabel3"
        Me.dateLabel3.Size = New System.Drawing.Size(98, 16)
        Me.dateLabel3.TabIndex = 17
        Me.dateLabel3.Text = "Today is "
        Me.dateLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateLabel2
        '
        Me.dateLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dateLabel2.AutoSize = True
        Me.dateLabel2.Font = New System.Drawing.Font("Lucida Console", 11.0!)
        Me.dateLabel2.ForeColor = System.Drawing.Color.White
        Me.dateLabel2.Location = New System.Drawing.Point(3, 594)
        Me.dateLabel2.Name = "dateLabel2"
        Me.dateLabel2.Size = New System.Drawing.Size(88, 15)
        Me.dateLabel2.TabIndex = 16
        Me.dateLabel2.Text = "Today is "
        Me.dateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.icon_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(26, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ButtonAdv7
        '
        Me.ButtonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv7.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdv7.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv7.FlatAppearance.BorderSize = 0
        Me.ButtonAdv7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv7.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv7.Image = Global.ProjeckMilk.My.Resources.Resources.Dialog_Box_About50
        Me.ButtonAdv7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv7.Location = New System.Drawing.Point(15, 480)
        Me.ButtonAdv7.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv7.Name = "ButtonAdv7"
        Me.ButtonAdv7.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv7.TabIndex = 6
        Me.ButtonAdv7.TabStop = False
        Me.ButtonAdv7.Text = "About"
        Me.ButtonAdv7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv7.ThemeName = "Metro"
        Me.ButtonAdv7.UseVisualStyle = False
        Me.ButtonAdv7.UseVisualStyleBackColor = False
        '
        'ButtonAdv6
        '
        Me.ButtonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv6.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdv6.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv6.FlatAppearance.BorderSize = 0
        Me.ButtonAdv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv6.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv6.Image = Global.ProjeckMilk.My.Resources.Resources.Admin50
        Me.ButtonAdv6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv6.Location = New System.Drawing.Point(15, 410)
        Me.ButtonAdv6.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv6.Name = "ButtonAdv6"
        Me.ButtonAdv6.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv6.TabIndex = 5
        Me.ButtonAdv6.TabStop = False
        Me.ButtonAdv6.Text = "Admin"
        Me.ButtonAdv6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv6.ThemeName = "Metro"
        Me.ButtonAdv6.UseVisualStyle = False
        Me.ButtonAdv6.UseVisualStyleBackColor = False
        '
        'ButtonAdv3
        '
        Me.ButtonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv3.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdv3.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv3.FlatAppearance.BorderSize = 0
        Me.ButtonAdv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv3.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv3.Image = Global.ProjeckMilk.My.Resources.Resources.Blog_WF50
        Me.ButtonAdv3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv3.Location = New System.Drawing.Point(15, 340)
        Me.ButtonAdv3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv3.Name = "ButtonAdv3"
        Me.ButtonAdv3.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv3.TabIndex = 2
        Me.ButtonAdv3.TabStop = False
        Me.ButtonAdv3.Text = "Summary"
        Me.ButtonAdv3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv3.ThemeName = "Metro"
        Me.ButtonAdv3.UseVisualStyle = False
        Me.ButtonAdv3.UseVisualStyleBackColor = False
        '
        'dateLabel
        '
        Me.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Lucida Console", 11.0!)
        Me.dateLabel.ForeColor = System.Drawing.Color.White
        Me.dateLabel.Location = New System.Drawing.Point(3, 573)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(88, 15)
        Me.dateLabel.TabIndex = 15
        Me.dateLabel.Text = "Today is "
        Me.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonAdv2
        '
        Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdv2.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv2.FlatAppearance.BorderSize = 0
        Me.ButtonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv2.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv2.Image = Global.ProjeckMilk.My.Resources.Resources.Alarm_Clock50
        Me.ButtonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv2.Location = New System.Drawing.Point(15, 270)
        Me.ButtonAdv2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv2.Name = "ButtonAdv2"
        Me.ButtonAdv2.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv2.TabIndex = 1
        Me.ButtonAdv2.TabStop = False
        Me.ButtonAdv2.Text = "Appointments"
        Me.ButtonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv2.ThemeName = "Metro"
        Me.ButtonAdv2.UseVisualStyle = False
        Me.ButtonAdv2.UseVisualStyleBackColor = False
        '
        'ButtonAdv1
        '
        Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdv1.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv1.FlatAppearance.BorderSize = 0
        Me.ButtonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv1.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv1.Image = Global.ProjeckMilk.My.Resources.Resources.Patient_Cab50
        Me.ButtonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv1.Location = New System.Drawing.Point(15, 200)
        Me.ButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv1.Name = "ButtonAdv1"
        Me.ButtonAdv1.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv1.TabIndex = 0
        Me.ButtonAdv1.TabStop = False
        Me.ButtonAdv1.Text = "Patient Records"
        Me.ButtonAdv1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv1.ThemeName = "Metro"
        Me.ButtonAdv1.UseVisualStyle = False
        Me.ButtonAdv1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.ButtonAdv4)
        Me.Panel3.Controls.Add(Me.ButtonAdv5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-12, 0)
        Me.BorderLayout1.SetMinimumSize(Me.Panel3, New System.Drawing.Size(1134, 191))
        Me.Panel3.Name = "Panel3"
        Me.BorderLayout1.SetPreferredSize(Me.Panel3, New System.Drawing.Size(1302, 179))
        Me.Panel3.Size = New System.Drawing.Size(1302, 179)
        Me.Panel3.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Title_1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.ProjeckMilk.My.Resources.Resources.Title_1
        Me.PictureBox2.Location = New System.Drawing.Point(221, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(312, 114)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'ButtonAdv4
        '
        Me.ButtonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv4.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdv4.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv4.FlatAppearance.BorderSize = 0
        Me.ButtonAdv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv4.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv4.Image = Global.ProjeckMilk.My.Resources.Resources.Check50
        Me.ButtonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdv4.Location = New System.Drawing.Point(885, 115)
        Me.ButtonAdv4.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv4.Name = "ButtonAdv4"
        Me.ButtonAdv4.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv4.TabIndex = 3
        Me.ButtonAdv4.TabStop = False
        Me.ButtonAdv4.Text = "Bill Out"
        Me.ButtonAdv4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdv4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv4.ThemeName = "Metro"
        Me.ButtonAdv4.UseVisualStyle = False
        Me.ButtonAdv4.UseVisualStyleBackColor = False
        '
        'ButtonAdv5
        '
        Me.ButtonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv5.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdv5.BeforeTouchSize = New System.Drawing.Size(188, 64)
        Me.ButtonAdv5.FlatAppearance.BorderSize = 0
        Me.ButtonAdv5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv5.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv5.Image = Global.ProjeckMilk.My.Resources.Resources.Close50
        Me.ButtonAdv5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdv5.Location = New System.Drawing.Point(1079, 115)
        Me.ButtonAdv5.MetroColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonAdv5.Name = "ButtonAdv5"
        Me.ButtonAdv5.Size = New System.Drawing.Size(188, 64)
        Me.ButtonAdv5.TabIndex = 4
        Me.ButtonAdv5.TabStop = False
        Me.ButtonAdv5.Text = "Remove"
        Me.ButtonAdv5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdv5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAdv5.ThemeName = "Metro"
        Me.ButtonAdv5.UseVisualStyle = False
        Me.ButtonAdv5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(217, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Patient Queue:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AppointmentIDDataGridViewTextBoxColumn
        '
        Me.AppointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn.Name = "AppointmentIDDataGridViewTextBoxColumn"
        Me.AppointmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        '
        'AppointmentDateDataGridViewTextBoxColumn
        '
        Me.AppointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate"
        Me.AppointmentDateDataGridViewTextBoxColumn.HeaderText = "AppointmentDate"
        Me.AppointmentDateDataGridViewTextBoxColumn.Name = "AppointmentDateDataGridViewTextBoxColumn"
        '
        'AppointmentTimeDataGridViewTextBoxColumn
        '
        Me.AppointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentTime"
        Me.AppointmentTimeDataGridViewTextBoxColumn.HeaderText = "AppointmentTime"
        Me.AppointmentTimeDataGridViewTextBoxColumn.Name = "AppointmentTimeDataGridViewTextBoxColumn"
        '
        'ServiceTypeDataGridViewTextBoxColumn
        '
        Me.ServiceTypeDataGridViewTextBoxColumn.DataPropertyName = "ServiceType"
        Me.ServiceTypeDataGridViewTextBoxColumn.HeaderText = "ServiceType"
        Me.ServiceTypeDataGridViewTextBoxColumn.Name = "ServiceTypeDataGridViewTextBoxColumn"
        '
        'DentistDataGridViewTextBoxColumn
        '
        Me.DentistDataGridViewTextBoxColumn.DataPropertyName = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.HeaderText = "Dentist"
        Me.DentistDataGridViewTextBoxColumn.Name = "DentistDataGridViewTextBoxColumn"
        '
        'PatientAddressDataGridViewTextBoxColumn
        '
        Me.PatientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.HeaderText = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn.Name = "PatientAddressDataGridViewTextBoxColumn"
        '
        'ToothImageDBDataSetBindingSource
        '
        Me.ToothImageDBDataSetBindingSource.DataSource = Me.ToothImageDBDataSet
        Me.ToothImageDBDataSetBindingSource.Position = 0
        '
        'ToothImageDBDataSet
        '
        Me.ToothImageDBDataSet.DataSetName = "ToothImageDBDataSet"
        Me.ToothImageDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiceQueueDBTableAdapter
        '
        Me.ServiceQueueDBTableAdapter.ClearBeforeFill = True
        '
        'AppointmentsDBTableAdapter
        '
        Me.AppointmentsDBTableAdapter.ClearBeforeFill = True
        '
        'ServiceQueueIDDataGridViewTextBoxColumn
        '
        Me.ServiceQueueIDDataGridViewTextBoxColumn.DataPropertyName = "serviceQueueID"
        Me.ServiceQueueIDDataGridViewTextBoxColumn.HeaderText = "serviceQueueID"
        Me.ServiceQueueIDDataGridViewTextBoxColumn.Name = "ServiceQueueIDDataGridViewTextBoxColumn"
        Me.ServiceQueueIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceQueueIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServiceQueueIDDataGridViewTextBoxColumn.Visible = False
        '
        'PatientNameDataGridViewTextBoxColumn1
        '
        Me.PatientNameDataGridViewTextBoxColumn1.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn1.HeaderText = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn1.Name = "PatientNameDataGridViewTextBoxColumn1"
        Me.PatientNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PatientNameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PatientNameDataGridViewTextBoxColumn1.Width = 250
        '
        'DentalServiceDataGridViewTextBoxColumn
        '
        Me.DentalServiceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DentalServiceDataGridViewTextBoxColumn.DataPropertyName = "DentalService"
        Me.DentalServiceDataGridViewTextBoxColumn.HeaderText = "Dental Service"
        Me.DentalServiceDataGridViewTextBoxColumn.Name = "DentalServiceDataGridViewTextBoxColumn"
        Me.DentalServiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DentalServiceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ServiceDateDataGridViewTextBoxColumn
        '
        Me.ServiceDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDate"
        Me.ServiceDateDataGridViewTextBoxColumn.HeaderText = "Date and Time"
        Me.ServiceDateDataGridViewTextBoxColumn.Name = "ServiceDateDataGridViewTextBoxColumn"
        Me.ServiceDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ToothNumberDataGridViewTextBoxColumn
        '
        Me.ToothNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "Tooth No."
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        Me.ToothNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToothNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.ServiceAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DentistDataGridViewTextBoxColumn1
        '
        Me.DentistDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DentistDataGridViewTextBoxColumn1.DataPropertyName = "Dentist"
        Me.DentistDataGridViewTextBoxColumn1.HeaderText = "Dentist"
        Me.DentistDataGridViewTextBoxColumn1.Name = "DentistDataGridViewTextBoxColumn1"
        Me.DentistDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DentistDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PatientAddressDataGridViewTextBoxColumn1
        '
        Me.PatientAddressDataGridViewTextBoxColumn1.DataPropertyName = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn1.HeaderText = "PatientAddress"
        Me.PatientAddressDataGridViewTextBoxColumn1.Name = "PatientAddressDataGridViewTextBoxColumn1"
        Me.PatientAddressDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PatientAddressDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PatientAddressDataGridViewTextBoxColumn1.Visible = False
        '
        'MainFormMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 654)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainFormMetro"
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Style.ForeColor = System.Drawing.Color.White
        Me.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Style.TitleBar.BottomBorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Style.TitleBar.ForeColor = System.Drawing.Color.White
        Me.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text = "Tooth Image Dental Records™ - SQL Edition"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceQueueDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderLayout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToothImageDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BorderLayout1 As Syncfusion.Windows.Forms.Tools.BorderLayout
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv7 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv6 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents dateLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dateLabel3 As Label
    Friend WithEvents dateLabel2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedsQueueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToothImageDBDataSetBindingSource As BindingSource
    Friend WithEvents ToothImageDBDataSet As ToothImageDBDataSet
    Friend WithEvents ServiceQueueDBBindingSource As BindingSource
    Friend WithEvents ServiceQueueDBTableAdapter As ToothImageDBDataSetTableAdapters.ServiceQueueDBTableAdapter
    Friend WithEvents AppointmentsDBBindingSource As BindingSource
    Friend WithEvents AppointmentsDBTableAdapter As ToothImageDBDataSetTableAdapters.AppointmentsDBTableAdapter
    Friend WithEvents ServiceQueueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DentalServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientAddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
