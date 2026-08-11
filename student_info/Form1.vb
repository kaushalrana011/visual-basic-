Public Class Form1
    Dim Roll, Sem As Integer
    Dim Name, Email, Branch As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Roll = TextBox1.Text
        Name = TextBox2.Text
        Branch = TextBox3.Text
        Sem = TextBox4.Text
        Email = TextBox5.Text

        MsgBox("Student Information" & vbCrLf &
               "Roll No : " & Roll & vbCrLf &
               "Name :" & Name & vbCrLf &
               "Branch : " & Branch & vbCrLf &
               "Semester : " & Sem & vbCrLf &
               "Email : " & Email)
    End Sub
End Class
