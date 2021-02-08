Imports MvvmCross
Imports MvvmCross.IoC
Imports MvvmCross.Localization
Imports MvvmCross.ViewModels
Imports TipCalc.Core.Services
Imports TipCalc.Core.ViewModels


Public Class App
    Inherits MvxApplication

    Public Overrides Sub Initialize()
        Mvx.IoCProvider.RegisterType(Of ICalculationService, CalculationService)()
        'RegisterAppStart(Of TipViewModel)()

        RegisterAppStart(Of FirstViewModel)()
        'RegisterAppStart(Of MasterViewModel)()

        RegisterAppStart(Of RootViewModel)()

        'CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsSingleton()
        'Mvx.IoCProvider.RegisterSingleton(Of IMvxTextProvider)(New TextProviderBuilder().TextProvider)

        'RegisterAppStart(Of RootViewModel)()

    End Sub

    'Public Overrides Function Startup() As Task
    '    Return MyBase.Startup()
    'End Function

    'Public Overrides Sub Reset()
    '    MyBase.Reset()
    'End Sub

End Class
