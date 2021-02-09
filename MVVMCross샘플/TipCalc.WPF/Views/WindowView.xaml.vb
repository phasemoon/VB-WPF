Imports MvvmCross.Platforms.Wpf.Views
Imports MvvmCross.Presenters
Imports MvvmCross.Presenters.Attributes
Imports MvvmCross.Platforms.Wpf.Presenters.Attributes
Imports MvvmCross.ViewModels
Imports TipCalc.Core

Partial Public Class WindowView
    Implements IMvxOverridePresentationAttribute

    Public Function PresentationAttribute(request As MvxViewModelRequest) As MvxBasePresentationAttribute Implements IMvxOverridePresentationAttribute.PresentationAttribute
        Dim instanceRequest As MvxViewModelInstanceRequest = request
        Dim viewModel = TryCast(instanceRequest?.ViewModelInstance, WindowViewModel)

        Return New MvxWindowPresentationAttribute With {
            .Identifier = $"{NameOf(WindowView)}.{viewModel?.Count}"
        }
    End Function
End Class
