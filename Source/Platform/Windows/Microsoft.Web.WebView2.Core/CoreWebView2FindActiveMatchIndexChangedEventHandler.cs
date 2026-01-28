using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FindActiveMatchIndexChangedEventHandler : ICoreWebView2FindActiveMatchIndexChangedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2FindActiveMatchIndexChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Find source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
