Imports MvvmCross.ViewModels
'Imports TipCalc.Core.Services
Imports System.Threading.Tasks
Imports MvvmCross.Navigation
Imports MvvmCross.Logging
Imports MvvmCross.Commands

Public Class MainViewModel
    Inherits MvxNavigationViewModel

    Private _bindableText As String = "I'm Bound"

    Private _counter As Integer = 2

    Public Sub New(logProvider As IMvxLogProvider, navigationService As IMvxNavigationService)
        MyBase.New(logProvider, navigationService)

        'ShowChildCommand = New MvxAsyncCommand(Async Function() Await na)
    End Sub

    Public ReadOnly Property ShowChildCommand As IMvxCommand
    Public ReadOnly Property ShowModalCommand As IMvxCommand

End Class
