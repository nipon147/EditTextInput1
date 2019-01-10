<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMembers
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblName.Location = New System.Drawing.Point(173, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(286, 229)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(121, 58)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtname.Location = New System.Drawing.Point(259, 84)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(169, 26)
        Me.txtname.TabIndex = 2
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkAdmin.Location = New System.Drawing.Point(259, 137)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(113, 24)
        Me.chkAdmin.TabIndex = 3
        Me.chkAdmin.Text = "สถานะแอดมิน"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'addMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 478)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lblName)
        Me.Name = "addMembers"
        Me.Text = "addMembers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
End Class
