Imports System
Imports System.ComponentModel
Imports System.Windows.Input
Public Class CustomerViewModel
    Inherits WorkspaceViewModel
    Implements IDataErrorInfo

    Private ReadOnly _customer As Customer
    Private ReadOnly _customerRepository As CustomerRepository
    Private _customerType As String
    Private _customerTypeOptions As String()
    Private _isSelected As Boolean
    Private _saveCommand As RelayCommand

    Public Sub New(customer As Customer, customerRepository As CustomerRepository)
        _customer = If(customer, )
    End Sub

    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class
