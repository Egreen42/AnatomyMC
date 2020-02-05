<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question7))
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.Con_RB = New System.Windows.Forms.RadioButton()
        Me.NC_RB = New System.Windows.Forms.RadioButton()
        Me.TAPS_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.TAPS_Label = New System.Windows.Forms.Label()
        Me.Con_Label = New System.Windows.Forms.Label()
        Me.IDK_PB = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GB.SuspendLayout()
        CType(Me.IDK_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.BackColor = System.Drawing.Color.Transparent
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(12, 9)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(462, 125)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "Just about half the process has happened! All of that in the terminal is fully do" &
    "ne and now comes the quick and big steps. Which the first being that of…"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.Con_RB)
        Me.GB.Controls.Add(Me.NC_RB)
        Me.GB.Controls.Add(Me.TAPS_RB)
        Me.GB.Location = New System.Drawing.Point(584, 28)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(191, 105)
        Me.GB.TabIndex = 1
        Me.GB.TabStop = False
        '
        'Con_RB
        '
        Me.Con_RB.AutoSize = True
        Me.Con_RB.Location = New System.Drawing.Point(7, 68)
        Me.Con_RB.Name = "Con_RB"
        Me.Con_RB.Size = New System.Drawing.Size(79, 17)
        Me.Con_RB.TabIndex = 2
        Me.Con_RB.TabStop = True
        Me.Con_RB.Text = "Contraction"
        Me.Con_RB.UseVisualStyleBackColor = True
        '
        'NC_RB
        '
        Me.NC_RB.AutoSize = True
        Me.NC_RB.Location = New System.Drawing.Point(7, 44)
        Me.NC_RB.Name = "NC_RB"
        Me.NC_RB.Size = New System.Drawing.Size(63, 17)
        Me.NC_RB.TabIndex = 1
        Me.NC_RB.TabStop = True
        Me.NC_RB.Text = "No Clue"
        Me.NC_RB.UseVisualStyleBackColor = True
        '
        'TAPS_RB
        '
        Me.TAPS_RB.AutoSize = True
        Me.TAPS_RB.Location = New System.Drawing.Point(7, 20)
        Me.TAPS_RB.Name = "TAPS_RB"
        Me.TAPS_RB.Size = New System.Drawing.Size(172, 17)
        Me.TAPS_RB.TabIndex = 0
        Me.TAPS_RB.TabStop = True
        Me.TAPS_RB.Text = "The Action Potential Spreading"
        Me.TAPS_RB.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(611, 140)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'TAPS_Label
        '
        Me.TAPS_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAPS_Label.Location = New System.Drawing.Point(17, 149)
        Me.TAPS_Label.Name = "TAPS_Label"
        Me.TAPS_Label.Size = New System.Drawing.Size(523, 133)
        Me.TAPS_Label.TabIndex = 3
        Me.TAPS_Label.Text = resources.GetString("TAPS_Label.Text")
        Me.TAPS_Label.Visible = False
        '
        'Con_Label
        '
        Me.Con_Label.AutoSize = True
        Me.Con_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Con_Label.Location = New System.Drawing.Point(22, 297)
        Me.Con_Label.Name = "Con_Label"
        Me.Con_Label.Size = New System.Drawing.Size(332, 25)
        Me.Con_Label.TabIndex = 4
        Me.Con_Label.Text = "I know I said fast but not that fast!"
        Me.Con_Label.Visible = False
        '
        'IDK_PB
        '
        Me.IDK_PB.Image = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.ROCKROCKROCKROCK
        Me.IDK_PB.Location = New System.Drawing.Point(558, 203)
        Me.IDK_PB.Name = "IDK_PB"
        Me.IDK_PB.Size = New System.Drawing.Size(230, 185)
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
        'Question7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Up
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IDK_PB)
        Me.Controls.Add(Me.Con_Label)
        Me.Controls.Add(Me.TAPS_Label)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.Body_Label)
        Me.Name = "Question7"
        Me.Text = "Question7"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.IDK_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents GB As GroupBox
    Friend WithEvents Con_RB As RadioButton
    Friend WithEvents NC_RB As RadioButton
    Friend WithEvents TAPS_RB As RadioButton
    Friend WithEvents Submit_Button As Button
    Friend WithEvents TAPS_Label As Label
    Friend WithEvents Con_Label As Label
    Friend WithEvents IDK_PB As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
