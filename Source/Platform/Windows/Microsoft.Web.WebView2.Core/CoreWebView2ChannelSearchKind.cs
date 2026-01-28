namespace Microsoft.Web.WebView2.Core;

/// <summary>The channel search kind determines the order that release channels are
/// searched for during environment creation. The default behavior is to search
/// for and use the most stable channel found on the device. The order from most
/// to least stable is: WebView2 Runtime -&gt; Beta -&gt; Dev -&gt; Canary. Switch the
/// order to prefer the least stable channel in order to perform pre-release
/// testing. See `COREWEBVIEW2_RELEASE_CHANNELS` for descriptions of channels.</summary>
public enum CoreWebView2ChannelSearchKind
{
	/// <summary>Search for a release channel from most to least stable:
	/// WebView2 Runtime -&gt; Beta -&gt; Dev -&gt; Canary. This is the default behavior.</summary>
	MostStable,
	/// <summary>Search for a release channel from least to most stable:
	/// Canary -&gt; Dev -&gt; Beta -&gt; WebView2 Runtime.</summary>
	LeastStable
}
