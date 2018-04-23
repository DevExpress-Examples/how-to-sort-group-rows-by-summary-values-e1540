using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.Grid;

namespace DXSample_SortGroupsBySummary {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = new AccountList().GetData();
            SortGroupsBySummary(grid.View.GroupedColumns[0]);
        }
        private void SortGroupsBySummary(GridColumn column) {
            GridGroupSummarySortInfo sortInfo = new GridGroupSummarySortInfo(grid.GroupSummary[0],
                column.FieldName, System.ComponentModel.ListSortDirection.Ascending);
            grid.GroupSummarySortInfo.Add(sortInfo);
        }
    }
    public class AccountList {
        public List<Account> GetData() {
            return CreateAccounts();
        }
        private List<Account> CreateAccounts() {
            List<Account> list = new List<Account>();
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
