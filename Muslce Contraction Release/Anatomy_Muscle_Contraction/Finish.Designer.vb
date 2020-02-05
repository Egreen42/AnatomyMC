<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finish
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
        Me.Body_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Correct_Label = New System.Windows.Forms.Label()
        Me.Wrong_label = New System.Windows.Forms.Label()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Body_Label
        '
        Me.Body_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body_Label.Location = New System.Drawing.Point(122, 50)
        Me.Body_Label.Name = "Body_Label"
        Me.Body_Label.Size = New System.Drawing.Size(556, 60)
        Me.Body_Label.TabIndex = 0
        Me.Body_Label.Text = "Congratulations you have finished the Interactive Guide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Here are your results" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Correct"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Wrong"
        '
        'Correct_Label
        '
        Me.Correct_Label.AutoSize = True
        Me.Correct_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correct_Label.Location = New System.Drawing.Point(300, 146)
        Me.Correct_Label.Name = "Correct_Label"
        Me.Correct_Label.Size = New System.Drawing.Size(0, 25)
        Me.Correct_Label.TabIndex = 3
        '
        'Wrong_label
        '
        Me.Wrong_label.AutoSize = True
        Me.Wrong_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wrong_label.Location = New System.Drawing.Point(300, 183)
        Me.Wrong_label.Name = "Wrong_label"
        Me.Wrong_label.Size = New System.Drawing.Size(0, 25)
        Me.Wrong_label.TabIndex = 4
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(273, 238)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 5
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Finish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anatomy_Muscle_Contraction.My.Resources.Resources.Thumbs_up
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Wrong_label)
        Me.Controls.Add(Me.Correct_Label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Body_Label)
        Me.Name = "Finish"
        Me.Text = "Finish"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Body_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Correct_Label As Label
    Friend WithEvents Wrong_label As Label
    Friend WithEvents Exit_Button As Button
End Class
