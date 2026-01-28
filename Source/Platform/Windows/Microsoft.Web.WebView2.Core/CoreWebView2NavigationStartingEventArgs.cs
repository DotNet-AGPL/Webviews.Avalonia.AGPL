using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event.</summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2NavigationStartingEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgsValue;

	internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2Value;

	internal ICoreWebView2NavigationStartingEventArgs3 _nativeICoreWebView2NavigationStartingEventArgs3Value;

	internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgs
	{
		get
		{
			if (_nativeICoreWebView2NavigationStartingEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2NavigationStartingEventArgsValue = (ICoreWebView2NavigationStartingEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationStartingEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2NavigationStartingEventArgsValue = value;
		}
	}

	/// <summary>
	/// Determines whether to cancel the navigation.
	/// </summary><remarks>
	/// If set to <c>true</c>, the navigation is no longer present and the content of the current page is intact. For performance reasons, <c>GET</c> HTTP requests may happen, while the host is responding. You may set cookies and use part of a request for the navigation. Navigations to about schemes are cancellable, unless `msWebView2CancellableAboutNavigations` feature flag is disabled. Cancellation of frame navigation to `srcdoc` is not supported and will be ignored.
	/// </remarks>
	public bool Cancel
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.Cancel != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2NavigationStartingEventArgs.Cancel = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> when the navigation is redirected.</summary>
	public bool IsRedirected
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.IsRedirected != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> when the new window request was initiated through a user gesture.
	/// </summary><remarks>
	/// Examples of user initiated requests are:
	/// <list type="bullet"><item><description>Selecting an anchor tag with target</description></item><item><description>Programmatic window open from a script that directly run as a result of user interaction such as via onclick handlers.</description></item></list>
	/// Non-user initiated requests are programmatic window opens from a script that are not directly triggered by user interaction, such as those that run while loading a new page or via timers.
	/// The Microsoft Edge popup blocker is disabled for WebView so the app is able to use this flag to block non-user initiated popups.
	/// </remarks>
	public bool IsUserInitiated
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.IsUserInitiated != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the ID of the navigation.</summary>
	public ulong NavigationId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.NavigationId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the HTTP request headers for the navigation.
	/// </summary><remarks>
	/// Note, you are not able to modify the HTTP request headers in a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" />
	public CoreWebView2HttpRequestHeaders RequestHeaders
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders == null) ? null : new CoreWebView2HttpRequestHeaders(_nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the uri of the requested navigation.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2NavigationStartingEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2NavigationStartingEventArgs2Value = (ICoreWebView2NavigationStartingEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationStartingEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2NavigationStartingEventArgs2Value = value;
		}
	}

	/// <summary>Additional allowed frame ancestors set by the host app.
	/// </summary><remarks>
	/// The app may set this property to allow a frame to be embedded by additional ancestors besides what is allowed by http header [X-Frame-Options](https://developer.mozilla.org/docs/Web/HTTP/Headers/X-Frame-Options) and [Content-Security-Policy frame-ancestors directive](https://developer.mozilla.org/docs/Web/HTTP/Headers/Content-Security-Policy/frame-ancestors).
	/// If set, a frame ancestor is allowed if it is allowed by the additional allowed frame ancestors or original http header from the site.
	/// Whether an ancestor is allowed by the additional allowed frame ancestors is done the same way as if the site provided it as the source list of the Content-Security-Policy frame-ancestors directive.
	/// For example, if <c>https://example.com</c> and <c>https://www.example.com</c> are the origins of the top page and intermediate iframes that embed a nested site-embedding iframe, and you fully trust those origins, you should set this property to <c>https://example.com https://www.example.com</c>.
	///
	/// This property gives the app the ability to use iframe to embed sites that otherwise could not be embedded in an iframe in trusted app pages.
	/// This could potentially subject the embedded sites to [Clickjacking](https://wikipedia.org/wiki/Clickjacking) attack from the code running in the embedding web page. Therefore, you should only set this property with origins of fully trusted embedding page and any intermediate iframes.
	/// Whenever possible, you should use the list of specific origins of the top and intermediate frames instead of wildcard characters for this property.
	/// This API is to provide limited support for app scenarios that used to be supported by <c>&lt;webview&gt;</c> element in other solutions like JavaScript UWP apps and Electron.
	/// You should limit the usage of this property to trusted pages, and specific navigation target url, by checking the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.Source" />, and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Uri" />.
	///
	/// This property is ignored for top level document navigation.
	/// </remarks>
	public string AdditionalAllowedFrameAncestors
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2NavigationStartingEventArgs3 _nativeICoreWebView2NavigationStartingEventArgs3
	{
		get
		{
			if (_nativeICoreWebView2NavigationStartingEventArgs3Value == null)
			{
				try
				{
					_nativeICoreWebView2NavigationStartingEventArgs3Value = (ICoreWebView2NavigationStartingEventArgs3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationStartingEventArgs3Value;
		}
		set
		{
			_nativeICoreWebView2NavigationStartingEventArgs3Value = value;
		}
	}

	/// <summary>
	/// Gets the navigation kind of the navigation.</summary>
	public CoreWebView2NavigationKind NavigationKind
	{
		get
		{
			try
			{
				return (CoreWebView2NavigationKind)_nativeICoreWebView2NavigationStartingEventArgs3.NavigationKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2NavigationStartingEventArgs(object rawCoreWebView2NavigationStartingEventArgs)
	{
		_rawNative = rawCoreWebView2NavigationStartingEventArgs;
	}
}
