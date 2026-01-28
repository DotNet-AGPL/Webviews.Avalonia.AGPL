namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the duplex option for a print.</summary>
public enum CoreWebView2PrintDuplex
{
	/// <summary>The default duplex for a printer.</summary>
	Default,
	/// <summary>Print on only one side of the sheet.</summary>
	OneSided,
	/// <summary>Print on both sides of the sheet, flipped along the long edge.</summary>
	TwoSidedLongEdge,
	/// <summary>Print on both sides of the sheet, flipped along the short edge.</summary>
	TwoSidedShortEdge
}
