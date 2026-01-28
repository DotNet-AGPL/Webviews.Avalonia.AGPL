using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("0DE611FD-31E9-5DDC-9D71-95EDA26EFF32")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Frame6 : ICoreWebView2Frame5
{
	void _VtblGap1_25();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_ScreenCaptureStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameScreenCaptureStartingEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_ScreenCaptureStarting([In] EventRegistrationToken token);
}
