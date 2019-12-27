Public Class Form1

        Dim stri As String
        Dim stright As String
        Dim stmid As String
        Dim howmany As Integer
        Dim reverse As String
        Dim reversed As String
        Dim a As String
        Dim b As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        stri = txtinput.Text
        lbloutput.Text = lbloutput.Text & vbCrLf & (UCase(stri))
        lbloutput.Text = lbloutput.Text & vbCrLf & (LCase(stri))
        lbloutput.Text = lbloutput.Text & vbCrLf & (Replace(stri, "e", "x"))
        stright = Microsoft.VisualBasic.Right(stri, 5)
        lbloutput.Text = lbloutput.Text & vbCrLf & (stright)
        stmid = Mid(stri, 3, 6)
        lbloutput.Text = lbloutput.Text & vbCrLf & (stmid)
        howmany = UBound(Split(stri, txtletter.Text))
        lbloutput.Text = lbloutput.Text & vbCrLf & (howmany)
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        lbloutput.Text = ""
        txtinput.Text = ""
    End Sub

    Private Sub btnreverse_Click(sender As Object, e As EventArgs) Handles btnreverse.Click
        reverse = InputBox("Input sentence to be reversed", "reverse")
        reversed = (StrReverse(reverse))
        MsgBox(reversed, , "reverse")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Checks if your key is long enough, if not it returns a message box
        If Len(txtplain.Text) > Len(txtpad.Text) Then MsgBox("Your key is not long enough", , "Error")
        Dim c As String
        Dim s As String
        Dim x As Integer
        c = txtplain.Text
        x = Len(c)
        Dim y As Integer
        For y = 1 To x
            'assigns a number to a character. Adds/subtracts (depending on encryption or decryption) the key and plain text value to get your encrypted code.
            If Len(txtplain.Text) < Len(txtpad.Text) Then s = s & Chr((Asc(Mid(txtplain.Text, y, 1)) - Asc("A") + Asc("k") - Asc(Mid(txtpad.Text, y, 1)) Mod 26 + Asc("A")))
        Next y
        txtencrypted.Text = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Len(txtencrypted.Text) > Len(txtpad.Text) Then MsgBox("Your key is not long enough", , "Error")
        Dim d As String
        Dim k As String
        Dim h As Integer
        d = txtencrypted.Text
        h = Len(d)
        Dim j As Integer
        For j = 1 To h
            If Len(txtplain.Text) < Len(txtpad.Text) Then k = k & Chr((Asc(Mid(txtencrypted.Text, j, 1)) + Asc("A") - Asc("k") + Asc(Mid(txtpad.Text, j, 1)) Mod 26 - Asc("A")))
        Next j
        txtplain.Text = k
    End Sub

    Private Sub txtpad_TextChanged(sender As Object, e As EventArgs) Handles txtpad.TextChanged
        'counts how many more characters the key requires
        Dim v As Integer
        v = Len(txtplain.Text) - Len(txtpad.Text)
        Lblcharacter.Text = "Characters Required: " & v
    End Sub

    Private Sub txtplain_TextChanged(sender As Object, e As EventArgs) Handles txtplain.TextChanged
        Dim f As Integer
        f = Len(txtplain.Text) - Len(txtpad.Text)
        Lblcharacter.Text = "Characters Required: " & f
    End Sub
End Class
