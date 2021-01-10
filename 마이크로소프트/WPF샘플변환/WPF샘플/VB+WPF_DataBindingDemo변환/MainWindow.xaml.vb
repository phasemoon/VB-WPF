Class MainWindow

    Private ReadOnly Property mListingDataView As CollectionViewSource

    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        mListingDataView = CType((Resources("ListingViewData")), CollectionViewSource)
    End Sub

    Private Sub OpenAddPropduct_Click(sender As Object, e As RoutedEventArgs)
        Dim addProductWindow = New AddProductWindow
        addProductWindow.ShowDialog()
    End Sub

    Private Sub Grouping_Checked(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Grouping_Unchecked(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Filtering_Checked(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Filtering_Unchecked(sender As Object, e As RoutedEventArgs)

    End Sub

End Class
