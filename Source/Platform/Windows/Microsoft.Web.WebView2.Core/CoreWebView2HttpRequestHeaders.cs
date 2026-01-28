using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// HTTP request headers.
/// </summary><remarks>
/// Used to inspect the HTTP request on <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event. It is possible to modify the HTTP request headers from a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event, but not from a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event.
/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" />
public class CoreWebView2HttpRequestHeaders : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	internal object _rawNative;

	internal ICoreWebView2HttpRequestHeaders _nativeICoreWebView2HttpRequestHeadersValue;

	internal ICoreWebView2HttpRequestHeaders _nativeICoreWebView2HttpRequestHeaders
	{
		get
		{
			if (_nativeICoreWebView2HttpRequestHeadersValue == null)
			{
				try
				{
					_nativeICoreWebView2HttpRequestHeadersValue = (ICoreWebView2HttpRequestHeaders)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2HttpRequestHeadersValue;
		}
		set
		{
			_nativeICoreWebView2HttpRequestHeadersValue = value;
		}
	}

	internal CoreWebView2HttpRequestHeaders(object rawCoreWebView2HttpRequestHeaders)
	{
		_rawNative = rawCoreWebView2HttpRequestHeaders;
	}

	/// <summary>Gets the header value matching the name.</summary>
	public string GetHeader(string name)
	{
		try
		{
			return _nativeICoreWebView2HttpRequestHeaders.GetHeader(name);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Gets the header value matching the name using a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator" />.
	/// <returns>The header value matching the name.</returns></summary>
	public CoreWebView2HttpHeadersCollectionIterator GetHeaders(string name)
	{
		try
		{
			return new CoreWebView2HttpHeadersCollectionIterator(_nativeICoreWebView2HttpRequestHeaders.GetHeaders(name));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Checks whether the headers contain an entry that matches the header name.</summary>
	public bool Contains(string name)
	{
		try
		{
			return _nativeICoreWebView2HttpRequestHeaders.Contains(name) != 0;
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Adds or updates header that matches the name.</summary>
	public void SetHeader(string name, string value)
	{
		try
		{
			_nativeICoreWebView2HttpRequestHeaders.SetHeader(name, value);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Removes header that matches the name.</summary>
	public void RemoveHeader(string name)
	{
		try
		{
			_nativeICoreWebView2HttpRequestHeaders.RemoveHeader(name);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Gets a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator" /> over the collection of request headers.</summary>
	public CoreWebView2HttpHeadersCollectionIterator GetIterator()
	{
		try
		{
			return new CoreWebView2HttpHeadersCollectionIterator(_nativeICoreWebView2HttpRequestHeaders.GetIterator());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2HttpRequestHeaders members cannot be accessed after the WebView2 control is disposed.", ex2);
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
