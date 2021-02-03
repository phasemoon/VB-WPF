Imports MvvmCross.Core
Imports MvvmCross.IoC
Imports MvvmCross.Platforms.Wpf.Core

Namespace MyName.Core
    Class Application : Inherits MvvmCross.ViewModels.MvxApplication


        ' Startup, Exit 및 DispatcherUnhandledException 같은 애플리케이션 수준 이벤트는
        ' 이 파일에서 처리할 수 있습니다.
        Public Overrides Sub Initialize()
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton()
            RegisterAppStart(Of ViewModels.MainViewModel)()

        End Sub

        Protected Overloads Sub RegisterSetup()
            Me.RegisterSetupType(Of MvxWpfSetup(Of Core.Application))
        End Sub

    End Class
End Namespace

