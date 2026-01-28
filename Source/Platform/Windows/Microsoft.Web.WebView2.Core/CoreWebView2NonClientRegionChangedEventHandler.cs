using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NonClientRegionChangedEventHandler : ICoreWebView2NonClientRegionChangedEventHandler
{
	public delegate void CallbackType(CoreWebView2NonClientRegionChangedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2NonClientRegionChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2CompositionController source, ICoreWebView2NonClientRegionChangedEventArgs args)
	{
		_callback(new CoreWebView2NonClientRegionChangedEventArgs(args));
	}
}
