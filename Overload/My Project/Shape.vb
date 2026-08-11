Public Class Shape
    Public Sub Area(length As Double, breadth As Double)
        MsgBox("Area of Rectangle = " & (length * breadth))
    End Sub
    Public Sub Area(side As Double)
        MsgBox("Area of Square = " & (side * side))
    End Sub

End Class
