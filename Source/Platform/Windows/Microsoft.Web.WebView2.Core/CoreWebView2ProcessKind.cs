namespace Microsoft.Web.WebView2.Core;

/// <summary>Indicates the process type used in the ICoreWebView2ProcessInfo interface.</summary>
public enum CoreWebView2ProcessKind
{
	/// <summary>Indicates the browser process kind.</summary>
	Browser,
	/// <summary>Indicates the render process kind.</summary>
	Renderer,
	/// <summary>Indicates the utility process kind.</summary>
	Utility,
	/// <summary>Indicates the sandbox helper process kind.</summary>
	SandboxHelper,
	/// <summary>Indicates the GPU process kind.</summary>
	Gpu,
	/// <summary>Indicates the PPAPI plugin process kind.</summary>
	PpapiPlugin,
	/// <summary>Indicates the PPAPI plugin broker process kind.</summary>
	PpapiBroker
}
