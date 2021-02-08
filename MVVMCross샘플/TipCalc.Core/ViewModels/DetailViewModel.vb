Imports MvvmCross.ViewModels

Public Class DetailViewModel
    Inherits MvxViewModel(Of DetailNavigationArgs)

    Private _parameter As Integer
    Public Property Parameter As Integer
        Get
            Return _parameter
        End Get
        Set(value As Integer)
            _parameter = value
            RaisePropertyChanged(Function() Parameter)
        End Set
    End Property


    Public Overrides Sub Prepare(_parameter As DetailNavigationArgs)
        'use the parametres here
        Parameter = _parameter.Index
    End Sub

End Class
