# How to Create a Custom Column Chooser


<p>This example shows how to create a custom standalone <strong>Column Chooser</strong> and display it within the <strong>Expander </strong>control.</p>


<h3>Description</h3>

<p>In this example, we implemented a custom <strong>CustomColumnChooserControl </strong>control that can be placed on a form. For example:</p>
<code lang="xaml">&lt;Grid&gt;
    &lt;Grid.ColumnDefinitions&gt;
        &lt;ColumnDefinition /&gt;
        &lt;ColumnDefinition Width="170"/&gt;
    &lt;/Grid.ColumnDefinitions&gt;
    &lt;dxg:GridControl x:Name="grid"&gt;
        &lt;dxg:GridControl.View&gt;
            &lt;dxg:TableView x:Name="tableView" /&gt;
        &lt;/dxg:GridControl.View&gt;
    &lt;/dxg:GridControl&gt;
    &lt;local:CustomColumnChooserControl x:Name="columnChooser" Grid.Column="1"/&gt;
&lt;/Grid&gt;</code>
<p>To associate it with a grid, set the CustomColumnChooserControl's <strong>View </strong>property to the grid's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridControl_Viewtopic"><u>View</u></a> object and set the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridDataViewBase_ColumnChooserFactorytopic"><u>DataViewBase.ColumnChooserFactory</u></a> property in the following manner:</p>
<code lang="cs">columnChooser.View = view;
view.ColumnChooserFactory = New CustomColumnChooser(columnChooser);</code>

<br/>


