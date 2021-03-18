Imports System
Imports System.Diagnostics
Imports System.Windows.Input

Public Class RelayCommand
    Implements ICommand

    ReadOnly _execute As Action(Of Object)
    ReadOnly _canExecute As Predicate(Of Object)

    Public Sub New(execute As Action(Of Object))
        Me.New(execute, Nothing)

    End Sub

    Public Sub New(execute As Action(Of Object), ByVal canExecute As Predicate(Of Object))
        If execute Is Nothing Then Throw New ArgumentException("execute")
        _execute = execute
        _canExecute = canExecute
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        _execute(parameter)
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return If(_canExecute Is Nothing, True, _canExecute(parameter))
    End Function
End Class
