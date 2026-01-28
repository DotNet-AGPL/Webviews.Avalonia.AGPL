using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary></summary>
public class CoreWebView2ScreenCaptureStartingEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2ScreenCaptureStartingEventArgs _nativeICoreWebView2ScreenCaptureStartingEventArgsValue;

	internal ICoreWebView2ScreenCaptureStartingEventArgs _nativeICoreWebView2ScreenCaptureStartingEventArgs
	{
		get
		{
			if (_nativeICoreWebView2ScreenCaptureStartingEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2ScreenCaptureStartingEventArgsValue = (ICoreWebView2ScreenCaptureStartingEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScreenCaptureStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ScreenCaptureStartingEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2ScreenCaptureStartingEventArgsValue = value;
		}
	}

	/// <summary>
	/// The host may set this flag to cancel the screen capture. If canceled,
	/// the screen capture UI is not displayed regardless of the
	/// <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ScreenCaptureStartingEventArgs.Handled" /> property.
	/// On the script side, it will return with a NotAllowedError as Permission denied.</summary>
	public bool Cancel
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScreenCaptureStartingEventArgs.Cancel != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ScreenCaptureStartingEventArgs.Cancel = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// By default, both the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ScreenCaptureStarting" /> event handlers on the
	/// <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" /> and the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" /> will be invoked, with the
	/// <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" /> event handlers invoked first. The host may
	/// set this flag to TRUE within the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" /> event handlers
	/// to prevent the remaining <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" /> event handlers from being
	/// invoked. If the flag is set to FALSE within the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" />
	/// event handlers, downstream handlers can update the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ScreenCaptureStartingEventArgs.Cancel" /> property.
	///
	/// If a deferral is taken on the event args, then you must synchronously
	/// set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ScreenCaptureStartingEventArgs.Handled" /> to TRUE prior to taking your deferral to prevent the
	/// <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Frame" />s event handlers from being invoked.</summary>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScreenCaptureStartingEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ScreenCaptureStartingEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The associated frame information that requests the screen capture
	/// permission. This can be used to get the frame source, name, frameId,
	/// and parent frame information.</summary>
	public CoreWebView2FrameInfo OriginalSourceFrameInfo
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2ScreenCaptureStartingEventArgs.OriginalSourceFrameInfo == null) ? null : new CoreWebView2FrameInfo(_nativeICoreWebView2ScreenCaptureStartingEventArgs.OriginalSourceFrameInfo);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ScreenCaptureStartingEventArgs(object rawCoreWebView2ScreenCaptureStartingEventArgs)
	{
		_rawNative = rawCoreWebView2ScreenCaptureStartingEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object. Use this deferral to
	/// defer the decision to show the Screen Capture UI. getDisplayMedia()
	/// won't call its callbacks until the deferral is completed.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2ScreenCaptureStartingEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2ScreenCaptureStartingEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
