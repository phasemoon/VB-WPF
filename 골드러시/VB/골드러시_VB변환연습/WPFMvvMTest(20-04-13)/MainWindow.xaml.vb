Imports System
Imports System.ComponentModel
Imports System.Windows
Class MainWindow


    'Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
    '    Try
    '        Dim ViewModel As New MainViewModel()
    '        DataContext = ViewModel
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        'ViewModel과 UI의 연결
        Dim ViewModel As New MainViewModel
        DataContext = ViewModel

    End Sub


End Class
