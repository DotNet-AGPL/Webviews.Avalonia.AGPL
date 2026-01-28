using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("39A7AD55-4287-5CC1-88A1-C6F458593824")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_24 : ICoreWebView2_23
{
	void _VtblGap1_123();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_NotificationReceived([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NotificationReceivedEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_NotificationReceived([In] EventRegistrationToken token);
}
