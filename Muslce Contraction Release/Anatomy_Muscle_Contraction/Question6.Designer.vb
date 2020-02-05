<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question6))
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AROS_RB = New System.Windows.Forms.RadioButton()
        Me.MDA_RB = New System.Windows.Forms.RadioButton()
        Me.IDK_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MDOA_Label = New System.Windows.Forms.Label()
        Me.IDK_PB = New System.Windows.Forms.PictureBox()
        Me.AROS_Label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IDK_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.BackColor = System.Drawing.Color.Transparent
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(38, 22)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(419, 75)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "What is left in this section before the next wave of action potential?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AROS_RB)
        Me.GroupBox1.Controls.Add(Me.MDA_RB)
        Me.GroupBox1.Controls.Add(Me.IDK_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(587, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 92)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'AROS_RB
        '
        Me.AROS_RB.AutoSize = True
        Me.AROS_RB.Location = New System.Drawing.Point(6, 66)
        Me.AROS_RB.Name = "AROS_RB"
        Me.AROS_RB.Size = New System.Drawing.Size(108, 17)
        Me.AROS_RB.TabIndex = 2
        Me.AROS_RB.TabStop = True
        Me.AROS_RB.Text = "A Rush of sodium"
        Me.AROS_RB.UseVisualStyleBackColor = True
        '
        'MDA_RB
        '
        Me.MDA_RB.AutoSize = True
        Me.MDA_RB.Location = New System.Drawing.Point(7, 43)
        Me.MDA_RB.Name = "MDA_RB"
        Me.MDA_RB.Size = New System.Drawing.Size(129, 17)
        Me.MDA_RB.TabIndex = 1
        Me.MDA_RB.TabStop = True
        Me.MDA_RB.Text = "More Dumping of ACh"
        Me.MDA_RB.UseVisualStyleBackColor = True
        '
        'IDK_RB
        '
        Me.IDK_RB.AutoSize = True
        Me.IDK_RB.Location = New System.Drawing.Point(7, 20)
        Me.IDK_RB.Name = "IDK_RB"
        Me.IDK_RB.Size = New System.Drawing.Size(40, 17)
        Me.IDK_RB.TabIndex = 0
        Me.IDK_RB.TabStop = True
        Me.IDK_RB.Text = "Idk"
        Me.IDK_RB.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(593, 140)
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
        'MDOA_Label
        '
        Me.MDOA_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MDOA_Label.Location = New System.Drawing.Point(12, 97)
        Me.MDOA_Label.Name = "MDOA_Label"
        Me.MDOA_Label.Size = New System.Drawing.Size(470, 57)
        Me.MDOA_Label.TabIndex = 3
        Me.MDOA_Label.Text = "Not exactly, there is more dumping but not of Ach, when Ach is in its spot it’s d" &
    "one for. "
        Me.MDOA_Label.Visible = False
        '
        'IDK_PB
        '
        Me.IDK_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Sad_Ramsay
        Me.IDK_PB.Location = New System.Drawing.Point(499, 232)
        Me.IDK_PB.Name = "IDK_PB"
        Me.IDK_PB.Size = New System.Drawing.Size(289, 177)
        Me.IDK_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IDK_PB.TabIndex = 4
        Me.IDK_PB.TabStop = False
        Me.IDK_PB.Visible = False
        '
        'AROS_Label
        '
        Me.AROS_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AROS_Label.Location = New System.Drawing.Point(12, 166)
        Me.AROS_Label.Name = "AROS_Label"
        Me.AROS_Label.Size = New System.Drawing.Size(603, 258)
        Me.AROS_Label.TabIndex = 5
        Me.AROS_Label.Text = resources.GetString("AROS_Label.Text")
        Me.AROS_Label.Visible = False
        '
        'Question6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Backbent
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AROS_Label)
        Me.Controls.Add(Me.IDK_PB)
        Me.Controls.Add(Me.MDOA_Label)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Body_Label)
        Me.Name = "Question6"
        Me.Text = "Question6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IDK_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AROS_RB As RadioButton
    Friend WithEvents MDA_RB As RadioButton
    Friend WithEvents IDK_RB As RadioButton
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MDOA_Label As Label
    Friend WithEvents IDK_PB As PictureBox
    Friend WithEvents AROS_Label As Label
End Class
