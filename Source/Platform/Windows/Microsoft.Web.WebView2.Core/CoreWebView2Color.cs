using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>A value representing RGBA color (Red, Green, Blue, Alpha) for WebView2.
/// Each component takes a value from 0 to 255, with 0 being no intensity
/// and 255 being the highest intensity.</summary>
public struct CoreWebView2Color(COREWEBVIEW2_COLOR rawStruct)
{
	/// <summary>Specifies the intensity of the Alpha ie. opacity value. 0 is transparent,
	/// 255 is opaque.</summary>
	public byte A = rawStruct.A;

	/// <summary>Specifies the intensity of the Red color.</summary>
	public byte R = rawStruct.R;

	/// <summary>Specifies the intensity of the Green color.</summary>
	public byte G = rawStruct.G;

	/// <summary>Specifies the intensity of the Blue color.</summary>
	public byte B = rawStruct.B;
}
