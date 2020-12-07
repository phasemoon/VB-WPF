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
        mDescription = mDescription
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

    Public ReadOnly Property Owner As User



#End Region

End Class
