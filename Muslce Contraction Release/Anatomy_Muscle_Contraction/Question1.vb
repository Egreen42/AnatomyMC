Public Class Question1
    Private tries As Integer
    Private Sub Question1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AP_Label_Click(sender As Object, e As EventArgs) Handles AP_Label.Click

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If AP_RB.Checked Then
            AP_Label.Visible = True
            Timer2.Interval = 7000
            Timer2.Start()
        ElseIf MN_RB.Checked Then
            MN_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf IDK_RB.Checked Then
            IDK_Label.Visible = True
            If tries = 0 Then
                Starting_Page.Correct = Starting_Page.Correct + 1
            End If
            Timer1.Interval = 2000
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        IDK_Label.Visible = False
        MN_Label.Visible = False
        If tries = 0 Then
            tries = 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Question2.Show()
        Me.Hide()
    End Sub
End Class