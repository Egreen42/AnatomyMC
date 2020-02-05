<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question3))
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Nothing_RB = New System.Windows.Forms.RadioButton()
        Me.HKOTA_RB = New System.Windows.Forms.RadioButton()
        Me.IHAL_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.No_PB = New System.Windows.Forms.PictureBox()
        Me.IHAL_Label = New System.Windows.Forms.Label()
        Me.HKOTA_Label = New System.Windows.Forms.Label()
        Me.HKOFT_PB = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.No_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HKOFT_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.AutoSize = True
        Me.Body_Label.BackColor = System.Drawing.Color.Transparent
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(12, 9)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(515, 31)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "What happens with the synaptic terminal?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Nothing_RB)
        Me.GroupBox1.Controls.Add(Me.HKOTA_RB)
        Me.GroupBox1.Controls.Add(Me.IHAL_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(588, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Nothing_RB
        '
        Me.Nothing_RB.AutoSize = True
        Me.Nothing_RB.Location = New System.Drawing.Point(7, 19)
        Me.Nothing_RB.Name = "Nothing_RB"
        Me.Nothing_RB.Size = New System.Drawing.Size(62, 17)
        Me.Nothing_RB.TabIndex = 2
        Me.Nothing_RB.TabStop = True
        Me.Nothing_RB.Text = "Nothing"
        Me.Nothing_RB.UseVisualStyleBackColor = True
        '
        'HKOTA_RB
        '
        Me.HKOTA_RB.AutoSize = True
        Me.HKOTA_RB.Location = New System.Drawing.Point(7, 44)
        Me.HKOTA_RB.Name = "HKOTA_RB"
        Me.HKOTA_RB.Size = New System.Drawing.Size(145, 17)
        Me.HKOTA_RB.TabIndex = 1
        Me.HKOTA_RB.TabStop = True
        Me.HKOTA_RB.Text = "Helps kick off the actions"
        Me.HKOTA_RB.UseVisualStyleBackColor = True
        '
        'IHAL_RB
        '
        Me.IHAL_RB.AutoSize = True
        Me.IHAL_RB.Location = New System.Drawing.Point(7, 67)
        Me.IHAL_RB.Name = "IHAL_RB"
        Me.IHAL_RB.Size = New System.Drawing.Size(82, 17)
        Me.IHAL_RB.TabIndex = 0
        Me.IHAL_RB.TabStop = True
        Me.IHAL_RB.Text = "It holds a lot"
        Me.IHAL_RB.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(595, 157)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'No_PB
        '
        Me.No_PB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.No_PB.BackColor = System.Drawing.SystemColors.Control
        Me.No_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Not_Amused
        Me.No_PB.Location = New System.Drawing.Point(451, 186)
        Me.No_PB.Name = "No_PB"
        Me.No_PB.Size = New System.Drawing.Size(299, 236)
        Me.No_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.No_PB.TabIndex = 3
        Me.No_PB.TabStop = False
        Me.No_PB.Visible = False
        '
        'IHAL_Label
        '
        Me.IHAL_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IHAL_Label.Location = New System.Drawing.Point(18, 56)
        Me.IHAL_Label.Name = "IHAL_Label"
        Me.IHAL_Label.Size = New System.Drawing.Size(387, 61)
        Me.IHAL_Label.TabIndex = 4
        Me.IHAL_Label.Text = "Yes, it does hold a lot of stuff for the process but it has to do something with " &
    "it.  "
        Me.IHAL_Label.Visible = False
        '
        'HKOTA_Label
        '
        Me.HKOTA_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HKOTA_Label.Location = New System.Drawing.Point(18, 136)
        Me.HKOTA_Label.Name = "HKOTA_Label"
        Me.HKOTA_Label.Size = New System.Drawing.Size(387, 126)
        Me.HKOTA_Label.TabIndex = 5
        Me.HKOTA_Label.Text = resources.GetString("HKOTA_Label.Text")
        Me.HKOTA_Label.UseCompatibleTextRendering = True
        Me.HKOTA_Label.Visible = False
        '
        'HKOFT_PB
        '
        Me.HKOFT_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Synaptic_Terminal
        Me.HKOFT_PB.Location = New System.Drawing.Point(33, 265)
        Me.HKOFT_PB.Name = "HKOFT_PB"
        Me.HKOFT_PB.Size = New System.Drawing.Size(334, 173)
        Me.HKOFT_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HKOFT_PB.TabIndex = 6
        Me.HKOFT_PB.TabStop = False
        Me.HKOFT_PB.Visible = False
        '
        'Question3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Flex
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HKOFT_PB)
        Me.Controls.Add(Me.HKOTA_Label)
        Me.Controls.Add(Me.IHAL_Label)
        Me.Controls.Add(Me.No_PB)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Body_Label)
        Me.Name = "Question3"
        Me.Text = "Question3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.No_PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HKOFT_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Nothing_RB As RadioButton
    Friend WithEvents HKOTA_RB As RadioButton
    Friend WithEvents IHAL_RB As RadioButton
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents No_PB As PictureBox
    Friend WithEvents IHAL_Label As Label
    Friend WithEvents HKOTA_Label As Label
    Friend WithEvents HKOFT_PB As PictureBox
End Class
