<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649119/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1661)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Data Grid - Display a Standalone Column Chooser

This example displays the [column chooser](http://docs.devexpress.com/WPF/6217/controls-and-libraries/data-grid/visual-elements/common-elements/column-band-chooser) in standalone mode and connects it to the [GridControl](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl):

![image](https://user-images.githubusercontent.com/65009440/173013222-48dffa6d-5f00-48ef-a0cc-eaf1f5d85a00.png)

* Add [ExtendedColumnChooserControl](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ExtendedColumnChooserControl) to your layout and define its **Owner** and **FlowDirection** properties:

```xaml
<dxg:ExtendedColumnChooserControl Owner="{Binding ElementName=tableView}" 
                                  FlowDirection="{Binding Owner.FlowDirection, RelativeSource={RelativeSource Self}}"/>
```

* Hide the context menu item that shows and hides GridControl's Column Chooser. Add a [RemoveAction](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.RemoveAction) object to the TableView's [ColumnMenuCustomizations](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnMenuCustomizations) collection:

```xaml
<dxg:TableView.ColumnMenuCustomizations>
   <dxb:RemoveAction ElementName="{x:Static dxg:DefaultColumnMenuItemNames.ColumnChooser}"/>
</dxg:TableView.ColumnMenuCustomizations>
```

<!-- default file list -->

## Files to look at

* [MainWindow.xaml](./CS/DevExCustomColumnChooser/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DevExCustomColumnChooser/MainWindow.xaml))

<!-- default file list end -->

## Documentation

* [Column Chooser](http://docs.devexpress.com/WPF/6217/controls-and-libraries/data-grid/visual-elements/common-elements/column-band-chooser)
* [Show and Hide Columns](http://docs.devexpress.com/WPF/6318/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields/show-and-hide-columns)
* [ExtendedColumnChooserControl](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ExtendedColumnChooserControl)
* [Context Menus](https://docs.devexpress.com/WPF/6587/controls-and-libraries/data-grid/miscellaneous/context-menus)

## More Examples

* [WPF Data Grid - Specify Custom Content for Headers Displayed in the Column Chooser](https://github.com/DevExpress-Examples/wpf-data-grid-custom-content-for-column-chooser-headers)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-standalone-column-chooser&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-standalone-column-chooser&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
