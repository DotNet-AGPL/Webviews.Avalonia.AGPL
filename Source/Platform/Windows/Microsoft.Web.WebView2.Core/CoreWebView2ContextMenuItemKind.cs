namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the menu item kind
/// for the `ICoreWebView2ContextMenuItem::get_Kind` method</summary>
public enum CoreWebView2ContextMenuItemKind
{
	/// <summary>Specifies a command menu item kind.</summary>
	Command,
	/// <summary>Specifies a check box menu item kind. `ContextMenuItem` objects of this kind
	/// will need the `IsChecked` property to determine current state of the check box.</summary>
	CheckBox,
	/// <summary>Specifies a radio button menu item kind. `ContextMenuItem` objects of this kind
	/// will need the `IsChecked` property to determine current state of the radio button.</summary>
	Radio,
	/// <summary>Specifies a separator menu item kind. `ContextMenuItem` objects of this kind
	/// are used to signal a visual separator with no functionality.</summary>
	Separator,
	/// <summary>Specifies a submenu menu item kind. `ContextMenuItem` objects of this kind will contain
	/// a `ContextMenuItemCollection` of its children `ContextMenuItem` objects.</summary>
	Submenu
}
