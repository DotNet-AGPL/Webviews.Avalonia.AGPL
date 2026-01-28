using System;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Provides a set of properties that are used to manage a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Cookie" />.</summary>
public class CoreWebView2Cookie
{
	internal object _rawNative;

	internal ICoreWebView2Cookie _nativeICoreWebView2CookieValue;

	private static DateTime _unixEpoch = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);

	internal ICoreWebView2Cookie _nativeICoreWebView2Cookie
	{
		get
		{
			if (_nativeICoreWebView2CookieValue == null)
			{
				try
				{
					_nativeICoreWebView2CookieValue = (ICoreWebView2Cookie)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CookieValue;
		}
		set
		{
			_nativeICoreWebView2CookieValue = value;
		}
	}

	/// <summary>
	/// Gets the domain for which the cookie is valid.
	/// </summary><remarks>
	/// The default value is the host that this cookie has been received from. Note that, for instance, <c>.bing.com</c>, <c>bing.com</c>, and <c>www.bing.com</c> are considered different domains.
	/// </remarks>
	public string Domain
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.Domain;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether this cookie is http-only.</summary>
	public bool IsHttpOnly
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.IsHttpOnly != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Cookie.IsHttpOnly = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the security level of this cookie.</summary>
	public bool IsSecure
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.IsSecure != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Cookie.IsSecure = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether this is a session cookie. The default value is <c>false</c>.</summary>
	public bool IsSession
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.IsSession != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Get or sets the cookie name.</summary>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the path for which the cookie is valid.
	/// </summary><remarks>
	/// The default value is "/", which means this cookie will be sent to all pages on the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Domain" />.
	/// </remarks>
	public string Path
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.Path;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines the SameSite status of the cookie which represents the enforcement mode of the cookie.
	/// The default value is <c>CoreWebView2CookieSameSiteKind.Lax</c>.</summary>
	public CoreWebView2CookieSameSiteKind SameSite
	{
		get
		{
			try
			{
				return (CoreWebView2CookieSameSiteKind)_nativeICoreWebView2Cookie.SameSite;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Cookie.SameSite = (COREWEBVIEW2_COOKIE_SAME_SITE_KIND)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the cookie value.</summary>
	public string Value
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Cookie.Value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Cookie.Value = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Cookie members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The expiration date and time for the cookie since the UNIX epoch.
	/// </summary>
	/// <remarks>
	/// Setting the Expires property to <see cref="F:System.DateTime.MinValue" />
	/// makes this a session cookie, which is its default value.
	/// </remarks>
	public DateTime Expires
	{
		get
		{
			return SecondsSinceUnixEpochToDateTime(_nativeICoreWebView2Cookie.Expires);
		}
		set
		{
			if (value.Kind != DateTimeKind.Utc)
			{
				value = value.ToUniversalTime();
			}
			double totalSeconds = (value - _unixEpoch).TotalSeconds;
			_nativeICoreWebView2Cookie.Expires = ((totalSeconds < 0.0) ? Convert.ToDouble(-1.0) : totalSeconds);
		}
	}

	internal CoreWebView2Cookie(object rawCoreWebView2Cookie)
	{
		_rawNative = rawCoreWebView2Cookie;
	}

	/// <summary>
	/// Converts this to a System.Net.Cookie.
	/// </summary>
	/// <returns>
	/// An object whose <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, <see cref="P:System.Net.Cookie.Domain" />, <see cref="P:System.Net.Cookie.HttpOnly" />, <see cref="P:System.Net.Cookie.Secure" />, and <see cref="P:System.Net.Cookie.Expires" />, matches
	/// those <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Name" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Value" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Path" />,
	/// <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Domain" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.IsHttpOnly" />, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.IsSecure" />, and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Cookie.Expires" /> of this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Cookie" /> object.
	/// </returns>
	/// <remarks>
	/// The values of the <see cref="T:System.Net.Cookie" /> properties other than those
	/// specified above remain their default values.
	/// </remarks>
	/// <seealso cref="T:System.Net.Cookie" />
	public Cookie ToSystemNetCookie()
	{
		return new Cookie(Name, Value, Path, Domain)
		{
			Expires = Expires,
			HttpOnly = IsHttpOnly,
			Secure = IsSecure
		};
	}

	private DateTime SecondsSinceUnixEpochToDateTime(double seconds)
	{
		if (seconds < 0.0)
		{
			return DateTime.MinValue;
		}
		if (seconds * 10000000.0 + (double)_unixEpoch.Ticks > (double)DateTime.MaxValue.Ticks)
		{
			return DateTime.MaxValue;
		}
		return _unixEpoch.AddSeconds(seconds);
	}
}
