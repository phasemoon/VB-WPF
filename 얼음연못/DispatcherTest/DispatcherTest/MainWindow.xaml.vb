' 출처: https://frozenpond.tistory.com/61?category=1126752
Imports System.Threading
Imports System.Windows.Threading

Class MainWindow
    Dim myThread As Thread

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        myThread = New Thread(AddressOf IncreaseNum)
        myThread.Start()
    End Sub

    Private Sub IncreaseNum()
        'System.InvalidOperationException '다른 스레드가 이 개체를 소유하고 있어 호출한 스레드가 해당 개체에 액세스할 수 없습니다.'
        '혹은
        'Cross-thread operation Not valid: Control accessed from a thread other than the thread it was created On. 
        '의 예외가 발생하며 프로그램이 종료되어버립니다.

        'UI스레드의 개체를 myThread라는 외부스레드에서 컨트롤하려고 했기때문에 생긴 예외입니다.
        'WPF의 UI를 그리는 스레드는 STA(Single-thread-apartment) 스레드로
        'System.Windows.Threading.DispatcherObject를 통해 실현되어
        'UI를 그린 본인만 접근할 수 있도록 되어있습니다.


        'For i As Integer = 0 To 9
        '    textBlock.Text = (i + 1).ToString()
        '    Thread.Sleep(300)
        'Next

        'WPF에서는 DispatcherObject로 만든 자신의 스레드(MainWindow의 UI스레드)만 내부 UI개체들에 접근하여 내용을 수정할 수 있지만
        'DIspatcher의 이벤트큐에 UI를 변경할 로직을 넣어두면 UIThread도 제어가 가능합니다.
        '따라서 위의 방식으로 Dispatcher 이벤트 큐에 해당 로직을 넣어 실행시켜줘야 합니다.

        'Dispatcher.Invoke의 첫번째 매개변수는 중요도(우선순위), 두번째 매개변수는 대리자 형식이며
        '두번쨰 매개변수에는 보통 반환형이 없는 delegate형식인 Action과 람다식을 사용하곤 합니다.

        For i As Integer = 0 To 9
            Dispatcher.Invoke(DispatcherPriority.Normal, New Action(Function()
                                                                        textBlock.Text = (i + 1).ToString()
                                                                    End Function))
            Thread.Sleep(300)
        Next
    End Sub
End Class

'System.InvalidOperationException '다른 스레드가 이 개체를 소유하고 있어 호출한 스레드가 해당 개체에 액세스할 수 없습니다.'
'혹은
'Cross-thread operation Not valid: Control accessed from a thread other than the thread it was created On. 
'의 예외가 발생하며 프로그램이 종료되어버립니다.

'UI스레드의 개체를 myThread라는 외부스레드에서 컨트롤하려고 했기때문에 생긴 예외입니다.
'WPF의 UI를 그리는 스레드는 STA(Single-thread-apartment) 스레드로
'System.Windows.Threading.DispatcherObject를 통해 실현되어
'UI를 그린 본인만 접근할 수 있도록 되어있습니다.
