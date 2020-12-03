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
Imports GalaSoft.MvvmLight.Messaging
Imports Microsoft.Practices.ServiceLocation

Namespace ViewModel

    ''' <summary>
    ''' This class contains static references to all the view models in the
    ''' application and provides an entry point for the bindings.
    ''' 이 클래스는 애플리케이션의 모든보기 모델에 대한
    ''' 정적 참조를 포함하고 바인딩에 대한 진입 점을 제공합니다.
    ''' 
    ''' ViewModelLocator은 ViewModel들을 가지고 있다가 찾아주는 역할을 한다.
    ''' 즉 View에서 해당 ViewModelLocator을 보고, 선언되어있는 ViewModel을 찾아온다.
    ''' </summary>
    Public Class ViewModelLocator

        ''' <summary>
        ''' Initializes a new instance of the ViewModelLocator class.
        ''' </summary>
        Public Sub New()
            'ServiceLocator.SetLocatorProvider(Function() SimpleIoc.Default)
            ServiceLocator.SetLocatorProvider(Function() SimpleIoc.Default)

            'if ViewModelBase.IsInDesignModeStatic then
            '    ' Create design time view services and models
            '    SimpleIoc.Default.Register(Of IDataService, DesignDataService)();
            'else
            '    ' Create run time view services and models
            '    SimpleIoc.Default.Register(Of IDataService, DataService)();
            'end if

            SimpleIoc.Default.Register(Of MainViewModel)()

            Messenger.Default.Register(Of NotificationMessage)(Me, AddressOf NotifyUserMethod)


        End Sub

        Public ReadOnly Property Main As MainViewModel
            Get
                Return ServiceLocator.Current.GetInstance(Of MainViewModel)()
            End Get
        End Property

        Private Sub NotifyUserMethod(ByVal message As NotificationMessage)
            MsgBox(message.Notification)
        End Sub


        Public Shared Sub Cleanup()
            ' TODO: Clear the ViewModels
        End Sub

    End Class

End Namespace