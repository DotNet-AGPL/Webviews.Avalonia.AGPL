namespace Microsoft.Web.WebView2.Core;

/// <summary>Mode for how the Bounds property is interpreted in relation to the RasterizationScale property.</summary>
public enum CoreWebView2BoundsMode
{
	/// <summary>Bounds property represents raw pixels. Physical size of Webview is not impacted by RasterizationScale.</summary>
	UseRawPixels,
	/// <summary>Bounds property represents logical pixels and the RasterizationScale property is used to get the physical size of the WebView.</summary>
	UseRasterizationScale
}
