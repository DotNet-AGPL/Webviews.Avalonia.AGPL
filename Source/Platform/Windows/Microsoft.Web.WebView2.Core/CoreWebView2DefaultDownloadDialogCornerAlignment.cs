namespace Microsoft.Web.WebView2.Core;

/// <summary>The default download dialog can be aligned to any of the WebView corners
/// by setting the `DefaultDownloadDialogCornerAlignment` property. The default
/// position is top-right corner.</summary>
public enum CoreWebView2DefaultDownloadDialogCornerAlignment
{
	/// <summary>Top-left corner of the WebView.</summary>
	TopLeft,
	/// <summary>Top-right corner of the WebView.</summary>
	TopRight,
	/// <summary>Bottom-left corner of the WebView.</summary>
	BottomLeft,
	/// <summary>Bottom-right corner of the WebView.</summary>
	BottomRight
}
