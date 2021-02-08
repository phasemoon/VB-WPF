Imports MvvmCross.ViewModels
'Imports TipCalc.Core.Services
Imports System.Threading.Tasks
Imports MvvmCross.Navigation
Imports MvvmCross.Commands

Public Class MasterViewModel
    Inherits MvxViewModel

    Private ReadOnly _navigationService As IMvxNavigationService


    Public Sub New(navigationService As IMvxNavigationService)
        _navigationService = navigationService

        NavigateCommand = New MvxAsyncCommand(Function() _navigationService.Navigate(Of DetailViewModel, DetailNavigationArgs)(New DetailNavigationArgs With {
    .Index = 2
}))

    End Sub
    Public Property NavigateCommand As MvxAsyncCommand

End Class
