using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("AF4C4C2E-45DB-11EE-BE56-0242AC120002")]
[TypeIdentifier]
public interface ICoreWebView2ProcessExtendedInfo
{
	[DispId(1610678272)]
	ICoreWebView2ProcessInfo ProcessInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610678273)]
	ICoreWebView2FrameInfoCollection AssociatedFrameInfos
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
