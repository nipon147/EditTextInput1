<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timeBomb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(timeBomb))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.labelMsg = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.labelContDown = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(36, 449)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(276, 33)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(429, 253)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(131, 58)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check!!!"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(429, 337)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(131, 58)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Start /Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'labelMsg
        '
        Me.labelMsg.AutoSize = True
        Me.labelMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelMsg.Location = New System.Drawing.Point(466, 72)
        Me.labelMsg.Name = "labelMsg"
        Me.labelMsg.Size = New System.Drawing.Size(45, 25)
        Me.labelMsg.TabIndex = 3
        Me.labelMsg.Text = "- - -"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Games.My.Resources.Resources.bomb2
        Me.PictureBox1.Location = New System.Drawing.Point(36, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 372)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Games.My.Resources.Resources.bomb1
        Me.PictureBox2.Location = New System.Drawing.Point(78, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 173)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'labelContDown
        '
        Me.labelContDown.AutoSize = True
        Me.labelContDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelContDown.Location = New System.Drawing.Point(140, 9)
        Me.labelContDown.Name = "labelContDown"
        Me.labelContDown.Size = New System.Drawing.Size(45, 25)
        Me.labelContDown.TabIndex = 6
        Me.labelContDown.Text = "- - -"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 350)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 350)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(215, 350)
        Me.TextBox3.MaxLength = 1
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timeBomb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 512)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.labelContDown)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelMsg)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "timeBomb"
        Me.Text = "timeBomb"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Public WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents labelMsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents labelContDown As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
