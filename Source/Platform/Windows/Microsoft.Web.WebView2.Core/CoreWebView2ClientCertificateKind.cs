namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the client certificate kind.</summary>
public enum CoreWebView2ClientCertificateKind
{
	/// <summary>Specifies smart card certificate.</summary>
	SmartCard,
	/// <summary>Specifies PIN certificate.</summary>
	Pin,
	/// <summary>Specifies other certificate.</summary>
	Other
}
