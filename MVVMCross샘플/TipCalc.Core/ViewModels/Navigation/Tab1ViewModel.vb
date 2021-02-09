Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels
Imports MvvmCross.Presenters.Hints
Public Class Tab1ViewModel
    Inherits MvxNavigationViewModel(Of String)

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        OpenChildCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of ChildViewModel))

        OpenModalCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of ModalViewModel))

        'OpenNavModalCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of ModalNavViewModel))

        'CloseCommand = New MvxApplication(Async Function() Await NavigationService.Close(Me))
        'OpenTab2Command = New MvxAsyncCommand(Async Function() Await NavigationService.ChangePresentation(New MvxPagePresentationHint(GetType(tab2viewmodel))))

    End Sub

    Public Overrides Async Function Initialize() As Task
        Await Task.Delay(3000)
    End Function

    Dim para As String
    Public Overrides Sub Prepare(parameter As String)
        para = parameter
    End Sub

    Public Overrides Sub ViewAppeared()
        MyBase.ViewAppeared()
    End Sub

    Public Property OpenChildCommand As IMvxAsyncCommand
    Public Property OpenModalCommand As IMvxAsyncCommand
    Public Property OpenNavModalCommand As IMvxAsyncCommand
    Public Property OpenTab2Command As IMvxAsyncCommand
    Public Property CloseCommand As IMvxAsyncCommand
End Class
