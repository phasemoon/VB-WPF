Imports MvvmCross.ViewModels
'Imports TipCalc.Core.Services
Imports System.Threading.Tasks
Imports MvvmCross.Navigation
Imports MvvmCross.Commands
Imports MvvmCross.Logging

Public Class RootViewModel
    Inherits MvxNavigationViewModel

    Private ReadOnly _navigationService As IMvxNavigationService

    Private ReadOnly Property _mvxViewModelLoader As IMvxViewModelLoader

    Private _counter As Integer = 2

    Private _welcomeText As String = "Default welcome"



    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService, mvxViewModelLoader As IMvxViewModelLoader)
        MyBase.New(logProvider, mNavigationService)

        _mvxViewModelLoader = mvxViewModelLoader
        'Try
        '    Dim messenger = Mvx.IoCProvider.Resolve(Of IMvxMessenger)
        '    Dim str = messenger.ToString
        'Catch ex As Exception
        '    Console.WriteLine(ex.ToString)
        'End Try

        ShowChildCommand = New MvxAsyncCommand(Async Function()
                                                   Dim result = Await NavigationService.Navigate(Of ChildViewModel, SampleModel, SampleModel)(New SampleModel With {
                                                   .Message = "Hey",
                                                   .Value = 1.23D
                                                   })
                                                   Dim testIfReturn = result
                                               End Function)

        'ShowWindowCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of WindowViewModel))

    End Sub

    Public Property MyTask As MvxNotifyTask
    Public ReadOnly Property ShowChildCommand As IMvxCommand
    Public ReadOnly Property ShowModalCommand As IMvxCommand
    Public ReadOnly Property ShowModalNavCommand As IMvxCommand
    Public ReadOnly Property ShowCustumBindingCommand As IMvxCommand
    Public ReadOnly Property ShowTabsCommand As IMvxCommand
    Public ReadOnly Property ShowPagesCommand As IMvxCommand

    Private _isVisible As Boolean
    Public Property IsVisible As Boolean
        Get
            Return _isVisible
        End Get
        Set(value As Boolean)
            SetProperty(_isVisible, value)
        End Set
    End Property

    Public Property WelcomeText As String
        Get
            Return _welcomeText
        End Get
        Set(value As String)
            ShouldLogInpc(True)
            SetProperty(_welcomeText, value)
            ShouldLogInpc(False)
        End Set
    End Property

    Public Overrides Async Function Initialize() As Task
        Log.Warn(Function() "Testing log")

        Await MyBase.Initialize
    End Function


End Class
