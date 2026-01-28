namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the desired access from script to `CoreWebView2SharedBuffer`.</summary>
public enum CoreWebView2SharedBufferAccess
{
	/// <summary>Script from web page only has read access to the shared buffer.</summary>
	ReadOnly,
	/// <summary>Script from web page has read and write access to the shared buffer.</summary>
	ReadWrite
}
