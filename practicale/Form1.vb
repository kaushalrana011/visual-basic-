Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4, s5 As Integer
        Dim total As Integer
        Dim percentage As Double
        Dim grade As String
        Dim result As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        s3 = TextBox3.Text
        s4 = TextBox4.Text
        s5 = TextBox5.Text
        total = s1 + s2 + s3 + s4 + s5
        percentage = total / 5

        If percentage >= 80 Then
            grade = "A"
        ElseIf percentage >= 60 Then
            grade = "B"
        ElseIf percentage >= 40 Then
            grade = "C"
        Else
            grade = "F"
        End If

        If percentage >= 40 Then
            result = "Pass"
        Else
            result = "Fail"
        End If

        MsgBox("Total Marks Obtained = " & total & vbCrLf &
                "Percentage = " & percentage & "%" & vbCrLf &
                "Grade = " & grade & vbCrLf &
                "Result = " & result)




    End Sub
End Class
