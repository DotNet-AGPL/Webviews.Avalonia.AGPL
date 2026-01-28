using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5833FDF2-5E56-49D7-A807-DE4F0C0DB311")]
[TypeIdentifier]
public interface ICoreWebView2PrivateLargeUnmanagedResource
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	long GetMemoryUsage();
}
