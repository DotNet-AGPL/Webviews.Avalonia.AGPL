namespace Microsoft.Web.WebView2.Core;

/// <summary>Status of a programmatic Save As call. Indicates the result
/// of the `ShowSaveAsUI` method.</summary>
public enum CoreWebView2SaveAsUIResult
{
	/// <summary>The ShowSaveAsUI method call completed successfully. By default, the system
	/// Save As dialog opens. If `SuppressDefaultDialog` is set to TRUE, the system
	/// dialog is skipped.</summary>
	Success,
	/// <summary>Could not perform Save As because the destination file path is an invalid path.
	///
	/// The path is invalid when it is empty, a relative path, or a directory,
	/// or when the parent path does not exist.</summary>
	InvalidPath,
	/// <summary>Could not perform Save As because the destination file path already exists and
	/// replacing files was not allowed by the `AllowReplace` property.</summary>
	FileAlreadyExists,
	/// <summary>Could not perform Save As because the `Kind` property selection is not
	/// supported due to content MIME type or system limits.
	///
	/// See the `COREWEBVIEW2_SAVE_AS_KIND` enum for MIME type limits.
	///
	/// System limits include when the `HTML_ONLY` kind is selected for an error page
	/// at child mode, or when the `COMPLETE` kind is selected and the WebView is
	/// running in an App Container.</summary>
	KindNotSupported,
	/// <summary>Did not perform Save As because the end user cancelled or the
	/// `Cancel` property on `ICoreWebView2SaveAsUIShowingEventArgs` was set to TRUE.</summary>
	Cancelled
}
