using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameScreenCaptureStartingEventHandler : ICoreWebView2FrameScreenCaptureStartingEventHandler
{
	public delegate void CallbackType(CoreWebView2ScreenCaptureStartingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameScreenCaptureStartingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Frame source, ICoreWebView2ScreenCaptureStartingEventArgs args)
	{
		_callback(new CoreWebView2ScreenCaptureStartingEventArgs(args));
	}
}
