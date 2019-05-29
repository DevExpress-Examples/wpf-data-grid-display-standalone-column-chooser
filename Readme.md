<!-- default file list -->
*Files to look at*:

* [CustomColumnChooser.cs](./CS/DevExCustomColumnChooser/CustomColumnChooser.cs) (VB: [CustomColumnChooser.vb](./VB/DevExCustomColumnChooser/CustomColumnChooser.vb))
* [MainWindow.xaml](./CS/DevExCustomColumnChooser/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DevExCustomColumnChooser/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DevExCustomColumnChooser/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DevExCustomColumnChooser/MainWindow.xaml.vb))
<!-- default file list end -->
# How to Create a Custom Column Chooser


This example shows how to create a custom standalone **Column Chooser** and display it within the **Expander** control.</p>


### Description

In this example, we implemented a custom **CustomColumnChooserControl** control that can be placed on a form. For example:
````xaml
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition />
        <ColumnDefinition Width="170"/>
    </Grid.ColumnDefinitions>
    <dxg:GridControl x:Name="grid">
        <dxg:GridControl.View>
            <dxg:TableView x:Name="tableView" />
        </dxg:GridControl.View>
    </dxg:GridControl>
    <local:CustomColumnChooserControl x:Name="columnChooser" Grid.Column="1"/>
</Grid>
````

To associate it with a grid, set the CustomColumnChooserControl's **View** property to the grid's [View](http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridControl_Viewtopic) object and set the [DataViewBase.ColumnChooserFactory](http://documentation.devexpress.com/#WPF/DevExpressXpfGridDataViewBase_ColumnChooserFactorytopic) property in the following manner:

````cs
columnChooser.View = view;
view.ColumnChooserFactory = New CustomColumnChooser(columnChooser);
````
