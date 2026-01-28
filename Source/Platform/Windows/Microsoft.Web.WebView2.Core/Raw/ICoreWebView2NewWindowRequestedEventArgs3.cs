using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("842BED3C-6AD6-4DD9-B938-28C96667AD66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2NewWindowRequestedEventArgs3 : ICoreWebView2NewWindowRequestedEventArgs2
{
	void _VtblGap1_9();

	[DispId(1610809344)]
	ICoreWebView2FrameInfo OriginalSourceFrameInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
