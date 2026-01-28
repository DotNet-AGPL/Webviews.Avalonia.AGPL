using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NotificationReceivedEventHandler : ICoreWebView2NotificationReceivedEventHandler
{
	public delegate void CallbackType(CoreWebView2NotificationReceivedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2NotificationReceivedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2NotificationReceivedEventArgs args)
	{
		_callback(new CoreWebView2NotificationReceivedEventArgs(args));
	}
}
