namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the action type when server certificate error is detected to be
/// used in the `ICoreWebView2ServerCertificateErrorDetectedEventArgs`
/// interface.</summary>
public enum CoreWebView2ServerCertificateErrorAction
{
	/// <summary>Indicates to ignore the warning and continue the request with the TLS
	/// certificate. This decision is cached for the RequestUri's host and the
	/// server certificate in the session.</summary>
	AlwaysAllow,
	/// <summary>Indicates to reject the certificate and cancel the request.</summary>
	Cancel,
	/// <summary>Indicates to display the default TLS interstitial error page to user for
	/// page navigations.
	/// For others TLS certificate is rejected and the request is cancelled.</summary>
	Default
}
