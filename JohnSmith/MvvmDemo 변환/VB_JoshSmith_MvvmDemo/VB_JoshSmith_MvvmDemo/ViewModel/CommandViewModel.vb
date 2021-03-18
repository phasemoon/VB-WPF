Imports System
Imports System.Windows.Input

Public Class CommandViewModel
    Inherits ViewModelBase

    Private _command As ICommand

    Public Sub New(displayName As String, command As ICommand)
        If command Is Nothing Then Throw New ArgumentException("command")
        MyBase.DisplayName = displayName
        Me.Command = command
    End Sub

    Public Property Command As ICommand
        Get
            Return _command
        End Get
        Set(value As ICommand)
            _command = value
        End Set
    End Property
End Class
