using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// The result for <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.ExecuteScriptWithResultAsync(System.String)" />.</summary>
public class CoreWebView2ExecuteScriptResult
{
	internal object _rawNative;

	internal ICoreWebView2ExecuteScriptResult _nativeICoreWebView2ExecuteScriptResultValue;

	internal ICoreWebView2ExecuteScriptResult _nativeICoreWebView2ExecuteScriptResult
	{
		get
		{
			if (_nativeICoreWebView2ExecuteScriptResultValue == null)
			{
				try
				{
					_nativeICoreWebView2ExecuteScriptResultValue = (ICoreWebView2ExecuteScriptResult)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExecuteScriptResult.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExecuteScriptResultValue;
		}
		set
		{
			_nativeICoreWebView2ExecuteScriptResultValue = value;
		}
	}

	/// <summary>
	/// If Succeeded is false, you can use this property to get the unhandled exception thrown by script execution</summary>
	public CoreWebView2ScriptException Exception
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2ExecuteScriptResult.Exception == null) ? null : new CoreWebView2ScriptException(_nativeICoreWebView2ExecuteScriptResult.Exception);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// A function that has no explicit return value returns undefined. If the script that was run throws an unhandled exception, then the result is also null.</summary>
	public string ResultAsJson
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExecuteScriptResult.ResultAsJson;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// This property is true if <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.ExecuteScriptWithResultAsync(System.String)" /> successfully executed script with no unhandled exceptions and the result is available in the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ExecuteScriptResult.ResultAsJson" /> property.</summary>
	public bool Succeeded
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExecuteScriptResult.Succeeded != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ExecuteScriptResult(object rawCoreWebView2ExecuteScriptResult)
	{
		_rawNative = rawCoreWebView2ExecuteScriptResult;
	}

	public void TryGetResultAsString(out string stringResult, out int value)
	{
		try
		{
			_nativeICoreWebView2ExecuteScriptResult.TryGetResultAsString(out stringResult, out value);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2ExecuteScriptResult members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
