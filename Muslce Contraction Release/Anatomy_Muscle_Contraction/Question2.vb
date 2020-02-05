Public Class Question2
    Private tries As Integer
    Private Sub Question2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Body_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If IDK_RB.Checked Then
            IDK_PB.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf TTM_RB.Checked Then
            TTM_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf TTMN_RB.Checked Then
            TTMN_Label.Visible = True
            If tries = 0 Then
                Starting_Page.Correct = Starting_Page.Correct + 1
            Else
                Starting_Page.Wrong = Starting_Page.Wrong + 1
            End If
            Timer2.Interval = 5000
            Timer2.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        IDK_PB.Visible = False
        TTM_Label.Visible = False
        tries = 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Question3.Show()
        Me.Hide()
    End Sub
End Class