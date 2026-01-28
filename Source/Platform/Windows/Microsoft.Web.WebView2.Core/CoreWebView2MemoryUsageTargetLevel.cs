namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies memory usage target level of WebView.</summary>
public enum CoreWebView2MemoryUsageTargetLevel
{
	/// <summary>Specifies normal memory usage target level.</summary>
	Normal,
	/// <summary>Specifies low memory usage target level.
	/// Used for inactivate WebView for reduced memory consumption.</summary>
	Low
}
