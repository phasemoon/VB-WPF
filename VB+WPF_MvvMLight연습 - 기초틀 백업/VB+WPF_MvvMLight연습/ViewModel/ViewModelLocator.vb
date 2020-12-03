'  In App.xaml:
'  <Application.Resources>
'      <vm:ViewModelLocator xmlns:vm="clr-namespace:WirePicking"
'                           x:Key="Locator" />
'  </Application.Resources>
'  
'  In the View:
'  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
'
'  You can also use Blend to do all this with the tool's support.
'  See http://www.galasoft.ch/mvvm

Imports CommonServiceLocator
Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Ioc
Imports Microsoft.Practices.ServiceLocation

Namespace ViewModel

    ''' <summary>
    ''' This class contains static references to all the view models in the
    ''' application and provides an entry point for the bindings.
    ''' </summary>
    Public Class ViewModelLocator

        ''' <summary>
        ''' Initializes a new instance of the ViewModelLocator class.
        ''' </summary>
        Public Sub New()
            ServiceLocator.SetLocatorProvider(Function() SimpleIoc.Default)

            'if ViewModelBase.IsInDesignModeStatic then
            '    ' Create design time view services and models
            '    SimpleIoc.Default.Register(Of IDataService, DesignDataService)();
            'else
            '    ' Create run time view services and models
            '    SimpleIoc.Default.Register(Of IDataService, DataService)();
            'end if

            SimpleIoc.Default.Register(Of MainViewModel)()
        End Sub

        Public ReadOnly Property Main As MainViewModel
            Get
                Return ServiceLocator.Current.GetInstance(Of MainViewModel)()
            End Get
        End Property

        Public Shared Sub Cleanup()
            ' TODO: Clear the ViewModels
        End Sub

    End Class

End Namespace