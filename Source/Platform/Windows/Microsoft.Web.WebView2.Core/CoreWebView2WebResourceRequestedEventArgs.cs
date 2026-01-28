using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event.</summary>
/// <summary>Event args for the `WebResourceRequested` event.</summary>
public class CoreWebView2WebResourceRequestedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgsValue;

	internal ICoreWebView2WebResourceRequestedEventArgs2 _nativeICoreWebView2WebResourceRequestedEventArgs2Value;

	internal ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2WebResourceRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2WebResourceRequestedEventArgsValue = (ICoreWebView2WebResourceRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebResourceRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2WebResourceRequestedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Gets the web resource request.
	/// </summary><remarks>
	/// The request object may be missing some headers that are added by network stack at a later time.
	/// </remarks>
	public CoreWebView2WebResourceRequest Request
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2WebResourceRequestedEventArgs.Request == null) ? null : new CoreWebView2WebResourceRequest(_nativeICoreWebView2WebResourceRequestedEventArgs.Request);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>The web resource request context.</summary>
	public CoreWebView2WebResourceContext ResourceContext
	{
		get
		{
			try
			{
				return (CoreWebView2WebResourceContext)_nativeICoreWebView2WebResourceRequestedEventArgs.ResourceContext;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse" /> object.
	/// </summary><remarks>
	/// If this object is set, the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event will be completed with this Response.
	/// An empty <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse" /> object can be created with <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateWebResourceResponse(System.IO.Stream,System.Int32,System.String,System.String)" /> and then modified to construct the Response.
	/// </remarks>
	public CoreWebView2WebResourceResponse Response
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2WebResourceRequestedEventArgs.Response == null) ? null : new CoreWebView2WebResourceResponse(_nativeICoreWebView2WebResourceRequestedEventArgs.Response);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2WebResourceRequestedEventArgs.Response = value._nativeICoreWebView2WebResourceResponse;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2WebResourceRequestedEventArgs2 _nativeICoreWebView2WebResourceRequestedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2WebResourceRequestedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2WebResourceRequestedEventArgs2Value = (ICoreWebView2WebResourceRequestedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebResourceRequestedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2WebResourceRequestedEventArgs2Value = value;
		}
	}

	/// <summary>The web resource requested source.</summary>
	public CoreWebView2WebResourceRequestSourceKinds RequestedSourceKind
	{
		get
		{
			try
			{
				return (CoreWebView2WebResourceRequestSourceKinds)_nativeICoreWebView2WebResourceRequestedEventArgs2.RequestedSourceKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2WebResourceRequestedEventArgs(object rawCoreWebView2WebResourceRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2WebResourceRequestedEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object and put the event into a deferred state.
	/// Use this to Complete the event at a later time.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2WebResourceRequestedEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2WebResourceRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
