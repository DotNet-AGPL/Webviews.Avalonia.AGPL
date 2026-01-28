using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// An HTTP request used with the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event.</summary>
public class CoreWebView2WebResourceRequest
{
	internal object _rawNative;

	internal ICoreWebView2WebResourceRequest _nativeICoreWebView2WebResourceRequestValue;

	internal ICoreWebView2WebResourceRequest _nativeICoreWebView2WebResourceRequest
	{
		get
		{
			if (_nativeICoreWebView2WebResourceRequestValue == null)
			{
				try
				{
					_nativeICoreWebView2WebResourceRequestValue = (ICoreWebView2WebResourceRequest)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebResourceRequestValue;
		}
		set
		{
			_nativeICoreWebView2WebResourceRequestValue = value;
		}
	}

	/// <summary>
	/// Gets or sets the HTTP request message body as stream.
	/// </summary><remarks>
	/// POST data should be here. If a stream is set, which overrides the message body, the stream must have all the content data available by the time the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event deferral of this request is completed. Stream should be agile or be created from a background STA to prevent performance impact to the UI thread. <c>null</c> means no content data.
	/// </remarks><seealso cref="T:System.IO.Stream" />
	public Stream Content
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.StreamCOMToNet(_nativeICoreWebView2WebResourceRequest.Content);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2WebResourceRequest.Content = ((value == null) ? null : new ManagedIStream(value));
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Gets the mutable HTTP request headers.</summary>
	public CoreWebView2HttpRequestHeaders Headers
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2WebResourceRequest.Headers == null) ? null : new CoreWebView2HttpRequestHeaders(_nativeICoreWebView2WebResourceRequest.Headers);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The HTTP request method.</summary>
	public string Method
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebResourceRequest.Method;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2WebResourceRequest.Method = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The request URI.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebResourceRequest.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2WebResourceRequest.Uri = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequest members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2WebResourceRequest(object rawCoreWebView2WebResourceRequest)
	{
		_rawNative = rawCoreWebView2WebResourceRequest;
	}
}
