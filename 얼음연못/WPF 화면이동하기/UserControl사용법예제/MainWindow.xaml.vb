'출처: https://frozenpond.tistory.com/40

Class MainWindow

    Dim a1 As MyUCContainer = Nothing

    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        a1 = New MyUCContainer("Tom", 20)

        myUC1.ContainerData = a1
    End Sub


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
