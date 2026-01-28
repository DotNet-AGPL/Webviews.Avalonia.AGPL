using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// View of the HTTP representation for a web resource response.
/// </summary><remarks>
/// The properties of this object are not mutable. This response view is used with the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceResponseReceived" /> event.
/// </remarks>
public class CoreWebView2WebResourceResponseView
{
	internal object _rawNative;

	internal ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseViewValue;

	internal ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseView
	{
		get
		{
			if (_nativeICoreWebView2WebResourceResponseViewValue == null)
			{
				try
				{
					_nativeICoreWebView2WebResourceResponseViewValue = (ICoreWebView2WebResourceResponseView)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebResourceResponseViewValue;
		}
		set
		{
			_nativeICoreWebView2WebResourceResponseViewValue = value;
		}
	}

	/// <summary>The HTTP response headers as received.</summary>
	public CoreWebView2HttpResponseHeaders Headers
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2WebResourceResponseView.Headers == null) ? null : new CoreWebView2HttpResponseHeaders(_nativeICoreWebView2WebResourceResponseView.Headers);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseView members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseView members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The HTTP response reason phrase.</summary>
	public string ReasonPhrase
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebResourceResponseView.ReasonPhrase;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseView members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseView members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The HTTP response status code.</summary>
	public int StatusCode
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebResourceResponseView.StatusCode;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseView members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceResponseView members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2WebResourceResponseView(object rawCoreWebView2WebResourceResponseView)
	{
		_rawNative = rawCoreWebView2WebResourceResponseView;
	}

	/// <summary>
	/// Gets the response content stream asynchronously.
	/// <exception cref="T:System.Runtime.InteropServices.COMException">The content failed to load.</exception></summary><remarks>
	/// A <c>null</c> stream means no content was found. Note content (if any) for redirect responses is ignored.
	/// This method returns <c>null</c> if content size is more than 123MB. If <c>msWebView2EnableDownloadContentInWebResourceResponseReceived</c> feature flag is disabled, for navigations that become downloads or if response is downloadable content type (e.g., application/octet-stream), this method also returns <c>null</c>. See <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.DownloadStarting" /> event to handle the response or enable the feature flag. The Stream object that is returned will be thread-safe and as reads will be blocking while waiting for data to be available, it is recommended to read from a background thread.
	/// If this method is being called again before a first call has completed, it will complete at the same time all prior calls do.
	/// If this method is being called after a first call has completed, it will return immediately (asynchronously).
	/// </remarks>
	public async Task<Stream> GetContentAsync()
	{
		CoreWebView2WebResourceResponseViewGetContentCompletedHandler handler;
		try
		{
			handler = new CoreWebView2WebResourceResponseViewGetContentCompletedHandler();
			_nativeICoreWebView2WebResourceResponseView.GetContent(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2WebResourceResponseView members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2WebResourceResponseView members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}
}
