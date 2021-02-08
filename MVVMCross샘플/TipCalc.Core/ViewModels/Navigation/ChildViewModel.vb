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
            SetProperty(Of String)(_brokenTextValue, value)
        End Set
    End Property
    Public Property AnotherBrokentTextValue As String
        Get
            Return _anotherBrokenTextValue
        End Get
        Set(value As String)
            SetProperty(_anotherBrokenTextValue, value)
        End Set
    End Property

    Private _parameter As SampleModel
    Private _brokenTextValue As String
    Private _anotherBrokenTextValue As String

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        CloseCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me, New SampleModel With {
        .Message = "This returned correctly", .Value = 5.67D
        }))

        ShowSecondChildCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Navigate(Of SecondChildViewModel))

    End Sub

    Public Property CloseCommand As IMvxAsyncCommand
    Public Property ShowSecondChildCommand As IMvxAsyncCommand
    Public Property ShowRootCommand As IMvxAsyncCommand

    Public Overrides Sub Prepare()
        MyBase.Prepare()
    End Sub

    Public Overrides Sub Prepare(parameter As SampleModel)
        _parameter = parameter
    End Sub

    Public Overrides Sub ViewAppeared()
        MyBase.ViewAppeared()

        Task.Run(Async Function()
                     Await Task.Delay(1000)
                     BrokenTextValue = "This will throw exception in UI layer"
                     AnotherBrokentTextValue = "This will throw exception in page"
                 End Function)
    End Sub

End Class
