Imports System.Globalization

Public Class SpecialFeaturesConverter
    Implements IMultiValueConverter

    Public Function Convert(values() As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
        If values Is Nothing Or values.Length < 2 Then Return False
        If values(0) Is DependencyProperty.UnsetValue Then Return False
        If values(1) Is DependencyProperty.UnsetValue Then Return False
        Dim rating = CType(values(0), Integer)
        Dim _date = CType(values(1), DateTime)


    End Function

    Public Function ConvertBack(value As Object, targetTypes() As Type, parameter As Object, culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
