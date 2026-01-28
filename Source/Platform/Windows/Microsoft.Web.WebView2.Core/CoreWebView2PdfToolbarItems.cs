using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the PDF toolbar item types used for the `ICoreWebView2Settings::put_HiddenPdfToolbarItems` method.</summary>
[Flags]
public enum CoreWebView2PdfToolbarItems
{
	/// <summary>No item.</summary>
	None = 0,
	/// <summary>The save button.</summary>
	Save = 1,
	/// <summary>The print button.</summary>
	Print = 2,
	/// <summary>The save as button.</summary>
	SaveAs = 4,
	/// <summary>The zoom in button.</summary>
	ZoomIn = 8,
	/// <summary>The zoom out button.</summary>
	ZoomOut = 0x10,
	/// <summary>The rotate button.</summary>
	Rotate = 0x20,
	/// <summary>The fit page button.</summary>
	FitPage = 0x40,
	/// <summary>The page layout button.</summary>
	PageLayout = 0x80,
	/// <summary>The bookmarks button.</summary>
	Bookmarks = 0x100,
	/// <summary>The page select button.</summary>
	PageSelector = 0x200,
	/// <summary>The search button.</summary>
	Search = 0x400,
	/// <summary>The full screen button.</summary>
	FullScreen = 0x800,
	/// <summary>The more settings button.</summary>
	MoreSettings = 0x1000
}
