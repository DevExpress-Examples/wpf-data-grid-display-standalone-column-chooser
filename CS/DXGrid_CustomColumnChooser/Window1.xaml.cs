using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core;

namespace DXGrid_CustomColumnChooser {
    public partial class Window1 : Window {
        public Window1() {
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
    public class CustomColumnChooser : IColumnChooser, IColumnChooserFactory {
        readonly CustomColumnChooserControl columnChooserControl;
        public CustomColumnChooser(CustomColumnChooserControl columnChooserControl) {
            this.columnChooserControl = columnChooserControl;
        }
        #region IColumnChooser Members
        void IColumnChooser.Show() { }
        void IColumnChooser.Hide() { }
        void IColumnChooser.ApplyState(IColumnChooserState state) { }
        void IColumnChooser.SaveState(IColumnChooserState state) { }
        void IColumnChooser.Destroy() { }
        UIElement IColumnChooser.TopContainer { get {
                 return columnChooserControl.ColunmChooserControl; } }
        #endregion

        #region IColumnChooserFactory Members

        IColumnChooser IColumnChooserFactory.Create(Control owner) {
            return this;
        }

        #endregion
    }
    public class CustomColumnChooserControl : Control {
        public static readonly DependencyProperty ViewProperty;

        static CustomColumnChooserControl() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomColumnChooserControl),
                new FrameworkPropertyMetadata(typeof(CustomColumnChooserControl)));
            ViewProperty = DependencyProperty.Register("View", typeof(GridViewBase),
                typeof(CustomColumnChooserControl), new UIPropertyMetadata(null));
        }

        public GridViewBase View {
            get { return (GridViewBase)GetValue(ViewProperty); }
            set { SetValue(ViewProperty, value); }
        }

        internal ColumnChooserControl ColunmChooserControl { get; private set; }

        public override void OnApplyTemplate() {
            base.OnApplyTemplate();
            ColunmChooserControl = (ColumnChooserControl)GetTemplateChild(
                "PART_ColumnChooserControl");
        }
    }
    public class IssueList {
        static public List<IssueDataObject> GetData() {
            List<IssueDataObject> data = new List<IssueDataObject>();
            data.Add(new IssueDataObject() { IssueName = "Transaction History", 
                IssueType = "Bug", IsPrivate = true });
            data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency",
                IssueType = "Bug", IsPrivate = false });
            data.Add(new IssueDataObject() { IssueName = "Data Import",
                IssueType = "Request", IsPrivate = false });
            data.Add(new IssueDataObject() { IssueName = "Data Archiving",
                IssueType = "Request", IsPrivate = true });
            return data;
        }
    }

    public class IssueDataObject {
        public string IssueName { get; set; }
        public string IssueType { get; set; }
        public bool IsPrivate { get; set; }
    }
}
