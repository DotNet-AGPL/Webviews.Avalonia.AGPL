using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("508F0DB5-90C4-5872-90A7-267A91377502")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_23 : ICoreWebView2_22
{
	void _VtblGap1_122();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void PostWebMessageAsJsonWithAdditionalObjects([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ObjectCollectionView additionalObjects);
}
