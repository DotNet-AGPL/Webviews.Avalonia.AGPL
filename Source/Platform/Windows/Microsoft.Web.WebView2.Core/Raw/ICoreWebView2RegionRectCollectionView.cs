using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("333353B8-48BF-4449-8FCC-22697FAF5753")]
[TypeIdentifier]
public interface ICoreWebView2RegionRectCollectionView
{
	[DispId(1610678272)]
	uint Count
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	tagRECT GetValueAtIndex([In] uint index);
}
