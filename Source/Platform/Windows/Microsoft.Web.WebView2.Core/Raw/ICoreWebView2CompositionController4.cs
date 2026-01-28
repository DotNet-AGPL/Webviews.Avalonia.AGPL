using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("7C367B9B-3D2B-450F-9E58-D61A20F486AA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CompositionController4 : ICoreWebView2CompositionController3
{
	void _VtblGap1_13();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	COREWEBVIEW2_NON_CLIENT_REGION_KIND GetNonClientRegionAtPoint([In] tagPOINT point);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2RegionRectCollectionView QueryNonClientRegion([In] COREWEBVIEW2_NON_CLIENT_REGION_KIND Kind);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_NonClientRegionChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NonClientRegionChangedEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_NonClientRegionChanged([In] EventRegistrationToken token);
}
