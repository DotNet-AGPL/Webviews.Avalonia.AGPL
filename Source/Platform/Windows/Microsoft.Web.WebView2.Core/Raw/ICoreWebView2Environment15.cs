using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2AC5EBFB-E654-5961-A667-7971885C7B27")]
[TypeIdentifier]
public interface ICoreWebView2Environment15 : ICoreWebView2Environment14
{
	void _VtblGap1_26();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2FindOptions CreateFindOptions();
}
