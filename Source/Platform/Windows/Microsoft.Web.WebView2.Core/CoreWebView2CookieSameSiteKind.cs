namespace Microsoft.Web.WebView2.Core;

/// <summary>Kind of cookie SameSite status used in the ICoreWebView2Cookie interface.
/// These fields match those as specified in https://developer.mozilla.org/docs/Web/HTTP/Cookies#.
/// Learn more about SameSite cookies here: https://tools.ietf.org/html/draft-west-first-party-cookies-07</summary>
public enum CoreWebView2CookieSameSiteKind
{
	/// <summary>None SameSite type. No restrictions on cross-site requests.</summary>
	None,
	/// <summary>Lax SameSite type. The cookie will be sent with "same-site" requests, and with "cross-site" top level navigation.</summary>
	Lax,
	/// <summary>Strict SameSite type. The cookie will only be sent along with "same-site" requests.</summary>
	Strict
}
