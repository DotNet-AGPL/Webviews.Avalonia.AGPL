namespace Microsoft.Web.WebView2.Core;

/// <summary>Kind of CoreWebView2FileSystemHandle as described in
/// [FileSystemHandle.kind](https://developer.mozilla.org/docs/Web/API/FileSystemHandle/kind).</summary>
public enum CoreWebView2FileSystemHandleKind
{
	/// <summary>FileSystemHandle is for a file
	/// [FileSystemFileHandle](https://developer.mozilla.org/docs/Web/API/FileSystemFileHandle).</summary>
	File,
	/// <summary>FileSystemHandle is for a directory
	/// [FileSystemDirectoryHandle](https://developer.mozilla.org/docs/Web/API/FileSystemDirectoryHandle).</summary>
	Directory
}
