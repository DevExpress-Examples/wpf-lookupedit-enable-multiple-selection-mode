# How to enable the multi-selection mode in LookUpEdit


<p>LookUpEdit natively supports the multi-selection mode. To enable it, set the editor's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.StyleSettings.property">StyleSettings</a> property to an appropriate object (such as <strong><a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.TokenLookUpEditStyleSettings.class">TokenLookUpEditStyleSettings</a></strong>) - see <a href="https://documentation.devexpress.com/WPF/116556/Controls-and-Libraries/Data-Editors/Common-Features/Editor-Operation-Modes/LookUpEdit">Editor Operation Modes > LookUpEdit</a> for more information.<br><br>If you wish to select records on a click basis (without the CTRL modifier) or customize the drop-down grid in any other way, use the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate.property">PopupContentTemplate</a> property.<br><br>For more information on how to achieve the same in the previous DevExpress versions, refer to the <strong>Implementation Details</strong> section.</p>

<br/>


