using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Creates, adds or updates, gets, or or view the cookies.
/// </summary><remarks>
/// The changes would apply to the context of the user profile. That is, other WebViews under the same user profile could be affected.
/// </remarks>
public class CoreWebView2CookieManager
{
	internal object _rawNative;

	internal ICoreWebView2CookieManager _nativeICoreWebView2CookieManagerValue;

	internal ICoreWebView2CookieManager _nativeICoreWebView2CookieManager
	{
		get
		{
			if (_nativeICoreWebView2CookieManagerValue == null)
			{
				try
				{
					_nativeICoreWebView2CookieManagerValue = (ICoreWebView2CookieManager)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CookieManagerValue;
		}
		set
		{
			_nativeICoreWebView2CookieManagerValue = value;
		}
	}

	internal CoreWebView2CookieManager(object rawCoreWebView2CookieManager)
	{
		_rawNative = rawCoreWebView2CookieManager;
	}

	/// <summary>
	/// Creates a cookie object with a specified name, value, domain, and path.
	/// </summary><remarks>
	/// One can set other optional properties after cookie creation. This only creates a cookie object and it is not added to the cookie manager until you call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2CookieManager.AddOrUpdateCookie(Microsoft.Web.WebView2.Core.CoreWebView2Cookie)" />. name that starts with whitespace(s) is not allowed.
	/// </remarks><param name="name">The name for the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Cookie" /> to be created. It cannot start with whitespace(s).</param><param name="cookieValue"></param><param name="Domain"></param><param name="Path"></param>
	public CoreWebView2Cookie CreateCookie(string name, string cookieValue, string Domain, string Path)
	{
		try
		{
			return new CoreWebView2Cookie(_nativeICoreWebView2CookieManager.CreateCookie(name, cookieValue, Domain, Path));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Creates a cookie whose params matches those of the specified cookie.</summary>
	public CoreWebView2Cookie CopyCookie(CoreWebView2Cookie cookieParam)
	{
		try
		{
			return new CoreWebView2Cookie(_nativeICoreWebView2CookieManager.CopyCookie(cookieParam._nativeICoreWebView2Cookie));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Gets a list of cookies matching the specific URI.
	/// </summary><remarks>
	/// You can modify the cookie objects by calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2CookieManager.AddOrUpdateCookie(Microsoft.Web.WebView2.Core.CoreWebView2Cookie)" />, and the changes will be applied to the webview.
	/// </remarks><param name="uri">If uri is empty string or null, all cookies under the same profile are returned.</param>
	public async Task<List<CoreWebView2Cookie>> GetCookiesAsync(string uri)
	{
		CoreWebView2GetCookiesCompletedHandler handler;
		try
		{
			handler = new CoreWebView2GetCookiesCompletedHandler();
			_nativeICoreWebView2CookieManager.GetCookies(uri, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Adds or updates a cookie with the given cookie data; may overwrite cookies with matching name, domain, and path if they exist.
	/// </summary><param name="cookie">The <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Cookie" /> to be added or updated.</param><remarks>
	/// This method will fail if the domain of the given cookie is not specified.
	/// </remarks>
	public void AddOrUpdateCookie(CoreWebView2Cookie cookie)
	{
		try
		{
			_nativeICoreWebView2CookieManager.AddOrUpdateCookie(cookie._nativeICoreWebView2Cookie);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Deletes a cookie whose name and domain/path pair match those of the specified cookie.</summary>
	public void DeleteCookie(CoreWebView2Cookie cookie)
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteCookie(cookie._nativeICoreWebView2Cookie);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Deletes cookies with matching name and uri.
	/// </summary><param name="name">The name for the cookies to be deleted is required.</param><param name="uri">If uri is specified, deletes all cookies with the given name where domain and path match provided URI.</param>
	public void DeleteCookies(string name, string uri)
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteCookies(name, uri);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Deletes cookies with matching name and domain/path pair.
	/// </summary><param name="name">The name for the cookies to be deleted is required.</param><param name="Domain">If domain is specified, deletes only cookies with the exact domain.</param><param name="Path">If path is specified, deletes only cookies with the exact path.</param>
	public void DeleteCookiesWithDomainAndPath(string name, string Domain, string Path)
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteCookiesWithDomainAndPath(name, Domain, Path);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Deletes all cookies under the same profile.
	/// </summary><remarks>
	/// This could affect other WebViews under the same user profile.
	/// </remarks>
	public void DeleteAllCookies()
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteAllCookies();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CookieManager members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Creates a CoreWebView2Cookie object whose params matches those of the given System.Net.Cookie.
	/// </summary>
	/// <param name="systemNetCookie">
	/// A System.Net.Cookie whose params to be used to create a CoreWebView2Cookie.
	/// </param>
	/// <returns>
	/// An object whose <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Name" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Value" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Path" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Domain" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.IsHttpOnly" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.IsSecure" />, and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Expires" />, matches those <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, <see cref="P:System.Net.Cookie.Domain" />, <see cref="P:System.Net.Cookie.HttpOnly" />, <see cref="P:System.Net.Cookie.Secure" />, and <see cref="P:System.Net.Cookie.Expires" /> of the given <see cref="T:System.Net.Cookie" /> object.
	/// </returns>
	/// <remarks>
	/// The default value for the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.SameSite" />
	/// property of the returned <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Cookie" /> object is
	/// <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2CookieSameSiteKind.Lax" />.
	/// </remarks>
	/// <seealso cref="T:System.Net.Cookie" />
	public CoreWebView2Cookie CreateCookieWithSystemNetCookie(Cookie systemNetCookie)
	{
		return new CoreWebView2Cookie(_nativeICoreWebView2CookieManager.CreateCookie(systemNetCookie.Name, systemNetCookie.Value, systemNetCookie.Domain, systemNetCookie.Path))
		{
			IsHttpOnly = systemNetCookie.HttpOnly,
			IsSecure = systemNetCookie.Secure,
			Expires = systemNetCookie.Expires.ToUniversalTime()
		};
	}
}
