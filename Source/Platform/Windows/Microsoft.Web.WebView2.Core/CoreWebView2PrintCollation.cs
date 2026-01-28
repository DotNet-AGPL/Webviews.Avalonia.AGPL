namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the collation for a print.</summary>
public enum CoreWebView2PrintCollation
{
	/// <summary>The default collation for a printer.</summary>
	Default,
	/// <summary>Indicate that the collation has been selected for the printed output.</summary>
	Collated,
	/// <summary>Indicate that the collation has not been selected for the printed output.</summary>
	Uncollated
}
