'출처: https://blog.naver.com/goldrushing/221245862378
Imports _20_12_04_VB_WPF_MvvM_CommandBinding기본2.ViewModel
Class MainWindow
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        'NameSpace ViewModel임포트 후 아래처럼 코드 비하인드에서도 가능
        DataContext = New MessageViewModel
    End Sub
End Class
