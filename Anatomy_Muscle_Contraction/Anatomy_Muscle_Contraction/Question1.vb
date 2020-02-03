Public Class Question1
    Private tries As Integer
    Private Sub Question1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AP_Label_Click(sender As Object, e As EventArgs) Handles AP_Label.Click

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        If AP_RB.Checked Then

        ElseIf MN_RB.Checked Then

        ElseIf IDK_RB.Checked Then

        End If
    End Sub
End Class