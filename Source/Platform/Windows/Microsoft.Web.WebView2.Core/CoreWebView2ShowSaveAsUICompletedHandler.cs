using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ShowSaveAsUICompletedHandler : ICoreWebView2ShowSaveAsUICompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2SaveAsUIResult AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2ShowSaveAsUICompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, COREWEBVIEW2_SAVE_AS_UI_RESULT value)
	{
		AsyncReturnValue = (CoreWebView2SaveAsUIResult)value;
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2ShowSaveAsUICompletedHandler GetAwaiter()
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

	public CoreWebView2SaveAsUIResult GetResult()
	{
		return AsyncReturnValue;
	}
}
