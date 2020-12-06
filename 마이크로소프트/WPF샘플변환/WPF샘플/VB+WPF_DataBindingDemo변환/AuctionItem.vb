Imports System.Collections.ObjectModel
Imports System.ComponentModel
Public Class AuctionItem
    Implements INotifyPropertyChanged

    Private ReadOnly Property mBids As ObservableCollection(Of Bid)
    Private mDescription As String
    Private mStartDate As DateTime
    Private mStartPrice As Integer

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New()

    End Sub
End Class
