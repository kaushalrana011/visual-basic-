Public Class BankAccount
    Dim Balance As Double = 10000
    Public Sub Deposit(amount As Double)
        Balance = Balance + amount
        MsgBox("Amount Deposited")
    End Sub
    Public Sub Withdraw(amount As Double)
        Balance = Balance - amount
        MsgBox("Amount Withdrawn")
    End Sub
    Public Sub ShowBalance()
        MsgBox("Current Balance = " & Balance)
    End Sub
End Class
