Public Class DelegateCommand
    Implements ICommand

    '명령에 필요한 실제 수행 동작(Action)이 들어갈 함수인
    '_execute와 조건(Predicate) 체크에 사용된 _canExecute를 선언한다.
    '<obejct> 는 나중에 사용할 파라미터의 형태이다.

    ReadOnly mExecute As Action(Of Object)
    ReadOnly mCanExecute As Predicate(Of Object)

    '다음 생성자는 수행 동작(Action)과 조건(Predicate)에 사용될 파라미터를 받아서
    '현재 클래스의 _execute와 _canExecute에 대입해 주는 부분이고,
    '앞쪽의 execute는 반드시 입력해야 하는 파라미터로 null이되면 오류를 발생하는 조건을 넣었다. 
    Public Sub New(execute As Action(Of Object), canExecute As Predicate(Of Object))

        If execute Is Nothing Then
            Throw New NullReferenceException("Execute cannot Nothing")
        End If

        mExecute = execute
        mCanExecute = canExecute

    End Sub

    '다음 생성자는
    '앞쪽의 execute 동작만 입력 받으면 (execute, null)
    '파라미터를 ①의 생성자로 전달하는 구문이다.
    Public Sub New(execute As Action(Of Object))
        Me.New(execute, Nothing)

    End Sub

    'Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    'CanExecuteChanged 이벤트 핸들러는 화면 상에서 변경이 발생하면 인식을 못하므로 아래와 같이,
    '변경이 발생하면 CommandManager에 이벤트를 추가(add)하거나 제거(remove)해 주는 과정이 필요하다.
    Public Custom Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
        AddHandler(ByVal value As EventHandler)
            AddHandler CommandManager.RequerySuggested, value
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
            RemoveHandler CommandManager.RequerySuggested, value
        End RemoveHandler
        RaiseEvent()
        End RaiseEvent
    End Event

    'Execute 함수는 넘어온 함수를 파라미터와 함께 그대로 수행하는 내용이다.
    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        mExecute.Invoke(parameter)
    End Sub

    'CanExecute 함수는 _canExecute가 넘어오지 않으면
    '별다른 조건 체크 없이 항상 true를 반환하고, 넘어왔다면 _canExecute(parameter) 수행을 반환한다.
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return If(mCanExecute Is Nothing, True, mCanExecute(parameter))
    End Function
End Class
