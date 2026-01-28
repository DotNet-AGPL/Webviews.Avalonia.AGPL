namespace Microsoft.Web.WebView2.Core;

/// <summary>Pointer event type used by SendPointerInput to convey the type of pointer
/// event being sent to WebView. The values of this enum align with the
/// matching WM_POINTER* window messages.</summary>
public enum CoreWebView2PointerEventKind
{
	/// <summary>Corresponds to WM_POINTERACTIVATE.</summary>
	Activate = 587,
	/// <summary>Corresponds to WM_POINTERDOWN.</summary>
	Down = 582,
	/// <summary>Corresponds to WM_POINTERENTER.</summary>
	Enter = 585,
	/// <summary>Corresponds to WM_POINTERLEAVE.</summary>
	Leave = 586,
	/// <summary>Corresponds to WM_POINTERUP.</summary>
	Up = 583,
	/// <summary>Corresponds to WM_POINTERUPDATE.</summary>
	Update = 581
}
