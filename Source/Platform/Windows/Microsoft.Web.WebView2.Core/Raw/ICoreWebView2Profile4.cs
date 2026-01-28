using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8F4AE680-192E-4EC8-833A-21CFADAEF628")]
[TypeIdentifier]
public interface ICoreWebView2Profile4 : ICoreWebView2Profile3
{
	void _VtblGap1_12();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void SetPermissionState([In] COREWEBVIEW2_PERMISSION_KIND PermissionKind, [In][MarshalAs(UnmanagedType.LPWStr)] string origin, [In] COREWEBVIEW2_PERMISSION_STATE State, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2SetPermissionStateCompletedHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void GetNonDefaultPermissionSettings([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler handler);
}
