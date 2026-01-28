using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Represents the information regarding the context menu target. Includes the context selected and the appropriate data used for the actions of a context menu.</summary>
public class CoreWebView2ContextMenuTarget
{
	internal object _rawNative;

	internal ICoreWebView2ContextMenuTarget _nativeICoreWebView2ContextMenuTargetValue;

	internal ICoreWebView2ContextMenuTarget _nativeICoreWebView2ContextMenuTarget
	{
		get
		{
			if (_nativeICoreWebView2ContextMenuTargetValue == null)
			{
				try
				{
					_nativeICoreWebView2ContextMenuTargetValue = (ICoreWebView2ContextMenuTarget)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContextMenuTarget.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ContextMenuTargetValue;
		}
		set
		{
			_nativeICoreWebView2ContextMenuTargetValue = value;
		}
	}

	/// <summary>
	/// Gets the uri of the frame. Will match the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget.PageUri" /> if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget.IsRequestedForMainFrame" /> is <c>true</c>.</summary>
	public string FrameUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.FrameUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns <c>true</c> if the context menu is requested on text element that contains an anchor tag.</summary>
	public bool HasLinkText
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.HasLinkText != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns <c>true</c> if the context menu is requested on HTML containing an anchor tag.</summary>
	public bool HasLinkUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.HasLinkUri != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns <c>true</c> if the context menu is requested on a selection.</summary>
	public bool HasSelection
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.HasSelection != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns <c>true</c> if the context menu is requested on HTML containing a source uri.</summary>
	public bool HasSourceUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.HasSourceUri != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns <c>true</c> if the context menu is requested on an editable component.</summary>
	public bool IsEditable
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.IsEditable != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns <c>true</c> if the context menu was requested on the main frame and <c>false</c> if invoked on another frame.</summary>
	public bool IsRequestedForMainFrame
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.IsRequestedForMainFrame != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the kind of context that the user selected as <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTargetKind" />.</summary>
	public CoreWebView2ContextMenuTargetKind Kind
	{
		get
		{
			try
			{
				return (CoreWebView2ContextMenuTargetKind)_nativeICoreWebView2ContextMenuTarget.Kind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the text of the link (if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget.HasLinkText" /> is <c>true</c>, <c>null</c> otherwise).</summary>
	public string LinkText
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.LinkText;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the uri of the link (if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget.HasLinkUri" /> is <c>true</c>, <c>null</c> otherwise).</summary>
	public string LinkUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.LinkUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Gets the uri of the page.</summary>
	public string PageUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.PageUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the selected text (if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget.HasSelection" /> is <c>true</c>, <c>null</c> otherwise).</summary>
	public string SelectionText
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.SelectionText;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the active source uri of element (if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget.HasSourceUri" /> is <c>true</c>, <c>null</c> otherwise).</summary>
	public string SourceUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuTarget.SourceUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuTarget members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ContextMenuTarget(object rawCoreWebView2ContextMenuTarget)
	{
		_rawNative = rawCoreWebView2ContextMenuTarget;
	}
}
