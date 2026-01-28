using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0054F514-9A8E-5876-AED5-30B37F8C86A5")]
[TypeIdentifier]
public interface ICoreWebView2FindActiveMatchIndexChangedEventHandler
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Find sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
