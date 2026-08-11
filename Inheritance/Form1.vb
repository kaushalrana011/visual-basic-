Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Manager

        m.Name = TextBox1.Text
        m.Salary = TextBox2.Text

        m.ShowData()

    End Sub
End Class
