using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" /> event.</summary>
/// <summary></summary>
public class CoreWebView2WebMessageReceivedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgsValue;

	internal ICoreWebView2WebMessageReceivedEventArgs2 _nativeICoreWebView2WebMessageReceivedEventArgs2Value;

	private long _memoryUsage;

	internal ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2WebMessageReceivedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2WebMessageReceivedEventArgsValue = (ICoreWebView2WebMessageReceivedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebMessageReceivedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2WebMessageReceivedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Gets the URI of the document that sent this web message.</summary>
	public string Source
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebMessageReceivedEventArgs.Source;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the message posted from the WebView content to the host converted to a JSON string.
	/// </summary><remarks>
	/// Run this operation to communicate using JavaScript objects.
	/// </remarks>
	public string WebMessageAsJson
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebMessageReceivedEventArgs.WebMessageAsJson;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2WebMessageReceivedEventArgs2 _nativeICoreWebView2WebMessageReceivedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2WebMessageReceivedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2WebMessageReceivedEventArgs2Value = (ICoreWebView2WebMessageReceivedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebMessageReceivedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2WebMessageReceivedEventArgs2Value = value;
		}
	}

	/// <summary>
	/// Additional received WebMessage objects.
	/// </summary><remarks>
	/// To pass <c>AdditionalObjects</c> via WebMessage to the app, use the <c>chrome.webview.postMessageWithAdditionalObjects</c> content API. Any DOM object type that can be natively representable that has been passed in to <c>additionalObjects</c> parameter will be accessible here. Currently a WebMessage object can be the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2File" /> type.
	/// Entries in the collection can be <c>nullptr</c> if <c>null</c> or <c>undefined</c> was passed. Cast the object to the native type to access its specific properties.
	/// </remarks>
	public IReadOnlyList<object> AdditionalObjects
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.objectCollectionCOMToNet(_nativeICoreWebView2WebMessageReceivedEventArgs2.AdditionalObjects);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	private void Initialize()
	{
		if (_rawNative != null && _rawNative is ICoreWebView2PrivateLargeUnmanagedResource coreWebView2PrivateLargeUnmanagedResource)
		{
			_memoryUsage = coreWebView2PrivateLargeUnmanagedResource.GetMemoryUsage();
			GC.AddMemoryPressure(_memoryUsage);
		}
	}

	internal CoreWebView2WebMessageReceivedEventArgs(object rawCoreWebView2WebMessageReceivedEventArgs)
	{
		_rawNative = rawCoreWebView2WebMessageReceivedEventArgs;
		Initialize();
	}

	/// <summary>
	/// Gets the message posted from the WebView content to the host as a string.
	/// <returns>The message posted from the WebView content to the host.</returns><exception cref="T:System.ArgumentException">The message posted is some other kind of JavaScript type.</exception></summary><remarks>
	/// Run this operation to communicate using simple strings.
	/// </remarks>
	public string TryGetWebMessageAsString()
	{
		try
		{
			return _nativeICoreWebView2WebMessageReceivedEventArgs.TryGetWebMessageAsString();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2WebMessageReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	~CoreWebView2WebMessageReceivedEventArgs()
	{
		if (_memoryUsage != 0L)
		{
			GC.RemoveMemoryPressure(_memoryUsage);
		}
	}
}
