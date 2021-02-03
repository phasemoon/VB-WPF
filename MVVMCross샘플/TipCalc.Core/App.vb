Imports MvvmCross
Imports MvvmCross.ViewModels
Imports TipCalc.Core.Services
Imports TipCalc.Core.ViewModels


Public Class App
    Inherits MvxApplication

    Public Overrides Sub Initialize()
        Mvx.IoCProvider.RegisterType(Of ICalculationService, CalculationService)()

        RegisterAppStart(Of TipViewModel)()

    End Sub

End Class
