<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649119/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1661)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-standalone-column-chooser&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-standalone-column-chooser&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
