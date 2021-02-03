Imports MvvmCross.ViewModels
'Imports TipCalc.Core.Services
Imports System.Threading.Tasks
Public Class TipViewModel
    Inherits MvxViewModel

    'It is possible that this TipViewModel will already make sense to you. If it does, then skip ahead to ‘Add the App(lication)’. If not, then here are some further explanations:
    '이 TipViewModel이 이미 이해가 될 수 있습니다. 그렇다면 '애플리케이션 추가 (라이선스)'로 건너 뜁니다. 그렇지 않은 경우 다음과 같은 추가 설명이 있습니다.
    ReadOnly _calculationService As ICalculationService

    ' > the TipViewModel is constructed with an ICalculationService service, which is injected using the MvvmCross Dependency Injection engine.
    ' > TipViewModel은 MvvmCross 종속성 주입 엔진을 사용하여 주입되는 ICalculationService 서비스로 구성됩니다.
    Public Sub New(calculationService As ICalculationService)
        _calculationService = calculationService
    End Sub

    'After construction, the TipViewModel runs the Initialize method, which is part of the ViewModel lifecycle - during this it sets some initial values.
    '생성 후 TipViewModel은 ViewModel 수명주기의 일부인 Initialize 메서드를 실행합니다.이 동안 몇 가지 초기 값을 설정합니다.
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
