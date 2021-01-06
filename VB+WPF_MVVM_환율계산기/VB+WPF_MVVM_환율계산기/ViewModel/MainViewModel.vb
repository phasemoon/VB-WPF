Imports System.ComponentModel
Imports VB_WPF_MVVM_환율계산기.Model

Namespace ViewModel
    Public Class MainViewModel
        Implements INotifyPropertyChanged

        Private myModel As MainModel = Nothing

        Public Sub New()
            myModel = New MainModel
        End Sub

        Public Property Dollar As String
            Get
                If String.IsNullOrEmpty(myModel.dollar) Then
                    Won = 0
                Else
                    Dim num As Integer = -1
                    If (Integer.TryParse(myModel.dollar, num)) Then
                        Dim result As Integer = num * 1160
                        Won = result.ToString
                    Else
                        MessageBox.Show("Invalid Numer", "error", MessageBoxButton.OK, MessageBoxImage.Error)
                        Dollar = ""
                        Won = "0"
                    End If
                End If
                Return myModel.dollar
            End Get
            Set(value As String)
                If myModel.dollar <> value Then
                    myModel.dollar = value
                    OnPropertyChanged("Dollar")
                End If
            End Set
        End Property

        Public Property Won As String
            Get
                Return myModel.won
            End Get
            Set(value As String)
                myModel.won = value
                OnPropertyChanged("Won")
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

End Namespace


