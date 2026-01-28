using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B5A86092-DF50-5B4F-A17B-6C8F8B40B771")]
[TypeIdentifier]
public interface ICoreWebView2_25 : ICoreWebView2_24
{
	void _VtblGap1_125();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_SaveAsUIShowing([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2SaveAsUIShowingEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_SaveAsUIShowing([In] EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void ShowSaveAsUI([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ShowSaveAsUICompletedHandler handler);
}
