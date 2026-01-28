using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C65100AC-0DE2-5551-A362-23D9BD1D0E1F")]
[TypeIdentifier]
public interface ICoreWebView2FileSystemHandle
{
	[DispId(1610678272)]
	COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND Kind
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(1610678273)]
	string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	[DispId(1610678274)]
	COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
