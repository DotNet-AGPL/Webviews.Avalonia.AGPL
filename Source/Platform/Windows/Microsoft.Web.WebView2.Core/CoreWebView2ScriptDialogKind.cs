namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the JavaScript dialog type used in the
/// `ICoreWebView2ScriptDialogOpeningEventHandler` interface.</summary>
public enum CoreWebView2ScriptDialogKind
{
	/// <summary>Indicates that the dialog uses the `window.alert` JavaScript function.</summary>
	Alert,
	/// <summary>Indicates that the dialog uses the `window.confirm` JavaScript function.</summary>
	Confirm,
	/// <summary>Indicates that the dialog uses the `window.prompt` JavaScript function.</summary>
	Prompt,
	/// <summary>Indicates that the dialog uses the `beforeunload` JavaScript event.</summary>
	Beforeunload
}
