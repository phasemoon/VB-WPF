Public Class User

    Public Sub New(vName As String, vRating As Integer, vMemberSince As DateTime)
        Name = vName
        Rating = vRating
        MemberSince = vMemberSince
    End Sub

#Region "Property Getters and setters"

    Public ReadOnly Property Name As String
    Public Property Rating As Integer
    Public ReadOnly Property MemberSince As DateTime

#End Region

End Class
