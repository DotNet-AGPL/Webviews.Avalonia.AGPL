using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3598CFA2-D85D-5A9F-9228-4DDE1F59EC64")]
[TypeIdentifier]
public interface ICoreWebView2Frame7 : ICoreWebView2Frame6
{
	void _VtblGap1_27();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_FrameCreated([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameChildFrameCreatedEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_FrameCreated([In] EventRegistrationToken token);
}
