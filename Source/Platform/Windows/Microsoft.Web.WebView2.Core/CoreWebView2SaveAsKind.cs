namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies Save As kind selection options for
/// `ICoreWebView2SaveAsUIShowingEventArgs`.
///
/// For HTML documents, we support 3 Save As kinds: HTML_ONLY, SINGLE_FILE and
/// COMPLETE. For non-HTML documents, you must use DEFAULT. MIME types of `text/html` and
/// `application/xhtml+xml` are considered HTML documents.</summary>
public enum CoreWebView2SaveAsKind
{
	/// <summary>Default kind to save non-HTML content. If this kind is selected for an HTML
	/// page, the behavior is the same as the `HTML_ONLY` kind.</summary>
	Default,
	/// <summary>Save the page as HTML. Only the top-level document is saved, excluding
	/// subresources.</summary>
	HtmlOnly,
	/// <summary>Save the page as [MHTML](https://en.wikipedia.org/wiki/MHTML).</summary>
	SingleFile,
	/// <summary>Save the page as HTML and download the page-related source files
	/// (for example: CSS, JavaScript, images, etc.) in a directory with
	/// the same filename prefix.</summary>
	Complete
}
