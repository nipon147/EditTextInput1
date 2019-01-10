<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.midLbl = New System.Windows.Forms.Label()
        Me.mbnLbl = New System.Windows.Forms.Label()
        Me.passwordLBl = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'midLbl
        '
        Me.midLbl.AutoSize = True
        Me.midLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.midLbl.Location = New System.Drawing.Point(69, 48)
        Me.midLbl.Name = "midLbl"
        Me.midLbl.Size = New System.Drawing.Size(98, 24)
        Me.midLbl.TabIndex = 0
        Me.midLbl.Text = "memberID"
        '
        'mbnLbl
        '
        Me.mbnLbl.AutoSize = True
        Me.mbnLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.mbnLbl.Location = New System.Drawing.Point(69, 145)
        Me.mbnLbl.Name = "mbnLbl"
        Me.mbnLbl.Size = New System.Drawing.Size(132, 24)
        Me.mbnLbl.TabIndex = 1
        Me.mbnLbl.Text = "memberName"
        '
        'passwordLBl
        '
        Me.passwordLBl.AutoSize = True
        Me.passwordLBl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.passwordLBl.Location = New System.Drawing.Point(69, 191)
        Me.passwordLBl.Name = "passwordLBl"
        Me.passwordLBl.Size = New System.Drawing.Size(92, 24)
        Me.passwordLBl.TabIndex = 2
        Me.passwordLBl.Text = "Password"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(207, 48)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(146, 20)
        Me.txt1.TabIndex = 3
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(207, 191)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(146, 20)
        Me.txt3.TabIndex = 4
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(207, 145)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(146, 20)
        Me.txt2.TabIndex = 5
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Location = New System.Drawing.Point(373, 38)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(90, 44)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(252, 231)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(373, 231)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 411)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.passwordLBl)
        Me.Controls.Add(Me.mbnLbl)
        Me.Controls.Add(Me.midLbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents midLbl As System.Windows.Forms.Label
    Friend WithEvents mbnLbl As System.Windows.Forms.Label
    Friend WithEvents passwordLBl As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
