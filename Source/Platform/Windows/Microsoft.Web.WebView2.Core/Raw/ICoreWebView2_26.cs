using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("806268B8-F897-5685-88E5-C45FCA0B1A48")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_26 : ICoreWebView2_25
{
	void _VtblGap1_128();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_SaveFileSecurityCheckStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2SaveFileSecurityCheckStartingEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_SaveFileSecurityCheckStarting([In] EventRegistrationToken token);
}
