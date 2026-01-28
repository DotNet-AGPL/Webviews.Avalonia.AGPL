using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// CoreWebView2Frame provides direct access to the iframes information and handling. You can get a CoreWebView2Frame by handling the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.FrameCreated" /> event.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary>
/// CoreWebView2Frame provides direct access to the iframes information and handling.
/// </summary>
public class CoreWebView2Frame
{
	internal object _rawNative;

	internal ICoreWebView2Frame _nativeICoreWebView2FrameValue;

	private EventRegistrationToken _DestroyedToken;

	private EventHandler<object> privateDestroyed;

	private EventRegistrationToken _NameChangedToken;

	private EventHandler<object> privateNameChanged;

	internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2Value;

	private EventRegistrationToken _ContentLoadingToken;

	private EventHandler<CoreWebView2ContentLoadingEventArgs> privateContentLoading;

	private EventRegistrationToken _DOMContentLoadedToken;

	private EventHandler<CoreWebView2DOMContentLoadedEventArgs> privateDOMContentLoaded;

	private EventRegistrationToken _NavigationCompletedToken;

	private EventHandler<CoreWebView2NavigationCompletedEventArgs> privateNavigationCompleted;

	private EventRegistrationToken _NavigationStartingToken;

	private EventHandler<CoreWebView2NavigationStartingEventArgs> privateNavigationStarting;

	private EventRegistrationToken _WebMessageReceivedToken;

	private EventHandler<CoreWebView2WebMessageReceivedEventArgs> privateWebMessageReceived;

	internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3Value;

	private EventRegistrationToken _PermissionRequestedToken;

	private EventHandler<CoreWebView2PermissionRequestedEventArgs> privatePermissionRequested;

	internal ICoreWebView2Frame4 _nativeICoreWebView2Frame4Value;

	internal ICoreWebView2Frame5 _nativeICoreWebView2Frame5Value;

	internal ICoreWebView2Frame6 _nativeICoreWebView2Frame6Value;

	private EventRegistrationToken _ScreenCaptureStartingToken;

	private EventHandler<CoreWebView2ScreenCaptureStartingEventArgs> privateScreenCaptureStarting;

	internal ICoreWebView2Frame7 _nativeICoreWebView2Frame7Value;

	private EventRegistrationToken _FrameCreatedToken;

	private EventHandler<CoreWebView2FrameCreatedEventArgs> privateFrameCreated;

	internal ICoreWebView2Frame _nativeICoreWebView2Frame
	{
		get
		{
			if (_nativeICoreWebView2FrameValue == null)
			{
				try
				{
					_nativeICoreWebView2FrameValue = (ICoreWebView2Frame)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FrameValue;
		}
		set
		{
			_nativeICoreWebView2FrameValue = value;
		}
	}

	/// <summary>
	/// The name of the iframe from the iframe html tag declaring it.</summary>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Frame.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2
	{
		get
		{
			if (_nativeICoreWebView2Frame2Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame2Value = (ICoreWebView2Frame2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame2Value;
		}
		set
		{
			_nativeICoreWebView2Frame2Value = value;
		}
	}

	internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3
	{
		get
		{
			if (_nativeICoreWebView2Frame3Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame3Value = (ICoreWebView2Frame3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame3Value;
		}
		set
		{
			_nativeICoreWebView2Frame3Value = value;
		}
	}

	internal ICoreWebView2Frame4 _nativeICoreWebView2Frame4
	{
		get
		{
			if (_nativeICoreWebView2Frame4Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame4Value = (ICoreWebView2Frame4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame4Value;
		}
		set
		{
			_nativeICoreWebView2Frame4Value = value;
		}
	}

	internal ICoreWebView2Frame5 _nativeICoreWebView2Frame5
	{
		get
		{
			if (_nativeICoreWebView2Frame5Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame5Value = (ICoreWebView2Frame5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame5Value;
		}
		set
		{
			_nativeICoreWebView2Frame5Value = value;
		}
	}

	/// <summary>
	/// The unique identifier of the current frame. It's the same kind of ID as with the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.FrameId" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo.FrameId" />.</summary>
	public uint FrameId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Frame5.FrameId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Frame6 _nativeICoreWebView2Frame6
	{
		get
		{
			if (_nativeICoreWebView2Frame6Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame6Value = (ICoreWebView2Frame6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame6Value;
		}
		set
		{
			_nativeICoreWebView2Frame6Value = value;
		}
	}

	internal ICoreWebView2Frame7 _nativeICoreWebView2Frame7
	{
		get
		{
			if (_nativeICoreWebView2Frame7Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame7Value = (ICoreWebView2Frame7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame7Value;
		}
		set
		{
			_nativeICoreWebView2Frame7Value = value;
		}
	}

	/// <summary>
	/// Destroyed event is raised when the iframe corresponding to this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" /> object is removed or the document containing that iframe is destroyed.
	/// </summary><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveHostObjectFromScript(System.String)" />
	public event EventHandler<object> Destroyed
	{
		add
		{
			if (privateDestroyed == null)
			{
				try
				{
					_nativeICoreWebView2Frame.add_Destroyed(new CoreWebView2FrameDestroyedEventHandler(OnDestroyed), out _DestroyedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateDestroyed = (EventHandler<object>)Delegate.Combine(privateDestroyed, value);
		}
		remove
		{
			privateDestroyed = (EventHandler<object>)Delegate.Remove(privateDestroyed, value);
			if (privateDestroyed != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Frame.remove_Destroyed(_DestroyedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// NameChanged is raised when the iframe changes its <c>window.name</c> property.
	/// </summary><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveHostObjectFromScript(System.String)" />
	public event EventHandler<object> NameChanged
	{
		add
		{
			if (privateNameChanged == null)
			{
				try
				{
					_nativeICoreWebView2Frame.add_NameChanged(new CoreWebView2FrameNameChangedEventHandler(OnNameChanged), out _NameChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNameChanged = (EventHandler<object>)Delegate.Combine(privateNameChanged, value);
		}
		remove
		{
			privateNameChanged = (EventHandler<object>)Delegate.Remove(privateNameChanged, value);
			if (privateNameChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Frame.remove_NameChanged(_NameChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ContentLoading is raised before any content is loaded, including scripts added with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String)" />. ContentLoading is not raised if a same page navigation occurs.
	/// </summary><remarks>
	/// This operation follows the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting" /> event and precedes the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.DOMContentLoaded" /> and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationCompleted" /> events.
	/// </remarks>
	public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
	{
		add
		{
			if (privateContentLoading == null)
			{
				try
				{
					_nativeICoreWebView2Frame2.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler(OnContentLoading), out _ContentLoadingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame2.remove_ContentLoading(_ContentLoadingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// DOMContentLoaded is raised when the initial HTML document has been parsed.
	/// </summary><remarks>
	/// This aligns with the the document's <c>DOMContentLoaded</c> event in HTML.
	/// </remarks>
	public event EventHandler<CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
	{
		add
		{
			if (privateDOMContentLoaded == null)
			{
				try
				{
					_nativeICoreWebView2Frame2.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler(OnDOMContentLoaded), out _DOMContentLoadedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame2.remove_DOMContentLoaded(_DOMContentLoadedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// NavigationCompleted is raised when the current frame has completely loaded (<c>body.onload</c> has been raised) or loading stopped with error.</summary>
	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
	{
		add
		{
			if (privateNavigationCompleted == null)
			{
				try
				{
					_nativeICoreWebView2Frame2.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler(OnNavigationCompleted), out _NavigationCompletedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame2.remove_NavigationCompleted(_NavigationCompletedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// NavigationStarting is raised when the current frame is requesting permission to navigate to a different URI.
	/// </summary><remarks>
	/// A frame navigation will raise a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting" /> event and a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.FrameNavigationStarting" /> event. All of the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.FrameNavigationStarting" /> event handlers will be run before the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting" /> event handlers. All of the event handlers share a common <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs" /> object. Whichever event handler is last to change the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel" /> property will decide if the frame navigation will be cancelled.
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
					_nativeICoreWebView2Frame2.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler(OnNavigationStarting), out _NavigationStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame2.remove_NavigationStarting(_NavigationStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// WebMessageReceived is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /> setting is set and the iframe runs <c>window.chrome.webview.postMessage</c>.
	/// </summary><remarks>
	/// The <c>postMessage</c> function is <c>void postMessage(object)</c> where object is any object supported by JSON conversion.
	/// When <c>postMessage</c> is called, the handler's Invoke method will be called with the <c>object</c> parameter <c>postMessage</c> converted to a JSON string.
	/// </remarks>
	public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
	{
		add
		{
			if (privateWebMessageReceived == null)
			{
				try
				{
					_nativeICoreWebView2Frame2.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler(OnWebMessageReceived), out _WebMessageReceivedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame2.remove_WebMessageReceived(_WebMessageReceivedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// PermissionRequested is raised when content in an iframe or any of its descendant iframes requests permission to access some privileged resources.
	/// </summary><remarks>
	/// This relates to the <c>PermissionRequested</c> event on the <c>CoreWebView2</c>.
	/// Both these events will be raised in the case of an iframe requesting permission. The <c>CoreWebView2Frame</c>'s event handlers will be invoked before the event handlers on the <c>CoreWebView2</c>. If the <c>Handled</c> property of the <c>PermissionRequestedEventArgs</c> is set to TRUE within the <c>CoreWebView2Frame</c> event handler, then the event will not be raised on the <c>CoreWebView2</c>, and it's event handlers will not be invoked.
	/// In the case of nested iframes, the <c>PermissionRequested</c> event will be raised from the top level iframe.
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
					_nativeICoreWebView2Frame3.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler(OnPermissionRequested), out _PermissionRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame3.remove_PermissionRequested(_PermissionRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ScreenCaptureStarting event is raised when the [Screen Capture API](https://www.w3.org/TR/screen-capture/) is requested by the user using getDisplayMedia().
	/// </summary><remarks>
	/// This relates to the <c>ScreenCaptureStarting</c> event on the <c>CoreWebView2</c>.
	/// Both these events will be raised in the case of an iframe requesting screen capture. The <c>CoreWebView2Frame</c>'s event handlers will be invoked before the event handlers on the <c>CoreWebView2</c>. If the <c>Handled</c> property of the <c>ScreenCaptureStartingEventArgs</c> is set to TRUE within the <c>CoreWebView2Frame</c> event handler, then the event will not be raised on the <c>CoreWebView2</c>, and it's event handlers will not be invoked.
	/// In the case of nested iframes, if the <c>ScreenCaptureStarting</c> event is handled in the current nested iframe (i.e., the Handled property of the <c>ScreenCaptureStartingEventArgs</c> is set to TRUE), the event will not be raised on the parent <c>CoreWebView2Frame</c>. However, if the <c>ScreenCaptureStarting</c> event is not handled in that nested iframe, the event will be raised from its nearest tracked parent <c>CoreWebView2Frame</c>.
	/// It will iterate through the parent frame chain up to the main frame until a parent frame handles the request.
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
					_nativeICoreWebView2Frame6.add_ScreenCaptureStarting(new CoreWebView2FrameScreenCaptureStartingEventHandler(OnScreenCaptureStarting), out _ScreenCaptureStartingToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame6.remove_ScreenCaptureStarting(_ScreenCaptureStartingToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// FrameCreated is raised when a new direct descendant iframe is created. Handle this event to get access to <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" /> objects.
	/// </summary><remarks>
	/// Use the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed" /> to listen for when this iframe goes away.
	/// </remarks><example>
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="FrameChildFrameCreated":::
	/// </example>
	public event EventHandler<CoreWebView2FrameCreatedEventArgs> FrameCreated
	{
		add
		{
			if (privateFrameCreated == null)
			{
				try
				{
					_nativeICoreWebView2Frame7.add_FrameCreated(new CoreWebView2FrameFrameCreatedEventHandler(OnFrameCreated), out _FrameCreatedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
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
				_nativeICoreWebView2Frame7.remove_FrameCreated(_FrameCreatedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2Frame(object rawCoreWebView2Frame)
	{
		_rawNative = rawCoreWebView2Frame;
	}

	internal void OnDestroyed(object args)
	{
		privateDestroyed?.Invoke(this, args);
	}

	internal void OnNameChanged(object args)
	{
		privateNameChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Remove the host object specified by the name so that it is no longer accessible from JavaScript code in the iframe.
	/// </summary><remarks>
	/// While new access attempts are denied, if the object is already obtained by JavaScript code in the iframe, the JavaScript code continues to have access to that object. Calling this method for a name that is already removed or was never added fails. If the iframe is destroyed this method will return fail also.
	/// </remarks>
	public void RemoveHostObjectFromScript(string name)
	{
		try
		{
			_nativeICoreWebView2Frame.RemoveHostObjectFromScript(name);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	public int IsDestroyed()
	{
		try
		{
			return _nativeICoreWebView2Frame.IsDestroyed();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
	{
		privateContentLoading?.Invoke(this, args);
	}

	internal void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
	{
		privateDOMContentLoaded?.Invoke(this, args);
	}

	internal void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
	{
		privateNavigationCompleted?.Invoke(this, args);
	}

	internal void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
	{
		privateNavigationStarting?.Invoke(this, args);
	}

	internal void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
	{
		privateWebMessageReceived?.Invoke(this, args);
	}

	/// <summary>
	/// Runs JavaScript code from the <c>javaScript</c> parameter in the current frame.
	/// </summary><param name="javaScript">The JavaScript code to be run in the current frame.</param><returns>A JSON encoded string that represents the result of running the provided JavaScript.</returns><remarks>
	/// A function that has no explicit return value returns <c>undefined</c>. If the script that was run throws an unhandled exception, then the result is also <c>null</c>. This method is applied asynchronously.
	/// If the method is run before <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.ContentLoading" />, the script will not be executed and the JSON <c>null</c> will be returned.
	/// This operation works even if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsScriptEnabled" /> is set to <c>false</c>.
	/// </remarks>
	public async Task<string> ExecuteScriptAsync(string javaScript)
	{
		CoreWebView2ExecuteScriptCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ExecuteScriptCompletedHandler();
			_nativeICoreWebView2Frame2.ExecuteScript(javaScript, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Posts the specified <c>webMessageAsJson</c> to the current frame.
	/// </summary><param name="webMessageAsJson">The web message to be posted to the iframe.</param><remarks>
	/// The event args is an instance of <c>MessageEvent</c>. The <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /> setting must be <c>true</c> or the message will not be sent. The event arg's <c>data</c> property of the event arg is the <c>webMessageAsJson</c> string parameter parsed as a JSON string into a JavaScript object. The event arg's <c>source</c> property of the event arg is a reference to the <c>window.chrome.webview</c> object. For information about sending messages from the iframe to the host, navigate to <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.WebMessageReceived" />. The message is sent asynchronously. If a navigation occurs before the message is posted to the iframe, the message is not be sent.
	/// </remarks><example>
	/// Runs the message event of the <c>window.chrome.webview</c> of the iframe. JavaScript in that document may subscribe and unsubscribe to the event using the following code:
	/// ```javascript
	/// window.chrome.webview.addEventListener('message', handler)
	/// window.chrome.webview.removeEventListener('message', handler)
	/// ```
	/// </example><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled" /><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.WebMessageReceived" /><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostWebMessageAsString(System.String)" />
	public void PostWebMessageAsJson(string webMessageAsJson)
	{
		try
		{
			_nativeICoreWebView2Frame2.PostWebMessageAsJson(webMessageAsJson);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Posts a message that is a simple string rather than a JSON string representation of a JavaScript object.
	/// </summary><param name="webMessageAsString">The web message to be posted to the iframe.</param><remarks>
	/// This behaves in exactly the same manner as <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostWebMessageAsJson(System.String)" />, but the <c>data</c> property of the event arg of the <c>window.chrome.webview</c> message is a string with the same value as <c>webMessageAsString</c>. Use this instead of <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostWebMessageAsJson(System.String)" /> if you want to communicate using simple strings rather than JSON objects.
	/// </remarks><seealso cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.WebMessageReceived" /><seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostWebMessageAsJson(System.String)" />
	public void PostWebMessageAsString(string webMessageAsString)
	{
		try
		{
			_nativeICoreWebView2Frame2.PostWebMessageAsString(webMessageAsString);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
	{
		privatePermissionRequested?.Invoke(this, args);
	}

	/// <summary>
	/// Share a shared buffer object with script of the iframe in the WebView.
	/// </summary><param name="sharedBuffer">The <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer" /> object to be shared with script.</param><param name="access">The desired <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess" /> given to script.</param><param name="additionalDataAsJson">Additional data to be send to script. If it is not null or empty string, and it is not a valid JSON string, <see cref="T:System.ArgumentException" /> will be thrown.</param><remarks>
	/// The script will receive a <c>sharedbufferreceived</c> event from chrome.webview.
	/// The event arg for that event will have the following methods and properties.
	///
	/// <list type="table"><listheader><description>Property</description><description>Description</description></listheader><item><description><c>getBuffer()</c></description><description>A method that returns an ArrayBuffer object with the backing content from the shared buffer.</description></item><item><description><c>additionalData</c></description><description>An object as the result of parsing <c>additionalDataAsJson</c> as JSON string. This property will be <c>undefined</c> if <c>additionalDataAsJson</c> is nullptr or empty string.</description></item><item><description><c>source</c></description><description>With a value set as <c>chrome.webview</c> object.</description></item></list>
	///
	/// If <c>access</c> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess.ReadOnly" />, the script will only have read access to the buffer.
	/// If the script tries to modify the content in a read only buffer, it will cause an access violation in WebView renderer process and crash the renderer process.
	///
	/// If the shared buffer is already closed, the API throws <see cref="T:System.Runtime.InteropServices.COMException" /> with error code of <c>RO_E_CLOSED</c>.
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
			_nativeICoreWebView2Frame4.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Frame members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Frame members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnScreenCaptureStarting(CoreWebView2ScreenCaptureStartingEventArgs args)
	{
		privateScreenCaptureStarting?.Invoke(this, args);
	}

	internal void OnFrameCreated(CoreWebView2FrameCreatedEventArgs args)
	{
		privateFrameCreated?.Invoke(this, args);
	}

	/// <summary>
	/// Adds the provided host object to script running in the WebViewFrame with the specified name for the list of the specified origins.
	/// The host object will be accessible for this iframe only if the iframe's origin during
	/// access matches one of the origins which are passed. The provided origins
	/// will be normalized before comparing to the origin of the document.
	/// So the scheme name is made lower case, the host will be punycode decoded
	/// as appropriate, default port values will be removed, and so on.
	/// This means the origin's host may be punycode encoded or not and will match
	/// regardless. If list contains malformed origin the call will fail.
	/// The method can be called multiple times in a row without calling
	/// RemoveHostObjectFromScript for the same object name. It will replace
	/// the previous object with the new object and new list of origins.
	/// List of origins will be treated as following:
	/// 1. empty list - call will succeed and object will be added for the iframe
	/// but it will not be exposed to any origin;
	/// 2. list with origins - during access to host object from iframe the
	/// origin will be checked that it belongs to this list;
	/// 3. list with "*" element - host object will be available for iframe for
	/// all origins. We suggest not to use this feature without understanding
	/// security implications of giving access to host object from from iframes
	/// with unknown origins.
	/// 4. list with "file://" element - host object will be available for iframes
	/// loaded via file protocol.
	/// </summary>
	/// <param name="name">
	/// The name of the host object.
	/// </param>
	/// <param name="rawObject">
	/// The host object to be added to script.
	/// </param>
	/// <param name="origins">
	/// The list of the iframe origins for which host object will be accessible.
	/// </param>
	/// <seealso cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddHostObjectToScript(System.String,System.Object)" />
	public void AddHostObjectToScript(string name, object rawObject, IEnumerable<string> origins)
	{
		ICoreWebView2Frame nativeICoreWebView2Frame = _nativeICoreWebView2Frame;
		object @object = rawObject;
		nativeICoreWebView2Frame.AddHostObjectToScriptWithOrigins(name, ref @object, (uint)origins.Count(), origins.Select((string origin) => origin).ToArray());
	}
}
