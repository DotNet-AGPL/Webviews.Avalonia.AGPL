using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.AcceleratorKeyPressed" /> event.</summary>
/// <summary></summary>
public class CoreWebView2AcceleratorKeyPressedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;

	internal ICoreWebView2AcceleratorKeyPressedEventArgs2 _nativeICoreWebView2AcceleratorKeyPressedEventArgs2Value;

	internal ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2AcceleratorKeyPressedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = (ICoreWebView2AcceleratorKeyPressedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.AcceleratorKeyPressed" /> event is handled by host.
	/// </summary><remarks>
	/// If set to <c>true</c> then this prevents the WebView from performing the default action for this accelerator key. Otherwise the WebView will perform the default action for the accelerator key.
	/// </remarks>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the key event kind that caused the event to run.</summary>
	public CoreWebView2KeyEventKind KeyEventKind
	{
		get
		{
			try
			{
				return (CoreWebView2KeyEventKind)_nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the LPARAM value that accompanied the window message.
	/// </summary><remarks>
	/// See the documentation for the <c>WM_KEYDOWN</c> and <c>WM_KEYUP</c> messages.
	/// </remarks>
	public int KeyEventLParam
	{
		get
		{
			try
			{
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PhysicalKeyStatus" /> representing the information passed in the LPARAM of the window message.</summary>
	public CoreWebView2PhysicalKeyStatus PhysicalKeyStatus
	{
		get
		{
			try
			{
				return new CoreWebView2PhysicalKeyStatus(_nativeICoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the Win32 virtual key code of the key that was pressed or released.
	/// </summary><remarks>
	/// It is one of the Win32 virtual key constants such as VK_RETURN or an (uppercase) ASCII value such as 'A'. Verify whether Ctrl or Alt are pressed by running GetKeyState(VK_CONTROL) or GetKeyState(VK_MENU).
	/// </remarks>
	public uint VirtualKey
	{
		get
		{
			try
			{
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs.VirtualKey;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2AcceleratorKeyPressedEventArgs2 _nativeICoreWebView2AcceleratorKeyPressedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2AcceleratorKeyPressedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2AcceleratorKeyPressedEventArgs2Value = (ICoreWebView2AcceleratorKeyPressedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2AcceleratorKeyPressedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2AcceleratorKeyPressedEventArgs2Value = value;
		}
	}

	/// <summary>
	/// This `IsBrowserAcceleratorKeyEnabled` property allows developers to control whether the browser handles accelerator keys such as Ctrl+P or F3, etc.
	/// </summary><remarks>
	/// The `CoreWebView2Settings.AreBrowserAcceleratorKeysEnabled` API is a convenient setting for developers to disable all the browser accelerator keys together. This setting also sets the default value for the `IsBrowserAcceleratorKeyEnabled` property.
	///
	/// By default, `CoreWebView2Settings.AreBrowserAcceleratorKeysEnabled` is `TRUE` and `IsBrowserAcceleratorKeyEnabled` is `TRUE`. When developers change `CoreWebView2Settings.AreBrowserAcceleratorKeysEnabled` setting to `FALSE`, this will change default value for `IsBrowserAcceleratorKeyEnabled` to `FALSE`. If developers want specific keys to be handled by the browser after changing the `CoreWebView2Settings.AreBrowserAcceleratorKeysEnabled` setting to `FALSE`, they need to enable these keys by setting `IsBrowserAcceleratorKeyEnabled` to `TRUE`.
	///
	/// The `CoreWebView2Controller.AcceleratorKeyPressed` event is raised any time an accelerator key is pressed, regardless of whether accelerator keys are enabled or not.
	///
	/// This API will give the event arg higher priority over the `CoreWebView2Settings.AreBrowserAcceleratorKeysEnabled` setting when we handle the keys.
	///
	/// With `IsBrowserAcceleratorKeyEnabled` property, if developers mark `IsBrowserAcceleratorKeyEnabled` as `FALSE`, the browser will skip the WebView2 browser feature accelerator key handling process, but the event propagation continues, and web content will receive the key combination.
	///
	/// This property does not disable accelerator keys related to movement and text editing, such as:
	///  - Home, End, Page Up, and Page Down
	///  - Ctrl-X, Ctrl-C, Ctrl-V
	///  - Ctrl-A for Select All
	///  - Ctrl-Z for Undo
	/// </remarks>
	public bool IsBrowserAcceleratorKeyEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs2.IsBrowserAcceleratorKeyEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2AcceleratorKeyPressedEventArgs2.IsBrowserAcceleratorKeyEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2AcceleratorKeyPressedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2AcceleratorKeyPressedEventArgs(object rawCoreWebView2AcceleratorKeyPressedEventArgs)
	{
		_rawNative = rawCoreWebView2AcceleratorKeyPressedEventArgs;
	}
}
