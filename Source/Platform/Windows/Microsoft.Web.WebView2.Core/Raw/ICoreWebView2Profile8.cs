using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("FBF70C2F-EB1F-4383-85A0-163E92044011")]
[TypeIdentifier]
public interface ICoreWebView2Profile8 : ICoreWebView2Profile7
{
	void _VtblGap1_21();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void Delete();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_Deleted([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProfileDeletedEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_Deleted([In] EventRegistrationToken token);
}
