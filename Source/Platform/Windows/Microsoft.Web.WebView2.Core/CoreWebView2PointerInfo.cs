using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// This mostly represents a combined win32 <c>POINTER_INFO</c>, <c>POINTER_TOUCH_INFO</c>, and <c>POINTER_PEN_INFO</c> object.</summary>
public class CoreWebView2PointerInfo
{
	internal object _rawNative;

	internal ICoreWebView2PointerInfo _nativeICoreWebView2PointerInfoValue;

	internal ICoreWebView2PointerInfo _nativeICoreWebView2PointerInfo
	{
		get
		{
			if (_nativeICoreWebView2PointerInfoValue == null)
			{
				try
				{
					_nativeICoreWebView2PointerInfoValue = (ICoreWebView2PointerInfo)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PointerInfoValue;
		}
		set
		{
			_nativeICoreWebView2PointerInfoValue = value;
		}
	}

	/// <summary>
	/// Gets or sets the ButtonChangeKind of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the ButtonChangeKind property of the <c>POINTER_INFO</c> struct. The values are defined by the <c>POINTER_BUTTON_CHANGE_KIND</c> enum in the Windows SDK (_winuser.h_).
	/// </remarks>
	public int ButtonChangeKind
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.ButtonChangeKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.ButtonChangeKind = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the DisplayRect of the sourceDevice property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).</summary>
	public Rectangle DisplayRect
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.DisplayRect);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.DisplayRect = COMDotNetTypeConverter.RectangleNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the FrameID of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the frameId property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint FrameId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.FrameId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.FrameId = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the HimetricLocation of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the ptHimetricLocation property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public Point HimetricLocation
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.HimetricLocation);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.HimetricLocation = COMDotNetTypeConverter.PointNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the HimetricLocationRaw of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the ptHimetricLocationRaw property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public Point HimetricLocationRaw
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.HimetricLocationRaw);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.HimetricLocationRaw = COMDotNetTypeConverter.PointNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the HistoryCount of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the historyCount property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint HistoryCount
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.HistoryCount;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.HistoryCount = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the InputData of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the InputData property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public int InputData
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.InputData;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.InputData = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the KeyStates of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the dwKeyStates property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint KeyStates
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.KeyStates;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.KeyStates = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PenFlags of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the penFlags property of the <c>POINTER_PEN_INFO</c> struct. The values are defined by the PEN_FLAGS constants in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint PenFlags
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PenFlags;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PenFlags = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PenMask of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the penMask property of the <c>POINTER_PEN_INFO</c> struct. The values are defined by the PEN_MASK constants in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint PenMask
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PenMask;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PenMask = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PenPressure of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the pressure property of the <c>POINTER_PEN_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint PenPressure
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PenPressure;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PenPressure = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PenRotation of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the rotation property of the <c>POINTER_PEN_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint PenRotation
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PenRotation;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PenRotation = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PenTiltX of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the tiltX property of the <c>POINTER_PEN_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public int PenTiltX
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PenTiltX;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PenTiltX = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PenTiltY of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the tiltY property of the <c>POINTER_PEN_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public int PenTiltY
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PenTiltY;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PenTiltY = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PerformanceCount of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the PerformanceCount property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public ulong PerformanceCount
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PerformanceCount;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PerformanceCount = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PixelLocation of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the ptPixelLocation property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public Point PixelLocation
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.PixelLocation);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PixelLocation = COMDotNetTypeConverter.PointNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PixelLocationRaw of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the ptPixelLocationRaw property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public Point PixelLocationRaw
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.PixelLocationRaw);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PixelLocationRaw = COMDotNetTypeConverter.PointNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PointerDeviceRect of the sourceDevice property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).</summary>
	public Rectangle PointerDeviceRect
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.PointerDeviceRect);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PointerDeviceRect = COMDotNetTypeConverter.RectangleNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PointerFlags of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the pointerFlags property of the <c>POINTER_INFO</c> struct. The values are defined by the <c>POINTER_FLAGS</c> constants in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint PointerFlags
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PointerFlags;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PointerFlags = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PointerId of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the pointerId property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint PointerId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PointerId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PointerId = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the PointerKind of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the pointerKind property of the <c>POINTER_INFO</c> struct. The values are defined by the <c>POINTER_INPUT_KIND</c> enum in the Windows SDK (_winuser.h_). Supports PT_PEN and PT_TOUCH.
	/// </remarks>
	public uint PointerKind
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.PointerKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.PointerKind = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the Time of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the dwTime property of the <c>POINTER_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint Time
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.Time;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.Time = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the TouchContact of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the rcContact property of the <c>POINTER_TOUCH_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public Rectangle TouchContact
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.TouchContact);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.TouchContact = COMDotNetTypeConverter.RectangleNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the TouchContactRaw of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the rcContactRaw property of the <c>POINTER_TOUCH_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public Rectangle TouchContactRaw
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.TouchContactRaw);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.TouchContactRaw = COMDotNetTypeConverter.RectangleNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the TouchFlags of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the touchFlags property of the <c>POINTER_TOUCH_INFO</c> struct. The values are defined by the TOUCH_FLAGS constants in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint TouchFlags
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.TouchFlags;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.TouchFlags = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the TouchMask of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the touchMask property of the <c>POINTER_TOUCH_INFO</c> struct. The values are defined by the TOUCH_MASK constants in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint TouchMask
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.TouchMask;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.TouchMask = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the TouchOrientation of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the orientation property of the <c>POINTER_TOUCH_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint TouchOrientation
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.TouchOrientation;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.TouchOrientation = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the TouchPressure of the pointer event.
	/// </summary><remarks>
	/// This corresponds to the pressure property of the <c>POINTER_TOUCH_INFO</c> struct as defined in the Windows SDK (_winuser.h_).
	/// </remarks>
	public uint TouchPressure
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PointerInfo.TouchPressure;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PointerInfo.TouchPressure = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PointerInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2PointerInfo(object rawCoreWebView2PointerInfo)
	{
		_rawNative = rawCoreWebView2PointerInfo;
	}
}
