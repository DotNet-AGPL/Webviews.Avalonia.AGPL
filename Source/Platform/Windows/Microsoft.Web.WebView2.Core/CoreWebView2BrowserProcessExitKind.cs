namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the browser process exit type used in the
/// `ICoreWebView2BrowserProcessExitedEventArgs` interface.</summary>
public enum CoreWebView2BrowserProcessExitKind
{
	/// <summary>Indicates that the browser process ended normally.</summary>
	Normal,
	/// <summary>Indicates that the browser process ended unexpectedly.
	/// A `ProcessFailed` event will also be sent to listening WebViews from the
	/// `ICoreWebView2Environment` associated to the failed process.</summary>
	Failed
}
