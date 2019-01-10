<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmAddMember
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.idlbl = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.passwordlbl = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(177, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 47)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'idlbl
        '
        Me.idlbl.AutoSize = True
        Me.idlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.idlbl.Location = New System.Drawing.Point(113, 95)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(26, 20)
        Me.idlbl.TabIndex = 1
        Me.idlbl.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtId.Location = New System.Drawing.Point(182, 95)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(84, 26)
        Me.txtId.TabIndex = 2
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.namelbl.Location = New System.Drawing.Point(98, 131)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(51, 20)
        Me.namelbl.TabIndex = 3
        Me.namelbl.Text = "Name"
        '
        'passwordlbl
        '
        Me.passwordlbl.AutoSize = True
        Me.passwordlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.passwordlbl.Location = New System.Drawing.Point(71, 164)
        Me.passwordlbl.Name = "passwordlbl"
        Me.passwordlbl.Size = New System.Drawing.Size(78, 20)
        Me.passwordlbl.TabIndex = 4
        Me.passwordlbl.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(182, 164)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(112, 26)
        Me.txtPassword.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(182, 131)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 26)
        Me.txtName.TabIndex = 6
        '
        'fmAddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 431)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.passwordlbl)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "fmAddMember"
        Me.Text = "บันทึกประวัตืสมาชิก"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents idlbl As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents namelbl As System.Windows.Forms.Label
    Friend WithEvents passwordlbl As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox

End Class
