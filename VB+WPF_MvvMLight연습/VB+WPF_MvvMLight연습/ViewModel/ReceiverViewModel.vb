Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Messaging

Namespace ViewModel
    Public Class ReceiverViewModel
        Inherits ViewModelBase
        'Inherits ObservableObject

        Private mContentText As String
        Public Property ContentText As String
            Get
                Return mContentText
            End Get
            Set(value As String)

                [Set]("ContentText", mContentText, value)
                'mContentText = value
                'RaisePropertyChanged("ContentText")
            End Set
        End Property

        Public Sub New()
            Messenger.Default.Register(Of ViewModelMessage)(Me, AddressOf OnThisMessageAction)
            MessengerInstance.Register(Of PropertyChangedMessage(Of String))(Me, AddressOf SenderViewModelChanged)
        End Sub

        Private Sub SenderViewModelChanged(propertyDetails As PropertyChangedMessage(Of String))
            If propertyDetails.PropertyName = "TextBoxText" Then
                Dim tmp As String = propertyDetails.NewValue
            End If
        End Sub

        Private Sub OnThisMessageAction(obj As ViewModelMessage)
            ContentText = obj.Text
        End Sub

    End Class
End Namespace


