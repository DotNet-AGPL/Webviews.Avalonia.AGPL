using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> event.</summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2NewWindowRequestedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgsValue;

	internal ICoreWebView2NewWindowRequestedEventArgs2 _nativeICoreWebView2NewWindowRequestedEventArgs2Value;

	internal ICoreWebView2NewWindowRequestedEventArgs3 _nativeICoreWebView2NewWindowRequestedEventArgs3Value;

	internal ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2NewWindowRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2NewWindowRequestedEventArgsValue = (ICoreWebView2NewWindowRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NewWindowRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2NewWindowRequestedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" /> event is handled by host.
	/// </summary><remarks>
	/// If this is <c>false</c> and no <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow" /> is set, the WebView opens a popup window and returns the opened <c>WindowProxy</c> to the opener script. Note that in this case, there is no avenue to control the popup window from the app. If set to <c>true</c> and no <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow" /> is set for <c>window.open()</c>, the opened <c>proxy</c> is for a dummy window object, but this window does not load and is immediately closed. The default value is <c>false</c>.
	/// </remarks>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NewWindowRequestedEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2NewWindowRequestedEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> when the new window request was initiated through a user gesture such as selecting an anchor tag with target.
	/// </summary><remarks>
	/// The Microsoft Edge popup blocker is disabled for WebView so the app is able to use this flag to block non-user initiated popups.
	/// </remarks>
	public bool IsUserInitiated
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NewWindowRequestedEventArgs.IsUserInitiated != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the new window or sets a WebView as a result of the new window requested.
	/// </summary><remarks>
	/// Provides a WebView as the target for a <c>window.open()</c> from inside the requesting WebView. If this is set, the top-level window of this WebView is returned as the opened [WindowProxy](https://developer.mozilla.org/docs/glossary/windowproxy) to the opener script. If this is not set, then <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Handled" /> is checked to determine behavior for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested" />.
	/// The methods which should affect the new web contents like <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String)" /> has to be called and completed before setting NewWindow. Other methods which should affect the new web contents like <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> have to be called after setting NewWindow. It is best not to use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(System.String)" /> before setting NewWindow, otherwise it may not work for later added scripts.
	/// WebView provided in the <c>NewWindow</c> property must be on the same <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> as the opener WebView and cannot be navigated. Changes to settings should be made before setting NewWindow to ensure that those settings take effect for the newly setup WebView. The new WebView must have the same profile as the opener WebView.
	/// </remarks>
	public CoreWebView2 NewWindow
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow == null) ? null : new CoreWebView2(_nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow = value._nativeICoreWebView2;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the target uri of the new window request.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NewWindowRequestedEventArgs.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the window features specified by the <c>window.open()</c> call.
	/// These features should be considered for positioning and sizing of new WebView windows.</summary>
	public CoreWebView2WindowFeatures WindowFeatures
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures == null) ? null : new CoreWebView2WindowFeatures(_nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2NewWindowRequestedEventArgs2 _nativeICoreWebView2NewWindowRequestedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2NewWindowRequestedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2NewWindowRequestedEventArgs2Value = (ICoreWebView2NewWindowRequestedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NewWindowRequestedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2NewWindowRequestedEventArgs2Value = value;
		}
	}

	/// <summary>
	/// Gets the name of the new window.
	/// </summary><remarks>
	/// This window can be created via <c>window.open(url, windowName)</c>, where the windowName parameter corresponds to <c>Name</c> property.
	/// If no windowName is passed to `window.open`, then the `Name` property will be set to an empty string. Additionally, if window is opened through other means, such as `<a target="windowName" />` or `<iframe name="windowName" />`, then the `Name` property will be set accordingly. In the case of target=_blank, the `Name` property will be an empty string.
	/// Opening a window via Ctrl+clicking a link would result in the <c>Name</c> property being set to an empty string.
	/// </remarks>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NewWindowRequestedEventArgs2.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2NewWindowRequestedEventArgs3 _nativeICoreWebView2NewWindowRequestedEventArgs3
	{
		get
		{
			if (_nativeICoreWebView2NewWindowRequestedEventArgs3Value == null)
			{
				try
				{
					_nativeICoreWebView2NewWindowRequestedEventArgs3Value = (ICoreWebView2NewWindowRequestedEventArgs3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NewWindowRequestedEventArgs3Value;
		}
		set
		{
			_nativeICoreWebView2NewWindowRequestedEventArgs3Value = value;
		}
	}

	/// <summary>The frame info of the frame where the new window request originated. The
	/// `OriginalSourceFrameInfo` is a snapshot of frame information at the time when the
	/// new window was requested.
	///
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" /> for details on frame properties.</summary>
	public CoreWebView2FrameInfo OriginalSourceFrameInfo
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2NewWindowRequestedEventArgs3.OriginalSourceFrameInfo == null) ? null : new CoreWebView2FrameInfo(_nativeICoreWebView2NewWindowRequestedEventArgs3.OriginalSourceFrameInfo);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2NewWindowRequestedEventArgs(object rawCoreWebView2NewWindowRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2NewWindowRequestedEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object and put the event into a deferred state.
	/// Use this to Complete the window open request at a later time. While this event is deferred the opener window returns a WindowProxy to an un-navigated window, which navigates when the deferral is complete.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2NewWindowRequestedEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2NewWindowRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
