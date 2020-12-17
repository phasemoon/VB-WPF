Public Class DropList
    Inherits ContentControl

    Public Property Command As ICommand
        Get
            Return CType(GetValue(CommandProperty), ICommand)
        End Get
        Set(value As ICommand)
            SetValue(CommandProperty, value)
        End Set
    End Property

    Public Shared ReadOnly CommandProperty As DependencyProperty =
        DependencyProperty.Register("Command", GetType(ICommand), GetType(DropList), New PropertyMetadata(Nothing))
End Class
