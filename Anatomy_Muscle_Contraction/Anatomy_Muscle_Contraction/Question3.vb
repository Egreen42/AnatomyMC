Public Class Question3
    Private tries As Integer
    Private Sub Question3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If Nothing_RB.Checked Then
            No_PB.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf HKOTA_RB.Checked Then
            If tries = 0 Then
                Starting_Page.Correct = Starting_Page.Correct + 1
            Else
                Starting_Page.Wrong = Starting_Page.Wrong + 1
            End If
            HKOFT_PB.Visible = True
            HKOTA_Label.Visible = True
            Timer2.Interval = 10000
            Timer2.Start()
        ElseIf IHAL_RB.Checked Then
            IHAL_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        No_PB.Visible = False
        IHAL_Label.Visible = False
        tries = 1

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        HKOFT_PB.Visible = False
        HKOTA_Label.Visible = False
        Question4.Show()
        Me.Hide()


    End Sub
End Class