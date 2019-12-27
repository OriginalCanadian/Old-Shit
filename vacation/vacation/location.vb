Module locat

    Function locate(a As String)
        Dim b As Integer
        Dim c As Integer
        b = Mid(a, 5, 1)
        c = 1000 * b
        Return (c)
    End Function
    Function total(c As Integer, d As Integer)
        Dim f As Integer
        Dim h As Integer
        f = c + d
        h = f * 200
        Return (h)
    End Function
End Module
