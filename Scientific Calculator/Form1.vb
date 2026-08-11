Public Class Form1
    Dim d1, d2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        MsgBox("Addition is : " & (d1 + d2))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        MsgBox("Subtraction is : " & (d1 - d2))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        MsgBox("Multiplication is : " & (d1 * d2))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        MsgBox("Division is : " & (d1 / d2))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        MsgBox("Modulus is : " & (d1 Mod d2))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        MsgBox("Power is : " & (d1 ^ d2))
    End Sub
End Class
