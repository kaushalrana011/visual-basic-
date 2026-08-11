Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim basic, gross, tax, pf, net As Double
        basic = TextBox1.Text
        gross = basic + (basic * 20 / 100)
        tax = gross * 10 / 100
        pf = basic * 12 / 100
        net = gross - tax - pf
        MsgBox("Gross Salary = " & gross & vbCrLf &
               "Tax = " & tax & vbCrLf &
               "PF = " & pf & vbCrLf &
               "Net Salary = " & net)
    End Sub
End Class
