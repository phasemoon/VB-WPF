Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels

Public Class WindowChildViewModel : Inherits MvxNavigationViewModel(Of WindowChildParam)
    Private _param As WindowChildParam

    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)
    End Sub

    Public ReadOnly Property ParentNo As Integer
        Get
            Return _param.ParentNo
        End Get
    End Property

    Public ReadOnly Property Text As String
        Get
            Return $"I'm No.{_param.ChildNo}. My parent is No.{_param.ParentNo}"
        End Get
    End Property

    Public ReadOnly Property CloseCommand As MvxAsyncCommand
        Get
            Return New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me))
        End Get
    End Property


    Public Overrides Sub Prepare(parameter As WindowChildParam)
        _param = parameter
    End Sub
End Class
