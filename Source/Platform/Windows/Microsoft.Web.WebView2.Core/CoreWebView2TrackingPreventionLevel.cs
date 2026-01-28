namespace Microsoft.Web.WebView2.Core;

/// <summary>Tracking prevention levels.</summary>
public enum CoreWebView2TrackingPreventionLevel
{
	/// <summary>Tracking prevention is turned off.</summary>
	None,
	/// <summary>The least restrictive level of tracking prevention. Set to this level to
	/// protect against malicious trackers but allows most other trackers and
	/// personalize content and ads.
	///
	/// See [Current tracking prevention
	/// behavior](/microsoft-edge/web-platform/tracking-prevention#current-tracking-prevention-behavior)
	/// for fine-grained information on what is being blocked with this level and
	/// can change with different Edge versions.</summary>
	Basic,
	/// <summary>The default level of tracking prevention. Set to this level to
	/// protect against social media tracking on top of malicious trackers.
	/// Content and ads will likely be less personalized.
	///
	/// See [Current tracking prevention
	/// behavior](/microsoft-edge/web-platform/tracking-prevention#current-tracking-prevention-behavior)
	/// for fine-grained information on what is being blocked with this level and
	/// can change with different Edge versions.</summary>
	Balanced,
	/// <summary>The most restrictive level of tracking prevention. Set to this level to
	/// protect
	/// against malicious trackers and most trackers across sites. Content and ads
	/// will likely have minimal personalization.
	///
	/// This level blocks the most trackers but could cause some websites to not
	/// behave as expected.
	///
	/// See [Current tracking prevention
	/// behavior](/microsoft-edge/web-platform/tracking-prevention#current-tracking-prevention-behavior)
	/// for fine-grained information on what is being blocked with this level and
	/// can change with different Edge versions.</summary>
	Strict
}
