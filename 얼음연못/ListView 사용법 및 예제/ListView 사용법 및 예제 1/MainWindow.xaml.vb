Class MainWindow
    Dim students As List(Of Student)

    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        students = New List(Of Student)
        students.Add(New Student With {.name = "john", .age = 21, .gender = "Male"})

        ' xaml에서 만든 ListView에 내가 만든 List를 연결해줍니다.
        studentListView.ItemsSource = students
    End Sub

    Public Class Student
        Public Property name As String
        Public Property gender As String
        Public Property age As Integer
    End Class
End Class
