using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// This class is an extension of the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> class to support visual hosting.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2CompositionController : CoreWebView2Controller
{
	internal ICoreWebView2CompositionController _nativeICoreWebView2CompositionControllerValue;

	private EventRegistrationToken _CursorChangedToken;

	private EventHandler<object> privateCursorChanged;

	internal ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2Value;

	internal ICoreWebView2CompositionController3 _nativeICoreWebView2CompositionController3Value;

	internal ICoreWebView2CompositionController4 _nativeICoreWebView2CompositionController4Value;

	private EventRegistrationToken _NonClientRegionChangedToken;

	private EventHandler<CoreWebView2NonClientRegionChangedEventArgs> privateNonClientRegionChanged;

	internal ICoreWebView2CompositionController _nativeICoreWebView2CompositionController
	{
		get
		{
			if (_nativeICoreWebView2CompositionControllerValue == null)
			{
				try
				{
					_nativeICoreWebView2CompositionControllerValue = (ICoreWebView2CompositionController)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CompositionControllerValue;
		}
		set
		{
			_nativeICoreWebView2CompositionControllerValue = value;
		}
	}

	/// <summary>
	/// Gets the current cursor that WebView thinks it should be.
	/// </summary><remarks>
	/// The cursor should be set in WM_SETCURSOR through Mouse.SetCursor or set on the corresponding parent/ancestor HWND of the WebView through ::SetClassLongPtr. The HCURSOR can be freed so CopyCursor/DestroyCursor is recommended to keep your own copy if you are doing more than immediately setting the cursor.
	/// </remarks>
	public IntPtr Cursor
	{
		get
		{
			try
			{
				return _nativeICoreWebView2CompositionController.Cursor;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the root visual in the hosting app's visual tree.
	/// </summary><remarks>
	/// This visual is where the WebView will connect its visual tree. The app uses this visual to position the WebView within the app. The app still needs to use the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds" /> property to size the WebView. The RootVisualTarget property can be an IDCompositionVisual or a Windows::UI::Composition::ContainerVisual. WebView will connect its visual tree to the provided visual before returning from the property setter. The app needs to commit on its device setting the RootVisualTarget property. The RootVisualTarget property supports being set to <c>null</c> to disconnect the WebView from the app's visual tree.
	/// </remarks>
	public object RootVisualTarget
	{
		get
		{
			try
			{
				return _nativeICoreWebView2CompositionController.RootVisualTarget;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2CompositionController.RootVisualTarget = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the current system cursor ID reported by the underlying rendering engine for WebView.</summary>
	public uint SystemCursorId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2CompositionController.SystemCursorId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2
	{
		get
		{
			if (_nativeICoreWebView2CompositionController2Value == null)
			{
				try
				{
					_nativeICoreWebView2CompositionController2Value = (ICoreWebView2CompositionController2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CompositionController2Value;
		}
		set
		{
			_nativeICoreWebView2CompositionController2Value = value;
		}
	}

	internal ICoreWebView2CompositionController3 _nativeICoreWebView2CompositionController3
	{
		get
		{
			if (_nativeICoreWebView2CompositionController3Value == null)
			{
				try
				{
					_nativeICoreWebView2CompositionController3Value = (ICoreWebView2CompositionController3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CompositionController3Value;
		}
		set
		{
			_nativeICoreWebView2CompositionController3Value = value;
		}
	}

	internal ICoreWebView2CompositionController4 _nativeICoreWebView2CompositionController4
	{
		get
		{
			if (_nativeICoreWebView2CompositionController4Value == null)
			{
				try
				{
					_nativeICoreWebView2CompositionController4Value = (ICoreWebView2CompositionController4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CompositionController4Value;
		}
		set
		{
			_nativeICoreWebView2CompositionController4Value = value;
		}
	}

	/// <summary>
	/// The event is raised when WebView thinks the cursor should be changed.
	/// </summary><remarks>
	/// For example, when the mouse cursor is currently the default cursor but is then moved over text, it may try to change to the IBeam cursor.
	/// It is expected for the developer to send <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.Leave" /> messages (in addition to <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.Move" /> messages) through <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendMouseInput(Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind,Microsoft.Web.WebView2.Core.CoreWebView2MouseEventVirtualKeys,System.UInt32,System.Drawing.Point)" />. This is to ensure that the mouse is actually within the WebView that sends out CursorChanged events.
	/// </remarks>
	public event EventHandler<object> CursorChanged
	{
		add
		{
			if (privateCursorChanged == null)
			{
				try
				{
					_nativeICoreWebView2CompositionController.add_CursorChanged(new CoreWebView2CursorChangedEventHandler(OnCursorChanged), out _CursorChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateCursorChanged = (EventHandler<object>)Delegate.Combine(privateCursorChanged, value);
		}
		remove
		{
			privateCursorChanged = (EventHandler<object>)Delegate.Remove(privateCursorChanged, value);
			if (privateCursorChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2CompositionController.remove_CursorChanged(_CursorChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// This event is raised when elements on the page with "app-region" CSS property values corresponding to non-client regions change. Use the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2NonClientRegionChangedEventArgs.RegionKind" /> to see the kind of non-client region that changed.</summary>
	public event EventHandler<CoreWebView2NonClientRegionChangedEventArgs> NonClientRegionChanged
	{
		add
		{
			if (privateNonClientRegionChanged == null)
			{
				try
				{
					_nativeICoreWebView2CompositionController4.add_NonClientRegionChanged(new CoreWebView2NonClientRegionChangedEventHandler(OnNonClientRegionChanged), out _NonClientRegionChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNonClientRegionChanged = (EventHandler<CoreWebView2NonClientRegionChangedEventArgs>)Delegate.Combine(privateNonClientRegionChanged, value);
		}
		remove
		{
			privateNonClientRegionChanged = (EventHandler<CoreWebView2NonClientRegionChangedEventArgs>)Delegate.Remove(privateNonClientRegionChanged, value);
			if (privateNonClientRegionChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2CompositionController4.remove_NonClientRegionChanged(_NonClientRegionChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2CompositionController(object rawCoreWebView2CompositionController)
		: base(rawCoreWebView2CompositionController)
	{
	}

	internal void OnCursorChanged(object args)
	{
		privateCursorChanged?.Invoke(this, args);
	}

	/// <summary /><param name="eventKind">The mouse event kind.</param><param name="virtualKeys">The virtual keys associated with the <c>eventKind</c>.</param><param name="mouseData">The amount of wheel movement.</param><param name="point">The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the <c>eventKind</c>.</param>
	/// Sends mouse input to the WebView.
	/// <remarks>
	/// If <c>eventKind</c> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.HorizontalWheel" /> or <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.Wheel" />, then <c>mouseData</c> specifies the amount of wheel movement.
	/// A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward, toward the user. One wheel click is defined as WHEEL_DELTA, which is 120. If <c>eventKind</c> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.XButtonDoubleClick" />, <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.XButtonDown" />, or <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.XButtonUp" />, then <c>mouseData</c> specifies which X buttons were pressed or released. This value should be 1 if the first X button is pressed/released and 2 if the second X button is pressed/released. If <c>eventKind</c> is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.Leave" />, then <c>virtualKeys</c>, <c>mouseData</c>, and point should all be zero. If <c>eventKind</c> is any other value, then <c>mouseData</c> should be zero. <c>point</c> is expected to be in the client coordinate space of the WebView. To track mouse events that start in the WebView and can potentially move outside of the WebView and host application, calling SetCapture and ReleaseCapture is recommended. To dismiss hover popups, it is also recommended to send <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind.Leave" /> messages.
	/// </remarks>
	public void SendMouseInput(CoreWebView2MouseEventKind eventKind, CoreWebView2MouseEventVirtualKeys virtualKeys, uint mouseData, Point point)
	{
		try
		{
			_nativeICoreWebView2CompositionController.SendMouseInput((COREWEBVIEW2_MOUSE_EVENT_KIND)eventKind, (COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS)virtualKeys, mouseData, COMDotNetTypeConverter.PointNetToCOM(point));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Sends pen or pointer input to the WebView.
	/// </summary><param name="eventKind">The pointer event kind.</param><param name="pointerInfo">The pointer information.</param><remarks>
	/// Accepts touch or pen pointer input of kinds defined in <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind" />.
	/// Any pointer input from the system must be converted into a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo" /> first.
	/// </remarks>
	public void SendPointerInput(CoreWebView2PointerEventKind eventKind, CoreWebView2PointerInfo pointerInfo)
	{
		try
		{
			_nativeICoreWebView2CompositionController.SendPointerInput((COREWEBVIEW2_POINTER_EVENT_KIND)eventKind, pointerInfo._nativeICoreWebView2PointerInfo);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Call this method to inform the CoreWebView2CompositionController that a drag operation has left the WebView.
	/// </summary><remarks>
	/// Corresponds to the [ICoreDropOperationTarget.LeaveAsync](/uwp/api/windows.applicationmodel.datatransfer.dragdrop.core.icoredropoperationtarget.leaveasync) method when performing a drag operation into the WebView.
	/// </remarks>
	public void DragLeave()
	{
		try
		{
			_nativeICoreWebView2CompositionController3.DragLeave();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnNonClientRegionChanged(CoreWebView2NonClientRegionChangedEventArgs args)
	{
		privateNonClientRegionChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Call this method to perform hit-testing inside of your message loop when the message is WM_NCHITTEST.
	/// </summary><param name="point">The point parameter is expected to be in the client coordinate space of the WebView2.</param><returns>The type of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2NonClientRegionKind" /> region which contains the point.</returns>
	public CoreWebView2NonClientRegionKind GetNonClientRegionAtPoint(Point point)
	{
		try
		{
			return (CoreWebView2NonClientRegionKind)_nativeICoreWebView2CompositionController4.GetNonClientRegionAtPoint(COMDotNetTypeConverter.PointNetToCOM(point));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// When a given </summary><param name="Kind"> region kind of type <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2NonClientRegionKind" /></param><returns>This method returns a vector of rectangles which corresponds to the specified region.</returns><remarks>
	/// This method can be used inside the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.NonClientRegionChanged" /> event handler to get the list of rects for the specific region that changed.
	/// </remarks>
	public IReadOnlyList<Rectangle> QueryNonClientRegion(CoreWebView2NonClientRegionKind Kind)
	{
		try
		{
			return COMDotNetTypeConverter.RectangleCollectionCOMToNet(_nativeICoreWebView2CompositionController4.QueryNonClientRegion((COREWEBVIEW2_NON_CLIENT_REGION_KIND)Kind));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2CompositionController members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
