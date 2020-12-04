Imports System.ComponentModel
Public Class MainViewModel
    Implements INotifyPropertyChanged
    ' INotifyPropertyChanged 인터페이스 구현
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged



    Private iNum As Integer

    'Number에 대한 get,set
    'Public Property Number
    '    Get
    '        Return iNum
    '    End Get
    '    Set(value)
    '        iNum = value
    '        OnPropertyChanged("Number") 'set부분이 호출되어 Number의 값이 바뀌게 되면 UI에게 변했음을 알림
    '        '이것을 알려주면 UI는 개발자가 특별한 작업을 하지 않아도 값을 자동으로 바뀐 값으로 변경하게 된다.

    '        OnPropertyChanged("PlusEnable")
    '        OnPropertyChanged("MinusEnable")

    '        PageContents = String.Format("You Are Reading {0} Page", iNum)
    '    End Set

    'End Property
    Public Property Number
        Get
            Return iNum
        End Get
        Set(value)
            Dim iOldnum As Integer = iNum

            iNum = value
            OnPropertyChanged("Number") 'set부분이 호출되어 Number의 값이 바뀌게 되면 UI에게 변했음을 알림
            '이것을 알려주면 UI는 개발자가 특별한 작업을 하지 않아도 값을 자동으로 바뀐 값으로 변경하게 된다.

            If (iNum > 0 And iNum < 11) Then
                OnPropertyChanged("PlusEnable")
                OnPropertyChanged("MinusEnable")

                PageContents = String.Format("You Are Reading {0} Page", iNum)

            Else
                MessageBox.Show("You can input page 1 to 10")
                iNum = iOldnum
                OnPropertyChanged("Number")
            End If


        End Set

    End Property

    '생성자
    'C#에서는 "public MainViewModel()" 과 같은 형태로 쓰임
    Public Sub New()
        Number = 1
    End Sub


    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


    Private micmd As ICommand
    'Public Property MinusCommand As ICommand
    '    Get
    '        'Return Me.minusCommand ?? 
    '        'Return IIf(Me.micmd, Me.MinusCommand = New DelegateCommand(Minus),)

    '        Return If((Me.micmd), New DelegateCommand(AddressOf Minus))

    '    End Get
    '    Set(value As ICommand)

    '    End Set
    'End Property

    Public ReadOnly Property MinusCommand As ICommand
        Get
            'Return Me.minusCommand ?? 
            'Return IIf(Me.micmd, Me.MinusCommand = New DelegateCommand(Minus),)

            Return If(Me.micmd, New DelegateCommand(AddressOf Minus)) 'AddressOf: 특정 프로시저를 참조하는 대리자 인스턴스를 만듦
            ' get이 하는 일은 micmd라는 ICommand 객체를 return해주는데 이 micmd의 실제 수행 작업이 Minus()라는 함수로 위임해 주는 역할을 한다.


        End Get

    End Property

    'Minus()라는 Action함수를 정의한다.
    Private Sub Minus()
        Number -= 1
    End Sub

    Private plcmd As ICommand

    Public Property PlusCommand As ICommand
        Get
            Return If((Me.plcmd), New DelegateCommand(AddressOf Plus))
        End Get
        Set(value As ICommand)

        End Set
    End Property

    Private Sub Plus()
        Number += 1
    End Sub

    Public ReadOnly Property MinusEnable As Boolean
        Get
            Return If(Number > 1, True, False)
        End Get
    End Property

    Public ReadOnly Property PlusEnable As Boolean
        Get
            'Return If(Number < 10, True, False)
            Return IIf(Number < 10, True, False)
        End Get
    End Property

    Private pgContent As String
    Public Property PageContents As String
        Get
            Return pgContent
        End Get
        Set(value As String)
            pgContent = value
            OnPropertyChanged("PageContents")
        End Set
    End Property


End Class



'Public Class DelegateCommand
'    Inherits ICommand

'    Private ReadOnly canExecute As Func(Of Boolean)
'    Private ReadOnly execute As Action

'    Public Sub New(ByVal execute As Action, ByVal canExecute As Func(Of Boolean))
'        Me.execute = execute
'        Me.canExecute = canExecute
'    End Sub

'    Public Event CanExecuteChanged As EventHandler

'    Public Function CanExecute_F(ByVal o As Object) As Boolean
'        If Me.canExecute Is Nothing Then
'            Return True
'        End If

'        Return Me.canExecute()
'    End Function

'    Public Sub Execute_S(ByVal o As Object)
'        Me.execute()
'    End Sub

'    Public Sub RaiseCanExecuteChanged()
'        RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
'    End Sub

'End Class

Public Class DelegateCommand
    Implements ICommand

    'canExe,EXE 선언
    Private canExe As Func(Of Boolean)
    Private Exe As Action


    'Public Sub DelegateCommand(ByVal exe As Action)
    '    Me.New(exe, Nothing)

    'End Sub

    Public Sub New(ByVal exe As Action)
        Me.New(exe, Nothing)
    End Sub

    'Public Sub DelegateCommand(exe As Action, canexe As Func(Of Boolean))
    '    Me.Exe = exe
    '    Me.canExe = canexe
    'End Sub

    Public Sub New(ByVal exe As Action, canexe As Func(Of Boolean))
        Me.Exe = exe
        Me.canExe = canexe
    End Sub


    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged


    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        If Me.canExe Is Nothing Then
            Return True
        End If

        Return Me.canExe()
    End Function

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        Me.Exe()
    End Sub

    Public Sub RaiseCanExecuteChanged()
        RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
    End Sub

End Class