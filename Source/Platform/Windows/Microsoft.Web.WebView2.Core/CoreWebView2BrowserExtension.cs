using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Browser extension installed on current profile.</summary>
public class CoreWebView2BrowserExtension
{
	internal object _rawNative;

	internal ICoreWebView2BrowserExtension _nativeICoreWebView2BrowserExtensionValue;

	internal ICoreWebView2BrowserExtension _nativeICoreWebView2BrowserExtension
	{
		get
		{
			if (_nativeICoreWebView2BrowserExtensionValue == null)
			{
				try
				{
					_nativeICoreWebView2BrowserExtensionValue = (ICoreWebView2BrowserExtension)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BrowserExtension.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2BrowserExtensionValue;
		}
		set
		{
			_nativeICoreWebView2BrowserExtensionValue = value;
		}
	}

	/// <summary>
	/// This is the browser extension's ID. This is the same browser extension ID returned by the browser extension API [chrome.runtime.id](https://developer.mozilla.org/docs/Mozilla/Add-ons/WebExtensions/API/runtime/id). Please see that documentation for more details on how the ID is generated. After an extension is removed, calling <c>Id</c> will return the id of the extension that is removed.</summary>
	public string Id
	{
		get
		{
			try
			{
				return _nativeICoreWebView2BrowserExtension.Id;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2BrowserExtension members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2BrowserExtension members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// If <c>IsEnabled</c> is true then the Extension is enabled and running in WebView instances. If it is false then the Extension is disabled and not running in WebView instances. When a Extension is first installed, <c>IsEnable</c> are default to be <c>true</c>. <c>IsEnabled</c> is persisted per profile. After an extension is removed, calling <c>IsEnabled</c> will return the value at the time it was removed.</summary>
	public bool IsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2BrowserExtension.IsEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2BrowserExtension members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2BrowserExtension members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// This is the browser extension's name. This value is defined in this browser extension's manifest.json file. If manifest.json define extension's localized name, this value will be the localized version of the name. Please see [Manifest.json name](https://developer.mozilla.org/docs/Mozilla/Add-ons/WebExtensions/manifest.json/name) for more details.</summary>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2BrowserExtension.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2BrowserExtension members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2BrowserExtension members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2BrowserExtension(object rawCoreWebView2BrowserExtension)
	{
		_rawNative = rawCoreWebView2BrowserExtension;
	}

	/// <summary>
	/// Removes this browser extension from its WebView2 Profile. The browser extension is removed immediately including from all currently running HTML documents associated with this WebView2 Profile. The removal is persisted and future uses of this profile will not have this extension installed. After an extension is removed, calling <c>Remove</c> again will cause an exception.</summary>
	public async Task RemoveAsync()
	{
		CoreWebView2BrowserExtensionRemoveCompletedHandler handler;
		try
		{
			handler = new CoreWebView2BrowserExtensionRemoveCompletedHandler();
			_nativeICoreWebView2BrowserExtension.Remove(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2BrowserExtension members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2BrowserExtension members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	/// <summary>
	/// Sets whether this browser extension is enabled or disabled. This change applies immediately to the extension in all HTML documents in all WebView2s associated with this profile. After an extension is removed, calling <c>Enable</c> will not change the value of <c>IsEnabled</c>.</summary>
	public async Task EnableAsync(bool IsEnabled)
	{
		CoreWebView2BrowserExtensionEnableCompletedHandler handler;
		try
		{
			handler = new CoreWebView2BrowserExtensionEnableCompletedHandler();
			_nativeICoreWebView2BrowserExtension.Enable(IsEnabled ? 1 : 0, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2BrowserExtension members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2BrowserExtension members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}
}
