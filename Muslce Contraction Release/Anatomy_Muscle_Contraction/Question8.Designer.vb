<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question8))
        Me.BodyLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RTT_RB = New System.Windows.Forms.RadioButton()
        Me.HUH_RB = New System.Windows.Forms.RadioButton()
        Me.APAC_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_button = New System.Windows.Forms.Button()
        Me.Huh_PB = New System.Windows.Forms.PictureBox()
        Me.APAC_Label = New System.Windows.Forms.Label()
        Me.RTT_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Huh_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BodyLabel
        '
        Me.BodyLabel.BackColor = System.Drawing.SystemColors.Control
        Me.BodyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyLabel.Location = New System.Drawing.Point(3, 9)
        Me.BodyLabel.Name = "BodyLabel"
        Me.BodyLabel.Size = New System.Drawing.Size(383, 106)
        Me.BodyLabel.TabIndex = 0
        Me.BodyLabel.Text = "The calcium is a big step but where does it come from and what does it do?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RTT_RB)
        Me.GroupBox1.Controls.Add(Me.HUH_RB)
        Me.GroupBox1.Controls.Add(Me.APAC_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(477, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RTT_RB
        '
        Me.RTT_RB.AutoSize = True
        Me.RTT_RB.Location = New System.Drawing.Point(7, 68)
        Me.RTT_RB.Name = "RTT_RB"
        Me.RTT_RB.Size = New System.Drawing.Size(303, 17)
        Me.RTT_RB.TabIndex = 2
        Me.RTT_RB.TabStop = True
        Me.RTT_RB.Text = "A reaction in the T Tubules and the falling of the active site"
        Me.RTT_RB.UseVisualStyleBackColor = True
        '
        'HUH_RB
        '
        Me.HUH_RB.AutoSize = True
        Me.HUH_RB.Location = New System.Drawing.Point(7, 44)
        Me.HUH_RB.Name = "HUH_RB"
        Me.HUH_RB.Size = New System.Drawing.Size(51, 17)
        Me.HUH_RB.TabIndex = 1
        Me.HUH_RB.TabStop = True
        Me.HUH_RB.Text = "Huh?"
        Me.HUH_RB.UseVisualStyleBackColor = True
        '
        'APAC_RB
        '
        Me.APAC_RB.AutoSize = True
        Me.APAC_RB.Location = New System.Drawing.Point(7, 20)
        Me.APAC_RB.Name = "APAC_RB"
        Me.APAC_RB.Size = New System.Drawing.Size(177, 17)
        Me.APAC_RB.TabIndex = 0
        Me.APAC_RB.TabStop = True
        Me.APAC_RB.Text = "Action Potential and Contraction"
        Me.APAC_RB.UseVisualStyleBackColor = True
        '
        'Submit_button
        '
        Me.Submit_button.Location = New System.Drawing.Point(477, 121)
        Me.Submit_button.Name = "Submit_button"
        Me.Submit_button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_button.TabIndex = 2
        Me.Submit_button.Text = "Submit"
        Me.Submit_button.UseVisualStyleBackColor = True
        '
        'Huh_PB
        '
        Me.Huh_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Turk_Leaving
        Me.Huh_PB.Location = New System.Drawing.Point(495, 161)
        Me.Huh_PB.Name = "Huh_PB"
        Me.Huh_PB.Size = New System.Drawing.Size(293, 183)
        Me.Huh_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Huh_PB.TabIndex = 3
        Me.Huh_PB.TabStop = False
        Me.Huh_PB.Visible = False
        '
        'APAC_Label
        '
        Me.APAC_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APAC_Label.Location = New System.Drawing.Point(4, 134)
        Me.APAC_Label.Name = "APAC_Label"
        Me.APAC_Label.Size = New System.Drawing.Size(373, 104)
        Me.APAC_Label.TabIndex = 4
        Me.APAC_Label.Text = "Technically this is right but not the answer we’re looking for as it is not techn" &
    "ical enough try the big worded response"
        Me.APAC_Label.Visible = False
        '
        'RTT_Label
        '
        Me.RTT_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTT_Label.Location = New System.Drawing.Point(13, 255)
        Me.RTT_Label.Name = "RTT_Label"
        Me.RTT_Label.Size = New System.Drawing.Size(583, 158)
        Me.RTT_Label.TabIndex = 5
        Me.RTT_Label.Text = resources.GetString("RTT_Label.Text")
        Me.RTT_Label.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Question8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Disc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RTT_Label)
        Me.Controls.Add(Me.APAC_Label)
        Me.Controls.Add(Me.Huh_PB)
        Me.Controls.Add(Me.Submit_button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BodyLabel)
        Me.Name = "Question8"
        Me.Text = "Question8"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Huh_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BodyLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RTT_RB As RadioButton
    Friend WithEvents HUH_RB As RadioButton
    Friend WithEvents APAC_RB As RadioButton
    Friend WithEvents Submit_button As Button
    Friend WithEvents Huh_PB As PictureBox
    Friend WithEvents APAC_Label As Label
    Friend WithEvents RTT_Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
