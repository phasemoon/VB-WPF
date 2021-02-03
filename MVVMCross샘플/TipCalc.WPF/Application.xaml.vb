Imports MvvmCross.Core
Imports MvvmCross.Platforms.Wpf.Core
Imports MvvmCross.Platforms.Wpf.Views

Class Application
    Inherits MvxApplication

    ' Startup, Exit 및 DispatcherUnhandledException 같은 애플리케이션 수준 이벤트는
    ' 이 파일에서 처리할 수 있습니다.

    Protected Overrides Sub RegisterSetup()
        Me.RegisterSetupType(Of MvxWpfSetup(Of Core.App))
    End Sub

End Class