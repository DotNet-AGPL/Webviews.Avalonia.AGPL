namespace Microsoft.Web.WebView2.Core;

/// <summary>This enum contains values representing possible regions a given
/// point lies within. The values of this enum align with the
/// matching WM_NCHITTEST* window message return values.</summary>
public enum CoreWebView2NonClientRegionKind
{
	/// <summary>A hit test region out of bounds of the WebView2.
	/// This has the same value as the Win32 HTNOWHERE</summary>
	Nowhere = 0,
	/// <summary>A hit test region in the WebView2 which does not have the CSS style
	/// `-webkit-app-region: drag` set. This is normal web content that should not be
	/// considered part of the app window's title bar. This has the same value
	/// as the Win32 HTCLIENT constant.</summary>
	Client = 1,
	/// <summary>A hit test region in the WebView2 which has the CSS style
	/// `-webkit-app-region: drag` set. Web content should use this CSS
	/// style to identify regions that should be treated like the app
	/// window's title bar. This has the same value as the Win32 HTCAPTION
	/// constant.</summary>
	Caption = 2,
	/// <summary>A hit test region in the Webview2 which corresponds to the minimize
	/// window control button.</summary>
	Minimize = 8,
	/// <summary>A hit test region in the Webview2 which corresponds to the maximize
	/// window control button.</summary>
	Maximize = 9,
	/// <summary>A hit test region in the Webview2 which corresponds to the close
	/// window control button.</summary>
	Close = 20
}
