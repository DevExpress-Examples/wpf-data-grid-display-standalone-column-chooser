using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace DevExCustomColumnChooser {
    public class CustomColumnChooser: IColumnChooser, IColumnChooserFactory {
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
        UIElement IColumnChooser.TopContainer { get { return columnChooserControl.ColunmChooserControl; } }
        #endregion

        #region IColumnChooserFactory Members
        IColumnChooser IColumnChooserFactory.Create(Control owner) { return this; }
        #endregion
    }
    public class CustomColumnChooserControl: Control {
        public static readonly DependencyProperty ViewProperty = DependencyProperty.Register("View", typeof(GridViewBase), typeof(CustomColumnChooserControl), new UIPropertyMetadata(null));
        public CustomColumnChooserControl() {
            DefaultStyleKey = typeof(CustomColumnChooserControl);
        }
        public GridViewBase View {
            get { return (GridViewBase)GetValue(ViewProperty); }
            set { SetValue(ViewProperty, value); }
        }
        internal ColumnChooserControl ColunmChooserControl { get; private set; }

        public override void OnApplyTemplate() {
            base.OnApplyTemplate();
            ColunmChooserControl = (ColumnChooserControl)GetTemplateChild("PART_ColumnChooserControl");
        }
    }
}
