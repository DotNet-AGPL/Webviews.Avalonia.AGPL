using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ProfileGetBrowserExtensionsCompletedHandler : ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public IReadOnlyList<CoreWebView2BrowserExtension> AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2ProfileGetBrowserExtensionsCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2BrowserExtensionList value)
	{
		AsyncReturnValue = ((value == null) ? null : COMDotNetTypeConverter.CoreWebView2BrowserExtensionCollectionCOMToNet(value));
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2ProfileGetBrowserExtensionsCompletedHandler GetAwaiter()
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

	public IReadOnlyList<CoreWebView2BrowserExtension> GetResult()
	{
		return AsyncReturnValue;
	}
}
