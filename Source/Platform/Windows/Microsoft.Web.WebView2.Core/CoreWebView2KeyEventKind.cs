namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the key event type that triggered an `AcceleratorKeyPressed`
/// event.</summary>
public enum CoreWebView2KeyEventKind
{
	/// <summary>Specifies that the key event type corresponds to window message
	/// `WM_KEYDOWN`.</summary>
	KeyDown,
	/// <summary>Specifies that the key event type corresponds to window message
	/// `WM_KEYUP`.</summary>
	KeyUp,
	/// <summary>Specifies that the key event type corresponds to window message
	/// `WM_SYSKEYDOWN`.</summary>
	SystemKeyDown,
	/// <summary>Specifies that the key event type corresponds to window message
	/// `WM_SYSKEYUP`.</summary>
	SystemKeyUp
}
