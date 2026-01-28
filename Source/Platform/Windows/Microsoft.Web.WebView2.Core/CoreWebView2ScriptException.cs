using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>This represents a JavaScript exception.</summary>
public class CoreWebView2ScriptException
{
	internal object _rawNative;

	internal ICoreWebView2ScriptException _nativeICoreWebView2ScriptExceptionValue;

	internal ICoreWebView2ScriptException _nativeICoreWebView2ScriptException
	{
		get
		{
			if (_nativeICoreWebView2ScriptExceptionValue == null)
			{
				try
				{
					_nativeICoreWebView2ScriptExceptionValue = (ICoreWebView2ScriptException)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptException.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ScriptExceptionValue;
		}
		set
		{
			_nativeICoreWebView2ScriptExceptionValue = value;
		}
	}

	/// <summary>The column number of the source where the exception occurred. Note that this position starts at 0.</summary>
	public uint ColumnNumber
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptException.ColumnNumber;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The line number of the source where the exception occurred. Note that this position starts at 0.</summary>
	public uint LineNumber
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptException.LineNumber;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The Message is the exception's message and potentially stack.</summary>
	public string Message
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptException.Message;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The Name is the exception's class name.</summary>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptException.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>This will return all details of the exception as a JSON string.</summary>
	public string ToJson
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptException.ToJson;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptException members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ScriptException(object rawCoreWebView2ScriptException)
	{
		_rawNative = rawCoreWebView2ScriptException;
	}
}
