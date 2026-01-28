using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Provides a set of properties for a frame in the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" />.</summary>
/// <summary></summary>
public class CoreWebView2FrameInfo
{
	internal object _rawNative;

	internal ICoreWebView2FrameInfo _nativeICoreWebView2FrameInfoValue;

	internal ICoreWebView2FrameInfo2 _nativeICoreWebView2FrameInfo2Value;

	internal ICoreWebView2FrameInfo _nativeICoreWebView2FrameInfo
	{
		get
		{
			if (_nativeICoreWebView2FrameInfoValue == null)
			{
				try
				{
					_nativeICoreWebView2FrameInfoValue = (ICoreWebView2FrameInfo)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FrameInfoValue;
		}
		set
		{
			_nativeICoreWebView2FrameInfoValue = value;
		}
	}

	/// <summary>
	/// Gets the name attribute of the frame, as in `<iframe name="frame-name">...</iframe>`.
	/// </summary><remarks>
	/// The returned string is empty when the frame has no name attribute.
	/// </remarks>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FrameInfo.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The URI of the document in the frame.</summary>
	public string Source
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FrameInfo.Source;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2FrameInfo2 _nativeICoreWebView2FrameInfo2
	{
		get
		{
			if (_nativeICoreWebView2FrameInfo2Value == null)
			{
				try
				{
					_nativeICoreWebView2FrameInfo2Value = (ICoreWebView2FrameInfo2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FrameInfo2Value;
		}
		set
		{
			_nativeICoreWebView2FrameInfo2Value = value;
		}
	}

	/// <summary>
	/// The unique identifier of the frame associated with the current <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" />. It's the same kind of ID as with the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2.FrameId" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Frame.FrameId" />. FrameId will only be populated when obtained calling <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessExtendedInfo.AssociatedFrameInfos" />. <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" /> objects obtained via <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> will always have an invalid frame Id <c>0</c>.
	/// </summary><remarks>
	/// FrameId could be out of date as it's a snapshot. If there's <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" /> created or destroyed or <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.FrameCreated" /> event or <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed" /> event after the asynchronous call <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetProcessExtendedInfosAsync" /> starts, you may want to call the asynchronous method again to get the updated `<see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" />s.
	/// </remarks>
	public uint FrameId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FrameInfo2.FrameId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the kind of the frame. FrameKind will only be populated when obtained calling <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessExtendedInfo.AssociatedFrameInfos" />. <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" />` objects obtained via <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> will always have the default value <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2FrameKind.Unknown" />.
	/// </summary><remarks>
	/// FrameKind could be out of date as it's a snapshot.
	/// </remarks>
	public CoreWebView2FrameKind FrameKind
	{
		get
		{
			try
			{
				return (CoreWebView2FrameKind)_nativeICoreWebView2FrameInfo2.FrameKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// This parent frame's <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" />. ParentFrameInfo will only be populated when obtained via calling <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessExtendedInfo.AssociatedFrameInfos" />. <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" /> objects obtained via <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> will always have a <c>null</c> ParentFrameInfo. This property is also <c>null</c> for the top most document in the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" /> which has no parent frame.
	/// </summary><remarks>
	/// ParentFrameInfo could be out of date as it's a snapshot.
	/// </remarks>
	public CoreWebView2FrameInfo ParentFrameInfo
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2FrameInfo2.ParentFrameInfo == null) ? null : new CoreWebView2FrameInfo(_nativeICoreWebView2FrameInfo2.ParentFrameInfo);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FrameInfo members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2FrameInfo(object rawCoreWebView2FrameInfo)
	{
		_rawNative = rawCoreWebView2FrameInfo;
	}
}
