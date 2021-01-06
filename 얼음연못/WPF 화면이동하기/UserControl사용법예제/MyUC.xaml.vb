Public Class MyUC
    Private _containerData As MyUCContainer
    Public Property ContainerData As MyUCContainer
        Get
            Return _containerData
        End Get
        Set(value As MyUCContainer)
            _containerData = value
            nameTb1.Text = ContainerData.name
            nameTb2.Text = ContainerData.age
        End Set
    End Property
End Class

Public Class MyUCContainer
    Public Property name As String
    Public Property age As Integer
    Public Sub New(name As String, age As Integer)
        Me.name = name
        Me.age = age
    End Sub
End Class