using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0F36FD87-4F69-4415-98DA-888F89FB9A33")]
[TypeIdentifier]
public interface ICoreWebView2ObjectCollectionView
{
	[DispId(1610678272)]
	uint Count
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object GetValueAtIndex([In] uint index);
}
