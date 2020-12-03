Imports GalaSoft.MvvmLight

Namespace ViewModel

	''' <summary>
	''' This class contains properties that the main View can data bind to.
	''' <para>
	''' Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
	''' </para>
	''' <para>
	''' You can also use Blend to data bind with the tool's support.
	''' </para>
	''' <para>
	''' See http://www.galasoft.ch/mvvm
	''' </para>
	''' </summary>
	Public Class MainViewModel
		Inherits ViewModelBase

        ''' <summary>
        ''' Initializes a new instance of the MainViewModel class.
        ''' </summary>
        Public Sub New()
			'if IsInDesignMode then
			'    ' Code runs in Blend --> create design time data.
			'else
			'    ' Code runs "for real"
			'end if
		End Sub
	End Class

End Namespace