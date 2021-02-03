Imports MvvmCross.Commands
Imports MvvmCross.ViewModels

Namespace ViewModels
    Public Class MainViewModel : Inherits MvxViewModel
        Public Sub New()

        End Sub

        Public Overrides Sub Prepare()
            '// This Is the first method to be called after construction
        End Sub

        Public Overrides Function Initialize() As Task
            '// Async initialization, YEY!
            Return MyBase.Initialize()
        End Function

        Public ReadOnly Property ResetTextCommand As IMvxCommand
            Get
                Return New MvxCommand(AddressOf ResetText)
            End Get
        End Property

        Private Sub ResetText()
            Text = "Hello MvvmCross"
        End Sub

        Private _text As String = "Hello MvvmCross"
        Public Property Text As String
            Get
                Return _text
            End Get
            Set(value As String)
                SetProperty(_text, value)
            End Set
        End Property

    End Class

End Namespace
