using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the source of `WebResourceRequested` event.</summary>
[Flags]
public enum CoreWebView2WebResourceRequestSourceKinds
{
	None = 0,
	/// <summary>Indicates that web resource is requested from main page including dedicated workers,
	/// iframes and main script for shared workers.</summary>
	Document = 1,
	/// <summary>Indicates that web resource is requested from shared worker.</summary>
	SharedWorker = 2,
	/// <summary>Indicates that web resource is requested from service worker.</summary>
	ServiceWorker = 4,
	/// <summary>Indicates that web resource is requested from any supported source.</summary>
	All = -1
}
