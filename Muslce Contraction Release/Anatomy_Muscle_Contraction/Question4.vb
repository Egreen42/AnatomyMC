Public Class Question4
    Private tries As Integer
    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If Nothing_RB.Checked Then
            Nothing_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf MCIOC_RB.Checked Then
            MCIOC_PB.Visible = True
            MCIOC_Label.Visible = True
            Timer2.Interval = 7000
            Timer2.Start()
        ElseIf CTMN_RB.Checked Then
            CTMN_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Nothing_Label.Visible = False
        CTMN_Label.Visible = False
        tries = 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        If tries = 0 Then
            Starting_Page.Correct = Starting_Page.Correct + 1
        Else
            Starting_Page.Wrong = Starting_Page.Wrong + 1
        End If
        Question5.Show()
        Me.Hide()
    End Sub
End Class