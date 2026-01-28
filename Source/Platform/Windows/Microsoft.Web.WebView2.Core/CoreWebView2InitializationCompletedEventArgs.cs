using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the CoreWebView2InitializationCompleted event.
/// </summary>
public class CoreWebView2InitializationCompletedEventArgs : EventArgs
{
	/// <summary>
	/// True if the init task completed successfully.
	/// </summary>
	public bool IsSuccess => InitializationException == null;

	/// <summary>
	/// The exception thrown from the init task. If the task completed successfully, this property is null.
	/// </summary>
	public Exception InitializationException { get; private set; }

	/// <summary>
	/// Initializes a new instance of the CoreWebView2InitializationCompletedEventArgs class.
	/// </summary>
	/// <param name="ex">
	/// Exception that occurred during initialization, or null if initialization was successful.
	/// </param> 
	public CoreWebView2InitializationCompletedEventArgs(Exception ex = null)
	{
		InitializationException = ex;
	}
}
