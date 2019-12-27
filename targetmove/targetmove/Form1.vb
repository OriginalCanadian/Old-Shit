Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pic1.Left = pic1.Left + 5
        If pic1.Left > Me.Width Then
            pic1.Left = 0 - pic1.Width
        End If
        pic4.Left = pic4.Left - 5
        If pic4.Right < 0 Then
            pic4.Left = Me.Width
        End If
        pic2.Top = pic2.Top + 5
        If pic2.Top > Me.Height Then
            pic2.Top = 0 - pic2.Height
        End If
        pic3.Top = pic3.Top - 5
        If pic3.Top < 0 Then
            pic3.Top = Me.Height
        End If
        collision(picbullet, pic1)
        collision(picbullet, pic2)
        collision(picbullet, pic3)
        collision(picbullet, pic4)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                picbullet.Left = picbullet.Left + 10
            Case Keys.Left
                picbullet.Left = picbullet.Left - 10
            Case Keys.Up
                picbullet.Top = picbullet.Top - 10
            Case Keys.Down
                picbullet.Top = picbullet.Top + 10

        End Select
    End Sub
    Public Sub collision(a, b)

        If a.left >= b.left - a.width And a.left <= b.left + b.width Then
            If a.top < b.top + b.Height And a.top > b.top - a.Height Then
                b.left = 0 - b.width
                b.top = 0 - b.height
            End If
        End If
    End Sub

End Class
