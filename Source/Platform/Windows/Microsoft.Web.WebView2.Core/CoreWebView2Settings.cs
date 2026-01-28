using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Defines properties that enable, disable, or modify WebView features.
/// </summary><remarks>
/// Changes to <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsGeneralAutofillEnabled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsPasswordAutosaveEnabled" /> will take effect immediately, while other setting changes made after <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event do not apply until the next top-level navigation.
/// </remarks>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2Settings
{
	internal object _rawNative;

	internal ICoreWebView2Settings _nativeICoreWebView2SettingsValue;

	internal ICoreWebView2Settings2 _nativeICoreWebView2Settings2Value;

	internal ICoreWebView2Settings3 _nativeICoreWebView2Settings3Value;

	internal ICoreWebView2Settings4 _nativeICoreWebView2Settings4Value;

	internal ICoreWebView2Settings5 _nativeICoreWebView2Settings5Value;

	internal ICoreWebView2Settings6 _nativeICoreWebView2Settings6Value;

	internal ICoreWebView2Settings7 _nativeICoreWebView2Settings7Value;

	internal ICoreWebView2Settings8 _nativeICoreWebView2Settings8Value;

	internal ICoreWebView2Settings9 _nativeICoreWebView2Settings9Value;

	internal ICoreWebView2Settings _nativeICoreWebView2Settings
	{
		get
		{
			if (_nativeICoreWebView2SettingsValue == null)
			{
				try
				{
					_nativeICoreWebView2SettingsValue = (ICoreWebView2Settings)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2SettingsValue;
		}
		set
		{
			_nativeICoreWebView2SettingsValue = value;
		}
	}

	/// <summary>
	/// Determines whether the default context menus are shown to the user in WebView.
	/// </summary><remarks>
	/// The default value is <c>true</c>.
	/// </remarks>
	public bool AreDefaultContextMenusEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreDefaultContextMenusEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.AreDefaultContextMenusEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether WebView renders the default JavaScript dialog box.
	/// </summary><remarks>
	/// This is used when loading a new HTML document. If set to <c>false</c>, WebView does not render the default JavaScript dialog box (specifically those displayed by the JavaScript alert, confirm, prompt functions and <c>beforeunload</c> event). Instead, WebView raises <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ScriptDialogOpening" /> event that contains all of the information for the dialog and allow the host app to show a custom UI. The default value is <c>true</c>.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ScriptDialogOpening" />
	public bool AreDefaultScriptDialogsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreDefaultScriptDialogsEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.AreDefaultScriptDialogsEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether the user is able to use the context menu or keyboard shortcuts to open the DevTools window.
	/// </summary><remarks>
	/// The default value is <c>true</c>.
	/// </remarks>
	public bool AreDevToolsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreDevToolsEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.AreDevToolsEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether host objects are accessible from the page in WebView.
	/// </summary><remarks>
	/// The default value is <c>true</c>.
	/// </remarks>
	public bool AreHostObjectsAllowed
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreHostObjectsAllowed != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.AreHostObjectsAllowed = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether to disable built in error page for navigation failure and render process failure.
	/// </summary><remarks>
	/// When disabled, blank page is displayed when related error happens. The default value is <c>true</c>.
	/// </remarks>
	public bool IsBuiltInErrorPageEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsBuiltInErrorPageEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.IsBuiltInErrorPageEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether running JavaScript is enabled in all future navigations in the WebView.
	/// </summary><remarks>
	/// This only affects scripts in the document. Scripts injected with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.ExecuteScriptAsync(System.String)" /> runs even if script is disabled. The default value is <c>true</c>.
	/// </remarks>
	public bool IsScriptEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsScriptEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.IsScriptEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether the status bar is displayed.
	/// </summary><remarks>
	/// The status bar is usually displayed in the lower left of the WebView and shows things such as the URI of a link when the user hovers over it and other information. The default value is <c>true</c>. The status bar UI can be altered by web content and should not be considered secure.
	/// </remarks>
	public bool IsStatusBarEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsStatusBarEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.IsStatusBarEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether communication from the host to the top-level HTML document of the WebView is allowed.
	/// </summary><remarks>
	/// This is used when loading a new HTML document. If set to <c>true</c>, communication from the host to the top-level HTML document of the WebView is allowed using <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" />, <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsString(System.String)" />, and message event of <c>window.chrome.webview</c>. Communication from the top-level HTML document of the WebView to the host is allowed using <c>window.chrome.webview.postMessage</c> function and the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" /> event. If set to <c>false</c>, then communication is disallowed. <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsString(System.String)" /> fail and <c>window.chrome.webview.postMessage</c> fails by throwing an instance of an Error object. The default value is <c>true</c>.
	/// </remarks><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" /><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsString(System.String)" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" />
	public bool IsWebMessageEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsWebMessageEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.IsWebMessageEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether the user is able to impact the zoom of the WebView.
	/// </summary><remarks>
	/// When disabled, the user is not able to zoom using Ctrl++, Ctr+-, or Ctrl+mouse wheel, but the zoom is set using <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> property. The default value is <c>true</c>.
	/// </remarks>
	public bool IsZoomControlEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsZoomControlEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings.IsZoomControlEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings2 _nativeICoreWebView2Settings2
	{
		get
		{
			if (_nativeICoreWebView2Settings2Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings2Value = (ICoreWebView2Settings2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings2Value;
		}
		set
		{
			_nativeICoreWebView2Settings2Value = value;
		}
	}

	/// <summary>
	/// Determines WebView2's User Agent.
	/// </summary><remarks>
	/// The default value is the default User Agent of the Edge browser. This property may be overridden if the User-Agent header is set in a request. If the parameter is empty the User Agent will not be updated and the current User Agent will remain. Setting this property may clear User Agent Client Hints headers Sec-CH-UA-* and script values from navigator.userAgentData. Current implementation behavior is subject to change. By default, the User Agent set will also be effective on the Service Worker associated with the WebView. If there are multiple WebViews associated with the same service worker, the last User Agent set will be used. To disable this behavior, disable the feature flag <c>msWebView2SetUserAgentOverrideOnServiceWorker</c>.
	/// </remarks>
	public string UserAgent
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings2.UserAgent;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings2.UserAgent = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings3 _nativeICoreWebView2Settings3
	{
		get
		{
			if (_nativeICoreWebView2Settings3Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings3Value = (ICoreWebView2Settings3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings3Value;
		}
		set
		{
			_nativeICoreWebView2Settings3Value = value;
		}
	}

	/// <summary>
	/// Determines whether browser-specific accelerator keys are enabled.</summary><remarks>
	/// When this setting is set to <c>false</c>, it disables all accelerator keys that access features specific to a web browser, including but not limited to:
	///
	/// <list type="bullet"><item><description>Ctrl+F and F3 for Find on Page</description></item><item><description>Ctrl+P for Print</description></item><item><description>Ctrl+R and F5 for Reload</description></item><item><description>Ctrl+Plus and Ctrl+Minus for zooming</description></item><item><description>Ctrl+Shift-C and F12 for DevTools</description></item><item><description>Special keys for browser functions, such as Back, Forward, and Search</description></item></list>
	///
	/// It does not disable accelerator keys related to movement and text editing, such as:
	///
	/// <list type="bullet"><item><description>Home, End, Page Up, and Page Down</description></item><item><description>Ctrl+X, Ctrl+C, Ctrl+V</description></item><item><description>Ctrl+A for Select All</description></item><item><description>Ctrl+Z for Undo</description></item></list>
	///
	/// Those accelerator keys will always be enabled unless they are handled in the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.AcceleratorKeyPressed" /> event.
	///
	/// This setting has no effect on the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.AcceleratorKeyPressed" /> event. The event will be fired for all accelerator keys, whether they are enabled or not.
	///
	/// The default value of <c>AreBrowserAcceleratorKeysEnabled</c> is true.
	/// </remarks>
	public bool AreBrowserAcceleratorKeysEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings3.AreBrowserAcceleratorKeysEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings3.AreBrowserAcceleratorKeysEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings4 _nativeICoreWebView2Settings4
	{
		get
		{
			if (_nativeICoreWebView2Settings4Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings4Value = (ICoreWebView2Settings4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings4Value;
		}
		set
		{
			_nativeICoreWebView2Settings4Value = value;
		}
	}

	/// <summary>
	/// Determines whether general form information will be saved and autofilled.
	/// </summary><remarks>
	/// General autofill information includes information like names, street and email addresses, phone numbers, and arbitrary input. This excludes password information. When disabled, no suggestions appear, and no new information is saved.
	/// When enabled, information is saved, suggestions appear, and clicking on one will populate the form fields. The default value is <c>true</c>. It will apply immediately after setting.
	/// This property has the same value as <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsGeneralAutofillEnabled" />, and changing one will change the other. And all WebView2s that created with the same <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Profile" /> will share the same value for this property, so for the WebView2s with the same profile, their <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsGeneralAutofillEnabled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsGeneralAutofillEnabled" /> will always have the same value.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.AcceleratorKeyPressed" />
	public bool IsGeneralAutofillEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings4.IsGeneralAutofillEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings4.IsGeneralAutofillEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether password information will be autosaved.
	/// </summary><remarks>
	/// When disabled, no new password data is saved and no Save/Update Password prompts are displayed. However, if there was password data already saved before disabling this setting, then that password information is auto-populated, suggestions are shown and clicking on one will populate the fields.
	/// When enabled, password information is auto-populated, suggestions are shown and clicking on one will populate the fields, new data is saved, and a Save/Update Password prompt is displayed. The default value is <c>false</c>. It will apply immediately after setting.
	/// This property has the same value as <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsPasswordAutosaveEnabled" />, and changing one will change the other. All WebView2s with the same <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Profile" /> will share the same value for this property, so for the WebView2s with the same profile, their <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsPasswordAutosaveEnabled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsPasswordAutosaveEnabled" /> will always have the same value.
	/// </remarks>
	public bool IsPasswordAutosaveEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings4.IsPasswordAutosaveEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings4.IsPasswordAutosaveEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings5 _nativeICoreWebView2Settings5
	{
		get
		{
			if (_nativeICoreWebView2Settings5Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings5Value = (ICoreWebView2Settings5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings5Value;
		}
		set
		{
			_nativeICoreWebView2Settings5Value = value;
		}
	}

	/// <summary>
	/// Determines the ability of the end users to use pinching motions on touch input enabled devices to scale the web content in the WebView2.
	/// </summary><remarks>
	/// When disabled, the end users cannot use pinching motions on touch input enabled devices to scale the web content in the WebView2. The default value is <c>true</c>.
	/// Pinch-zoom, referred to as "Page Scale" zoom, is performed as a post-rendering step, it changes the page scale factor property and scales the surface the web page is rendered onto when user performs a pinch zooming action. It does not change the layout but rather changes the viewport and clips the web content, the content outside of the viewport isn't visible onscreen and users can't reach this content using mouse. This API only affects the Page Scale zoom and has no effect on the existing browser zoom properties (<see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsZoomControlEnabled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" />) or other end user mechanisms for zooming.
	/// </remarks>
	public bool IsPinchZoomEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings5.IsPinchZoomEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings5.IsPinchZoomEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings6 _nativeICoreWebView2Settings6
	{
		get
		{
			if (_nativeICoreWebView2Settings6Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings6Value = (ICoreWebView2Settings6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings6Value;
		}
		set
		{
			_nativeICoreWebView2Settings6Value = value;
		}
	}

	/// <summary>
	/// Determines whether the end user to use swiping gesture on touch input enabled devices to navigate in WebView2.
	/// </summary><remarks>
	/// Swiping gesture navigation on touch screen includes:
	///
	/// <list type="bullet"><item><description>
	/// Swipe left/right (swipe horizontally) to navigate to previous/next page in navigation history.
	/// </description></item><item><description>
	/// Pull to refresh (swipe vertically) the current page. (This feature is currently disabled by default in the browser, to enable in WebView2, set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.AdditionalBrowserArguments" /> property with <c>--pull-to-refresh</c> switch).
	/// </description></item></list>
	/// It defaults to <c>true</c>. When set to <c>false</c>, the end user cannot swipe to navigate or pull to refresh. This API only affects the overscrolling navigation functionality and has no effect on the scrolling interaction used to explore the web content shown in WebView2.
	/// </remarks><example>
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="ToggleSwipeNavigationEnabled":::
	/// </example>
	public bool IsSwipeNavigationEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings6.IsSwipeNavigationEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings6.IsSwipeNavigationEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings7 _nativeICoreWebView2Settings7
	{
		get
		{
			if (_nativeICoreWebView2Settings7Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings7Value = (ICoreWebView2Settings7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings7Value;
		}
		set
		{
			_nativeICoreWebView2Settings7Value = value;
		}
	}

	/// <summary>
	/// Used to customize the PDF toolbar items.
	/// </summary><remarks>
	/// By default, it is <c>CoreWebView2PdfToolbarItems.None</c> and so it displays all of the items.
	/// Changes to this property apply to all CoreWebView2s in the same environment and using the same profile.
	/// Changes to this setting apply only after the next navigation.
	/// </remarks>
	public CoreWebView2PdfToolbarItems HiddenPdfToolbarItems
	{
		get
		{
			try
			{
				return (CoreWebView2PdfToolbarItems)_nativeICoreWebView2Settings7.HiddenPdfToolbarItems;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings7.HiddenPdfToolbarItems = (COREWEBVIEW2_PDF_TOOLBAR_ITEMS)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings8 _nativeICoreWebView2Settings8
	{
		get
		{
			if (_nativeICoreWebView2Settings8Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings8Value = (ICoreWebView2Settings8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings8Value;
		}
		set
		{
			_nativeICoreWebView2Settings8Value = value;
		}
	}

	/// <summary>
	/// Determines whether SmartScreen is enabled when visiting web pages
	/// </summary><remarks>
	/// The default value is <c>true</c>.
	/// IsReputationCheckingRequired is used to control whether SmartScreen is enabled or not.
	/// SmartScreen is enabled or disabled for all CoreWebView2s using the same user data folder.
	/// If CoreWebView2Setting.IsReputationCheckingRequired is <c>true</c> for any CoreWebView2 using the same user data folder, then SmartScreen is enabled. If CoreWebView2Setting.IsReputationCheckingRequired is <c>false</c> for all CoreWebView2 using the same user data folder, then SmartScreen is disabled.
	/// When it is changed, the change will be applied to all WebViews using the same user data folder on the next navigation or download.
	/// If the newly created CoreWebview2 does not set SmartScreen to <c>false</c>, when navigating(Such as Navigate(), LoadDataUrl(), ExecuteScript(), etc.), the default value will be applied to all CoreWebview2 using the same user data folder.
	/// SmartScreen of WebView2 apps can be controlled by Windows system setting "SmartScreen for Microsoft Edge", specially, for WebView2 in Windows Store apps, SmartScreen is controlled by another Windows system setting "SmartScreen for Microsoft Store apps". When the Windows setting is enabled, the SmartScreen operates under the control of the `IsReputationCheckingRequired`. When the Windows setting is disabled, the SmartScreen will be disabled regardless of the `IsReputationCheckingRequired` value set in WebView2 apps. In other words, under this circumstance the value of `IsReputationCheckingRequired` will be saved but overridden by system setting. Upon re-enabling the Windows setting, the CoreWebview2 will reference the `IsReputationCheckingRequired` to determine the SmartScreen status.
	/// </remarks>
	public bool IsReputationCheckingRequired
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings8.IsReputationCheckingRequired != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings8.IsReputationCheckingRequired = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Settings9 _nativeICoreWebView2Settings9
	{
		get
		{
			if (_nativeICoreWebView2Settings9Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings9Value = (ICoreWebView2Settings9)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings9Value;
		}
		set
		{
			_nativeICoreWebView2Settings9Value = value;
		}
	}

	/// <summary>
	/// The `IsNonClientRegionSupportEnabled` property enables web pages to use the
	/// `app-region` CSS style. Disabling/Enabling the `IsNonClientRegionSupportEnabled`
	/// takes effect after the next navigation. Defaults to `false`.
	///
	/// When this property is `TRUE`, then all the non-client region features
	/// will be enabled:
	/// Draggable Regions will be enabled, they are regions on a webpage that
	/// are marked with the CSS attribute `app-region: drag/no-drag`. When set to
	/// `drag`, these regions will be treated like the window's title bar, supporting
	/// dragging of the entire WebView and its host app window; the system menu shows
	/// upon right click, and a double click will trigger maximizing/restoration of the
	/// window size.
	///
	/// When set to `false`, all non-client region support will be disabled.
	/// The `app-region` CSS style will be ignored on web pages.</summary>
	public bool IsNonClientRegionSupportEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings9.IsNonClientRegionSupportEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Settings9.IsNonClientRegionSupportEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Settings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Settings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2Settings(object rawCoreWebView2Settings)
	{
		_rawNative = rawCoreWebView2Settings;
	}
}
