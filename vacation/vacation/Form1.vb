Public Class Form1
    Dim place As String
    Dim placeprice, b, c, totalprice As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ' checked which checkbox is checked
        For Each Ctrl In GroupBox1.Controls
            If Ctrl.checked Then place = Ctrl.name
        Next
        placeprice = locat.locate(place)
        If chk1.Checked = True Then
            b = 1
        Else
            b = 0
        End If
        If chk2.Checked = True Then
            c = 1
        Else
            c = 0
        End If
        totalprice = locat.total(c, b)
        lblprice.Text = totalprice + placeprice
    End Sub
End Class
