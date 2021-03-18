Imports System
Imports System.ComponentModel
Imports System.Diagnostics

Public Class ViewModelBase
    Implements INotifyPropertyChanged, IDisposable

#Region "DisplayName"
    ''' <summary>
    ''' 이 객체의 사용자에게 친숙한 이름을 반환합니다.
    ''' 자식 클래스는이 속성을 새 값으로 설정하거나 요청시 값을 결정하기 위해 재정의 할 수 있습니다.
    ''' </summary>
    Public Overridable Property DisplayName As String
#End Region 'DisplayName

    Private disposedValue As Boolean
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#Region "INotifyPropertyChanged Members"
    Protected Overridable Sub OnPropertyChanged(propertyName As String)
        Dim handler As PropertyChangedEventHandler = PropertyChangedEvent

        If handler IsNot Nothing Then
            Dim e = New PropertyChangedEventArgs(propertyName)
            handler(Me, e)
        End If
    End Sub
#End Region

#Region "IDisposable Members"
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: 관리형 상태(관리형 개체)를 삭제합니다.
            End If

            ' TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
            ' TODO: 큰 필드를 null로 설정합니다.
            disposedValue = True
        End If
    End Sub

    ' ' TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(disposing As Boolean)'에 포함된 경우에만 종료자를 재정의합니다.
    ' Protected Overrides Sub Finalize()
    '     ' 이 코드를 변경하지 마세요. 'Dispose(disposing As Boolean)' 메서드에 정리 코드를 입력합니다.
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' 이 코드를 변경하지 마세요. 'Dispose(disposing As Boolean)' 메서드에 정리 코드를 입력합니다.
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
