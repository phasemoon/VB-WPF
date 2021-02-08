Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels


Public Class ChildViewModel
    Inherits MvxNavigationViewModel(Of SampleModel, SampleModel)

    Public Property BrokenTextValue As String
        Get
            Return _brokenTextValue
        End Get
        Set(value As String)
            SetProperty(Of String)(_anotherBrokenTextValue, value)
        End Set
    End Property

    Private _parameter As SampleModel
    Private _brokenTextValue As String
    Private _anotherBrokenTextValue As String

    Public Sub New(logProvider As IMvxLogProvider, navigationService As IMvxNavigationService)
        MyBase.New(logProvider, navigationService)


    End Sub

    Public Property CloseCommand As IMvxAsyncCommand
    Public Property ShowSecomdChildCommand As IMvxAsyncCommand
    Public Property ShowRootCommand As IMvxAsyncCommand

    Public Overrides Sub Prepare(parameter As SampleModel)
        Throw New NotImplementedException()
    End Sub
End Class
