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

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        Throw New NotImplementedException()
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Throw New NotImplementedException()
    End Function
End Class
