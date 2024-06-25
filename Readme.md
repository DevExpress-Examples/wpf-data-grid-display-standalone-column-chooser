<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649119/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1661)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-standalone-column-chooser&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-standalone-column-chooser&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
