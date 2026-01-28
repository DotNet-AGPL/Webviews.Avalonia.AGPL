using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> event.</summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2ProcessFailedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgsValue;

	internal ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2Value;

	internal ICoreWebView2ProcessFailedEventArgs3 _nativeICoreWebView2ProcessFailedEventArgs3Value;

	internal ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2ProcessFailedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2ProcessFailedEventArgsValue = (ICoreWebView2ProcessFailedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ProcessFailedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2ProcessFailedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Gets the kind of process failure that has occurred.
	/// </summary><remarks><c>ProcessFailedKind</c> is a combination of process kind (for example, browser, renderer, gpu) and failure (exit, unresponsiveness). Renderer processes are further divided in main frame renderer (<c>RenderProcessExited</c>, <c>RenderProcessUnresponsive</c>) and subframe renderer (<c>FrameRenderProcessExited</c>). To learn about the conditions under which each failure kind occurs, see <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind" />.
	/// </remarks>
	public CoreWebView2ProcessFailedKind ProcessFailedKind
	{
		get
		{
			try
			{
				return (CoreWebView2ProcessFailedKind)_nativeICoreWebView2ProcessFailedEventArgs.ProcessFailedKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2ProcessFailedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2ProcessFailedEventArgs2Value = (ICoreWebView2ProcessFailedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ProcessFailedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2ProcessFailedEventArgs2Value = value;
		}
	}

	/// <summary>
	/// Gets the exit code of the failing process, for telemetry purposes.</summary><remarks>
	/// The exit code is always <c>1</c> when <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind" /> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.BrowserProcessExited" />, and <c>STILL_ACTIVE</c>(<c>259</c>) when <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind" /> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.RenderProcessUnresponsive" />.
	/// </remarks>
	public int ExitCode
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ProcessFailedEventArgs2.ExitCode;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the collection of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" />s for frames in the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" /> that were being rendered by the failed process.
	/// </summary><remarks>
	/// The content in these frames is replaced with an error page.
	/// This is only available when <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind" /> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.FrameRenderProcessExited" />; the returned collection is empty for all other process failure kinds, including the case in which the failed process was the renderer for the main frame and subframes within it, for which the failure kind is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.RenderProcessExited" />.
	/// </remarks>
	public IReadOnlyList<CoreWebView2FrameInfo> FrameInfosForFailedProcess
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.CoreWebView2FrameInfoCollectionCOMToNet(_nativeICoreWebView2ProcessFailedEventArgs2.FrameInfosForFailedProcess);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets a description of the failing process, assigned by the WebView2 Runtime.
	/// </summary><remarks>
	/// This is a technical English term appropriate for logging or development purposes, and not localized for the end user. It applies to utility processes (for example, "Audio Service", "Video Capture") and plugin processes (for example, "Flash"). The returned string is empty if the WebView2 Runtime did not assign a description to the process.
	/// </remarks>
	public string ProcessDescription
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ProcessFailedEventArgs2.ProcessDescription;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the reason for the process failure.</summary><remarks>
	/// Some of the reasons are only applicable to specific values of <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind" />, and the following <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind" /> values always return the indicated reason value:
	/// <list type="table"><listheader><term>ProcessFailedKind</term><description>Reason</description></listheader><item><term><c>BrowserProcessExited</c></term><description><c>Unexpected</c></description></item><item><term><c>RenderProcessUnresponsive</c></term><description><c>Unresponsive</c></description></item></list>
	/// For other <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind" /> values, the reason may be any of the reason values. To learn about what these values mean, see <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedReason" />.
	/// </remarks>
	public CoreWebView2ProcessFailedReason Reason
	{
		get
		{
			try
			{
				return (CoreWebView2ProcessFailedReason)_nativeICoreWebView2ProcessFailedEventArgs2.Reason;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2ProcessFailedEventArgs3 _nativeICoreWebView2ProcessFailedEventArgs3
	{
		get
		{
			if (_nativeICoreWebView2ProcessFailedEventArgs3Value == null)
			{
				try
				{
					_nativeICoreWebView2ProcessFailedEventArgs3Value = (ICoreWebView2ProcessFailedEventArgs3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ProcessFailedEventArgs3Value;
		}
		set
		{
			_nativeICoreWebView2ProcessFailedEventArgs3Value = value;
		}
	}

	/// <summary>
	/// When ProcessFailed occurred due to a failed Code Integrity check, this property returns the full path of the file that was prevented from loading on the system.
	/// The webview2 process which tried to load the DLL will fail with exit code STATUS_INVALID_IMAGE_HASH(-1073740760).</summary>
	public string FailureSourceModulePath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ProcessFailedEventArgs3.FailureSourceModulePath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessFailedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ProcessFailedEventArgs(object rawCoreWebView2ProcessFailedEventArgs)
	{
		_rawNative = rawCoreWebView2ProcessFailedEventArgs;
	}
}
