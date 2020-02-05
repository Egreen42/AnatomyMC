<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question10))
        Me.RTT_Label = New System.Windows.Forms.Label()
        Me.APAC_Label = New System.Windows.Forms.Label()
        Me.Submit_button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TCAC_RB = New System.Windows.Forms.RadioButton()
        Me.Nothing_RB = New System.Windows.Forms.RadioButton()
        Me.Sarc_RB = New System.Windows.Forms.RadioButton()
        Me.BodyLabel = New System.Windows.Forms.Label()
        Me.Huh_PB = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Huh_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RTT_Label
        '
        Me.RTT_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTT_Label.Location = New System.Drawing.Point(12, 261)
        Me.RTT_Label.Name = "RTT_Label"
        Me.RTT_Label.Size = New System.Drawing.Size(583, 158)
        Me.RTT_Label.TabIndex = 17
        Me.RTT_Label.Text = resources.GetString("RTT_Label.Text")
        Me.RTT_Label.Visible = False
        '
        'APAC_Label
        '
        Me.APAC_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APAC_Label.Location = New System.Drawing.Point(9, 157)
        Me.APAC_Label.Name = "APAC_Label"
        Me.APAC_Label.Size = New System.Drawing.Size(373, 104)
        Me.APAC_Label.TabIndex = 16
        Me.APAC_Label.Text = "No, not yet something needs to affect the bridge before it can fall apart"
        Me.APAC_Label.Visible = False
        '
        'Submit_button
        '
        Me.Submit_button.Location = New System.Drawing.Point(482, 144)
        Me.Submit_button.Name = "Submit_button"
        Me.Submit_button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_button.TabIndex = 14
        Me.Submit_button.Text = "Submit"
        Me.Submit_button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TCAC_RB)
        Me.GroupBox1.Controls.Add(Me.Nothing_RB)
        Me.GroupBox1.Controls.Add(Me.Sarc_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(482, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 96)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'TCAC_RB
        '
        Me.TCAC_RB.AutoSize = True
        Me.TCAC_RB.Location = New System.Drawing.Point(7, 43)
        Me.TCAC_RB.Name = "TCAC_RB"
        Me.TCAC_RB.Size = New System.Drawing.Size(79, 17)
        Me.TCAC_RB.TabIndex = 2
        Me.TCAC_RB.TabStop = True
        Me.TCAC_RB.Text = "It falls apart"
        Me.TCAC_RB.UseVisualStyleBackColor = True
        '
        'Nothing_RB
        '
        Me.Nothing_RB.AutoSize = True
        Me.Nothing_RB.Location = New System.Drawing.Point(7, 66)
        Me.Nothing_RB.Name = "Nothing_RB"
        Me.Nothing_RB.Size = New System.Drawing.Size(117, 17)
        Me.Nothing_RB.TabIndex = 1
        Me.Nothing_RB.TabStop = True
        Me.Nothing_RB.Text = "A troll hides under it"
        Me.Nothing_RB.UseVisualStyleBackColor = True
        '
        'Sarc_RB
        '
        Me.Sarc_RB.AutoSize = True
        Me.Sarc_RB.Location = New System.Drawing.Point(7, 20)
        Me.Sarc_RB.Name = "Sarc_RB"
        Me.Sarc_RB.Size = New System.Drawing.Size(175, 17)
        Me.Sarc_RB.TabIndex = 0
        Me.Sarc_RB.TabStop = True
        Me.Sarc_RB.Text = "The myosin of the bridge moves"
        Me.Sarc_RB.UseVisualStyleBackColor = True
        '
        'BodyLabel
        '
        Me.BodyLabel.BackColor = System.Drawing.SystemColors.Control
        Me.BodyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyLabel.Location = New System.Drawing.Point(8, 32)
        Me.BodyLabel.Name = "BodyLabel"
        Me.BodyLabel.Size = New System.Drawing.Size(383, 106)
        Me.BodyLabel.TabIndex = 12
        Me.BodyLabel.Text = "What happens after the bridge is made?"
        '
        'Huh_PB
        '
        Me.Huh_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Trump_Wrong
        Me.Huh_PB.Location = New System.Drawing.Point(528, 173)
        Me.Huh_PB.Name = "Huh_PB"
        Me.Huh_PB.Size = New System.Drawing.Size(248, 201)
        Me.Huh_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Huh_PB.TabIndex = 15
        Me.Huh_PB.TabStop = False
        Me.Huh_PB.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Question10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.T_pose
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RTT_Label)
        Me.Controls.Add(Me.APAC_Label)
        Me.Controls.Add(Me.Huh_PB)
        Me.Controls.Add(Me.Submit_button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BodyLabel)
        Me.Name = "Question10"
        Me.Text = "Question10"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Huh_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RTT_Label As Label
    Friend WithEvents APAC_Label As Label
    Friend WithEvents Huh_PB As PictureBox
    Friend WithEvents Submit_button As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TCAC_RB As RadioButton
    Friend WithEvents Nothing_RB As RadioButton
    Friend WithEvents Sarc_RB As RadioButton
    Friend WithEvents BodyLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
