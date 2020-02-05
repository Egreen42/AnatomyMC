<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Starting_Page
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
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.Credits_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Muscle_Contraction_Label = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Form_Size = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Start_Button
        '
        Me.Start_Button.Location = New System.Drawing.Point(661, 137)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(75, 23)
        Me.Start_Button.TabIndex = 2
        Me.Start_Button.Text = "Start"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'Credits_Button
        '
        Me.Credits_Button.Location = New System.Drawing.Point(661, 166)
        Me.Credits_Button.Name = "Credits_Button"
        Me.Credits_Button.Size = New System.Drawing.Size(75, 23)
        Me.Credits_Button.TabIndex = 3
        Me.Credits_Button.Text = "Credits"
        Me.Credits_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(661, 196)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 4
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Muscle_Contraction_Label
        '
        Me.Muscle_Contraction_Label.AutoSize = True
        Me.Muscle_Contraction_Label.BackColor = System.Drawing.Color.Transparent
        Me.Muscle_Contraction_Label.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Muscle_Contraction_Label.Location = New System.Drawing.Point(309, 9)
        Me.Muscle_Contraction_Label.Name = "Muscle_Contraction_Label"
        Me.Muscle_Contraction_Label.Size = New System.Drawing.Size(202, 29)
        Me.Muscle_Contraction_Label.TabIndex = 5
        Me.Muscle_Contraction_Label.Text = "Muscle Contraction"
        Me.Muscle_Contraction_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.BackColor = System.Drawing.Color.Transparent
        Me.Name_Label.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Label.Location = New System.Drawing.Point(295, 423)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(254, 18)
        Me.Name_Label.TabIndex = 6
        Me.Name_Label.Text = "By: Ethan Green and Makaylee Coapstick"
        Me.Name_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form_Size
        '
        Me.Form_Size.AutoSize = True
        Me.Form_Size.BackColor = System.Drawing.Color.Transparent
        Me.Form_Size.Location = New System.Drawing.Point(28, 155)
        Me.Form_Size.Name = "Form_Size"
        Me.Form_Size.Size = New System.Drawing.Size(240, 13)
        Me.Form_Size.TabIndex = 7
        Me.Form_Size.Text = "Please don't change the window size at any point"
        '
        'Starting_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Muscle_Man
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Form_Size)
        Me.Controls.Add(Me.Name_Label)
        Me.Controls.Add(Me.Muscle_Contraction_Label)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Credits_Button)
        Me.Controls.Add(Me.Start_Button)
        Me.Name = "Starting_Page"
        Me.Text = "Muscle_Contraction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Start_Button As Button
    Friend WithEvents Credits_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Muscle_Contraction_Label As Label
    Friend WithEvents Name_Label As Label
    Friend WithEvents Form_Size As Label
End Class
