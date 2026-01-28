namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the navigation kind of each navigation.</summary>
public enum CoreWebView2NavigationKind
{
	/// <summary>A navigation caused by `CoreWebView2.Reload()`, `location.reload()`, the end user
	/// using F5 or other UX, or other reload mechanisms to reload the current document
	/// without modifying the navigation history.</summary>
	Reload,
	/// <summary>A navigation back or forward to a different entry in the session navigation history,
	/// like via `CoreWebView2.Back()`, `location.back()`, the end user pressing Alt+Left
	/// or other UX, or other mechanisms to navigate back or forward in the current
	/// session navigation history.</summary>
	BackOrForward,
	/// <summary>A navigation to another document, which can be caused by `CoreWebView2.Navigate()`,
	/// `window.location.href = ...`, or other WebView2 or DOM APIs that navigate to a new URI.</summary>
	NewDocument
}
