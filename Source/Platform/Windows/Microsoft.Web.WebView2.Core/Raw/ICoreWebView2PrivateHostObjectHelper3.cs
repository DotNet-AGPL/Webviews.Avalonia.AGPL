using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("BFFD8CC7-46CD-4D4F-B688-FE5152DBD92F")]
[TypeIdentifier]
public interface ICoreWebView2PrivateHostObjectHelper3
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object CreateBuiltInDispatch([In][MarshalAs(UnmanagedType.Struct)] ref object originalHostObject);
}
