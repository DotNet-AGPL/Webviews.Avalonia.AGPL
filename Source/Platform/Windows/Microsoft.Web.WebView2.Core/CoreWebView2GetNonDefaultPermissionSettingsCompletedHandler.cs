using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler : ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public IReadOnlyList<CoreWebView2PermissionSetting> AsyncReturnValue { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2PermissionSettingCollectionView value)
	{
		AsyncReturnValue = ((value == null) ? null : COMDotNetTypeConverter.CoreWebView2PermissionSettingCollectionCOMToNet(value));
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler GetAwaiter()
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

	public IReadOnlyList<CoreWebView2PermissionSetting> GetResult()
	{
		return AsyncReturnValue;
	}
}
