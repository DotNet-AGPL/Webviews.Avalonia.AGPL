using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("21EB052F-AD39-555E-824A-C87B091D4D36")]
[TypeIdentifier]
public interface ICoreWebView2ControllerOptions4 : ICoreWebView2ControllerOptions3
{
	void _VtblGap1_8();

	[DispId(1610874880)]
	int AllowHostInputProcessing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}
}
