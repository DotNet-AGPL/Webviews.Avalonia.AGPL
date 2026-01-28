using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("AB71D500-0820-4A52-809C-48DB04FF93BF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2NonClientRegionChangedEventArgs
{
	[DispId(1610678272)]
	COREWEBVIEW2_NON_CLIENT_REGION_KIND RegionKind
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
