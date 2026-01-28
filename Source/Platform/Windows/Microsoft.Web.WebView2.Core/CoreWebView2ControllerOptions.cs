using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Used to manage profile options that created by <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerOptions" />.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2ControllerOptions
{
	internal object _rawNative;

	internal ICoreWebView2ControllerOptions _nativeICoreWebView2ControllerOptionsValue;

	internal ICoreWebView2ControllerOptions2 _nativeICoreWebView2ControllerOptions2Value;

	internal ICoreWebView2ControllerOptions3 _nativeICoreWebView2ControllerOptions3Value;

	internal ICoreWebView2ControllerOptions4 _nativeICoreWebView2ControllerOptions4Value;

	internal ICoreWebView2ControllerOptions _nativeICoreWebView2ControllerOptions
	{
		get
		{
			if (_nativeICoreWebView2ControllerOptionsValue == null)
			{
				try
				{
					_nativeICoreWebView2ControllerOptionsValue = (ICoreWebView2ControllerOptions)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ControllerOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ControllerOptionsValue;
		}
		set
		{
			_nativeICoreWebView2ControllerOptionsValue = value;
		}
	}

	/// <summary>
	/// Manage the controller's InPrivate mode.</summary>
	public bool IsInPrivateModeEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ControllerOptions.IsInPrivateModeEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ControllerOptions.IsInPrivateModeEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Manage the name of the controller's profile.
	/// </summary><remarks>
	/// The <c>ProfileName</c> property is to specify a profile name, which is only allowed to contain the following ASCII characters. It has a maximum length of 64 characters excluding the null-terminator. It is ASCII case insensitive.
	///
	/// * alphabet characters: a-z and A-Z
	/// * digit characters: 0-9
	/// * and '#', '@', '$', '(', ')', '+', '-', '_', '~', '.', ' ' (space).
	///
	/// Note: the text must not end with a period '.' or ' ' (space). And, although upper-case letters are allowed, they're treated just as lower-case counterparts because the profile name will be mapped to the real profile directory path on disk and Windows file system handles path names in a case-insensitive way.
	/// </remarks>
	public string ProfileName
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ControllerOptions.ProfileName;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ControllerOptions.ProfileName = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2ControllerOptions2 _nativeICoreWebView2ControllerOptions2
	{
		get
		{
			if (_nativeICoreWebView2ControllerOptions2Value == null)
			{
				try
				{
					_nativeICoreWebView2ControllerOptions2Value = (ICoreWebView2ControllerOptions2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ControllerOptions2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ControllerOptions2Value;
		}
		set
		{
			_nativeICoreWebView2ControllerOptions2Value = value;
		}
	}

	internal ICoreWebView2ControllerOptions3 _nativeICoreWebView2ControllerOptions3
	{
		get
		{
			if (_nativeICoreWebView2ControllerOptions3Value == null)
			{
				try
				{
					_nativeICoreWebView2ControllerOptions3Value = (ICoreWebView2ControllerOptions3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ControllerOptions3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ControllerOptions3Value;
		}
		set
		{
			_nativeICoreWebView2ControllerOptions3Value = value;
		}
	}

	/// <summary>This property allows users to initialize the `DefaultBackgroundColor` early,
	/// preventing a white flash that can occur while WebView2 is loading when
	/// the background color is set to something other than white. With early
	/// initialization, the color remains consistent from the start. After
	/// initialization, `CoreWebView2Controller.DefaultBackgroundColor` will return the value set using this API.
	///
	/// The `CoreWebView2Controller.DefaultBackgroundColor` can be set via the WEBVIEW2_DEFAULT_BACKGROUND_COLOR environment variable,
	/// which will remain supported for cases where this solution is being used.
	/// It is encouraged to transition away from the environment variable and use this API solution to
	/// apply the property. It is important to highlight that when set, the enviroment variable overrides
	/// ControllerOptions::DefaultBackgroundColor and becomes the initial value of Controller::DefaultBackgroundColor.
	///
	/// The `DefaultBackgroundColor` is the color that renders underneath all web
	/// content. This means WebView2 renders this color when there is no web
	/// content loaded. When no background color is defined in WebView2, it uses
	/// the `DefaultBackgroundColor` property to render the background.
	/// By default, this color is set to white.
	///
	/// This API only supports opaque colors and full transparency. It will
	/// fail for colors with alpha values that don't equal 0 or 255.
	/// When WebView2 is set to be fully transparent, it does not render a background,
	/// allowing the content from windows behind it to be visible.</summary>
	public Color DefaultBackgroundColor
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.ColorCOMToNet(_nativeICoreWebView2ControllerOptions3.DefaultBackgroundColor);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ControllerOptions3.DefaultBackgroundColor = COMDotNetTypeConverter.ColorNetToCOM(value);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2ControllerOptions4 _nativeICoreWebView2ControllerOptions4
	{
		get
		{
			if (_nativeICoreWebView2ControllerOptions4Value == null)
			{
				try
				{
					_nativeICoreWebView2ControllerOptions4Value = (ICoreWebView2ControllerOptions4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ControllerOptions4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ControllerOptions4Value;
		}
		set
		{
			_nativeICoreWebView2ControllerOptions4Value = value;
		}
	}

	/// <summary>`AllowHostInputProcessing` property is to enable/disable input passing through
	/// the app before being delivered to the WebView2. This property is only applicable
	/// to controllers created with `CoreWebView2Environment.CreateCoreWebView2ControllerAsync` and not
	/// composition controllers created with `CoreWebView2Environment.CreateCoreWebView2CompositionControllerAsync`.
	/// By default the value is `FALSE`.
	/// Setting this property has no effect when using visual hosting.
	/// \snippet AppWindow.cpp AllowHostInputProcessing</summary>
	public bool AllowHostInputProcessing
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ControllerOptions4.AllowHostInputProcessing != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ControllerOptions4.AllowHostInputProcessing = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Manages the value of the controller's script locale.
	/// </summary>
	/// <remarks>
	/// The <c>ScriptLocale</c> property is to specify the default script
	/// locale. It sets the default locale for all Intl JavaScript APIs and
	/// other JavaScript APIs that depend on it, namely
	/// <c>Intl.DateTimeFormat()</c> which affects string formatting like in
	/// the time/date formats.The intended locale value is in the format of
	/// BCP 47 Language Tags. More information can be found from [IETF
	/// BCP47](https://www.ietf.org/rfc/bcp/bcp47.html ). The default value
	/// for ScriptLocale will be depend on the WebView2 language and OS
	/// region. If the language portions of the WebView2 language and OS
	/// region match, then it will use the OS region. Otherwise, it will use
	/// the WebView2 language.
	/// <list type="table">
	/// <listheader>
	/// <description>OS Region</description>
	/// <description>WebView2 Language</description>
	/// <description>Default WebView2 ScriptLocale</description>
	/// </listheader>
	/// <item>
	/// <description>en-GB</description>
	/// <description>en-US</description>
	/// <description>en-GB</description>
	/// </item>
	/// <item>
	/// <description>es-MX</description>
	/// <description>en-US</description>
	/// <description>en-US</description>
	/// </item>
	/// <item>
	/// <description>en-US</description>
	/// <description>en-GB</description>
	/// <description>en-US</description>
	/// </item>
	/// </list>
	/// You can set the ScriptLocale to the empty string to get the default ScriptLocale value.
	/// Use OS specific APIs to determine the OS region to use with this property if you always want to match with the OS
	/// region. For example:
	/// <code>
	/// CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
	/// return cultureInfo.Name
	/// </code>
	/// </remarks>
	public string ScriptLocale
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ControllerOptions2.ScriptLocale;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ControllerOptions2.ScriptLocale = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ControllerOptions(object rawCoreWebView2ControllerOptions)
	{
		_rawNative = rawCoreWebView2ControllerOptions;
	}
}
