using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Provides a set of properties for a process list with extended information in the .</summary>
public class CoreWebView2ProcessExtendedInfo
{
	internal object _rawNative;

	internal ICoreWebView2ProcessExtendedInfo _nativeICoreWebView2ProcessExtendedInfoValue;

	internal ICoreWebView2ProcessExtendedInfo _nativeICoreWebView2ProcessExtendedInfo
	{
		get
		{
			if (_nativeICoreWebView2ProcessExtendedInfoValue == null)
			{
				try
				{
					_nativeICoreWebView2ProcessExtendedInfoValue = (ICoreWebView2ProcessExtendedInfo)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessExtendedInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ProcessExtendedInfoValue;
		}
		set
		{
			_nativeICoreWebView2ProcessExtendedInfoValue = value;
		}
	}

	/// <summary>
	/// Provides the collection of associated <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" />s which are actively running (showing or hiding UI elements) in this renderer process.
	/// </summary><remarks>
	/// AssociatedFrameInfos will only be populated when this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessExtendedInfo" /> corresponds to a renderer process. Non-renderer processes will always have an empty AssociatedFrameInfo. AssociatedFrameInfos may also be empty for renderer processes that have no active frames.
	/// </remarks>
	public IReadOnlyList<CoreWebView2FrameInfo> AssociatedFrameInfos
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.CoreWebView2FrameInfoCollectionCOMToNet(_nativeICoreWebView2ProcessExtendedInfo.AssociatedFrameInfos);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessExtendedInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessExtendedInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Provides the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo" /> of the current process.</summary>
	public CoreWebView2ProcessInfo ProcessInfo
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2ProcessExtendedInfo.ProcessInfo == null) ? null : new CoreWebView2ProcessInfo(_nativeICoreWebView2ProcessExtendedInfo.ProcessInfo);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ProcessExtendedInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ProcessExtendedInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ProcessExtendedInfo(object rawCoreWebView2ProcessExtendedInfo)
	{
		_rawNative = rawCoreWebView2ProcessExtendedInfo;
	}
}
