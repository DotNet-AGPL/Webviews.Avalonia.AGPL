using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Represents a download operation. Gives access to a download's metadata and supports a user canceling, pausing, or resuming a download.</summary>
public class CoreWebView2DownloadOperation
{
	internal object _rawNative;

	internal ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperationValue;

	private EventRegistrationToken _BytesReceivedChangedToken;

	private EventHandler<object> privateBytesReceivedChanged;

	private EventRegistrationToken _EstimatedEndTimeChangedToken;

	private EventHandler<object> privateEstimatedEndTimeChanged;

	private EventRegistrationToken _StateChangedToken;

	private EventHandler<object> privateStateChanged;

	internal ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperation
	{
		get
		{
			if (_nativeICoreWebView2DownloadOperationValue == null)
			{
				try
				{
					_nativeICoreWebView2DownloadOperationValue = (ICoreWebView2DownloadOperation)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2DownloadOperationValue;
		}
		set
		{
			_nativeICoreWebView2DownloadOperationValue = value;
		}
	}

	/// <summary>The number of bytes that have been written to the download file.</summary>
	public long BytesReceived
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadOperation.BytesReceived;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns true if an interrupted download can be resumed.
	/// Downloads with the following interrupt reasons may automatically resume without you calling any methods: <c>CoreWebView2DownloadInterruptReason.ServerNoRange</c>, <c>CoreWebView2DownloadInterruptReason.FileHashMismatch</c>, <c>CoreWebView2DownloadInterruptReason.FileTooShort</c>. In these cases progress may be restarted with <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2DownloadOperation.BytesReceived" /> set to 0.</summary>
	public bool CanResume
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadOperation.CanResume != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The Content-Disposition header value from the download's HTTP response. If none, the value is an empty string.</summary>
	public string ContentDisposition
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadOperation.ContentDisposition;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The reason why connection with file host was broken.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2DownloadInterruptReason" /> for descriptions of reasons.
	/// </remarks>
	public CoreWebView2DownloadInterruptReason InterruptReason
	{
		get
		{
			try
			{
				return (CoreWebView2DownloadInterruptReason)_nativeICoreWebView2DownloadOperation.InterruptReason;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// MIME type of the downloaded content.</summary>
	public string MimeType
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadOperation.MimeType;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The absolute path to the download file, including file name.
	/// </summary><remarks>
	/// Host can change this from <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs.ResultFilePath" />.
	/// </remarks>
	public string ResultFilePath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadOperation.ResultFilePath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The state of the download. A download can be in progress, interrupted, or completed.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2DownloadState" /> for descriptions of states.
	/// </remarks>
	public CoreWebView2DownloadState State
	{
		get
		{
			try
			{
				return (CoreWebView2DownloadState)_nativeICoreWebView2DownloadOperation.State;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The URI of the download.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2DownloadOperation.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The estimated end time of the download.
	/// </summary>
	public DateTime EstimatedEndTime => DateTime.Parse(_nativeICoreWebView2DownloadOperation.EstimatedEndTime);

	/// <summary>
	/// The total bytes to receive count.
	/// </summary>
	public ulong? TotalBytesToReceive
	{
		get
		{
			if (_nativeICoreWebView2DownloadOperation.TotalBytesToReceive < 0)
			{
				return null;
			}
			return (ulong)_nativeICoreWebView2DownloadOperation.TotalBytesToReceive;
		}
	}

	/// <summary>
	/// Event raised when the bytes received count is updated.</summary>
	public event EventHandler<object> BytesReceivedChanged
	{
		add
		{
			if (privateBytesReceivedChanged == null)
			{
				try
				{
					_nativeICoreWebView2DownloadOperation.add_BytesReceivedChanged(new CoreWebView2BytesReceivedChangedEventHandler(OnBytesReceivedChanged), out _BytesReceivedChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateBytesReceivedChanged = (EventHandler<object>)Delegate.Combine(privateBytesReceivedChanged, value);
		}
		remove
		{
			privateBytesReceivedChanged = (EventHandler<object>)Delegate.Remove(privateBytesReceivedChanged, value);
			if (privateBytesReceivedChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2DownloadOperation.remove_BytesReceivedChanged(_BytesReceivedChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Event raised when the estimated end time changes.</summary>
	public event EventHandler<object> EstimatedEndTimeChanged
	{
		add
		{
			if (privateEstimatedEndTimeChanged == null)
			{
				try
				{
					_nativeICoreWebView2DownloadOperation.add_EstimatedEndTimeChanged(new CoreWebView2EstimatedEndTimeChangedEventHandler(OnEstimatedEndTimeChanged), out _EstimatedEndTimeChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateEstimatedEndTimeChanged = (EventHandler<object>)Delegate.Combine(privateEstimatedEndTimeChanged, value);
		}
		remove
		{
			privateEstimatedEndTimeChanged = (EventHandler<object>)Delegate.Remove(privateEstimatedEndTimeChanged, value);
			if (privateEstimatedEndTimeChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2DownloadOperation.remove_EstimatedEndTimeChanged(_EstimatedEndTimeChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Event raised when the state of the download changes.
	/// Use <c>CoreWebView2DownloadOperation.State</c> to get the current state, and <c>CoreWebView2DownloadOperation.InterruptReason</c> to get the reason if the download is interrupted.</summary>
	public event EventHandler<object> StateChanged
	{
		add
		{
			if (privateStateChanged == null)
			{
				try
				{
					_nativeICoreWebView2DownloadOperation.add_StateChanged(new CoreWebView2StateChangedEventHandler(OnStateChanged), out _StateChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateStateChanged = (EventHandler<object>)Delegate.Combine(privateStateChanged, value);
		}
		remove
		{
			privateStateChanged = (EventHandler<object>)Delegate.Remove(privateStateChanged, value);
			if (privateStateChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2DownloadOperation.remove_StateChanged(_StateChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2DownloadOperation(object rawCoreWebView2DownloadOperation)
	{
		_rawNative = rawCoreWebView2DownloadOperation;
	}

	internal void OnBytesReceivedChanged(object args)
	{
		privateBytesReceivedChanged?.Invoke(this, args);
	}

	internal void OnEstimatedEndTimeChanged(object args)
	{
		privateEstimatedEndTimeChanged?.Invoke(this, args);
	}

	internal void OnStateChanged(object args)
	{
		privateStateChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Cancels the download.
	/// </summary><remarks>
	/// If canceled, the default download dialog shows that the download was canceled. Host should use <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs.Cancel" /> if download should be canceled without displaying the default download dialog.
	/// </remarks>
	public void Cancel()
	{
		try
		{
			_nativeICoreWebView2DownloadOperation.Cancel();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Pauses the download.
	/// If paused, the default download dialog shows that the download is paused. No effect if download is already paused. Pausing a download changes the state from in progress to interrupted, with interrupt reason set to <c>CoreWebView2DownloadInterruptReason.UserCanceled</c>.</summary>
	public void Pause()
	{
		try
		{
			_nativeICoreWebView2DownloadOperation.Pause();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Resumes a paused download. May also resume a download that was interrupted for another reason if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2DownloadOperation.CanResume" /> returns true.
	/// </summary><remarks>
	/// Resuming a download changes the state from interrupted to in progress.
	/// </remarks>
	public void Resume()
	{
		try
		{
			_nativeICoreWebView2DownloadOperation.Resume();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2DownloadOperation members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2DownloadOperation members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
