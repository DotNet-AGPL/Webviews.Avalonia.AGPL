using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F5596F62-3DE5-47B1-91E8-A4104B596B96")]
[TypeIdentifier]
public interface ICoreWebView2PermissionSettingCollectionView
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2PermissionSetting GetValueAtIndex([In] uint index);

	[DispId(1610678273)]
	uint Count
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
