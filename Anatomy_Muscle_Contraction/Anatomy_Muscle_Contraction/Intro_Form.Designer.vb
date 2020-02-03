<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Intro_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro_Form))
        Me.BodyLabel1 = New System.Windows.Forms.Label()
        Me.BodyLabel2 = New System.Windows.Forms.Label()
        Me.BodyLabel3 = New System.Windows.Forms.Label()
        Me.Answer_GB = New System.Windows.Forms.GroupBox()
        Me.No_RB = New System.Windows.Forms.RadioButton()
        Me.Maybe_RB = New System.Windows.Forms.RadioButton()
        Me.Yes_RB = New System.Windows.Forms.RadioButton()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.No_Label = New System.Windows.Forms.Label()
        Me.Maybe_Label = New System.Windows.Forms.Label()
        Me.Yes_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Answer_GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'BodyLabel1
        '
        Me.BodyLabel1.AutoSize = True
        Me.BodyLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyLabel1.Location = New System.Drawing.Point(12, 9)
        Me.BodyLabel1.Name = "BodyLabel1"
        Me.BodyLabel1.Size = New System.Drawing.Size(553, 24)
        Me.BodyLabel1.TabIndex = 0
        Me.BodyLabel1.Text = "When you move have you ever wondered how you can do that? "
        '
        'BodyLabel2
        '
        Me.BodyLabel2.AutoSize = True
        Me.BodyLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyLabel2.Location = New System.Drawing.Point(12, 33)
        Me.BodyLabel2.Name = "BodyLabel2"
        Me.BodyLabel2.Size = New System.Drawing.Size(645, 24)
        Me.BodyLabel2.TabIndex = 1
        Me.BodyLabel2.Text = "What's the process below your skin of all of your muscles that you can't see?"
        '
        'BodyLabel3
        '
        Me.BodyLabel3.AutoSize = True
        Me.BodyLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyLabel3.Location = New System.Drawing.Point(12, 57)
        Me.BodyLabel3.Name = "BodyLabel3"
        Me.BodyLabel3.Size = New System.Drawing.Size(507, 24)
        Me.BodyLabel3.TabIndex = 2
        Me.BodyLabel3.Text = "Have you ever been curious of how your muscles contract?"
        '
        'Answer_GB
        '
        Me.Answer_GB.Controls.Add(Me.Yes_RB)
        Me.Answer_GB.Controls.Add(Me.Maybe_RB)
        Me.Answer_GB.Controls.Add(Me.No_RB)
        Me.Answer_GB.Location = New System.Drawing.Point(588, 70)
        Me.Answer_GB.Name = "Answer_GB"
        Me.Answer_GB.Size = New System.Drawing.Size(200, 108)
        Me.Answer_GB.TabIndex = 3
        Me.Answer_GB.TabStop = False
        '
        'No_RB
        '
        Me.No_RB.AutoSize = True
        Me.No_RB.Location = New System.Drawing.Point(23, 33)
        Me.No_RB.Name = "No_RB"
        Me.No_RB.Size = New System.Drawing.Size(39, 17)
        Me.No_RB.TabIndex = 0
        Me.No_RB.TabStop = True
        Me.No_RB.Text = "No"
        Me.No_RB.UseVisualStyleBackColor = True
        '
        'Maybe_RB
        '
        Me.Maybe_RB.AutoSize = True
        Me.Maybe_RB.Location = New System.Drawing.Point(23, 57)
        Me.Maybe_RB.Name = "Maybe_RB"
        Me.Maybe_RB.Size = New System.Drawing.Size(63, 17)
        Me.Maybe_RB.TabIndex = 1
        Me.Maybe_RB.TabStop = True
        Me.Maybe_RB.Text = "Maybe?"
        Me.Maybe_RB.UseVisualStyleBackColor = True
        '
        'Yes_RB
        '
        Me.Yes_RB.AutoSize = True
        Me.Yes_RB.Location = New System.Drawing.Point(23, 81)
        Me.Yes_RB.Name = "Yes_RB"
        Me.Yes_RB.Size = New System.Drawing.Size(46, 17)
        Me.Yes_RB.TabIndex = 2
        Me.Yes_RB.TabStop = True
        Me.Yes_RB.Text = "Yes!"
        Me.Yes_RB.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(588, 184)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 4
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'No_Label
        '
        Me.No_Label.AutoSize = True
        Me.No_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_Label.Location = New System.Drawing.Point(198, 94)
        Me.No_Label.Name = "No_Label"
        Me.No_Label.Size = New System.Drawing.Size(300, 39)
        Me.No_Label.TabIndex = 5
        Me.No_Label.Text = "Wrong answer!!!!!!"
        Me.No_Label.UseMnemonic = False
        Me.No_Label.Visible = False
        '
        'Maybe_Label
        '
        Me.Maybe_Label.AutoSize = True
        Me.Maybe_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maybe_Label.Location = New System.Drawing.Point(198, 151)
        Me.Maybe_Label.Name = "Maybe_Label"
        Me.Maybe_Label.Size = New System.Drawing.Size(349, 39)
        Me.Maybe_Label.TabIndex = 6
        Me.Maybe_Label.Text = "Closer, but still wrong"
        Me.Maybe_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Maybe_Label.UseMnemonic = False
        Me.Maybe_Label.Visible = False
        '
        'Yes_Label
        '
        Me.Yes_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yes_Label.Location = New System.Drawing.Point(199, 210)
        Me.Yes_Label.Name = "Yes_Label"
        Me.Yes_Label.Size = New System.Drawing.Size(524, 211)
        Me.Yes_Label.TabIndex = 7
        Me.Yes_Label.Text = resources.GetString("Yes_Label.Text")
        Me.Yes_Label.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Intro_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Running
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Yes_Label)
        Me.Controls.Add(Me.Maybe_Label)
        Me.Controls.Add(Me.No_Label)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Answer_GB)
        Me.Controls.Add(Me.BodyLabel3)
        Me.Controls.Add(Me.BodyLabel2)
        Me.Controls.Add(Me.BodyLabel1)
        Me.Name = "Intro_Form"
        Me.Text = "Intro_Form"
        Me.Answer_GB.ResumeLayout(False)
        Me.Answer_GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BodyLabel1 As Label
    Friend WithEvents BodyLabel2 As Label
    Friend WithEvents BodyLabel3 As Label
    Friend WithEvents Answer_GB As GroupBox
    Friend WithEvents Yes_RB As RadioButton
    Friend WithEvents Maybe_RB As RadioButton
    Friend WithEvents No_RB As RadioButton
    Friend WithEvents Submit_Button As Button
    Friend WithEvents No_Label As Label
    Friend WithEvents Maybe_Label As Label
    Friend WithEvents Yes_Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
