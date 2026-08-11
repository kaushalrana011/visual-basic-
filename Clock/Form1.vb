Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateClockDisplay()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            UpdateClockDisplay()
        End Sub

        Private Sub UpdateClockDisplay()
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    End Class


