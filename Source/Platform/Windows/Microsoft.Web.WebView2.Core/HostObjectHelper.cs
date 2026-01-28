using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// This class is deprecated; use CoreWebView2PrivateHostObjectHelper instead.
/// </summary>
[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class HostObjectHelper
{
	private CoreWebView2PrivateHostObjectHelper _helper = new CoreWebView2PrivateHostObjectHelper();

	public bool IsMethod(object obj, string name)
	{
		return _helper.IsMethodMember(obj, name) != 0;
	}
}
