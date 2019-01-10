<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class findEmp
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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rdoName = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Location = New System.Drawing.Point(358, 59)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 30)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Checked = True
        Me.rdoAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdoAll.Location = New System.Drawing.Point(62, 32)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(72, 24)
        Me.rdoAll.TabIndex = 1
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "ทั้งหมด"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoName
        '
        Me.rdoName.AutoSize = True
        Me.rdoName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdoName.Location = New System.Drawing.Point(62, 65)
        Me.rdoName.Name = "rdoName"
        Me.rdoName.Size = New System.Drawing.Size(95, 24)
        Me.rdoName.TabIndex = 2
        Me.rdoName.TabStop = True
        Me.rdoName.Text = "ชื่อพนักงาน"
        Me.rdoName.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(186, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(140, 20)
        Me.txtName.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(73, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(426, 186)
        Me.DataGridView1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.rdoName)
        Me.GroupBox1.Controls.Add(Me.rdoAll)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กำหนดข้อมูล"
        '
        'findEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "findEmp"
        Me.Text = "ค้นหาข้อมูลพนักงาน"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoName As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
