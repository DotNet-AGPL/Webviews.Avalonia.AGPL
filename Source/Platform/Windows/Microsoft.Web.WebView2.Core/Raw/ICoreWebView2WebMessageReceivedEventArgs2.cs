using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("06FC7AB7-C90C-4297-9389-33CA01CF6D5E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2WebMessageReceivedEventArgs2 : ICoreWebView2WebMessageReceivedEventArgs
{
	void _VtblGap1_3();

	[DispId(1610743808)]
	ICoreWebView2ObjectCollectionView AdditionalObjects
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
