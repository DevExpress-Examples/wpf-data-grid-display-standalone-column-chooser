Imports System.Collections.Generic
Imports System.Windows

Namespace DevExCustomColumnChooser
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = IssueList.GetData()
		End Sub
	End Class

	Public Class IssueList
		Public Shared Function GetData() As List(Of IssueDataObject)
			Dim data = New List(Of IssueDataObject) From {
				New IssueDataObject() With {
					.IssueName = "Transaction History",
					.IssueType = "Bug",
					.IsPrivate = True
				},
				New IssueDataObject() With {
					.IssueName = "Ledger: Inconsistency",
					.IssueType = "Bug",
					.IsPrivate = False
				},
				New IssueDataObject() With {
					.IssueName = "Data Import",
					.IssueType = "Request",
					.IsPrivate = False
				},
				New IssueDataObject() With {
					.IssueName = "Data Archiving",
					.IssueType = "Request",
					.IsPrivate = True
				}
			}
			Return data
		End Function
	End Class
	Public Class IssueDataObject
		Public Property IssueName() As String
		Public Property IssueType() As String
		Public Property IsPrivate() As Boolean
	End Class
End Namespace