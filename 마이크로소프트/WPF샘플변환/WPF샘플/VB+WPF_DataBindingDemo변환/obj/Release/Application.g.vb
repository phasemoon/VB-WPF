﻿#ExternalChecksum("..\..\Application.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","8A26D60E974629D7CE1D9C0200196D0BD1DE5855F7BB118B2966F0A1B51147EB")
'------------------------------------------------------------------------------
' <auto-generated>
'     이 코드는 도구를 사용하여 생성되었습니다.
'     런타임 버전:4.0.30319.42000
'
'     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
'     이러한 변경 내용이 손실됩니다.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell
Imports VB_WPF_DataBindingDemo변환


'''<summary>
'''Application
'''</summary>
Partial Public Class Application
    Inherits System.Windows.Application
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        
        #ExternalSource("..\..\Application.xaml",5)
        AddHandler Startup, New System.Windows.StartupEventHandler(AddressOf Me.Application_Startup)
        
        #End ExternalSource
        
        #ExternalSource("..\..\Application.xaml",6)
        Me.StartupUri = New System.Uri("MainWindow.xaml", System.UriKind.Relative)
        
        #End ExternalSource
        Dim resourceLocater As System.Uri = New System.Uri("/VB+WPF_DataBindingDemo변환;component/application.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Application.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    '''<summary>
    '''Application Entry Point.
    '''</summary>
    <System.STAThreadAttribute(),  _
     System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Shared Sub Main()
        Dim app As Application = New Application()
        app.InitializeComponent
        app.Run
    End Sub
End Class

