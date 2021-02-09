Imports MvvmCross.Platforms.Wpf.Views
Imports MvvmCross.Presenters
Imports MvvmCross.Presenters.Attributes
Imports MvvmCross.Platforms.Wpf.Presenters.Attributes
Imports MvvmCross.ViewModels
Imports TipCalc.Core
Public Class WindowChildView
    Implements IMvxOverridePresentationAttribute

    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Public Function PresentationAttribute(request As MvxViewModelRequest) As MvxBasePresentationAttribute Implements IMvxOverridePresentationAttribute.PresentationAttribute
        Dim instanceRequest As MvxViewModelInstanceRequest = request
        Dim viewModel = TryCast(instanceRequest?.ViewModelInstance, WindowChildViewModel)

        Return New MvxContentPresentationAttribute With {
            .WindowIdentifier = $"{NameOf(WindowView)}.{viewModel?.ParentNo}",
            .StackNavigation = False
        }
    End Function
End Class
