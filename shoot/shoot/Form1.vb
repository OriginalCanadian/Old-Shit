Public Class Form1
    Dim c As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                tmrleft.Enabled = True
                tmrright.Enabled = False
            Case Keys.D
                tmrleft.Enabled = False
                tmrright.Enabled = True
            Case Keys.Space
                tmrfollow.Enabled = False
                tmrfire.Enabled = True
        End Select

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.A
                tmrleft.Enabled = False
            Case Keys.D
                tmrright.Enabled = False
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c = 0
    End Sub

    Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
        picgun.Left = picgun.Left - 5
        If picgun.Left < 0 Then
            picgun.Left = 15
        End If
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        picgun.Left = picgun.Left + 5
        If picgun.Right > Me.Width Then
            picgun.Left = Me.Width - (20 + picgun.Width)
        End If
    End Sub

    Private Sub tmrfollow_Tick(sender As Object, e As EventArgs) Handles tmrfollow.Tick
        picbullet.Left = picgun.Left + ((picgun.Width / 2) - (picbullet.Width / 2))
        picbullet.Top = picgun.Top
    End Sub

    Private Sub tmrfire_Tick(sender As Object, e As EventArgs) Handles tmrfire.Tick
        picbullet.Top = picbullet.Top - 25
        If picbullet.Top < 0 Then
            tmrfire.Enabled = False
            tmrfollow.Enabled = True
        End If
    End Sub
    Public Sub collision(a, b)

        If a.left >= b.left - a.width And a.left <= b.left + b.width Then
            If a.top < b.top + b.Height And a.top > b.top - a.Height Then
                b.left = 0 - b.width
                b.top = 0 - b.height
                tmrfire.Enabled = False
                tmrfollow.Enabled = True
                c = 1 + c
                lblscore.Text = c
            End If
        End If
    End Sub
    Private Sub tmrcollide_Tick(sender As Object, e As EventArgs) Handles tmrcollide.Tick
        collision(picbullet, pic4)
        collision(picbullet, pic1)
        collision(picbullet, pic2)
        collision(picbullet, pic3)
    End Sub

    Private Sub tmrtarget_Tick(sender As Object, e As EventArgs) Handles tmrtarget.Tick
        pic1.Left = pic1.Left + 5
        If pic1.Left > Me.Width Then
            pic1.Left = 0 - pic1.Width
        End If
        pic2.Left = pic2.Left - 10
        If pic2.Right < 0 Then
            pic2.Left = Me.Width
        End If
        pic3.Left = pic3.Left + 15
        If pic3.Left > Me.Width Then
            pic3.Left = 0 - pic1.Width
        End If
        pic4.Left = pic4.Left - 20
        If pic4.Right < 0 Then
            pic4.Left = Me.Width
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
