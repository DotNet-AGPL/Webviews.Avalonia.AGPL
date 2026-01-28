using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Settings used by the <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> method.</summary>
/// <summary></summary>
public class CoreWebView2PrintSettings
{
	internal object _rawNative;

	internal ICoreWebView2PrintSettings _nativeICoreWebView2PrintSettingsValue;

	internal ICoreWebView2PrintSettings2 _nativeICoreWebView2PrintSettings2Value;

	internal ICoreWebView2PrintSettings _nativeICoreWebView2PrintSettings
	{
		get
		{
			if (_nativeICoreWebView2PrintSettingsValue == null)
			{
				try
				{
					_nativeICoreWebView2PrintSettingsValue = (ICoreWebView2PrintSettings)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrintSettings.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrintSettingsValue;
		}
		set
		{
			_nativeICoreWebView2PrintSettingsValue = value;
		}
	}

	/// <summary>
	/// The URI in the footer if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings.ShouldPrintHeaderAndFooter" /> is <c>true</c>.
	/// </summary><remarks>
	/// The default value is the current URI. If an empty string or null value is provided, no URI is shown in the footer.
	/// </remarks>
	public string FooterUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.FooterUri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.FooterUri = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The title in the header if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings.ShouldPrintHeaderAndFooter" /> is <c>true</c>.
	/// </summary><remarks>
	/// The default value is the title of the current document. If an empty string or null value is provided, no title is shown in the header.
	/// </remarks>
	public string HeaderTitle
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.HeaderTitle;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.HeaderTitle = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The bottom margin in inches.
	/// </summary><remarks>
	/// The default is 1 cm, or ~0.4 inches. A margin cannot be less than zero. If an invalid value is provided, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double MarginBottom
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginBottom;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.MarginBottom = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The left margin in inches.
	/// </summary><remarks>
	/// The default is 1 cm, or ~0.4 inches. A margin cannot be less than zero. If an invalid value is provided, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double MarginLeft
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginLeft;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.MarginLeft = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The right margin in inches.
	/// </summary><remarks>
	/// The default is 1 cm, or ~0.4 inches. A margin cannot be less than zero. If an invalid value is provided, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double MarginRight
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginRight;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.MarginRight = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The top margin in inches.
	/// </summary><remarks>
	/// The default is 1 cm, or ~0.4 inches. A margin cannot be less than zero. If an invalid value is provided, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double MarginTop
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginTop;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.MarginTop = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The orientation can be portrait or landscape.
	/// </summary><remarks>
	/// The default orientation is portrait. See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintOrientation" />.
	/// </remarks>
	public CoreWebView2PrintOrientation Orientation
	{
		get
		{
			try
			{
				return (CoreWebView2PrintOrientation)_nativeICoreWebView2PrintSettings.Orientation;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.Orientation = (COREWEBVIEW2_PRINT_ORIENTATION)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The page height in inches.
	/// </summary><remarks>
	/// The default height is 11 inches. If the provided page height is less than or equal to zero, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double PageHeight
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.PageHeight;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.PageHeight = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The page width in inches.
	/// </summary><remarks>
	/// The default width is 8.5 inches. If the provided page width is less than or equal to zero, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double PageWidth
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.PageWidth;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.PageWidth = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The scale factor is a value between 0.1 and 2.0.
	/// </summary><remarks>
	/// The default is 1.0. If an invalid value is provided, the current value is not changed and an ArgumentException is thrown.
	/// </remarks>
	public double ScaleFactor
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ScaleFactor;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.ScaleFactor = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> if background colors and images should be printed.
	/// </summary><remarks>
	/// The default value is <c>false</c>.
	/// </remarks>
	public bool ShouldPrintBackgrounds
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ShouldPrintBackgrounds != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.ShouldPrintBackgrounds = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> if header and footer should be printed.
	/// </summary><remarks>
	/// The default value is <c>false</c>. The header consists of the date and time of printing, and the title of the page. The footer consists of the URI and page number. The height of the header and footer is 0.5 cm, or ~0.2 inches.
	/// </remarks>
	public bool ShouldPrintHeaderAndFooter
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ShouldPrintHeaderAndFooter != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.ShouldPrintHeaderAndFooter = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary><c>true</c> if only the current end user's selection of HTML in the document should be printed.
	/// </summary><remarks>
	/// The default value is <c>false</c>.
	/// </remarks>
	public bool ShouldPrintSelectionOnly
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ShouldPrintSelectionOnly != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings.ShouldPrintSelectionOnly = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2PrintSettings2 _nativeICoreWebView2PrintSettings2
	{
		get
		{
			if (_nativeICoreWebView2PrintSettings2Value == null)
			{
				try
				{
					_nativeICoreWebView2PrintSettings2Value = (ICoreWebView2PrintSettings2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrintSettings2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrintSettings2Value;
		}
		set
		{
			_nativeICoreWebView2PrintSettings2Value = value;
		}
	}

	/// <summary>
	/// Printer collation.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintCollation" /> for descriptions of collation. The default value is <c>CoreWebView2PrintCollation.Default</c>.
	///
	/// Printing uses default value of printer's collation if an invalid value is provided for the specific printer.
	///
	/// This value is ignored in <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> method.
	/// </remarks>
	public CoreWebView2PrintCollation Collation
	{
		get
		{
			try
			{
				return (CoreWebView2PrintCollation)_nativeICoreWebView2PrintSettings2.Collation;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.Collation = (COREWEBVIEW2_PRINT_COLLATION)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Printer color mode.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintColorMode" /> for descriptions of color modes. The default value is <c>CoreWebView2PrintColorMode.Default</c>.
	///
	/// Printing uses default value of printer supported color if an invalid value is provided for the specific printer.
	/// </remarks>
	public CoreWebView2PrintColorMode ColorMode
	{
		get
		{
			try
			{
				return (CoreWebView2PrintColorMode)_nativeICoreWebView2PrintSettings2.ColorMode;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.ColorMode = (COREWEBVIEW2_PRINT_COLOR_MODE)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Number of copies to print. Minimum value is <c>1</c> and the maximum copies count is <c>999</c>.
	/// </summary><remarks>
	/// The default value is 1.
	/// </remarks>
	public int Copies
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings2.Copies;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.Copies = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Printer duplex settings.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintDuplex" /> for descriptions of duplex. The default value is <c>CoreWebView2PrintDuplex.Default</c>.
	///
	/// Printing uses default value of printer's duplex if an invalid value is provided for the specific printer.
	///
	/// This value is ignored in <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> method.
	/// </remarks>
	public CoreWebView2PrintDuplex Duplex
	{
		get
		{
			try
			{
				return (CoreWebView2PrintDuplex)_nativeICoreWebView2PrintSettings2.Duplex;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.Duplex = (COREWEBVIEW2_PRINT_DUPLEX)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Printer media size.
	/// </summary><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintMediaSize" /> for descriptions of media size. The default value is <c>CoreWebView2PrintMediaSize.Default</c>.
	///
	/// If media size is <c>CoreWebView2PrintMediaSize.Custom</c>, you should set the PageWidth and PageHeight.
	///
	/// Printing uses default value of printer supported media size if an invalid value is provided for the specific printer.
	///
	/// This value is ignored in <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> method.
	/// </remarks>
	public CoreWebView2PrintMediaSize MediaSize
	{
		get
		{
			try
			{
				return (CoreWebView2PrintMediaSize)_nativeICoreWebView2PrintSettings2.MediaSize;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.MediaSize = (COREWEBVIEW2_PRINT_MEDIA_SIZE)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Page range to print. Defaults to empty string, which means print all pages.</summary><remarks>
	/// The PageRanges property is a list of page ranges specifying one or more pages that should be printed separated by commas. Any whitespace between page ranges is ignored.
	/// A valid page range is either a single integer identifying the page to print, or a range in the form <c>[start page]-[last page]</c> where <c>start page</c> and <c>last page</c> are integers identifying the first and last inclusive pages respectively to print.
	/// Every page identifier is an integer greater than 0 unless wildcards are used (see below examples).
	/// The first page is 1.
	///
	/// In a page range of the form <c>[start page]-[last page]</c> the start page number must be larger than 0 and less than or equal to the document's total page count.
	/// If the <c>start page</c> is not present, then 1 is used as the <c>start page</c>.
	/// The <c>last page</c> must be larger than the <c>start page</c>.
	/// If the <c>last page</c> is not present, then the document total page count is used as the <c>last page</c>.
	///
	/// Repeating a page does not print it multiple times. To print multiple times, use the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings.Copies" /> property.
	///
	/// The pages are always printed in ascending order, even if specified in non-ascending order.
	///
	/// If page range is not valid or if a page is greater than document total page count, ArgumentException is thrown.
	///
	/// The following examples assume a document with 20 total pages.
	///
	/// <list type="table"><listheader><description>Example</description><description>Result</description><description>Notes</description></listheader><item><description>"2"</description><description>Page 2</description><description></description></item><item><description>"1-4, 9, 3-6, 10, 11"</description><description>Pages 1-6, 9-11</description><description></description></item><item><description>"1-4, -6" </description><description>Pages 1-6</description><description>The "-6" is interpreted as "1-6".</description></item><item><description>"2-" </description><description>Pages 2-20</description><description>The "2-" is interpreted as "pages 2 to the end of the document".</description></item><item><description>"4-2, 11, -6"</description><description>Invalid</description><description>"4-2" is an invalid range. </description></item><item><description>"-"</description><description>Pages 1-20</description><description>The "-" is interpreted as "page 1 to the end of the document".</description></item><item><description>"1-4dsf, 11"</description><description>Invalid</description><description></description></item><item><description>"2-2"</description><description>Page 2</description><description></description></item></list></remarks>
	public string PageRanges
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings2.PageRanges;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.PageRanges = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Prints multiple pages of a document on a single piece of paper. Choose from 1, 2, 4, 6, 9 or 16.</summary><remarks>
	/// The default value is 1.
	///
	/// If an invalid value is provided, ArgumentException is thrown.
	///
	/// Below examples shows print output for PagesPerSide and Duplex.
	///
	/// <list type="table"><listheader><description>PagesPerSide</description><description>Total pages</description><description>Two-sided printing</description><description>Result</description></listheader><item><description>1</description><description>1</description><description>-</description><description>1 page on the front side.</description></item><item><description>2</description><description>1</description><description>Yes</description><description>1 page on the front side.</description></item><item><description>2</description><description>4</description><description>-</description><description>2 pages on the first paper and 2 pages on the next paper.</description></item><item><description>2</description><description>4</description><description>Yes</description><description>2 pages on the front side and 2 pages on back side.</description></item><item><description>4</description><description>4</description><description>Yes</description><description>4 pages on the front side.</description></item><item><description>4</description><description>8</description><description>Yes</description><description>4 pages on the front side and 4 pages on the back side.</description></item></list></remarks>
	public int PagesPerSide
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings2.PagesPerSide;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.PagesPerSide = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The name of the printer to use.
	/// </summary><remarks>
	/// Defaults to empty string. If the printer name is empty string or null, then it prints to the default printer on the user OS.
	///
	/// If provided printer name doesn't match with the name of any installed printers on the user OS, the method returns with <c>CoreWebView2PrintStatus.PrinterUnavailable</c>.
	///
	/// Use [DeviceInformation.FindAllAsync](/uwp/api/windows.devices.enumeration.deviceinformation.findallasync) to get the list of local printers with AQS as "System.Devices.HardwareIds:~~"PRINTENUM\LocalPrintQueue""
	///
	/// This value is ignored in <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> method.
	/// </remarks>
	public string PrinterName
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings2.PrinterName;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2PrintSettings2.PrinterName = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2PrintSettings members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2PrintSettings(object rawCoreWebView2PrintSettings)
	{
		_rawNative = rawCoreWebView2PrintSettings;
	}
}
