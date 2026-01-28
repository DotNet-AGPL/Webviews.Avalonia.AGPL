using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2SaveFileSecurityCheckStartingEventHandler : ICoreWebView2SaveFileSecurityCheckStartingEventHandler
{
	public delegate void CallbackType(CoreWebView2SaveFileSecurityCheckStartingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2SaveFileSecurityCheckStartingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2SaveFileSecurityCheckStartingEventArgs args)
	{
		_callback(new CoreWebView2SaveFileSecurityCheckStartingEventArgs(args));
	}
}
