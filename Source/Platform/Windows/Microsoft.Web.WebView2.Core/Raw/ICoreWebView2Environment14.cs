using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("A5E9FAD9-C875-59DA-9BD7-473AA5CA1CEF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment14 : ICoreWebView2Environment13
{
	void _VtblGap1_23();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2FileSystemHandle CreateWebFileSystemFileHandle([In][MarshalAs(UnmanagedType.LPWStr)] string Path, [In] COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2FileSystemHandle CreateWebFileSystemDirectoryHandle([In][MarshalAs(UnmanagedType.LPWStr)] string Path, [In] COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission);
}
