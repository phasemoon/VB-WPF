Imports MvvmCross.ViewModels
'Imports TipCalc.Core.Services
Imports System.Threading.Tasks
Public Class TipViewModel
    Inherits MvxViewModel

    ReadOnly _calculationService As ICalculationService

    Public Sub New(calculationService As ICalculationService)
        _calculationService = calculationService
    End Sub

    Public Overrides Async Function Initialize() As Task
        Await MyBase.Initialize()
        _subTotal = 100
        _generosity = 10

        Recalculate()
    End Function

    Private _subTotal As Double
    Public Property SubTotal As Double
        Get
            Return _subTotal
        End Get
        Set(value As Double)
            _subTotal = value
            RaisePropertyChanged(Function() SubTotal)
            Recalculate()
        End Set
    End Property

    Private _generosity As Integer

    Public Property Generosity As Integer
        Get
            Return _generosity
        End Get
        Set(ByVal value As Integer)
            _generosity = value
            RaisePropertyChanged(Function() Generosity)
            Recalculate()
        End Set
    End Property

    Private _tip As Double

    Public Property Tip As Double
        Get
            Return _tip
        End Get
        Set(ByVal value As Double)
            _tip = value
            RaisePropertyChanged(Function() Tip)
        End Set
    End Property

    Private Sub Recalculate()
        Tip = _calculationService.TipAmount(SubTotal, Generosity)
    End Sub

End Class
