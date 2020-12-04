

Namespace ViewModel
    Public Class MessageViewModel
        'Public Property MessageText

        Public Property DisplayMessageCommand As MessageCommand

        Public Sub New()
            DisplayMessageCommand = New MessageCommand(AddressOf DisplayMessage)
        End Sub

        'Public Sub DisplayMessage()
        '    MessageBox.Show(MessageText)
        'End Sub

        Public Sub DisplayMessage(message As String)
            MessageBox.Show(message)
        End Sub
    End Class

End Namespace
