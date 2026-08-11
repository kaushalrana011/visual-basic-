Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As New Shape
        s.Area(TextBox1.Text, TextBox2.Text)
        s.Area(TextBox3.Text)
    End Sub
End Class
