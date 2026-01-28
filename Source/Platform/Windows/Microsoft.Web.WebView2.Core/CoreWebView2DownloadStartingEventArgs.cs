using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.DownloadStarting" /> event.</summary>
public class CoreWebView2DownloadStartingEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2DownloadStartingEventArgs _nativeICoreWebView2DownloadStartingEventArgsValue;

	internal ICoreWebView2DownloadStartingEventArgs _nativeICoreWebView2DownloadStartingEventArgs
	{
		get
		{
			if (_nativeICoreWebView2DownloadStartingEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2DownloadStartingEventArgsValue = (ICoreWebView2DownloadStartingEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2DownloadStartingEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2DownloadStartingEventArgsValue = value;
		}
	}

	/// <summary>
	/// Indicates whether to cancel the download.
	/// If canceled, the download save dialog is not displayed regardless of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs.Handled" /> value and the state is changed to <c>CoreWebView2DownloadState.Interrupted</c> with interrupt reason <c>CoreWebView2DownloadInterruptReason.UserCanceled</c>.</summary>
	public bool Cancel
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadStartingEventArgs.Cancel != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2DownloadStartingEventArgs.Cancel = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2DownloadOperation" /> for the download that has started.</summary>
	public CoreWebView2DownloadOperation DownloadOperation
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2DownloadStartingEventArgs.DownloadOperation == null) ? null : new CoreWebView2DownloadOperation(_nativeICoreWebView2DownloadStartingEventArgs.DownloadOperation);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Indicates whether to hide the default download dialog.
	/// </summary><remarks>
	/// If set to true, the default download dialog is hidden for this download. The download progresses normally if it is not canceled, there will just be no default UI shown. By default the value is false and the default download dialog is shown.
	/// </remarks>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadStartingEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2DownloadStartingEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The path to the file.
	/// </summary><remarks>
	/// If setting the path, the host should ensure that it is an absolute path, including the file name, and that the path does not point to an existing file. If the path points to an existing file, the file will be overwritten. If the directory does not exist, it is created.
	/// </remarks>
	public string ResultFilePath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadStartingEventArgs.ResultFilePath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2DownloadStartingEventArgs.ResultFilePath = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2DownloadStartingEventArgs(object rawCoreWebView2DownloadStartingEventArgs)
	{
		_rawNative = rawCoreWebView2DownloadStartingEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object.
	/// Use this to Complete the event at a later time.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2DownloadStartingEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2DownloadStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
