using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("06C991D8-9E7E-11ED-A8FC-0242AC120002")]
[TypeIdentifier]
public interface ICoreWebView2ControllerOptions2 : ICoreWebView2ControllerOptions
{
	void _VtblGap1_4();

	[DispId(1610743808)]
	string ScriptLocale
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.LPWStr)]
		set;
	}
}
