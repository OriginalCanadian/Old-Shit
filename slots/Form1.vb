Public Class Form1
    Dim a, b, c, d, e2, f, g, h, i As Integer
    Private Sub test2_Tick(sender As Object, e As EventArgs) Handles test2.Tick
        If d = 1 AndAlso e2 = 1 AndAlso f = 1 Then
            lblmoney.Text = lblmoney.Text + 100
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If d = 2 AndAlso e2 = 2 AndAlso f = 2 Then
            lblmoney.Text = lblmoney.Text + 200
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If d = 3 AndAlso e2 = 3 AndAlso f = 3 Then
            lblmoney.Text = lblmoney.Text + 300
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If d = 4 AndAlso e2 = 4 AndAlso f = 4 Then
            lblmoney.Text = lblmoney.Text + 400
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If d = 5 AndAlso e2 = 5 AndAlso f = 5 Then
            lblmoney.Text = lblmoney.Text + 500
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If a = 5 AndAlso e2 = 5 AndAlso i = 5 Then
            lblmoney.Text = lblmoney.Text + 500
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If a = 4 AndAlso e2 = 4 AndAlso i = 4 Then
            lblmoney.Text = lblmoney.Text + 400
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If a = 3 AndAlso e2 = 3 AndAlso i = 3 Then
            lblmoney.Text = lblmoney.Text + 300
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If a = 2 AndAlso e2 = 2 AndAlso i = 2 Then
            lblmoney.Text = lblmoney.Text + 200
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If a = 1 AndAlso e2 = 1 AndAlso i = 1 Then
            lblmoney.Text = lblmoney.Text + 100
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If c = 5 AndAlso e2 = 5 AndAlso g = 5 Then
            lblmoney.Text = lblmoney.Text + 500
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If c = 4 AndAlso e2 = 4 AndAlso g = 4 Then
            lblmoney.Text = lblmoney.Text + 400
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If c = 3 AndAlso e2 = 3 AndAlso g = 3 Then
            lblmoney.Text = lblmoney.Text + 300
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If c = 2 AndAlso e2 = 2 AndAlso g = 2 Then
            lblmoney.Text = lblmoney.Text + 200
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        If c = 1 AndAlso e2 = 1 AndAlso g = 1 Then
            lblmoney.Text = lblmoney.Text + 100
            My.Computer.Audio.Play(My.Resources.win,
     AudioPlayMode.WaitToComplete)
        End If
        test2.Enabled = False
    End Sub
    Private Sub test_Tick(sender As Object, e As EventArgs) Handles test.Tick
        test.Enabled = False
        spin.Enabled = False
    End Sub
    Private Sub spin_Tick(sender As Object, e As EventArgs) Handles spin.Tick
        random(a, b, c, d, e2, f, g, h, i)
        pic1.Image = My.Resources.ResourceManager.GetObject("i" & a)
        pic2.Image = My.Resources.ResourceManager.GetObject("i" & b)
        pic3.Image = My.Resources.ResourceManager.GetObject("i" & c)
        pic4.Image = My.Resources.ResourceManager.GetObject("i" & d)
        pic5.Image = My.Resources.ResourceManager.GetObject("i" & e2)
        pic6.Image = My.Resources.ResourceManager.GetObject("i" & f)
        pic7.Image = My.Resources.ResourceManager.GetObject("i" & g)
        pic8.Image = My.Resources.ResourceManager.GetObject("i" & h)
        pic9.Image = My.Resources.ResourceManager.GetObject("i" & i)
    End Sub
    Dim a1, b1, c1, d1, e1, f1, g1, h1, i1 As Integer
    Private Sub btnspin_Click(sender As Object, e As EventArgs) Handles btnspin.Click
        lblmoney.Text = lblmoney.Text - 100
        spin.Enabled = True
        test.Enabled = True
        test2.Enabled = True
    End Sub
    Public Sub random(a1, b1, c1, d1, e1, f1, g1, h1, i1)
        a1 = (Rnd(10) * 4) + 1
        b1 = (Rnd(10) * 4) + 1
        c1 = (Rnd(10) * 4) + 1
        d1 = (Rnd(10) * 4) + 1
        e1 = (Rnd(10) * 4) + 1
        f1 = (Rnd(10) * 4) + 1
        g1 = (Rnd(10) * 4) + 1
        h1 = (Rnd(10) * 4) + 1
        i1 = (Rnd(10) * 4) + 1
        a = a1
        b = b1
        c = c1
        d = d1
        e2 = e1
        f = f1
        g = g1
        h = h1
        i = i1
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
