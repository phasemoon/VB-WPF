Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels
Public Class SecondChildViewModel
    Inherits MvxNavigationViewModel

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        ShowNestedChildCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of nestedchildviewmodel))

        CloseCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me))

    End Sub

    Public Property ShowNestedChildCommand As IMvxAsyncCommand
    Public Property CloseCommand As IMvxAsyncCommand

End Class
