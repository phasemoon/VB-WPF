﻿Imports MvvmCross.ViewModels
'Imports TipCalc.Core.Services
Imports System.Threading.Tasks
Imports MvvmCross.Navigation
Imports MvvmCross.Commands

Public Class FirstViewModel
    Inherits MvxViewModel

    Private ReadOnly _navigationService As IMvxNavigationService

    Public Sub New(navigationService As IMvxNavigationService)
        _navigationService = navigationService

        NavigateCommand = New MvxAsyncCommand(Function() _navigationService.Navigate(Of SecondViewModel))
        NavigateCommand2 = New MvxAsyncCommand(Function() _navigationService.Navigate(Of TipViewModel))

    End Sub

    Public Property NavigateCommand As MvxAsyncCommand

    Public Property NavigateCommand2 As MvxAsyncCommand

End Class
