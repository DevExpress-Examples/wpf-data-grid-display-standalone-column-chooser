Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid

Namespace DevExCustomColumnChooser
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
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

	Public Class IssueList
		Public Shared Function GetData() As List(Of IssueDataObject)
			Dim data = New List(Of IssueDataObject) (New IssueDataObject() {New IssueDataObject() With {.IssueName = "Transaction History", .IssueType = "Bug", .IsPrivate = True}, New IssueDataObject() With {.IssueName = "Ledger: Inconsistency", .IssueType = "Bug", .IsPrivate = False}, New IssueDataObject() With {.IssueName = "Data Import", .IssueType = "Request", .IsPrivate = False}, New IssueDataObject() With {.IssueName = "Data Archiving", .IssueType = "Request", .IsPrivate = True}})
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