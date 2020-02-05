<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Question1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BodyLabel = New System.Windows.Forms.Label()
        Me.QuestionGB = New System.Windows.Forms.GroupBox()
        Me.IDK_RB = New System.Windows.Forms.RadioButton()
        Me.MN_RB = New System.Windows.Forms.RadioButton()
        Me.AP_RB = New System.Windows.Forms.RadioButton()
        Me.AP_Label = New System.Windows.Forms.Label()
        Me.MN_Label = New System.Windows.Forms.Label()
        Me.IDK_Label = New System.Windows.Forms.Label()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.QuestionGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'BodyLabel
        '
        Me.BodyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyLabel.Location = New System.Drawing.Point(13, 13)
        Me.BodyLabel.Name = "BodyLabel"
        Me.BodyLabel.Size = New System.Drawing.Size(276, 188)
        Me.BodyLabel.TabIndex = 0
        Me.BodyLabel.Text = "Lets Start. Before anything can happen there needs to be something to trigger the" &
    " process.                                      What could that be?"
        '
        'QuestionGB
        '
        Me.QuestionGB.Controls.Add(Me.IDK_RB)
        Me.QuestionGB.Controls.Add(Me.MN_RB)
        Me.QuestionGB.Controls.Add(Me.AP_RB)
        Me.QuestionGB.Location = New System.Drawing.Point(572, 48)
        Me.QuestionGB.Name = "QuestionGB"
        Me.QuestionGB.Size = New System.Drawing.Size(200, 100)
        Me.QuestionGB.TabIndex = 1
        Me.QuestionGB.TabStop = False
        '
        'IDK_RB
        '
        Me.IDK_RB.AutoSize = True
        Me.IDK_RB.Location = New System.Drawing.Point(30, 68)
        Me.IDK_RB.Name = "IDK_RB"
        Me.IDK_RB.Size = New System.Drawing.Size(43, 17)
        Me.IDK_RB.TabIndex = 2
        Me.IDK_RB.TabStop = True
        Me.IDK_RB.Text = "IDK"
        Me.IDK_RB.UseVisualStyleBackColor = True
        '
        'MN_RB
        '
        Me.MN_RB.AutoSize = True
        Me.MN_RB.Location = New System.Drawing.Point(30, 44)
        Me.MN_RB.Name = "MN_RB"
        Me.MN_RB.Size = New System.Drawing.Size(90, 17)
        Me.MN_RB.TabIndex = 1
        Me.MN_RB.TabStop = True
        Me.MN_RB.Text = "Motor Neuron"
        Me.MN_RB.UseVisualStyleBackColor = True
        '
        'AP_RB
        '
        Me.AP_RB.AutoSize = True
        Me.AP_RB.Location = New System.Drawing.Point(30, 20)
        Me.AP_RB.Name = "AP_RB"
        Me.AP_RB.Size = New System.Drawing.Size(99, 17)
        Me.AP_RB.TabIndex = 0
        Me.AP_RB.TabStop = True
        Me.AP_RB.Text = "Action Potential"
        Me.AP_RB.UseVisualStyleBackColor = True
        '
        'AP_Label
        '
        Me.AP_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AP_Label.Location = New System.Drawing.Point(332, 291)
        Me.AP_Label.Name = "AP_Label"
        Me.AP_Label.Size = New System.Drawing.Size(415, 150)
        Me.AP_Label.TabIndex = 2
        Me.AP_Label.Text = "Correct! Action potential is needed to start a muscle contraction. The action pot" &
    "ential is an electric signal or chemical message that is going to move down and " &
    "trigger the start of the process"
        Me.AP_Label.Visible = False
        '
        'MN_Label
        '
        Me.MN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN_Label.Location = New System.Drawing.Point(332, 198)
        Me.MN_Label.Name = "MN_Label"
        Me.MN_Label.Size = New System.Drawing.Size(390, 93)
        Me.MN_Label.TabIndex = 3
        Me.MN_Label.Text = "Close but not correct. The motor neuron is where the function will occur but is n" &
    "ot the reason why it is the action potential."
        Me.MN_Label.Visible = False
        '
        'IDK_Label
        '
        Me.IDK_Label.AutoSize = True
        Me.IDK_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDK_Label.Location = New System.Drawing.Point(332, 173)
        Me.IDK_Label.Name = "IDK_Label"
        Me.IDK_Label.Size = New System.Drawing.Size(384, 25)
        Me.IDK_Label.TabIndex = 4
        Me.IDK_Label.Text = "Try again! Don't give up we just started"
        Me.IDK_Label.Visible = False
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(570, 154)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 5
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Question1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Muscle_Face
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.IDK_Label)
        Me.Controls.Add(Me.MN_Label)
        Me.Controls.Add(Me.AP_Label)
        Me.Controls.Add(Me.QuestionGB)
        Me.Controls.Add(Me.BodyLabel)
        Me.Name = "Question1"
        Me.Text = "Question1"
        Me.QuestionGB.ResumeLayout(False)
        Me.QuestionGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BodyLabel As Label
    Friend WithEvents QuestionGB As GroupBox
    Friend WithEvents IDK_RB As RadioButton
    Friend WithEvents MN_RB As RadioButton
    Friend WithEvents AP_RB As RadioButton
    Friend WithEvents AP_Label As Label
    Friend WithEvents MN_Label As Label
    Friend WithEvents IDK_Label As Label
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
