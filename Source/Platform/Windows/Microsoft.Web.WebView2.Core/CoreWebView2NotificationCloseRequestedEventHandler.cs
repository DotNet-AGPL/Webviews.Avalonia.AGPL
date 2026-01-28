using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NotificationCloseRequestedEventHandler : ICoreWebView2NotificationCloseRequestedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2NotificationCloseRequestedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Notification source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
