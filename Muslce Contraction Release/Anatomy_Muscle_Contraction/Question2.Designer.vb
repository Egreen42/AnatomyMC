<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question2
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
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.Group_BOX = New System.Windows.Forms.GroupBox()
        Me.TTMN_RB = New System.Windows.Forms.RadioButton()
        Me.TTM_RB = New System.Windows.Forms.RadioButton()
        Me.IDK_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.TTM_Label = New System.Windows.Forms.Label()
        Me.TTMN_Label = New System.Windows.Forms.Label()
        Me.IDK_PB = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Group_BOX.SuspendLayout()
        CType(Me.IDK_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.BackColor = System.Drawing.Color.Transparent
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(12, 23)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(459, 74)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "Where does the action potential go and what does it do?"
        '
        'Group_BOX
        '
        Me.Group_BOX.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Group_BOX.Controls.Add(Me.TTMN_RB)
        Me.Group_BOX.Controls.Add(Me.TTM_RB)
        Me.Group_BOX.Controls.Add(Me.IDK_RB)
        Me.Group_BOX.Location = New System.Drawing.Point(600, 49)
        Me.Group_BOX.Name = "Group_BOX"
        Me.Group_BOX.Size = New System.Drawing.Size(162, 108)
        Me.Group_BOX.TabIndex = 1
        Me.Group_BOX.TabStop = False
        '
        'TTMN_RB
        '
        Me.TTMN_RB.AutoSize = True
        Me.TTMN_RB.Location = New System.Drawing.Point(7, 68)
        Me.TTMN_RB.Name = "TTMN_RB"
        Me.TTMN_RB.Size = New System.Drawing.Size(151, 17)
        Me.TTMN_RB.TabIndex = 2
        Me.TTMN_RB.TabStop = True
        Me.TTMN_RB.Text = "Through the Motor Neuron"
        Me.TTMN_RB.UseVisualStyleBackColor = True
        '
        'TTM_RB
        '
        Me.TTM_RB.AutoSize = True
        Me.TTM_RB.Location = New System.Drawing.Point(7, 44)
        Me.TTM_RB.Name = "TTM_RB"
        Me.TTM_RB.Size = New System.Drawing.Size(93, 17)
        Me.TTM_RB.TabIndex = 1
        Me.TTM_RB.TabStop = True
        Me.TTM_RB.Text = "To the Muscle"
        Me.TTM_RB.UseVisualStyleBackColor = True
        '
        'IDK_RB
        '
        Me.IDK_RB.AutoSize = True
        Me.IDK_RB.Location = New System.Drawing.Point(7, 20)
        Me.IDK_RB.Name = "IDK_RB"
        Me.IDK_RB.Size = New System.Drawing.Size(43, 17)
        Me.IDK_RB.TabIndex = 0
        Me.IDK_RB.TabStop = True
        Me.IDK_RB.Text = "IDK"
        Me.IDK_RB.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(600, 164)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'TTM_Label
        '
        Me.TTM_Label.BackColor = System.Drawing.SystemColors.Control
        Me.TTM_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTM_Label.Location = New System.Drawing.Point(39, 117)
        Me.TTM_Label.Name = "TTM_Label"
        Me.TTM_Label.Size = New System.Drawing.Size(465, 79)
        Me.TTM_Label.TabIndex = 3
        Me.TTM_Label.Text = "No, there are many many steps before we truly get into the depths of the muscle w" &
    "e must first start at the nerves."
        Me.TTM_Label.Visible = False
        '
        'TTMN_Label
        '
        Me.TTMN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTMN_Label.Location = New System.Drawing.Point(44, 200)
        Me.TTMN_Label.Name = "TTMN_Label"
        Me.TTMN_Label.Size = New System.Drawing.Size(460, 108)
        Me.TTMN_Label.TabIndex = 4
        Me.TTMN_Label.Text = "Yes, the action potential is going to go through the motor neuron of the nerve ce" &
    "ll that works with the muscle cell. The motor neuron branches off and ends at a " &
    "synaptic terminal."
        Me.TTMN_Label.Visible = False
        '
        'IDK_PB
        '
        Me.IDK_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IDK_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.You_Fool
        Me.IDK_PB.Location = New System.Drawing.Point(523, 200)
        Me.IDK_PB.Name = "IDK_PB"
        Me.IDK_PB.Size = New System.Drawing.Size(265, 238)
        Me.IDK_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IDK_PB.TabIndex = 5
        Me.IDK_PB.TabStop = False
        Me.IDK_PB.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Question2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Runningstart
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IDK_PB)
        Me.Controls.Add(Me.TTMN_Label)
        Me.Controls.Add(Me.TTM_Label)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Group_BOX)
        Me.Controls.Add(Me.Body_Label)
        Me.DoubleBuffered = True
        Me.Name = "Question2"
        Me.Text = "Question2"
        Me.Group_BOX.ResumeLayout(False)
        Me.Group_BOX.PerformLayout()
        CType(Me.IDK_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents Group_BOX As GroupBox
    Friend WithEvents TTMN_RB As RadioButton
    Friend WithEvents TTM_RB As RadioButton
    Friend WithEvents IDK_RB As RadioButton
    Friend WithEvents Submit_Button As Button
    Friend WithEvents TTM_Label As Label
    Friend WithEvents TTMN_Label As Label
    Friend WithEvents IDK_PB As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
