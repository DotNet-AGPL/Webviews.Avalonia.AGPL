namespace Microsoft.Web.WebView2.Core;

/// <summary>Mouse event type used by SendMouseInput to convey the type of mouse event
/// being sent to WebView. The values of this enum align with the matching
/// WM_* window messages.</summary>
public enum CoreWebView2MouseEventKind
{
	/// <summary>Mouse horizontal wheel scroll event, WM_MOUSEHWHEEL.</summary>
	HorizontalWheel = 526,
	/// <summary>Left button double click mouse event, WM_LBUTTONDBLCLK.</summary>
	LeftButtonDoubleClick = 515,
	/// <summary>Left button down mouse event, WM_LBUTTONDOWN.</summary>
	LeftButtonDown = 513,
	/// <summary>Left button up mouse event, WM_LBUTTONUP.</summary>
	LeftButtonUp = 514,
	/// <summary>Mouse leave event, WM_MOUSELEAVE.</summary>
	Leave = 675,
	/// <summary>Middle button double click mouse event, WM_MBUTTONDBLCLK.</summary>
	MiddleButtonDoubleClick = 521,
	/// <summary>Middle button down mouse event, WM_MBUTTONDOWN.</summary>
	MiddleButtonDown = 519,
	/// <summary>Middle button up mouse event, WM_MBUTTONUP.</summary>
	MiddleButtonUp = 520,
	/// <summary>Mouse move event, WM_MOUSEMOVE.</summary>
	Move = 512,
	/// <summary>Right button double click mouse event, WM_RBUTTONDBLCLK.</summary>
	RightButtonDoubleClick = 518,
	/// <summary>Right button down mouse event, WM_RBUTTONDOWN.</summary>
	RightButtonDown = 516,
	/// <summary>Right button up mouse event, WM_RBUTTONUP.</summary>
	RightButtonUp = 517,
	/// <summary>Mouse wheel scroll event, WM_MOUSEWHEEL.</summary>
	Wheel = 522,
	/// <summary>First or second X button double click mouse event, WM_XBUTTONDBLCLK.</summary>
	XButtonDoubleClick = 525,
	/// <summary>First or second X button down mouse event, WM_XBUTTONDOWN.</summary>
	XButtonDown = 523,
	/// <summary>First or second X button up mouse event, WM_XBUTTONUP.</summary>
	XButtonUp = 524,
	/// <summary>Mouse Right Button Down event over a nonclient area, WM_NCRBUTTONDOWN.</summary>
	NonClientRightButtonDown = 164,
	/// <summary>Mouse Right Button up event over a nonclient area, WM_NCRBUTTONUP.</summary>
	NonClientRightButtonUp = 165
}
