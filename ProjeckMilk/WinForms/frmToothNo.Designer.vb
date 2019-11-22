<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToothNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToothNo))
        Me.lblMove = New System.Windows.Forms.Label()
        Me.txtMove = New System.Windows.Forms.TextBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveC = New System.Windows.Forms.Button()
        Me.txtMoveS = New System.Windows.Forms.TextBox()
        Me.lblMoveS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMove
        '
        Me.lblMove.AutoSize = True
        Me.lblMove.BackColor = System.Drawing.Color.Transparent
        Me.lblMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMove.Location = New System.Drawing.Point(13, 13)
        Me.lblMove.Name = "lblMove"
        Me.lblMove.Size = New System.Drawing.Size(114, 20)
        Me.lblMove.TabIndex = 0
        Me.lblMove.Text = "Tooth Number:"
        '
        'txtMove
        '
        Me.txtMove.Location = New System.Drawing.Point(17, 37)
        Me.txtMove.MaxLength = 2
        Me.txtMove.Name = "txtMove"
        Me.txtMove.Size = New System.Drawing.Size(253, 20)
        Me.txtMove.TabIndex = 1
        Me.txtMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(114, 110)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 3
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnMoveC
        '
        Me.btnMoveC.Location = New System.Drawing.Point(195, 110)
        Me.btnMoveC.Name = "btnMoveC"
        Me.btnMoveC.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveC.TabIndex = 4
        Me.btnMoveC.Text = "Cancel"
        Me.btnMoveC.UseVisualStyleBackColor = True
        '
        'txtMoveS
        '
        Me.txtMoveS.Location = New System.Drawing.Point(17, 84)
        Me.txtMoveS.Name = "txtMoveS"
        Me.txtMoveS.Size = New System.Drawing.Size(253, 20)
        Me.txtMoveS.TabIndex = 2
        Me.txtMoveS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMoveS
        '
        Me.lblMoveS.AutoSize = True
        Me.lblMoveS.BackColor = System.Drawing.Color.Transparent
        Me.lblMoveS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveS.Location = New System.Drawing.Point(13, 60)
        Me.lblMoveS.Name = "lblMoveS"
        Me.lblMoveS.Size = New System.Drawing.Size(125, 20)
        Me.lblMoveS.TabIndex = 4
        Me.lblMoveS.Text = "Service Amount:"
        '
        'frmToothNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjeckMilk.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(282, 144)
        Me.Controls.Add(Me.txtMoveS)
        Me.Controls.Add(Me.lblMoveS)
        Me.Controls.Add(Me.btnMoveC)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.txtMove)
        Me.Controls.Add(Me.lblMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmToothNo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Tooth Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMove As System.Windows.Forms.Label
    Friend WithEvents txtMove As System.Windows.Forms.TextBox
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnMoveC As System.Windows.Forms.Button
    Friend WithEvents txtMoveS As System.Windows.Forms.TextBox
    Friend WithEvents lblMoveS As System.Windows.Forms.Label
End Class
