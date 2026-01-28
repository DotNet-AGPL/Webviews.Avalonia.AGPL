using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameFrameCreatedEventHandler : ICoreWebView2FrameChildFrameCreatedEventHandler
{
	public delegate void CallbackType(CoreWebView2FrameCreatedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameFrameCreatedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Frame source, ICoreWebView2FrameCreatedEventArgs args)
	{
		_callback(new CoreWebView2FrameCreatedEventArgs(args));
	}
}
