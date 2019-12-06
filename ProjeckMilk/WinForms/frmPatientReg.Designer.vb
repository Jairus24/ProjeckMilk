<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientReg))
        Me.gbRegName = New System.Windows.Forms.GroupBox()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.btnRegCancel = New System.Windows.Forms.Button()
        Me.btnRegSave = New System.Windows.Forms.Button()
        Me.cbRegMarital = New System.Windows.Forms.ComboBox()
        Me.lblRegbDate = New System.Windows.Forms.Label()
        Me.dtpRegBDay = New System.Windows.Forms.DateTimePicker()
        Me.lblRegStatus = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.lblRegOccu = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblRegContactNo = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblRegAddress = New System.Windows.Forms.Label()
        Me.lblRegmName = New System.Windows.Forms.Label()
        Me.lblRegfName = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblReglName = New System.Windows.Forms.Label()
        Me.PLDBDataSet = New ProjeckMilk.PLDBDataSet()
        Me.PatientDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientDBTableAdapter = New ProjeckMilk.PLDBDataSetTableAdapters.patientDBTableAdapter()
        Me.gbRegName.SuspendLayout()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRegName
        '
        Me.gbRegName.BackColor = System.Drawing.Color.Transparent
        Me.gbRegName.Controls.Add(Me.btnSaveRecord)
        Me.gbRegName.Controls.Add(Me.btnRegCancel)
        Me.gbRegName.Controls.Add(Me.btnRegSave)
        Me.gbRegName.Controls.Add(Me.cbRegMarital)
        Me.gbRegName.Controls.Add(Me.lblRegbDate)
        Me.gbRegName.Controls.Add(Me.dtpRegBDay)
        Me.gbRegName.Controls.Add(Me.lblRegStatus)
        Me.gbRegName.Controls.Add(Me.txtOccupation)
        Me.gbRegName.Controls.Add(Me.lblRegOccu)
        Me.gbRegName.Controls.Add(Me.txtContact)
        Me.gbRegName.Controls.Add(Me.lblRegContactNo)
        Me.gbRegName.Controls.Add(Me.txtAddress)
        Me.gbRegName.Controls.Add(Me.lblRegAddress)
        Me.gbRegName.Controls.Add(Me.lblRegmName)
        Me.gbRegName.Controls.Add(Me.lblRegfName)
        Me.gbRegName.Controls.Add(Me.txtMiddleName)
        Me.gbRegName.Controls.Add(Me.txtFirstName)
        Me.gbRegName.Controls.Add(Me.txtLastName)
        Me.gbRegName.Controls.Add(Me.lblReglName)
        Me.gbRegName.Location = New System.Drawing.Point(12, 6)
        Me.gbRegName.Name = "gbRegName"
        Me.gbRegName.Size = New System.Drawing.Size(427, 274)
        Me.gbRegName.TabIndex = 0
        Me.gbRegName.TabStop = False
        Me.gbRegName.Text = "Patient Information"
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Location = New System.Drawing.Point(148, 236)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(131, 31)
        Me.btnSaveRecord.TabIndex = 10
        Me.btnSaveRecord.Text = "Save Edit"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'btnRegCancel
        '
        Me.btnRegCancel.Location = New System.Drawing.Point(284, 236)
        Me.btnRegCancel.Name = "btnRegCancel"
        Me.btnRegCancel.Size = New System.Drawing.Size(131, 31)
        Me.btnRegCancel.TabIndex = 11
        Me.btnRegCancel.Text = "Cancel"
        Me.btnRegCancel.UseVisualStyleBackColor = True
        '
        'btnRegSave
        '
        Me.btnRegSave.Location = New System.Drawing.Point(11, 236)
        Me.btnRegSave.Name = "btnRegSave"
        Me.btnRegSave.Size = New System.Drawing.Size(131, 31)
        Me.btnRegSave.TabIndex = 9
        Me.btnRegSave.Text = "Register"
        Me.btnRegSave.UseVisualStyleBackColor = True
        '
        'cbRegMarital
        '
        Me.cbRegMarital.FormattingEnabled = True
        Me.cbRegMarital.ItemHeight = 13
        Me.cbRegMarital.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed (for Male)", "Widower (for Female)"})
        Me.cbRegMarital.Location = New System.Drawing.Point(147, 208)
        Me.cbRegMarital.Name = "cbRegMarital"
        Me.cbRegMarital.Size = New System.Drawing.Size(131, 21)
        Me.cbRegMarital.TabIndex = 15
        '
        'lblRegbDate
        '
        Me.lblRegbDate.AutoSize = True
        Me.lblRegbDate.BackColor = System.Drawing.Color.Transparent
        Me.lblRegbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegbDate.Location = New System.Drawing.Point(280, 131)
        Me.lblRegbDate.Name = "lblRegbDate"
        Me.lblRegbDate.Size = New System.Drawing.Size(85, 20)
        Me.lblRegbDate.TabIndex = 14
        Me.lblRegbDate.Text = "Birth Date:"
        '
        'dtpRegBDay
        '
        Me.dtpRegBDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dtpRegBDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegBDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpRegBDay.Location = New System.Drawing.Point(284, 153)
        Me.dtpRegBDay.Name = "dtpRegBDay"
        Me.dtpRegBDay.ShowUpDown = True
        Me.dtpRegBDay.Size = New System.Drawing.Size(131, 20)
        Me.dtpRegBDay.TabIndex = 7
        '
        'lblRegStatus
        '
        Me.lblRegStatus.AutoSize = True
        Me.lblRegStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblRegStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegStatus.Location = New System.Drawing.Point(143, 185)
        Me.lblRegStatus.Name = "lblRegStatus"
        Me.lblRegStatus.Size = New System.Drawing.Size(111, 20)
        Me.lblRegStatus.TabIndex = 12
        Me.lblRegStatus.Text = "Marital Status:"
        '
        'txtOccupation
        '
        Me.txtOccupation.Location = New System.Drawing.Point(147, 153)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(131, 20)
        Me.txtOccupation.TabIndex = 6
        '
        'lblRegOccu
        '
        Me.lblRegOccu.AutoSize = True
        Me.lblRegOccu.BackColor = System.Drawing.Color.Transparent
        Me.lblRegOccu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegOccu.Location = New System.Drawing.Point(143, 131)
        Me.lblRegOccu.Name = "lblRegOccu"
        Me.lblRegOccu.Size = New System.Drawing.Size(94, 20)
        Me.lblRegOccu.TabIndex = 10
        Me.lblRegOccu.Text = "Occupation:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(11, 153)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(130, 20)
        Me.txtContact.TabIndex = 5
        '
        'lblRegContactNo
        '
        Me.lblRegContactNo.AutoSize = True
        Me.lblRegContactNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRegContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegContactNo.Location = New System.Drawing.Point(6, 131)
        Me.lblRegContactNo.Name = "lblRegContactNo"
        Me.lblRegContactNo.Size = New System.Drawing.Size(97, 20)
        Me.lblRegContactNo.TabIndex = 8
        Me.lblRegContactNo.Text = "Contact No.:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(10, 96)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(405, 20)
        Me.txtAddress.TabIndex = 4
        '
        'lblRegAddress
        '
        Me.lblRegAddress.AutoSize = True
        Me.lblRegAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblRegAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegAddress.Location = New System.Drawing.Point(6, 72)
        Me.lblRegAddress.Name = "lblRegAddress"
        Me.lblRegAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblRegAddress.TabIndex = 6
        Me.lblRegAddress.Text = "Address:"
        '
        'lblRegmName
        '
        Me.lblRegmName.AutoSize = True
        Me.lblRegmName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegmName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegmName.Location = New System.Drawing.Point(280, 16)
        Me.lblRegmName.Name = "lblRegmName"
        Me.lblRegmName.Size = New System.Drawing.Size(105, 20)
        Me.lblRegmName.TabIndex = 5
        Me.lblRegmName.Text = "Middle Name:"
        '
        'lblRegfName
        '
        Me.lblRegfName.AutoSize = True
        Me.lblRegfName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegfName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegfName.Location = New System.Drawing.Point(143, 16)
        Me.lblRegfName.Name = "lblRegfName"
        Me.lblRegfName.Size = New System.Drawing.Size(90, 20)
        Me.lblRegfName.TabIndex = 4
        Me.lblRegfName.Text = "First Name:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(284, 40)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(131, 20)
        Me.txtMiddleName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(147, 40)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(131, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(10, 40)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(131, 20)
        Me.txtLastName.TabIndex = 1
        '
        'lblReglName
        '
        Me.lblReglName.AutoSize = True
        Me.lblReglName.BackColor = System.Drawing.Color.Transparent
        Me.lblReglName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReglName.Location = New System.Drawing.Point(6, 16)
        Me.lblReglName.Name = "lblReglName"
        Me.lblReglName.Size = New System.Drawing.Size(90, 20)
        Me.lblReglName.TabIndex = 0
        Me.lblReglName.Text = "Last Name:"
        '
        'PLDBDataSet
        '
        Me.PLDBDataSet.DataSetName = "PLDBDataSet"
        Me.PLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientDBBindingSource
        '
        Me.PatientDBBindingSource.DataMember = "patientDB"
        Me.PatientDBBindingSource.DataSource = Me.PLDBDataSet
        '
        'PatientDBTableAdapter
        '
        Me.PatientDBTableAdapter.ClearBeforeFill = True
        '
        'frmPatientReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(451, 292)
        Me.Controls.Add(Me.gbRegName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPatientReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Registration Form"
        Me.gbRegName.ResumeLayout(False)
        Me.gbRegName.PerformLayout()
        CType(Me.PLDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRegName As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegCancel As System.Windows.Forms.Button
    Friend WithEvents btnRegSave As System.Windows.Forms.Button
    Friend WithEvents cbRegMarital As System.Windows.Forms.ComboBox
    Friend WithEvents lblRegbDate As System.Windows.Forms.Label
    Friend WithEvents dtpRegBDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRegStatus As System.Windows.Forms.Label
    Friend WithEvents txtOccupation As System.Windows.Forms.TextBox
    Friend WithEvents lblRegOccu As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblRegContactNo As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblRegAddress As System.Windows.Forms.Label
    Friend WithEvents lblRegmName As System.Windows.Forms.Label
    Friend WithEvents lblRegfName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblReglName As System.Windows.Forms.Label
    Friend WithEvents PLDBDataSet As ProjeckMilk.PLDBDataSet
    Friend WithEvents PatientDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientDBTableAdapter As ProjeckMilk.PLDBDataSetTableAdapters.patientDBTableAdapter
    Friend WithEvents btnSaveRecord As System.Windows.Forms.Button
End Class
