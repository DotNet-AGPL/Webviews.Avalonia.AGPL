namespace Microsoft.Web.WebView2.Core;

/// <summary>Reason why a download was interrupted.</summary>
public enum CoreWebView2DownloadInterruptReason
{
	None,
	/// <summary>Generic file error.</summary>
	FileFailed,
	/// <summary>Access denied due to security restrictions.</summary>
	FileAccessDenied,
	/// <summary>Disk full. User should free some space or choose a different location to
	/// store the file.</summary>
	FileNoSpace,
	/// <summary>Result file path with file name is too long.</summary>
	FileNameTooLong,
	/// <summary>File is too large for file system.</summary>
	FileTooLarge,
	/// <summary>Microsoft Defender Smartscreen detected a virus in the file.</summary>
	FileMalicious,
	/// <summary>File was in use, too many files opened, or out of memory.</summary>
	FileTransientError,
	/// <summary>File blocked by local policy.</summary>
	FileBlockedByPolicy,
	/// <summary>Security check failed unexpectedly. Microsoft Defender SmartScreen could
	/// not scan this file.</summary>
	FileSecurityCheckFailed,
	/// <summary>Seeking past the end of a file in opening a file, as part of resuming an
	/// interrupted download. The file did not exist or was not as large as
	/// expected. Partially downloaded file was truncated or deleted, and download
	/// will be restarted automatically.</summary>
	FileTooShort,
	/// <summary>Partial file did not match the expected hash and was deleted. Download
	/// will be restarted automatically.</summary>
	FileHashMismatch,
	/// <summary>Generic network error. User can retry the download manually.</summary>
	NetworkFailed,
	/// <summary>Network operation timed out.</summary>
	NetworkTimeout,
	/// <summary>Network connection lost. User can retry the download manually.</summary>
	NetworkDisconnected,
	/// <summary>Server has gone down. User can retry the download manually.</summary>
	NetworkServerDown,
	/// <summary>Network request invalid because original or redirected URI is invalid, has
	/// an unsupported scheme, or is disallowed by network policy.</summary>
	NetworkInvalidRequest,
	/// <summary>Generic server error. User can retry the download manually.</summary>
	ServerFailed,
	/// <summary>Server does not support range requests.</summary>
	ServerNoRange,
	/// <summary>Server does not have the requested data.</summary>
	ServerBadContent,
	/// <summary>Server did not authorize access to resource.</summary>
	ServerUnauthorized,
	/// <summary>Server certificate problem.</summary>
	ServerCertificateProblem,
	/// <summary>Server access forbidden.</summary>
	ServerForbidden,
	/// <summary>Unexpected server response. Responding server may not be intended server.
	/// User can retry the download manually.</summary>
	ServerUnexpectedResponse,
	/// <summary>Server sent fewer bytes than the Content-Length header. Content-length
	/// header may be invalid or connection may have closed. Download is treated
	/// as complete unless there are
	/// [strong validators](https://tools.ietf.org/html/rfc7232#section-2) present
	/// to interrupt the download.</summary>
	ServerContentLengthMismatch,
	/// <summary>Unexpected cross-origin redirect.</summary>
	ServerCrossOriginRedirect,
	/// <summary>User canceled the download.</summary>
	UserCanceled,
	/// <summary>User shut down the WebView. Resuming downloads that were interrupted
	/// during shutdown is not yet supported.</summary>
	UserShutdown,
	/// <summary>User paused the download.</summary>
	UserPaused,
	/// <summary>WebView crashed.</summary>
	DownloadProcessCrashed
}
