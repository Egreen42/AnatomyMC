Public Class Starting_Page
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Name_Label_Click(sender As Object, e As EventArgs) Handles Name_Label.Click

    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        Intro_Form.Show()
        Me.Hide()
    End Sub
End Class
