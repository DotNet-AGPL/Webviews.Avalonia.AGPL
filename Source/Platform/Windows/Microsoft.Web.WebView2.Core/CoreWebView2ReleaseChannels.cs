using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Specifies the WebView2 release channel.
/// </summary><remarks>
/// Use <c>ReleaseChannels</c> and <c>ChannelSearchKind</c> on <c>CoreWebView2EnvironmentOptions</c> to control which channel the WebView2 loader searches for.
/// <list type="table"><listheader><description>Channel</description><description>Primary purpose</description><description>How often updated with new features</description></listheader><item><description>Stable (WebView2 Runtime)</description><description>Broad Deployment</description><description>Monthly</description></item><item><description>Beta</description><description>Flighting with inner rings, automated testing</description><description>Monthly</description></item><item><description>Dev</description><description>Automated testing, selfhosting to test new APIs and features</description><description>Weekly</description></item><item><description>Canary</description><description>Automated testing, selfhosting to test new APIs and features</description><description>Daily</description></item></list></remarks>
[Flags]
public enum CoreWebView2ReleaseChannels
{
	/// <summary>No release channel. Passing only this value to `ReleaseChannels` results
	/// in HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND).</summary>
	None = 0,
	/// <summary>The stable WebView2 Runtime that is released every 4 weeks.</summary>
	Stable = 1,
	/// <summary>The Beta release channel that is released every 4 weeks, a week before the
	/// stable release.</summary>
	Beta = 2,
	/// <summary>The Dev release channel that is released weekly.</summary>
	Dev = 4,
	/// <summary>The Canary release channel that is released daily.</summary>
	Canary = 8
}
