using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>The event args for `SaveFileSecurityCheckStarting` event.</summary>
public class CoreWebView2SaveFileSecurityCheckStartingEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2SaveFileSecurityCheckStartingEventArgs _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgsValue;

	internal ICoreWebView2SaveFileSecurityCheckStartingEventArgs _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs
	{
		get
		{
			if (_nativeICoreWebView2SaveFileSecurityCheckStartingEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2SaveFileSecurityCheckStartingEventArgsValue = (ICoreWebView2SaveFileSecurityCheckStartingEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SaveFileSecurityCheckStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2SaveFileSecurityCheckStartingEventArgsValue = value;
		}
	}

	/// <summary>
	/// Set if cancel the upcoming save/download.</summary>
	public bool CancelSave
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.CancelSave != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.CancelSave = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Get the document origin URI of this file save operation.</summary>
	public string DocumentOriginUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.DocumentOriginUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Get the extension of file to be saved.</summary>
	public string FileExtension
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.FileExtension;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Get the full path of file to be saved. This includes the file name and extension.</summary>
	public string FilePath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.FilePath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Set if the default policy checking and security warning will be suppressed.</summary>
	public bool SuppressDefaultPolicy
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.SuppressDefaultPolicy != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.SuppressDefaultPolicy = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2SaveFileSecurityCheckStartingEventArgs(object rawCoreWebView2SaveFileSecurityCheckStartingEventArgs)
	{
		_rawNative = rawCoreWebView2SaveFileSecurityCheckStartingEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object.
	/// </summary><remarks>
	/// It will put the event into a deferred state. The default policy checking and any default UI will be blocked temporarily, saving file to local won't start, until the deferral is completed.
	/// </remarks>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2SaveFileSecurityCheckStartingEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2SaveFileSecurityCheckStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
