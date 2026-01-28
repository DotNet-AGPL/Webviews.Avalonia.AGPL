using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Contains the information packed into the LPARAM sent to a Win32 key event.
/// </summary>
/// <remarks>
/// For more information about <c>WM_KEYDOWN</c>, navigate to [WM_KEYDOWN message](/windows/win32/inputdev/wm-keydown).
/// </remarks>
public struct CoreWebView2PhysicalKeyStatus(COREWEBVIEW2_PHYSICAL_KEY_STATUS rawStruct)
{
	/// <summary>
	/// Specifies the repeat count for the current message.
	/// </summary>
	public uint RepeatCount = rawStruct.RepeatCount;

	/// <summary>
	/// Specifies the scan code.
	/// </summary>
	public uint ScanCode = rawStruct.ScanCode;

	/// <summary>
	/// Indicates that the key is an extended key.
	/// </summary>
	public int IsExtendedKey = rawStruct.IsExtendedKey;

	/// <summary>
	/// Indicates that a menu key is held down (context code).
	/// </summary>
	public int IsMenuKeyDown = rawStruct.IsMenuKeyDown;

	/// <summary>
	/// Indicates that the key was held down.
	/// </summary>
	public int WasKeyDown = rawStruct.WasKeyDown;

	/// <summary>
	/// Indicates that the key was released.
	/// </summary>
	public int IsKeyReleased = rawStruct.IsKeyReleased;
}
