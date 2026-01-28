using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.LaunchingExternalUriScheme" /> event.</summary>
public class CoreWebView2LaunchingExternalUriSchemeEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2LaunchingExternalUriSchemeEventArgs _nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue;

	internal ICoreWebView2LaunchingExternalUriSchemeEventArgs _nativeICoreWebView2LaunchingExternalUriSchemeEventArgs
	{
		get
		{
			if (_nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue = (ICoreWebView2LaunchingExternalUriSchemeEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2LaunchingExternalUriSchemeEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue = value;
		}
	}

	/// <summary>
	/// Determines whether to cancel the navigation.</summary>
	public bool Cancel
	{
		get
		{
			try
			{
				return _nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.Cancel != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.Cancel = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the origin initiating the external URI scheme launch.
	/// </summary><remarks>
	/// The origin will be an empty string if the request is initiated by calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.Navigate(System.String)" /> on the external URI scheme. If a script initiates the navigation, the `InitiatingOrigin` will be the top-level document's `Source`, i.e. if `window.location` is set to `"calculator://", the `InitiatingOrigin` will be set to `calculator://`. If the request is initiated from a child frame, the `InitiatingOrigin` will be the source of that child frame. If the `InitiatingOrigin` is [opaque](https://html.spec.whatwg.org/multipage/origin.html#concept-origin-opaque), the `InitiatingOrigin` reported in the event args will be its precursor origin. The precursor origin is the origin that created the opaque origin. For example, if a frame on example.com opens a subframe with a different opaque origin, the subframe's precursor origin is example.com.
	/// </remarks>
	public string InitiatingOrigin
	{
		get
		{
			try
			{
				return _nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.InitiatingOrigin;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> when the launching external URI scheme request was initiated through a user gesture.</summary>
	public bool IsUserInitiated
	{
		get
		{
			try
			{
				return _nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.IsUserInitiated != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the URI with the external URI scheme to be launched.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2LaunchingExternalUriSchemeEventArgs(object rawCoreWebView2LaunchingExternalUriSchemeEventArgs)
	{
		_rawNative = rawCoreWebView2LaunchingExternalUriSchemeEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object and puts the event into a deferred state.
	/// Use this to Complete the launching external URI scheme request at a later time.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2LaunchingExternalUriSchemeEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
