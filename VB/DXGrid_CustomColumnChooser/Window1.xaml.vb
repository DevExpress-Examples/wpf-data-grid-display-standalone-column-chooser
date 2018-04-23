Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core

Namespace DXGrid_CustomColumnChooser
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = IssueList.GetData()
			InitCustomColumnChooser(tableView)

		End Sub
		Private Sub InitCustomColumnChooser(ByVal view As GridViewBase)
			columnChooser.View = view
			view.ColumnChooserFactory = New CustomColumnChooser(columnChooser)
			view.ShowColumnChooser()
		End Sub
	End Class
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
		Public Shared ReadOnly ViewProperty As DependencyProperty

		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomColumnChooserControl), New FrameworkPropertyMetadata(GetType(CustomColumnChooserControl)))
			ViewProperty = DependencyProperty.Register("View", GetType(GridViewBase), GetType(CustomColumnChooserControl), New UIPropertyMetadata(Nothing))
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
	Public Class IssueList
		Public Shared Function GetData() As List(Of IssueDataObject)
			Dim data As New List(Of IssueDataObject)()
			data.Add(New IssueDataObject() With {.IssueName = "Transaction History", .IssueType = "Bug", .IsPrivate = True})
			data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency", .IssueType = "Bug", .IsPrivate = False})
			data.Add(New IssueDataObject() With {.IssueName = "Data Import", .IssueType = "Request", .IsPrivate = False})
			data.Add(New IssueDataObject() With {.IssueName = "Data Archiving", .IssueType = "Request", .IsPrivate = True})
			Return data
		End Function
	End Class

	Public Class IssueDataObject
		Private privateIssueName As String
		Public Property IssueName() As String
			Get
				Return privateIssueName
			End Get
			Set(ByVal value As String)
				privateIssueName = value
			End Set
		End Property
		Private privateIssueType As String
		Public Property IssueType() As String
			Get
				Return privateIssueType
			End Get
			Set(ByVal value As String)
				privateIssueType = value
			End Set
		End Property
		Private privateIsPrivate As Boolean
		Public Property IsPrivate() As Boolean
			Get
				Return privateIsPrivate
			End Get
			Set(ByVal value As Boolean)
				privateIsPrivate = value
			End Set
		End Property
	End Class
End Namespace
