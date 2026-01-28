using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C4980DEA-587B-43B9-8143-3EF3BF552D95")]
[TypeIdentifier]
public interface ICoreWebView2_21 : ICoreWebView2_20
{
	void _VtblGap1_119();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void ExecuteScriptWithResult([In][MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptWithResultCompletedHandler handler);
}
