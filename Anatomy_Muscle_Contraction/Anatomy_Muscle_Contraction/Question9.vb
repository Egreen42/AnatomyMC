Public Class Question9
    Private tries As Integer
    Private Sub Question9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_button_Click(sender As Object, e As EventArgs) Handles Submit_button.Click
        If TCAC_RB.Checked Then
            APAC_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf Nothing_RB.Checked Then
            Huh_PB.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf Sarc_RB.Checked Then
            RTT_Label.Visible = True
            Timer2.Interval = 10000
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Huh_PB.Visible = False
        APAC_Label.Visible = False
        tries = 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        RTT_Label.Visible = False
        If tries = 0 Then
            Starting_Page.Correct = Starting_Page.Correct + 1
        Else
            Starting_Page.Wrong = Starting_Page.Wrong + 1
        End If

        Question10.Show()
        Me.Hide()
    End Sub
End Class