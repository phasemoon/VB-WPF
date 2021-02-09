Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels

Public Class TabsRootViewModel
    Inherits MvxNavigationViewModel

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)


    End Sub

    Public Property ShowInitialViewModelsCommand As IMvxAsyncCommand
    Public Property ShowTabsRootBCommand As IMvxAsyncCommand

    Private Async Function ShowInitialViewModels() As Task
        Dim tasks = New List(Of Task)()
        tasks.Add(NavigationService.Navigate(Of Tab1ViewModel, String)("test"))
        tasks.Add(NavigationService.Navigate(Of Tab2ViewModel)())
        tasks.Add(NavigationService.Navigate(Of Tab3ViewModel)())
        Await Task.WhenAll(tasks)
    End Function

    Private _itemIndex As Integer
    Public Property ItemIndex As Integer
        Get
            Return _itemIndex
        End Get
        Set(value As Integer)
            If _itemIndex = value Then Return
            _itemIndex = value
            Log.Trace("Tab item changed to {0}", _itemIndex.ToString)
            RaisePropertyChanged(Function() ItemIndex)
        End Set
    End Property

End Class
