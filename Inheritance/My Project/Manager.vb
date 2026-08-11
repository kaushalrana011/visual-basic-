Public Class Manager
    Inherits Employee
    Public Sub ShowData()
        MsgBox("Name : " & Name & vbCrLf &
               "Salary : " & Salary)
    End Sub
End Class
