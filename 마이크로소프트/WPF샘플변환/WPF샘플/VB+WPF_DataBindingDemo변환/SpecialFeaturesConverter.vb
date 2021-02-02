Imports System.Globalization

Public Class SpecialFeaturesConverter
    Implements IMultiValueConverter

    Public Function Convert(values() As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
        If values Is Nothing Or values.Length < 2 Then Return False
        If values(0) Is DependencyProperty.UnsetValue Then Return False
        If values(1) Is DependencyProperty.UnsetValue Then Return False
        Dim rating = CType(values(0), Integer)
        Dim _date = CType(values(1), DateTime)

        ' if the user has a good rating (10+) and has been a member for more than a year, special features are available
        ' 사용자가 좋은 평가를 갖거나 1년 이상 회원이었다면, special features 가 가능합니다
        If rating >= 10 And _date.Date < Date.Now.Date - New TimeSpan(365, 0, 0, 0) Then
            Return True
        End If
        Return False

    End Function

    Private Function IMultiValueConverter_ConvertBack(value As Object, targetTypes() As Type, parameter As Object, culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
        Return {Binding.DoNothing, Binding.DoNothing}
    End Function
End Class
