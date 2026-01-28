using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Options used to create WebView2 Environment.
/// Default values will use your defaulted Edge WebView2 Runtime binaries and user data folder.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary>
/// Options used to create WebView2 Environment.
/// </summary>
/// <remarks>
/// Default values will use your defaulted Edge WebView2 Runtime binaries and
/// user data folder.
/// </remarks>
public class CoreWebView2EnvironmentOptions
{
	private class RawOptions : ICoreWebView2EnvironmentOptions, ICoreWebView2EnvironmentOptions2, ICoreWebView2EnvironmentOptions3, ICoreWebView2EnvironmentOptions4, ICoreWebView2EnvironmentOptions5, ICoreWebView2EnvironmentOptions6, ICoreWebView2EnvironmentOptions7, ICoreWebView2EnvironmentOptions8
	{
		public string AdditionalBrowserArguments { get; set; }

		public string Language { get; set; }

		public string TargetCompatibleBrowserVersion { get; set; }

		public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; }

		public int ExclusiveUserDataFolderAccess { get; set; }

		public int IsCustomCrashReportingEnabled { get; set; }

		public int AreBrowserExtensionsEnabled { get; set; }

		public COREWEBVIEW2_RELEASE_CHANNELS ReleaseChannels { get; set; } = (COREWEBVIEW2_RELEASE_CHANNELS)15;

		public COREWEBVIEW2_CHANNEL_SEARCH_KIND ChannelSearchKind { get; set; }

		public COREWEBVIEW2_SCROLLBAR_STYLE ScrollBarStyle { get; set; }

		public List<CoreWebView2CustomSchemeRegistration> CustomSchemeRegistrations { get; set; }

		public int EnableTrackingPrevention { get; set; } = 1;

		public void GetCustomSchemeRegistrations(out uint count, IntPtr registrationsPtr)
		{
			if (CustomSchemeRegistrations == null || CustomSchemeRegistrations.Count == 0)
			{
				count = 0u;
				return;
			}
			count = (uint)CustomSchemeRegistrations.Count;
			Marshal.SizeOf<IntPtr>();
			IntPtr intPtr = Marshal.AllocCoTaskMem((int)count * Marshal.SizeOf<IntPtr>());
			for (int i = 0; i < count; i++)
			{
				Marshal.WriteIntPtr(intPtr + i * Marshal.SizeOf<IntPtr>(), CustomSchemeRegistrations[i].GetNative());
			}
			Marshal.WriteIntPtr(registrationsPtr, intPtr);
		}

		public void SetCustomSchemeRegistrations(uint count, ref ICoreWebView2CustomSchemeRegistration registration)
		{
			throw new NotImplementedException();
		}

		public RawOptions(string additionalBrowserArguments, string language, string targetCompatibleBrowserVersion, bool allowSingleSignOnUsingOSPrimaryAccount, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations, CoreWebView2ReleaseChannels releaseChannels, CoreWebView2ChannelSearchKind channelSearchKind)
		{
			AdditionalBrowserArguments = additionalBrowserArguments;
			Language = language;
			TargetCompatibleBrowserVersion = targetCompatibleBrowserVersion;
			AllowSingleSignOnUsingOSPrimaryAccount = (allowSingleSignOnUsingOSPrimaryAccount ? 1 : 0);
			CustomSchemeRegistrations = customSchemeRegistrations;
			ReleaseChannels = (COREWEBVIEW2_RELEASE_CHANNELS)releaseChannels;
			ChannelSearchKind = (COREWEBVIEW2_CHANNEL_SEARCH_KIND)channelSearchKind;
		}

		public RawOptions(string additionalBrowserArguments, string language, string targetCompatibleBrowserVersion, bool allowSingleSignOnUsingOSPrimaryAccount, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations)
		{
			AdditionalBrowserArguments = additionalBrowserArguments;
			Language = language;
			TargetCompatibleBrowserVersion = targetCompatibleBrowserVersion;
			AllowSingleSignOnUsingOSPrimaryAccount = (allowSingleSignOnUsingOSPrimaryAccount ? 1 : 0);
			CustomSchemeRegistrations = customSchemeRegistrations;
			ReleaseChannels = (COREWEBVIEW2_RELEASE_CHANNELS)15;
			ChannelSearchKind = COREWEBVIEW2_CHANNEL_SEARCH_KIND.COREWEBVIEW2_CHANNEL_SEARCH_KIND_MOST_STABLE;
		}
	}

	internal object _rawNative;

	internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptionsValue;

	internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2Value;

	internal ICoreWebView2EnvironmentOptions3 _nativeICoreWebView2EnvironmentOptions3Value;

	internal ICoreWebView2EnvironmentOptions4 _nativeICoreWebView2EnvironmentOptions4Value;

	internal ICoreWebView2EnvironmentOptions5 _nativeICoreWebView2EnvironmentOptions5Value;

	internal ICoreWebView2EnvironmentOptions6 _nativeICoreWebView2EnvironmentOptions6Value;

	internal ICoreWebView2EnvironmentOptions8 _nativeICoreWebView2EnvironmentOptions8Value;

	internal ICoreWebView2EnvironmentOptions7 _nativeICoreWebView2EnvironmentOptions7Value;

	private const CoreWebView2ReleaseChannels kAllChannelsFlag = CoreWebView2ReleaseChannels.Stable | CoreWebView2ReleaseChannels.Beta | CoreWebView2ReleaseChannels.Dev | CoreWebView2ReleaseChannels.Canary;

	internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptions
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptionsValue == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptionsValue = (ICoreWebView2EnvironmentOptions)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptionsValue;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptionsValue = value;
		}
	}

	/// <summary>
	/// Gets or sets the additional browser arguments to change the behavior of the WebView.
	/// </summary><remarks><para>
	/// The arguments are passed to the browser process as part of the command. For more information about using command-line switches with Chromium browser processes, navigate to [Run Chromium with Flags](https://aka.ms/RunChromiumWithFlags). The value appended to a switch is appended to the browser process, for example, in <c>--edge-webview-switches=xxx</c> the value is <c>xxx</c>. If you specify a switch that is important to WebView functionality, it is ignored, for example, <c>--user-data-dir</c>. Specific features are disabled internally and blocked from being enabled. If a switch is specified multiple times, only the last instance is used.
	/// </para><para>
	/// A merge of the different values of the same switch is not attempted, except for disabled and enabled features. The features specified by <c>--enable-features</c> and <c>--disable-features</c> will be merged with simple logic -- the features are the union of the specified features and built-in features. If a feature is disabled, it is removed from the enabled features list.
	/// </para><para>
	/// If you specify command-line switches and sets this property, the <c>--edge-webview-switches</c> value takes precedence and is processed last. If a switch fails to parse, the switch is ignored. The default state for the operation is to run the browser process with no extra flags.
	/// </para><para>
	/// Please note that calling this API twice will replace the previous value rather than appending to it. If there are multiple switches, there should be a space in between them. The one exception is if multiple features are being enabled/disabled for a single switch, in which case the features should be comma-separated. Ex. "--disable-features=feature1,feature2 --some-other-switch --do-something"
	/// </para></remarks>
	public string AdditionalBrowserArguments
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether to enable single sign on with Azure Active Directory (AAD) resources inside WebView using the logged in Windows account and single sign on (SSO) with web sites using Microsoft account associated with the login in Windows account.
	/// </summary><remarks>
	/// The default value is <c>false</c>. Universal Windows Platform apps must also declare <c>enterpriseCloudSSO</c> [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) for the single sign on (SSO) to work.
	/// </remarks>
	public bool AllowSingleSignOnUsingOSPrimaryAccount
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the default display language for WebView.
	/// </summary><remarks>
	/// It applies to browser UIs such as context menu and dialogs. It also applies to the <c>accept-languages</c> HTTP header that WebView sends to websites. The intended locale value is in the format of BCP 47 Language Tags. More information can be found from [IETF BCP47](https://www.ietf.org/rfc/bcp/bcp47.html).
	/// </remarks>
	public string Language
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.Language;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions.Language = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the version of the WebView2 Runtime binaries required to be compatible with your app.
	/// </summary><remarks>
	/// This defaults to the WebView2 Runtime version that corresponds with the version of the SDK the app is using. The format of this value is the same as the format of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Environment.BrowserVersionString" /> property and other BrowserVersion values. Only the version part of the BrowserVersion value is respected. The channel suffix, if it exists, is ignored. The version of the WebView2 Runtime binaries actually used may be different from the specified TargetCompatibleBrowserVersion. The binaries are only guaranteed to be compatible. Verify the actual version on the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Environment.BrowserVersionString" /> property.
	/// </remarks>
	public string TargetCompatibleBrowserVersion
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions2Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions2Value = (ICoreWebView2EnvironmentOptions2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions2Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions2Value = value;
		}
	}

	/// <summary>
	/// Determines whether other processes can create <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> from <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> created with the same user data folder and therefore sharing the same WebView browser process instance.
	/// </summary><remarks>
	/// The default value is <c>false</c>.
	/// </remarks>
	public bool ExclusiveUserDataFolderAccess
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions2.ExclusiveUserDataFolderAccess != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions2.ExclusiveUserDataFolderAccess = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2EnvironmentOptions3 _nativeICoreWebView2EnvironmentOptions3
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions3Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions3Value = (ICoreWebView2EnvironmentOptions3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions3Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions3Value = value;
		}
	}

	/// <summary>
	/// When <c>IsCustomCrashReportingEnabled</c> is set to <c>true</c>, Windows won't send crash data to Microsoft endpoint.
	/// </summary><remarks>
	/// The default value is <c>false</c>. In this case, WebView will respect OS consent.
	/// </remarks>
	public bool IsCustomCrashReportingEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions3.IsCustomCrashReportingEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions3.IsCustomCrashReportingEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2EnvironmentOptions4 _nativeICoreWebView2EnvironmentOptions4
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions4Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions4Value = (ICoreWebView2EnvironmentOptions4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions4Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions4Value = value;
		}
	}

	internal ICoreWebView2EnvironmentOptions5 _nativeICoreWebView2EnvironmentOptions5
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions5Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions5Value = (ICoreWebView2EnvironmentOptions5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions5Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions5Value = value;
		}
	}

	/// <summary>
	/// The <c>EnableTrackingPrevention</c> property is used to enable/disable tracking prevention feature in WebView2. This property enable/disable tracking prevention for all the WebView2's created in the same environment. By default this feature is enabled to block potentially harmful trackers and trackers from sites that aren't visited before and set to <c>CoreWebView2TrackingPreventionLevel.Balanced</c> or whatever value was last changed/persisted on the profile.
	/// </summary><remarks>
	/// You can set this property to false to disable the tracking prevention feature if the app only renders content in the WebView2 that is known to be safe. Disabling this feature when creating environment also improves runtime performance by skipping related code.
	///
	/// You shouldn't disable this property if WebView2 is being used as a "full browser" with arbitrary navigation and should protect end user privacy.
	///
	/// There is <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.PreferredTrackingPreventionLevel" /> property to control levels of tracking prevention of the WebView2's associated with a same profile. However, you can also disable tracking prevention later using <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.PreferredTrackingPreventionLevel" /> property and <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2TrackingPreventionLevel.None" /> value but that doesn't improves runtime performance.
	///
	/// See <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.PreferredTrackingPreventionLevel" /> for more details.
	///
	/// Tracking prevention protects users from online tracking by restricting the ability of trackers to access browser-based storage as well as the network. See [Tracking prevention](/microsoft-edge/web-platform/tracking-prevention).
	/// </remarks>
	public bool EnableTrackingPrevention
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions5.EnableTrackingPrevention != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions5.EnableTrackingPrevention = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2EnvironmentOptions6 _nativeICoreWebView2EnvironmentOptions6
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions6Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions6Value = (ICoreWebView2EnvironmentOptions6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions6Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions6Value = value;
		}
	}

	/// <summary>
	/// Enable/disable browser extensions.
	/// </summary><remarks>
	/// When <c>AreBrowserExtensionsEnabled</c> is set to <c>true</c>, new extensions can be added to user profile and used. <c>AreBrowserExtensionsEnabled</c> is default to be <c>false</c>, in this case, new extensions can't be installed, and already installed extension won't be available to use in user profile. If connecting to an already running environment with a different value for <c>AreBrowserExtensionsEnabled</c> property, it will fail with <c>HRESULT_FROM_WIN32(ERROR_INVALID_STATE)</c>. See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2BrowserExtension" /> for Extensions API details.
	/// </remarks>
	public bool AreBrowserExtensionsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions6.AreBrowserExtensionsEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions6.AreBrowserExtensionsEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2EnvironmentOptions8 _nativeICoreWebView2EnvironmentOptions8
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions8Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions8Value = (ICoreWebView2EnvironmentOptions8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions8Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions8Value = value;
		}
	}

	/// <summary></summary>
	public CoreWebView2ScrollbarStyle ScrollBarStyle
	{
		get
		{
			try
			{
				return (CoreWebView2ScrollbarStyle)_nativeICoreWebView2EnvironmentOptions8.ScrollBarStyle;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions8.ScrollBarStyle = (COREWEBVIEW2_SCROLLBAR_STYLE)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2EnvironmentOptions7 _nativeICoreWebView2EnvironmentOptions7
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions7Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions7Value = (ICoreWebView2EnvironmentOptions7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions7Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions7Value = value;
		}
	}

	/// <summary>
	/// Set <c>ChannelSearchKind</c> to <c>CoreWebView2ChannelSearchKind.LeastStable</c> so that the WebView2 loader searches for binaries from least to most stable: Canary -&gt; Dev -&gt; Beta -&gt; WebView2 Runtime.
	/// </summary><remarks>
	/// The <c>ChannelSearchKind</c> property is <c>CoreWebView2ChannelSearchKind.MostStable</c> by default and environment creation searches for a release channel on the machine from most to least stable using the first channel found. The default search order is: WebView2 Release -&gt; Beta -&gt; Dev -&gt; Canary. Set <c>ChannelSearchKind</c> to <c>CoreWebView2ChannelSearchKind.LeastStable</c> to reverse the search order so that environment creation searches for a channel from least to most stable. If a <c>ReleaseChannels</c> has been provided, environment creation will only search for channels in the set. See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ReleaseChannels" /> for more details on channels. This property can be overridden by the corresponding registry key <c>ChannelSearchKind</c> or the environment variable <c>WEBVIEW2_CHANNEL_SEARCH_KIND</c>. Set the value to <c>1</c> to reverse the search order. See <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(System.String,System.String,Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions)" /> for more details on overrides.
	/// </remarks>
	public CoreWebView2ChannelSearchKind ChannelSearchKind
	{
		get
		{
			try
			{
				return (CoreWebView2ChannelSearchKind)_nativeICoreWebView2EnvironmentOptions7.ChannelSearchKind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions7.ChannelSearchKind = (COREWEBVIEW2_CHANNEL_SEARCH_KIND)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Sets the <c>ReleaseChannels</c>, which is a mask of one or more <c>CoreWebView2ReleaseChannels</c> indicating which channels environment creation should search for.</summary><remarks>
	/// OR operation(s) can be applied to multiple <c>CoreWebView2ReleaseChannels</c> to create a mask. The default value is a mask of all the channels. By default, environment creation searches for channels from most to least stable, using the first channel found on the device. When <c>ReleaseChannels</c> is provided, environment creation will only search for the channels specified in the set. Set <c>ChannelSearchKind</c> to <c>CoreWebView2ChannelSearchKind.LeastStable</c> to reverse the search order so that environment creation searches for the least stable build first. See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ReleaseChannels" /> for descriptions of each channel. Environment creation fails if it is unable to find any channel from the <c>ReleaseChannels</c> installed on the device. Use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetAvailableBrowserVersionString(System.String,Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions)" /> to verify which channel is used. If both a <c>BrowserExecutableFolder</c> and <c>ReleaseChannels</c> are provided, the <c>BrowserExecutableFolder</c> takes precedence. The <c>ReleaseChannels</c> can be overridden by the corresponding registry override <c>ReleaseChannels</c> or the environment variable <c>WEBVIEW2_RELEASE_CHANNELS</c>. Set the value to a comma-separated string of integers, which map to the following release channel values: Stable (0), Beta (1), Dev (2), and Canary (3). For example, the values "0,2" and "2,0" indicate that environment creation should only search for Dev channel and the WebView2 Runtime, using the order indicated by <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.ChannelSearchKind" />. Environment creation attempts to interpret each integer and treats any invalid entry as Stable channel.
	/// <list type="table"><listheader><description>ReleaseChannels</description><description>Channel Search Kind: Most Stable (default)</description><description>Channel Search Kind: Least Stable</description></listheader><item><description>CoreWebView2ReleaseChannels.Beta | CoreWebView2ReleaseChannels.Stable</description><description>WebView2 Runtime -&gt; Beta</description><description>Beta -&gt; WebView2 Runtime</description></item><item><description>CoreWebView2ReleaseChannels.Canary | CoreWebView2ReleaseChannels.Dev | CoreWebView2ReleaseChannels.Beta | CoreWebView2ReleaseChannels.Stable</description><description>WebView2 Runtime -&gt; Beta -&gt; Dev -&gt; Canary</description><description>Canary -&gt; Dev -&gt; Beta -&gt; WebView2 Runtime</description></item><item><description>CoreWebView2ReleaseChannels.Canary</description><description>Canary</description><description>Canary</description></item><item><description>CoreWebView2ReleaseChannels.Beta | CoreWebView2ReleaseChannels.Canary | CoreWebView2ReleaseChannels.Stable</description><description>WebView2 Runtime -&gt; Beta -&gt; Canary</description><description>Canary -&gt; Beta -&gt; WebView2 Runtime</description></item></list></remarks>
	public CoreWebView2ReleaseChannels ReleaseChannels
	{
		get
		{
			try
			{
				return (CoreWebView2ReleaseChannels)_nativeICoreWebView2EnvironmentOptions7.ReleaseChannels;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2EnvironmentOptions7.ReleaseChannels = (COREWEBVIEW2_RELEASE_CHANNELS)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2EnvironmentOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// List of custom scheme registrations to be applied to the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />
	/// </summary>
	public List<CoreWebView2CustomSchemeRegistration> CustomSchemeRegistrations { get; }

	internal CoreWebView2EnvironmentOptions(object rawCoreWebView2EnvironmentOptions)
	{
		_rawNative = rawCoreWebView2EnvironmentOptions;
	}

	/// <summary>
	/// Initializes a new instance of the CoreWebView2EnvironmentOptions class.
	/// </summary>
	/// <param name="additionalBrowserArguments">
	/// AdditionalBrowserArguments can be specified to change the behavior of
	/// the WebView.
	/// </param>
	/// <param name="language">
	/// The default language that WebView will run with.
	/// </param>
	/// <param name="targetCompatibleBrowserVersion">
	/// The version of the Edge WebView2 Runtime binaries required to be
	/// compatible with the calling application.
	/// </param>
	/// <param name="allowSingleSignOnUsingOSPrimaryAccount">
	/// Set to true if single sign on be enabled using the end user's OS primary
	/// account. Defaults to false.
	/// </param>
	/// <param name="customSchemeRegistrations">
	/// List of custom scheme registrations to be applied to the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />.
	/// </param>
	public CoreWebView2EnvironmentOptions(string additionalBrowserArguments = null, string language = null, string targetCompatibleBrowserVersion = null, bool allowSingleSignOnUsingOSPrimaryAccount = false, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations = null)
	{
		targetCompatibleBrowserVersion = BrowserInfo.PRODUCT_VERSION;
		_nativeICoreWebView2EnvironmentOptions8 = (ICoreWebView2EnvironmentOptions8)(_nativeICoreWebView2EnvironmentOptions7 = (ICoreWebView2EnvironmentOptions7)(_nativeICoreWebView2EnvironmentOptions6 = (ICoreWebView2EnvironmentOptions6)(_nativeICoreWebView2EnvironmentOptions5 = (ICoreWebView2EnvironmentOptions5)(_nativeICoreWebView2EnvironmentOptions4 = (ICoreWebView2EnvironmentOptions4)(_nativeICoreWebView2EnvironmentOptions3 = (ICoreWebView2EnvironmentOptions3)(_nativeICoreWebView2EnvironmentOptions2 = (ICoreWebView2EnvironmentOptions2)(_nativeICoreWebView2EnvironmentOptions = new RawOptions(additionalBrowserArguments, language, targetCompatibleBrowserVersion, allowSingleSignOnUsingOSPrimaryAccount, customSchemeRegistrations))))))));
		CustomSchemeRegistrations = customSchemeRegistrations;
	}

	/// <summary>
	/// Initializes a new instance of the CoreWebView2EnvironmentOptions class.
	/// </summary>
	/// <param name="additionalBrowserArguments">
	/// AdditionalBrowserArguments can be specified to change the behavior of
	/// the WebView.
	/// </param>
	/// <param name="language">
	/// The default language that WebView will run with.
	/// </param>
	/// <param name="targetCompatibleBrowserVersion">
	/// The version of the Edge WebView2 Runtime binaries required to be
	/// compatible with the calling application.
	/// </param>
	/// <param name="allowSingleSignOnUsingOSPrimaryAccount">
	/// Set to true if single sign on be enabled using the end user's OS primary
	/// account. Defaults to false.
	/// </param>
	/// <param name="customSchemeRegistrations">
	/// List of custom scheme registrations to be applied to the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />.
	/// </param>
	/// <param name="channelSearchKind">
	/// Set to CoreWebView2ChannelSearchKind.LeastStable so that environment
	/// creation searches for binaries from least to most stable:
	/// Canary -&gt; Dev -&gt; Beta -&gt; WebView2 Runtime.
	/// Defaults to CoreWebView2RuntimeChannel.MostStable.
	/// </param>
	/// <param name="releaseChannels">
	/// The release channels that are searched for during environment creation.
	/// </param>
	public CoreWebView2EnvironmentOptions(string additionalBrowserArguments, string language, string targetCompatibleBrowserVersion, bool allowSingleSignOnUsingOSPrimaryAccount, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations, CoreWebView2ReleaseChannels releaseChannels = CoreWebView2ReleaseChannels.Stable | CoreWebView2ReleaseChannels.Beta | CoreWebView2ReleaseChannels.Dev | CoreWebView2ReleaseChannels.Canary, CoreWebView2ChannelSearchKind channelSearchKind = CoreWebView2ChannelSearchKind.MostStable)
	{
		targetCompatibleBrowserVersion = BrowserInfo.PRODUCT_VERSION;
		_nativeICoreWebView2EnvironmentOptions8 = (ICoreWebView2EnvironmentOptions8)(_nativeICoreWebView2EnvironmentOptions7 = (ICoreWebView2EnvironmentOptions7)(_nativeICoreWebView2EnvironmentOptions6 = (ICoreWebView2EnvironmentOptions6)(_nativeICoreWebView2EnvironmentOptions5 = (ICoreWebView2EnvironmentOptions5)(_nativeICoreWebView2EnvironmentOptions4 = (ICoreWebView2EnvironmentOptions4)(_nativeICoreWebView2EnvironmentOptions3 = (ICoreWebView2EnvironmentOptions3)(_nativeICoreWebView2EnvironmentOptions2 = (ICoreWebView2EnvironmentOptions2)(_nativeICoreWebView2EnvironmentOptions = new RawOptions(additionalBrowserArguments, language, targetCompatibleBrowserVersion, allowSingleSignOnUsingOSPrimaryAccount, customSchemeRegistrations, releaseChannels, channelSearchKind))))))));
		CustomSchemeRegistrations = customSchemeRegistrations;
	}
}
