Imports System.Reflection
Imports MvvmCross.IoC
Imports MvvmCross.Plugin.JsonLocalization


Public Class TextProviderBuilder
    Inherits MvxTextProviderBuilder

    Public Sub New()
        MyBase.New("TipCalc.Core", "Resources", New MvxEmbeddedJsonDictionaryTextProvider(False))
    End Sub

    Protected Overrides ReadOnly Property ResourceFiles As IDictionary(Of String, String)
        Get
            Dim dictionary = [GetType]().GetTypeInfo().Assembly.CreatableTypes().Where(Function(t) t.Name.EndsWith("ViewModel")).ToDictionary(Function(t) t.Name, Function(t) t.Name)
            dictionary.Add("Text", "Text")
            Return dictionary
        End Get
    End Property
End Class
