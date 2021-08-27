<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134079196/12.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4573)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication68/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication68/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication68/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication68/MainWindow.xaml.vb))
<!-- default file list end -->
# How to enable the multi-selection mode in LookUpEdit


<p>LookUpEdit natively supports the multi-selection mode. To enable it, set the editor's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.StyleSettings.property">StyleSettings</a> property to an appropriate object (such as <strong><a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.TokenLookUpEditStyleSettings.class">TokenLookUpEditStyleSettings</a></strong>) - see <a href="https://documentation.devexpress.com/WPF/116556/Controls-and-Libraries/Data-Editors/Common-Features/Editor-Operation-Modes/LookUpEdit">Editor Operation Modes > LookUpEdit</a> for more information.<br><br>If you wish to select records on a click basis (without the CTRL modifier) or customize the drop-down grid in any other way, use the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate.property">PopupContentTemplate</a> property.<br><br>For more information on how to achieve the same in the previous DevExpress versions, refer to the <strong>Implementation Details</strong> section.</p>


<h3>Description</h3>

We implemented the multi-selection mode as an extension. To use it, add a reference to the <strong>DevExpress.Xpf.Grid.Extensions</strong> library and assign <strong>MultiSelectLookUpEditStyleSettings</strong> to the editor's&nbsp;<a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit.StyleSettings.property">StyleSettings</a> property. Also, if you wish to select records on a click basis (without the <strong>CTRL</strong> modifier), customize the editor's&nbsp;<a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate.property">PopupContentTemplate</a>&nbsp; and use the <strong>OneClickSelectionView</strong> as the grid's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.View.property">View</a>. Please note that the LookUpEdit does not support text editing in the multi-selection mode.

<br/>


