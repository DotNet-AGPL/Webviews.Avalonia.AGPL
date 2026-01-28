using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// A shared memory based buffer object that is created by <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateSharedBuffer(System.UInt64)" />. The object is presented to script as ArrayBuffer when posted to script with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostSharedBufferToScript(Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer,Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess,System.String)" />.</summary>
public class CoreWebView2SharedBuffer : IDisposable
{
	internal class WebView2SharedBufferSafeHandle : SafeHandle
	{
		protected CoreWebView2SharedBuffer _shared_buffer;

		public override bool IsInvalid
		{
			get
			{
				if (!base.IsClosed && _shared_buffer != null)
				{
					return _shared_buffer.UnsafeFileMappingHandle == IntPtr.Zero;
				}
				return true;
			}
		}

		public WebView2SharedBufferSafeHandle(CoreWebView2SharedBuffer shared_buffer)
			: base(IntPtr.Zero, ownsHandle: false)
		{
			IntPtr unsafeFileMappingHandle = shared_buffer.UnsafeFileMappingHandle;
			if (unsafeFileMappingHandle != IntPtr.Zero)
			{
				SetHandle(unsafeFileMappingHandle);
				_shared_buffer = shared_buffer;
			}
		}

		protected override bool ReleaseHandle()
		{
			_shared_buffer = null;
			return true;
		}
	}

	internal object _rawNative;

	internal ICoreWebView2SharedBuffer _nativeICoreWebView2SharedBufferValue;

	private bool _disposed;

	private WebView2SharedBufferSafeHandle _safeFileMappingHandle;

	internal ICoreWebView2SharedBuffer _nativeICoreWebView2SharedBuffer
	{
		get
		{
			if (_nativeICoreWebView2SharedBufferValue == null)
			{
				try
				{
					_nativeICoreWebView2SharedBufferValue = (ICoreWebView2SharedBuffer)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SharedBuffer.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2SharedBufferValue;
		}
		set
		{
			_nativeICoreWebView2SharedBufferValue = value;
		}
	}

	/// <summary>
	/// A Windows.Foundation.IMemoryBufferReference object to access the underlying memory of the shared buffer as an array of bytes.
	/// </summary><remarks>
	/// Normal app should use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer.OpenStream" /> to get a stream object to access the buffer.
	/// </remarks>
	public IntPtr Buffer
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SharedBuffer.Buffer;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SharedBuffer members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SharedBuffer members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The size of the shared buffer in bytes.</summary>
	public ulong Size
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SharedBuffer.Size;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2SharedBuffer members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2SharedBuffer members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal IntPtr UnsafeFileMappingHandle
	{
		get
		{
			try
			{
				return _nativeICoreWebView2SharedBuffer.FileMappingHandle;
			}
			catch (Exception)
			{
				return IntPtr.Zero;
			}
		}
	}

	/// <summary>
	/// The file mapping handle of the shared memory of the buffer.
	/// </summary>
	/// <remarks>
	/// Normal app should use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer.OpenStream" /> to
	/// get a stream object to access the buffer.
	/// For advanced scenarios, you could use native file mapping APIs to obtain
	/// other views or duplicate this handle to another application process and
	/// create a view from the duplicated handle in that process to access the buffer
	/// from that separate process.
	/// </remarks>
	public SafeHandle FileMappingHandle
	{
		get
		{
			if (!_disposed && _safeFileMappingHandle == null)
			{
				_safeFileMappingHandle = new WebView2SharedBufferSafeHandle(this);
			}
			return _safeFileMappingHandle;
		}
	}

	internal CoreWebView2SharedBuffer(object rawCoreWebView2SharedBuffer)
	{
		_rawNative = rawCoreWebView2SharedBuffer;
	}

	/// <summary>
	/// Get an stream object that can be used to access the shared buffer.</summary>
	public Stream OpenStream()
	{
		try
		{
			return COMDotNetTypeConverter.StreamCOMToNet(_nativeICoreWebView2SharedBuffer.OpenStream());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2SharedBuffer members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2SharedBuffer members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary></summary>
	public void Close()
	{
		try
		{
			_nativeICoreWebView2SharedBuffer.Close();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2SharedBuffer members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2SharedBuffer members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <inheritdoc />
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Protected implementation of Dispose pattern.
	/// </summary>
	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			_disposed = true;
			Close();
			if (disposing && _safeFileMappingHandle != null)
			{
				_safeFileMappingHandle.SetHandleAsInvalid();
				_safeFileMappingHandle = null;
			}
		}
	}
}
