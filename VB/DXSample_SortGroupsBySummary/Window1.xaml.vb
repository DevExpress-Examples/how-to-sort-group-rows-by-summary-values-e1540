Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace DXSample_SortGroupsBySummary

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = AccountList.GetData()
            Me.SortGroupsBySummary(Me.view.GroupedColumns(0))
        End Sub

        Private Sub SortGroupsBySummary(ByVal column As GridColumn)
            Dim sortInfo As GridGroupSummarySortInfo = New GridGroupSummarySortInfo(Me.grid.GroupSummary(0), column.FieldName, System.ComponentModel.ListSortDirection.Ascending)
            Me.grid.GroupSummarySortInfo.Add(sortInfo)
        End Sub
    End Class

    Public Class AccountList

        Public Shared Function GetData() As ObservableCollection(Of Account)
            Dim list As ObservableCollection(Of Account) = New ObservableCollection(Of Account)()
            list.Add(New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today, .Age = 57})
            list.Add(New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New DateTime(2009, 5, 10), .Age = 24})
            list.Add(New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New DateTime(2009, 5, 10), .Age = 35})
            list.Add(New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today, .Age = 19})
            list.Add(New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New DateTime(2008, 10, 18), .Age = 42})
            Return list
        End Function
    End Class

    Public Class Account

        Public Property UserName As String

        Public Property RegistrationDate As Date

        Public Property Age As Integer
    End Class
End Namespace
