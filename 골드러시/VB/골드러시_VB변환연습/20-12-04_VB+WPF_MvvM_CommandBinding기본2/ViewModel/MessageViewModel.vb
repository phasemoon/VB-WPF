'현재까지 TextBox에 속성하나, Button에 명령하나를 사용하였다.
'    여기에서 TextBox의 속성을 이용하지않고 Button 클릭시
'    명령에 파라미터로 현재 입력한 TextBox의 텍스트를 대입하는 
'    방법을 알아보자.
'    우선은 TextBox에 바인딩되었던 MessageText 속성을 주석처리하고, DisplayMessage에 파라미터로 String message 를 대입한다.

Namespace ViewModel
    Public Class MessageViewModel
        'Public Property MessageText

        Public Property DisplayMessageCommand As MessageCommand

        Public Sub New()
            DisplayMessageCommand = New MessageCommand(AddressOf DisplayMessage)
        End Sub

        'Public Sub DisplayMessage()
        '    MessageBox.Show(MessageText)
        'End Sub

        Public Sub DisplayMessage(message As String)
            MessageBox.Show(message)
        End Sub
    End Class

End Namespace
