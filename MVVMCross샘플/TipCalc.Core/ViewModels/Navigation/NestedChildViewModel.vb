Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.Presenters.Hints
Imports MvvmCross.ViewModels

Public Class NestedChildViewModel
    Inherits MvxNavigationViewModel

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        CloseCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me))
        PopToChildCommand = New MvxCommand(Function() NavigationService.ChangePresentation(New MvxPopPresentationHint(GetType(ChildViewModel))))
        PopToRootCommand = New MvxCommand(Function() NavigationService.ChangePresentation(New MvxPopToRootPresentationHint()))
        RemoveCommand = New MvxCommand(Function() NavigationService.ChangePresentation(New MvxRemovePresentationHint(GetType(SecondChildViewModel))))

    End Sub

    Public Property CloseCommand As IMvxAsyncCommand
    Public Property PopToChildCommand As IMvxAsyncCommand
    Public Property PopToRootCommand As IMvxAsyncCommand
    Public Property RemoveCommand As IMvxAsyncCommand

End Class
