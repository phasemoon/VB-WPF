
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels
Public Class NestedModalViewModel
    Inherits MvxNavigationViewModel

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        CloseCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me))
    End Sub

    Public Property CloseCommand As IMvxAsyncCommand
End Class
