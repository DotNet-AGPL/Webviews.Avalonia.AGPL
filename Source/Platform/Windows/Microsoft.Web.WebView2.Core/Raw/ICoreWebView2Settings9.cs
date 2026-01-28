using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0528A73B-E92D-49F4-927A-E547DDDAA37D")]
[TypeIdentifier]
public interface ICoreWebView2Settings9 : ICoreWebView2Settings8
{
	void _VtblGap1_34();

	[DispId(1611202560)]
	int IsNonClientRegionSupportEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}
}
