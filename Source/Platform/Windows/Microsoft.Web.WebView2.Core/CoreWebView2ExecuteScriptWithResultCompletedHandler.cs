using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ExecuteScriptWithResultCompletedHandler : ICoreWebView2ExecuteScriptWithResultCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2ExecuteScriptResult AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2ExecuteScriptWithResultCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2ExecuteScriptResult value)
	{
		AsyncReturnValue = new CoreWebView2ExecuteScriptResult(value);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2ExecuteScriptWithResultCompletedHandler GetAwaiter()
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

	public CoreWebView2ExecuteScriptResult GetResult()
	{
		return AsyncReturnValue;
	}
}
