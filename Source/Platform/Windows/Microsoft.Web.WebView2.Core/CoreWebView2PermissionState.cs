namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the response to a permission request.</summary>
public enum CoreWebView2PermissionState
{
	/// <summary>Specifies that the default browser behavior is used, which normally
	/// prompt users for decision.</summary>
	Default,
	/// <summary>Specifies that the permission request is granted.</summary>
	Allow,
	/// <summary>Specifies that the permission request is denied.</summary>
	Deny
}
