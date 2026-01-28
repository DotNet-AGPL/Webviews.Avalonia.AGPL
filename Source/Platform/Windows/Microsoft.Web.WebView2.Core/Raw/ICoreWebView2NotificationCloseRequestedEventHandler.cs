using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("47C32D23-1E94-4733-85F1-D9BF4ACD0974")]
[TypeIdentifier]
public interface ICoreWebView2NotificationCloseRequestedEventHandler
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Notification sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
