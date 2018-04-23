Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Controls
Imports System.Windows.Data

Namespace DXSample
	Public Class OrientationInverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim inputValue As Orientation = CType(value, Orientation)
			Select Case inputValue
				Case Orientation.Horizontal
					Return Orientation.Vertical
				Case Else
					Return Orientation.Horizontal
			End Select
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Dim inputValue As Orientation = CType(value, Orientation)
			Select Case inputValue
				Case Orientation.Horizontal
					Return Orientation.Vertical
				Case Else
					Return Orientation.Horizontal
			End Select
		End Function
	End Class
End Namespace
