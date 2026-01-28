using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7B4C7906-A1AA-4CB4-B723-DB09F813D541")]
[TypeIdentifier]
public interface ICoreWebView2Profile7 : ICoreWebView2Profile6
{
	void _VtblGap1_19();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void AddBrowserExtension([In][MarshalAs(UnmanagedType.LPWStr)] string extensionFolderPath, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProfileAddBrowserExtensionCompletedHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void GetBrowserExtensions([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler handler);
}
