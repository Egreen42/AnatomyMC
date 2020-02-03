Public Class Starting_Page
    Public Correct As Integer
    Public Wrong As Integer
    Private Declare Function timeGetTime Lib "winmm.dll" () As Long
    Public lngStartTime As Long

    Public Sub delay(msdelay As Long)
        lngStartTime = timeGetTime()
        Do Until (timeGetTime() - lngStartTime) > msdelay
        Loop
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Name_Label_Click(sender As Object, e As EventArgs) Handles Name_Label.Click

    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        Intro_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Starting_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
