using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Provides a set of properties for a permission setting.</summary>
public class CoreWebView2PermissionSetting
{
	internal object _rawNative;

	internal ICoreWebView2PermissionSetting _nativeICoreWebView2PermissionSettingValue;

	internal ICoreWebView2PermissionSetting _nativeICoreWebView2PermissionSetting
	{
		get
		{
			if (_nativeICoreWebView2PermissionSettingValue == null)
			{
				try
				{
					_nativeICoreWebView2PermissionSettingValue = (ICoreWebView2PermissionSetting)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionSetting.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PermissionSettingValue;
		}
		set
		{
			_nativeICoreWebView2PermissionSettingValue = value;
		}
	}

	/// <summary>
	/// The kind of the permission setting.</summary>
	public CoreWebView2PermissionKind PermissionKind
	{
		get
		{
			try
			{
				return (CoreWebView2PermissionKind)_nativeICoreWebView2PermissionSetting.PermissionKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionSetting members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionSetting members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The origin of the permission setting.</summary>
	public string PermissionOrigin
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionSetting.PermissionOrigin;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionSetting members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionSetting members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The state of the permission setting.
	/// </summary>
	public CoreWebView2PermissionState PermissionState
	{
		get
		{
			try
			{
				return (CoreWebView2PermissionState)_nativeICoreWebView2PermissionSetting.PermissionState;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionSetting members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionSetting members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2PermissionSetting(object rawCoreWebView2PermissionSetting)
	{
		_rawNative = rawCoreWebView2PermissionSetting;
	}
}
