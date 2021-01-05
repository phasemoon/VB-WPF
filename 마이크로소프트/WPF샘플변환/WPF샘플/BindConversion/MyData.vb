Imports System.ComponentModel

Public Class MyData
    Implements INotifyPropertyChanged

    Private _thedate As DateTime
    Public Sub New()
        _thedate = DateTime.Now
    End Sub

    Public Property TheDate As DateTime
        Get
            Return _thedate
        End Get
        Set(value As DateTime)
            _thedate = value
            OnPropertyChanged("TheDate")
        End Set
    End Property

    Protected Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
