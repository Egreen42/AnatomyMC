<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question5))
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AH_RB = New System.Windows.Forms.RadioButton()
        Me.SC_RB = New System.Windows.Forms.RadioButton()
        Me.Nowhere_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.AHole_Label = New System.Windows.Forms.Label()
        Me.SC_Label = New System.Windows.Forms.Label()
        Me.Nowhere_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.AutoSize = True
        Me.Body_Label.BackColor = System.Drawing.Color.Transparent
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(33, 21)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(353, 31)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "Where does the ACh dump?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Nowhere_RB)
        Me.GroupBox1.Controls.Add(Me.SC_RB)
        Me.GroupBox1.Controls.Add(Me.AH_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(602, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'AH_RB
        '
        Me.AH_RB.AutoSize = True
        Me.AH_RB.Location = New System.Drawing.Point(7, 20)
        Me.AH_RB.Name = "AH_RB"
        Me.AH_RB.Size = New System.Drawing.Size(70, 17)
        Me.AH_RB.TabIndex = 0
        Me.AH_RB.TabStop = True
        Me.AH_RB.Text = "ACh Hole"
        Me.AH_RB.UseVisualStyleBackColor = True
        '
        'SC_RB
        '
        Me.SC_RB.AutoSize = True
        Me.SC_RB.Location = New System.Drawing.Point(7, 44)
        Me.SC_RB.Name = "SC_RB"
        Me.SC_RB.Size = New System.Drawing.Size(90, 17)
        Me.SC_RB.TabIndex = 1
        Me.SC_RB.TabStop = True
        Me.SC_RB.Text = "Synaptic Cleft"
        Me.SC_RB.UseVisualStyleBackColor = True
        '
        'Nowhere_RB
        '
        Me.Nowhere_RB.AutoSize = True
        Me.Nowhere_RB.Location = New System.Drawing.Point(7, 68)
        Me.Nowhere_RB.Name = "Nowhere_RB"
        Me.Nowhere_RB.Size = New System.Drawing.Size(68, 17)
        Me.Nowhere_RB.TabIndex = 2
        Me.Nowhere_RB.TabStop = True
        Me.Nowhere_RB.Text = "Nowhere"
        Me.Nowhere_RB.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(609, 166)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'AHole_Label
        '
        Me.AHole_Label.AutoSize = True
        Me.AHole_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AHole_Label.Location = New System.Drawing.Point(12, 99)
        Me.AHole_Label.Name = "AHole_Label"
        Me.AHole_Label.Size = New System.Drawing.Size(307, 25)
        Me.AHole_Label.TabIndex = 3
        Me.AHole_Label.Text = "That does not exist but nice try"
        Me.AHole_Label.Visible = False
        '
        'SC_Label
        '
        Me.SC_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SC_Label.Location = New System.Drawing.Point(12, 131)
        Me.SC_Label.Name = "SC_Label"
        Me.SC_Label.Size = New System.Drawing.Size(435, 241)
        Me.SC_Label.TabIndex = 4
        Me.SC_Label.Text = resources.GetString("SC_Label.Text")
        Me.SC_Label.Visible = False
        '
        'Nowhere_Label
        '
        Me.Nowhere_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nowhere_Label.Location = New System.Drawing.Point(519, 229)
        Me.Nowhere_Label.Name = "Nowhere_Label"
        Me.Nowhere_Label.Size = New System.Drawing.Size(208, 57)
        Me.Nowhere_Label.TabIndex = 5
        Me.Nowhere_Label.Text = "Not a trick question, This aint it chief"
        Me.Nowhere_Label.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Question5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources._2_People
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Nowhere_Label)
        Me.Controls.Add(Me.SC_Label)
        Me.Controls.Add(Me.AHole_Label)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Body_Label)
        Me.Name = "Question5"
        Me.Text = "Question5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Nowhere_RB As RadioButton
    Friend WithEvents SC_RB As RadioButton
    Friend WithEvents AH_RB As RadioButton
    Friend WithEvents Submit_Button As Button
    Friend WithEvents AHole_Label As Label
    Friend WithEvents SC_Label As Label
    Friend WithEvents Nowhere_Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
