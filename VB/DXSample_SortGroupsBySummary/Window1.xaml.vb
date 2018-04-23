Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.Grid

Namespace DXSample_SortGroupsBySummary
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New AccountList().GetData()
			SortGroupsBySummary(grid.View.GroupedColumns(0))
		End Sub
		Private Sub SortGroupsBySummary(ByVal column As GridColumn)
			Dim sortInfo As New GridGroupSummarySortInfo(grid.GroupSummary(0), _
				column.FieldName, System.ComponentModel.ListSortDirection.Ascending)
			grid.GroupSummarySortInfo.Add(sortInfo)
		End Sub
	End Class
	Public Class AccountList
		Public Function GetData() As List(Of Account)
			Return CreateAccounts()
		End Function
		Private Function CreateAccounts() As List(Of Account)
			Dim list As New List(Of Account)()
			list.Add(New Account() With {.UserName = "Nick White", _
				.RegistrationDate = DateTime.Today, .Age = 57})
			list.Add(New Account() With {.UserName = "Jack Rodman", _
				.RegistrationDate = New DateTime(2009, 5, 10), .Age = 24})
			list.Add(New Account() With {.UserName = "Sandra Sherry", _
				.RegistrationDate = New DateTime(2009, 5, 10), .Age = 35})
			list.Add(New Account() With {.UserName = "Sabrina Vilk", _
				.RegistrationDate = DateTime.Today, .Age = 19})
			list.Add(New Account() With {.UserName = "Mike Pearson", _
				.RegistrationDate = New DateTime(2008, 10, 18), .Age = 42})
			Return list
		End Function
	End Class
	Public Class Account
		Private privateUserName As String
		Public Property UserName() As String
			Get
				Return privateUserName
			End Get
			Set(ByVal value As String)
				privateUserName = value
			End Set
		End Property
		Private privateRegistrationDate As DateTime
		Public Property RegistrationDate() As DateTime
			Get
				Return privateRegistrationDate
			End Get
			Set(ByVal value As DateTime)
				privateRegistrationDate = value
			End Set
		End Property
		Private privateAge As Integer
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property
	End Class
End Namespace
