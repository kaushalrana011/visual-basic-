Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog2.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog2.FileName)
    End Sub


End Class
