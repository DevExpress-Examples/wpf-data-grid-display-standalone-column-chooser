using System.Collections.Generic;
using System.Windows;

namespace DevExCustomColumnChooser {
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = IssueList.GetData();
        }
    }

    public class IssueList {
        static public List<IssueDataObject> GetData() {
            var data = new List<IssueDataObject>
                {
                    new IssueDataObject()
                        {
                            IssueName = "Transaction History",
                            IssueType = "Bug",
                            IsPrivate = true
                        },
                    new IssueDataObject()
                        {
                            IssueName = "Ledger: Inconsistency",
                            IssueType = "Bug",
                            IsPrivate = false
                        },
                    new IssueDataObject()
                        {
                            IssueName = "Data Import",
                            IssueType = "Request",
                            IsPrivate = false
                        },
                    new IssueDataObject()
                        {
                            IssueName = "Data Archiving",
                            IssueType = "Request",
                            IsPrivate = true
                        }
                };
            return data;
        }
    }
    public class IssueDataObject {
        public string IssueName { get; set; }
        public string IssueType { get; set; }
        public bool IsPrivate { get; set; }
    }
}