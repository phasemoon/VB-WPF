Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight.Messaging

Namespace ViewModel

    ''' <summary>
    ''' This class contains properties that the main View can data bind to.
    ''' <para>
    ''' Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    ''' </para>
    ''' <para>
    ''' You can also use Blend to data bind with the tool's support.
    ''' </para>
    ''' <para>
    ''' See http://www.galasoft.ch/mvvm
    ''' </para>
    ''' </summary>
    Public Class MainViewModel
        Inherits ViewModelBase

        Private employees As ObservableCollection(Of Employee)
        Private mSelectedEmployee As Employee

        ''' <summary>
        ''' Initializes a new instance of the MainViewModel class.
        ''' </summary>
        Public Sub New()
            'if IsInDesignMode then
            '    ' Code runs in Blend --> create design time data.
            'else
            '    ' Code runs "for real"
            'end if

            'RelayCommand를 사용하여 인스턴스화됩니다. RelayCommand는 MVVM Light Toolkit에서 제공하는 명령으로,
            '델리게이트를 호출하여 다른 개체에 기능을 전달하기위한 것입니다.
            LoadEmployeesCommand = New RelayCommand(AddressOf LoadEmployeesMethod)
            SaveEmployeesCommand = New RelayCommand(AddressOf SaveEmployeesMethod)

        End Sub

        Public Property LoadEmployeesCommand As ICommand
        Public Property SaveEmployeesCommand As ICommand

        ' EmployeeList속성은 ListBox의 ItemsSource 속성에 바인딩된다.
        Public ReadOnly Property EmployeeList As ObservableCollection(Of Employee)
            Get
                Return employees
            End Get
        End Property

        ' SelectedEmployee 속성은 ListBox의 SelectedItem 속성에 바인딩된다
        Public Property SelectedEmployee As Employee
            Get
                Return mSelectedEmployee
            End Get
            Set(value As Employee)
                mSelectedEmployee = value
                RaisePropertyChanged("SelectedEmployee")
            End Set
        End Property

        Public Sub SaveEmployeesMethod()
            Messenger.Default.Send(Of NotificationMessage)(New NotificationMessage("Employees Saved."))
        End Sub

        'LoadEmployeesMethod 메서드에서는 Employee 클래스의 정적 메서드(GetSampleEmployees)에서 직원 목록을로드합니다.
        '다음으로 RaisePropertyChanged 메서드를 사용하여 EmployeeList 속성이 변경되었음을 UI에 알립니다.
        Public Sub LoadEmployeesMethod()
            employees = Employee.GetSampleEmployees
            Me.RaisePropertyChanged(Function() Me.EmployeeList)
            Messenger.Default.Send(Of NotificationMessage)(New NotificationMessage("Employees Loaded."))
            'MsgBox("Employees Loaded.")
        End Sub

    End Class

End Namespace