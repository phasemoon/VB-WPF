Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels
Public Class ModalViewModel
    Inherits MvxNavigationViewModel

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        'ShowTabsCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of TabsRootViewModel)())

        CloseCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me))

        ShowNestedModalCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of NestedModalViewModel)())
    End Sub

    Public Overrides Function Initialize() As Task
        Return MyBase.Initialize()
    End Function

    Public Sub Init()

    End Sub

    Public Overrides Sub Start()
        MyBase.Start()
    End Sub

    Public Property ShowTabsCommand As IMvxAsyncCommand
    Public Property CloseCommand As IMvxAsyncCommand
    Public Property ShowNestedModalCommand As IMvxAsyncCommand
End Class
