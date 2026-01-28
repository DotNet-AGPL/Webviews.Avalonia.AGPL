using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Mouse event virtual keys associated with a COREWEBVIEW2_MOUSE_EVENT_KIND for
/// SendMouseInput. These values can be combined into a bit flag if more than
/// one virtual key is pressed for the event. The values of this enum align
/// with the matching MK_* mouse keys.</summary>
[Flags]
public enum CoreWebView2MouseEventVirtualKeys
{
	/// <summary>No additional keys pressed.</summary>
	None = 0,
	/// <summary>Left mouse button is down, MK_LBUTTON.</summary>
	LeftButton = 1,
	/// <summary>Right mouse button is down, MK_RBUTTON.</summary>
	RightButton = 2,
	/// <summary>SHIFT key is down, MK_SHIFT.</summary>
	Shift = 4,
	/// <summary>CTRL key is down, MK_CONTROL.</summary>
	Control = 8,
	/// <summary>Middle mouse button is down, MK_MBUTTON.</summary>
	MiddleButton = 0x10,
	/// <summary>First X button is down, MK_XBUTTON1</summary>
	XButton1 = 0x20,
	/// <summary>Second X button is down, MK_XBUTTON2</summary>
	XButton2 = 0x40
}
