<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question4))
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CTMN_RB = New System.Windows.Forms.RadioButton()
        Me.Nothing_RB = New System.Windows.Forms.RadioButton()
        Me.MCIOC_RB = New System.Windows.Forms.RadioButton()
        Me.MCIOC_Label = New System.Windows.Forms.Label()
        Me.MCIOC_PB = New System.Windows.Forms.PictureBox()
        Me.Nothing_Label = New System.Windows.Forms.Label()
        Me.CTMN_Label = New System.Windows.Forms.Label()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.MCIOC_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.AutoSize = True
        Me.Body_Label.BackColor = System.Drawing.Color.Transparent
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(56, 29)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(240, 25)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "What does the ACh do?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CTMN_RB)
        Me.GroupBox1.Controls.Add(Me.Nothing_RB)
        Me.GroupBox1.Controls.Add(Me.MCIOC_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(588, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CTMN_RB
        '
        Me.CTMN_RB.AutoSize = True
        Me.CTMN_RB.Location = New System.Drawing.Point(22, 68)
        Me.CTMN_RB.Name = "CTMN_RB"
        Me.CTMN_RB.Size = New System.Drawing.Size(150, 17)
        Me.CTMN_RB.TabIndex = 2
        Me.CTMN_RB.TabStop = True
        Me.CTMN_RB.Text = "Changes the motor neuron"
        Me.CTMN_RB.UseVisualStyleBackColor = True
        '
        'Nothing_RB
        '
        Me.Nothing_RB.AutoSize = True
        Me.Nothing_RB.Location = New System.Drawing.Point(22, 44)
        Me.Nothing_RB.Name = "Nothing_RB"
        Me.Nothing_RB.Size = New System.Drawing.Size(62, 17)
        Me.Nothing_RB.TabIndex = 1
        Me.Nothing_RB.TabStop = True
        Me.Nothing_RB.Text = "Nothing"
        Me.Nothing_RB.UseVisualStyleBackColor = True
        '
        'MCIOC_RB
        '
        Me.MCIOC_RB.AutoSize = True
        Me.MCIOC_RB.Location = New System.Drawing.Point(22, 20)
        Me.MCIOC_RB.Name = "MCIOC_RB"
        Me.MCIOC_RB.Size = New System.Drawing.Size(167, 17)
        Me.MCIOC_RB.TabIndex = 0
        Me.MCIOC_RB.TabStop = True
        Me.MCIOC_RB.Text = "Makes Changes in Other Cells"
        Me.MCIOC_RB.UseVisualStyleBackColor = True
        '
        'MCIOC_Label
        '
        Me.MCIOC_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCIOC_Label.Location = New System.Drawing.Point(28, 79)
        Me.MCIOC_Label.Name = "MCIOC_Label"
        Me.MCIOC_Label.Size = New System.Drawing.Size(390, 87)
        Me.MCIOC_Label.TabIndex = 2
        Me.MCIOC_Label.Text = resources.GetString("MCIOC_Label.Text")
        Me.MCIOC_Label.Visible = False
        '
        'MCIOC_PB
        '
        Me.MCIOC_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.ACh
        Me.MCIOC_PB.Location = New System.Drawing.Point(23, 169)
        Me.MCIOC_PB.Name = "MCIOC_PB"
        Me.MCIOC_PB.Size = New System.Drawing.Size(395, 158)
        Me.MCIOC_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MCIOC_PB.TabIndex = 3
        Me.MCIOC_PB.TabStop = False
        Me.MCIOC_PB.Visible = False
        '
        'Nothing_Label
        '
        Me.Nothing_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nothing_Label.Location = New System.Drawing.Point(452, 196)
        Me.Nothing_Label.Name = "Nothing_Label"
        Me.Nothing_Label.Size = New System.Drawing.Size(261, 23)
        Me.Nothing_Label.TabIndex = 4
        Me.Nothing_Label.Text = "No, It doesn't hurt you to atleast try."
        Me.Nothing_Label.Visible = False
        '
        'CTMN_Label
        '
        Me.CTMN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTMN_Label.Location = New System.Drawing.Point(452, 244)
        Me.CTMN_Label.Name = "CTMN_Label"
        Me.CTMN_Label.Size = New System.Drawing.Size(287, 164)
        Me.CTMN_Label.TabIndex = 5
        Me.CTMN_Label.Text = resources.GetString("CTMN_Label.Text")
        Me.CTMN_Label.Visible = False
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(588, 162)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 6
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Question4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Jumping
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.CTMN_Label)
        Me.Controls.Add(Me.Nothing_Label)
        Me.Controls.Add(Me.MCIOC_PB)
        Me.Controls.Add(Me.MCIOC_Label)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Body_Label)
        Me.Name = "Question4"
        Me.Text = "Question4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MCIOC_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CTMN_RB As RadioButton
    Friend WithEvents Nothing_RB As RadioButton
    Friend WithEvents MCIOC_RB As RadioButton
    Friend WithEvents MCIOC_Label As Label
    Friend WithEvents MCIOC_PB As PictureBox
    Friend WithEvents Nothing_Label As Label
    Friend WithEvents CTMN_Label As Label
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
