namespace Microsoft.Web.WebView2.Core;

/// <summary>State of the download operation.</summary>
public enum CoreWebView2DownloadState
{
	/// <summary>The download is in progress.</summary>
	InProgress,
	/// <summary>The connection with the file host was broken. The `InterruptReason` property
	/// can be accessed from `ICoreWebView2DownloadOperation`. See
	/// `COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON` for descriptions of kinds of
	/// interrupt reasons. Host can check whether an interrupted download can be
	/// resumed with the `CanResume` property on the `ICoreWebView2DownloadOperation`.
	/// Once resumed, a download is in the `COREWEBVIEW2_DOWNLOAD_STATE_IN_PROGRESS` state.</summary>
	Interrupted,
	/// <summary>The download completed successfully.</summary>
	Completed
}
