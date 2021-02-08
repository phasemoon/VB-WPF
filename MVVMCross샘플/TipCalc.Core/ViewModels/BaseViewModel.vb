Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels

Public Class BaseViewModel
    Inherits MvxNavigationViewModel

    Public Sub New(logProvider As IMvxLogProvider, navigationService As IMvxNavigationService)
        MyBase.New(logProvider, navigationService)
    End Sub

End Class
