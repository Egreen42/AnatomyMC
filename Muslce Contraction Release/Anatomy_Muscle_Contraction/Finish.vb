Public Class Finish
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Finish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Correct_Label.Text = Starting_Page.Correct
        Wrong_label.Text = Starting_Page.Wrong
    End Sub
End Class