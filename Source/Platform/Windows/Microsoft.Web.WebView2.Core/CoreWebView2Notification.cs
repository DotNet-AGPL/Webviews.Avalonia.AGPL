using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// An object that represents a [HTML Notification object](https://developer.mozilla.org/docs/Web/API/Notification).</summary>
public class CoreWebView2Notification
{
	internal object _rawNative;

	internal ICoreWebView2Notification _nativeICoreWebView2NotificationValue;

	private EventRegistrationToken _CloseRequestedToken;

	private EventHandler<object> privateCloseRequested;

	internal ICoreWebView2Notification _nativeICoreWebView2Notification
	{
		get
		{
			if (_nativeICoreWebView2NotificationValue == null)
			{
				try
				{
					_nativeICoreWebView2NotificationValue = (ICoreWebView2Notification)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Notification.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NotificationValue;
		}
		set
		{
			_nativeICoreWebView2NotificationValue = value;
		}
	}

	/// <summary>
	/// A string containing the URI of the image used to represent the notification when there isn't enough space to display the notification itself.
	/// </summary><remarks>
	/// The default value is an empty string.
	/// </remarks>
	public string BadgeUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.BadgeUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// A string representing the body text of the notification.
	/// </summary><remarks>
	/// The default value is an empty string.
	/// </remarks>
	public string Body
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.Body;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// A string containing the URI of an image to be displayed in the notification.
	/// </summary><remarks>
	/// The default value is an empty string.
	/// </remarks>
	public string BodyImageUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.BodyImageUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The text direction in which to display the notification.</summary><remarks>
	/// This corresponds to [Notification.dir](https://developer.mozilla.org/docs/Web/API/Notification/dir) DOM API. The default value is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2TextDirectionKind.Default" />.
	/// </remarks>
	public CoreWebView2TextDirectionKind Direction
	{
		get
		{
			try
			{
				return (CoreWebView2TextDirectionKind)_nativeICoreWebView2Notification.Direction;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// A string containing the URI of an icon to be displayed in the notification.
	/// </summary><remarks>
	/// The default value is an empty string.
	/// </remarks>
	public string IconUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.IconUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Indicates whether the notification should be silent -- i.e., no sounds or vibrations should be issued, regardless of the device settings.
	/// </summary><remarks>
	/// This corresponds to [Notification.silent](https://developer.mozilla.org/docs/Web/API/Notification/silent) DOM API. The default value is <c>false</c>.
	/// </remarks>
	public bool IsSilent
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.IsSilent != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The notification's language, as intended to be specified using a string representing a language tag (such as <c>en-US</c>) according to [BCP47](https://datatracker.ietf.org/doc/html/rfc5646).
	/// </summary><remarks>
	/// Note that no validation is performed on this property and it can be any string the notification sender specifies. This corresponds to [Notification.lang](https://developer.mozilla.org/docs/Web/API/Notification/lang) DOM API. The default value is an empty string.
	/// </remarks>
	public string Language
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.Language;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// A boolean value indicating that a notification should remain active until the user clicks or dismisses it, rather than closing automatically.
	/// </summary><remarks>
	/// This corresponds to [Notification.requireInteraction](https://developer.mozilla.org/docs/Web/API/Notification/requireInteraction) DOM API. Note that you may not be able to necessarily implement this due to native API limitations. The default value is <c>false</c>.
	/// </remarks>
	public bool RequiresInteraction
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.RequiresInteraction != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Indicates whether the user should be notified after a new notification replaces an old one.
	/// </summary><remarks>
	/// This corresponds to [Notification.renotify](https://developer.mozilla.org/docs/Web/API/Notification/renotify) DOM API. The default value is <c>false</c>.
	/// </remarks>
	public bool ShouldRenotify
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.ShouldRenotify != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// A string representing an identifying tag for the notification.
	/// </summary><remarks>
	/// This corresponds to [Notification.tag](https://developer.mozilla.org/docs/Web/API/Notification/tag) DOM API. The default value is an empty string.
	/// </remarks>
	public string Tag
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.Tag;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The title of the notification.</summary>
	public string Title
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Notification.Title;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Specifies the time at which a notification is created or applicable
	/// (past, present, or future).
	/// </summary>
	public DateTime Timestamp => DateTimeOffset.FromUnixTimeMilliseconds((long)_nativeICoreWebView2Notification.Timestamp).DateTime;

	/// <summary>
	/// Gets the vibration pattern for devices with vibration hardware to emit.
	/// </summary>
	/// <remarks>
	/// The vibration pattern can be represented by an array of 64-bit
	/// unsigned integers describing a pattern of vibrations and pauses. See
	/// [Vibration API](https://developer.mozilla.org/docs/Web/API/Vibration_API) for
	/// more information. This corresponds to
	/// [Notification.vibrate](https://developer.mozilla.org/docs/Web/API/Notification/vibrate)
	/// DOM API. An empty list is returned if no vibration patterns are
	/// specified.
	/// </remarks>
	public IReadOnlyList<ulong> VibrationPattern
	{
		get
		{
			uint Count = 0u;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
			_nativeICoreWebView2Notification.GetVibrationPattern(out Count, intPtr);
			List<ulong> list = new List<ulong>(Convert.ToInt32(Count));
			IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
			for (int i = 0; i < Count; i++)
			{
				list.Add((ulong)Marshal.ReadInt64(intPtr2, i * 8));
			}
			Marshal.FreeHGlobal(intPtr2);
			return new ReadOnlyCollection<ulong>(list);
		}
	}

	/// <summary>
	/// This event is raised when the notification is closed by the web code, such as through <c>notification.close()</c>.
	/// </summary><remarks>
	/// You don't need to call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Notification.ReportClosed" /> since this is coming from the web code.
	/// </remarks>
	public event EventHandler<object> CloseRequested
	{
		add
		{
			if (privateCloseRequested == null)
			{
				try
				{
					_nativeICoreWebView2Notification.add_CloseRequested(new CoreWebView2NotificationCloseRequestedEventHandler(OnCloseRequested), out _CloseRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateCloseRequested = (EventHandler<object>)Delegate.Combine(privateCloseRequested, value);
		}
		remove
		{
			privateCloseRequested = (EventHandler<object>)Delegate.Remove(privateCloseRequested, value);
			if (privateCloseRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Notification.remove_CloseRequested(_CloseRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2Notification(object rawCoreWebView2Notification)
	{
		_rawNative = rawCoreWebView2Notification;
	}

	internal void OnCloseRequested(object args)
	{
		privateCloseRequested?.Invoke(this, args);
	}

	/// <summary>
	/// The host may run this to report the notification has been displayed and it will cause the [show](https://developer.mozilla.org/docs/Web/API/Notification/show_event) event to be raised for non-persistent notifications.
	/// </summary><remarks>
	/// You must not run this unless you are handling the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NotificationReceived" />. API throws COMException with error code of <c>HRESULT_FROM_WIN32(ERROR_INVALID_STATE)</c> if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> is <c>false</c> when this is called.
	/// </remarks>
	public void ReportShown()
	{
		try
		{
			_nativeICoreWebView2Notification.ReportShown();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// The host may run this to report the notification has been clicked, and it will cause the [click](https://developer.mozilla.org/docs/Web/API/Notification/click_event) event to be raised for non-persistent notifications.
	/// You must not run this unless you are handling the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NotificationReceived" />. API throws COMException with error code of <c>HRESULT_FROM_WIN32(ERROR_INVALID_STATE)</c> if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> is <c>false</c> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Notification.ReportShown" /> has not been run when this is called.</summary>
	public void ReportClicked()
	{
		try
		{
			_nativeICoreWebView2Notification.ReportClicked();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// The host may run this to report the notification was dismissed, and it will cause the [close](https://developer.mozilla.org/docs/Web/API/Notification/close_event) event to be raised for non-persistent notifications.
	/// </summary><remarks>
	/// You must not run this unless you are handling the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NotificationReceived" />. API throws COMException with error code of <c>HRESULT_FROM_WIN32(ERROR_INVALID_STATE)</c> if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> is <c>false</c> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Notification.ReportShown" /> has not been run when this is called.
	/// </remarks>
	public void ReportClosed()
	{
		try
		{
			_nativeICoreWebView2Notification.ReportClosed();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Notification members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Notification members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
