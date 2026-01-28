using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ProfileAddBrowserExtensionCompletedHandler : ICoreWebView2ProfileAddBrowserExtensionCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2BrowserExtension AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2ProfileAddBrowserExtensionCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2BrowserExtension value)
	{
		AsyncReturnValue = new CoreWebView2BrowserExtension(value);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2ProfileAddBrowserExtensionCompletedHandler GetAwaiter()
	{
		return this;
	}

	public void OnCompleted(Action continuation)
	{
		this.continuation = continuation;
		if (IsCompleted)
		{
			continuation();
		}
	}

	public CoreWebView2BrowserExtension GetResult()
	{
		return AsyncReturnValue;
	}
}
