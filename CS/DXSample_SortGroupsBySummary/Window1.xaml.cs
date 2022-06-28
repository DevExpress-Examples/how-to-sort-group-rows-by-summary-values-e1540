using DevExpress.Xpf.Grid;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace DXSample_SortGroupsBySummary {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = AccountList.GetData();
            SortGroupsBySummary(view.GroupedColumns[0]);
        }
        void SortGroupsBySummary(GridColumn column) {
            GridGroupSummarySortInfo sortInfo = new GridGroupSummarySortInfo(grid.GroupSummary[0],
                column.FieldName, System.ComponentModel.ListSortDirection.Ascending);
            grid.GroupSummarySortInfo.Add(sortInfo);
        }
    }
    public class AccountList {
        public static ObservableCollection<Account> GetData() {
            ObservableCollection<Account> list = new ObservableCollection<Account>();
            list.Add(new Account() { UserName = "Nick White", 
                RegistrationDate = DateTime.Today, Age = 57 });
            list.Add(new Account() { UserName = "Jack Rodman",
                RegistrationDate = new DateTime(2009, 5, 10), Age = 24 });
            list.Add(new Account() { UserName = "Sandra Sherry",
                RegistrationDate = new DateTime(2009, 5, 10), Age = 35 });
            list.Add(new Account() { UserName = "Sabrina Vilk",
                RegistrationDate = DateTime.Today, Age = 19 });
            list.Add(new Account() { UserName = "Mike Pearson",
                RegistrationDate = new DateTime(2008, 10, 18), Age = 42 });
            return list;
        }
    }
    public class Account {
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Age { get; set; }
    }
}
