

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As New Student
        s.GetData(TextBox1.Text,
                  TextBox2.Text,
                  TextBox3.Text)
        s.ShowData()
    End Sub
End Class
