using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Representation of a DOM [File](https://developer.mozilla.org/docs/Web/API/File) object passed via WebMessage.
/// </summary><remarks>
/// You can use this object to obtain the path of a File dropped on WebView2.
/// </remarks>
public class CoreWebView2File
{
	internal object _rawNative;

	internal ICoreWebView2File _nativeICoreWebView2FileValue;

	internal ICoreWebView2File _nativeICoreWebView2File
	{
		get
		{
			if (_nativeICoreWebView2FileValue == null)
			{
				try
				{
					_nativeICoreWebView2FileValue = (ICoreWebView2File)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2File.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FileValue;
		}
		set
		{
			_nativeICoreWebView2FileValue = value;
		}
	}

	/// <summary>
	/// The absolute file path.</summary>
	public string Path
	{
		get
		{
			try
			{
				return _nativeICoreWebView2File.Path;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2File members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2File members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2File(object rawCoreWebView2File)
	{
		_rawNative = rawCoreWebView2File;
	}
}
