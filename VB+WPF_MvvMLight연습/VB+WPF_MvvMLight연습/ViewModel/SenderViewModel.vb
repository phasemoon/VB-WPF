Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight.Messaging

Namespace ViewModel
    Public Class SenderViewModel
        Inherits ViewModelBase

        Public Property OnClickCommand As RelayCommand

        Private mTextboxText As String
        Public Property TextBoxText As String
            Get
                Return mTextboxText
            End Get
            Set(value As String)
                [Set]("TextboxText", mTextboxText, value)

                'mTextboxText = value
                'RaisePropertyChanged("TextboxText")
            End Set
        End Property

        Public Sub New()
            'OnClickCommand = New RelayCommand(AddressOf OnClickCommandAction)
            'C#의 Null에 일대일로 대치되는 VB.NET가 없는것 같다..
            OnClickCommand = New RelayCommand(AddressOf OnClickCommandAction, False)

        End Sub

        Private Sub OnClickCommandAction()
            Dim viewModelMessage = New ViewModelMessage With {.Text = TextBoxText}

            Messenger.Default.Send(viewModelMessage)
        End Sub

    End Class
End Namespace

