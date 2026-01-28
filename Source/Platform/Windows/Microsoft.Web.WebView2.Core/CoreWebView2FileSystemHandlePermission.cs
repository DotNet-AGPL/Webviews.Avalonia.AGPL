namespace Microsoft.Web.WebView2.Core;

/// <summary>Allowed permissions of a CoreWebView2FileSystemHandle as described in
/// [FileSystemHandle.requestPermission()](https://developer.mozilla.org/docs/Web/API/FileSystemHandle/requestPermission).</summary>
public enum CoreWebView2FileSystemHandlePermission
{
	/// <summary>Read-only permission for FileSystemHandle.</summary>
	ReadOnly,
	/// <summary>Read and write permissions for FileSystemHandle.</summary>
	ReadWrite
}
