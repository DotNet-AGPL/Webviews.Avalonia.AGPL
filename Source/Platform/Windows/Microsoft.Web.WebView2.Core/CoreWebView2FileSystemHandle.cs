using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Representation of a DOM
/// [FileSystemHandle](https://developer.mozilla.org/docs/Web/API/FileSystemHandle)
/// object.</summary>
public class CoreWebView2FileSystemHandle
{
	internal object _rawNative;

	internal ICoreWebView2FileSystemHandle _nativeICoreWebView2FileSystemHandleValue;

	internal ICoreWebView2FileSystemHandle _nativeICoreWebView2FileSystemHandle
	{
		get
		{
			if (_nativeICoreWebView2FileSystemHandleValue == null)
			{
				try
				{
					_nativeICoreWebView2FileSystemHandleValue = (ICoreWebView2FileSystemHandle)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FileSystemHandle.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FileSystemHandleValue;
		}
		set
		{
			_nativeICoreWebView2FileSystemHandleValue = value;
		}
	}

	/// <summary>The kind of the FileSystemHandle. It can either be a file or a directory.</summary>
	public CoreWebView2FileSystemHandleKind Kind
	{
		get
		{
			try
			{
				return (CoreWebView2FileSystemHandleKind)_nativeICoreWebView2FileSystemHandle.Kind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FileSystemHandle members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FileSystemHandle members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The path to the FileSystemHandle.</summary>
	public string Path
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FileSystemHandle.Path;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FileSystemHandle members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FileSystemHandle members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The permissions granted to the FileSystemHandle.</summary>
	public CoreWebView2FileSystemHandlePermission Permission
	{
		get
		{
			try
			{
				return (CoreWebView2FileSystemHandlePermission)_nativeICoreWebView2FileSystemHandle.Permission;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FileSystemHandle members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FileSystemHandle members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2FileSystemHandle(object rawCoreWebView2FileSystemHandle)
	{
		_rawNative = rawCoreWebView2FileSystemHandle;
	}
}
