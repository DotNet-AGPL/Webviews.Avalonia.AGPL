using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceResponseReceived" /> event.</summary>
public class CoreWebView2WebResourceResponseReceivedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2WebResourceResponseReceivedEventArgs _nativeICoreWebView2WebResourceResponseReceivedEventArgsValue;

	internal ICoreWebView2WebResourceResponseReceivedEventArgs _nativeICoreWebView2WebResourceResponseReceivedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2WebResourceResponseReceivedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2WebResourceResponseReceivedEventArgsValue = (ICoreWebView2WebResourceResponseReceivedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebResourceResponseReceivedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2WebResourceResponseReceivedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Gets the request object for the web resource, as committed.
	/// </summary><remarks>
	/// This includes headers added by the network stack that were not be included during the associated <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event, such as Authentication headers. Modifications to this object have no effect on how the request is processed as it has already been sent.
	/// </remarks>
	public CoreWebView2WebResourceRequest Request
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2WebResourceResponseReceivedEventArgs.Request == null) ? null : new CoreWebView2WebResourceRequest(_nativeICoreWebView2WebResourceResponseReceivedEventArgs.Request);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>View of the response object received for the web resource.</summary>
	public CoreWebView2WebResourceResponseView Response
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2WebResourceResponseReceivedEventArgs.Response == null) ? null : new CoreWebView2WebResourceResponseView(_nativeICoreWebView2WebResourceResponseReceivedEventArgs.Response);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2WebResourceResponseReceivedEventArgs(object rawCoreWebView2WebResourceResponseReceivedEventArgs)
	{
		_rawNative = rawCoreWebView2WebResourceResponseReceivedEventArgs;
	}
}
