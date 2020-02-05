Public Class Question7
    Private tries As Integer

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If NC_RB.Checked Then
            IDK_PB.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf TAPS_RB.Checked Then
            TAPS_Label.Visible = True
            Timer2.Interval = 1000
            Timer2.Start()
        ElseIf Con_RB.Checked Then
            Con_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        IDK_PB.Visible = False
        Con_Label.Visible = False
        tries = 1
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        TAPS_Label.Visible = False
        If tries = 0 Then
            Starting_Page.Correct = Starting_Page.Correct + 1
        Else
            Starting_Page.Wrong = Starting_Page.Wrong + 1
        End If

        Question8.Show()
        Me.Hide()
    End Sub

End Class