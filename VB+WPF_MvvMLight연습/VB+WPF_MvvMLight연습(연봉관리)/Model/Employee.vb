Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight

Public Class Employee
    Inherits ObservableObject

    Private mId As Integer
    Private mName As String
    Private mAge As Integer
    Private mSalary As Short

    Public Property ID As Integer
        Get
            Return mId
        End Get
        Set(value As Integer)
            '[Set] 메서드는 속성에 새 값을 할당 한 다음 RaisePropertyChanged 메서드를 호출합니다.
            '속성이 변경되면 UI를 업데이트해야하므로 RaisePropertyChanged 메서드를 사용해야합니다.

            ' 이들의 차이가 무엇인지?
            '[Set](Of Integer)(Function() Me.mId, mId, value) '<-본문
            [Set](Of Integer)("ID", mId, value)
            '[Set](Of Integer)(mId, value, "ID")
        End Set
    End Property

    Public Property Name As String
        Get
            Return mName
        End Get
        Set(value As String)
            [Set](Of String)(Function() Me.Name, mName, value)
        End Set
    End Property

    Public Property Age As String
        Get
            Return mAge
        End Get
        Set(value As String)
            [Set](Of String)(Function() Me.Age, mAge, value)
        End Set
    End Property

    Public Property Salary As Short
        Get
            Return mSalary
        End Get
        Set(value As Short)
            [Set](Of Short)(Function() Me.Salary, mSalary, value)
        End Set
    End Property


    ''' <summary>
    ''' 메모리에 임시 직원 목록을 만들고 Employee 클래스의 ObservableCollection을 반환합니다.
    ''' 직원 세부 정보를 로드하고 저장하는 데 데이터베이스를 사용할 필요가 없도록 UI 바인딩에 해당 목록을 사용하였습니다.
    ''' </summary>
    ''' <returns>Employee 클래스의 ObservableCollection</returns>
    Public Shared Function GetSampleEmployees() As ObservableCollection(Of Employee)
        Dim employees As ObservableCollection(Of Employee) = New ObservableCollection(Of Employee)

        For i = 0 To 29
            employees.Add(New Employee With {
                          .ID = i + 1,
                          .Name = "Name" + (i + 1).ToString,
                          .Age = 20 + 1,
                          .Salary = 20000 + (i * 10)
            })

        Next

        Return employees

    End Function

End Class
