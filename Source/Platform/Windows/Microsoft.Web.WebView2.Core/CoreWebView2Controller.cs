using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// The owner of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" /> object that provides support for resizing, showing and hiding, focusing, and other functionality related to windowing and composition.
/// </summary><remarks>
/// The CoreWebView2Controller owns the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" />, and if all references to the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> go away, the WebView is closed.
/// </remarks>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
///
/// <summary>
/// This class is the owner of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" /> object, and
/// provides support for resizing, showing and hiding, focusing, and other
/// functionality related to windowing and composition.
/// </summary>
/// <remarks>
/// The <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> owns the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" />, and if all references to the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> go away, the WebView will be closed.
/// </remarks>
public class CoreWebView2Controller
{
	internal object _rawNative;

	internal ICoreWebView2Controller _nativeICoreWebView2ControllerValue;

	private EventRegistrationToken _AcceleratorKeyPressedToken;

	private EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> privateAcceleratorKeyPressed;

	private EventRegistrationToken _GotFocusToken;

	private EventHandler<object> privateGotFocus;

	private EventRegistrationToken _LostFocusToken;

	private EventHandler<object> privateLostFocus;

	private EventRegistrationToken _MoveFocusRequestedToken;

	private EventHandler<CoreWebView2MoveFocusRequestedEventArgs> privateMoveFocusRequested;

	private EventRegistrationToken _ZoomFactorChangedToken;

	private EventHandler<object> privateZoomFactorChanged;

	internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2Value;

	internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3Value;

	private EventRegistrationToken _RasterizationScaleChangedToken;

	private EventHandler<object> privateRasterizationScaleChanged;

	internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4Value;

	internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialControllerValue;

	private EventRegistrationToken _KeyPressedToken;

	private EventHandler<CoreWebView2PrivateKeyPressedEventArgs> privateKeyPressed;

	private const string HostObjectHelperName = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";

	private CoreWebView2 _coreWebView2;

	internal ICoreWebView2Controller _nativeICoreWebView2Controller
	{
		get
		{
			if (_nativeICoreWebView2ControllerValue == null)
			{
				try
				{
					_nativeICoreWebView2ControllerValue = (ICoreWebView2Controller)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ControllerValue;
		}
		set
		{
			_nativeICoreWebView2ControllerValue = value;
		}
	}

	/// <summary>
	/// Gets or sets the WebView bounds.</summary><remarks>
	/// Bounds are relative to the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ParentWindow" />. The app has two ways to position a WebView:
	///
	/// <list type="bullet"><item><description>
	/// Create a child HWND that is the WebView parent HWND. Position the window where the WebView should be. Use (0, 0) for the top-left corner (the offset) of the Bounds of the WebView.
	/// </description></item><item><description>
	/// Use the top-most window of the app as the WebView parent HWND. For example, to position ebView correctly in the app, set the top-left corner of the Bounds of the WebView.
	/// </description></item></list>
	///
	/// The values of Bounds are limited by the coordinate space of the host.
	/// </remarks>
	public Rectangle Bounds
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2Controller.Bounds);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller.Bounds = COMDotNetTypeConverter.RectangleNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether to show or hide the WebView.
	/// </summary><remarks>
	/// If `IsVisible` is set to `false`, the WebView is transparent and is not rendered. However, this does not affect the window containing the WebView (the `ParentWindow` parameter that was passed to <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr)" />).
	/// WebView as a child window does not get window messages when the top window is minimized or restored. For performance reasons, developers should set the <c>IsVisible</c> property of the WebView to <c>false</c> when the app window is minimized and back to <c>true</c> when the app window is restored. The app window does this by handling <c>SIZE_MINIMIZED</c> and <c>SIZE_RESTORED</c> command upon receiving <c>WM_SIZE</c> message. There are CPU and memory benefits when the page is hidden. For instance Chromium has code that throttles activities on the page like animations and some tasks are run less frequently. Similarly, WebView2 will purge some caches to reduce memory usage.
	/// </remarks><seealso cref="M:System.Windows.Forms.Control.Hide" />
	public bool IsVisible
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Controller.IsVisible != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller.IsVisible = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the parent window provided by the app or sets the parent window that this WebView is using to render content.
	/// </summary><remarks>
	/// It initially returns the `ParentWindow` passed into <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr)" />. Setting the property causes the WebView to re-parent the main WebView window to the newly provided window.
	/// </remarks>
	public IntPtr ParentWindow
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Controller.ParentWindow;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller.ParentWindow = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the zoom factor for the WebView.
	/// </summary><remarks>
	/// Note that changing zoom factor may cause <c>window.innerWidth</c> or <c>window.innerHeight</c> and page layout to change. A zoom factor that is applied by the host by setting this ZoomFactor property becomes the new default zoom for the WebView. This zoom factor applies across navigations and is the zoom factor WebView is returned to when the user presses Ctrl+0. When the zoom factor is changed by the user (resulting in the app receiving <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactorChanged" />), that zoom applies only for the current page. Any user applied zoom is only for the current page and is reset on a navigation. Specifying a ZoomFactor less than or equal to 0 is not allowed. WebView also has an internal supported zoom factor range. When a specified zoom factor is out of that range, it is normalized to be within the range, and a <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactorChanged" /> event is raised for the real applied zoom factor. When this range normalization happens, this reports the zoom factor specified during the previous modification of the ZoomFactor property until the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactorChanged" /> event is received after WebView applies the normalized zoom factor.
	/// </remarks>
	public double ZoomFactor
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Controller.ZoomFactor;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller.ZoomFactor = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2
	{
		get
		{
			if (_nativeICoreWebView2Controller2Value == null)
			{
				try
				{
					_nativeICoreWebView2Controller2Value = (ICoreWebView2Controller2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Controller2Value;
		}
		set
		{
			_nativeICoreWebView2Controller2Value = value;
		}
	}

	/// <summary>
	/// Gets or sets the WebView default background color.
	/// </summary><remarks>
	/// The `DefaultBackgroundColor` is the color that renders underneath all web content. This means WebView renders this color when there is no web content loaded such as before the initial navigation or between navigations. This also means web pages with undefined css background properties or background properties containing transparent pixels will render their contents over this color. Web pages with defined and opaque background properties that span the page will obscure the `DefaultBackgroundColor` and display normally. The default value for this property is white to resemble the native browser experience. Currently this API only supports opaque colors and transparency. It will fail for colors with alpha values that don't equal 0 or 255 ie. translucent colors are not supported. It also does not support transparency on Windows 7. On Windows 7, setting DefaultBackgroundColor to a Color with an Alpha value other than 255 will result in failure. On any OS above Win7, choosing a transparent color will result in showing hosting app content. This means webpages without explicit background properties defined will render web content over hosting app content.
	/// This property may also be set via the `WEBVIEW2_DEFAULT_BACKGROUND_COLOR` environment variable. There is a known issue with background color where just setting the color by property can still leave the app with a white flicker before the `DefaultBackgroundColor` property takes effect. Setting the color via environment variable solves this issue. The value must be a hex value that can optionally prepend a 0x. The value must account for the alpha value which is represented by the first 2 digits. So any hex value fewer than 8 digits will assume a prepended 00 to the hex value and result in a transparent color. `DefaultBackgroundColor` will return the result of this environment variable even if it has not been set directly. This environment variable can only set the `DefaultBackgroundColor` once. Subsequent updates to background color must be done by setting the property.
	/// </remarks>
	public Color DefaultBackgroundColor
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.ColorCOMToNet(_nativeICoreWebView2Controller2.DefaultBackgroundColor);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller2.DefaultBackgroundColor = COMDotNetTypeConverter.ColorNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3
	{
		get
		{
			if (_nativeICoreWebView2Controller3Value == null)
			{
				try
				{
					_nativeICoreWebView2Controller3Value = (ICoreWebView2Controller3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Controller3Value;
		}
		set
		{
			_nativeICoreWebView2Controller3Value = value;
		}
	}

	/// <summary>
	/// Gets or sets the WebView bounds mode.</summary><remarks>
	/// BoundsMode affects how setting the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" /> properties work. Bounds mode can either be in <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode.UseRawPixels" /> mode or <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode.UseRasterizationScale" /> mode.
	/// </remarks>
	public CoreWebView2BoundsMode BoundsMode
	{
		get
		{
			try
			{
				return (CoreWebView2BoundsMode)_nativeICoreWebView2Controller3.BoundsMode;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller3.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the WebView rasterization scale.
	/// </summary><remarks>
	/// The rasterization scale is the combination of the monitor DPI scale and text scaling set by the user. This value should be updated when the DPI scale of the app's top level window changes (i.e. monitor DPI scale changes or the window changes monitor) or when the text scale factor of the system changes.
	/// Rasterization scale applies to the WebView content, as well as popups, context menus, scroll bars, and so on. Normal app scaling scenarios should use the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> property or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Controller.SetBoundsAndZoomFactor(System.Drawing.Rectangle,System.Double)" /> method.
	/// </remarks>
	public double RasterizationScale
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Controller3.RasterizationScale;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller3.RasterizationScale = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether the WebView will detect monitor scale changes.
	/// </summary><remarks>
	/// ShouldDetectMonitorScaleChanges property determines whether the WebView attempts to track monitor DPI scale changes. When true, the WebView will track monitor DPI scale changes, update the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" /> property, and fire <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScaleChanged" /> event. When <c>false</c>, the WebView will not track monitor DPI scale changes, and the app must update the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" /> property itself. <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScaleChanged" /> event will never raise when ShouldDetectMonitorScaleChanges is false. Apps that want to set their own rasterization scale should set this property to false to avoid the WebView2 updating the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" /> property to match the monitor DPI scale.
	/// </remarks>
	public bool ShouldDetectMonitorScaleChanges
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4
	{
		get
		{
			if (_nativeICoreWebView2Controller4Value == null)
			{
				try
				{
					_nativeICoreWebView2Controller4Value = (ICoreWebView2Controller4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Controller4Value;
		}
		set
		{
			_nativeICoreWebView2Controller4Value = value;
		}
	}

	/// <summary>
	/// Gets or sets the WebView allow external drop property.
	/// </summary><remarks>
	/// The AllowExternalDrop is to configure the capability that dropping files into webview2 is allowed or permitted. The default value is true.
	/// </remarks>
	public bool AllowExternalDrop
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Controller4.AllowExternalDrop != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Controller4.AllowExternalDrop = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialController
	{
		get
		{
			if (_nativeICoreWebView2PrivatePartialControllerValue == null)
			{
				try
				{
					_nativeICoreWebView2PrivatePartialControllerValue = (ICoreWebView2PrivatePartialController)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartialController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrivatePartialControllerValue;
		}
		set
		{
			_nativeICoreWebView2PrivatePartialControllerValue = value;
		}
	}

	internal bool IsBrowserHitTransparent
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrivatePartialController.IsBrowserHitTransparent != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" /> associated with this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" />.
	/// </summary>
	/// <seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" />
	public CoreWebView2 CoreWebView2
	{
		get
		{
			if (_nativeICoreWebView2Controller.CoreWebView2 == null)
			{
				return null;
			}
			if (_coreWebView2 == null)
			{
				ICoreWebView2 coreWebView = _nativeICoreWebView2Controller.CoreWebView2;
				if (coreWebView == null)
				{
					return null;
				}
				_coreWebView2 = new CoreWebView2(coreWebView);
			}
			return _coreWebView2;
		}
	}

	/// <summary>
	/// AcceleratorKeyPressed is raised when an accelerator key or key combo is pressed or released while the WebView is focused.
	/// A key is considered an accelerator if either of the following conditions are true:
	///
	/// <list type="bullet"><item><description>
	/// Ctrl or Alt is currently being held.
	/// </description></item><item><description>
	/// The pressed key does not map to a character.
	/// </description></item></list>
	///
	/// A few specific keys are never considered accelerators, such as Shift. The Escape key is always considered an accelerator.
	///
	/// Autorepeated key events caused by holding the key down will also raise this event. Filter out the auto-repeated key events by verifying <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam" /> or <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus" />.
	///
	/// In windowed mode, this event is synchronous. Until you set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.Handled" /> to <c>true</c> or the event handler returns, the browser process is blocked and outgoing cross-process COM calls will fail with RPC_E_CANTCALLOUT_ININPUTSYNCCALL. All <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2" /> methods work, however.
	///
	/// In windowless mode, the event is asynchronous. Further input do not reach the browser until the event handler returns or <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.Handled" /> is set to <c>true</c>, but the browser process is not blocked, and outgoing COM calls work normally.
	///
	/// It is recommended to set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.Handled" /> to <c>true</c> as early as you are able to know that you want to handle the accelerator key.</summary>
	public event EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed
	{
		add
		{
			if (privateAcceleratorKeyPressed == null)
			{
				try
				{
					_nativeICoreWebView2Controller.add_AcceleratorKeyPressed(new CoreWebView2AcceleratorKeyPressedEventHandler(OnAcceleratorKeyPressed), out _AcceleratorKeyPressedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateAcceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Combine(privateAcceleratorKeyPressed, value);
		}
		remove
		{
			privateAcceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Remove(privateAcceleratorKeyPressed, value);
			if (privateAcceleratorKeyPressed != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Controller.remove_AcceleratorKeyPressed(_AcceleratorKeyPressedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// GotFocus is raised when WebView gets focus.</summary>
	public event EventHandler<object> GotFocus
	{
		add
		{
			if (privateGotFocus == null)
			{
				try
				{
					_nativeICoreWebView2Controller.add_GotFocus(new CoreWebView2FocusChangedEventHandler(OnGotFocus), out _GotFocusToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateGotFocus = (EventHandler<object>)Delegate.Combine(privateGotFocus, value);
		}
		remove
		{
			privateGotFocus = (EventHandler<object>)Delegate.Remove(privateGotFocus, value);
			if (privateGotFocus != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Controller.remove_GotFocus(_GotFocusToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// LostFocus is raised when WebView loses focus.
	/// </summary><remarks>
	/// In the case where <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.MoveFocusRequested" /> event is raised, the focus is still on WebView when <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.MoveFocusRequested" /> event is raised. LostFocus is only raised afterwards when code of the app or default action of <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Controller.MoveFocusRequested" /> event sets focus away from WebView.
	/// </remarks>
	public event EventHandler<object> LostFocus
	{
		add
		{
			if (privateLostFocus == null)
			{
				try
				{
					_nativeICoreWebView2Controller.add_LostFocus(new CoreWebView2FocusChangedEventHandler(OnLostFocus), out _LostFocusToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateLostFocus = (EventHandler<object>)Delegate.Combine(privateLostFocus, value);
		}
		remove
		{
			privateLostFocus = (EventHandler<object>)Delegate.Remove(privateLostFocus, value);
			if (privateLostFocus != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Controller.remove_LostFocus(_LostFocusToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// MoveFocusRequested is raised when user tries to tab out of the WebView.
	/// </summary><remarks>
	/// The focus of the WebView has not changed when this event is raised.
	/// </remarks>
	public event EventHandler<CoreWebView2MoveFocusRequestedEventArgs> MoveFocusRequested
	{
		add
		{
			if (privateMoveFocusRequested == null)
			{
				try
				{
					_nativeICoreWebView2Controller.add_MoveFocusRequested(new CoreWebView2MoveFocusRequestedEventHandler(OnMoveFocusRequested), out _MoveFocusRequestedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateMoveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Combine(privateMoveFocusRequested, value);
		}
		remove
		{
			privateMoveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Remove(privateMoveFocusRequested, value);
			if (privateMoveFocusRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Controller.remove_MoveFocusRequested(_MoveFocusRequestedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ZoomFactorChanged is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> property changes.
	/// </summary><remarks>
	/// The event may be raised because the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> property was modified, or due to the user manually modifying the zoom. When it is modified using the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> property, the internal zoom factor is updated immediately and no ZoomFactorChanged event is raised. WebView associates the last used zoom factor for each site. It is possible for the zoom factor to change when navigating to a different page. When the zoom factor changes due to a navigation change, the ZoomFactorChanged event is raised right after the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading" /> event.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" />
	public event EventHandler<object> ZoomFactorChanged
	{
		add
		{
			if (privateZoomFactorChanged == null)
			{
				try
				{
					_nativeICoreWebView2Controller.add_ZoomFactorChanged(new CoreWebView2ZoomFactorChangedEventHandler(OnZoomFactorChanged), out _ZoomFactorChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateZoomFactorChanged = (EventHandler<object>)Delegate.Combine(privateZoomFactorChanged, value);
		}
		remove
		{
			privateZoomFactorChanged = (EventHandler<object>)Delegate.Remove(privateZoomFactorChanged, value);
			if (privateZoomFactorChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Controller.remove_ZoomFactorChanged(_ZoomFactorChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// RasterizationScaleChanged is raised when the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" /> property changes.
	/// </summary><remarks>
	/// The event is raised when the Webview detects that the monitor DPI scale has changed, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ShouldDetectMonitorScaleChanges" /> is true, and the Webview has changed the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" /> property.
	/// </remarks><seealso cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale" />
	public event EventHandler<object> RasterizationScaleChanged
	{
		add
		{
			if (privateRasterizationScaleChanged == null)
			{
				try
				{
					_nativeICoreWebView2Controller3.add_RasterizationScaleChanged(new CoreWebView2RasterizationScaleChangedEventHandler(OnRasterizationScaleChanged), out _RasterizationScaleChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateRasterizationScaleChanged = (EventHandler<object>)Delegate.Combine(privateRasterizationScaleChanged, value);
		}
		remove
		{
			privateRasterizationScaleChanged = (EventHandler<object>)Delegate.Remove(privateRasterizationScaleChanged, value);
			if (privateRasterizationScaleChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Controller3.remove_RasterizationScaleChanged(_RasterizationScaleChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal event EventHandler<CoreWebView2PrivateKeyPressedEventArgs> KeyPressed
	{
		add
		{
			if (privateKeyPressed == null)
			{
				try
				{
					_nativeICoreWebView2PrivatePartialController.add_KeyPressed(new CoreWebView2PrivateKeyPressedEventHandler(OnKeyPressed), out _KeyPressedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateKeyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Combine(privateKeyPressed, value);
		}
		remove
		{
			privateKeyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Remove(privateKeyPressed, value);
			if (privateKeyPressed != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2PrivatePartialController.remove_KeyPressed(_KeyPressedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	private void Initialize()
	{
		if (_nativeICoreWebView2Controller != null)
		{
			try
			{
				CoreWebView2PrivateHostObjectHelper hostObjectHelper = new CoreWebView2PrivateHostObjectHelper();
				CoreWebView2.AddHostObjectHelper(hostObjectHelper);
			}
			catch (NotImplementedException)
			{
				ICoreWebView2 coreWebView = _nativeICoreWebView2Controller.CoreWebView2;
				object @object = new HostObjectHelper();
				coreWebView.AddHostObjectToScript("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper", ref @object);
			}
		}
	}

	internal CoreWebView2Controller(object rawCoreWebView2Controller)
	{
		_rawNative = rawCoreWebView2Controller;
		Initialize();
	}

	internal void OnAcceleratorKeyPressed(CoreWebView2AcceleratorKeyPressedEventArgs args)
	{
		privateAcceleratorKeyPressed?.Invoke(this, args);
	}

	internal void OnGotFocus(object args)
	{
		privateGotFocus?.Invoke(this, args);
	}

	internal void OnLostFocus(object args)
	{
		privateLostFocus?.Invoke(this, args);
	}

	internal void OnMoveFocusRequested(CoreWebView2MoveFocusRequestedEventArgs args)
	{
		privateMoveFocusRequested?.Invoke(this, args);
	}

	internal void OnZoomFactorChanged(object args)
	{
		privateZoomFactorChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Updates <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> properties at the same time.
	/// </summary><param name="Bounds">The bounds to be updated.</param><param name="ZoomFactor">The zoom factor to be updated.</param><remarks>
	/// This operation is atomic from the perspective of the host. After returning from this function, the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> properties are both updated if the function is successful, or neither is updated if the function fails. If <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> are both updated by the same scale (for example, <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> are both doubled), then the page does not display a change in <c>window.innerWidth</c> or <c>window.innerHeight</c> and the WebView renders the content at the new size and zoom without intermediate renderings. This function also updates just one of <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor" /> or <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> by passing in the new value for one and the current value for the other.
	/// </remarks>
	public void SetBoundsAndZoomFactor(Rectangle Bounds, double ZoomFactor)
	{
		try
		{
			_nativeICoreWebView2Controller.SetBoundsAndZoomFactor(COMDotNetTypeConverter.RectangleNetToCOM(Bounds), ZoomFactor);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Moves focus into WebView.
	/// </summary><param name="reason">The reason for moving focus.</param><remarks>
	/// WebView will get focus and focus will be set to correspondent element in the page hosted in the WebView. For <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic" /> reason, focus is set to previously focused element or the default element if no previously focused element exists. For <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next" /> reason, focus is set to the first element. For <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous" /> reason, focus is set to the last element. WebView changes focus through user interaction including selecting into a WebView or Tab into it. For tabbing, the app runs MoveFocus with <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next" /> or <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous" /> to align with Tab and Shift+Tab respectively when it decides the WebView is the next tabbable element.
	/// </remarks>
	public void MoveFocus(CoreWebView2MoveFocusReason reason)
	{
		try
		{
			_nativeICoreWebView2Controller.MoveFocus((COREWEBVIEW2_MOVE_FOCUS_REASON)reason);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		catch (ArgumentException ex3)
		{
			if (ex3.HResult == -2147024809)
			{
				return;
			}
			throw ex3;
		}
	}

	/// <summary>
	/// Tells WebView that the main WebView parent (or any ancestor) HWND moved.
	/// </summary><remarks>
	/// This is a notification separate from <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" />. This is needed for accessibility and certain dialogs in WebView to work correctly.
	/// </remarks>
	public void NotifyParentWindowPositionChanged()
	{
		try
		{
			_nativeICoreWebView2Controller.NotifyParentWindowPositionChanged();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Closes the WebView and cleans up the underlying browser instance.
	/// </summary><remarks>
	/// Cleaning up the browser instance releases the resources powering the WebView. The browser instance is shut down if no other WebViews are using it.
	///
	/// After running Close, all methods fail and event handlers stop running. Specifically, the WebView releases the associated references to any associated event handlers when Close is run.
	///
	/// Close is implicitly run when the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> loses the final reference and is destructed. But it is best practice to explicitly run Close to avoid any accidental cycle of references between the WebView and the app code. Specifically, if you capture a reference to the WebView in an event handler you create a reference cycle between the WebView and the event handler. Run Close to break the cycle by releasing all event handlers. But to avoid the situation, it is best to both explicitly run Close on the WebView and to not capture a reference to the WebView to ensure the WebView is cleaned up correctly. Close is synchronous and won't trigger the <c>beforeunload</c> event.
	/// </remarks>
	public void Close()
	{
		try
		{
			_nativeICoreWebView2Controller.Close();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Controller members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Controller members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnRasterizationScaleChanged(object args)
	{
		privateRasterizationScaleChanged?.Invoke(this, args);
	}

	internal void OnKeyPressed(CoreWebView2PrivateKeyPressedEventArgs args)
	{
		privateKeyPressed?.Invoke(this, args);
	}
}
