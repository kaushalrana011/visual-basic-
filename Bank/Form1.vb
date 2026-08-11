Public Class Form1
    Dim b As New BankAccount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b.Deposit(TextBox1.Text)
    End Sub

    Private Sub Buttton2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.Withdraw(TextBox1.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        b.ShowBalance()

    End Sub
End Class
