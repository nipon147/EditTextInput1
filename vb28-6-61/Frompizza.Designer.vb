<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frompizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frompizza))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCreditNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBoxPizza = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoLarge = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBecon = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.chkBerry = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelSize = New System.Windows.Forms.Label()
        Me.labelPrice = New System.Windows.Forms.Label()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.rdoCreditCard = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.LabelToppingPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "หมายเลขบัตร"
        '
        'txtCreditNumber
        '
        Me.txtCreditNumber.Enabled = False
        Me.txtCreditNumber.Location = New System.Drawing.Point(359, 447)
        Me.txtCreditNumber.Name = "txtCreditNumber"
        Me.txtCreditNumber.Size = New System.Drawing.Size(173, 20)
        Me.txtCreditNumber.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.AutoSize = True
        Me.txtAddress.Location = New System.Drawing.Point(76, 529)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(27, 13)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Text = "ที่อยุ่"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 522)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(304, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBoxPizza)
        Me.Panel1.Location = New System.Drawing.Point(74, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 244)
        Me.Panel1.TabIndex = 4
        '
        'PictureBoxPizza
        '
        Me.PictureBoxPizza.Image = CType(resources.GetObject("PictureBoxPizza.Image"), System.Drawing.Image)
        Me.PictureBoxPizza.Location = New System.Drawing.Point(259, 26)
        Me.PictureBoxPizza.Name = "PictureBoxPizza"
        Me.PictureBoxPizza.Size = New System.Drawing.Size(197, 186)
        Me.PictureBoxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPizza.TabIndex = 0
        Me.PictureBoxPizza.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoLarge)
        Me.GroupBox1.Controls.Add(Me.rdoMedium)
        Me.GroupBox1.Controls.Add(Me.rdoSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกขนาด"
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Checked = True
        Me.rdoSmall.Location = New System.Drawing.Point(39, 42)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(77, 17)
        Me.rdoSmall.TabIndex = 0
        Me.rdoSmall.TabStop = True
        Me.rdoSmall.Text = "Small 150.-"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Location = New System.Drawing.Point(39, 70)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(89, 17)
        Me.rdoMedium.TabIndex = 1
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium 250.-"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoLarge
        '
        Me.rdoLarge.AutoSize = True
        Me.rdoLarge.Location = New System.Drawing.Point(39, 100)
        Me.rdoLarge.Name = "rdoLarge"
        Me.rdoLarge.Size = New System.Drawing.Size(79, 17)
        Me.rdoLarge.TabIndex = 2
        Me.rdoLarge.Text = "Large 400.-"
        Me.rdoLarge.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBerry)
        Me.GroupBox2.Controls.Add(Me.chkTuna)
        Me.GroupBox2.Controls.Add(Me.chkCheese)
        Me.GroupBox2.Controls.Add(Me.chkBecon)
        Me.GroupBox2.Location = New System.Drawing.Point(500, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 186)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เลือก Topping 5.-"
        '
        'chkBecon
        '
        Me.chkBecon.AutoSize = True
        Me.chkBecon.Location = New System.Drawing.Point(31, 42)
        Me.chkBecon.Name = "chkBecon"
        Me.chkBecon.Size = New System.Drawing.Size(57, 17)
        Me.chkBecon.TabIndex = 0
        Me.chkBecon.Text = "Becon"
        Me.chkBecon.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(31, 71)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.Location = New System.Drawing.Point(31, 101)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(51, 17)
        Me.chkTuna.TabIndex = 2
        Me.chkTuna.Text = "Tuna"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'chkBerry
        '
        Me.chkBerry.AutoSize = True
        Me.chkBerry.Location = New System.Drawing.Point(31, 135)
        Me.chkBerry.Name = "chkBerry"
        Me.chkBerry.Size = New System.Drawing.Size(50, 17)
        Me.chkBerry.TabIndex = 3
        Me.chkBerry.Text = "Berry"
        Me.chkBerry.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.LabelToppingPrice)
        Me.Panel2.Controls.Add(Me.labelTotal)
        Me.Panel2.Controls.Add(Me.labelPrice)
        Me.Panel2.Controls.Add(Me.labelSize)
        Me.Panel2.Location = New System.Drawing.Point(74, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(786, 112)
        Me.Panel2.TabIndex = 5
        '
        'labelSize
        '
        Me.labelSize.AutoSize = True
        Me.labelSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelSize.Location = New System.Drawing.Point(48, 49)
        Me.labelSize.Name = "labelSize"
        Me.labelSize.Size = New System.Drawing.Size(58, 25)
        Me.labelSize.TabIndex = 0
        Me.labelSize.Text = "ขนาด"
        '
        'labelPrice
        '
        Me.labelPrice.AutoSize = True
        Me.labelPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelPrice.Location = New System.Drawing.Point(221, 49)
        Me.labelPrice.Name = "labelPrice"
        Me.labelPrice.Size = New System.Drawing.Size(52, 25)
        Me.labelPrice.TabIndex = 1
        Me.labelPrice.Text = "ราคา"
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelTotal.Location = New System.Drawing.Point(602, 49)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(44, 25)
        Me.labelTotal.TabIndex = 2
        Me.labelTotal.Text = "รวม"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoCreditCard)
        Me.GroupBox3.Controls.Add(Me.rdoCash)
        Me.GroupBox3.Location = New System.Drawing.Point(74, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 71)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ชำระเงิน"
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Checked = True
        Me.rdoCash.Location = New System.Drawing.Point(20, 20)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(56, 17)
        Me.rdoCash.TabIndex = 0
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "เงินสด"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'rdoCreditCard
        '
        Me.rdoCreditCard.AutoSize = True
        Me.rdoCreditCard.Location = New System.Drawing.Point(20, 43)
        Me.rdoCreditCard.Name = "rdoCreditCard"
        Me.rdoCreditCard.Size = New System.Drawing.Size(77, 17)
        Me.rdoCreditCard.TabIndex = 1
        Me.rdoCreditCard.Text = "บัตรเครดิต"
        Me.rdoCreditCard.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(691, 495)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 91)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LabelToppingPrice
        '
        Me.LabelToppingPrice.AutoSize = True
        Me.LabelToppingPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelToppingPrice.Location = New System.Drawing.Point(365, 49)
        Me.LabelToppingPrice.Name = "LabelToppingPrice"
        Me.LabelToppingPrice.Size = New System.Drawing.Size(136, 25)
        Me.LabelToppingPrice.TabIndex = 3
        Me.LabelToppingPrice.Text = "ราคา Topping"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ราคา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ราคา Topping"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(604, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "รวม"
        '
        'Frompizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 613)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCreditNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frompizza"
        Me.Text = "Frompizza"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCreditNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBerry As System.Windows.Forms.CheckBox
    Friend WithEvents chkTuna As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkBecon As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSmall As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBoxPizza As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents labelPrice As System.Windows.Forms.Label
    Friend WithEvents labelSize As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCash As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents LabelToppingPrice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
