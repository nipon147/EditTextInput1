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
        Me.ListBoxInterrestRate = New System.Windows.Forms.ListBox()
        Me.ListBoxNumYear = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.labal1 = New System.Windows.Forms.Label()
        Me.labal2 = New System.Windows.Forms.Label()
        Me.labal3 = New System.Windows.Forms.Label()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.txtPayPerMonth = New System.Windows.Forms.TextBox()
        Me.txtIncomePerMonth = New System.Windows.Forms.TextBox()
        Me.labal4 = New System.Windows.Forms.Label()
        Me.labal5 = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.test = New System.Windows.Forms.Label()
        Me.test2 = New System.Windows.Forms.Label()
        Me.ChkStarEgg = New System.Windows.Forms.CheckBox()
        Me.ChkEgg2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxInterrestRate
        '
        Me.ListBoxInterrestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListBoxInterrestRate.FormattingEnabled = True
        Me.ListBoxInterrestRate.ItemHeight = 33
        Me.ListBoxInterrestRate.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ListBoxInterrestRate.Location = New System.Drawing.Point(91, 164)
        Me.ListBoxInterrestRate.Name = "ListBoxInterrestRate"
        Me.ListBoxInterrestRate.Size = New System.Drawing.Size(284, 70)
        Me.ListBoxInterrestRate.TabIndex = 1
        '
        'ListBoxNumYear
        '
        Me.ListBoxNumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListBoxNumYear.FormattingEnabled = True
        Me.ListBoxNumYear.ItemHeight = 33
        Me.ListBoxNumYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ListBoxNumYear.Location = New System.Drawing.Point(95, 291)
        Me.ListBoxNumYear.Name = "ListBoxNumYear"
        Me.ListBoxNumYear.Size = New System.Drawing.Size(284, 70)
        Me.ListBoxNumYear.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(104, 507)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 42)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(266, 507)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(144, 42)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "ล้างข้อความ"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'labal1
        '
        Me.labal1.AutoSize = True
        Me.labal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labal1.Location = New System.Drawing.Point(98, 9)
        Me.labal1.Name = "labal1"
        Me.labal1.Size = New System.Drawing.Size(149, 33)
        Me.labal1.TabIndex = 7
        Me.labal1.Text = "วงเงินกู้/บาท"
        '
        'labal2
        '
        Me.labal2.AutoSize = True
        Me.labal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labal2.Location = New System.Drawing.Point(89, 112)
        Me.labal2.Name = "labal2"
        Me.labal2.Size = New System.Drawing.Size(230, 33)
        Me.labal2.TabIndex = 8
        Me.labal2.Text = "อัตราดอกเบี้ย/ปี(%)"
        '
        'labal3
        '
        Me.labal3.AutoSize = True
        Me.labal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labal3.Location = New System.Drawing.Point(89, 246)
        Me.labal3.Name = "labal3"
        Me.labal3.Size = New System.Drawing.Size(159, 33)
        Me.labal3.TabIndex = 9
        Me.labal3.Text = "ระยะเวลากู้/ปี"
        '
        'txtLoan
        '
        Me.txtLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoan.Location = New System.Drawing.Point(91, 59)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(280, 40)
        Me.txtLoan.TabIndex = 10
        '
        'txtPayPerMonth
        '
        Me.txtPayPerMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPayPerMonth.Location = New System.Drawing.Point(99, 421)
        Me.txtPayPerMonth.Name = "txtPayPerMonth"
        Me.txtPayPerMonth.Size = New System.Drawing.Size(280, 40)
        Me.txtPayPerMonth.TabIndex = 11
        '
        'txtIncomePerMonth
        '
        Me.txtIncomePerMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIncomePerMonth.Location = New System.Drawing.Point(405, 421)
        Me.txtIncomePerMonth.Name = "txtIncomePerMonth"
        Me.txtIncomePerMonth.Size = New System.Drawing.Size(280, 40)
        Me.txtIncomePerMonth.TabIndex = 12
        '
        'labal4
        '
        Me.labal4.AutoSize = True
        Me.labal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labal4.Location = New System.Drawing.Point(98, 376)
        Me.labal4.Name = "labal4"
        Me.labal4.Size = New System.Drawing.Size(259, 33)
        Me.labal4.TabIndex = 13
        Me.labal4.Text = "ยอดชำระต่อเดือน/บาท"
        '
        'labal5
        '
        Me.labal5.AutoSize = True
        Me.labal5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labal5.Location = New System.Drawing.Point(395, 376)
        Me.labal5.Name = "labal5"
        Me.labal5.Size = New System.Drawing.Size(290, 33)
        Me.labal5.TabIndex = 14
        Me.labal5.Text = "รายได้ขั้นต่ำต่อเดือน/บาท"
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTest.Location = New System.Drawing.Point(686, 190)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(84, 34)
        Me.btnTest.TabIndex = 15
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'test
        '
        Me.test.AutoSize = True
        Me.test.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.test.Location = New System.Drawing.Point(826, 190)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(30, 20)
        Me.test.TabIndex = 16
        Me.test.Text = "xxx"
        '
        'test2
        '
        Me.test2.AutoSize = True
        Me.test2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.test2.Location = New System.Drawing.Point(826, 246)
        Me.test2.Name = "test2"
        Me.test2.Size = New System.Drawing.Size(30, 20)
        Me.test2.TabIndex = 17
        Me.test2.Text = "xxx"
        '
        'ChkStarEgg
        '
        Me.ChkStarEgg.AutoSize = True
        Me.ChkStarEgg.Checked = True
        Me.ChkStarEgg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStarEgg.Location = New System.Drawing.Point(627, 81)
        Me.ChkStarEgg.Name = "ChkStarEgg"
        Me.ChkStarEgg.Size = New System.Drawing.Size(56, 17)
        Me.ChkStarEgg.TabIndex = 18
        Me.ChkStarEgg.Text = "ไข่ดาว"
        Me.ChkStarEgg.UseVisualStyleBackColor = True
        '
        'ChkEgg2
        '
        Me.ChkEgg2.AutoSize = True
        Me.ChkEgg2.Location = New System.Drawing.Point(627, 127)
        Me.ChkEgg2.Name = "ChkEgg2"
        Me.ChkEgg2.Size = New System.Drawing.Size(62, 17)
        Me.ChkEgg2.TabIndex = 19
        Me.ChkEgg2.Text = "ไข่เจียว"
        Me.ChkEgg2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(606, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 55)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChkEgg2)
        Me.Controls.Add(Me.ChkStarEgg)
        Me.Controls.Add(Me.test2)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.labal5)
        Me.Controls.Add(Me.labal4)
        Me.Controls.Add(Me.txtIncomePerMonth)
        Me.Controls.Add(Me.txtPayPerMonth)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.labal3)
        Me.Controls.Add(Me.labal2)
        Me.Controls.Add(Me.labal1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.ListBoxNumYear)
        Me.Controls.Add(Me.ListBoxInterrestRate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxInterrestRate As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNumYear As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents labal1 As System.Windows.Forms.Label
    Friend WithEvents labal2 As System.Windows.Forms.Label
    Friend WithEvents labal3 As System.Windows.Forms.Label
    Friend WithEvents txtLoan As System.Windows.Forms.TextBox
    Friend WithEvents txtPayPerMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomePerMonth As System.Windows.Forms.TextBox
    Friend WithEvents labal4 As System.Windows.Forms.Label
    Friend WithEvents labal5 As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents test As System.Windows.Forms.Label
    Friend WithEvents test2 As System.Windows.Forms.Label
    Friend WithEvents ChkStarEgg As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEgg2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
