﻿Public Class Question5
    Private tries As Integer
    Private Sub Question5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If AH_RB.Checked Then
            AHole_Label.Visible = True
            'ha AHole'
            Timer1.Interval = 2000
            Timer1.Start()
        ElseIf SC_RB.Checked Then
            SC_Label.Visible = True
            Timer2.Interval = 10000
            Timer2.Start()
        ElseIf Nowhere_RB.Checked Then
            Nowhere_Label.Visible = True
            Timer1.Interval = 2000
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        AHole_Label.Visible = False 'Ha I used Ahole again'
        Nowhere_Label.Visible = False
        tries = 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        If tries = 0 Then
            Starting_Page.Correct = Starting_Page.Correct + 1
        Else
            Starting_Page.Wrong = Starting_Page.Wrong + 1
        End If

        Question6.Show()
        Me.Hide()


    End Sub
End Class