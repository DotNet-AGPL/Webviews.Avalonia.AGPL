using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9E6B0E8F-86AD-4E81-8147-A9B5EDB68650")]
[TypeIdentifier]
public interface ICoreWebView2Settings8 : ICoreWebView2Settings7
{
	void _VtblGap1_32();

	[DispId(1611137024)]
	int IsReputationCheckingRequired
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}
}
