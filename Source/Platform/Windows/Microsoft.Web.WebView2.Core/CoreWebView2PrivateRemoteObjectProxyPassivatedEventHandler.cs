using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler : ICoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2PrivateRemoteObjectProxy source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
