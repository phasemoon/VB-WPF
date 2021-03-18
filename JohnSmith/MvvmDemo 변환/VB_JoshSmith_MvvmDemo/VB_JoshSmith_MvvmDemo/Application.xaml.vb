Class Application

    ' Startup, Exit 및 DispatcherUnhandledException 같은 애플리케이션 수준 이벤트는
    ' 이 파일에서 처리할 수 있습니다.

    Protected Overrides Sub OnStartup(e As StartupEventArgs)
        MyBase.OnStartup(e)

        Dim window = New MainWindow

        ' Create the ViewModel to which 
        ' the main window binds.
        Dim path As String = "Data/customers.xml"
        Dim viewModel = New MainWindowViewModel(path)

        Dim handler As EventHandler = Nothing
        handler = Function()
                      viewModel.re
                  End Function

    End Sub


End Class
