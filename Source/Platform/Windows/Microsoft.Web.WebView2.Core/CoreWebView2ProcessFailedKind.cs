namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the process failure type used in the
/// `ICoreWebView2ProcessFailedEventArgs` interface. The values in this enum
/// make reference to the process kinds in the Chromium architecture. For more
/// information about what these processes are and what they do, see
/// [Browser Architecture - Inside look at modern web browser](https://developers.google.com/web/updates/2018/09/inside-browser-part1).</summary>
public enum CoreWebView2ProcessFailedKind
{
	/// <summary>Indicates that the browser process ended unexpectedly.  The WebView
	/// automatically moves to the Closed state.  The app has to recreate a new
	/// WebView to recover from this failure.</summary>
	BrowserProcessExited,
	/// <summary>Indicates that the main frame's render process ended unexpectedly. Any
	/// subframes in the WebView will be gone too.  A new render process is
	/// created automatically and navigated to an error page. You can use the
	/// `Reload` method to try to recover from this failure. Alternatively, you
	/// can `Close` and recreate the WebView.</summary>
	RenderProcessExited,
	/// <summary>Indicates that the main frame's render process is unresponsive. Renderer
	/// process unresponsiveness can happen for the following reasons:
	/// There is a **long-running script** being executed. For example, the
	/// web content in your WebView might be performing a synchronous XHR, or have
	/// entered an infinite loop. Or, the **system is busy**.
	/// The `ProcessFailed` event will continue to be raised every few seconds
	/// until the renderer process has become responsive again. The application
	/// can consider taking action if the event keeps being raised. For example,
	/// the application might show UI for the user to decide to keep waiting or
	/// reload the page, or navigate away.</summary>
	RenderProcessUnresponsive,
	/// <summary>Indicates that a frame-only render process ended unexpectedly. The process
	/// exit does not affect the top-level document, only a subset of the
	/// subframes within it. The content in these frames is replaced with an error
	/// page in the frame. Your application can communicate with the main frame to
	/// recover content in the impacted frames, using
	/// `ICoreWebView2ProcessFailedEventArgs2::FrameInfosForFailedProcess` to get
	/// information about the impacted frames.</summary>
	FrameRenderProcessExited,
	/// <summary>Indicates that a utility process ended unexpectedly. The failed process
	/// is recreated automatically. Your application does **not** need to handle
	/// recovery for this event, but can use `ICoreWebView2ProcessFailedEventArgs`
	/// and `ICoreWebView2ProcessFailedEventArgs2` to collect information about
	/// the failure, including `ProcessDescription`.</summary>
	UtilityProcessExited,
	/// <summary>Indicates that a sandbox helper process ended unexpectedly. This failure
	/// is not fatal. Your application does **not** need to handle recovery for
	/// this event, but can use `ICoreWebView2ProcessFailedEventArgs` and
	/// `ICoreWebView2ProcessFailedEventArgs2` to collect information about
	/// the failure.</summary>
	SandboxHelperProcessExited,
	/// <summary>Indicates that the GPU process ended unexpectedly. The failed process
	/// is recreated automatically. Your application does **not** need to handle
	/// recovery for this event, but can use `ICoreWebView2ProcessFailedEventArgs`
	/// and `ICoreWebView2ProcessFailedEventArgs2` to collect information about
	/// the failure.</summary>
	GpuProcessExited,
	/// <summary>Indicates that a PPAPI plugin process ended unexpectedly. This failure
	/// is not fatal. Your application does **not** need to handle recovery for
	/// this event, but can use `ICoreWebView2ProcessFailedEventArgs` and
	/// `ICoreWebView2ProcessFailedEventArgs2` to collect information about
	/// the failure, including `ProcessDescription`.</summary>
	PpapiPluginProcessExited,
	/// <summary>Indicates that a PPAPI plugin broker process ended unexpectedly. This failure
	/// is not fatal. Your application does **not** need to handle recovery for
	/// this event, but can use `ICoreWebView2ProcessFailedEventArgs` and
	/// `ICoreWebView2ProcessFailedEventArgs2` to collect information about
	/// the failure.</summary>
	PpapiBrokerProcessExited,
	/// <summary>Indicates that a process of unspecified kind ended unexpectedly. Your
	/// application can use `ICoreWebView2ProcessFailedEventArgs` and
	/// `ICoreWebView2ProcessFailedEventArgs2` to collect information about
	/// the failure.</summary>
	UnknownProcessExited
}
