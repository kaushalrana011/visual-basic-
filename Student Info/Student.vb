Public Class Student
    Dim RollNo As Integer
    Dim Name As String
    Dim Course As String
    Public Sub GetData(r As Integer, n As String, c As String)
        RollNo = r
        Name = n
        Course = c
    End Sub
    Public Sub ShowData()
        MsgBox("Roll No : " & RollNo & vbCrLf &
               "Name : " & Name & vbCrLf &
               "Course : " & Course)
    End Sub
End Class
