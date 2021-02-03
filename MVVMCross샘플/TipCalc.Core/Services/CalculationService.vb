Public Class CalculationService
    Implements ICalculationService

    Public Function TipAmount(subTotal As Double, generosity As Integer) As Double Implements ICalculationService.TipAmount
        Return subTotal * CDbl(generosity) / 100
    End Function
End Class
