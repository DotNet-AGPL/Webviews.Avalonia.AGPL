using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2SaveAsUIShowingEventHandler : ICoreWebView2SaveAsUIShowingEventHandler
{
	public delegate void CallbackType(CoreWebView2SaveAsUIShowingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2SaveAsUIShowingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2SaveAsUIShowingEventArgs args)
	{
		_callback(new CoreWebView2SaveAsUIShowingEventArgs(args));
	}
}
