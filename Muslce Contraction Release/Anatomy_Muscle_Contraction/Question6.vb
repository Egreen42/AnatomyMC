Public Class Question6
    Private tries As Integer
    Private Sub Question6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If IDK_RB.Checked Then
            IDK_PB.Visible = True
            Timer1.Interval = 2500
            Timer1.Start()
        ElseIf MDA_RB.Checked Then
            MDOA_Label.Visible = True
            Timer1.Interval = 2500
            Timer1.Start()
        ElseIf AROS_RB.Checked Then
            AROS_Label.Visible = True
            Timer2.Interval = 10000
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        IDK_PB.Visible = False
        MDOA_Label.Visible = False
        tries = 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        AROS_Label.Visible = False
        If tries = 0 Then
            Starting_Page.Correct = Starting_Page.Correct + 1
        Else
            Starting_Page.Wrong = Starting_Page.Wrong + 1
        End If

        Question7.Show()
        Me.Hide()
    End Sub
End Class