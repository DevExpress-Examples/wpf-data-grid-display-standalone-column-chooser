﻿Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls

Namespace DevExCustomColumnChooser
	Public Class CustomColumnChooser
		Implements IColumnChooser, IColumnChooserFactory
		Private ReadOnly columnChooserControl As CustomColumnChooserControl
		Public Sub New(ByVal columnChooserControl As CustomColumnChooserControl)
			Me.columnChooserControl = columnChooserControl
		End Sub
		#Region "IColumnChooser Members"
		Private Sub Show() Implements IColumnChooser.Show
		End Sub
		Private Sub Hide() Implements IColumnChooser.Hide
		End Sub
		Private Sub ApplyState(ByVal state As IColumnChooserState) Implements IColumnChooser.ApplyState
		End Sub
		Private Sub SaveState(ByVal state As IColumnChooserState) Implements IColumnChooser.SaveState
		End Sub
		Private Sub Destroy() Implements IColumnChooser.Destroy
		End Sub
		Private ReadOnly Property TopContainer() As UIElement Implements IColumnChooser.TopContainer
			Get
				Return columnChooserControl.ColunmChooserControl
			End Get
		End Property
		#End Region

		#Region "IColumnChooserFactory Members"
		Private Function Create(ByVal owner As Control) As IColumnChooser Implements IColumnChooserFactory.Create
			Return Me
		End Function
		#End Region
	End Class
	Public Class CustomColumnChooserControl
		Inherits Control
		Public Shared ReadOnly ViewProperty As DependencyProperty = DependencyProperty.Register("View", GetType(GridViewBase), GetType(CustomColumnChooserControl), New UIPropertyMetadata(Nothing))
		Public Sub New()
			DefaultStyleKey = GetType(CustomColumnChooserControl)
		End Sub
		Public Property View() As GridViewBase
			Get
				Return CType(GetValue(ViewProperty), GridViewBase)
			End Get
			Set(ByVal value As GridViewBase)
				SetValue(ViewProperty, value)
			End Set
		End Property
		Private privateColunmChooserControl As ColumnChooserControl
		Friend Property ColunmChooserControl() As ColumnChooserControl
			Get
				Return privateColunmChooserControl
			End Get
			Private Set(ByVal value As ColumnChooserControl)
				privateColunmChooserControl = value
			End Set
		End Property

		Public Overrides Sub OnApplyTemplate()
			MyBase.OnApplyTemplate()
			ColunmChooserControl = CType(GetTemplateChild("PART_ColumnChooserControl"), ColumnChooserControl)
		End Sub
	End Class
End Namespace
