using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// The window features for a WebView popup window.
/// </summary><remarks>
/// The fields match the <c>windowFeatures</c> passed to <c>window.open()</c> as specified in [Window features](https://developer.mozilla.org/docs/Web/API/Window/open#Window_features) on MDN.
/// </remarks>
/// There is no requirement for you to respect the values.  If your app does
/// not have corresponding UI features (for example, no toolbar) or if all
/// instance of WebView are opened in tabs and do not have distinct size or
/// positions, then your app does not respect the values.  You may want to
/// respect values, but perhaps only some apply to the UI of you app.
/// Accordingly, you may respect all, some, or none of the properties as
/// appropriate for your app.  For all numeric properties, if the value that is
/// passed to `window.open` is outside the range of an unsigned 32bit int, the
/// resulting value is the absolute value of the maximum for unsigned 32bit
/// integer.  If you are not able to parse the value an integer, it is
/// considered `0`.  If the value is a floating point value, it is rounded down
/// to an integer.
///
/// In runtime versions 98 or later, the values of `ShouldDisplayMenuBar`,
/// `ShouldDisplayStatus`, `ShouldDisplayToolbar`, and `ShouldDisplayScrollBars`
/// will not directly depend on the equivalent fields in the `windowFeatures`
/// string.  Instead, they will all be false if the window is expected to be a
/// popup, and true if it is not.
public class CoreWebView2WindowFeatures
{
	internal object _rawNative;

	internal ICoreWebView2WindowFeatures _nativeICoreWebView2WindowFeaturesValue;

	internal ICoreWebView2WindowFeatures _nativeICoreWebView2WindowFeatures
	{
		get
		{
			if (_nativeICoreWebView2WindowFeaturesValue == null)
			{
				try
				{
					_nativeICoreWebView2WindowFeaturesValue = (ICoreWebView2WindowFeatures)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowFeatures.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WindowFeaturesValue;
		}
		set
		{
			_nativeICoreWebView2WindowFeaturesValue = value;
		}
	}

	/// <summary>Indicates whether the left and top values are specified.</summary>
	public bool HasPosition
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.HasPosition != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Indicates whether the height and width values are specified.</summary>
	public bool HasSize
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.HasSize != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the height of the window. Ignored if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures.HasSize" /> is <c>false</c>.</summary>
	public uint Height
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.Height;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Specifies the left position of the window.
	///
	/// Ignored if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures.HasPosition" /> is <c>false</c>.</summary>
	public uint Left
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.Left;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Indicates that the menu bar is displayed.</summary>
	public bool ShouldDisplayMenuBar
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.ShouldDisplayMenuBar != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Indicates that the scroll bars are displayed.</summary>
	public bool ShouldDisplayScrollBars
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.ShouldDisplayScrollBars != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Indicates that the status bar is displayed.</summary>
	public bool ShouldDisplayStatus
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.ShouldDisplayStatus != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Indicates that the browser toolbar is displayed.</summary>
	public bool ShouldDisplayToolbar
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.ShouldDisplayToolbar != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Specifies the top position of the window.
	///
	/// Ignored if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures.HasPosition" /> is <c>false</c>.</summary>
	public uint Top
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.Top;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Specifies the width of the window.
	///
	/// Ignored if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures.HasSize" /> is <c>false</c>.</summary>
	public uint Width
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WindowFeatures.Width;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WindowFeatures members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2WindowFeatures(object rawCoreWebView2WindowFeatures)
	{
		_rawNative = rawCoreWebView2WindowFeatures;
	}
}
