namespace Microsoft.Web.WebView2.Core;

/// <summary>Indicates the kind of context for which the context menu was created
/// for the `ICoreWebView2ContextMenuTarget::get_Kind` method.
/// This enum will always represent the active element that caused the context menu request.
/// If there is a selection with multiple images, audio and text, for example, the element that
/// the end user right clicks on within this selection will be the option represented by this enum.</summary>
public enum CoreWebView2ContextMenuTargetKind
{
	/// <summary>Indicates that the context menu was created for the page without any additional content.</summary>
	Page,
	/// <summary>Indicates that the context menu was created for an image element.</summary>
	Image,
	/// <summary>Indicates that the context menu was created for selected text.</summary>
	SelectedText,
	/// <summary>Indicates that the context menu was created for an audio element.</summary>
	Audio,
	/// <summary>Indicates that the context menu was created for a video element.</summary>
	Video
}
