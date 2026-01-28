using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9C562C24-B219-4D7F-92F6-B187FBBADD56")]
[TypeIdentifier]
public interface ICoreWebView2WebResourceRequestedEventArgs2 : ICoreWebView2WebResourceRequestedEventArgs
{
	void _VtblGap1_5();

	[DispId(1610743808)]
	COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS RequestedSourceKind
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
