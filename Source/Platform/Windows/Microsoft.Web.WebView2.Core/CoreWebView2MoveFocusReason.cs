namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the reason for moving focus.</summary>
public enum CoreWebView2MoveFocusReason
{
	/// <summary>Specifies that the code is setting focus into WebView.</summary>
	Programmatic,
	/// <summary>Specifies that the focus is moving due to Tab traversal forward.</summary>
	Next,
	/// <summary>Specifies that the focus is moving due to Tab traversal backward.</summary>
	Previous
}
