<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServices))
        Me.gbSevicesS = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cbxMedOnly = New System.Windows.Forms.CheckBox()
        Me.cbxServices2 = New System.Windows.Forms.CheckBox()
        Me.cbxServices1 = New System.Windows.Forms.CheckBox()
        Me.txtServicesTN = New System.Windows.Forms.TextBox()
        Me.lblServicesTN = New System.Windows.Forms.Label()
        Me.txtServicesDentist = New System.Windows.Forms.TextBox()
        Me.lblServicesDentist = New System.Windows.Forms.Label()
        Me.btnServicesCancel = New System.Windows.Forms.Button()
        Me.btnServicesAdd = New System.Windows.Forms.Button()
        Me.txtServicesAmount = New System.Windows.Forms.TextBox()
        Me.lblServicesamount = New System.Windows.Forms.Label()
        Me.txtServicesType = New System.Windows.Forms.TextBox()
        Me.lblServicestype = New System.Windows.Forms.Label()
        Me.gbServicesDent = New System.Windows.Forms.GroupBox()
        Me.rbDenture5 = New System.Windows.Forms.RadioButton()
        Me.rbDenture4 = New System.Windows.Forms.RadioButton()
        Me.cbFinal = New System.Windows.Forms.CheckBox()
        Me.cbTrial = New System.Windows.Forms.CheckBox()
        Me.cbDenture1 = New System.Windows.Forms.ComboBox()
        Me.rbDenture3 = New System.Windows.Forms.RadioButton()
        Me.rbDenture1 = New System.Windows.Forms.RadioButton()
        Me.rbDenture2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbSevicesS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbServicesDent.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSevicesS
        '
        Me.gbSevicesS.BackColor = System.Drawing.Color.Transparent
        Me.gbSevicesS.Controls.Add(Me.Label1)
        Me.gbSevicesS.Controls.Add(Me.GroupBox2)
        Me.gbSevicesS.Controls.Add(Me.CheckBox1)
        Me.gbSevicesS.Controls.Add(Me.GroupBox1)
        Me.gbSevicesS.Controls.Add(Me.cbxMedOnly)
        Me.gbSevicesS.Controls.Add(Me.cbxServices2)
        Me.gbSevicesS.Controls.Add(Me.cbxServices1)
        Me.gbSevicesS.Controls.Add(Me.txtServicesTN)
        Me.gbSevicesS.Controls.Add(Me.lblServicesTN)
        Me.gbSevicesS.Controls.Add(Me.txtServicesDentist)
        Me.gbSevicesS.Controls.Add(Me.lblServicesDentist)
        Me.gbSevicesS.Controls.Add(Me.btnServicesCancel)
        Me.gbSevicesS.Controls.Add(Me.btnServicesAdd)
        Me.gbSevicesS.Controls.Add(Me.txtServicesAmount)
        Me.gbSevicesS.Controls.Add(Me.lblServicesamount)
        Me.gbSevicesS.Controls.Add(Me.txtServicesType)
        Me.gbSevicesS.Controls.Add(Me.lblServicestype)
        Me.gbSevicesS.Controls.Add(Me.gbServicesDent)
        Me.gbSevicesS.Location = New System.Drawing.Point(13, 13)
        Me.gbSevicesS.Name = "gbSevicesS"
        Me.gbSevicesS.Size = New System.Drawing.Size(345, 468)
        Me.gbSevicesS.TabIndex = 0
        Me.gbSevicesS.TabStop = False
        Me.gbSevicesS.Text = "Services"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "(Separated by a semicolon ;)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(156, 70)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Oral Prophylaxis"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Items.AddRange(New Object() {"OP: Heavy", "OP: Moderate", "OP: Light"})
        Me.ComboBox2.Location = New System.Drawing.Point(9, 28)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(179, 67)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Jacket"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 108)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jacket"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"Plastic", "Porcelain"})
        Me.ComboBox1.Location = New System.Drawing.Point(10, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(10, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Fixed Bridge Jacket"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Jacket"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cbxMedOnly
        '
        Me.cbxMedOnly.AutoSize = True
        Me.cbxMedOnly.BackColor = System.Drawing.Color.Transparent
        Me.cbxMedOnly.Location = New System.Drawing.Point(237, 67)
        Me.cbxMedOnly.Name = "cbxMedOnly"
        Me.cbxMedOnly.Size = New System.Drawing.Size(102, 17)
        Me.cbxMedOnly.TabIndex = 5
        Me.cbxMedOnly.Text = "Medication Only"
        Me.cbxMedOnly.UseVisualStyleBackColor = False
        '
        'cbxServices2
        '
        Me.cbxServices2.AutoSize = True
        Me.cbxServices2.BackColor = System.Drawing.Color.Transparent
        Me.cbxServices2.Location = New System.Drawing.Point(10, 67)
        Me.cbxServices2.Name = "cbxServices2"
        Me.cbxServices2.Size = New System.Drawing.Size(101, 17)
        Me.cbxServices2.TabIndex = 3
        Me.cbxServices2.Text = "Oral Prophylaxis"
        Me.cbxServices2.UseVisualStyleBackColor = False
        '
        'cbxServices1
        '
        Me.cbxServices1.BackColor = System.Drawing.Color.Transparent
        Me.cbxServices1.Location = New System.Drawing.Point(114, 67)
        Me.cbxServices1.Name = "cbxServices1"
        Me.cbxServices1.Size = New System.Drawing.Size(64, 17)
        Me.cbxServices1.TabIndex = 2
        Me.cbxServices1.Text = "Denture"
        Me.cbxServices1.UseVisualStyleBackColor = False
        '
        'txtServicesTN
        '
        Me.txtServicesTN.Location = New System.Drawing.Point(9, 342)
        Me.txtServicesTN.MaxLength = 60
        Me.txtServicesTN.Name = "txtServicesTN"
        Me.txtServicesTN.Size = New System.Drawing.Size(330, 20)
        Me.txtServicesTN.TabIndex = 19
        Me.txtServicesTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServicesTN
        '
        Me.lblServicesTN.AutoSize = True
        Me.lblServicesTN.BackColor = System.Drawing.Color.Transparent
        Me.lblServicesTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicesTN.Location = New System.Drawing.Point(7, 321)
        Me.lblServicesTN.Name = "lblServicesTN"
        Me.lblServicesTN.Size = New System.Drawing.Size(108, 18)
        Me.lblServicesTN.TabIndex = 9
        Me.lblServicesTN.Text = "Tooth Number:"
        '
        'txtServicesDentist
        '
        Me.txtServicesDentist.Location = New System.Drawing.Point(9, 387)
        Me.txtServicesDentist.MaxLength = 50
        Me.txtServicesDentist.Name = "txtServicesDentist"
        Me.txtServicesDentist.Size = New System.Drawing.Size(330, 20)
        Me.txtServicesDentist.TabIndex = 20
        Me.txtServicesDentist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServicesDentist
        '
        Me.lblServicesDentist.AutoSize = True
        Me.lblServicesDentist.BackColor = System.Drawing.Color.Transparent
        Me.lblServicesDentist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicesDentist.Location = New System.Drawing.Point(7, 365)
        Me.lblServicesDentist.Name = "lblServicesDentist"
        Me.lblServicesDentist.Size = New System.Drawing.Size(58, 18)
        Me.lblServicesDentist.TabIndex = 7
        Me.lblServicesDentist.Text = "Dentist:"
        '
        'btnServicesCancel
        '
        Me.btnServicesCancel.Location = New System.Drawing.Point(228, 413)
        Me.btnServicesCancel.Name = "btnServicesCancel"
        Me.btnServicesCancel.Size = New System.Drawing.Size(111, 47)
        Me.btnServicesCancel.TabIndex = 22
        Me.btnServicesCancel.Text = "Cancel"
        Me.btnServicesCancel.UseVisualStyleBackColor = True
        '
        'btnServicesAdd
        '
        Me.btnServicesAdd.Location = New System.Drawing.Point(10, 413)
        Me.btnServicesAdd.Name = "btnServicesAdd"
        Me.btnServicesAdd.Size = New System.Drawing.Size(113, 47)
        Me.btnServicesAdd.TabIndex = 21
        Me.btnServicesAdd.Text = "Add To Patient Queue"
        Me.btnServicesAdd.UseVisualStyleBackColor = True
        '
        'txtServicesAmount
        '
        Me.txtServicesAmount.Location = New System.Drawing.Point(8, 298)
        Me.txtServicesAmount.Name = "txtServicesAmount"
        Me.txtServicesAmount.Size = New System.Drawing.Size(330, 20)
        Me.txtServicesAmount.TabIndex = 18
        Me.txtServicesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServicesamount
        '
        Me.lblServicesamount.AutoSize = True
        Me.lblServicesamount.BackColor = System.Drawing.Color.Transparent
        Me.lblServicesamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicesamount.Location = New System.Drawing.Point(7, 277)
        Me.lblServicesamount.Name = "lblServicesamount"
        Me.lblServicesamount.Size = New System.Drawing.Size(100, 18)
        Me.lblServicesamount.TabIndex = 2
        Me.lblServicesamount.Text = "Total Amount:"
        '
        'txtServicesType
        '
        Me.txtServicesType.Location = New System.Drawing.Point(10, 41)
        Me.txtServicesType.MaxLength = 100
        Me.txtServicesType.Name = "txtServicesType"
        Me.txtServicesType.Size = New System.Drawing.Size(329, 20)
        Me.txtServicesType.TabIndex = 1
        Me.txtServicesType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServicestype
        '
        Me.lblServicestype.AutoSize = True
        Me.lblServicestype.BackColor = System.Drawing.Color.Transparent
        Me.lblServicestype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicestype.Location = New System.Drawing.Point(7, 20)
        Me.lblServicestype.Name = "lblServicestype"
        Me.lblServicestype.Size = New System.Drawing.Size(97, 18)
        Me.lblServicestype.TabIndex = 0
        Me.lblServicestype.Text = "Service Type:"
        '
        'gbServicesDent
        '
        Me.gbServicesDent.BackColor = System.Drawing.Color.Transparent
        Me.gbServicesDent.Controls.Add(Me.rbDenture5)
        Me.gbServicesDent.Controls.Add(Me.rbDenture4)
        Me.gbServicesDent.Controls.Add(Me.cbFinal)
        Me.gbServicesDent.Controls.Add(Me.cbTrial)
        Me.gbServicesDent.Controls.Add(Me.cbDenture1)
        Me.gbServicesDent.Controls.Add(Me.rbDenture3)
        Me.gbServicesDent.Controls.Add(Me.rbDenture1)
        Me.gbServicesDent.Controls.Add(Me.rbDenture2)
        Me.gbServicesDent.Location = New System.Drawing.Point(6, 90)
        Me.gbServicesDent.Name = "gbServicesDent"
        Me.gbServicesDent.Size = New System.Drawing.Size(170, 184)
        Me.gbServicesDent.TabIndex = 19
        Me.gbServicesDent.TabStop = False
        Me.gbServicesDent.Text = "Denture"
        '
        'rbDenture5
        '
        Me.rbDenture5.AutoSize = True
        Me.rbDenture5.BackColor = System.Drawing.Color.Transparent
        Me.rbDenture5.Location = New System.Drawing.Point(17, 114)
        Me.rbDenture5.Name = "rbDenture5"
        Me.rbDenture5.Size = New System.Drawing.Size(142, 17)
        Me.rbDenture5.TabIndex = 10
        Me.rbDenture5.TabStop = True
        Me.rbDenture5.Text = "Lower Complete Denture"
        Me.rbDenture5.UseVisualStyleBackColor = False
        '
        'rbDenture4
        '
        Me.rbDenture4.AutoSize = True
        Me.rbDenture4.BackColor = System.Drawing.Color.Transparent
        Me.rbDenture4.Location = New System.Drawing.Point(17, 91)
        Me.rbDenture4.Name = "rbDenture4"
        Me.rbDenture4.Size = New System.Drawing.Size(142, 17)
        Me.rbDenture4.TabIndex = 9
        Me.rbDenture4.TabStop = True
        Me.rbDenture4.Text = "Upper Complete Denture"
        Me.rbDenture4.UseVisualStyleBackColor = False
        '
        'cbFinal
        '
        Me.cbFinal.AutoSize = True
        Me.cbFinal.BackColor = System.Drawing.Color.Transparent
        Me.cbFinal.Location = New System.Drawing.Point(87, 160)
        Me.cbFinal.Name = "cbFinal"
        Me.cbFinal.Size = New System.Drawing.Size(79, 17)
        Me.cbFinal.TabIndex = 13
        Me.cbFinal.Text = "Final Fitting"
        Me.cbFinal.UseVisualStyleBackColor = False
        '
        'cbTrial
        '
        Me.cbTrial.AutoSize = True
        Me.cbTrial.BackColor = System.Drawing.Color.Transparent
        Me.cbTrial.Location = New System.Drawing.Point(9, 160)
        Me.cbTrial.Name = "cbTrial"
        Me.cbTrial.Size = New System.Drawing.Size(77, 17)
        Me.cbTrial.TabIndex = 12
        Me.cbTrial.Text = "Trial Fitting"
        Me.cbTrial.UseVisualStyleBackColor = False
        '
        'cbDenture1
        '
        Me.cbDenture1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDenture1.Items.AddRange(New Object() {"Plastic", "Porcelain"})
        Me.cbDenture1.Location = New System.Drawing.Point(17, 17)
        Me.cbDenture1.Name = "cbDenture1"
        Me.cbDenture1.Size = New System.Drawing.Size(142, 21)
        Me.cbDenture1.TabIndex = 6
        '
        'rbDenture3
        '
        Me.rbDenture3.AutoSize = True
        Me.rbDenture3.BackColor = System.Drawing.Color.Transparent
        Me.rbDenture3.Location = New System.Drawing.Point(17, 137)
        Me.rbDenture3.Name = "rbDenture3"
        Me.rbDenture3.Size = New System.Drawing.Size(110, 17)
        Me.rbDenture3.TabIndex = 11
        Me.rbDenture3.TabStop = True
        Me.rbDenture3.Text = "Complete Denture"
        Me.rbDenture3.UseVisualStyleBackColor = False
        '
        'rbDenture1
        '
        Me.rbDenture1.AutoSize = True
        Me.rbDenture1.BackColor = System.Drawing.Color.Transparent
        Me.rbDenture1.Location = New System.Drawing.Point(17, 44)
        Me.rbDenture1.Name = "rbDenture1"
        Me.rbDenture1.Size = New System.Drawing.Size(127, 17)
        Me.rbDenture1.TabIndex = 7
        Me.rbDenture1.TabStop = True
        Me.rbDenture1.Text = "Upper Partial Denture"
        Me.rbDenture1.UseVisualStyleBackColor = False
        '
        'rbDenture2
        '
        Me.rbDenture2.AutoSize = True
        Me.rbDenture2.BackColor = System.Drawing.Color.Transparent
        Me.rbDenture2.Location = New System.Drawing.Point(17, 68)
        Me.rbDenture2.Name = "rbDenture2"
        Me.rbDenture2.Size = New System.Drawing.Size(127, 17)
        Me.rbDenture2.TabIndex = 8
        Me.rbDenture2.TabStop = True
        Me.rbDenture2.Text = "Lower Partial Denture"
        Me.rbDenture2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 20)
        Me.TextBox1.TabIndex = 1
        '
        'frmServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(370, 495)
        Me.Controls.Add(Me.gbSevicesS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dental Service"
        Me.gbSevicesS.ResumeLayout(False)
        Me.gbSevicesS.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbServicesDent.ResumeLayout(False)
        Me.gbServicesDent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSevicesS As System.Windows.Forms.GroupBox
    Friend WithEvents lblServicesamount As System.Windows.Forms.Label
    Friend WithEvents txtServicesType As System.Windows.Forms.TextBox
    Friend WithEvents lblServicestype As System.Windows.Forms.Label
    Friend WithEvents btnServicesCancel As System.Windows.Forms.Button
    Friend WithEvents btnServicesAdd As System.Windows.Forms.Button
    Friend WithEvents txtServicesAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtServicesDentist As System.Windows.Forms.TextBox
    Friend WithEvents lblServicesDentist As System.Windows.Forms.Label
    Friend WithEvents txtServicesTN As System.Windows.Forms.TextBox
    Friend WithEvents lblServicesTN As System.Windows.Forms.Label
    Friend WithEvents cbxServices2 As System.Windows.Forms.CheckBox
    Friend WithEvents rbDenture2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenture1 As System.Windows.Forms.RadioButton
    Friend WithEvents cbxServices1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbDenture1 As System.Windows.Forms.ComboBox
    Friend WithEvents rbDenture3 As System.Windows.Forms.RadioButton
    Friend WithEvents gbServicesDent As System.Windows.Forms.GroupBox
    Friend WithEvents cbFinal As System.Windows.Forms.CheckBox
    Friend WithEvents cbTrial As System.Windows.Forms.CheckBox
    Friend WithEvents cbxMedOnly As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents rbDenture5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenture4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
