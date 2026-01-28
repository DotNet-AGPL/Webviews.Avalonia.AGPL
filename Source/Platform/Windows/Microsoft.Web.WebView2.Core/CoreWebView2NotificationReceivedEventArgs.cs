using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NotificationReceived" />.</summary>
public class CoreWebView2NotificationReceivedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2NotificationReceivedEventArgs _nativeICoreWebView2NotificationReceivedEventArgsValue;

	internal ICoreWebView2NotificationReceivedEventArgs _nativeICoreWebView2NotificationReceivedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2NotificationReceivedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2NotificationReceivedEventArgsValue = (ICoreWebView2NotificationReceivedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NotificationReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NotificationReceivedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2NotificationReceivedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Sets whether the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NotificationReceived" /> is handled by the host after the event handler completes or if there is a deferral then after the deferral is completed.
	/// </summary><remarks>
	/// If <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> is set to <c>true</c> then WebView will not display the notification with the default UI, and the host will be responsible for handling the notification and for letting the web content know that the notification has been displayed, clicked, or closed. You must set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> to <c>true</c> before you call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Notification.ReportShown" />, <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Notification.ReportClicked" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Notification.ReportClosed" />, otherwise they will fail with <c>HRESULT_FROM_WIN32(ERROR_INVALID_STATE)</c>. If after the event handler or deferral completes <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> is set to <c>false</c> then WebView will display the default notification UI. Note that you cannot un-handle this event once you have set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NotificationReceivedEventArgs.Handled" /> to be <c>true</c>. The initial value is <c>false</c>.
	/// </remarks>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NotificationReceivedEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2NotificationReceivedEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The notification that was received.
	/// </summary><remarks>
	/// You can access the properties on the Notification object to show your own notification.
	/// </remarks>
	public CoreWebView2Notification Notification
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2NotificationReceivedEventArgs.Notification == null) ? null : new CoreWebView2Notification(_nativeICoreWebView2NotificationReceivedEventArgs.Notification);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The origin of the web content that sends the notification, such as <c>https://example.com/</c> or <c>https://www.example.com/</c>.</summary>
	public string SenderOrigin
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NotificationReceivedEventArgs.SenderOrigin;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2NotificationReceivedEventArgs(object rawCoreWebView2NotificationReceivedEventArgs)
	{
		_rawNative = rawCoreWebView2NotificationReceivedEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object.
	/// Use this to Complete the event at a later time.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2NotificationReceivedEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2NotificationReceivedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
