Public Class Bid
    Public Sub New(vAmount As Integer, vBidder As User)
        Amount = vAmount
        Bidder = vBidder
    End Sub

#Region "Property Getters and Setters"

    Public Property Amount As Integer

    Public Property Bidder As User

#End Region
End Class
