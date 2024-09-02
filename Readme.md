<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134079196/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4573)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF LookUpEdit - Enable Multiple Selection Mode

This example demonstrates how to allow users to select multiple items in the [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit).

![image](https://user-images.githubusercontent.com/65009440/225583463-7f8694f7-f61f-4a47-a4ad-a4273b4c5d3d.png)

To enable multiple selection mode, set the editor's [StyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.StyleSettings) property to an object that supports this mode ([MultiSelectLookUpEditStyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.MultiSelectLookUpEditStyleSettings), [TokenLookUpEditStyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.TokenLookUpEditStyleSettings), or [SearchTokenLookUpEditStyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.SearchTokenLookUpEditStyleSettings)).

You can use the [PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate) property to customize the selection behavior or display the [checkbox selector column](https://docs.devexpress.com/WPF/17808/controls-and-libraries/data-grid/visual-elements/table-view-elements/selector-column) as demonstrated in the following example: [WPF LookUpEdit - Display CheckBoxes for Multiple Selection Mode](https://github.com/DevExpress-Examples/wpf-lookupedit-display-checkboxes-for-multiple-selection-mode).

## Files to Review

* [MainWindow.xaml](./CS/WpfApplication68/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication68/MainWindow.xaml))

## Documentation

* [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)
* [LookUpEdit Operation Modes](https://docs.devexpress.com/WPF/116556/controls-and-libraries/data-editors/common-features/editor-operation-modes/lookupedit)
* [Implement multi-select in DevExpress WPF Data Editors (ComboBoxEdit, LookUpEdit, ListBoxEdit)](https://supportcenter.devexpress.com/ticket/details/t889444/how-to-implement-multi-select-when-using-devexpress-wpf-data-editors-comboboxedit)

## More Examples

* [WPF LookUpEdit - Display CheckBoxes for Multiple Selection Mode](https://github.com/DevExpress-Examples/wpf-lookupedit-display-checkboxes-for-multiple-selection-mode)
* [WPF LookUpEdit - Customize the Embedded Data Grid](https://github.com/DevExpress-Examples/wpf-lookupedit-customize-the-embedded-data-grid)
* [WPF LookUpEdit - Display a TreeList as Popup Content](https://github.com/DevExpress-Examples/wpf-lookupedit-display-treelist-as-popup-content)
* [WPF LookUpEdit - Filter by Multiple Columns](https://github.com/DevExpress-Examples/wpf-lookupedit-filter-by-multiple-columns)
* [WPF LookUpEdit - Process New Values](https://github.com/DevExpress-Examples/wpf-lookupedit-process-new-values)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-enable-multiple-selection-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-enable-multiple-selection-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
