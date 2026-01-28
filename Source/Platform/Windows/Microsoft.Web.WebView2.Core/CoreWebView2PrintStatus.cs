namespace Microsoft.Web.WebView2.Core;

/// <summary>Indicates the status for printing.</summary>
public enum CoreWebView2PrintStatus
{
	/// <summary>Indicates that the print operation is succeeded.</summary>
	Succeeded,
	/// <summary>Indicates that the printer is not available.</summary>
	PrinterUnavailable,
	/// <summary>Indicates that the print operation is failed.</summary>
	OtherError
}
