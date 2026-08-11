Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4, s5 As Integer
        Dim total As Integer
        Dim per As Double
        Dim grade, result As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        s3 = TextBox3.Text
        s4 = TextBox4.Text
        s5 = TextBox5.Text
        total = s1 + s2 + s3 + s4 + s5
        per = total / 5
        If per >= 80 Then
            grade = "A"
        ElseIf per >= 60 Then
            grade = "B"
        ElseIf per >= 40 Then
            grade = "C"
        Else
            grade = "F"
        End If

        If per >= 40 Then
            result = "Pass"
        Else
            result = "Fail"
        End If
        MsgBox("Total Marks Obtained = " & total & vbCrLf &
               "Percentage = " & per & "%" & vbCrLf &
               "Grade = " & grade & vbCrLf &
               "Result = " & result)
    End Sub
End Class
