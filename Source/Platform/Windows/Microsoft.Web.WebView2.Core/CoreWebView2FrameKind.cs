namespace Microsoft.Web.WebView2.Core;

/// <summary>Indicates the frame type used in the `ICoreWebView2FrameInfo` interface.</summary>
public enum CoreWebView2FrameKind
{
	/// <summary>Indicates that the frame is an unknown type frame. We may extend this enum
	/// type to identify more frame kinds in the future.</summary>
	Unknown,
	/// <summary>Indicates that the frame is a primary main frame(webview).</summary>
	MainFrame,
	/// <summary>Indicates that the frame is an iframe.</summary>
	Iframe,
	/// <summary>Indicates that the frame is an embed element.</summary>
	Embed,
	/// <summary>Indicates that the frame is an object element.</summary>
	Object
}
