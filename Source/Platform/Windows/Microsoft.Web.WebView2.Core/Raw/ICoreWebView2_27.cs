using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00FBE33B-8C07-517C-AA23-0DDD4B5F6FA0")]
[TypeIdentifier]
public interface ICoreWebView2_27 : ICoreWebView2_26
{
	void _VtblGap1_130();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_ScreenCaptureStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ScreenCaptureStartingEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_ScreenCaptureStarting([In] EventRegistrationToken token);
}
