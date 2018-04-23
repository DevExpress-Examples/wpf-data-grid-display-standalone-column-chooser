using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;

namespace DevExCustomColumnChooser {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = IssueList.GetData();
            InitCustomColumnChooser(tableView);
        }

        void InitCustomColumnChooser(GridViewBase view) {
            columnChooser.View = view;
            view.ColumnChooserFactory = new CustomColumnChooser(columnChooser);
            view.ShowColumnChooser();
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