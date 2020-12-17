Imports System.ComponentModel

Public Class MainWindowViewModel
    Implements INotifyPropertyChanged

    Public Sub New()
        Movies2 = New List(Of String) From {
        "Movie1",
        "Movie2",
        "Movie3",
        "Movie4",
        "Movie5",
        "Movie6"
        }
        Movies = New List(Of Movie) From
        {
            New Movie With {.Id = 1, .Title = "The Dark Knight"},
            New Movie With {.Id = 2, .Title = "The Big Lebowski"},
            New Movie With {.Id = 3, .Title = "The Shawshank Redemption"},
            New Movie With {.Id = 4, .Title = "Schindler's List"},
            New Movie With {.Id = 5, .Title = "The Parasite"},
            New Movie With {.Id = 6, .Title = "Forest Gump"}
        }
    End Sub

    Public Property Movies As List(Of Movie)
    Public Property Movies2 As List(Of String)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
