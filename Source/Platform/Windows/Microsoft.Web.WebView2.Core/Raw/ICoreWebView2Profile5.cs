using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2EE5B76E-6E80-4DF2-BCD3-D4EC3340A01B")]
[TypeIdentifier]
public interface ICoreWebView2Profile5 : ICoreWebView2Profile4
{
	void _VtblGap1_14();

	[DispId(1610940416)]
	ICoreWebView2CookieManager CookieManager
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
