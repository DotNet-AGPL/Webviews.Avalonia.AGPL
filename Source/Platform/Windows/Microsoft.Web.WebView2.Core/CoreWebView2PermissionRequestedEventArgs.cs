using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.PermissionRequested" /> event.</summary>
/// <summary></summary>
/// <summary>This is a continuation of the `ICoreWebView2PermissionRequestedEventArgs2` interface.</summary>
public class CoreWebView2PermissionRequestedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2PermissionRequestedEventArgs _nativeICoreWebView2PermissionRequestedEventArgsValue;

	internal ICoreWebView2PermissionRequestedEventArgs2 _nativeICoreWebView2PermissionRequestedEventArgs2Value;

	internal ICoreWebView2PermissionRequestedEventArgs3 _nativeICoreWebView2PermissionRequestedEventArgs3Value;

	internal ICoreWebView2PermissionRequestedEventArgs _nativeICoreWebView2PermissionRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2PermissionRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2PermissionRequestedEventArgsValue = (ICoreWebView2PermissionRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PermissionRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2PermissionRequestedEventArgsValue = value;
		}
	}

	/// <summary><c>true</c> when the permission request was initiated through a user gesture such as clicking an anchor tag with target.
	/// </summary><remarks>
	/// Being initiated through a user gesture does not mean that user intended to access the associated resource.
	/// </remarks>
	public bool IsUserInitiated
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionRequestedEventArgs.IsUserInitiated != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the kind of the permission that is requested.</summary>
	public CoreWebView2PermissionKind PermissionKind
	{
		get
		{
			try
			{
				return (CoreWebView2PermissionKind)_nativeICoreWebView2PermissionRequestedEventArgs.PermissionKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the status of a permission request. For example, whether the request is granted.</summary><remarks>
	/// The default value is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2PermissionState.Default" />.
	/// </remarks>
	public CoreWebView2PermissionState State
	{
		get
		{
			try
			{
				return (CoreWebView2PermissionState)_nativeICoreWebView2PermissionRequestedEventArgs.State;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PermissionRequestedEventArgs.State = (COREWEBVIEW2_PERMISSION_STATE)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the origin of the web content that requests the permission.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionRequestedEventArgs.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2PermissionRequestedEventArgs2 _nativeICoreWebView2PermissionRequestedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2PermissionRequestedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2PermissionRequestedEventArgs2Value = (ICoreWebView2PermissionRequestedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PermissionRequestedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2PermissionRequestedEventArgs2Value = value;
		}
	}

	/// <summary>
	/// The host may set this flag to <c>TRUE</c> to prevent the <c>PermissionRequested</c> event from firing on the <c>CoreWebView2</c> as well.
	/// By default, both the <c>PermissionRequested</c> on the <c>CoreWebView2Frame</c> and <c>CoreWebView2</c> will be fired.</summary>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionRequestedEventArgs2.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PermissionRequestedEventArgs2.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2PermissionRequestedEventArgs3 _nativeICoreWebView2PermissionRequestedEventArgs3
	{
		get
		{
			if (_nativeICoreWebView2PermissionRequestedEventArgs3Value == null)
			{
				try
				{
					_nativeICoreWebView2PermissionRequestedEventArgs3Value = (ICoreWebView2PermissionRequestedEventArgs3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PermissionRequestedEventArgs3Value;
		}
		set
		{
			_nativeICoreWebView2PermissionRequestedEventArgs3Value = value;
		}
	}

	/// <summary>
	/// Set the <c>SavesInProfile</c> property to <c>FALSE</c> to not persist the state beyond the current request, and to continue to receive <c>PermissionRequested</c> events for this origin and permission kind.
	/// </summary><remarks>
	/// The permission state set from the <c>PermissionRequested</c>  event is saved in the profile by default; it is persisted across sessions and becomes the new default behavior for future <c>PermissionRequested</c>  events. Browser heuristics can affect whether the event continues to be raised when the state is persisted.
	/// </remarks>
	public bool SavesInProfile
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionRequestedEventArgs3.SavesInProfile != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PermissionRequestedEventArgs3.SavesInProfile = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2PermissionRequestedEventArgs(object rawCoreWebView2PermissionRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2PermissionRequestedEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object.
	/// </summary><remarks>
	/// Use the deferral object to make the permission decision at a later time. The deferral only applies to the current request, and does not prevent the <c>PermissionRequested</c> event from getting raised for new requests. However, for some permission kinds the WebView will avoid creating a new request if there is a pending request of the same kind.
	/// </remarks>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2PermissionRequestedEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2PermissionRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
