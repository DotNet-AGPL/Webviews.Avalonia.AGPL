using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// WebView2 enables you to host web content using the latest Microsoft Edge browser and web technology.</summary>
///
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2
{
	internal object _rawNative;

	internal ICoreWebView2 _nativeICoreWebView2Value;

	private EventRegistrationToken _ContainsFullScreenElementChangedToken;

	private EventHandler<object> privateContainsFullScreenElementChanged;

	private EventRegistrationToken _ContentLoadingToken;

	private EventHandler<CoreWebView2ContentLoadingEventArgs> privateContentLoading;

	private EventRegistrationToken _DocumentTitleChangedToken;

	private EventHandler<object> privateDocumentTitleChanged;

	private EventRegistrationToken _FrameNavigationCompletedToken;

	private EventHandler<CoreWebView2NavigationCompletedEventArgs> privateFrameNavigationCompleted;

	private EventRegistrationToken _FrameNavigationStartingToken;

	private EventHandler<CoreWebView2NavigationStartingEventArgs> privateFrameNavigationStarting;

	private EventRegistrationToken _HistoryChangedToken;

	private EventHandler<object> privateHistoryChanged;

	private EventRegistrationToken _NavigationCompletedToken;

	private EventHandler<CoreWebView2NavigationCompletedEventArgs> privateNavigationCompleted;

	private EventRegistrationToken _NavigationStartingToken;

	private EventHandler<CoreWebView2NavigationStartingEventArgs> privateNavigationStarting;

	private EventRegistrationToken _NewWindowRequestedToken;

	private EventHandler<CoreWebView2NewWindowRequestedEventArgs> privateNewWindowRequested;

	private EventRegistrationToken _PermissionRequestedToken;

	private EventHandler<CoreWebView2PermissionRequestedEventArgs> privatePermissionRequested;

	private EventRegistrationToken _ProcessFailedToken;

	private EventHandler<CoreWebView2ProcessFailedEventArgs> privateProcessFailed;

	private EventRegistrationToken _ScriptDialogOpeningToken;

	private EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> privateScriptDialogOpening;

	private EventRegistrationToken _SourceChangedToken;

	private EventHandler<CoreWebView2SourceChangedEventArgs> privateSourceChanged;

	private EventRegistrationToken _WebMessageReceivedToken;

	private EventHandler<CoreWebView2WebMessageReceivedEventArgs> privateWebMessageReceived;

	private EventRegistrationToken _WebResourceRequestedToken;

	private EventHandler<CoreWebView2WebResourceRequestedEventArgs> privateWebResourceRequested;

	private EventRegistrationToken _WindowCloseRequestedToken;

	private EventHandler<object> privateWindowCloseRequested;

	internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartialValue;

	internal ICoreWebView2_10 _nativeICoreWebView2_10Value;

	private EventRegistrationToken _BasicAuthenticationRequestedToken;

	private EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> privateBasicAuthenticationRequested;

	internal ICoreWebView2_11 _nativeICoreWebView2_11Value;

	private EventRegistrationToken _ContextMenuRequestedToken;

	private EventHandler<CoreWebView2ContextMenuRequestedEventArgs> privateContextMenuRequested;

	internal ICoreWebView2_12 _nativeICoreWebView2_12Value;

	private EventRegistrationToken _StatusBarTextChangedToken;

	private EventHandler<object> privateStatusBarTextChanged;

	internal ICoreWebView2_13 _nativeICoreWebView2_13Value;

	internal ICoreWebView2_14 _nativeICoreWebView2_14Value;

	private EventRegistrationToken _ServerCertificateErrorDetectedToken;

	private EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> privateServerCertificateErrorDetected;

	internal ICoreWebView2_15 _nativeICoreWebView2_15Value;

	private EventRegistrationToken _FaviconChangedToken;

	private EventHandler<object> privateFaviconChanged;

	internal ICoreWebView2_16 _nativeICoreWebView2_16Value;

	internal ICoreWebView2_17 _nativeICoreWebView2_17Value;

	internal ICoreWebView2_18 _nativeICoreWebView2_18Value;

	private EventRegistrationToken _LaunchingExternalUriSchemeToken;

	private EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> privateLaunchingExternalUriScheme;

	internal ICoreWebView2_19 _nativeICoreWebView2_19Value;

	internal ICoreWebView2_2 _nativeICoreWebView2_2Value;

	private EventRegistrationToken _DOMContentLoadedToken;

	private EventHandler<CoreWebView2DOMContentLoadedEventArgs> privateDOMContentLoaded;

	private EventRegistrationToken _WebResourceResponseReceivedToken;

	private EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> privateWebResourceResponseReceived;

	internal ICoreWebView2_20 _nativeICoreWebView2_20Value;

	internal ICoreWebView2_21 _nativeICoreWebView2_21Value;

	internal ICoreWebView2_22 _nativeICoreWebView2_22Value;

	internal ICoreWebView2_25 _nativeICoreWebView2_25Value;

	private EventRegistrationToken _SaveAsUIShowingToken;

	private EventHandler<CoreWebView2SaveAsUIShowingEventArgs> privateSaveAsUIShowing;

	internal ICoreWebView2_23 _nativeICoreWebView2_23Value;

	internal ICoreWebView2_27 _nativeICoreWebView2_27Value;

	private EventRegistrationToken _ScreenCaptureStartingToken;

	private EventHandler<CoreWebView2ScreenCaptureStartingEventArgs> privateScreenCaptureStarting;

	internal ICoreWebView2_28 _nativeICoreWebView2_28Value;

	internal ICoreWebView2_26 _nativeICoreWebView2_26Value;

	private EventRegistrationToken _SaveFileSecurityCheckStartingToken;

	private EventHandler<CoreWebView2SaveFileSecurityCheckStartingEventArgs> privateSaveFileSecurityCheckStarting;

	internal ICoreWebView2_24 _nativeICoreWebView2_24Value;

	private EventRegistrationToken _NotificationReceivedToken;

	private EventHandler<CoreWebView2NotificationReceivedEventArgs> privateNotificationReceived;

	internal ICoreWebView2_3 _nativeICoreWebView2_3Value;

	internal ICoreWebView2_4 _nativeICoreWebView2_4Value;

	private EventRegistrationToken _DownloadStartingToken;

	private EventHandler<CoreWebView2DownloadStartingEventArgs> privateDownloadStarting;

	private EventRegistrationToken _FrameCreatedToken;

	private EventHandler<CoreWebView2FrameCreatedEventArgs> privateFrameCreated;

	internal ICoreWebView2_5 _nativeICoreWebView2_5Value;

	private EventRegistrationToken _ClientCertificateRequestedToken;

	private EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> privateClientCertificateRequested;

	internal ICoreWebView2_6 _nativeICoreWebView2_6Value;

	internal ICoreWebView2_7 _nativeICoreWebView2_7Value;

	internal ICoreWebView2_8 _nativeICoreWebView2_8Value;

	private EventRegistrationToken _IsDocumentPlayingAudioChangedToken;

	private EventHandler<object> privateIsDocumentPlayingAudioChanged;

	private EventRegistrationToken _IsMutedChangedToken;

	private EventHandler<object> privateIsMutedChanged;

	internal ICoreWebView2_9 _nativeICoreWebView2_9Value;

	private EventRegistrationToken _IsDefaultDownloadDialogOpenChangedToken;

	private EventHandler<object> privateIsDefaultDownloadDialogOpenChanged;

	internal ICoreWebView2 _nativeICoreWebView2
	{
		get
		{
			if (_nativeICoreWebView2Value == null)
			{
				try
				{
					_nativeICoreWebView2Value = (ICoreWebView2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Value;
		}
		set
		{
			_nativeICoreWebView2Value = value;
		}
	}

	/// <summary>
	/// Gets the process ID of the browser process that hosts the WebView.</summary>
	public uint BrowserProcessId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.BrowserProcessId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> if the WebView is able to navigate to a previous page in the navigation history.
	/// </summary><remarks>
	/// If CanGoBack changes value, the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" /> event is raised.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" />
	public bool CanGoBack
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.CanGoBack != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> if the WebView is able to navigate to a next page in the navigation history.
	/// </summary><remarks>
	/// If CanGoForward changes value, the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" /> event is raised.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" />
	public bool CanGoForward
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.CanGoForward != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Indicates if the WebView contains a fullscreen HTML element.</summary>
	public bool ContainsFullScreenElement
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.ContainsFullScreenElement != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the title for the current top-level document.
	/// </summary><remarks>
	/// If the document has no explicit title or is otherwise empty, a default that may or may not match the URI of the document is used.
	/// </remarks>
	public string DocumentTitle
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.DocumentTitle;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Settings" /> object contains various modifiable settings for the running WebView.</summary>
	public CoreWebView2Settings Settings
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2.Settings == null) ? null : new CoreWebView2Settings(_nativeICoreWebView2.Settings);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the URI of the current top level document.
	/// </summary><remarks>
	/// This value potentially changes as a part of the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" /> event raised for some cases such as navigating to a different site or fragment navigations. It remains the same for other types of navigations such as page refreshes or <c>history.pushState</c> with the same URL as the current page.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" />
	public string Source
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.Source;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartial
	{
		get
		{
			if (_nativeICoreWebView2PrivatePartialValue == null)
			{
				try
				{
					_nativeICoreWebView2PrivatePartialValue = (ICoreWebView2PrivatePartial)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartial.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrivatePartialValue;
		}
		set
		{
			_nativeICoreWebView2PrivatePartialValue = value;
		}
	}

	internal ICoreWebView2_10 _nativeICoreWebView2_10
	{
		get
		{
			if (_nativeICoreWebView2_10Value == null)
			{
				try
				{
					_nativeICoreWebView2_10Value = (ICoreWebView2_10)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_10Value;
		}
		set
		{
			_nativeICoreWebView2_10Value = value;
		}
	}

	internal ICoreWebView2_11 _nativeICoreWebView2_11
	{
		get
		{
			if (_nativeICoreWebView2_11Value == null)
			{
				try
				{
					_nativeICoreWebView2_11Value = (ICoreWebView2_11)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_11Value;
		}
		set
		{
			_nativeICoreWebView2_11Value = value;
		}
	}

	internal ICoreWebView2_12 _nativeICoreWebView2_12
	{
		get
		{
			if (_nativeICoreWebView2_12Value == null)
			{
				try
				{
					_nativeICoreWebView2_12Value = (ICoreWebView2_12)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_12Value;
		}
		set
		{
			_nativeICoreWebView2_12Value = value;
		}
	}

	/// <summary>
	/// The current text of the statusbar as defined by [Window.statusbar](https://developer.mozilla.org/docs/Web/API/Window/statusbar).</summary>
	public string StatusBarText
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_12.StatusBarText;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_13 _nativeICoreWebView2_13
	{
		get
		{
			if (_nativeICoreWebView2_13Value == null)
			{
				try
				{
					_nativeICoreWebView2_13Value = (ICoreWebView2_13)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_13Value;
		}
		set
		{
			_nativeICoreWebView2_13Value = value;
		}
	}

	/// <summary>
	/// The associated <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Profile" /> object of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" />.</summary>
	public CoreWebView2Profile Profile
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2_13.Profile == null) ? null : new CoreWebView2Profile(_nativeICoreWebView2_13.Profile);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_14 _nativeICoreWebView2_14
	{
		get
		{
			if (_nativeICoreWebView2_14Value == null)
			{
				try
				{
					_nativeICoreWebView2_14Value = (ICoreWebView2_14)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_14.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_14Value;
		}
		set
		{
			_nativeICoreWebView2_14Value = value;
		}
	}

	internal ICoreWebView2_15 _nativeICoreWebView2_15
	{
		get
		{
			if (_nativeICoreWebView2_15Value == null)
			{
				try
				{
					_nativeICoreWebView2_15Value = (ICoreWebView2_15)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_15.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_15Value;
		}
		set
		{
			_nativeICoreWebView2_15Value = value;
		}
	}

	/// <summary>
	/// Get the Uri as a string of the current Favicon. This will be an empty string if the page does not have a Favicon.</summary>
	public string FaviconUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_15.FaviconUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_16 _nativeICoreWebView2_16
	{
		get
		{
			if (_nativeICoreWebView2_16Value == null)
			{
				try
				{
					_nativeICoreWebView2_16Value = (ICoreWebView2_16)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_16.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_16Value;
		}
		set
		{
			_nativeICoreWebView2_16Value = value;
		}
	}

	internal ICoreWebView2_17 _nativeICoreWebView2_17
	{
		get
		{
			if (_nativeICoreWebView2_17Value == null)
			{
				try
				{
					_nativeICoreWebView2_17Value = (ICoreWebView2_17)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_17.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_17Value;
		}
		set
		{
			_nativeICoreWebView2_17Value = value;
		}
	}

	internal ICoreWebView2_18 _nativeICoreWebView2_18
	{
		get
		{
			if (_nativeICoreWebView2_18Value == null)
			{
				try
				{
					_nativeICoreWebView2_18Value = (ICoreWebView2_18)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_18.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_18Value;
		}
		set
		{
			_nativeICoreWebView2_18Value = value;
		}
	}

	internal ICoreWebView2_19 _nativeICoreWebView2_19
	{
		get
		{
			if (_nativeICoreWebView2_19Value == null)
			{
				try
				{
					_nativeICoreWebView2_19Value = (ICoreWebView2_19)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_19.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_19Value;
		}
		set
		{
			_nativeICoreWebView2_19Value = value;
		}
	}

	/// <summary>
	/// Desired <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel" /> of a WebView.
	/// </summary><remarks>
	/// An app may set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel" /> to indicate desired memory consumption level of WebView.
	/// Scripts will not be impacted and continue to run.
	/// This is useful for inactive apps that still want to run scripts and/or keep network connections alive and therefore could not call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> to reduce memory consumption.
	/// These apps can set memory usage target level to <c>CoreWebView2MemoryUsageTargetLevel.Low</c> when the app becomes inactive, and set back to <c>CoreWebView2MemoryUsageTargetLevel.Normal</c> when the app becomes active.
	///
	/// It is not necessary to set CoreWebView2Controller's IsVisible property to false when setting the property.
	///
	/// It is a best effort operation to change memory usage level, and the API will return before the operation completes.
	///
	/// Setting the level to `CoreWebView2MemoryUsageTargetLevel.Low` could potentially cause memory for some WebView browser processes to be swapped out to disk in some circumstances. It is a best effort to reduce memory usage as much as possible.
	/// If a script runs after its related memory has been swapped out, the memory will be swapped back in to ensure the script can still run, but performance might be impacted.
	/// Therefore, the app should set the level back to `CoreWebView2MemoryUsageTargetLevel.Normal` when the app becomes active again. Setting memory usage target level back to normal will not happen automatically.
	///
	/// An app should choose to use either the combination of <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> or the combination of setting MemoryUsageTargetLevel to `CoreWebView2MemoryUsageTargetLevel.Low` and `CoreWebView2MemoryUsageTargetLevel.Normal`. It is not advisable to mix them.
	/// Trying to set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel" /> while suspended will be ignored.
	/// The <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> methods will change the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel" />.
	/// <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync" /> will automatically set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel" /> to `CoreWebView2MemoryUsageTargetLevel.Low` while <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> on suspended WebView will automatically set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel" /> to `CoreWebView2MemoryUsageTargetLevel.Normal`.
	/// Calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> when the WebView is not suspended would not change <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel" />.
	/// </remarks>
	public CoreWebView2MemoryUsageTargetLevel MemoryUsageTargetLevel
	{
		get
		{
			try
			{
				return (CoreWebView2MemoryUsageTargetLevel)_nativeICoreWebView2_19.MemoryUsageTargetLevel;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2_19.MemoryUsageTargetLevel = (COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_2 _nativeICoreWebView2_2
	{
		get
		{
			if (_nativeICoreWebView2_2Value == null)
			{
				try
				{
					_nativeICoreWebView2_2Value = (ICoreWebView2_2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_2Value;
		}
		set
		{
			_nativeICoreWebView2_2Value = value;
		}
	}

	/// <summary>
	/// Gets the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CookieManager" /> object associated with this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" />.
	/// </summary><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CookieManager" />
	public CoreWebView2CookieManager CookieManager
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2_2.CookieManager == null) ? null : new CoreWebView2CookieManager(_nativeICoreWebView2_2.CookieManager);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Exposes the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> used to create this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" />.</summary>
	public CoreWebView2Environment Environment
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2_2.Environment == null) ? null : new CoreWebView2Environment(_nativeICoreWebView2_2.Environment);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_20 _nativeICoreWebView2_20
	{
		get
		{
			if (_nativeICoreWebView2_20Value == null)
			{
				try
				{
					_nativeICoreWebView2_20Value = (ICoreWebView2_20)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_20.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_20Value;
		}
		set
		{
			_nativeICoreWebView2_20Value = value;
		}
	}

	/// <summary>
	/// The unique identifier of the main frame. It's the same kind of ID as with the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Frame.FrameId" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo.FrameId" />.
	/// </summary><remarks>
	/// FrameId may not be valid if <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" /> has not done any navigation. It's safe to get this value during or after the first <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> event. Otherwise, it could return the invalid frame Id <c>0</c>.
	/// </remarks>
	public uint FrameId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_20.FrameId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_21 _nativeICoreWebView2_21
	{
		get
		{
			if (_nativeICoreWebView2_21Value == null)
			{
				try
				{
					_nativeICoreWebView2_21Value = (ICoreWebView2_21)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_21.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_21Value;
		}
		set
		{
			_nativeICoreWebView2_21Value = value;
		}
	}

	internal ICoreWebView2_22 _nativeICoreWebView2_22
	{
		get
		{
			if (_nativeICoreWebView2_22Value == null)
			{
				try
				{
					_nativeICoreWebView2_22Value = (ICoreWebView2_22)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_22.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_22Value;
		}
		set
		{
			_nativeICoreWebView2_22Value = value;
		}
	}

	internal ICoreWebView2_25 _nativeICoreWebView2_25
	{
		get
		{
			if (_nativeICoreWebView2_25Value == null)
			{
				try
				{
					_nativeICoreWebView2_25Value = (ICoreWebView2_25)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_25.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_25Value;
		}
		set
		{
			_nativeICoreWebView2_25Value = value;
		}
	}

	internal ICoreWebView2_23 _nativeICoreWebView2_23
	{
		get
		{
			if (_nativeICoreWebView2_23Value == null)
			{
				try
				{
					_nativeICoreWebView2_23Value = (ICoreWebView2_23)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_23.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_23Value;
		}
		set
		{
			_nativeICoreWebView2_23Value = value;
		}
	}

	internal ICoreWebView2_27 _nativeICoreWebView2_27
	{
		get
		{
			if (_nativeICoreWebView2_27Value == null)
			{
				try
				{
					_nativeICoreWebView2_27Value = (ICoreWebView2_27)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_27.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_27Value;
		}
		set
		{
			_nativeICoreWebView2_27Value = value;
		}
	}

	internal ICoreWebView2_28 _nativeICoreWebView2_28
	{
		get
		{
			if (_nativeICoreWebView2_28Value == null)
			{
				try
				{
					_nativeICoreWebView2_28Value = (ICoreWebView2_28)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_28.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_28Value;
		}
		set
		{
			_nativeICoreWebView2_28Value = value;
		}
	}

	/// <summary>Retrieves the find session interface for the current web view.</summary>
	public CoreWebView2Find Find
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2_28.Find == null) ? null : new CoreWebView2Find(_nativeICoreWebView2_28.Find);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_26 _nativeICoreWebView2_26
	{
		get
		{
			if (_nativeICoreWebView2_26Value == null)
			{
				try
				{
					_nativeICoreWebView2_26Value = (ICoreWebView2_26)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_26.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_26Value;
		}
		set
		{
			_nativeICoreWebView2_26Value = value;
		}
	}

	internal ICoreWebView2_24 _nativeICoreWebView2_24
	{
		get
		{
			if (_nativeICoreWebView2_24Value == null)
			{
				try
				{
					_nativeICoreWebView2_24Value = (ICoreWebView2_24)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_24.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_24Value;
		}
		set
		{
			_nativeICoreWebView2_24Value = value;
		}
	}

	internal ICoreWebView2_3 _nativeICoreWebView2_3
	{
		get
		{
			if (_nativeICoreWebView2_3Value == null)
			{
				try
				{
					_nativeICoreWebView2_3Value = (ICoreWebView2_3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_3Value;
		}
		set
		{
			_nativeICoreWebView2_3Value = value;
		}
	}

	/// <summary>
	/// Whether WebView is suspended.
	/// </summary><remarks>
	/// True when WebView is suspended, from the time when <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync" /> has completed successfully until WebView is resumed.
	/// </remarks>
	public bool IsSuspended
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_3.IsSuspended != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_4 _nativeICoreWebView2_4
	{
		get
		{
			if (_nativeICoreWebView2_4Value == null)
			{
				try
				{
					_nativeICoreWebView2_4Value = (ICoreWebView2_4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_4Value;
		}
		set
		{
			_nativeICoreWebView2_4Value = value;
		}
	}

	internal ICoreWebView2_5 _nativeICoreWebView2_5
	{
		get
		{
			if (_nativeICoreWebView2_5Value == null)
			{
				try
				{
					_nativeICoreWebView2_5Value = (ICoreWebView2_5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_5Value;
		}
		set
		{
			_nativeICoreWebView2_5Value = value;
		}
	}

	internal ICoreWebView2_6 _nativeICoreWebView2_6
	{
		get
		{
			if (_nativeICoreWebView2_6Value == null)
			{
				try
				{
					_nativeICoreWebView2_6Value = (ICoreWebView2_6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_6Value;
		}
		set
		{
			_nativeICoreWebView2_6Value = value;
		}
	}

	internal ICoreWebView2_7 _nativeICoreWebView2_7
	{
		get
		{
			if (_nativeICoreWebView2_7Value == null)
			{
				try
				{
					_nativeICoreWebView2_7Value = (ICoreWebView2_7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_7Value;
		}
		set
		{
			_nativeICoreWebView2_7Value = value;
		}
	}

	internal ICoreWebView2_8 _nativeICoreWebView2_8
	{
		get
		{
			if (_nativeICoreWebView2_8Value == null)
			{
				try
				{
					_nativeICoreWebView2_8Value = (ICoreWebView2_8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_8Value;
		}
		set
		{
			_nativeICoreWebView2_8Value = value;
		}
	}

	/// <summary>
	/// Indicates whether any audio output from this CoreWebView2 is playing. <c>true</c> if audio is playing even if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.IsMuted" /> is true.</summary>
	public bool IsDocumentPlayingAudio
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_8.IsDocumentPlayingAudio != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Indicates whether all audio output from this CoreWebView2 is muted or not. Set to true will mute this CoreWebView2, and set to false will unmute this CoreWebView2. <c>true</c> if audio is muted.</summary>
	public bool IsMuted
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_8.IsMuted != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2_8.IsMuted = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2_9 _nativeICoreWebView2_9
	{
		get
		{
			if (_nativeICoreWebView2_9Value == null)
			{
				try
				{
					_nativeICoreWebView2_9Value = (ICoreWebView2_9)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_9Value;
		}
		set
		{
			_nativeICoreWebView2_9Value = value;
		}
	}

	/// <summary>
	/// The default download dialog corner alignment.</summary>
	public CoreWebView2DefaultDownloadDialogCornerAlignment DefaultDownloadDialogCornerAlignment
	{
		get
		{
			try
			{
				return (CoreWebView2DefaultDownloadDialogCornerAlignment)_nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment = (COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The default download dialog margin relative to the WebView corner specified by <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.DefaultDownloadDialogCornerAlignment" />.
	/// </summary><remarks>
	/// The margin is a point that describes the vertical and horizontal distances between the chosen WebView corner and the default download dialog corner nearest to it. Positive values move the dialog towards the center of the WebView from the chosen WebView corner, and negative values move the dialog away from it. Use (0, 0) to align the dialog to the WebView corner with no margin. The corner alignment and margin should be set during initialization to ensure that they are correctly applied when the layout is first computed, otherwise they will not take effect until the next time the WebView position or size is updated.
	/// </remarks>
	public Point DefaultDownloadDialogMargin
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2_9.DefaultDownloadDialogMargin);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2_9.DefaultDownloadDialogMargin = COMDotNetTypeConverter.PointNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// True if the default download dialog is currently open.
	/// </summary><remarks>
	/// The value of this property changes only when the default download dialog is explicitly opened or closed. Hiding the WebView implicitly hides the dialog, but does not change the value of this property.
	/// </remarks>
	public bool IsDefaultDownloadDialogOpen
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_9.IsDefaultDownloadDialogOpen != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ContainsFullScreenElementChanged is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.ContainsFullScreenElement" /> property changes.
	/// </summary><remarks>
	/// An HTML element inside the WebView may enter fullscreen to the size of the WebView or leave fullscreen. This event is useful when, for example, a video element requests to go fullscreen. The listener of this event may resize the WebView in response.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.ContainsFullScreenElement" />
	public event EventHandler<object> ContainsFullScreenElementChanged
	{
		add
		{
			if (privateContainsFullScreenElementChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_ContainsFullScreenElementChanged(new CoreWebView2ContainsFullScreenElementChangedEventHandler(OnContainsFullScreenElementChanged), out _ContainsFullScreenElementChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateContainsFullScreenElementChanged = (EventHandler<object>)Delegate.Combine(privateContainsFullScreenElementChanged, value);
		}
		remove
		{
			privateContainsFullScreenElementChanged = (EventHandler<object>)Delegate.Remove(privateContainsFullScreenElementChanged, value);
			if (privateContainsFullScreenElementChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ContainsFullScreenElementChanged(_ContainsFullScreenElementChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ContentLoading is raised before any content is loaded, including scripts added with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String)" />. ContentLoading is not raised if a same page navigation occurs (such as through fragment navigations or <c>history.pushState</c> navigations).
	/// </summary><remarks>
	/// This operation follows the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" /> events and precedes the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" /> and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> events.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" />
	public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
	{
		add
		{
			if (privateContentLoading == null)
			{
				try
				{
					_nativeICoreWebView2.add_ContentLoading(new CoreWebView2ContentLoadingEventHandler(OnContentLoading), out _ContentLoadingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateContentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Combine(privateContentLoading, value);
		}
		remove
		{
			privateContentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Remove(privateContentLoading, value);
			if (privateContentLoading != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ContentLoading(_ContentLoadingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// DocumentTitleChanged is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.DocumentTitle" /> property changes and may be raised before or after the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> event.
	/// </summary><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.DocumentTitle" />
	public event EventHandler<object> DocumentTitleChanged
	{
		add
		{
			if (privateDocumentTitleChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_DocumentTitleChanged(new CoreWebView2DocumentTitleChangedEventHandler(OnDocumentTitleChanged), out _DocumentTitleChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateDocumentTitleChanged = (EventHandler<object>)Delegate.Combine(privateDocumentTitleChanged, value);
		}
		remove
		{
			privateDocumentTitleChanged = (EventHandler<object>)Delegate.Remove(privateDocumentTitleChanged, value);
			if (privateDocumentTitleChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_DocumentTitleChanged(_DocumentTitleChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// FrameNavigationCompleted is raised when a child frame has completely loaded (<c>body.onload</c> has been raised) or loading stopped with error.</summary>
	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> FrameNavigationCompleted
	{
		add
		{
			if (privateFrameNavigationCompleted == null)
			{
				try
				{
					_nativeICoreWebView2.add_FrameNavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(OnFrameNavigationCompleted), out _FrameNavigationCompletedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateFrameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(privateFrameNavigationCompleted, value);
		}
		remove
		{
			privateFrameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(privateFrameNavigationCompleted, value);
			if (privateFrameNavigationCompleted != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_FrameNavigationCompleted(_FrameNavigationCompletedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// FrameNavigationStarting is raised when a child frame in the WebView requests permission to navigate to a different URI.
	/// </summary><remarks>
	/// Redirects raise this operation as well, and the navigation id is the same as the original one. You may block corresponding navigations until the event handler returns.
	/// </remarks>
	public event EventHandler<CoreWebView2NavigationStartingEventArgs> FrameNavigationStarting
	{
		add
		{
			if (privateFrameNavigationStarting == null)
			{
				try
				{
					_nativeICoreWebView2.add_FrameNavigationStarting(new CoreWebView2NavigationStartingEventHandler(OnFrameNavigationStarting), out _FrameNavigationStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateFrameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(privateFrameNavigationStarting, value);
		}
		remove
		{
			privateFrameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(privateFrameNavigationStarting, value);
			if (privateFrameNavigationStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_FrameNavigationStarting(_FrameNavigationStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// HistoryChanged is raised for changes to joint session history, which consists of top-level and manual frame navigations.
	/// </summary><remarks>
	/// Use HistoryChanged to verify that the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.CanGoBack" /> or <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.CanGoForward" /> value has changed. HistoryChanged is also raised for using <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.GoBack" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.GoForward" />. HistoryChanged is raised after <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" /> and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" />. CanGoBack is false for navigations initiated through CoreWebView2Frame APIs if there has not yet been a user gesture.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.CanGoBack" /><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.CanGoForward" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" />
	public event EventHandler<object> HistoryChanged
	{
		add
		{
			if (privateHistoryChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_HistoryChanged(new CoreWebView2HistoryChangedEventHandler(OnHistoryChanged), out _HistoryChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateHistoryChanged = (EventHandler<object>)Delegate.Combine(privateHistoryChanged, value);
		}
		remove
		{
			privateHistoryChanged = (EventHandler<object>)Delegate.Remove(privateHistoryChanged, value);
			if (privateHistoryChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_HistoryChanged(_HistoryChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// NavigationCompleted is raised when the WebView has completely loaded (<c>body.onload</c> has been raised) or loading stopped with error.</summary>
	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
	{
		add
		{
			if (privateNavigationCompleted == null)
			{
				try
				{
					_nativeICoreWebView2.add_NavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(OnNavigationCompleted), out _NavigationCompletedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(privateNavigationCompleted, value);
		}
		remove
		{
			privateNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(privateNavigationCompleted, value);
			if (privateNavigationCompleted != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_NavigationCompleted(_NavigationCompletedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// NavigationStarting is raised when the WebView main frame is requesting permission to navigate to a different URI.
	/// </summary><remarks>
	/// Redirects raise this event as well, and the navigation id is the same as the original one. You may block corresponding navigations until the event handler returns.
	/// </remarks>
	public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting
	{
		add
		{
			if (privateNavigationStarting == null)
			{
				try
				{
					_nativeICoreWebView2.add_NavigationStarting(new CoreWebView2NavigationStartingEventHandler(OnNavigationStarting), out _NavigationStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(privateNavigationStarting, value);
		}
		remove
		{
			privateNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(privateNavigationStarting, value);
			if (privateNavigationStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_NavigationStarting(_NavigationStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// NewWindowRequested is raised when content inside the WebView requests to open a new window, such as through <c>window.open()</c>.
	/// </summary><remarks>
	/// The app can pass a target WebView that is considered the opened window or mark the event as <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Handled" />, in which case WebView2 does not open a window.
	/// If either <c>Handled</c> or <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow" /> properties are not set, the target content will be opened on a popup window.
	/// If a deferral is not taken on the event args, scripts that resulted in the new window that are requested are blocked until the event handler returns. If a deferral is taken, then scripts are blocked until the deferral is completed.
	///
	/// On Hololens 2, if the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow" /> property is not set and the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Handled" /> property is not set to <c>true</c>, the WebView2 will navigate to the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Uri" />.
	/// If either of these properties are set, the WebView2 will not navigate to the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Uri" /> and the the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> event will continue as normal.
	/// </remarks>
	public event EventHandler<CoreWebView2NewWindowRequestedEventArgs> NewWindowRequested
	{
		add
		{
			if (privateNewWindowRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_NewWindowRequested(new CoreWebView2NewWindowRequestedEventHandler(OnNewWindowRequested), out _NewWindowRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNewWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Combine(privateNewWindowRequested, value);
		}
		remove
		{
			privateNewWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Remove(privateNewWindowRequested, value);
			if (privateNewWindowRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_NewWindowRequested(_NewWindowRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// PermissionRequested is raised when content in a WebView requests permission to access some privileged resources.
	/// </summary><remarks>
	/// If a deferral is not taken on the event args, the subsequent scripts are blocked until the event handler returns. If a deferral is taken, the scripts are blocked until the deferral is completed.
	/// </remarks>
	public event EventHandler<CoreWebView2PermissionRequestedEventArgs> PermissionRequested
	{
		add
		{
			if (privatePermissionRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_PermissionRequested(new CoreWebView2PermissionRequestedEventHandler(OnPermissionRequested), out _PermissionRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privatePermissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Combine(privatePermissionRequested, value);
		}
		remove
		{
			privatePermissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Remove(privatePermissionRequested, value);
			if (privatePermissionRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_PermissionRequested(_PermissionRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ProcessFailed is raised when a WebView process ends unexpectedly or becomes unresponsive.
	/// </summary><remarks><c>ProcessFailed</c> is raised when any of the processes in the <a href="/microsoft-edge/webview2/concepts/process-model?tabs=csharp#processes-in-the-webview2-runtime">WebView2 Process Group</a> encounters one of the following conditions:
	///
	/// <list type="table"><listheader><term>Condition</term><description>Details</description></listheader><item><term>Unexpected exit</term><description>
	/// The process indicated by the event args has exited unexpectedly (usually due to a crash). The failure might or might not be recoverable, and some failures are auto-recoverable.
	/// </description></item><item><term>Unresponsiveness</term><description>
	/// The process indicated by the event args has become unresponsive to user input. This is only reported for renderer processes, and will run every few seconds until the process becomes responsive again.
	/// </description></item></list><b>Note:</b> When the failing process is the browser process, a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Environment.BrowserProcessExited" /> event will run too.
	///
	/// Your application can use  <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs" /> to identify which condition and process the event is for, and to collect diagnostics and handle recovery if necessary. For more details about which cases need to be handled by your application, see  <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind" />.
	/// </remarks><example>
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="ProcessFailed":::
	/// </example>
	public event EventHandler<CoreWebView2ProcessFailedEventArgs> ProcessFailed
	{
		add
		{
			if (privateProcessFailed == null)
			{
				try
				{
					_nativeICoreWebView2.add_ProcessFailed(new CoreWebView2ProcessFailedEventHandler(OnProcessFailed), out _ProcessFailedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateProcessFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Combine(privateProcessFailed, value);
		}
		remove
		{
			privateProcessFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Remove(privateProcessFailed, value);
			if (privateProcessFailed != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ProcessFailed(_ProcessFailedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ScriptDialogOpening is raised when a JavaScript dialog (<c>alert</c>, <c>confirm</c>, <c>prompt</c>, or <c>beforeunload</c>) displays for the WebView.
	/// </summary><remarks>
	/// This event only is raised if the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.AreDefaultScriptDialogsEnabled" /> property is set to <c>false</c>. This event suppresses dialogs or replaces default dialogs with custom dialogs.
	///
	/// If a deferral is not taken on the event args, the subsequent scripts are blocked until the event handler returns. If a deferral is taken, the scripts are blocked until the deferral is completed.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.AreDefaultScriptDialogsEnabled" />
	public event EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> ScriptDialogOpening
	{
		add
		{
			if (privateScriptDialogOpening == null)
			{
				try
				{
					_nativeICoreWebView2.add_ScriptDialogOpening(new CoreWebView2ScriptDialogOpeningEventHandler(OnScriptDialogOpening), out _ScriptDialogOpeningToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateScriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Combine(privateScriptDialogOpening, value);
		}
		remove
		{
			privateScriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Remove(privateScriptDialogOpening, value);
			if (privateScriptDialogOpening != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ScriptDialogOpening(_ScriptDialogOpeningToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// SourceChanged is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.Source" /> property changes.
	/// </summary><remarks>
	/// SourceChanged is raised when navigating to a different site or fragment navigations. It is not raised for other types of navigations such as page refreshes or <c>history.pushState</c> with the same URL as the current page. This event is raised before <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> for navigation to a new document.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.Source" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" />
	public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged
	{
		add
		{
			if (privateSourceChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_SourceChanged(new CoreWebView2SourceChangedEventHandler(OnSourceChanged), out _SourceChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateSourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Combine(privateSourceChanged, value);
		}
		remove
		{
			privateSourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Remove(privateSourceChanged, value);
			if (privateSourceChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_SourceChanged(_SourceChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// WebMessageReceived is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /> setting is set and the top-level document of the WebView runs <c>window.chrome.webview.postMessage</c> or <c>window.chrome.webview.postMessageWithAdditionalObjects</c>.
	/// </summary><remarks>
	/// The <c>postMessage</c> function is <c>void postMessage(object)</c> where object is any object supported by JSON conversion.
	/// When <c>postMessage</c> is called, the handler's Invoke method will be called with the <c>object</c> parameter <c>postMessage</c> converted to a JSON string.
	/// If the same page calls <c>postMessage</c> multiple times, the corresponding <c>WebMessageReceived</c> events are guaranteed to be fired in the same order. However, if multiple frames call <c>postMessage</c>, there is no guaranteed order. In addition, <c>WebMessageReceived</c> events caused by calls to <c>postMessage</c> are not guaranteed to be sequenced with events caused by DOM APIs. For example, if the page runs
	/// <code>
	/// chrome.webview.postMessage("message");
	/// window.open();
	/// </code>
	/// then the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> event might be fired before the <c>WebMessageReceived</c> event. If you need the <c>WebMessageReceived</c> event to happen before anything else, then in the <c>WebMessageReceived</c> handler you can post a message back to the page and have the page wait until it receives that message before continuing.
	/// </remarks>
	public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
	{
		add
		{
			if (privateWebMessageReceived == null)
			{
				try
				{
					_nativeICoreWebView2.add_WebMessageReceived(new CoreWebView2WebMessageReceivedEventHandler(OnWebMessageReceived), out _WebMessageReceivedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateWebMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Combine(privateWebMessageReceived, value);
		}
		remove
		{
			privateWebMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Remove(privateWebMessageReceived, value);
			if (privateWebMessageReceived != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_WebMessageReceived(_WebMessageReceivedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// WebResourceRequested is raised when the WebView is performing a URL request to a matching URL and resource context filter that was added with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds)" />.
	/// </summary><remarks>
	/// At least one filter must be added for the event to be raised.
	/// The web resource requested may be blocked until the event handler returns if a deferral is not taken on the event args. If a deferral is taken, then the web resource requested is blocked until the deferral is completed.
	///
	/// If this event is subscribed in the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> handler it should be called after the new window is set. For more details see <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow" />.
	///
	/// This event is by default raised for file, http, and https URI schemes. This is also raised for registered custom URI schemes. See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CustomSchemeRegistration" /> for more details.
	/// </remarks><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds)" />
	public event EventHandler<CoreWebView2WebResourceRequestedEventArgs> WebResourceRequested
	{
		add
		{
			if (privateWebResourceRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_WebResourceRequested(new CoreWebView2WebResourceRequestedEventHandler(OnWebResourceRequested), out _WebResourceRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateWebResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Combine(privateWebResourceRequested, value);
		}
		remove
		{
			privateWebResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Remove(privateWebResourceRequested, value);
			if (privateWebResourceRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_WebResourceRequested(_WebResourceRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// WindowCloseRequested is raised when content inside the WebView requested to close the window, such as after <c>window.close()</c> is run.
	/// </summary><remarks>
	/// The app should close the WebView and related app window if that makes sense to the app.
	/// After the first <c>window.close()</c> call, this event may not fire for any immediate back to back <c>window.close()</c> calls.
	/// </remarks>
	public event EventHandler<object> WindowCloseRequested
	{
		add
		{
			if (privateWindowCloseRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_WindowCloseRequested(new CoreWebView2WindowCloseRequestedEventHandler(OnWindowCloseRequested), out _WindowCloseRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateWindowCloseRequested = (EventHandler<object>)Delegate.Combine(privateWindowCloseRequested, value);
		}
		remove
		{
			privateWindowCloseRequested = (EventHandler<object>)Delegate.Remove(privateWindowCloseRequested, value);
			if (privateWindowCloseRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_WindowCloseRequested(_WindowCloseRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// BasicAuthenticationRequested event is raised when WebView encounters a Basic HTTP Authentication request as described in https://developer.mozilla.org/docs/Web/HTTP/Authentication, a Digest HTTP Authentication request as described in https://developer.mozilla.org/docs/Web/HTTP/Headers/Authorization#digest, an NTLM authentication or a Proxy Authentication request.
	/// </summary><remarks>
	/// The host can provide a response with credentials for the authentication or cancel the request. If the host sets the Cancel property to false but does not provide either UserName or Password properties on the Response property, then WebView2 will show the default authentication challenge dialog prompt to the user.
	/// </remarks>
	public event EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> BasicAuthenticationRequested
	{
		add
		{
			if (privateBasicAuthenticationRequested == null)
			{
				try
				{
					_nativeICoreWebView2_10.add_BasicAuthenticationRequested(new CoreWebView2BasicAuthenticationRequestedEventHandler(OnBasicAuthenticationRequested), out _BasicAuthenticationRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateBasicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Combine(privateBasicAuthenticationRequested, value);
		}
		remove
		{
			privateBasicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Remove(privateBasicAuthenticationRequested, value);
			if (privateBasicAuthenticationRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_10.remove_BasicAuthenticationRequested(_BasicAuthenticationRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ContextMenuRequested is raised when a context menu is requested by the user and the content inside WebView hasn't disabled context menus.
	/// </summary><remarks>
	/// The host has the option to create their own context menu with the information provided in the event or can add items to or remove items from WebView context menu. If the host doesn't handle the event, WebView will display the default context menu.
	/// </remarks>
	public event EventHandler<CoreWebView2ContextMenuRequestedEventArgs> ContextMenuRequested
	{
		add
		{
			if (privateContextMenuRequested == null)
			{
				try
				{
					_nativeICoreWebView2_11.add_ContextMenuRequested(new CoreWebView2ContextMenuRequestedEventHandler(OnContextMenuRequested), out _ContextMenuRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateContextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Combine(privateContextMenuRequested, value);
		}
		remove
		{
			privateContextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Remove(privateContextMenuRequested, value);
			if (privateContextMenuRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_11.remove_ContextMenuRequested(_ContextMenuRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// StatusBarTextChanged event is raised when the text in the [Window.statusbar](https://developer.mozilla.org/docs/Web/API/Window/statusbar) changes. When the event is fired use the property <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.StatusBarText" /> to get the current statusbar text.
	/// </summary><remarks>
	/// Events which cause causes can be anything from hover, url events, and others. There is not a finite list on how to cause the statusbar to change.
	/// The developer must create the status bar and set the text.
	/// </remarks>
	public event EventHandler<object> StatusBarTextChanged
	{
		add
		{
			if (privateStatusBarTextChanged == null)
			{
				try
				{
					_nativeICoreWebView2_12.add_StatusBarTextChanged(new CoreWebView2StatusBarTextChangedEventHandler(OnStatusBarTextChanged), out _StatusBarTextChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateStatusBarTextChanged = (EventHandler<object>)Delegate.Combine(privateStatusBarTextChanged, value);
		}
		remove
		{
			privateStatusBarTextChanged = (EventHandler<object>)Delegate.Remove(privateStatusBarTextChanged, value);
			if (privateStatusBarTextChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_12.remove_StatusBarTextChanged(_StatusBarTextChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The ServerCertificateErrorDetected event is raised when the WebView2 cannot verify server's digital certificate while loading a web page.
	/// </summary><remarks>
	/// This event will raise for all web resources and follows the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event.
	///
	/// If you don't handle the event, WebView2 will show the default TLS interstitial error page to the user for navigations, and for non-navigations the web request is cancelled.
	///
	/// Note that WebView2 before raising `ServerCertificateErrorDetected` raises a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> event with <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess" /> as FALSE and any of the below WebErrorStatuses that indicate a certificate failure.
	///
	/// <list type="bullet"><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateCommonNameIsIncorrect" /></description></item><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateExpired" /></description></item><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.ClientCertificateContainsErrors" /></description></item><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateRevoked" /></description></item><item><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateIsInvalid" /></description></item></list>
	///
	/// For more details see <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess" /> and handle ServerCertificateErrorDetected event or show the default TLS interstitial error page to the user according to the app needs.
	///
	/// WebView2 caches the response when action is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ServerCertificateErrorAction.AlwaysAllow" /> for the RequestUri's host and the server certificate in the session and the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ServerCertificateErrorDetected" /> event won't be raised again.
	///
	/// To raise the event again you must clear the cache using <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.ClearServerCertificateErrorActionsAsync" />.
	/// </remarks>
	public event EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> ServerCertificateErrorDetected
	{
		add
		{
			if (privateServerCertificateErrorDetected == null)
			{
				try
				{
					_nativeICoreWebView2_14.add_ServerCertificateErrorDetected(new CoreWebView2ServerCertificateErrorDetectedEventHandler(OnServerCertificateErrorDetected), out _ServerCertificateErrorDetectedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateServerCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Combine(privateServerCertificateErrorDetected, value);
		}
		remove
		{
			privateServerCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Remove(privateServerCertificateErrorDetected, value);
			if (privateServerCertificateErrorDetected != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_14.remove_ServerCertificateErrorDetected(_ServerCertificateErrorDetectedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Raised when the Favicon has changed. This can include when a new page is loaded and thus by default no icon is set or the icon is set for the page by DOM or JavaScript.
	/// </summary><remarks>
	/// The first argument is the Webview2 which saw the changed Favicon and the second is null.
	/// </remarks>
	public event EventHandler<object> FaviconChanged
	{
		add
		{
			if (privateFaviconChanged == null)
			{
				try
				{
					_nativeICoreWebView2_15.add_FaviconChanged(new CoreWebView2FaviconChangedEventHandler(OnFaviconChanged), out _FaviconChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateFaviconChanged = (EventHandler<object>)Delegate.Combine(privateFaviconChanged, value);
		}
		remove
		{
			privateFaviconChanged = (EventHandler<object>)Delegate.Remove(privateFaviconChanged, value);
			if (privateFaviconChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_15.remove_FaviconChanged(_FaviconChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// LaunchingExternalUriScheme is raised when a navigation request is made to a URI scheme that is registered with the OS.
	/// </summary><remarks>
	/// The <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.LaunchingExternalUriScheme" /> event handler may suppress the default dialog or replace the default dialog with a custom dialog.
	/// If a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Deferral" /> is not taken on the event args, the external URI scheme launch is blocked until the event handler returns.
	/// If a deferral is taken, the external URI scheme launch is blocked until the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Deferral" /> is completed.
	/// The host also has the option to cancel the URI scheme launch.
	///
	/// The <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> events will be raised, regardless of whether the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel" /> property is set to <c>true</c> or <c>false</c>.
	/// The <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> event will be raised with the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess" /> property set to <c>false</c> and the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.WebErrorStatus" /> property set to <c>CoreWebView2WebErrorStatus.ConnectionAborted</c> regardless of whether the host sets the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2LaunchingExternalUriSchemeEventArgs.Cancel" /> property.
	/// The <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged" />, <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged" /> events will not be raised for this navigation to the external URI scheme regardless of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel" /> property.
	/// The <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.LaunchingExternalUriScheme" /> event will be raised after the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event and before the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /> event.
	///
	/// The default <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Settings" /> will also be updated upon navigation to an external URI scheme.
	/// If a setting on the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Settings" /> interface has been changed, navigating to an external URI scheme will trigger the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Settings" /> to update.
	///
	/// The WebView2 may not display the default dialog based on user settings, browser settings, and whether the origin is determined as a [trustworthy origin](https://w3c.github.io/webappsec-secure-contexts#potentially-trustworthy-origin); however, the event will still be raised.
	/// If the request is initiated by a cross-origin frame without a user gesture, the request will be blocked and the `LaunchingExternalUriScheme` event will not be raised.
	/// </remarks>
	public event EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> LaunchingExternalUriScheme
	{
		add
		{
			if (privateLaunchingExternalUriScheme == null)
			{
				try
				{
					_nativeICoreWebView2_18.add_LaunchingExternalUriScheme(new CoreWebView2LaunchingExternalUriSchemeEventHandler(OnLaunchingExternalUriScheme), out _LaunchingExternalUriSchemeToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateLaunchingExternalUriScheme = (EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs>)Delegate.Combine(privateLaunchingExternalUriScheme, value);
		}
		remove
		{
			privateLaunchingExternalUriScheme = (EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs>)Delegate.Remove(privateLaunchingExternalUriScheme, value);
			if (privateLaunchingExternalUriScheme != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_18.remove_LaunchingExternalUriScheme(_LaunchingExternalUriSchemeToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// DOMContentLoaded is raised when the initial HTML document has been parsed.
	/// </summary><remarks>
	/// This aligns with the the document's DOMContentLoaded event in HTML.
	/// </remarks>
	public event EventHandler<CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
	{
		add
		{
			if (privateDOMContentLoaded == null)
			{
				try
				{
					_nativeICoreWebView2_2.add_DOMContentLoaded(new CoreWebView2DOMContentLoadedEventHandler(OnDOMContentLoaded), out _DOMContentLoadedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateDOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Combine(privateDOMContentLoaded, value);
		}
		remove
		{
			privateDOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Remove(privateDOMContentLoaded, value);
			if (privateDOMContentLoaded != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_2.remove_DOMContentLoaded(_DOMContentLoadedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// WebResourceResponseReceived is raised when the WebView receives the response for a request for a web resource (any URI resolution performed by the WebView; such as HTTP/HTTPS, file and data requests from redirects, navigations, declarations in HTML, implicit Favicon lookups, and fetch API usage in the document).
	/// </summary><remarks>
	/// The host app can use this event to view the actual request and response for a web resource. There is no guarantee about the order in which the WebView processes the response and the host app's handler runs. The app's handler will not block the WebView from processing the response.
	/// The event args include the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest" /> as sent by the wire and <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse" /> received, including any additional headers added by the network stack that were not be included as part of the associated <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event, such as Authentication headers.
	/// </remarks>
	public event EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> WebResourceResponseReceived
	{
		add
		{
			if (privateWebResourceResponseReceived == null)
			{
				try
				{
					_nativeICoreWebView2_2.add_WebResourceResponseReceived(new CoreWebView2WebResourceResponseReceivedEventHandler(OnWebResourceResponseReceived), out _WebResourceResponseReceivedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateWebResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Combine(privateWebResourceResponseReceived, value);
		}
		remove
		{
			privateWebResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Remove(privateWebResourceResponseReceived, value);
			if (privateWebResourceResponseReceived != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_2.remove_WebResourceResponseReceived(_WebResourceResponseReceivedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary></summary>
	public event EventHandler<CoreWebView2SaveAsUIShowingEventArgs> SaveAsUIShowing
	{
		add
		{
			if (privateSaveAsUIShowing == null)
			{
				try
				{
					_nativeICoreWebView2_25.add_SaveAsUIShowing(new CoreWebView2SaveAsUIShowingEventHandler(OnSaveAsUIShowing), out _SaveAsUIShowingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateSaveAsUIShowing = (EventHandler<CoreWebView2SaveAsUIShowingEventArgs>)Delegate.Combine(privateSaveAsUIShowing, value);
		}
		remove
		{
			privateSaveAsUIShowing = (EventHandler<CoreWebView2SaveAsUIShowingEventArgs>)Delegate.Remove(privateSaveAsUIShowing, value);
			if (privateSaveAsUIShowing != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_25.remove_SaveAsUIShowing(_SaveAsUIShowingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ScreenCaptureStarting event is raised when the [Screen Capture API](https://www.w3.org/TR/screen-capture/) is requested by the user using getDisplayMedia().
	/// </summary><remarks>
	/// If a deferral is not taken on the event args, the subsequent scripts are blocked until the event handler returns. If a deferral is taken, the scripts are blocked until the deferral is completed.
	/// </remarks>
	public event EventHandler<CoreWebView2ScreenCaptureStartingEventArgs> ScreenCaptureStarting
	{
		add
		{
			if (privateScreenCaptureStarting == null)
			{
				try
				{
					_nativeICoreWebView2_27.add_ScreenCaptureStarting(new CoreWebView2ScreenCaptureStartingEventHandler(OnScreenCaptureStarting), out _ScreenCaptureStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateScreenCaptureStarting = (EventHandler<CoreWebView2ScreenCaptureStartingEventArgs>)Delegate.Combine(privateScreenCaptureStarting, value);
		}
		remove
		{
			privateScreenCaptureStarting = (EventHandler<CoreWebView2ScreenCaptureStartingEventArgs>)Delegate.Remove(privateScreenCaptureStarting, value);
			if (privateScreenCaptureStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_27.remove_ScreenCaptureStarting(_ScreenCaptureStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>This event will be raised during system FileTypePolicy
	/// checking the dangerous file extension list.
	///
	/// Developers can specify their own logic for determining whether
	/// to allow a particular type of file to be saved from the document origin URI.
	/// Developers can also determine the save decision based on other criteria.
	///
	/// Here are two properties in <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2SaveFileSecurityCheckStartingEventArgs" /> to manage the decision, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2SaveFileSecurityCheckStartingEventArgs.CancelSave" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2SaveFileSecurityCheckStartingEventArgs.SuppressDefaultPolicy" />.
	/// Table of Properties' value and result:
	/// <list type="table"><listheader><description>CancelSave</description><description>SuppressDefaultPolicy</description><description>Result</description></listheader><item><description>False</description><description>False</description><description>Perform the default policy check. It may show the security warning UI if the file extension is dangerous.</description></item><item><description>False</description><description>True</description><description>Skip the default policy check and the possible security warning. Start saving or downloading.</description></item><item><description>True</description><description>Any</description><description>Skip the default policy check and the possible security warning. Abort save or download.</description></item></list></summary>
	public event EventHandler<CoreWebView2SaveFileSecurityCheckStartingEventArgs> SaveFileSecurityCheckStarting
	{
		add
		{
			if (privateSaveFileSecurityCheckStarting == null)
			{
				try
				{
					_nativeICoreWebView2_26.add_SaveFileSecurityCheckStarting(new CoreWebView2SaveFileSecurityCheckStartingEventHandler(OnSaveFileSecurityCheckStarting), out _SaveFileSecurityCheckStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateSaveFileSecurityCheckStarting = (EventHandler<CoreWebView2SaveFileSecurityCheckStartingEventArgs>)Delegate.Combine(privateSaveFileSecurityCheckStarting, value);
		}
		remove
		{
			privateSaveFileSecurityCheckStarting = (EventHandler<CoreWebView2SaveFileSecurityCheckStartingEventArgs>)Delegate.Remove(privateSaveFileSecurityCheckStarting, value);
			if (privateSaveFileSecurityCheckStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_26.remove_SaveFileSecurityCheckStarting(_SaveFileSecurityCheckStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Add an event handler for the `NotificationReceived` event for
	/// non-persistent notifications.
	///
	/// If a deferral is not taken on the event args, the subsequent scripts after
	/// the DOM notification creation call (i.e. `Notification()`) are blocked
	/// until the event handler returns. If a deferral is taken, the scripts are
	/// blocked until the deferral is completed.</summary>
	public event EventHandler<CoreWebView2NotificationReceivedEventArgs> NotificationReceived
	{
		add
		{
			if (privateNotificationReceived == null)
			{
				try
				{
					_nativeICoreWebView2_24.add_NotificationReceived(new CoreWebView2NotificationReceivedEventHandler(OnNotificationReceived), out _NotificationReceivedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNotificationReceived = (EventHandler<CoreWebView2NotificationReceivedEventArgs>)Delegate.Combine(privateNotificationReceived, value);
		}
		remove
		{
			privateNotificationReceived = (EventHandler<CoreWebView2NotificationReceivedEventArgs>)Delegate.Remove(privateNotificationReceived, value);
			if (privateNotificationReceived != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_24.remove_NotificationReceived(_NotificationReceivedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// DownloadStarting is raised when a download has begun, blocking the default download dialog, but not blocking the progress of the download.
	/// </summary><remarks>
	/// The host can choose to cancel a download, change the result file path, and hide the default download dialog. If download is not handled or canceled, the download is saved to the default path after the event completes with default download dialog shown.
	/// </remarks>
	public event EventHandler<CoreWebView2DownloadStartingEventArgs> DownloadStarting
	{
		add
		{
			if (privateDownloadStarting == null)
			{
				try
				{
					_nativeICoreWebView2_4.add_DownloadStarting(new CoreWebView2DownloadStartingEventHandler(OnDownloadStarting), out _DownloadStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateDownloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Combine(privateDownloadStarting, value);
		}
		remove
		{
			privateDownloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Remove(privateDownloadStarting, value);
			if (privateDownloadStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_4.remove_DownloadStarting(_DownloadStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// FrameCreated is raised when a new iframe is created. Handle this event to get access to <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" /> objects.
	/// </summary><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs" /><remarks>
	/// Use the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed" /> to listen for when this iframe goes away.
	/// </remarks>
	public event EventHandler<CoreWebView2FrameCreatedEventArgs> FrameCreated
	{
		add
		{
			if (privateFrameCreated == null)
			{
				try
				{
					_nativeICoreWebView2_4.add_FrameCreated(new CoreWebView2FrameCreatedEventHandler(OnFrameCreated), out _FrameCreatedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateFrameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Combine(privateFrameCreated, value);
		}
		remove
		{
			privateFrameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Remove(privateFrameCreated, value);
			if (privateFrameCreated != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_4.remove_FrameCreated(_FrameCreatedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ClientCertificateRequested is raised when WebView2 is making a request to an HTTP server that needs a client certificate for HTTP authentication. Read more about HTTP client certificates at [RFC 8446 The Transport Layer Security (TLS) Protocol Version 1.3](https://tools.ietf.org/html/rfc8446).
	/// </summary><remarks>
	/// The host have several options for responding to client certificate requests:
	///
	/// <list type="table"><listheader><description>Scenario</description><description>Handled</description><description>Cancel</description><description>SelectedCertificate</description></listheader><item><description>Respond to server with a certificate</description><description>True</description><description>False</description><description>MutuallyTrustedCertificate value</description></item><item><description>Respond to server without certificate</description><description>True</description><description>False</description><description>null</description></item><item><description>Display default client certificate selection dialog prompt</description><description>False</description><description>False</description><description>n/a</description></item><item><description>Cancel the request</description><description>n/a</description><description>True</description><description>n/a</description></item></list>
	///
	/// If the host don't handle the event, WebView2 will show the default client certificate selection dialog prompt to the user.
	/// </remarks>
	public event EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> ClientCertificateRequested
	{
		add
		{
			if (privateClientCertificateRequested == null)
			{
				try
				{
					_nativeICoreWebView2_5.add_ClientCertificateRequested(new CoreWebView2ClientCertificateRequestedEventHandler(OnClientCertificateRequested), out _ClientCertificateRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateClientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Combine(privateClientCertificateRequested, value);
		}
		remove
		{
			privateClientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Remove(privateClientCertificateRequested, value);
			if (privateClientCertificateRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_5.remove_ClientCertificateRequested(_ClientCertificateRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// IsDocumentPlayingAudioChanged is raised when document starts or stops playing audio.</summary>
	public event EventHandler<object> IsDocumentPlayingAudioChanged
	{
		add
		{
			if (privateIsDocumentPlayingAudioChanged == null)
			{
				try
				{
					_nativeICoreWebView2_8.add_IsDocumentPlayingAudioChanged(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler(OnIsDocumentPlayingAudioChanged), out _IsDocumentPlayingAudioChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateIsDocumentPlayingAudioChanged = (EventHandler<object>)Delegate.Combine(privateIsDocumentPlayingAudioChanged, value);
		}
		remove
		{
			privateIsDocumentPlayingAudioChanged = (EventHandler<object>)Delegate.Remove(privateIsDocumentPlayingAudioChanged, value);
			if (privateIsDocumentPlayingAudioChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_8.remove_IsDocumentPlayingAudioChanged(_IsDocumentPlayingAudioChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// IsMutedChanged is raised when the mute state changes.</summary>
	public event EventHandler<object> IsMutedChanged
	{
		add
		{
			if (privateIsMutedChanged == null)
			{
				try
				{
					_nativeICoreWebView2_8.add_IsMutedChanged(new CoreWebView2IsMutedChangedEventHandler(OnIsMutedChanged), out _IsMutedChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateIsMutedChanged = (EventHandler<object>)Delegate.Combine(privateIsMutedChanged, value);
		}
		remove
		{
			privateIsMutedChanged = (EventHandler<object>)Delegate.Remove(privateIsMutedChanged, value);
			if (privateIsMutedChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_8.remove_IsMutedChanged(_IsMutedChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.IsDefaultDownloadDialogOpen" /> property changes.
	/// </summary><remarks>
	/// This event comes after the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.DownloadStarting" /> event. Setting the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs.Handled" /> property disables the default download dialog and ensures that this event is never raised.
	/// </remarks>
	public event EventHandler<object> IsDefaultDownloadDialogOpenChanged
	{
		add
		{
			if (privateIsDefaultDownloadDialogOpenChanged == null)
			{
				try
				{
					_nativeICoreWebView2_9.add_IsDefaultDownloadDialogOpenChanged(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(OnIsDefaultDownloadDialogOpenChanged), out _IsDefaultDownloadDialogOpenChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateIsDefaultDownloadDialogOpenChanged = (EventHandler<object>)Delegate.Combine(privateIsDefaultDownloadDialogOpenChanged, value);
		}
		remove
		{
			privateIsDefaultDownloadDialogOpenChanged = (EventHandler<object>)Delegate.Remove(privateIsDefaultDownloadDialogOpenChanged, value);
			if (privateIsDefaultDownloadDialogOpenChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_9.remove_IsDefaultDownloadDialogOpenChanged(_IsDefaultDownloadDialogOpenChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2(object rawCoreWebView2)
	{
		_rawNative = rawCoreWebView2;
	}

	internal void OnContainsFullScreenElementChanged(object args)
	{
		privateContainsFullScreenElementChanged?.Invoke(this, args);
	}

	internal void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
	{
		privateContentLoading?.Invoke(this, args);
	}

	internal void OnDocumentTitleChanged(object args)
	{
		privateDocumentTitleChanged?.Invoke(this, args);
	}

	internal void OnFrameNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
	{
		privateFrameNavigationCompleted?.Invoke(this, args);
	}

	internal void OnFrameNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
	{
		privateFrameNavigationStarting?.Invoke(this, args);
	}

	internal void OnHistoryChanged(object args)
	{
		privateHistoryChanged?.Invoke(this, args);
	}

	internal void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
	{
		privateNavigationCompleted?.Invoke(this, args);
	}

	internal void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
	{
		privateNavigationStarting?.Invoke(this, args);
	}

	internal void OnNewWindowRequested(CoreWebView2NewWindowRequestedEventArgs args)
	{
		privateNewWindowRequested?.Invoke(this, args);
	}

	internal void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
	{
		privatePermissionRequested?.Invoke(this, args);
	}

	internal void OnProcessFailed(CoreWebView2ProcessFailedEventArgs args)
	{
		privateProcessFailed?.Invoke(this, args);
	}

	internal void OnScriptDialogOpening(CoreWebView2ScriptDialogOpeningEventArgs args)
	{
		privateScriptDialogOpening?.Invoke(this, args);
	}

	internal void OnSourceChanged(CoreWebView2SourceChangedEventArgs args)
	{
		privateSourceChanged?.Invoke(this, args);
	}

	internal void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
	{
		privateWebMessageReceived?.Invoke(this, args);
	}

	internal void OnWebResourceRequested(CoreWebView2WebResourceRequestedEventArgs args)
	{
		privateWebResourceRequested?.Invoke(this, args);
	}

	internal void OnWindowCloseRequested(object args)
	{
		privateWindowCloseRequested?.Invoke(this, args);
	}

	/// <summary>
	/// Causes a navigation of the top level document to the specified URI.
	/// </summary><param name="uri">The URI to navigate to.</param><remarks>
	/// For more information, navigate to [Navigation event](/microsoft-edge/webview2/concepts/navigation-events). Note that this operation starts a navigation and the corresponding <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event is raised sometime after Navigate runs.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" />
	public void Navigate(string uri)
	{
		try
		{
			_nativeICoreWebView2.Navigate(uri);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Initiates a navigation to <c>htmlContent</c> as source HTML of a new document.
	/// </summary><param name="htmlContent">A source HTML of a new document.</param><remarks>
	/// The <c>htmlContent</c> parameter may not be larger than 2 MB (2 * 1024 * 1024 bytes) in total size. The origin of the new page is <c>about:blank</c>.
	/// </remarks><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.SetVirtualHostNameToFolderMapping(System.String,System.String,Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind)" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted" /><example><code>
	/// webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
	///     "appassets.example", "assets", CoreWebView2HostResourceAccessKind.DenyCors);
	/// string htmlContent =
	/// @"
	///     <head><link rel="stylesheet" href="http://appassets.example/run.css" /></head><body><img src="http://appassets.example/grill.png" /><p><a href="http://appassets.example/winrt_test.txt"> Click me</a></p></body>
	/// ";
	/// webview.NavigateToString(htmlContent);
	/// </code></example>
	public void NavigateToString(string htmlContent)
	{
		try
		{
			_nativeICoreWebView2.NavigateToString(htmlContent);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Adds the provided JavaScript to a list of scripts that should be run after the global object has been created, but before the HTML document has been parsed and before any other script included by the HTML document is run.
	/// </summary><param name="javaScript">The JavaScript code to be run.</param><returns>A script ID that may be passed when calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(System.String)" />.</returns><remarks>
	/// The injected script will apply to all future top level document and child frame navigations until removed with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(System.String)" />.
	/// This is applied asynchronously and you must wait for the returned IAsyncOperation to complete before you can be sure that the script is ready to execute on future navigations.
	/// If the method is run in <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> handler, it should be called before the new window is set. For more details see <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow" />.
	///
	/// Note that if an HTML document has sandboxing of some kind via [sandbox](https://developer.mozilla.org/docs/Web/HTML/Element/iframe#attr-sandbox) properties or the [Content-Security-Policy HTTP header](https://developer.mozilla.org/docs/Web/HTTP/Headers/Content-Security-Policy) this will affect the script run here. So, for example, if the <c>allow-modals</c> keyword is not set then calls to the <c>alert</c> function will be ignored.
	/// </remarks><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(System.String)" />
	public async Task<string> AddScriptToExecuteOnDocumentCreatedAsync(string javaScript)
	{
		CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler;
		try
		{
			handler = new CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler();
			_nativeICoreWebView2.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Removes the corresponding JavaScript added via <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String)" /> with the specified script ID.
	/// </summary><param name="id">The ID corresponds to the JavaScript code to be removed from the list of scripts.</param>
	/// Both use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String)" /> and this method in <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> handler at the same time sometimes causes trouble. Since invalid scripts will be ignored, the script IDs you got may not be valid anymore.
	public void RemoveScriptToExecuteOnDocumentCreated(string id)
	{
		try
		{
			_nativeICoreWebView2.RemoveScriptToExecuteOnDocumentCreated(id);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Runs JavaScript code from the <c>javaScript</c> parameter in the current top-level document rendered in the WebView.
	/// </summary><param name="javaScript">The JavaScript code to be run in the current top-level document rendered in the WebView.</param><returns>A JSON encoded string that represents the result of running the provided JavaScript.</returns><remarks>
	/// If the result is <c>undefined</c>, contains a reference cycle, or otherwise is not able to be encoded into JSON, the JSON <c>null</c> value is returned as the <c>"null"</c> string.
	///
	/// A function that has no explicit return value returns <c>undefined</c>. If the script that was run throws an unhandled exception, then the result is also <c>null</c>. This method is applied asynchronously. If the method is run after the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event during a navigation, the script runs in the new document when loading it, around the time <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> is run. This operation works even if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsScriptEnabled" /> is set to <c>false</c>.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsScriptEnabled" />
	public async Task<string> ExecuteScriptAsync(string javaScript)
	{
		CoreWebView2ExecuteScriptCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ExecuteScriptCompletedHandler();
			_nativeICoreWebView2.ExecuteScript(javaScript, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Captures an image of what WebView is displaying.
	/// </summary><param name="imageFormat">The format of the image to be captured.</param><param name="imageStream">The stream to which the resulting image binary data is written.</param><remarks>
	/// When CapturePreviewAsync finishes writing to the stream, the Invoke method on the provided handler parameter is called. This method fails if called before the first <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> event. For example if this is called in the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting" /> event for the first navigation it will fail. For subsequent navigations, the method may not fail, but will not capture an image of a given webpage until the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> event has been fired for it. Any call to this method prior to that will result in a capture of the page being navigated away from.
	/// </remarks><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat" />
	public async Task CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat imageFormat, Stream imageStream)
	{
		CoreWebView2CapturePreviewCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CapturePreviewCompletedHandler();
			_nativeICoreWebView2.CapturePreview((COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT)imageFormat, (imageStream == null) ? null : new ManagedIStream(imageStream), handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	/// <summary>
	/// Reloads the current page.
	/// </summary><remarks>
	/// This is similar to navigating to the URI of current top level document including all navigation events firing and respecting any entries in the HTTP cache. But, the back or forward history will not be modified.
	/// </remarks>
	public void Reload()
	{
		try
		{
			_nativeICoreWebView2.Reload();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Posts the specified <c>webMessageAsJson</c> to the top level document in this WebView.
	/// </summary><param name="webMessageAsJson">The web message to be posted to the top level document in this WebView.</param><remarks>
	/// The event args is an instance of <c>MessageEvent</c>. The <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /> setting must be <c>true</c> or the message will not be sent. The event arg's <c>data</c> property of the event arg is the <c>webMessageAsJson</c> string parameter parsed as a JSON string into a JavaScript object. The event arg's <c>source</c> property of the event arg is a reference to the <c>window.chrome.webview</c> object. For information about sending messages from the HTML document in the WebView to the host, navigate to <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" />. The message is sent asynchronously. If a navigation occurs before the message is posted to the page, the message is not be sent.
	/// </remarks><example>
	/// Runs the message event of the <c>window.chrome.webview</c> of the top-level document. JavaScript in that document may subscribe and unsubscribe to the event using the following code:
	/// <code>
	/// window.chrome.webview.addEventListener('message', handler)
	/// window.chrome.webview.removeEventListener('message', handler)
	/// </code></example><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" /><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsString(System.String)" />
	public void PostWebMessageAsJson(string webMessageAsJson)
	{
		try
		{
			_nativeICoreWebView2.PostWebMessageAsJson(webMessageAsJson);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Posts a message that is a simple string rather than a JSON string representation of a JavaScript object.
	/// </summary><param name="webMessageAsString">The web message to be posted to the top level document in this WebView.</param><remarks>
	/// This behaves in exactly the same manner as <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" />, but the <c>data</c> property of the event arg of the <c>window.chrome.webview</c> message is a string with the same value as <c>webMessageAsString</c>. Use this instead of <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" /> if you want to communicate using simple strings rather than JSON objects.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" /><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" />
	public void PostWebMessageAsString(string webMessageAsString)
	{
		try
		{
			_nativeICoreWebView2.PostWebMessageAsString(webMessageAsString);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Runs an asynchronous DevToolsProtocol method.
	/// </summary><param name="methodName">The full name of the method in the format <c>{domain}.{method}</c>.</param><param name="parametersAsJson">A JSON formatted string containing the parameters for the corresponding method.</param><returns>A JSON string that represents the method's return object.</returns><remarks>
	/// For more information about available methods, navigate to [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs). The returned task is completed when the method asynchronously completes and will return the method's return object as a JSON string. Note even though WebView2 dispatches the CDP messages in the order called, CDP method calls may be processed out of order. If you require CDP methods to run in a particular order, you should await for the previous method call.
	/// </remarks>
	public async Task<string> CallDevToolsProtocolMethodAsync(string methodName, string parametersAsJson)
	{
		CoreWebView2CallDevToolsProtocolMethodCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
			_nativeICoreWebView2.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Navigates the WebView to the previous page in the navigation history.</summary>
	public void GoBack()
	{
		try
		{
			_nativeICoreWebView2.GoBack();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Navigates the WebView to the next page in the navigation history.</summary>
	public void GoForward()
	{
		try
		{
			_nativeICoreWebView2.GoForward();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Gets a DevTools Protocol event receiver that allows you to subscribe to a DevToolsProtocol event.
	/// </summary><param name="eventName">The full name of the event in the format <c>{domain}.{event}</c>.</param><returns>A Devtools Protocol event receiver.</returns><remarks>
	/// For more information about DevToolsProtocol events description and event args, navigate to [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs).
	/// </remarks>
	public CoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(string eventName)
	{
		try
		{
			return new CoreWebView2DevToolsProtocolEventReceiver(_nativeICoreWebView2.GetDevToolsProtocolEventReceiver(eventName));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Stops all navigations and pending resource fetches.
	/// </summary><remarks>
	/// Does not stop scripts.
	/// </remarks>
	public void Stop()
	{
		try
		{
			_nativeICoreWebView2.Stop();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Adds the provided host object to script running in the WebView with the specified name.
	/// </summary><param name="name">The name of the host object.</param><param name="rawObject">The host object to be added to script.</param><remarks>
	/// Host objects are exposed as host object proxies via <c>window.chrome.webview.hostObjects.{name}</c>. Host object proxies are promises and will resolve to an object representing the host object. Only the COM visible objects/properties/methods can be accessed from script.
	///
	/// The app can control which part of .NET objects are exposed using <see cref="T:System.Runtime.InteropServices.ComVisibleAttribute" />.
	///
	/// JavaScript code in the WebView will be able to access appObject as following and then access attributes and methods of appObject.
	///
	/// Note that while simple types, <c>IDispatch</c> and array are supported, and <c>IUnknown</c> objects that also implement <c>IDispatch</c> are treated as <c>IDispatch</c>, generic <c>IUnknown</c>, <c>VT_DECIMAL</c>, or <c>VT_RECORD</c> variant is not supported. Remote JavaScript objects like callback functions are represented as an <c>VT_DISPATCH</c> VARIANT with the object implementing <c>IDispatch</c>. The JavaScript callback method may be invoked using DISPID_VALUE for the DISPID. Such callback method invocations will return immediately and will not wait for the JavaScript function to run and so will not provide the return value of the JavaScript function. Nested arrays are supported up to a depth of 3. Arrays of by reference types are not supported. <c>VT_EMPTY</c> and <c>VT_NULL</c> are mapped into JavaScript as <c>null</c>. In JavaScript <c>null</c> and <c>undefined</c> are mapped to <c>VT_EMPTY</c>.
	///
	/// Additionally, all host objects are exposed as <c>window.chrome.webview.hostObjects.sync.{name}</c>. Here the host objects are exposed as synchronous host object proxies. These are not promises and calls to functions or property access synchronously block running script waiting to communicate cross process for the host code to run. Accordingly this can result in reliability issues and it is recommended that you use the promise based asynchronous <c>window.chrome.webview.hostObjects.{name}</c> API described above.
	///
	/// Synchronous host object proxies and asynchronous host object proxies can both proxy the same host object. Remote changes made by one proxy will be reflected in any other proxy of that same host object whether the other proxies and synchronous or asynchronous.
	///
	/// While JavaScript is blocked on a synchronous call to native code, that native code is unable to call back to JavaScript. Attempts to do so will fail with <c>HRESULT_FROM_WIN32(ERROR_POSSIBLE_DEADLOCK)</c>.
	///
	/// Host object proxies are JavaScript Proxy objects that intercept all property get, property set, and method invocations. Properties or methods that are a part of the Function or Object prototype are run locally. Additionally any property or method in the array <c>chrome.webview.hostObjects.options.forceLocalProperties</c> will also be run locally. This defaults to including optional methods that have meaning in JavaScript like <c>toJSON</c> and <c>Symbol.toPrimitive</c>. You can add more to this array as required.
	///
	/// There's a method <c>chrome.webview.hostObjects.cleanupSome</c> that will best effort garbage collect host object proxies.
	///
	/// The <c>chrome.webview.hostObjects.options</c> object provides the ability to change some functionality of host objects.
	///
	/// <list type="table"><listheader><term>Options property</term><description>Details</description></listheader><item><term><c>forceLocalProperties</c></term><description>
	/// This is an array of host object property names that will be run locally, instead of being called on the native host object. This defaults to <c>then</c>, <c>toJSON</c>, <c>Symbol.toString</c>, and <c>Symbol.toPrimitive</c>. You can add other properties to specify that they should be run locally on the JavaScript host object proxy.
	/// </description></item><item><term><c>log</c></term><description>
	/// This is a callback that will be called with debug information. For example, you can set this to <c>console.log.bind(console)</c> to have it print debug information to the console to help when troubleshooting host object usage. By default this is null.
	/// </description></item><item><term><c>shouldSerializeDates</c></term><description>
	/// By default this is false, and JavaScript Date objects will be sent to host objects as a string using <c>JSON.stringify</c>. You can set this property to true to have Date objects properly serialize as a <c>System.DateTime</c> when sending to the .NET host object, and have <c>System.DateTime</c> properties and return values create a JavaScript <c>Date</c> object.
	/// </description></item><item><term><c>defaultSyncProxy</c></term><description>
	/// When calling a method on a synchronous proxy, the result should also be a synchronous proxy. But in some cases, the sync/async context is lost (for example, when providing to native code a reference to a function, and then calling that function in native code). In these cases, the proxy will be asynchronous, unless this property is set.
	/// </description></item><item><term><c>forceAsyncMethodMatches</c></term><description>
	/// This is an array of regular expressions. When calling a method on a synchronous proxy, the method call will be performed asynchronously if the method name matches a string or regular expression in this array. Setting this value to <c>Async</c> will make any method that ends with Async be an asynchronous method call. If an async method doesn't match here and isn't forced to be asynchronous, the method will be invoked synchronously, blocking execution of the calling JavaScript and then returning the resolution of the promise, rather than returning a promise.
	/// </description></item><item><term><c>ignoreMemberNotFoundError</c></term><description>
	/// By default, an exception is thrown when attempting to get the value of a proxy property that doesn't exist on the corresponding native class. Setting this property to <c>true</c> switches the behavior to match Chakra WinRT projection (and general JavaScript) behavior of returning <c>undefined</c> with no error.
	/// </description></item><item><term><c>shouldPassTypedArraysAsArrays</c></term><description>
	/// By default, typed arrays are passed to the host as <c>IDispatch</c>. To instead pass typed arrays to the host as <c>array</c>, set this to <c>true</c>.
	/// </description></item></list>
	///
	/// Host object proxies additionally have the following methods:
	///
	/// <list type="table"><listheader><term>Method name</term><description>Details</description></listheader><item><term><c>applyHostFunction</c>, <c>getHostProperty</c>, <c>setHostProperty</c></term><description>
	/// Perform a method invocation, property get, or property set on the host object. You can use these to explicitly force a method or property to run remotely if there is a conflicting local method or property. For instance, <c>proxy.toString()</c> will run the local <c>toString</c> method on the proxy object. But <c>proxy.applyHostFunction('toString')</c> runs <c>toString</c> on the host proxied object instead.
	/// </description></item><item><term><c>getLocalProperty</c>, <c>setLocalProperty</c></term><description>
	/// Perform property get, or property set locally. You can use these methods to force getting or setting a property on the host object proxy itself rather than on the host object it represents. For instance, <c>proxy.unknownProperty</c> will get the property named <c>unknownProperty</c> from the host proxied object. But <c>proxy.getLocalProperty('unknownProperty')</c> will get the value of the property <c>unknownProperty</c> on the proxy object itself.
	/// </description></item><item><term><c>addEventListener</c></term><description>
	/// This method only exists on proxies for .NET objects. Bind the JavaScript handler to the C# event, so that the JavaScript handler can be called through the C# event. For example, <c>chrome.webview.hostObjects.sample.addEventListener('TestEvent', () =&gt; { alert('Invoked from remote');});</c> bind an anonymous JavaScript function to a C# event called 'TestEvent'. When calling <c>TestEvent?.Invoke()</c> on C# side, the JavaScript function that was just bound will be called asynchronously. It allows adding more than one handler for an event, but if the handler is already in the list of event handler, it will not be added a second time. If the host object cannot find the event with the name passed in by the <c>addEventListener</c> function or it is no public or its return type is not void, an exception will be thrown. If the count and type of C# event's parameters do not match the count and type of JavaScript handler, invoke <c>addEventListener</c> will be successful but an exception will be passed to JavaScript when invoke the event on C# side. If the host object has defined <c>addEventListener</c> function, use the defined function rather than the additionally <c>addEventListener</c> function.
	/// </description></item><item><term><c>removeEventListener</c></term><description>
	/// This method only exists on proxies for .NET objects. Removes a handler previously bound with <c>addEventListener()</c>. If the handler does not exist in the list of event handler, nothing will happen. If the host object cannot find the event with the name passed in by the <c>removeEventListener</c> function or it is no public, an exception will be thrown. If the host object has defined <c>removeEventListener</c> function, use the defined function rather than the additionally <c>removeEventListener</c> function.
	/// </description></item><item><term><c>sync</c></term><description>
	/// Asynchronous host object proxies expose a sync method which returns a promise for a synchronous host object proxy for the same host object. For example, <c>chrome.webview.hostObjects.sample.methodCall()</c> returns an asynchronous host object proxy. You can use the <c>sync</c> method to obtain a synchronous host object proxy instead:
	/// <c>const syncProxy = await chrome.webview.hostObjects.sample.methodCall().sync()</c></description></item><item><term><c>async</c></term><description>
	/// Synchronous host object proxies expose an async method which blocks and returns an asynchronous host object proxy for the same host object. For example, <c>chrome.webview.hostObjects.sync.sample.methodCall()</c> returns a synchronous host object proxy. Calling the <c>async</c> method on this blocks and then returns an asynchronous host object proxy for the same host object: <c>const asyncProxy = chrome.webview.hostObjects.sync.sample.methodCall().async()</c></description></item><item><term><c>then</c></term><description>
	/// Asynchronous host object proxies have a then method. This allows them to be awaitable. <c>then</c> will return a promise that resolves with a representation of the host object. If the proxy represents a JavaScript literal then a copy of that is returned locally. If the proxy represents a function then a non-awaitable proxy is returned. If the proxy represents a JavaScript object with a mix of literal properties and function properties, then the a copy of the object is returned with some properties as host object proxies.
	/// </description></item><item><term><c>cancelPromise</c></term><description>
	/// This method attempts to cancel the fulfillment of a promised value. If the promise hasn't already been fulfilled and cancellation is supported, the promise will get rejected. <c>cancelPromise</c> supports cancellation of IAsyncOperation and IAsyncAction methods. If the promise is successfully canceled, then calling await on the promise will throw. For example, <c>chrome.webview.hostObjects.cancelPromise(promise); await promise;</c> will throw with "Promise Canceled". Once a promise has been canceled, a subsequent cancel on the same promise will throw an exception as well.
	/// </description></item></list>
	///
	/// All other property and method invocations (other than the above Remote object proxy methods, <c>forceLocalProperties</c> list, and properties on Function and Object prototypes) are run remotely. Asynchronous host object proxies return a promise representing asynchronous completion of remotely invoking the method, or getting the property. The promise resolves after the remote operations complete and the promises resolve to the resulting value of the operation. Synchronous host object proxies work similarly but block JavaScript execution and wait for the remote operation to complete.
	///
	/// Setting a property on an asynchronous host object proxy works slightly differently. The set returns immediately and the return value is the value that will be set. This is a requirement of the JavaScript Proxy object. If you need to asynchronously wait for the property set to complete, use the <c>setHostProperty</c> method which returns a promise as described above. Synchronous object property set property synchronously blocks until the property is set.
	///
	/// Exposing host objects to script has security risk. Please follow [best practices](/microsoft-edge/webview2/concepts/security).
	/// </remarks><example>
	/// To create a [IDispatch](/windows/win32/api/oaidl/nn-oaidl-idispatch) implementing class in C# use the following attributes on each class you intend to expose.
	/// <code>
	/// // Bridge and BridgeAnotherClass are C# classes that implement IDispatch and works with AddHostObjectToScript.
	/// [ClassInterface(ClassInterfaceType.AutoDual)]
	/// [ComVisible(true)]
	/// public class BridgeAnotherClass
	/// {
	///     // Sample property.
	///     public string Prop { get; set; } = "Example";
	/// }
	///
	/// [ClassInterface(ClassInterfaceType.AutoDual)]
	/// [ComVisible(true)]
	/// public class Bridge
	/// {
	///     public string Func(string param)
	///     {
	///         return "Example: " + param;
	///     }
	///
	///     public BridgeAnotherClass AnotherObject { get; set; } = new BridgeAnotherClass();
	///
	///     // Sample indexed property.
	///     [System.Runtime.CompilerServices.IndexerName("Items")]
	///     public string this[int index]
	///     {
	///         get { return m_dictionary[index]; }
	///         set { m_dictionary[index] = value; }
	///     }
	///     private Dictionary&lt;int, string&gt; m_dictionary = new Dictionary&lt;int, string&gt;();
	/// }
	/// </code>
	/// Then add instances of those classes via <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddHostObjectToScript(System.String,System.Object)" />:
	/// <code>
	/// webView.CoreWebView2.AddHostObjectToScript("bridge", new Bridge());
	/// </code>
	/// And then in script you can call the methods, and access those properties of the objects added via <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddHostObjectToScript(System.String,System.Object)" />.
	/// Note that `CoreWebView2.AddHostObjectToScript` only applies to the top-level document and not to frames. To add host objects to frames use `CoreWebView2Frame.AddHostObjectToScript`.
	/// <code>
	/// // Find added objects on the hostObjects property
	/// const bridge = chrome.webview.hostObjects.bridge;
	///
	/// // Call a method and pass in a parameter.
	/// // The result is another proxy promise so you must await to get the result.
	/// console.log(await bridge.Func("testing..."));
	///
	/// // A property may be another object as long as its class also implements
	/// // IDispatch.
	/// // Getting a property also gets a proxy promise you must await.
	/// const propValue = await bridge.AnotherObject.Prop;
	/// console.log(propValue);
	///
	/// // Indexed properties
	/// let index = 123;
	/// bridge[index] = "test";
	/// let result = await bridge[index];
	/// console.log(result);
	/// </code></example><seealso cref="T:System.Runtime.InteropServices.ComVisibleAttribute" />
	public void AddHostObjectToScript(string name, object rawObject)
	{
		try
		{
			ICoreWebView2 nativeICoreWebView = _nativeICoreWebView2;
			object @object = rawObject;
			nativeICoreWebView.AddHostObjectToScript(name, ref @object);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Removes the host object specified by the name so that it is no longer accessible from JavaScript code in the WebView.
	/// </summary><param name="name">The name of the host object to be removed.</param><remarks>
	/// While new access attempts are denied, if the object is already obtained by JavaScript code in the WebView, the JavaScript code continues to have access to that object. Running this method for a name that is already removed or never added fails.
	/// </remarks>
	public void RemoveHostObjectFromScript(string name)
	{
		try
		{
			_nativeICoreWebView2.RemoveHostObjectFromScript(name);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Opens the DevTools window for the current document in the WebView.
	/// </summary><remarks>
	/// Does nothing if run when the DevTools window is already open.
	/// </remarks>
	public void OpenDevToolsWindow()
	{
		try
		{
			_nativeICoreWebView2.OpenDevToolsWindow();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Warning: This method is deprecated and does not behave as expected for
	/// iframes. Please use
	/// <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds)" />
	/// instead.</summary>
	public void AddWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext)
	{
		try
		{
			_nativeICoreWebView2.AddWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Warning: This method and `CoreWebView2.AddWebResourceRequestedFilter(string, CoreWebView2WebResourceContext)` are deprecated.
	/// Please use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds)" /> and
	/// <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds)" /> instead.</summary>
	public void RemoveWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext)
	{
		try
		{
			_nativeICoreWebView2.RemoveWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void AddHostObjectHelper(CoreWebView2PrivateHostObjectHelper hostObjectHelper)
	{
		try
		{
			_nativeICoreWebView2PrivatePartial.AddHostObjectHelper(hostObjectHelper._nativeICoreWebView2PrivateHostObjectHelper);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnBasicAuthenticationRequested(CoreWebView2BasicAuthenticationRequestedEventArgs args)
	{
		privateBasicAuthenticationRequested?.Invoke(this, args);
	}

	internal void OnContextMenuRequested(CoreWebView2ContextMenuRequestedEventArgs args)
	{
		privateContextMenuRequested?.Invoke(this, args);
	}

	/// <summary>
	/// Runs an asynchronous <c>DevToolsProtocol</c> method for a specific session of an attached target.
	/// </summary><param name="sessionId">The sessionId for an attached target. null or empty string is treated as the session for the default target for the top page.</param><param name="methodName">The full name of the method in the format <c>{domain}.{method}</c>.</param><param name="parametersAsJson">A JSON formatted string containing the parameters for the corresponding method.</param><returns>A JSON string that represents the method's return object.</returns><remarks>
	/// There could be multiple <c>DevToolsProtocol</c> targets in a WebView.
	/// Besides the top level page, iframes from different origin and web workers are also separate targets.
	/// Attaching to these targets allows interaction with them.
	/// When the DevToolsProtocol is attached to a target, the connection is identified by a sessionId.
	///
	/// To use this API, you must set the <c>flatten</c> parameter to true when calling <c>Target.attachToTarget</c> or <c>Target.setAutoAttach</c><c>DevToolsProtocol</c> method.
	/// Using <c>Target.setAutoAttach</c> is recommended as that would allow you to attach to dedicated worker targets, which are not discoverable via other APIs like <c>Target.getTargets</c>.
	/// For more information about targets and sessions, navigate to [Chrome DevTools Protocol - Target domain]( https://chromedevtools.github.io/devtools-protocol/tot/Target).
	///
	/// For more information about available methods, navigate to [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs). The handler's Invoke method will be called when the method asynchronously completes. Invoke will be called with the method's return object as a JSON string.
	/// </remarks>
	public async Task<string> CallDevToolsProtocolMethodForSessionAsync(string sessionId, string methodName, string parametersAsJson)
	{
		CoreWebView2CallDevToolsProtocolMethodCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
			_nativeICoreWebView2_11.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	internal void OnStatusBarTextChanged(object args)
	{
		privateStatusBarTextChanged?.Invoke(this, args);
	}

	internal void OnServerCertificateErrorDetected(CoreWebView2ServerCertificateErrorDetectedEventArgs args)
	{
		privateServerCertificateErrorDetected?.Invoke(this, args);
	}

	/// <summary>
	/// Clears all cached decisions to proceed with TLS certificate errors from the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ServerCertificateErrorDetected" /> event for all WebView2's sharing the same session.</summary>
	public async Task ClearServerCertificateErrorActionsAsync()
	{
		CoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ClearServerCertificateErrorActionsCompletedHandler();
			_nativeICoreWebView2_14.ClearServerCertificateErrorActions(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	internal void OnFaviconChanged(object args)
	{
		privateFaviconChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Get the downloaded Favicon image for the current page and copy it to the image stream.
	/// </summary><param name="format">The format to retrieve the Favicon in.</param><returns>
	/// An <c>IStream</c> populated with the downloaded Favicon.
	/// </returns>
	public async Task<Stream> GetFaviconAsync(CoreWebView2FaviconImageFormat format)
	{
		CoreWebView2GetFaviconCompletedHandler handler;
		try
		{
			handler = new CoreWebView2GetFaviconCompletedHandler();
			_nativeICoreWebView2_15.GetFavicon((COREWEBVIEW2_FAVICON_IMAGE_FORMAT)format, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Print the current web page asynchronously to the specified printer with the provided settings.</summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings" /> for description of settings. Passing null for <c>printSettings</c> results in default print settings used.
	/// The method will return <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus" /> as <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.PrinterUnavailable" /> if <c>printerName</c> doesn't match with the name of any installed printers on the user OS.
	/// The method will throw ArgumentException if the caller provides invalid settings for a given printer.
	/// The async Print operation completes when it finishes printing to the printer. Only one <c>Printing</c> operation can be in progress at a time. If <c>Print</c> is called while a <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> job is in progress, <see cref="T:System.Threading.Tasks.Task`1" /> throws exception. This is only for printing operation on one webview.
	/// <list type="table"><listheader><description>Error</description><description>PrintStatus</description><description>Notes</description></listheader><item><description>No</description><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.Succeeded" /></description><description>Print operation succeeded.</description></item><item><description>No</description><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.PrinterUnavailable" /></description><description>If specified printer is not found or printer status is not available, offline or error state.</description></item><item><description>No</description><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.OtherError" /></description><description>Print operation is failed. </description></item><item><description>ArgumentException</description><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.OtherError" /></description><description>If the caller provides invalid settings for the specified printer.</description></item><item><description>Exception</description><description><see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.OtherError" /></description><description>Print operation is failed as printing job already in progress.</description></item></list></remarks><example>
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="PrintToPrinter":::
	/// </example>
	public async Task<CoreWebView2PrintStatus> PrintAsync(CoreWebView2PrintSettings printSettings)
	{
		CoreWebView2PrintCompletedHandler handler;
		try
		{
			handler = new CoreWebView2PrintCompletedHandler();
			_nativeICoreWebView2_16.Print(printSettings?._nativeICoreWebView2PrintSettings, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Opens the print dialog to print the current web page.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintDialogKind" /> for descriptions of print dialog kinds.
	///
	/// Invoking browser or system print dialog doesn't open new print dialog if it is already open.
	/// </remarks>
	public void ShowPrintUI(CoreWebView2PrintDialogKind printDialogKind)
	{
		try
		{
			_nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Provides the Pdf data of current web page asynchronously for the provided settings.
	/// </summary><remarks>
	/// Stream will be rewound to the start of the pdf data.
	///
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings" /> for description of settings. Passing null for <c>printSettings</c> results in default print settings used.
	///
	/// The async PrintToPdfStream operation completes when it finishes writing to the stream. Only one <c>Printing</c> operation can be in progress at a time. If <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> is called while a <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> job is in progress, the <see cref="T:System.Threading.Tasks.Task`1" /> throws an exception. This is only for printing operation on one webview.
	/// </remarks>
	public async Task<Stream> PrintToPdfStreamAsync(CoreWebView2PrintSettings printSettings)
	{
		CoreWebView2PrintToPdfStreamCompletedHandler handler;
		try
		{
			handler = new CoreWebView2PrintToPdfStreamCompletedHandler();
			_nativeICoreWebView2_16.PrintToPdfStream(printSettings?._nativeICoreWebView2PrintSettings, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Share a shared buffer object with script of the main frame in the WebView.
	/// </summary><param name="sharedBuffer">The <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer" /> object to be shared with script.</param><param name="access">The desired <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess" /> given to script.</param><param name="additionalDataAsJson">Additional data to be send to script. If it is not null or empty string, and it is not a valid JSON string, <see cref="T:System.ArgumentException" /> will be thrown.</param><remarks>
	/// The script will receive a <c>sharedbufferreceived</c> event from chrome.webview.
	/// The event arg for that event will have the following methods and properties.
	///
	/// <list type="table"><listheader><description>Property</description><description>Description</description></listheader><item><description><c>getBuffer()</c></description><description>A method that returns an ArrayBuffer object with the backing content from the shared buffer.</description></item><item><description><c>additionalData</c></description><description>An object as the result of parsing <c>additionalDataAsJson</c> as JSON string. This property will be <c>undefined</c> if <c>additionalDataAsJson</c> is nullptr or empty string.</description></item><item><description><c>source</c></description><description>With a value set as <c>chrome.webview</c> object.</description></item></list>
	///
	/// If <c>access</c> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess.ReadOnly" />, the script will only have read access to the buffer.
	/// If the script tries to modify the content in a read only buffer, it will cause an access violation in WebView renderer process and crash the renderer process.
	///
	/// If the shared buffer is already closed, the API throws COMException with error code of <c>RO_E_CLOSED</c>.
	/// The script code should call <c>chrome.webview.releaseBuffer</c> with the shared buffer as the parameter to release underlying resources as soon as it does not need access to the shared buffer any more.
	///
	/// The application can post the same shared buffer object to multiple web pages or iframes, or post to the same web page or iframe multiple times.
	/// Each <c>PostSharedBufferToScript</c> will create a separate ArrayBuffer object with its own view of the memory and is separately released.
	/// The underlying shared memory will be released when all the views are released.
	///
	/// Sharing a buffer to script has security risk. You should only share buffer with trusted site.
	/// If a buffer is shared to a untrusted site, possible sensitive information could be leaked.
	/// If a buffer is shared as modifiable by the script and the script modifies it in an unexpected way, it could result in corrupted data that might even crash the application.
	///
	/// The example code shows how to send data to script for one time read only consumption.
	/// </remarks><example>
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="OneTimeShareBuffer":::
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/assets/sharedBuffer.html" id="ShareBufferScriptCode_1":::
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/assets/sharedBuffer.html" id="ShareBufferScriptCode_2":::
	/// </example>
	public void PostSharedBufferToScript(CoreWebView2SharedBuffer sharedBuffer, CoreWebView2SharedBufferAccess access, string additionalDataAsJson)
	{
		try
		{
			_nativeICoreWebView2_17.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnLaunchingExternalUriScheme(CoreWebView2LaunchingExternalUriSchemeEventArgs args)
	{
		privateLaunchingExternalUriScheme?.Invoke(this, args);
	}

	internal void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
	{
		privateDOMContentLoaded?.Invoke(this, args);
	}

	internal void OnWebResourceResponseReceived(CoreWebView2WebResourceResponseReceivedEventArgs args)
	{
		privateWebResourceResponseReceived?.Invoke(this, args);
	}

	/// <summary>
	/// Navigates using a constructed <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest" /> object.
	/// </summary><param name="Request">The constructed web resource object to provide post data or additional request headers during navigation.</param><remarks>
	/// The headers in the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest" /> override headers added by WebView2 runtime except for Cookie headers. Method can only be either <c>GET</c> or <c>POST</c>. Provided post data will only be sent only if the method is <c>POST</c> and the uri scheme is <c>HTTP(S)</c>.
	/// </remarks>
	public void NavigateWithWebResourceRequest(CoreWebView2WebResourceRequest Request)
	{
		try
		{
			_nativeICoreWebView2_2.NavigateWithWebResourceRequest(Request._nativeICoreWebView2WebResourceRequest);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Runs JavaScript code from the <c>javaScript</c> parameter in the current top-level document rendered in the WebView, The result of the execution is returned asynchronously in the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ExecuteScriptResult" /> object which has methods and properties to obtain the successful result of script execution as well as any unhandled JavaScript exceptions.</summary>
	public async Task<CoreWebView2ExecuteScriptResult> ExecuteScriptWithResultAsync(string javaScript)
	{
		CoreWebView2ExecuteScriptWithResultCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ExecuteScriptWithResultCompletedHandler();
			_nativeICoreWebView2_21.ExecuteScriptWithResult(javaScript, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary /><param name="uri">A URI to be added to the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event.</param><param name="ResourceContext">A resource context filter to be added to the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event.</param><param name="requestSourceKinds">A mask of one or more <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds" />s.</param>
	/// A web resource request with a resource context that matches this filter's resource context and a URI that matches this filter's URI wildcard string for corresponding request sources will be raised via the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event. To receive all raised events filters have to be added before main page navigation.<remarks>
	/// The <c>uri</c> parameter value is a wildcard string matched against the URI of the web resource request. This is a glob style wildcard string in which a <c>*</c> matches zero or more characters and a <c>?</c> matches exactly one character. These wildcard characters can be escaped using a backslash just before the wildcard character in order to represent the literal <c>*</c> or <c>?</c>. The matching occurs over the URI as a whole string and not limiting wildcard matches to particular parts of the URI. The wildcard filter is compared to the URI after the URI has been normalized, any URI fragment has been removed, and non-ASCII hostnames have been converted to punycode. Specifying a <c>null</c> for the uri is equivalent to an empty string which matches no URIs. For more information about resource context filters, navigate to <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext" />.
	/// <list type="table"><listheader><description>URI Filter String</description><description>Request URI</description><description>Match</description><description>Notes</description></listheader><item><description><c>*</c></description><description><c>https://contoso.com/a/b/c</c></description><description>Yes</description><description>A single * will match all URIs</description></item><item><description><c>*://contoso.com/*</c></description><description><c>https://contoso.com/a/b/c</c></description><description>Yes</description><description>Matches everything in contoso.com across all schemes</description></item><item><description><c>*://contoso.com/*</c></description><description><c>https://example.com/?https://contoso.com/</c></description><description>Yes</description><description>But also matches a URI with just the same text anywhere in the URI</description></item><item><description><c>example</c></description><description><c>https://contoso.com/example</c></description><description>No</description><description>The filter does not perform partial matches</description></item><item><description><c>*example</c></description><description><c>https://contoso.com/example</c></description><description>Yes</description><description>The filter matches across URI parts </description></item><item><description><c>*example</c></description><description><c>https://contoso.com/path/?example</c></description><description>Yes</description><description>The filter matches across URI parts</description></item><item><description><c>*example</c></description><description><c>https://contoso.com/path/?query#example</c></description><description>No</description><description>The filter is matched against the URI with no fragment</description></item><item><description><c>*example</c></description><description><c>https://example</c></description><description>No</description><description>The URI is normalized before filter matching so the actual URI used for comparison is <c>https://example.com/</c></description></item><item><description><c>*example/</c></description><description><c>https://example</c></description><description>Yes</description><description>Just like above, but this time the filter ends with a / just like the normalized URI</description></item><item><description><c>https://xn--qei.example/</c></description><description><c>https://❤.example/</c></description><description>Yes</description><description>Non-ASCII hostnames are normalized to punycode before wildcard comparison</description></item><item><description><c>https://❤.example/</c></description><description><c>https://xn--qei.example/</c></description><description>No</description><description>Non-ASCII hostnames are normalized to punycode before wildcard comparison</description></item></list>
	/// To form the <c>requestSourceKinds</c> parameter OR operation(s) can be applied to multiple <c>CoreWebView2WebResourceRequestSourceKind</c> to create a mask representing those source kinds. API will fail with <c>E_INVALIDARG</c> if <c>requestSourceKinds</c> equals to zero. Because service workers and shared workers run separately from any one HTML document their WebResourceRequested will be raised for all CoreWebView2s that have appropriate filters added in the corresponding CoreWebView2Environment. You should only add a WebResourceRequested filter for <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds.ServiceWorker" /> or <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds.SharedWorker" /> on one CoreWebView2 to avoid handling the same WebResourceRequested event multiple times.
	/// </remarks>
	public void AddWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext, CoreWebView2WebResourceRequestSourceKinds requestSourceKinds)
	{
		try
		{
			_nativeICoreWebView2_22.AddWebResourceRequestedFilterWithRequestSourceKinds(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext, (COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS)requestSourceKinds);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Removes a matching WebResource filter that was previously added for the
	/// `WebResourceRequested` event.  If the same filter was added multiple
	/// times, then it must be removed as many times as it was added for the
	/// removal to be effective. Returns `E_INVALIDARG` for a filter that was
	/// not added or is already removed.
	/// If the filter was added for multiple requestSourceKinds and removed just for one of them
	/// the filter remains for the non-removed requestSourceKinds.</summary>
	public void RemoveWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext, CoreWebView2WebResourceRequestSourceKinds requestSourceKinds)
	{
		try
		{
			_nativeICoreWebView2_22.RemoveWebResourceRequestedFilterWithRequestSourceKinds(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext, (COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS)requestSourceKinds);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnSaveAsUIShowing(CoreWebView2SaveAsUIShowingEventArgs args)
	{
		privateSaveAsUIShowing?.Invoke(this, args);
	}

	/// <summary>
	/// Async method to programmatically trigger a Save As action for the currently loaded document.
	/// </summary><remarks>
	/// It opens a system modal dialog by default. If the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2SaveAsUIShowingEventArgs.SuppressDefaultDialog" /> property is `TRUE`, the system dialog is not opened. This method can return <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2SaveAsUIResult" />.
	/// </remarks>
	public async Task<CoreWebView2SaveAsUIResult> ShowSaveAsUIAsync()
	{
		CoreWebView2ShowSaveAsUICompletedHandler handler;
		try
		{
			handler = new CoreWebView2ShowSaveAsUICompletedHandler();
			_nativeICoreWebView2_25.ShowSaveAsUI(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	internal void OnScreenCaptureStarting(CoreWebView2ScreenCaptureStartingEventArgs args)
	{
		privateScreenCaptureStarting?.Invoke(this, args);
	}

	internal void OnSaveFileSecurityCheckStarting(CoreWebView2SaveFileSecurityCheckStartingEventArgs args)
	{
		privateSaveFileSecurityCheckStarting?.Invoke(this, args);
	}

	internal void OnNotificationReceived(CoreWebView2NotificationReceivedEventArgs args)
	{
		privateNotificationReceived?.Invoke(this, args);
	}

	/// <summary>
	/// An app may call this API to have the WebView2 consume less memory.
	/// </summary><remarks>
	/// This is useful when a Win32 app becomes invisible, or when a Universal Windows Platform app is being suspended, during the suspended event handler before completing the suspended event.
	///
	/// The <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.IsVisible" /> property must be false when the API is called. Otherwise, the API throws COMException with error code of <c>HRESULT_FROM_WIN32(ERROR_INVALID_STATE)</c>.
	///
	/// Suspending is similar to putting a tab to sleep in the Edge browser. Suspending pauses WebView script timers and animations, minimizes CPU usage for the associated browser renderer process and allows the operating system to reuse the memory that was used by the renderer process for other processes.
	///
	/// Note that Suspend is best effort and considered completed successfully once the request is sent to browser renderer process. If there is a running script, the script will continue to run and the renderer process will be suspended after that script is done.
	///
	/// See [Sleeping Tabs FAQ](https://techcommunity.microsoft.com/t5/articles/sleeping-tabs-faq/m-p/1705434) for conditions that might prevent WebView from being suspended. In those situations, the result of the async task is false.
	///
	/// The WebView will be automatically resumed when it becomes visible. Therefore, the app normally does not have to call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> explicitly.
	///
	/// The app can call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" /> and then <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync" /> periodically for an invisible WebView so that the invisible WebView can sync up with latest data and the page ready to show fresh content when it becomes visible.
	///
	/// All WebView APIs can still be accessed when a WebView is suspended. Some APIs like Navigate will auto resume the WebView. To avoid unexpected auto resume, check <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.IsSuspended" /> property before calling APIs that might change WebView state.
	/// </remarks>
	public async Task<bool> TrySuspendAsync()
	{
		CoreWebView2TrySuspendCompletedHandler handler;
		try
		{
			handler = new CoreWebView2TrySuspendCompletedHandler();
			_nativeICoreWebView2_3.TrySuspend(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Resumes the WebView so that it resumes activities on the web page.
	/// </summary><remarks>
	/// This API can be called while the WebView2 controller is invisible.
	///
	/// The app can interact with the WebView immediately after <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Resume" />.
	///
	/// WebView will be automatically resumed when it becomes visible.
	/// </remarks>
	public void Resume()
	{
		try
		{
			_nativeICoreWebView2_3.Resume();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Sets a mapping between a virtual host name and a folder path to make available to web sites via that host name.
	/// </summary><param name="hostName">A virtual host name.</param><param name="folderPath">A folder path name to be mapped to the virtual host name. The length must not exceed the Windows MAX_PATH limit.</param><param name="accessKind">The level of access to resources under the virtual host from other sites.</param><remarks><para>
	/// After setting the mapping, documents loaded in the WebView can use HTTP or HTTPS URLs at the specified host name specified by <c>hostName</c> to access files in the local folder specified by <c>folderPath</c>.
	/// This mapping applies to both top-level document and iframe navigations as well as subresource references from a document. This also applies to dedicated and shared worker scripts but does not apply to service worker scripts.
	///
	/// Due to a current implementation limitation, media files accessed using virtual host name can be very slow to load.
	///
	/// As the resource loaders for the current page might have already been created and running, changes to the mapping might not be applied to the current page and a reload of the page is needed to apply the new mapping.
	///
	/// Both absolute and relative paths are supported for <c>folderPath</c>. Relative paths are interpreted as relative to the folder where the exe of the app is in.
	/// </para><para>
	/// For example, after calling <c>SetVirtualHostNameToFolderMapping("appassets.example", "assets", CoreWebView2HostResourceAccessKind.Deny);</c>, navigating to <c>https://appassets.example/my-local-file.html</c> will show content from my-local-file.html in the assets subfolder located on disk under the same path as the app's executable file.
	///
	/// DOM elements that want to reference local files will have their host reference virtual host in the source. If there are multiple folders being used, define one unique virtual host per folder.
	/// </para><para>
	/// You should typically choose virtual host names that are never used by real sites.
	/// If you own a domain such as <c>example.com</c>, another option is to use a subdomain reserved for the app (like <c>my-app.example.com</c>).
	/// </para><para>
	/// [RFC 6761](https://tools.ietf.org/html/rfc6761) has reserved several special-use domain names that are guaranteed to not be used by real sites (for example, <c>.example</c>, <c>.test</c>, and <c>.invalid</c>).
	/// </para><para>
	/// Note that using <c>.local</c> as the top-level domain name will work but can cause a delay during navigations. You should avoid using <c>.local</c> if you can.
	/// </para><para>
	/// Apps should use distinct domain names when mapping folder from different sources that should be isolated from each other. For instance, the app might use app-file.example for files that ship as part of the app, and book1.example might be used for files containing books from a less trusted source that were previously downloaded and saved to the disk by the app.
	/// </para><para>
	/// The host name used in the APIs is canonicalized using Chromium's host name parsing logic before being used internally.
	/// For more information see [HTML5 2.6 URLs](https://dev.w3.org/html5/spec-LC/urls.html).
	/// </para><para>
	/// All host names that are canonicalized to the same string are considered identical.
	/// For example, <c>EXAMPLE.COM</c> and <c>example.com</c> are treated as the same host name.
	/// An international host name and its Punycode-encoded host name are considered the same host name. There is no DNS resolution for host name and the trailing '.' is not normalized as part of canonicalization.
	/// </para><para>
	/// Therefore <c>example.com</c> and <c>example.com.</c> are treated as different host names. Similarly, <c>virtual-host-name</c> and <c>virtual-host-name.example.com</c> are treated as different host names even if the machine has a DNS suffix of <c>example.com</c>.
	/// </para><para>
	/// Specify the minimal cross-origin access necessary to run the app. If there is not a need to access local resources from other origins, use <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Deny" />.
	/// </para></remarks><example><code>
	/// webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
	///     "appassets.example", "assets", CoreWebView2HostResourceAccessKind.DenyCors);
	/// webView.Source = new Uri("https://appassets.example/index.html");
	/// </code>
	///
	/// This in an example on how to embed a local image. For more information see <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.NavigateToString(System.String)" />.
	/// <code>
	/// webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
	///     "appassets.example", "assets", CoreWebView2HostResourceAccessKind.DenyCors);
	/// string c_navString = "<img src="http://appassets.example/wv2.png" />";
	/// webview.NavigateToString(c_navString);
	/// </code></example><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.ClearVirtualHostNameToFolderMapping(System.String)" />
	public void SetVirtualHostNameToFolderMapping(string hostName, string folderPath, CoreWebView2HostResourceAccessKind accessKind)
	{
		try
		{
			_nativeICoreWebView2_3.SetVirtualHostNameToFolderMapping(hostName, folderPath, (COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND)accessKind);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Clears a host name mapping for local folder that was added by <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.SetVirtualHostNameToFolderMapping(System.String,System.String,Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind)" />.
	/// </summary><param name="hostName">The host name to be removed from the mapping.</param><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.SetVirtualHostNameToFolderMapping(System.String,System.String,Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind)" />
	public void ClearVirtualHostNameToFolderMapping(string hostName)
	{
		try
		{
			_nativeICoreWebView2_3.ClearVirtualHostNameToFolderMapping(hostName);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnDownloadStarting(CoreWebView2DownloadStartingEventArgs args)
	{
		privateDownloadStarting?.Invoke(this, args);
	}

	internal void OnFrameCreated(CoreWebView2FrameCreatedEventArgs args)
	{
		privateFrameCreated?.Invoke(this, args);
	}

	internal void OnClientCertificateRequested(CoreWebView2ClientCertificateRequestedEventArgs args)
	{
		privateClientCertificateRequested?.Invoke(this, args);
	}

	/// <summary>
	/// Opens the Browser Task Manager view as a new window in the foreground.
	/// </summary><remarks>
	/// If the Browser Task Manager is already open, this will bring it into the foreground. WebView2 currently blocks the Shift+Esc shortcut for opening the task manager. An end user can open the browser task manager manually via the <c>Browser task manager</c> entry of the DevTools window's title bar's context menu.
	/// </remarks>
	public void OpenTaskManagerWindow()
	{
		try
		{
			_nativeICoreWebView2_6.OpenTaskManagerWindow();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Print the current page to PDF asynchronously with the provided settings.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings" /> for description of settings. Passing null for <c>printSettings</c> results in default print settings used.
	///
	/// Use <c>resultFilePath</c> to specify the path to the PDF file. The host should provide an absolute path, including file name. If the path points to an existing file, the file will be overwritten. If the path is not valid, the method fails.
	///
	/// The async PrintToPdf operation completes when the data has been written to the PDF file. If the application exits before printing is complete, the file is not saved. Only one PrintToPdf operation can be in progress at a time.
	/// If PrintToPdf is called while a print to PDF operation is in progress, the IAsyncOperation completes and returns false.
	/// </remarks>
	public async Task<bool> PrintToPdfAsync(string ResultFilePath, CoreWebView2PrintSettings printSettings = null)
	{
		CoreWebView2PrintToPdfCompletedHandler handler;
		try
		{
			handler = new CoreWebView2PrintToPdfCompletedHandler();
			_nativeICoreWebView2_7.PrintToPdf(ResultFilePath, printSettings?._nativeICoreWebView2PrintSettings, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	internal void OnIsDocumentPlayingAudioChanged(object args)
	{
		privateIsDocumentPlayingAudioChanged?.Invoke(this, args);
	}

	internal void OnIsMutedChanged(object args)
	{
		privateIsMutedChanged?.Invoke(this, args);
	}

	internal void OnIsDefaultDownloadDialogOpenChanged(object args)
	{
		privateIsDefaultDownloadDialogOpenChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Open the default download dialog.
	/// </summary><remarks>
	/// If the dialog is opened before there are recent downloads, the dialog shows all past downloads for the current profile. Otherwise, the dialog shows only the recent downloads with a "See more" button for past downloads. Calling this method raises the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.IsDefaultDownloadDialogOpenChanged" /> event if the dialog was closed. No effect if the dialog is already open.
	/// </remarks>
	public void OpenDefaultDownloadDialog()
	{
		try
		{
			_nativeICoreWebView2_9.OpenDefaultDownloadDialog();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Close the default download dialog.
	/// </summary><remarks>
	/// Calling this method raises the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.IsDefaultDownloadDialogOpenChanged" /> event if the dialog was open. No effect if the dialog is already closed.
	/// </remarks>
	public void CloseDefaultDownloadDialog()
	{
		try
		{
			_nativeICoreWebView2_9.CloseDefaultDownloadDialog();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Creates a CoreWebView2 object that wraps an existing COM ICoreWebView2 object.
	/// This allows interacting with the CoreWebView2 using .NET, even if it was originally created using COM.
	/// </summary>
	/// <param name="value">Pointer to a COM object that implements the ICoreWebView2 COM interface.</param>
	/// <returns>Returns a .NET CoreWebView2 object that wraps the COM object.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown when the provided COM pointer is null.</exception>
	/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Thrown when the value is not an ICoreWebView2 COM object and cannot be wrapped.</exception>
	public static CoreWebView2 CreateFromComICoreWebView2(IntPtr value)
	{
		IntPtr ppv = IntPtr.Zero;
		try
		{
			if (value == IntPtr.Zero)
			{
				throw new ArgumentNullException("value", "The provided COM pointer cannot be null.");
			}
			Guid iid = typeof(ICoreWebView2).GUID;
			int num = Marshal.QueryInterface(value, ref iid, out ppv);
			if (num != 0 || ppv == IntPtr.Zero)
			{
				throw new InvalidComObjectException($"The provided COM object does not implement the ICoreWebView2 interface. HRESULT: {num}");
			}
			try
			{
				return new CoreWebView2(((ICoreWebView2)Marshal.GetObjectForIUnknown(value)) ?? throw new InvalidComObjectException("The provided COM object does not implement the ICoreWebView2 interface."));
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 can only be created from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 cannot be created after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		finally
		{
			if (ppv != IntPtr.Zero)
			{
				Marshal.Release(ppv);
			}
		}
	}

	/// <summary>
	/// Returns the existing COM ICoreWebView2 object underlying this .NET CoreWebView2 object.
	/// This allows interacting with the WebView2 control using COM APIs,
	/// even if the control was originally created using .NET.
	/// </summary>
	/// <returns>Pointer to a COM object that implements the ICoreWebView2 COM interface.</returns>
	public IntPtr GetComICoreWebView2()
	{
		return Marshal.GetComInterfaceForObject(_rawNative, typeof(ICoreWebView2));
	}

	/// <summary>
	/// Same as <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)" />, but also has support for posting DOM
	/// objects to page content.
	/// </summary>
	/// <param name="webMessageAsJson">The web message to be posted to the top level document in
	/// this WebView.</param>
	/// <param name="additionalObjects"> Additional DOM objects posted to the content.</param>
	/// <remarks>
	/// The event args is an instance of <c>MessageEvent</c>. The <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /> setting must be <c>true</c> or the message
	/// will not be sent. The event arg's <c>data</c> property of the event arg is the
	/// <c>webMessageAsJson</c> string parameter parsed as a JSON string into a JavaScript object.
	/// The event arg's <c>source</c> property of the event arg is a reference to the
	/// <c>window.chrome.webview</c> object. For information about sending messages from the HTML
	/// document in the WebView to the host, navigate to <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived" />. The message is sent asynchronously. If a
	/// navigation occurs before the message is posted to the page, the message is not be sent.
	/// This additionalObjects is retrieved in web content via the DOM MessageEvent <c>additionalObjects</c>
	/// property as an array-like list of DOM objects. Currently these type of objects can be
	/// posted:
	/// <list type="table">
	/// <listheader>
	/// <description> .NET / WinRT </description>
	/// <description> DOM type </description>
	/// </listheader>
	/// <item>
	/// <description> <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FileSystemHandle" /> </description>
	/// <description> [FileSystemHandle](https://developer.mozilla.org/docs/Web/API/FileSystemHandle) </description>
	/// </item>
	/// <item>
	/// <description> <c>null</c> </description>
	/// <description> null </description>
	/// </item>
	/// </list>
	/// The objects are posted to web content, following the
	/// [structured-clone](https://developer.mozilla.org/docs/Web/API/Web_Workers_API/Structured_clone_algorithm)
	/// semantics, meaning only objects that can be cloned can be posted. They will also behave as
	/// if they had been created by the web content they are posted to. For example, if a
	/// <c>FileSystemFileHandle</c> is posted to a web content it can only be re-transferred via
	/// <c>postMessage</c> to other web content [with the same
	/// origin](https://fs.spec.whatwg.org/#filesystemhandle).
	/// Warning: An app needs to be mindful when using this API to post DOM objects as this API
	/// provides the web content with unusual access to sensitive Web Platform features such as
	/// filesystem access! Similar to <c>PostWebMessageAsJson</c>, the app should check the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.Source" /> property right before posting the message to ensure the message
	/// and objects will only be sent to the target web content that it expects to receive the DOM
	/// objects. Additionally, the order of messages that are posted between <c>PostWebMessageAsJson</c>
	/// and <c>PostWebMessageAsJsonWithAdditionalObjects</c> may not be preserved.
	/// </remarks>
	/// <seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" />
	/// <seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs.AdditionalObjects" />
	public void PostWebMessageAsJson(string webMessageAsJson, List<object> additionalObjects)
	{
		try
		{
			_nativeICoreWebView2_23.PostWebMessageAsJsonWithAdditionalObjects(webMessageAsJson, COMDotNetTypeConverter.CoreWebView2WebObjectCollectionViewNetToCOM(additionalObjects));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Opens the browser print preview dialog to print the current web page
	/// </summary>
	public void ShowPrintUI()
	{
		try
		{
			CoreWebView2PrintDialogKind printDialogKind = CoreWebView2PrintDialogKind.Browser;
			_nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
