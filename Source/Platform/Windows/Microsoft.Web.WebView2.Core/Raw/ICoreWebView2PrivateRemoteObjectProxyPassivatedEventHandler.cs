using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6996FC3E-DCEB-4BAA-819E-061648BF1A37")]
[TypeIdentifier]
public interface ICoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateRemoteObjectProxy sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
