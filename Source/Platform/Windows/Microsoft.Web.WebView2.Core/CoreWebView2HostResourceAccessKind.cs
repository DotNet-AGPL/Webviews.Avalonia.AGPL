namespace Microsoft.Web.WebView2.Core;

/// <summary>Kind of cross origin resource access allowed for host resources during download.
/// Note that other normal access checks like same origin DOM access check and [Content
/// Security Policy](https://developer.mozilla.org/docs/Web/HTTP/CSP) still apply.
///
/// The following table illustrates the host resource cross origin access according to
/// access context and `CoreWebView2HostResourceAccessKind`.
///
/// <list type="table"><listheader><description>Cross Origin Access Context</description><description>Deny</description><description>Allow</description><description>DenyCors</description></listheader><item><description>From DOM like src of img, script or iframe element</description><description>Deny</description><description>Allow</description><description>Allow</description></item><item><description>From Script like Fetch or XMLHttpRequest</description><description>Deny</description><description>Allow</description><description>Deny</description></item></list></summary>
public enum CoreWebView2HostResourceAccessKind
{
	/// <summary>All cross origin resource access is denied, including normal sub resource access
	/// as src of a script or image element.</summary>
	Deny,
	/// <summary>All cross origin resource access is allowed, including accesses that are
	/// subject to Cross-Origin Resource Sharing(CORS) check. The behavior is similar to
	/// a web site sends back http header Access-Control-Allow-Origin: *.</summary>
	Allow,
	/// <summary>Cross origin resource access is allowed for normal sub resource access like
	/// as src of a script or image element, while any access that subjects to CORS check
	/// will be denied.
	/// See [Cross-Origin Resource Sharing](https://developer.mozilla.org/docs/Web/HTTP/CORS)
	/// for more information.</summary>
	DenyCors
}
