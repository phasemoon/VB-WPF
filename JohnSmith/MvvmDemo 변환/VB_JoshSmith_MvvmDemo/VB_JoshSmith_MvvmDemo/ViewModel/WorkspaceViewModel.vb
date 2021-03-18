Public Class WorkspaceViewModel
    Inherits ViewModelBase

    Private _closeCommand As RelayCommand

    Public ReadOnly Property ColseCommand As ICommand
        Get
            If _closeCommand Is Nothing Then _closeCommand = New RelayCommand(Sub(param) OnRequestClose())
            Return _closeCommand
        End Get
    End Property

    Public Event RequestClose As EventHandler

    Private Sub OnRequestClose()
        Dim handler As EventHandler = RequestCloseEvent
        If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
    End Sub
End Class
