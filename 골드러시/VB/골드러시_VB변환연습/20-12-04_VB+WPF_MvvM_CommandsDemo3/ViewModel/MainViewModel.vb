Imports System.Collections.ObjectModel

Namespace ViewModel
    Public Class MainViewModel

        '실제 구현될 UI 구성이 콤보 박스와 버튼 2개이므로, 
        '콤보박스용 MyMessages 속성하나와 만들어 두었던 DelegateCommand 형태를 갖는 
        'MessageBoxCommand, ConsoleCommand 속성을 선언한다.
        'ObservableCollection은 WPF의 리스트(List) 속성과 완벽하게 호환되는 컬렉션이다.

        Public Property MyMessages As ObservableCollection(Of String)
        Public Property MessageBoxCommand As DelegateCommand
        Public Property ConsoleCommand As DelegateCommand


        Public Sub New()

            'String 형태의 리스트 컬렉션을 갖는 MyMessages를 초기화하면서 값을 대입한다.
            MyMessages = New ObservableCollection(Of String)() From {
            "Hi", "Hello, World", "Message Box", "Console"
            }

            MessageBoxCommand = New DelegateCommand(AddressOf DisplayInMessageBox, AddressOf MessageBoxCanUse)
            ConsoleCommand = New DelegateCommand(AddressOf DisplayInConsole, AddressOf ConsoleCanUse)

        End Sub

        'UI상의 첫 번째 버튼인 "Message Box"를 클릭 했을 때 수행할 DisplayInMessageBox 함수와
        '두 번째 버튼인 "Console Log"를 클릭 했을 때 수행할 DisplayInConsole 함수를 추가한다.
        '내용은 각 파라미터로 넘어온 내용을 MessageBox와 Console로 보여주는 내용이다.(범용성을 위해 파라미터가 Object 형태이므로 string으로 형변환이 필요하다.)
        Public Sub DisplayInMessageBox(message As Object)
            MessageBox.Show(CStr(message))
        End Sub

        Public Sub DisplayInConsole(message As Object)
            Console.WriteLine(CStr(message))
        End Sub

        '두 버튼에 대한 조건도 각각 추가하는데,
        '콤보 박스 선택 내용이 "콘솔"이면 첫 번째 버튼은 사용 불가로 되고
        '"메시지 박스"이면 두 번째 버튼이 사용 불가로 되는 조건이다.
        Public Function MessageBoxCanUse(message As Object) As Boolean
            If CStr(message) = "Console" Then
                Return False
            End If
            Return True
        End Function

        Public Function ConsoleCanUse(message As Object) As Boolean
            If CStr(message) = "Message Box" Then
                Return False
            End If
            Return True
        End Function
    End Class
End Namespace

