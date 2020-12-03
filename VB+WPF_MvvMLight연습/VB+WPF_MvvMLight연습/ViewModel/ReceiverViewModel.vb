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

                [Set](mContentText, "ContentText", value)
                'mContentText = value
                'RaisePropertyChanged("ContentText")
            End Set
        End Property

        Public Sub New()
            Messenger.Default.Register(Of ViewModelMessage)(Me, AddressOf OnThisMessageAction)
        End Sub

        Private Sub OnThisMessageAction(obj As ViewModelMessage)
            ContentText = obj.Text
        End Sub

    End Class
End Namespace


