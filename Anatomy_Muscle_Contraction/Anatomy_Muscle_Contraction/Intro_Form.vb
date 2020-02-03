Public Class Intro_Form
    Private tries As Integer



    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If No_RB.Checked Then
            No_Label.Visible = True
            tries = 1
            Timer1.Interval = 3000
            Timer1.Start()
        ElseIf Maybe_RB.Checked Then
            Maybe_Label.Visible = True
            tries = 1
            Timer1.Interval = 3000
            Timer1.Start()
        ElseIf Yes_RB.Checked Then
            Yes_Label.Visible = True
            If tries = 0 Then
                Starting_Page.Correct = Starting_Page.Correct + 1
            Else
                Starting_Page.Wrong = Starting_Page.Wrong + 1
            End If
            Timer2.Interval = 10000
            Timer2.Start()
        End If
    End Sub

    Private Sub No_RB_CheckedChanged(sender As Object, e As EventArgs) Handles No_RB.CheckedChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        No_Label.Visible = False
        Maybe_Label.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Question1.Show()
        Me.Hide()
    End Sub
End Class