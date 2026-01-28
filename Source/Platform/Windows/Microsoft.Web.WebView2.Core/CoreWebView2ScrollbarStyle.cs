namespace Microsoft.Web.WebView2.Core;

/// <summary>Set ScrollBar style on `ICoreWebView2EnvironmentOptions` during environment creation.</summary>
public enum CoreWebView2ScrollbarStyle
{
	/// <summary>Browser default ScrollBar style</summary>
	Default,
	/// <summary>Window style fluent overlay scroll bar
	/// Please see [Fluent UI](https://developer.microsoft.com/fluentui#/)
	/// for more details on fluent UI.</summary>
	FluentOverlay
}
