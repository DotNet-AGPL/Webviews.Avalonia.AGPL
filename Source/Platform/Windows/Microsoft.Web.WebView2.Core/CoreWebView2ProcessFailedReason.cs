namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the process failure reason used in the
/// `ICoreWebView2ProcessFailedEventArgs` interface. For process failures where
/// a process has exited, it indicates the type of issue that produced the
/// process exit.</summary>
public enum CoreWebView2ProcessFailedReason
{
	/// <summary>An unexpected process failure occurred.</summary>
	Unexpected,
	/// <summary>The process became unresponsive.
	/// This only applies to the main frame's render process.</summary>
	Unresponsive,
	/// <summary>The process was terminated. For example, from Task Manager.</summary>
	Terminated,
	/// <summary>The process crashed. Most crashes will generate dumps in the location
	/// indicated by `ICoreWebView2Environment11::get_FailureReportFolderPath`.</summary>
	Crashed,
	/// <summary>The process failed to launch.</summary>
	LaunchFailed,
	/// <summary>The process terminated due to running out of memory.</summary>
	OutOfMemory,
	/// <summary>Deprecated. This value is unused.</summary>
	ProfileDeleted
}
