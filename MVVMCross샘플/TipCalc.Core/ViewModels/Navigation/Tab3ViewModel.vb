Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels
Imports MvvmCross.Presenters.Hints
Public Class Tab3ViewModel
    Inherits MvxNavigationViewModel


    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)
    End Sub

End Class
