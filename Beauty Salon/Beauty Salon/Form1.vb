Public Class Form1
    Dim appPath As String = Application.StartupPath()
    Dim c As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnfile.Click
        FolderBrowserDialog1.ShowDialog()
        c = FolderBrowserDialog1.SelectedPath
        txtpath.Text = c & "\" & txtcustomer.Text & ".txt"
        btnload.Enabled = True
        Btnsave.Enabled = True
        txtnote.Enabled = True
        txtemail.Enabled = True
        txtname.Enabled = True
        txtphone.Enabled = True
        txtcity.Enabled = True
        txtaddress.Enabled = True
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Len(txtname.Text) > 0 Then
            If My.Computer.FileSystem.FileExists(txtpath.Text) Then
                My.Computer.FileSystem.DeleteFile(txtpath.Text)
            End If

            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtcustomer.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtname.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtaddress.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtcity.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtphone.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtemail.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(txtpath.Text, txtnote.Text & vbCrLf, True)
        Else
            MsgBox("a value has been left blank")
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtpath.Text = appPath
        txtpath.Enabled = False
        btnfile.Enabled = False
        btnload.Enabled = False
        Btnsave.Enabled = False
        txtnote.Enabled = False
        txtemail.Enabled = False
        txtname.Enabled = False
        txtphone.Enabled = False
        txtcity.Enabled = False
        txtaddress.Enabled = False
    End Sub

    Private Sub txtcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtcustomer.TextChanged
        If Len(txtcustomer.Text) > 0 Then
            btnfile.Enabled = True
            txtpath.Enabled = True
        Else
            txtpath.Enabled = False
            btnfile.Enabled = False
            btnload.Enabled = False
            Btnsave.Enabled = False
            txtnote.Enabled = False
            txtemail.Enabled = False
            txtname.Enabled = False
            txtphone.Enabled = False
            txtcity.Enabled = False
            txtaddress.Enabled = False
        End If
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        If My.Computer.FileSystem.FileExists(txtpath.Text) Then
            Dim lines As String() = IO.File.ReadAllLines(txtpath.Text)
            txtname.Text = lines(1)
            txtaddress.Text = lines(2)
            txtcity.Text = lines(3)
            txtphone.Text = lines(4)
            txtemail.Text = lines(5)
            txtnote.Text = lines(6)
        End If

    End Sub

End Class
