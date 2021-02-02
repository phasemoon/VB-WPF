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
        camera.AddBid(New Bid(312, userMark))
        camera.AddBid(New Bid(314, userMike))
        camera.AddBid(New Bid(320, userMark))

        Dim snowBoard = New AuctionItem("Snowboard and bindings", ProductCategory.Sports, 12, New DateTime(2005, 7, 12), userMike, SpecialFeatures.Highlight)
        snowBoard.AddBid(New Bid(140, userAnna))
        snowBoard.AddBid(New Bid(142, userMary))
        snowBoard.AddBid(New Bid(150, userAnna))

        Dim insideCSharp = New AuctionItem("Inside C#, second edition", ProductCategory.Books, 10, New DateTime(2005, 5, 29), CurrentUser, SpecialFeatures.Color)
        insideCSharp.AddBid(New Bid(11, userMike))
        insideCSharp.AddBid(New Bid(13, userAnna))
        insideCSharp.AddBid(New Bid(14, userMary))
        insideCSharp.AddBid(New Bid(15, userAnna))

        Dim laptop = New AuctionItem("Laptop - only 1 year old", ProductCategory.Computers, 500, New DateTime(2005, 8, 15), userMark, SpecialFeatures.Highlight)
        laptop.AddBid(New Bid(510, CurrentUser))

        Dim setOfChairs = New AuctionItem("Set of 6 chairs", ProductCategory.Home, 120, New DateTime(2005, 2, 20), userMike, SpecialFeatures.Color)


        Dim myDvdCollection = New AuctionItem("My DVD Collection", ProductCategory.DvDs, 5, New DateTime(2005, 8, 3), userMary, SpecialFeatures.Highlight)
        myDvdCollection.AddBid(New Bid(6, userMike))
        myDvdCollection.AddBid(New Bid(8, CurrentUser))

        Dim tvDrama = New AuctionItem("TV Drama Series", ProductCategory.DvDs, 40, New DateTime(2005, 7, 28),
                userAnna,
                SpecialFeatures.None)
        tvDrama.AddBid(New Bid(42, userMike))
        tvDrama.AddBid(New Bid(45, userMark))
        tvDrama.AddBid(New Bid(50, userMike))
        tvDrama.AddBid(New Bid(51, CurrentUser))

        Dim squashRacket = New AuctionItem("Squash racket", ProductCategory.Sports, 60, New DateTime(2005, 4, 4),
               userMark,
               SpecialFeatures.Highlight)
        squashRacket.AddBid(New Bid(62, userMike))
        squashRacket.AddBid(New Bid(65, userAnna))

        AuctionItems.Add(camera)
        AuctionItems.Add(snowBoard)
        AuctionItems.Add(insideCSharp)
        AuctionItems.Add(laptop)
        AuctionItems.Add(setOfChairs)
        AuctionItems.Add(myDvdCollection)
        AuctionItems.Add(tvDrama)
        AuctionItems.Add(squashRacket)

#End Region
    End Sub
End Class
