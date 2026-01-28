namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the web resource request contexts.</summary>
public enum CoreWebView2WebResourceContext
{
	/// <summary>Specifies all resources.</summary>
	All,
	/// <summary>Specifies a document resource.</summary>
	Document,
	/// <summary>Specifies a CSS resource.</summary>
	Stylesheet,
	/// <summary>Specifies an image resource.</summary>
	Image,
	/// <summary>Specifies another media resource such as a video.</summary>
	Media,
	/// <summary>Specifies a font resource.</summary>
	Font,
	/// <summary>Specifies a script resource.</summary>
	Script,
	/// <summary>Specifies an XML HTTP request, Fetch and EventSource API communication.</summary>
	XmlHttpRequest,
	/// <summary>Specifies a Fetch API communication.</summary>
	Fetch,
	/// <summary>Specifies a TextTrack resource.</summary>
	TextTrack,
	/// <summary>Specifies an EventSource API communication.</summary>
	EventSource,
	/// <summary>Specifies a WebSocket API communication.</summary>
	Websocket,
	/// <summary>Specifies a Web App Manifest.</summary>
	Manifest,
	/// <summary>Specifies a Signed HTTP Exchange.</summary>
	SignedExchange,
	/// <summary>Specifies a Ping request.</summary>
	Ping,
	/// <summary>Specifies a CSP Violation Report.</summary>
	CspViolationReport,
	/// <summary>Specifies an other resource.</summary>
	Other
}
