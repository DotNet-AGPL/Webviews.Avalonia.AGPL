using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

namespace Microsoft.Web.WebView2.Core;

internal class ManagedIStream : IStream
{
	private Stream _ioStream;

	private const int STGTY_STREAM = 2;

	private const int STGM_READ = 0;

	private const int STGM_WRITE = 1;

	private const int STGM_READWRITE = 2;

	private const int STREAM_SEEK_SET = 0;

	private const int STREAM_SEEK_CUR = 1;

	private const int STREAM_SEEK_END = 2;

	private const int STATFLAG_DEFAULT = 0;

	private const int STATFLAG_NONAME = 1;

	private const int STATFLAG_NOOPEN = 2;

	/// <summary>
	/// Constructor
	/// </summary>
	internal ManagedIStream(Stream ioStream)
	{
		if (ioStream == null)
		{
			throw new ArgumentNullException("ioStream");
		}
		_ioStream = ioStream;
	}

	/// <summary>
	/// Read at most bufferSize bytes into buffer and return the effective
	/// number of bytes read in bytesReadPtr (unless null).
	/// </summary>
	/// <remarks>
	/// mscorlib disassembly shows the following MarshalAs parameters
	/// void Read([Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] pv, int cb, IntPtr pcbRead);
	/// This means marshaling code will have found the size of the array buffer in the parameter bufferSize.
	/// </remarks>
	///             <SecurityNote>
	///     Critical: calls Marshal.WriteInt32 which LinkDemands, takes pointers as input
	///             </SecurityNote>
	[SecurityCritical]
	void IStream.Read(byte[] buffer, int bufferSize, IntPtr bytesReadPtr)
	{
		int val = _ioStream.Read(buffer, 0, bufferSize);
		if (bytesReadPtr != IntPtr.Zero)
		{
			Marshal.WriteInt32(bytesReadPtr, val);
		}
	}

	/// <summary>
	/// Move the stream pointer to the specified position.
	/// </summary>
	/// <remarks>
	/// System.IO.stream supports searching past the end of the stream, like
	/// OLE streams.
	/// newPositionPtr is not an out parameter because the method is required
	/// to accept NULL pointers.
	/// </remarks>
	///             <SecurityNote>
	///                 Critical: calls Marshal.WriteInt64 which LinkDemands, takes pointers as input
	///             </SecurityNote>
	[SecurityCritical]
	void IStream.Seek(long offset, int origin, IntPtr newPositionPtr)
	{
		SeekOrigin origin2 = origin switch
		{
			0 => SeekOrigin.Begin, 
			1 => SeekOrigin.Current, 
			2 => SeekOrigin.End, 
			_ => throw new ArgumentOutOfRangeException("origin"), 
		};
		long val = _ioStream.Seek(offset, origin2);
		if (newPositionPtr != IntPtr.Zero)
		{
			Marshal.WriteInt64(newPositionPtr, val);
		}
	}

	/// <summary>
	/// Sets stream's size.
	/// </summary>
	void IStream.SetSize(long libNewSize)
	{
		_ioStream.SetLength(libNewSize);
	}

	/// <summary>
	/// Obtain stream stats.
	/// </summary>
	/// <remarks>
	/// STATSG has to be qualified because it is defined both in System.Runtime.InteropServices and
	/// System.Runtime.InteropServices.ComTypes.
	/// The STATSTG structure is shared by streams, storages and byte arrays. Members irrelevant to streams
	/// or not available from System.IO.Stream are not returned, which leaves only cbSize and grfMode as
	/// meaningful and available pieces of information.
	/// grfStatFlag is used to indicate whether the stream name should be returned and is ignored because
	/// this information is unavailable.
	/// </remarks>
	void IStream.Stat(out System.Runtime.InteropServices.ComTypes.STATSTG streamStats, int grfStatFlag)
	{
		streamStats = default(System.Runtime.InteropServices.ComTypes.STATSTG);
		streamStats.type = 2;
		streamStats.cbSize = _ioStream.Length;
		streamStats.grfMode = 0;
		if (_ioStream.CanRead && _ioStream.CanWrite)
		{
			streamStats.grfMode |= 2;
			return;
		}
		if (_ioStream.CanRead)
		{
			streamStats.grfMode |= 0;
			return;
		}
		if (_ioStream.CanWrite)
		{
			streamStats.grfMode |= 1;
			return;
		}
		throw new IOException();
	}

	/// <summary>
	/// Write at most bufferSize bytes from buffer.
	/// </summary>
	///             <SecurityNote>
	///                 Critical: calls Marshal.WriteInt32 which LinkDemands, takes pointers as input
	///             </SecurityNote>
	[SecurityCritical]
	void IStream.Write(byte[] buffer, int bufferSize, IntPtr bytesWrittenPtr)
	{
		_ioStream.Write(buffer, 0, bufferSize);
		if (bytesWrittenPtr != IntPtr.Zero)
		{
			Marshal.WriteInt32(bytesWrittenPtr, bufferSize);
		}
	}

	/// <summary>
	/// Create a clone.
	/// </summary>
	/// <remarks>
	/// Not implemented.
	/// </remarks>
	void IStream.Clone(out IStream streamCopy)
	{
		streamCopy = null;
		throw new NotSupportedException();
	}

	/// <summary>
	/// Read at most bufferSize bytes from the receiver and write them to targetStream.
	/// </summary>
	/// <remarks>
	/// Not implemented.
	/// </remarks>
	void IStream.CopyTo(IStream targetStream, long bufferSize, IntPtr buffer, IntPtr bytesWrittenPtr)
	{
		throw new NotSupportedException();
	}

	/// <summary>
	/// Commit changes.
	/// </summary>
	/// <remarks>
	/// Only relevant to transacted streams.
	/// </remarks>
	void IStream.Commit(int flags)
	{
		throw new NotSupportedException();
	}

	/// <summary>
	/// Lock at most byteCount bytes starting at offset.
	/// </summary>
	/// <remarks>
	/// Not supported by System.IO.Stream.
	/// </remarks>
	void IStream.LockRegion(long offset, long byteCount, int lockType)
	{
		throw new NotSupportedException();
	}

	/// <summary>
	/// Undo writes performed since last Commit.
	/// </summary>
	/// <remarks>
	/// Relevant only to transacted streams.
	/// </remarks>
	void IStream.Revert()
	{
		throw new NotSupportedException();
	}

	/// <summary>
	/// Unlock the specified region.
	/// </summary>
	/// <remarks>
	/// Not supported by System.IO.Stream.
	/// </remarks>
	void IStream.UnlockRegion(long offset, long byteCount, int lockType)
	{
		throw new NotSupportedException();
	}
}
