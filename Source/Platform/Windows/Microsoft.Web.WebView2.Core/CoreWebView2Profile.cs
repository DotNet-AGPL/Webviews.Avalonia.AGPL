using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Multiple profiles can be created under a single user data directory but with separated cookies, user preference settings, and various data storage etc.. If the CoreWebView2 was created with a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions" />, the CoreWebView2Profile will match those specified options. Otherwise if this CoreWebView2 was created without a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions" />, then this will be the default CoreWebView2Profile for the corresponding CoreWebView2Environment.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
public class CoreWebView2Profile
{
	internal object _rawNative;

	internal ICoreWebView2Profile _nativeICoreWebView2ProfileValue;

	internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2Value;

	internal ICoreWebView2Profile3 _nativeICoreWebView2Profile3Value;

	internal ICoreWebView2Profile4 _nativeICoreWebView2Profile4Value;

	internal ICoreWebView2Profile5 _nativeICoreWebView2Profile5Value;

	internal ICoreWebView2Profile6 _nativeICoreWebView2Profile6Value;

	internal ICoreWebView2Profile7 _nativeICoreWebView2Profile7Value;

	internal ICoreWebView2Profile8 _nativeICoreWebView2Profile8Value;

	private EventRegistrationToken _DeletedToken;

	private EventHandler<object> privateDeleted;

	internal ICoreWebView2Profile _nativeICoreWebView2Profile
	{
		get
		{
			if (_nativeICoreWebView2ProfileValue == null)
			{
				try
				{
					_nativeICoreWebView2ProfileValue = (ICoreWebView2Profile)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ProfileValue;
		}
		set
		{
			_nativeICoreWebView2ProfileValue = value;
		}
	}

	/// <summary>
	/// The default download folder path.
	/// </summary><remarks>
	/// The default value is the system default download folder path for the user. The default download folder path is persisted in the user data folder across sessions. The value should be an absolute path to a folder that the user and application can write to. Throws an exception if the value is invalid, and the default download path is not changed. Otherwise the path is changed immediately. If the directory does not yet exist, it is created at the time of the next download. If the host application does not have permission to create the directory, then the user is prompted to provide a new path through the Save As dialog. The user can override the default download folder path for a given download by choosing a different path in the Save As dialog.
	/// </remarks>
	public string DefaultDownloadFolderPath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Profile.DefaultDownloadFolderPath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Profile.DefaultDownloadFolderPath = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// InPrivate mode is enabled or not.</summary>
	public bool IsInPrivateModeEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Profile.IsInPrivateModeEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The PreferredColorScheme property sets the overall color scheme of the WebView2s associated with this profile.
	/// </summary><remarks>
	/// This sets the color scheme for WebView2 UI like dialogs, prompts, and menus by setting the media feature <c>prefers-color-scheme</c>.
	/// The default value for this is <c>CoreWebView2PreferredColorScheme.Auto</c>, which will follow whatever color scheme the OS is currently set to.
	/// </remarks>
	public CoreWebView2PreferredColorScheme PreferredColorScheme
	{
		get
		{
			try
			{
				return (CoreWebView2PreferredColorScheme)_nativeICoreWebView2Profile.PreferredColorScheme;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Profile.PreferredColorScheme = (COREWEBVIEW2_PREFERRED_COLOR_SCHEME)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The name of the profile.</summary>
	public string ProfileName
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Profile.ProfileName;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Full path of the profile directory.</summary>
	public string ProfilePath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Profile.ProfilePath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2
	{
		get
		{
			if (_nativeICoreWebView2Profile2Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile2Value = (ICoreWebView2Profile2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile2Value;
		}
		set
		{
			_nativeICoreWebView2Profile2Value = value;
		}
	}

	internal ICoreWebView2Profile3 _nativeICoreWebView2Profile3
	{
		get
		{
			if (_nativeICoreWebView2Profile3Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile3Value = (ICoreWebView2Profile3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile3Value;
		}
		set
		{
			_nativeICoreWebView2Profile3Value = value;
		}
	}

	/// <summary>
	/// The <c>PreferredTrackingPreventionLevel</c> property allows you to control levels of tracking prevention for WebView2 which are associated with a profile. This level would apply to the context of the profile. That is, all WebView2s sharing the same profile will be affected and also the value is persisted in the user data folder.
	///
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2TrackingPreventionLevel" /> for descriptions of levels.
	/// </summary><remarks>
	/// If tracking prevention feature is enabled when creating the WebView2 environment, you can also disable tracking prevention later using this property and <c>CoreWebView2TrackingPreventionLevel.None</c> value but that doesn't improves runtime performance.
	///
	/// There is <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.EnableTrackingPrevention" /> property to enable/disable tracking prevention feature for all the WebView2's created in the same environment. If enabled, PreferredTrackingPreventionLevel is set to <c>CoreWebView2TrackingPreventionLevel.Balanced</c> by default for all the WebView2's and profiles created in the same environment or is set to the level whatever value was last changed/persisted to the profile. If disabled PreferredTrackingPreventionLevel is not respected by WebView2. If PreferredTrackingPreventionLevel is set when the feature is disabled, the property value get changed and persisted but it will takes effect only if <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.EnableTrackingPrevention" /> is true.
	///
	/// See <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.EnableTrackingPrevention" /> for more details.
	/// </remarks>
	public CoreWebView2TrackingPreventionLevel PreferredTrackingPreventionLevel
	{
		get
		{
			try
			{
				return (CoreWebView2TrackingPreventionLevel)_nativeICoreWebView2Profile3.PreferredTrackingPreventionLevel;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Profile3.PreferredTrackingPreventionLevel = (COREWEBVIEW2_TRACKING_PREVENTION_LEVEL)value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Profile4 _nativeICoreWebView2Profile4
	{
		get
		{
			if (_nativeICoreWebView2Profile4Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile4Value = (ICoreWebView2Profile4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile4Value;
		}
		set
		{
			_nativeICoreWebView2Profile4Value = value;
		}
	}

	internal ICoreWebView2Profile5 _nativeICoreWebView2Profile5
	{
		get
		{
			if (_nativeICoreWebView2Profile5Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile5Value = (ICoreWebView2Profile5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile5Value;
		}
		set
		{
			_nativeICoreWebView2Profile5Value = value;
		}
	}

	/// <summary>
	/// Get the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CookieManager" /> which Creates, adds or updates, gets, or or view the cookies for the current profile.
	/// </summary><remarks>
	/// All CoreWebView2s associated with this profile share the same cookie values. Changes to cookies in this cookie manager apply to all CoreWebView2s associated with this profile.
	/// </remarks><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CookieManager" />
	public CoreWebView2CookieManager CookieManager
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2Profile5.CookieManager == null) ? null : new CoreWebView2CookieManager(_nativeICoreWebView2Profile5.CookieManager);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Profile6 _nativeICoreWebView2Profile6
	{
		get
		{
			if (_nativeICoreWebView2Profile6Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile6Value = (ICoreWebView2Profile6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile6Value;
		}
		set
		{
			_nativeICoreWebView2Profile6Value = value;
		}
	}

	/// <summary>
	/// Determines whether general form information will be saved and autofilled.
	/// </summary><remarks>
	/// General autofill information includes information like names, street and email addresses, phone numbers, and arbitrary input. This excludes password information. When disabled, no suggestions appear, and no new information is saved.
	/// When enabled, information is saved, suggestions appear, and clicking on one will populate the form fields. The default value is <c>true</c>. It will apply immediately after setting.
	/// This property has the same value as <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsGeneralAutofillEnabled" />, and changing one will change the other. All WebView2s  with the same <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Profile" /> will share the same value for this property, so for the WebView2s with the same profile, their <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsGeneralAutofillEnabled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsGeneralAutofillEnabled" /> will always have the same value.
	/// </remarks>
	public bool IsGeneralAutofillEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Profile6.IsGeneralAutofillEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Profile6.IsGeneralAutofillEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Determines whether password information will be autosaved.
	/// </summary><remarks>
	/// When disabled, no new password data is saved and no Save/Update Password prompts are displayed. However, if there was password data already saved before disabling this setting, then that password information is auto-populated, suggestions are shown and clicking on one will populate the fields.
	/// When enabled, password information is auto-populated, suggestions are shown and clicking on one will populate the fields, new data is saved, and a Save/Update Password prompt is displayed. The default value is <c>false</c>. It will apply immediately after setting.
	/// This property has the same value as <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsPasswordAutosaveEnabled" />, and changing one will change the other. All WebView2s with the same <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Profile" /> will share the same value for this property, so for the WebView2s with the same profile, their <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsPasswordAutosaveEnabled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsPasswordAutosaveEnabled" /> will always have the same value.
	/// </remarks>
	public bool IsPasswordAutosaveEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Profile6.IsPasswordAutosaveEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2Profile6.IsPasswordAutosaveEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Profile7 _nativeICoreWebView2Profile7
	{
		get
		{
			if (_nativeICoreWebView2Profile7Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile7Value = (ICoreWebView2Profile7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile7Value;
		}
		set
		{
			_nativeICoreWebView2Profile7Value = value;
		}
	}

	internal ICoreWebView2Profile8 _nativeICoreWebView2Profile8
	{
		get
		{
			if (_nativeICoreWebView2Profile8Value == null)
			{
				try
				{
					_nativeICoreWebView2Profile8Value = (ICoreWebView2Profile8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Profile8Value;
		}
		set
		{
			_nativeICoreWebView2Profile8Value = value;
		}
	}

	/// <summary>
	/// Raised when profile is marked for deletion.
	/// </summary><remarks>
	/// When this event is raised, the CoreWebView2Profile and its corresponding CoreWebView2s have been closed, and cannot be used anymore.
	/// </remarks>
	public event EventHandler<object> Deleted
	{
		add
		{
			if (privateDeleted == null)
			{
				try
				{
					_nativeICoreWebView2Profile8.add_Deleted(new CoreWebView2ProfileDeletedEventHandler(OnDeleted), out _DeletedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateDeleted = (EventHandler<object>)Delegate.Combine(privateDeleted, value);
		}
		remove
		{
			privateDeleted = (EventHandler<object>)Delegate.Remove(privateDeleted, value);
			if (privateDeleted != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Profile8.remove_Deleted(_DeletedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2Profile(object rawCoreWebView2Profile)
	{
		_rawNative = rawCoreWebView2Profile;
	}

	/// <summary>
	/// Clear the browsing data of the associated profile.</summary><remarks>
	/// Clears browsing data on the profile the method is called on. Additional optional parameters include the start time and end time to clear the browsing data between as well as the data specific data kinds to clear on the profile. The method may be overloaded to take:
	///
	/// <list type="bullet"><item><description>
	/// No parameters - in which the entirety of the data on the profile will be cleared.
	/// </description></item><item><description>
	/// The data kind(s) - in which the data kind(s) will be cleared for their entirety.
	/// </description></item><item><description>
	/// The data kind(s), start time, and end time - in which the data kind(s) will be cleared between the start and end time. The start time will be offset by -1.0 and the end time will be offset by +1.0 to include the last fractional second on each respective end. The start time is inclusive in the time period while the end time is exclusive.
	/// </description></item></list>
	///
	/// The exposed methods are as follows:
	/// <code>
	/// ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds);
	/// ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTime startTime, DateTime endTime);
	/// ClearBrowsingDataAsync();
	/// </code></remarks>
	public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds)
	{
		CoreWebView2ClearBrowsingDataCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
			_nativeICoreWebView2Profile2.ClearBrowsingData((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	/// <summary>
	/// Clear the entirety of the browsing data associated with the profile
	/// it is called on. It clears the data regardless of timestamp.</summary>
	public async Task ClearBrowsingDataAsync()
	{
		CoreWebView2ClearBrowsingDataCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
			_nativeICoreWebView2Profile2.ClearBrowsingDataAll(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	/// <summary>
	/// Sets permission state for the given permission kind and origin asynchronously.
	/// </summary><remarks>
	/// The state change persists across sessions until it is changed by another call to `SetPermissionState`, or by setting the `State` property in `PermissionRequestedEventArgs`. Setting the state to <c>CoreWebView2PermissionState.Default</c> will erase any state saved in the profile and restore the default behavior. The origin should have a valid scheme and host (e.g. "https://www.example.com"), otherwise the method fails. Additional URI parts like path and fragment are ignored. For example, "https://wwww.example.com/app1/index.html/" is treated the same as "https://wwww.example.com". See the [MDN origin definition](https://developer.mozilla.org/docs/Glossary/Origin) for more details.
	/// </remarks>
	public async Task SetPermissionStateAsync(CoreWebView2PermissionKind PermissionKind, string origin, CoreWebView2PermissionState State)
	{
		CoreWebView2SetPermissionStateCompletedHandler handler;
		try
		{
			handler = new CoreWebView2SetPermissionStateCompletedHandler();
			_nativeICoreWebView2Profile4.SetPermissionState((COREWEBVIEW2_PERMISSION_KIND)PermissionKind, origin, (COREWEBVIEW2_PERMISSION_STATE)State, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	/// <summary>
	/// Invokes the handler with a collection of all nondefault permission settings.
	/// </summary><remarks>
	/// Use this method to get the permission state set in the current and previous sessions.
	/// </remarks>
	public async Task<IReadOnlyList<CoreWebView2PermissionSetting>> GetNonDefaultPermissionSettingsAsync()
	{
		CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler handler;
		try
		{
			handler = new CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler();
			_nativeICoreWebView2Profile4.GetNonDefaultPermissionSettings(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Add a browser extension to the current user profile from <c>extensionFolderPath</c>.</summary><param name="extensionFolderPath">The manifest.json folder path.</param><remarks>
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2BrowserExtension" /> for descriptions of browser extensions.
	/// Adds the [browser extension](https://developer.mozilla.org/docs/Mozilla/Add-ons/WebExtensions) using the extension path for unpacked extensions from the local device. Extension is running right after installation.
	/// The extension folder path is the topmost folder of an unpacked browser extension and contains the browser extension manifest file.
	/// If the <c>extensionFolderPath</c> is an invalid path or doesn't contain the extension manifest.json file, this function will return <c>ERROR_FILE_NOT_FOUND</c> to callers.
	/// Installed extension will default <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2BrowserExtension.IsEnabled" /> to true. When <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.AreBrowserExtensionsEnabled" />  is <c>false</c>, <c>AddBrowserExtension</c> will fail and return HRESULT <c>ERROR_NOT_SUPPORTED</c>.
	/// During installation, the content of the extension is not copied to the user data folder. Once the extension is installed, changing the content of the extension will cause the extension to be removed from the installed profile.
	/// When an extension is added the extension is persisted in the corresponding profile. The extension will still be installed the next time you use this profile.
	/// When an extension is installed from a folder path, adding the same extension from the same folder path means reinstalleing this extension. When two extensions with the same Id are installed, only the later installed extension will be kept.
	/// The following summarizes the possible error values that can be returned from <c>AddBrowserExtension</c> and a description of why these errors occur.
	/// <list type="table"><listheader><description>Error value</description><description>Description</description></listheader><item><description><c>HRESULT_FROM_WIN32(ERROR_NOT_SUPPORTED)</c></description><description>Extensions are disabled.</description></item><item><description><c>HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND)</c></description><description>Cannot find <c>manifest.json</c> file or it is not a valid extension manifest.</description></item><item><description><c>E_ACCESSDENIED</c></description><description>Cannot load extension with file or directory name starting with <c>_</c>, reserved for use by the system.</description></item><item><description><c>E_FAIL</c></description><description>Extension failed to install with other unknown reasons.</description></item></list></remarks>
	public async Task<CoreWebView2BrowserExtension> AddBrowserExtensionAsync(string extensionFolderPath)
	{
		CoreWebView2ProfileAddBrowserExtensionCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ProfileAddBrowserExtensionCompletedHandler();
			_nativeICoreWebView2Profile7.AddBrowserExtension(extensionFolderPath, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Gets a snapshot of the set of extensions on current user profile.
	///
	/// See <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2BrowserExtension" /> for descriptions of browser extensions.
	/// </summary><remarks>
	/// Gets a snapshot of the set of extensions installed at the time <c>GetBrowserExtensions</c> is called. If an extension is installed or uninstalled after <c>GetBrowserExtensions</c> completes, the list returned by <c>GetBrowserExtensions</c> remains the same. When <c>AreBrowserExtensionsEnabled</c> is <c>false</c>, <c>GetBrowserExtensions</c> won't return any extensions on current user profile.
	/// </remarks>
	public async Task<IReadOnlyList<CoreWebView2BrowserExtension>> GetBrowserExtensionsAsync()
	{
		CoreWebView2ProfileGetBrowserExtensionsCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ProfileGetBrowserExtensionsCompletedHandler();
			_nativeICoreWebView2Profile7.GetBrowserExtensions(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	internal void OnDeleted(object args)
	{
		privateDeleted?.Invoke(this, args);
	}

	/// <summary>
	/// Delete this profile and close the corresponding CoreWebView2s.
	/// </summary><remarks>
	/// After the API is called, the profile will be marked for deletion. The local profile's directory will be deleted at browser process exit. If it fails to delete, because something else is holding the files open, WebView2 will try to delete the profile at all future browser process starts until successful. The corresponding CoreWebView2s will be closed and the CoreWebView2Profile.Deleted event will be raised. See `CoreWebView2Profile.Deleted` for more information. If you try to create a new profile with the same name as an existing profile that has been marked as deleted but hasn't yet been deleted, profile creation will fail with HRESULT_FROM_WIN32(ERROR_DELETE_PENDING).
	/// </remarks>
	public void Delete()
	{
		try
		{
			_nativeICoreWebView2Profile8.Delete();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Profile members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Profile members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Clear the browsing data for the specified dataKinds between the
	/// startTime and endTime. Overload the ClearBrowsingDataAsync method to
	/// allow for additional time parameters.
	/// </summary>
	public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTime startTime, DateTime endTime)
	{
		CoreWebView2ClearBrowsingDataCompletedHandler handler;
		try
		{
			double startTime2 = new DateTimeOffset(startTime).ToUnixTimeSeconds();
			double endTime2 = new DateTimeOffset(endTime).ToUnixTimeSeconds();
			handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
			_nativeICoreWebView2Profile2.ClearBrowsingDataInTimeRange((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, startTime2, endTime2, handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}
}
