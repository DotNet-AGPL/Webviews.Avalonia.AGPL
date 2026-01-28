using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2GetProcessExtendedInfosCompletedHandler : ICoreWebView2GetProcessExtendedInfosCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public IReadOnlyList<CoreWebView2ProcessExtendedInfo> AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2GetProcessExtendedInfosCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2ProcessExtendedInfoCollection value)
	{
		AsyncReturnValue = ((value == null) ? null : COMDotNetTypeConverter.CoreWebView2ProcessExtendedInfoCollectionCOMToNet(value));
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2GetProcessExtendedInfosCompletedHandler GetAwaiter()
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

	public IReadOnlyList<CoreWebView2ProcessExtendedInfo> GetResult()
	{
		return AsyncReturnValue;
	}
}
