using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ScreenCaptureStartingEventHandler : ICoreWebView2ScreenCaptureStartingEventHandler
{
	public delegate void CallbackType(CoreWebView2ScreenCaptureStartingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2ScreenCaptureStartingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2ScreenCaptureStartingEventArgs args)
	{
		_callback(new CoreWebView2ScreenCaptureStartingEventArgs(args));
	}
}
