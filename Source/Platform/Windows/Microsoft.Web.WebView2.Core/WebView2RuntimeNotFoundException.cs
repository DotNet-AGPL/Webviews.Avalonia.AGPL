using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// The exception that is thrown when an WebView2 Runtime installation is missing.
/// </summary>
[Serializable]
public class WebView2RuntimeNotFoundException : Exception
{
	/// <summary>
	/// Initializes a new instance of the WebView2RuntimeNotFoundException class.
	/// </summary>
	public WebView2RuntimeNotFoundException()
		: this((Exception)null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the WebView2RuntimeNotFoundException class with a specified error message.
	/// </summary>
	/// <param name="message">
	/// The error message that explains the reason for the exception.
	/// </param>
	public WebView2RuntimeNotFoundException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the WebView2RuntimeNotFoundException class with a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="inner">
	/// The exception that is the cause of the current exception.
	/// </param>
	public WebView2RuntimeNotFoundException(Exception inner)
		: base("Couldn't find a compatible Webview2 Runtime installation to host WebViews.", inner)
	{
	}

	/// <summary>
	/// Initializes a new instance of the WebView2RuntimeNotFoundException class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">
	/// The error message that explains the reason for the exception.
	/// </param>
	/// <param name="inner">
	/// The exception that is the cause of the current exception.
	/// </param>
	public WebView2RuntimeNotFoundException(string message, Exception inner)
		: base(message, inner)
	{
	}
}
