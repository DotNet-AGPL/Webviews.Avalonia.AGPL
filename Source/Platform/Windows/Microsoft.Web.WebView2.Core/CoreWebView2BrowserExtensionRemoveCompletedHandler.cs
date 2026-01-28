using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2BrowserExtensionRemoveCompletedHandler : ICoreWebView2BrowserExtensionRemoveCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2BrowserExtensionRemoveCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode)
	{
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2BrowserExtensionRemoveCompletedHandler GetAwaiter()
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

	public void GetResult()
	{
	}
}
