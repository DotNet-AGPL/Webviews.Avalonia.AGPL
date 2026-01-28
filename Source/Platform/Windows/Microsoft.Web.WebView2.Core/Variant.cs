using System;

namespace Microsoft.Web.WebView2.Core;

internal struct Variant
{
	public ushort vt;

	public ushort wReserved1;

	public ushort wReserved2;

	public ushort wReserved3;

	public IntPtr pVal;

	public IntPtr pRecInfo;
}
