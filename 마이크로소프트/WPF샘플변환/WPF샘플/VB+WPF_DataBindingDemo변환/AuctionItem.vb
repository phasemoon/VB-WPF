Imports System.Collections.ObjectModel
Imports System.ComponentModel
Public Class AuctionItem
    Implements INotifyPropertyChanged

    Private ReadOnly Property mBids As ObservableCollection(Of Bid)
    Private mCategory As ProductCategory
    Private mDescription As String
    Private mSpecialFeatures As SpecialFeatures
    Private mStartDate As DateTime
    Private mStartPrice As Integer

    Public Sub New(description As String, category As ProductCategory, startPrice As Integer, startDate As DateTime, vOwner As User, specialFeatures As SpecialFeatures)
        mDescription = description
        mCategory = category
        mStartDate = startDate
        Owner = vOwner
        mSpecialFeatures = specialFeatures
        mBids = New ObservableCollection(Of Bid)()

    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

    Public Sub AddBid(bid As Bid)
        mBids.Add(bid)
        OnPropertyChanged("CurrentPrice")
    End Sub

#Region "Properties Getters and Setters"

    Public Property Description As String
        Get
            Return mDescription
        End Get
        Set(value As String)
            mDescription = value
            OnPropertyChanged("Description")
        End Set
    End Property

    Public Property StartPrice As Integer
        Get
            Return mStartPrice
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New ArgumentException("Price must be positive. Provide a psitive price")
            End If
            mStartPrice = value
            OnPropertyChanged("StartPrice")
            OnPropertyChanged("CurrentPrice")
        End Set
    End Property

    Public Property StartDate As DateTime
        Get
            Return mStartDate
        End Get
        Set(value As DateTime)
            mStartDate = value
            OnPropertyChanged("StartDate")
        End Set
    End Property

    Public Property Category As ProductCategory
        Get
            Return mCategory
        End Get
        Set(value As ProductCategory)
            mCategory = value
            OnPropertyChanged("Category")
        End Set
    End Property

    Public ReadOnly Property Owner As User

    Public Property SpecialFeatures As SpecialFeatures
        Get
            Return mSpecialFeatures
        End Get
        Set(value As SpecialFeatures)
            mSpecialFeatures = value
            OnPropertyChanged("SpecialFeatures")
        End Set
    End Property

    'c#
    'Public ReadOnlyObservableCollection<Bid> Bids => New ReadOnlyObservableCollection<Bid>(_bids);
    Public ReadOnly Property Bids As ReadOnlyObservableCollection(Of Bid)
        Get
            Return New ReadOnlyObservableCollection(Of Bid)(mBids)
        End Get
    End Property

    Public ReadOnly Property CurrentPrice As Integer
        Get
            Dim price = 0

            'There is at least one bid on this product
            '제품에는 적어도 하나의 bid(입찰)가 있습니다
            If (mBids.Count > 0) Then
                Dim lastBid = mBids(mBids.Count - 1)
                price = lastBid.Amount
            Else
                price = mStartPrice
            End If
            Return price
        End Get
    End Property


#End Region

End Class
