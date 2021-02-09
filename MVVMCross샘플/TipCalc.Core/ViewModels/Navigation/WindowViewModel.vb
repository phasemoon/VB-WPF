Imports System.Threading.Tasks
Imports MvvmCross.Commands
Imports MvvmCross.Logging
Imports MvvmCross.Navigation
Imports MvvmCross.ViewModels

Public Class WindowChildParam
    Public Property ParentNo As Integer
    Public Property ChildNo As Integer
End Class
Public Class WindowViewModel : Inherits MvxNavigationViewModel
    Private Shared mCount As Integer

    'Public Title As String = $"No.{Count} Window View"
    Public ReadOnly Property Title As String
        Get
            Return $"No.{Count} Window View"
        End Get
    End Property

    Private _mode As Modes = Modes.Blue
    Public Property Mode As Modes
        Get
            Return _mode
        End Get
        Set(value As Modes)
            If value = _mode Then Return
            _mode = value
            RaisePropertyChanged(Function() Mode)
        End Set
    End Property

    Private _isItem1 As Boolean = True
    Public Property IsItem1 As Boolean
        Get
            Return _isItem1
        End Get
        Set(value As Boolean)
            If value = IsItem1 Then Return
            _isItem1 = value
            RaisePropertyChanged(Function() IsItem1)
        End Set
    End Property
    Private _isItem2 As Boolean = False
    Public Property IsItem2 As Boolean
        Get
            Return _isItem2
        End Get
        Set(value As Boolean)
            If value = IsItem2 Then Return
            _isItem2 = value
            RaisePropertyChanged(Function() IsItem2)
        End Set
    End Property
    Private _isItem3 As Boolean = False
    Public Property IsItem3 As Boolean
        Get
            Return _isItem3
        End Get
        Set(value As Boolean)
            If value = IsItem3 Then Return
            _isItem3 = value
            RaisePropertyChanged(Function() IsItem3)
        End Set
    End Property

    Private _isItemSetting As Boolean = False

    Public Property IsItemSetting As Boolean
        Get
            Return _isItemSetting
        End Get
        Set(value As Boolean)
            If value = IsItemSetting Then Return
            _isItemSetting = value
            RaisePropertyChanged(Function() IsItemSetting)
        End Set
    End Property

    Public Property Count As Integer


    Public Sub New(logProvider As IMvxLogProvider, mNavigationService As IMvxNavigationService)
        MyBase.New(logProvider, mNavigationService)

        mCount += 1
        Count = mCount

        ShowWindowChildCommand = New MvxAsyncCommand(Of Integer)(Async Function(no)
                                                                     Await NavigationService.Navigate(Of WindowChildViewModel, WindowChildParam)(New WindowChildParam With {
                              .ParentNo = Count,
                              .ChildNo = no
                                                                                                                                                 })
                                                                 End Function)
        CloseCommand = New MvxAsyncCommand(Async Function() Await NavigationService.Close(Me))
        ToggleSettingCommand = New MvxAsyncCommand(Async Function()
                                                       Await Task.Run(Function() IsItemSetting = Not IsItemSetting)
                                                   End Function)

    End Sub


    Public Property CloseCommand As IMvxAsyncCommand
    Public Property ShowWindowChildCommand As IMvxAsyncCommand(Of Integer)
    Public Property ToggleSettingCommand As IMvxAsyncCommand


End Class
