Imports System.Globalization

Public Class MyConverter
    Implements IValueConverter

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Return Nothing
    End Function

    Public Function IValueConverter_Convert(o As Object, type As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Dim _date = CType(o, DateTime)
        Select Case type.Name
            Case "String"
                Return _date.ToString("F", culture)
            Case "Brush"
                Return Brushes.Red
            Case Else
                Return o
        End Select
    End Function
End Class
