Public Class Form1
    Function Fact(n As Integer) As Integer
        If n = 0 Then
            Return 1
        Else
            Return n * Fact(n - 1)
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text
        MsgBox("Factorial = " & Fact(n))
    End Sub
    Function Fib(n As Integer) As Integer
        If n = 0 Then
            Return 0
        ElseIf n = 1 Then
            Return 1
        Else
            Return Fib(n - 1) + Fib(n - 2)
        End If
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Integer
        Dim i As Integer
        Dim s As String = ""

        n = TextBox1.Text
        For i = 0 To n - 1
            s = s & Fib(i) & " "
        Next
        MsgBox("Fibonacci Series :" & vbCrLf & s)

    End Sub
    End Class
