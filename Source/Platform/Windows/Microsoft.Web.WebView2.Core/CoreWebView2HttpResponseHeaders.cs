using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// HTTP response headers.
/// </summary><remarks>
/// Used to construct a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse" /> for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event.
/// </remarks>
public class CoreWebView2HttpResponseHeaders : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	internal object _rawNative;

	internal ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeadersValue;

	internal ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeaders
	{
		get
		{
			if (_nativeICoreWebView2HttpResponseHeadersValue == null)
			{
				try
				{
					_nativeICoreWebView2HttpResponseHeadersValue = (ICoreWebView2HttpResponseHeaders)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2HttpResponseHeadersValue;
		}
		set
		{
			_nativeICoreWebView2HttpResponseHeadersValue = value;
		}
	}

	internal CoreWebView2HttpResponseHeaders(object rawCoreWebView2HttpResponseHeaders)
	{
		_rawNative = rawCoreWebView2HttpResponseHeaders;
	}

	/// <summary>Appends header line with name and value.
	/// </summary><param name="name">The header name to be appended.</param><param name="value">The header value to be appended.</param>
	public void AppendHeader(string name, string value)
	{
		try
		{
			_nativeICoreWebView2HttpResponseHeaders.AppendHeader(name, value);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Checks whether this CoreWebView2HttpResponseHeaders contain entries matching the header name.
	/// </summary><param name="name">The name of the header to seek.</param>
	public bool Contains(string name)
	{
		try
		{
			return _nativeICoreWebView2HttpResponseHeaders.Contains(name) != 0;
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Gets the first header value in the collection matching the name.
	/// </summary><param name="name">The header name.</param><returns>The first header value in the collection matching the name.</returns>
	public string GetHeader(string name)
	{
		try
		{
			return _nativeICoreWebView2HttpResponseHeaders.GetHeader(name);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Gets the header values matching the name.</summary>
	public CoreWebView2HttpHeadersCollectionIterator GetHeaders(string name)
	{
		try
		{
			return new CoreWebView2HttpHeadersCollectionIterator(_nativeICoreWebView2HttpResponseHeaders.GetHeaders(name));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Gets a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator" /> over the collection of entire <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders" />.</summary>
	public CoreWebView2HttpHeadersCollectionIterator GetIterator()
	{
		try
		{
			return new CoreWebView2HttpHeadersCollectionIterator(_nativeICoreWebView2HttpResponseHeaders.GetIterator());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpResponseHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <inheritdoc />
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	/// <inheritdoc />
	IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
	{
		return GetEnumerator();
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders" /> or <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders" /> collection.
	/// </summary>
	public CoreWebView2HttpHeadersCollectionIterator GetEnumerator()
	{
		return GetIterator();
	}
}
