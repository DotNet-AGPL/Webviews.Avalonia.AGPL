using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2GetCookiesCompletedHandler : ICoreWebView2GetCookiesCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public List<CoreWebView2Cookie> AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2GetCookiesCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2CookieList value)
	{
		AsyncReturnValue = ((value == null) ? null : COMDotNetTypeConverter.CoreWebView2CookieCollectionCOMToNet(value));
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2GetCookiesCompletedHandler GetAwaiter()
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

	public List<CoreWebView2Cookie> GetResult()
	{
		return AsyncReturnValue;
	}
}
