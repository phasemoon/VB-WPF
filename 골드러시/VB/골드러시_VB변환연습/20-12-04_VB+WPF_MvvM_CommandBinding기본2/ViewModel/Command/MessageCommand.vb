Imports System.Windows.Input
Public Class MessageCommand
    Implements ICommand

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    '실제 명령 수행에 사용되는 Action을 선언합니다
    'Private mExecute As Action
    Private mExecute As Action(Of String)

    '생성자를 추가합니다
    '생성자로 전달되는 함수를 실제 명령으로 대입하기 위해 파라미터로 입력한다
    'Public Sub New(execute As Action)
    '    mExecute = execute
    'End Sub
    Public Sub New(execute As Action(Of String))
        mExecute = execute
    End Sub

    '실제 명령을 수행하는 함수 인 Execute 메서드에는 _execute를 수행하도록 한다.
    'Public Sub Execute(parameter As Object) Implements ICommand.Execute
    '    mExecute.Invoke
    'End Sub
    'Public Sub Execute(parameter As Object) Implements ICommand.Execute
    '    mExecute.Invoke
    'End Sub
    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        mExecute.Invoke(TryCast(parameter, String))
    End Sub

    ' CanExecute 는 명령 실행 선 조건에 해당하지만
    '여기서는 별도의 조건이 없으므로 항상 true를 반환하도록 한다.
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
