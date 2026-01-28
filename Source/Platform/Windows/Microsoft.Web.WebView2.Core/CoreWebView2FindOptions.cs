using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Interface defining the find options.
/// This interface provides the necessary methods and properties to configure a find session.</summary>
public class CoreWebView2FindOptions
{
	internal object _rawNative;

	internal ICoreWebView2FindOptions _nativeICoreWebView2FindOptionsValue;

	internal ICoreWebView2FindOptions _nativeICoreWebView2FindOptions
	{
		get
		{
			if (_nativeICoreWebView2FindOptionsValue == null)
			{
				try
				{
					_nativeICoreWebView2FindOptionsValue = (ICoreWebView2FindOptions)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FindOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FindOptionsValue;
		}
		set
		{
			_nativeICoreWebView2FindOptionsValue = value;
		}
	}

	/// <summary>Gets or sets the word or phrase to be searched in the current page.
	/// You can set `FindTerm` to any text you want to find on the page. 
	/// This will take effect the next time you call the `Start()` method.
	/// </summary>
	public string FindTerm
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FindOptions.FindTerm;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2FindOptions.FindTerm = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Determines if the find session is case sensitive. Returns TRUE if the find is case sensitive, FALSE otherwise.
	/// When toggling case sensitivity, the behavior can vary by locale, which may be influenced by both the browser's UI locale and the document's language settings. The browser's UI locale
	/// typically provides a default handling approach, while the document's language settings (e.g., specified using the HTML lang attribute) can override these defaults to apply locale-specific rules. This dual consideration
	/// ensures that text is processed in a manner consistent with user expectations and the linguistic context of the content.
	/// </summary>
	public bool IsCaseSensitive
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FindOptions.IsCaseSensitive != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2FindOptions.IsCaseSensitive = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Gets or sets the state of whether all matches are highlighted.
	/// Returns TRUE if all matches are highlighted, FALSE otherwise.
	/// Note: Changes to this property take effect only when Start, FindNext, or FindPrevious is called.
	/// Preferences for the session cannot be updated unless another call to the Start function on the server-side is made.
	/// Therefore, changes will not take effect until one of these functions is called.
	/// </summary>
	public bool ShouldHighlightAllMatches
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FindOptions.ShouldHighlightAllMatches != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2FindOptions.ShouldHighlightAllMatches = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Similar to case sensitivity, word matching also can vary by locale, which may be influenced by both the browser's UI locale and the document's language settings. The browser's UI locale
	/// typically provides a default handling approach, while the document's language settings (e.g., specified using the HTML lang attribute) can override these defaults to apply locale-specific rules. This dual consideration
	/// ensures that text is processed in a manner consistent with user expectations and the linguistic context of the content.
	/// ShouldMatchWord determines if only whole words should be matched during the find session. Returns TRUE if only whole words should be matched, FALSE otherwise.
	/// </summary>
	public bool ShouldMatchWord
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FindOptions.ShouldMatchWord != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2FindOptions.ShouldMatchWord = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Sets this property to hide the default Find UI.
	/// You can use this to hide the default UI so that you can show your own custom UI or programmatically interact with the Find API while showing no Find UI.
	/// Returns TRUE if hiding the default Find UI and FALSE if using showing the default Find UI.
	/// Note: Changes to this property take effect only when Start, FindNext, or FindPrevious is called.
	/// Preferences for the session cannot be updated unless another call to the Start function on the server-side is made.
	/// Therefore, changes will not take effect until one of these functions is called.
	/// </summary>
	public bool SuppressDefaultFindDialog
	{
		get
		{
			try
			{
				return _nativeICoreWebView2FindOptions.SuppressDefaultFindDialog != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2FindOptions.SuppressDefaultFindDialog = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2FindOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2FindOptions(object rawCoreWebView2FindOptions)
	{
		_rawNative = rawCoreWebView2FindOptions;
	}
}
