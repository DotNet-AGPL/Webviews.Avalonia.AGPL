namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2RestartRequestedEventArgs
{
	internal object _rawNative;

	internal CoreWebView2RestartRequestedEventArgs(object rawCoreWebView2RestartRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2RestartRequestedEventArgs;
	}
}
