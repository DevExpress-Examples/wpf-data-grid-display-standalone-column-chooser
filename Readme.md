# How to: Create a Custom Column Chooser

Starting with v17.2, we provide a new [Column Chooser](https://documentation.devexpress.com/WPF/6154/Controls-and-Libraries/Data-Grid/End-User-Interaction/Column-Chooser) control.  This control allows you to filter columns and hide/show them using corresponding checkboxes. This example illustrates how you can define this chooser in standalone mode and connect it to your GridControl. 

To do this, add **ExtendedColumnChooserControl** to your layout and define its *Owner* and *FlowDirection* properties as follows: 

````xaml
<dxg:ExtendedColumnChooserControl
       Owner="{Binding ElementName=tableView}" 
       FlowDirection="{Binding Owner.FlowDirection, RelativeSource={RelativeSource Self}}"/>
````

To hide the context menu item that shows and hides GridControl's default Column Chooser, use a corresponding [RemoveAction](https://documentation.devexpress.com/WPF/clsDevExpressXpfBarsRemoveActiontopic) in TableView's [ColumnMenuCustomizations](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnMenuCustomizations.property) as we described in the [Context Menus](https://documentation.devexpress.com/WPF/6587/Controls-and-Libraries/Data-Grid/End-User-Interaction/Context-Menus) help topic: 

````xaml
<dxg:TableView.ColumnMenuCustomizations>
    <dxb:RemoveAction ElementName="{x:Static dxg:DefaultColumnMenuItemNames.ColumnChooser}"/>
</dxg:TableView.ColumnMenuCustomizations>
````