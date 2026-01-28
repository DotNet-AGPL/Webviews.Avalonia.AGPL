using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> event.</summary>
/// <summary></summary>
public class CoreWebView2NavigationCompletedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgsValue;

	internal ICoreWebView2NavigationCompletedEventArgs2 _nativeICoreWebView2NavigationCompletedEventArgs2Value;

	internal ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2NavigationCompletedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2NavigationCompletedEventArgsValue = (ICoreWebView2NavigationCompletedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationCompletedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2NavigationCompletedEventArgsValue = value;
		}
	}

	/// <summary><c>true</c> when the navigation is successful; <c>false</c> for a navigation that ended up in an error page (failures due to no network, DNS lookup failure, HTTP server responds with 4xx). Note that WebView2 will report the navigation as 'unsuccessful' if the load for the navigation did not reach the expected completion for any reason. Such reasons include potentially catastrophic issues such network and certificate issues, but can also be the result of intended actions such as the app canceling a navigation or navigating away before the original navigation completed. Applications should not just rely on this flag, but also consider the reported WebErrorStatus to determine whether the failure is indeed catastrophic in their context.</summary><remarks>
	/// WebErrorStatuses that may indicate a non-catastrophic failure include:
	///
	/// <list type="bullet"><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.OperationCanceled" /></description></item><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.ValidAuthenticationCredentialsRequired" /></description></item><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.ValidProxyAuthenticationRequired" /></description></item></list>
	///
	/// This may also be <c>false</c> for additional scenarios such as <c>window.stop()</c> run on navigated page.
	/// </remarks>
	public bool IsSuccess
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationCompletedEventArgs.IsSuccess != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				return _nativeICoreWebView2NavigationCompletedEventArgs.NavigationId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the error code if the navigation failed.</summary>
	public CoreWebView2WebErrorStatus WebErrorStatus
	{
		get
		{
			try
			{
				return (CoreWebView2WebErrorStatus)_nativeICoreWebView2NavigationCompletedEventArgs.WebErrorStatus;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2NavigationCompletedEventArgs2 _nativeICoreWebView2NavigationCompletedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2NavigationCompletedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2NavigationCompletedEventArgs2Value = (ICoreWebView2NavigationCompletedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationCompletedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2NavigationCompletedEventArgs2Value = value;
		}
	}

	/// <summary>
	/// The HTTP status code of the navigation if it involved an HTTP request. For instance, this will usually be 200 if the request was successful, 404 if a page was not found, etc. See https://developer.mozilla.org/docs/Web/HTTP/Status for a list of common status codes.
	/// </summary><remarks>
	/// The <c>HttpStatusCode</c> property will be 0 in the following cases:
	/// <list type="bullet"><item><description>
	/// The navigation did not involve an HTTP request. For instance, if it was a navigation to a <c>file://</c> URL, or if it was a same-document navigation.
	/// </description></item><item><description>
	/// The navigation failed before a response was received. For instance, if the hostname was not found, or if there was a network error.
	/// </description></item></list>
	/// In those cases, you can get more information from the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.WebErrorStatus" /> properties.
	///
	/// If the navigation receives a successful HTTP response, but the navigated page calls <c>window.stop()</c> before it finishes loading, then HttpStatusCode may contain a success code like 200, but <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess" /> will be <c>false</c> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.WebErrorStatus" /> will be <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.ConnectionAborted" />.
	///
	/// Since WebView2 handles HTTP continuations and redirects automatically, it is unlikely for HttpStatusCode to ever be in the 1xx or 3xx ranges.
	/// </remarks>
	public int HttpStatusCode
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationCompletedEventArgs2.HttpStatusCode;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NavigationCompletedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2NavigationCompletedEventArgs(object rawCoreWebView2NavigationCompletedEventArgs)
	{
		_rawNative = rawCoreWebView2NavigationCompletedEventArgs;
	}
}
