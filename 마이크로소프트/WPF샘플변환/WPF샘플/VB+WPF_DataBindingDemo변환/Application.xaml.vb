Imports System.Collections.ObjectModel
Imports System.Windows
Class Application

    ' Startup, Exit 및 DispatcherUnhandledException 같은 애플리케이션 수준 이벤트는
    ' 이 파일에서 처리할 수 있습니다.

    Public Property CurrentUser As User
    Public Property AuctionItems As ObservableCollection(Of AuctionItem) = New ObservableCollection(Of AuctionItem)()


    Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
        LoadAuctionData()
    End Sub

    Private Sub LoadAuctionData()
        CurrentUser = New User("John", 12, New DateTime(2003, 4, 20))

#Region "Add Products to the auction"

        Dim userMary = New User("Mary", 10, New DateTime(2000, 5, 2))
        Dim userAnna = New User("Anna", 5, New DateTime(2001, 9, 13))
        Dim userMike = New User("Mike", 13, New DateTime(1999, 11, 23))
        Dim userMark = New User("Mark", 15, New DateTime(2004, 6, 3))

        Dim camera = New AuctionItem("Digital camera - good condition", ProductCategory.Electronics, 300, New DateTime(2005, 8, 23), userAnna, SpecialFeatures.None)
        camera.AddBid(New Bid(310, userMike))

        AuctionItems.Add(camera)

#End Region
    End Sub
End Class
