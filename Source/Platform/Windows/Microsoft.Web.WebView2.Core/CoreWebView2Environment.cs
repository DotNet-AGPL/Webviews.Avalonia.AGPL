using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// This represents the WebView2 Environment.
/// WebViews created from an environment run on the Browser process specified with environment parameters and objects created from an environment should be used in the same environment. Using it in different environments are not guaranteed to be compatible and may fail.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary>Interface that provides methods related to the environment settings of CoreWebView2.
/// This interface allows for the creation of new `FindOptions` objects.</summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary></summary>
/// <summary>
/// This represents the WebView2 Environment.
/// </summary>
/// <remarks>
/// WebViews created from an environment run on the Browser process specified with environment parameters and objects created from an environment should be used in the same environment. Using it in different environments are not guaranteed to be compatible and may fail.
/// </remarks>
public class CoreWebView2Environment
{
	private enum ProcessorArchitecture : ushort
	{
		x86 = 0,
		x64 = 9,
		ARM64 = 12,
		Unknown = ushort.MaxValue
	}

	private struct SYSTEM_INFO
	{
		internal ushort wProcessorArchitecture;

		private ushort wReserved;

		private int dwPageSize;

		private IntPtr lpMinimumApplicationAddress;

		private IntPtr lpMaximumApplicationAddress;

		private IntPtr dwActiveProcessorMask;

		private int dwNumberOfProcessors;

		private int dwProcessorType;

		private int dwAllocationGranularity;

		private short wProcessorLevel;

		private short wProcessorRevision;
	}

	internal object _rawNative;

	internal ICoreWebView2Environment _nativeICoreWebView2EnvironmentValue;

	private EventRegistrationToken _NewBrowserVersionAvailableToken;

	private EventHandler<object> privateNewBrowserVersionAvailable;

	internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10Value;

	internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11Value;

	internal ICoreWebView2Environment12 _nativeICoreWebView2Environment12Value;

	internal ICoreWebView2Environment13 _nativeICoreWebView2Environment13Value;

	internal ICoreWebView2Environment14 _nativeICoreWebView2Environment14Value;

	internal ICoreWebView2Environment15 _nativeICoreWebView2Environment15Value;

	internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2Value;

	internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3Value;

	internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5Value;

	private EventRegistrationToken _BrowserProcessExitedToken;

	private EventHandler<CoreWebView2BrowserProcessExitedEventArgs> privateBrowserProcessExited;

	internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6Value;

	internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7Value;

	internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8Value;

	private EventRegistrationToken _ProcessInfosChangedToken;

	private EventHandler<object> privateProcessInfosChanged;

	internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9Value;

	private const char DirectorySeparatorChar = '\\';

	private const char AltDirectorySeparatorChar = '/';

	private const char VolumeSeparatorChar = ':';

	private static bool webView2LoaderLoaded;

	private static string loaderDllFolderPath;

	internal ICoreWebView2Environment _nativeICoreWebView2Environment
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentValue == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentValue = (ICoreWebView2Environment)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentValue;
		}
		set
		{
			_nativeICoreWebView2EnvironmentValue = value;
		}
	}

	/// <summary>
	/// Gets the browser version info of the current <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />, including channel name if it is not the stable channel.
	/// </summary><remarks>
	/// It matches the format of the <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetAvailableBrowserVersionString(System.String)" /> method. Channel names are <c>beta</c>, <c>dev</c>, and <c>canary</c>.
	/// </remarks>
	public string BrowserVersionString
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Environment.BrowserVersionString;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10
	{
		get
		{
			if (_nativeICoreWebView2Environment10Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment10Value = (ICoreWebView2Environment10)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment10Value;
		}
		set
		{
			_nativeICoreWebView2Environment10Value = value;
		}
	}

	internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11
	{
		get
		{
			if (_nativeICoreWebView2Environment11Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment11Value = (ICoreWebView2Environment11)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment11Value;
		}
		set
		{
			_nativeICoreWebView2Environment11Value = value;
		}
	}

	/// <summary>
	/// Gets the failure report folder that all CoreWebView2s created from this environment are using.</summary>
	public string FailureReportFolderPath
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Environment11.FailureReportFolderPath;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Environment12 _nativeICoreWebView2Environment12
	{
		get
		{
			if (_nativeICoreWebView2Environment12Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment12Value = (ICoreWebView2Environment12)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment12Value;
		}
		set
		{
			_nativeICoreWebView2Environment12Value = value;
		}
	}

	internal ICoreWebView2Environment13 _nativeICoreWebView2Environment13
	{
		get
		{
			if (_nativeICoreWebView2Environment13Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment13Value = (ICoreWebView2Environment13)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment13Value;
		}
		set
		{
			_nativeICoreWebView2Environment13Value = value;
		}
	}

	internal ICoreWebView2Environment14 _nativeICoreWebView2Environment14
	{
		get
		{
			if (_nativeICoreWebView2Environment14Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment14Value = (ICoreWebView2Environment14)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment14.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment14Value;
		}
		set
		{
			_nativeICoreWebView2Environment14Value = value;
		}
	}

	internal ICoreWebView2Environment15 _nativeICoreWebView2Environment15
	{
		get
		{
			if (_nativeICoreWebView2Environment15Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment15Value = (ICoreWebView2Environment15)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment15.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment15Value;
		}
		set
		{
			_nativeICoreWebView2Environment15Value = value;
		}
	}

	internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2
	{
		get
		{
			if (_nativeICoreWebView2Environment2Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment2Value = (ICoreWebView2Environment2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment2Value;
		}
		set
		{
			_nativeICoreWebView2Environment2Value = value;
		}
	}

	internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3
	{
		get
		{
			if (_nativeICoreWebView2Environment3Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment3Value = (ICoreWebView2Environment3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment3Value;
		}
		set
		{
			_nativeICoreWebView2Environment3Value = value;
		}
	}

	internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5
	{
		get
		{
			if (_nativeICoreWebView2Environment5Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment5Value = (ICoreWebView2Environment5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment5Value;
		}
		set
		{
			_nativeICoreWebView2Environment5Value = value;
		}
	}

	internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6
	{
		get
		{
			if (_nativeICoreWebView2Environment6Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment6Value = (ICoreWebView2Environment6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment6Value;
		}
		set
		{
			_nativeICoreWebView2Environment6Value = value;
		}
	}

	internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7
	{
		get
		{
			if (_nativeICoreWebView2Environment7Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment7Value = (ICoreWebView2Environment7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment7Value;
		}
		set
		{
			_nativeICoreWebView2Environment7Value = value;
		}
	}

	/// <summary>
	/// Gets the user data folder that all CoreWebView2s created from this environment are using.
	/// </summary><remarks>
	/// This could be either the value passed in by the developer when creating the environment object or the calculated one for default handling. And will always be an absolute path.
	/// </remarks>
	public string UserDataFolder
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Environment7.UserDataFolder;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8
	{
		get
		{
			if (_nativeICoreWebView2Environment8Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment8Value = (ICoreWebView2Environment8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment8Value;
		}
		set
		{
			_nativeICoreWebView2Environment8Value = value;
		}
	}

	internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9
	{
		get
		{
			if (_nativeICoreWebView2Environment9Value == null)
			{
				try
				{
					_nativeICoreWebView2Environment9Value = (ICoreWebView2Environment9)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Environment9Value;
		}
		set
		{
			_nativeICoreWebView2Environment9Value = value;
		}
	}

	/// <summary>
	/// NewBrowserVersionAvailable is raised when a newer version of the WebView2 Runtime is installed and available using WebView2.
	/// </summary><remarks>
	/// To use the newer version of the browser you must create a new environment and WebView. The event is only raised for new version from the same WebView2 Runtime from which the code is running. When not running with installed WebView2 Runtime, no event is raised.
	///
	/// Because a user data folder is only able to be used by one browser process at a time, if you want to use the same user data folder in the WebViews using the new version of the browser, you must close the environment and instance of WebView that are using the older version of the browser first. Or simply prompt the user to restart the app.
	/// </remarks>
	public event EventHandler<object> NewBrowserVersionAvailable
	{
		add
		{
			if (privateNewBrowserVersionAvailable == null)
			{
				try
				{
					_nativeICoreWebView2Environment.add_NewBrowserVersionAvailable(new CoreWebView2NewBrowserVersionAvailableEventHandler(OnNewBrowserVersionAvailable), out _NewBrowserVersionAvailableToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateNewBrowserVersionAvailable = (EventHandler<object>)Delegate.Combine(privateNewBrowserVersionAvailable, value);
		}
		remove
		{
			privateNewBrowserVersionAvailable = (EventHandler<object>)Delegate.Remove(privateNewBrowserVersionAvailable, value);
			if (privateNewBrowserVersionAvailable != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Environment.remove_NewBrowserVersionAvailable(_NewBrowserVersionAvailableToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// BrowserProcessExited is raised when the collection of WebView2 Runtime processes for the browser process of this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> terminate due to browser process failure or normal shutdown (for example, when all associated WebViews are closed), after all resources have been released (including the user data folder).</summary><remarks>
	/// Multiple app processes can share a browser process by creating their webviews from a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> with the same user data folder. When the entire collection of WebView2Runtime processes for the browser process exit, all associated <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> objects receive the BrowserProcessExited event. Multiple processes sharing the same browser process need to coordinate their use of the shared user data folder to avoid race conditions and unnecessary waits. For example, one process should not clear the user data folder at the same time that another process recovers from a crash by recreating its WebView controls; one process should not block waiting for the event if other app processes are using the same browser process (the browser process will not exit until those other processes have closed their webviews too).
	/// Note this is an event from <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />, not <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2" />. The difference between BrowserProcessExited and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> is that BrowserProcessExited is raised for any <strong>browser process</strong> exit (expected or unexpected, after all associated processes have exited too), while <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> is raised for <strong>unexpected</strong> process exits of any kind (browser, render, GPU, and all other types), or for main frame <strong>render process</strong> unresponsiveness. To learn more about the WebView2 Process Model, go to [Process model](/microsoft-edge/webview2/concepts/process-model).
	/// In the case the browser process crashes, both BrowserProcessExited and <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed" /> events are raised, but the order is not guaranteed. These events are intended for different scenarios. It is up to the app to coordinate the handlers so they do not try to perform reliability recovery while also trying to move to a new WebView2 Runtime version or remove the user data folder.
	/// </remarks><example>
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="SubscribeToBrowserProcessExited":::
	/// :::code language="csharp" source="../code/sample/SampleApps/WebView2WpfBrowser/MainWindow.xaml.cs" id="BrowserProcessExited":::
	/// </example>
	public event EventHandler<CoreWebView2BrowserProcessExitedEventArgs> BrowserProcessExited
	{
		add
		{
			if (privateBrowserProcessExited == null)
			{
				try
				{
					_nativeICoreWebView2Environment5.add_BrowserProcessExited(new CoreWebView2BrowserProcessExitedEventHandler(OnBrowserProcessExited), out _BrowserProcessExitedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateBrowserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Combine(privateBrowserProcessExited, value);
		}
		remove
		{
			privateBrowserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Remove(privateBrowserProcessExited, value);
			if (privateBrowserProcessExited != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Environment5.remove_BrowserProcessExited(_BrowserProcessExitedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// ProcessInfosChanged is raised when a collection of WebView2 Runtime processes changed due to new process being detected or when a existing process gone away.</summary>
	public event EventHandler<object> ProcessInfosChanged
	{
		add
		{
			if (privateProcessInfosChanged == null)
			{
				try
				{
					_nativeICoreWebView2Environment8.add_ProcessInfosChanged(new CoreWebView2ProcessInfosChangedEventHandler(OnProcessInfosChanged), out _ProcessInfosChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateProcessInfosChanged = (EventHandler<object>)Delegate.Combine(privateProcessInfosChanged, value);
		}
		remove
		{
			privateProcessInfosChanged = (EventHandler<object>)Delegate.Remove(privateProcessInfosChanged, value);
			if (privateProcessInfosChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Environment8.remove_ProcessInfosChanged(_ProcessInfosChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2Environment(object rawCoreWebView2Environment)
	{
		_rawNative = rawCoreWebView2Environment;
	}

	internal void OnNewBrowserVersionAvailable(object args)
	{
		privateNewBrowserVersionAvailable?.Invoke(this, args);
	}

	/// <summary>
	/// Asynchronously creates a new WebView.
	/// </summary><param name="ParentWindow">The HWND in which the WebView should be displayed and from which receive input.</param><remarks>
	/// The WebView adds a child window to the provided window during WebView creation. Z-order and other things impacted by sibling window order are affected accordingly.
	///
	/// <para>
	/// HWND_MESSAGE is a valid parameter for <c>ParentWindow</c> for an invisible WebView for Windows 8 and above. In this case the window will never become visible. You are not able to reparent the window after you have created the WebView. This is not supported in Windows 7 or below. Passing this parameter in Windows 7 or below will return ERROR_INVALID_WINDOW_HANDLE in the controller callback.
	/// </para><para>
	/// It can also accept a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions" /> which is created by <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerOptions" /> as the second parameter for multiple profiles support. As WebView2 is built on top of Edge browser, it follows Edge's behavior pattern. To create an InPrivate WebView, we gets an off-the-record profile (an InPrivate profile) from a regular profile, then create the WebView with the off-the-record profile. Multiple profiles under single user data directory can share some system resources including memory, CPU footprint, disk space (such as compiled shaders and safebrowsing data) etc.
	/// </para><para>
	/// It is recommended that the application set Application User Model ID for the process or the application window. If none is set, during WebView creation a generated Application User Model ID is set to root window of <c>ParentWindow</c>.
	/// </para><para>
	/// It is recommended that the app handles restart manager messages, to gracefully restart it in the case when the app is using the WebView2 Runtime from a certain installation and that installation is being uninstalled. For example, if a user installs a version of the WebView2 Runtime and opts to use another version of the WebView2 Runtime for testing the app, and then uninstalls the 1st version of the WebView2 Runtime without closing the app, the app restarts to allow un-installation to succeed.
	/// </para><para>
	/// When the app retries CreateCoreWebView2ControllerAsync upon failure, it is recommended that the app restarts from creating a new WebView2 Environment. If a WebView2 Runtime update happens, the version associated with a WebView2 Environment may have been removed and causing the object to no longer work. Creating a new WebView2 Environment works since it uses the latest version.
	/// </para><para>
	/// WebView creation fails if a running instance using the same user data folder exists, and the Environment objects have different <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions" />. For example, if a WebView was created with one <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.Language" />, an attempt to create a WebView with a different <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.Language" /> using the same user data folder fails.
	/// </para><para>
	/// WebView creation can fail with `E_UNEXPECTED` if runtime does not have permissions to the user data folder.
	/// </para></remarks>
	public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow)
	{
		CoreWebView2CreateCoreWebView2ControllerCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
			_nativeICoreWebView2Environment.CreateCoreWebView2Controller(ParentWindow, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Creates a new <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse" /> object.
	/// </summary><param name="Content">HTTP response content as stream.</param><param name="StatusCode">The HTTP response status code.</param><param name="ReasonPhrase">The HTTP response reason phrase.</param><param name="Headers">The raw response header string delimited by newline.</param><remarks>
	/// It is also possible to create this object with empty headers string and then use the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders" /> to construct the headers line by line.
	/// </remarks><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse" />
	public CoreWebView2WebResourceResponse CreateWebResourceResponse(Stream Content, int StatusCode, string ReasonPhrase, string Headers)
	{
		try
		{
			return new CoreWebView2WebResourceResponse(_nativeICoreWebView2Environment.CreateWebResourceResponse((Content == null) ? null : new ManagedIStream(Content), StatusCode, ReasonPhrase, Headers));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Create a new WebView with options.</summary>
	public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
	{
		CoreWebView2CreateCoreWebView2ControllerCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
			_nativeICoreWebView2Environment10.CreateCoreWebView2ControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CreateCoreWebView2ControllerAsync failed to create the controller due to incompatible options.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>Create a new WebView in visual hosting mode with options.</summary>
	public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
	{
		CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
			_nativeICoreWebView2Environment10.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CreateCoreWebView2ControllerAsync failed to create the controller due to incompatible options.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Create a shared memory based buffer with the specified size in bytes.
	/// </summary><remarks>
	/// The buffer can be shared with web contents in WebView by calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PostSharedBufferToScript(Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer,Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess,System.String)" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostSharedBufferToScript(Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer,Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess,System.String)" />.
	/// Once shared, the same content of the buffer will be accessible from both the app process and script in WebView.
	/// Modification to the content will be visible to all parties that have access to the buffer.
	/// The shared buffer is presented to the script as ArrayBuffer. All JavaScript APIs that work for ArrayBuffer including Atomics APIs can be used on it.
	/// There is currently a limitation that only size less than 2GB is supported.
	/// </remarks>
	public CoreWebView2SharedBuffer CreateSharedBuffer(ulong Size)
	{
		try
		{
			return new CoreWebView2SharedBuffer(_nativeICoreWebView2Environment12.CreateSharedBuffer(Size));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Returns a snapshot collection of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo" /> corresponding to all currently running processes associated with this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> excludes crashpad process. This provides the same list of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo" /> as what's provided in <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetProcessInfos" />, but additionally provides a list of associated <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo" /> which are actively running (showing or hiding UI elements) in the renderer process. See <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ProcessExtendedInfo.AssociatedFrameInfos" /> for more information.</summary>
	public async Task<IReadOnlyList<CoreWebView2ProcessExtendedInfo>> GetProcessExtendedInfosAsync()
	{
		CoreWebView2GetProcessExtendedInfosCompletedHandler handler;
		try
		{
			handler = new CoreWebView2GetProcessExtendedInfosCompletedHandler();
			_nativeICoreWebView2Environment13.GetProcessExtendedInfos(handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>Create a `ICoreWebView2FileSystemHandle` object from a path that represents a Web
	/// [FileSystemFileHandle](https://developer.mozilla.org/docs/Web/API/FileSystemFileHandle).
	///
	/// The `path` is the path pointed by the file and must be a syntactically correct fully qualified
	/// path, but it is not checked here whether it currently points to a file. If an invalid path is
	/// passed, an E_INVALIDARG will be returned and the object will fail to create. Any other state
	/// validation will be done when this handle is accessed from web content
	/// and will cause the DOM exceptions described in
	/// [FileSystemFileHandle methods](https://developer.mozilla.org/docs/Web/API/FileSystemDirectoryHandle#instance_methods)
	/// if access operations fail.
	///
	/// `Permission` property is used to specify whether the Handle should be created with a Read-only or
	/// Read-and-write web permission. For the `permission` value specified here, the DOM
	/// [PermissionStatus](https://developer.mozilla.org/docs/Web/API/PermissionStatus) property
	/// will be [granted](https://developer.mozilla.org/docs/Web/API/PermissionStatus/state)
	/// and the unspecified permission will be
	/// [prompt](https://developer.mozilla.org/docs/Web/API/PermissionStatus/state). Therefore,
	/// the web content then does not need to call
	/// [requestPermission](https://developer.mozilla.org/docs/Web/API/FileSystemHandle/requestPermission)
	/// for the permission that was specified before attempting the permitted operation,
	/// but if it does, the promise will immediately be resolved
	/// with 'granted' PermissionStatus without firing the WebView2
	/// [PermissionRequested](/microsoft-edge/webview2/reference/win32/icorewebview2permissionrequestedeventargs)
	/// event or prompting the user for permission. Otherwise, `requestPermission` will behave as the
	/// status of permission is currently `prompt`, which means the `PermissionRequested` event will fire
	/// or the user will be prompted.
	/// Additionally, the app must have the same OS permissions that have propagated to the
	/// [WebView2 browser process](/microsoft-edge/webview2/concepts/process-model)
	/// for the path it wishes to give the web content to read/write the file.
	/// Specifically, the WebView2 browser process will run in same user, package identity, and app
	/// container of the app, but other means such as security context impersonations do not get
	/// propagated, so such permissions that the app has, will not be effective in WebView2.
	/// Note: An exception to this is, if there is a parent directory handle that
	/// has broader permissions in the same page context than specified in here, the handle will automatically
	/// inherit the most permissive permission of the parent handle when posted to that page context.
	/// i.e. If there is already a `FileSystemDirectoryHandle` to `C:\example` that has write permission on
	/// a page, even though a WebFileSystemHandle to file `C:\example\file.txt` is created with
	/// `COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION_READ_ONLY` permission, when posted to that page, write permission
	/// will be automatically granted to the created handle.
	///
	/// An app needs to be mindful that this object, when posted to the web content, provides it with unusual
	/// access to OS file system via the Web FileSystem API! The app should therefore only post objects
	/// for paths that it wants to allow access to the web content and it is not recommended that the web content
	/// "asks" for this path. The app should also check the source property of the target to ensure
	/// that it is sending to the web content of intended origin.
	///
	/// Once the object is passed to web content, if the content is attempting a read,
	/// the file must be existing and available to read similar to a file chosen by
	/// [open file picker](https://developer.mozilla.org/docs/Web/API/Window/showOpenFilePicker),
	/// otherwise the read operation will
	/// [throw a DOM exception](https://developer.mozilla.org/docs/Web/API/FileSystemFileHandle/getFile#exceptions).
	/// For write operations, the file does not need to exist as `FileSystemFileHandle` will behave
	/// as a file path chosen by
	/// [save file picker](https://developer.mozilla.org/docs/Web/API/Window/showSaveFilePicker)
	/// and will create or overwrite the file, but the parent directory structure pointed
	/// by the file must exist and an existing file must be available to write and delete
	/// or the write operation will
	/// [throw a DOM exception](https://developer.mozilla.org/docs/Web/API/FileSystemFileHandle/createWritable#exceptions).</summary>
	public CoreWebView2FileSystemHandle CreateWebFileSystemFileHandle(string path, CoreWebView2FileSystemHandlePermission permission)
	{
		try
		{
			return new CoreWebView2FileSystemHandle(_nativeICoreWebView2Environment14.CreateWebFileSystemFileHandle(path, (COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION)permission));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Create a `ICoreWebView2FileSystemHandle` object from a path that represents a Web
	/// [FileSystemDirectoryHandle](https://developer.mozilla.org/docs/Web/API/FileSystemDirectoryHandle).
	///
	/// The `path` is the path pointed by the directory and must be a syntactically correct fully qualified
	/// path, but it is not checked here whether it currently points to a directory. Any other state
	/// validation will be done when this handle is accessed from web content
	/// and will cause DOM exceptions if access operations fail. If an invalid path is
	/// passed, an E_INVALIDARG will be returned and the object will fail to create.
	///
	/// `Permission` property is used to specify whether the Handle should be created with a Read-only or
	/// Read-and-write web permission. For the `permission` value specified here, the Web
	/// [PermissionStatus](https://developer.mozilla.org/docs/Web/API/PermissionStatus)
	/// will be [granted](https://developer.mozilla.org/docs/Web/API/PermissionStatus/state)
	/// and the unspecified permission will be
	/// [prompt](https://developer.mozilla.org/docs/Web/API/PermissionStatus/state). Therefore,
	/// the web content then does not need to call
	/// [requestPermission](https://developer.mozilla.org/docs/Web/API/FileSystemHandle/requestPermission)
	/// for the permission that was specified before attempting the permitted operation,
	/// but if it does, the promise will immediately be resolved
	/// with 'granted' PermissionStatus without firing the WebView2
	/// [PermissionRequested](/microsoft-edge/webview2/reference/win32/icorewebview2permissionrequestedeventargs)
	/// event or prompting the user for permission. Otherwise, `requestPermission` will behave as the
	/// status of permission is currently `Prompt`, which means the `PermissionRequested` event will fire
	/// or the user will be prompted.
	/// Additionally, the app must have the same OS permissions that have propagated to the
	/// [WebView2 browser process](/microsoft-edge/webview2/concepts/process-model)
	/// for the path it wishes to give the web content to make any operations on the directory.
	/// Specifically, the WebView2 browser process will run in same user, package identity, and app
	/// container of the app, but other means such as security context impersonations do not get
	/// propagated, so such permissions that the app has, will not be effective in WebView2.
	/// Note: An exception to this is, if there is a parent directory handle that
	/// has broader permissions in the same page context than specified in here, the handle will automatically
	/// inherit the most permissive permission of the parent handle when posted to that page context.
	/// i.e. If there is already a `FileSystemDirectoryHandle` to `C:\example` that has write permission on
	/// a page, even though a WebFileSystemHandle to directory `C:\example\directory` is created with
	/// `COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION_READ_ONLY` permission, when posted to that page, write permission
	/// will be automatically granted to the created handle.
	///
	/// An app needs to be mindful that this object, when posted to the web content, provides it with unusual
	/// access to OS file system via the Web FileSystem API! The app should therefore only post objects
	/// for paths that it wants to allow access to the web content and it is not recommended that the web content
	/// "asks" for this path. The app should also check the source property of the target to ensure
	/// that it is sending to the web content of intended origin.
	///
	/// Once the object is passed to web content, the path must point to a directory as if it was chosen via
	/// [directory picker](https://developer.mozilla.org/docs/Web/API/Window/showDirectoryPicker)
	/// otherwise any IO operation done on the `FileSystemDirectoryHandle` will throw a DOM exception.</summary>
	public CoreWebView2FileSystemHandle CreateWebFileSystemDirectoryHandle(string path, CoreWebView2FileSystemHandlePermission permission)
	{
		try
		{
			return new CoreWebView2FileSystemHandle(_nativeICoreWebView2Environment14.CreateWebFileSystemDirectoryHandle(path, (COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION)permission));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Creates a new instance of a CoreWebView2FindOptions object.
	/// This find options object can be used to define parameters for a find session.
	/// Returns the newly created FindOptions object.</summary>
	public CoreWebView2FindOptions CreateFindOptions()
	{
		try
		{
			return new CoreWebView2FindOptions(_nativeICoreWebView2Environment15.CreateFindOptions());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Creates a new <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest" /> object.
	/// </summary><param name="uri">The request URI.</param><param name="Method">The HTTP request method.</param><param name="postData"></param><param name="Headers">The raw request header string delimited by CRLF (optional in last header).</param><remarks><c>uri</c> parameter must be absolute URI. It's also possible to create this object with <c>null</c> headers string and then use the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders" /> to construct the headers line by line.
	/// </remarks><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest" />
	public CoreWebView2WebResourceRequest CreateWebResourceRequest(string uri, string Method, Stream postData, string Headers)
	{
		try
		{
			return new CoreWebView2WebResourceRequest(_nativeICoreWebView2Environment2.CreateWebResourceRequest(uri, Method, (postData == null) ? null : new ManagedIStream(postData), Headers));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Asynchronously creates a new WebView for use with visual hosting.</summary><param name="ParentWindow">The HWND in which the app will connect the visual tree of the WebView.</param><remarks><c>ParentWindow</c> will be the HWND that the app will receive pointer/mouse input meant for the WebView (and will need to use <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendMouseInput(Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind,Microsoft.Web.WebView2.Core.CoreWebView2MouseEventVirtualKeys,System.UInt32,System.Drawing.Point)" /> or <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendPointerInput(Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind,Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo)" /> to forward). If the app moves the WebView visual tree to underneath a different window, then it needs to set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Controller.ParentWindow" /> to update the new parent HWND of the visual tree.
	///
	/// Set <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.RootVisualTarget" /> property on the created <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController" /> to provide a visual to host the browser's visual tree.
	///
	/// It is recommended that the application set Application User Model ID for the process or the application window. If none is set, during WebView creation a generated Application User Model ID is set to root window of <c>ParentWindow</c>.
	///
	/// It can also accept a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions" /> which is created by <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerOptions" /> as the second parameter for multiple profiles support.
	///
	/// CreateCoreWebView2CompositionController is supported in the following versions of Windows:
	///
	/// <list type="bullet"><item><description>Windows 11</description></item><item><description>Windows 10</description></item><item><description>Windows Server 2019</description></item><item><description>Windows Server 2016</description></item></list></remarks>
	public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow)
	{
		CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
			_nativeICoreWebView2Environment3.CreateCoreWebView2CompositionController(ParentWindow, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.AsyncReturnValue;
	}

	/// <summary>
	/// Creates an empty <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo" />.
	/// </summary><remarks>
	/// The returned <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo" /> needs to be populated with all of the relevant info before calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendPointerInput(Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind,Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo)" />.
	/// </remarks>
	public CoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
	{
		try
		{
			return new CoreWebView2PointerInfo(_nativeICoreWebView2Environment3.CreateCoreWebView2PointerInfo());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnBrowserProcessExited(CoreWebView2BrowserProcessExitedEventArgs args)
	{
		privateBrowserProcessExited?.Invoke(this, args);
	}

	/// <summary>
	/// Creates the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings" /> used by the <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)" /> method.</summary>
	public CoreWebView2PrintSettings CreatePrintSettings()
	{
		try
		{
			return new CoreWebView2PrintSettings(_nativeICoreWebView2Environment6.CreatePrintSettings());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	internal void OnProcessInfosChanged(object args)
	{
		privateProcessInfosChanged?.Invoke(this, args);
	}

	/// <summary>
	/// Returns the list of all <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo" /> using same user data folder except for crashpad process.</summary>
	public IReadOnlyList<CoreWebView2ProcessInfo> GetProcessInfos()
	{
		try
		{
			return COMDotNetTypeConverter.CoreWebView2ProcessInfoCollectionCOMToNet(_nativeICoreWebView2Environment8.GetProcessInfos());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Create a custom <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" /> object to insert into the WebView context menu.
	/// </summary><remarks>
	/// CoreWebView2 will rewind the <c>icon</c> stream before decoding.
	/// There is a limit of 1000 active custom context menu items at a given time per <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />. Attempting to create more before deleting existing ones will fail with <c>ERROR_NOT_ENOUGH_QUOTA</c>. It is recommended to reuse custom ContextMenuItems across CoreWebView2ContextMenuRequested events for performance. The created object's <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.IsEnabled" /> property will default to <c>true</c> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.IsChecked" /> property will default to <c>false</c>. A <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.CommandId" /> will be assigned that's unique across active custom context menu items, but command ID values of deleted custom ContextMenuItems can be reassigned.
	/// </remarks>
	public CoreWebView2ContextMenuItem CreateContextMenuItem(string Label, Stream iconStream, CoreWebView2ContextMenuItemKind Kind)
	{
		try
		{
			return new CoreWebView2ContextMenuItem(_nativeICoreWebView2Environment9.CreateContextMenuItem(Label, (iconStream == null) ? null : new ManagedIStream(iconStream), (COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND)Kind));
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Environment members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	[DllImport("WebView2Loader.dll")]
	internal static extern int CreateCoreWebView2EnvironmentWithOptions([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, [In][MarshalAs(UnmanagedType.LPWStr)] string userDataFolder, ICoreWebView2EnvironmentOptions options, ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environment_created_handler);

	[DllImport("WebView2Loader.dll")]
	internal static extern int GetAvailableCoreWebView2BrowserVersionString([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, [MarshalAs(UnmanagedType.LPWStr)] ref string versionInfo);

	[DllImport("WebView2Loader.dll")]
	internal static extern int CompareBrowserVersions([In][MarshalAs(UnmanagedType.LPWStr)] string version1, [In][MarshalAs(UnmanagedType.LPWStr)] string version2, ref int result);

	[DllImport("WebView2Loader.dll")]
	internal static extern int GetAvailableCoreWebView2BrowserVersionStringWithOptions([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, ICoreWebView2EnvironmentOptions options, [MarshalAs(UnmanagedType.LPWStr)] ref string versionInfo);

	/// <summary>
	/// Creates a WebView2 Environment using the installed or a custom WebView2 Runtime version.
	/// </summary>
	/// <param name="browserExecutableFolder">
	/// The relative path to the folder that contains a custom version of WebView2 Runtime.
	/// <para>
	/// To use a fixed version of the WebView2 Runtime, pass the
	/// folder path that contains the fixed version of the WebView2 Runtime
	/// to <c>browserExecutableFolder</c>. BrowserExecutableFolder supports both relative
	/// (to the application's executable) and absolute file paths. To create WebView2 controls
	/// that use the installed version of the WebView2 Runtime that exists on
	/// user machines, pass a <c>null</c> or empty string to
	/// <c>browserExecutableFolder</c>. In this scenario, the API tries to
	/// find a compatible version of the WebView2 Runtime that is installed
	/// on the user machine (first at the machine level, and then per user)
	/// using the selected channel preference. The path of fixed version of
	/// the WebView2 Runtime should not contain <em>\Edge\Application\</em>. When
	/// such a path is used, the API fails with <c>ERROR_NOT_SUPPORTED</c>.
	/// </para>
	/// </param>
	/// <param name="userDataFolder">
	/// The user data folder location for WebView2.
	/// <para>
	/// The path is either an absolute file path or a relative file path
	/// that is interpreted as relative to the compiled code for the
	/// current process. The default user data folder <em>{Executable File
	/// Name}.WebView2</em> is created in the same directory next to the
	/// compiled code for the app. WebView2 creation fails if the compiled
	/// code is running in a directory in which the process does not have
	/// permission to create a new directory. The app is responsible to
	/// clean up the associated user data folder when it is done.
	/// </para>
	/// </param>
	/// <param name="options">
	/// Options used to create WebView2 Environment.
	/// <para>
	/// As a browser process may be shared among WebViews, WebView creation
	/// fails if the specified <c>options</c> does not match the options of
	/// the WebViews that are currently running in the shared browser
	/// process.
	/// </para>
	/// </param>
	/// <remarks>
	/// <para>
	/// The default channel search order is the WebView2 Runtime, Beta, Dev, and
	/// Canary. When an override <c>WEBVIEW2_RELEASE_CHANNEL_PREFERENCE</c> environment
	/// variable or applicable <c>releaseChannelPreference</c> registry value is set to
	/// <c>1</c>, the channel search order is reversed.
	/// </para>
	/// <para>
	/// To use a fixed version of the WebView2 Runtime, pass the relative
	/// folder path that contains the fixed version of the WebView2 Runtime
	/// to <c>browserExecutableFolder</c>. To create WebView2 controls that
	/// use the installed version of the WebView2 Runtime that exists on
	/// user machines, pass a <c>null</c> or empty string to
	/// <c>browserExecutableFolder</c>. In this scenario, the API tries to
	/// find a compatible version of the WebView2 Runtime that is installed
	/// on the user machine (first at the machine level, and then per user)
	/// using the selected channel preference. The path of fixed version of
	/// the WebView2 Runtime should not contain <em>\Edge\Application\</em>. When
	/// such a path is used, the API fails with the following error.
	/// </para>
	/// <para>
	/// The <paramref name="browserExecutableFolder" />, <paramref name="userDataFolder" />, and <paramref name="options" /> may be
	/// overridden by values either specified in environment variables or in
	/// the registry.
	/// </para>
	/// <para>
	/// When creating a <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" /> the following environment variables are verified.
	/// </para>
	/// <list type="bullet">
	/// <item>
	/// <term><c>WEBVIEW2_BROWSER_EXECUTABLE_FOLDER</c></term>
	/// </item>
	/// <item>
	/// <term><c>WEBVIEW2_USER_DATA_FOLDER</c></term>
	/// </item>
	/// <item>
	/// <term><c>WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS</c></term>
	/// </item>
	/// <item>
	/// <term><c>WEBVIEW2_RELEASE_CHANNEL_PREFERENCE</c></term>
	/// </item>
	/// </list>
	/// <para>
	/// If browser executable folder or user data folder is specified in an
	/// environment variable or in the registry, the specified <paramref name="browserExecutableFolder" /> or <paramref name="userDataFolder" /> values are overridden. If additional browser
	/// arguments are specified in an environment variable or in the
	/// registry, it is appended to the corresponding value in the specified
	/// <paramref name="options" />.
	/// </para>
	/// <para>
	/// While not strictly overrides, additional environment variables may be set.
	/// </para>
	/// <list type="table">
	/// <listheader>
	/// <term>Value</term>
	/// <description>Description</description>
	/// </listheader>
	/// <item>
	/// <term><c>WEBVIEW2_WAIT_FOR_SCRIPT_DEBUGGER</c></term>
	/// <description>
	/// When found with a non-empty value, this indicates that the WebView
	/// is being launched under a script debugger. In this case, the WebView
	/// issues a <c>Page.waitForDebugger</c> CDP command that runs the
	/// script inside the WebView to pause on launch, until a debugger
	/// issues a corresponding <c>Runtime.runIfWaitingForDebugger</c> CDP
	/// command to resume the runtime.
	/// Note that this environment variable does not have a registry key equivalent.
	/// </description>
	/// </item>
	/// <item>
	/// <term><c>WEBVIEW2_PIPE_FOR_SCRIPT_DEBUGGER</c></term>
	/// <description>
	/// When found with a non-empty value, it indicates that the WebView is
	/// being launched under a script debugger that also supports host apps
	/// that use multiple WebViews. The value is used as the identifier for
	/// a named pipe that is opened and written to when a new WebView is
	/// created by the host app. The payload should match the payload of the
	/// <c>remote-debugging-port</c> JSON target and an external debugger
	/// may use it to attach to a specific WebView instance. The format of
	/// the pipe created by the debugger should be
	/// <c>\\.\pipe\WebView2\Debugger\{app_name}\{pipe_name}</c>, where the
	/// following are true.
	///
	/// <list type="bullet">
	/// <item><description><c>{app_name}</c> is the host app exe file name, for example, <c>WebView2Example.exe</c></description></item>
	/// <item><description><c>{pipe_name}</c> is the value set for <c>WEBVIEW2_PIPE_FOR_SCRIPT_DEBUGGER</c></description></item>
	/// </list>
	///
	/// To enable debugging of the targets identified by the JSON, you must
	/// set the <c>WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS</c> environment
	/// variable to send <c>--remote-debugging-port={port_num}</c>, where
	/// the following is true.
	///
	/// <list type="bullet">
	/// <item><description><c>{port_num}</c> is the port on which the CDP server binds.</description></item>
	/// </list>
	///
	/// If both <c>WEBVIEW2_PIPE_FOR_SCRIPT_DEBUGGER</c> and
	/// <c>WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS</c> environment variables,
	/// the WebViews hosted in your app and associated contents may exposed
	/// to 3rd party apps such as debuggers. Note that this environment
	/// variable does not have a registry key equivalent.
	/// </description>
	/// </item>
	/// </list>
	/// <para>
	/// If none of those environment variables exist, then the registry is examined
	/// next.
	/// </para>
	/// <list type="bullet">
	/// <item>
	/// <term><c>[{Root}]\Software\Policies\Microsoft\Edge\WebView2\BrowserExecutableFolder "{AppId}"=""</c></term>
	/// </item>
	/// <item>
	/// <term><c>[{Root}]\Software\Policies\Microsoft\Edge\WebView2\ReleaseChannelPreference "{AppId}"=""</c></term>
	/// </item>
	/// <item>
	/// <term><c>[{Root}]\Software\Policies\Microsoft\Edge\WebView2\AdditionalBrowserArguments "{AppId}"=""</c></term>
	/// </item>
	/// <item>
	/// <term><c>[{Root}]\Software\Policies\Microsoft\Edge\WebView2\UserDataFolder "{AppId}"=""</c></term>
	/// </item>
	/// </list>
	/// <para>
	/// Use a group policy under <strong>Administrative Templates</strong> &gt;
	/// <strong>Microsoft Edge WebView2</strong> to configure browser executable folder
	/// and release channel preference.
	/// </para>
	/// <list type="table">
	/// <listheader>
	/// <term>Value</term>
	/// <description>Description</description>
	/// </listheader>
	/// <item>
	/// <term><c>ERROR_DISK_FULL</c></term>
	/// <description>
	/// In the unlikely scenario where some instances of WebView are open during a
	/// browser update, the deletion of the previous WebView2 Runtime may be
	/// blocked. To avoid running out of disk space, a new WebView creation fails
	/// with this error if it detects that too many previous WebView2
	/// Runtime versions exist.
	/// </description>
	/// </item>
	/// <item>
	/// <term><c>COREWEBVIEW2_MAX_INSTANCES</c></term>
	/// <description>
	/// The default maximum number of WebView2 Runtime versions allowed is <c>20</c>.
	/// To override the maximum number of the previous WebView2 Runtime versions
	/// allowed, set the value of the following environment variable.
	/// </description>
	/// </item>
	/// <item>
	/// <term><c>ERROR_PRODUCT_UNINSTALLED</c></term>
	/// <description>
	/// If the Webview depends upon an installed WebView2 Runtime version and it is
	/// uninstalled, any subsequent creation fails with this error.
	/// </description>
	/// </item>
	/// </list>
	/// <para>
	/// First verify with Root as <c>HKLM</c> and then <c>HKCU</c>. <c>AppId</c> is first set to
	/// the Application User Model ID of the process, then if no corresponding
	/// registry key, the <c>AppId</c> is set to the compiled code name of the process,
	/// or if that is not a registry key then <c>*</c>. If an override registry key is
	/// found, use the <c>browserExecutableFolder</c> and <c>userDataFolder</c> registry
	/// values as replacements and append <c>additionalBrowserArguments</c> registry
	/// values for the corresponding values in the provided <paramref name="options" />.
	/// </para>
	/// </remarks>
	public static async Task<CoreWebView2Environment> CreateAsync(string browserExecutableFolder = null, string userDataFolder = null, CoreWebView2EnvironmentOptions options = null)
	{
		LoadWebView2LoaderDll();
		CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler handler = new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler();
		CoreWebView2EnvironmentOptions coreWebView2EnvironmentOptions = options ?? new CoreWebView2EnvironmentOptions();
		int num = CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder, coreWebView2EnvironmentOptions._nativeICoreWebView2EnvironmentOptions, handler);
		if (num == -2147024894)
		{
			throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(num));
		}
		Marshal.ThrowExceptionForHR(num);
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.result;
	}

	/// <summary>
	/// Gets the browser version info including channel name if it is not the stable channel or WebView2 Runtime.
	/// </summary>
	/// <param name="browserExecutableFolder">
	/// The relative path to the folder that contains the WebView2 Runtime.
	/// </param>
	/// <exception cref="T:Microsoft.Web.WebView2.Core.WebView2RuntimeNotFoundException">
	/// WebView2 Runtime installation is missing.
	/// </exception>
	public static string GetAvailableBrowserVersionString(string browserExecutableFolder)
	{
		LoadWebView2LoaderDll();
		string versionInfo = null;
		int availableCoreWebView2BrowserVersionString = GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, ref versionInfo);
		if (availableCoreWebView2BrowserVersionString == -2147024894)
		{
			throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(availableCoreWebView2BrowserVersionString));
		}
		Marshal.ThrowExceptionForHR(availableCoreWebView2BrowserVersionString);
		return versionInfo;
	}

	/// <summary>
	/// Gets the browser version info including channel name if it is not the stable channel or WebView2 Runtime.
	/// </summary>
	/// <param name="browserExecutableFolder">
	/// The relative path to the folder that contains the WebView2 Runtime.
	/// </param>
	/// <param name="environmentOptions">
	/// The environment options used to create the environment.
	/// </param>
	/// <exception cref="T:Microsoft.Web.WebView2.Core.WebView2RuntimeNotFoundException">
	/// WebView2 Runtime installation is missing.
	/// </exception>
	/// <remarks>
	/// Browser version info includes channel name if it is not the WebView2 Runtime.
	/// Channel names are Beta, Dev, and Canary. The format of the return string
	/// matches the format of <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2Environment.BrowserVersionString" />.
	/// If an override exists for <c>BrowserExecutableFolder</c>, <c>ReleaseChannels</c>,
	/// or <c>ChannelSearchKind</c>, the override is used. The presence of an override
	/// can result in a different channel used than the one expected based on the environment
	/// options object. <c>BrowserExecutableFolder</c> takes precedence over the
	/// other options. See <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2EnvironmentWithOptions(System.String,System.String,Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions,Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler)" />
	/// for more details on overrides. If an override is not specified, then the
	/// parameters passed to <c>GetAvailableBrowserVersionString</c> are used.
	/// The method fails if the loader is unable to find an installed WebView2
	/// Runtime or non-stable Microsoft Edge installation.
	/// </remarks>
	public static string GetAvailableBrowserVersionString(string browserExecutableFolder = null, CoreWebView2EnvironmentOptions environmentOptions = null)
	{
		if (browserExecutableFolder == null && environmentOptions == null)
		{
			return GetAvailableBrowserVersionString(null);
		}
		LoadWebView2LoaderDll();
		string versionInfo = null;
		CoreWebView2EnvironmentOptions coreWebView2EnvironmentOptions = environmentOptions ?? new CoreWebView2EnvironmentOptions();
		int availableCoreWebView2BrowserVersionStringWithOptions = GetAvailableCoreWebView2BrowserVersionStringWithOptions(browserExecutableFolder, coreWebView2EnvironmentOptions._nativeICoreWebView2EnvironmentOptions, ref versionInfo);
		if (availableCoreWebView2BrowserVersionStringWithOptions == -2147024894)
		{
			throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(availableCoreWebView2BrowserVersionStringWithOptions));
		}
		Marshal.ThrowExceptionForHR(availableCoreWebView2BrowserVersionStringWithOptions);
		return versionInfo;
	}

	/// <summary>
	/// Compares two instances of browser versions correctly and returns an integer that indicates whether the first instance is older, the same as, or newer than the second instance.
	/// </summary>
	/// <param name="version1">
	/// One of the version strings to compare.
	/// </param>
	/// <param name="version2">
	/// The other version string to compare.
	/// </param>
	/// <returns>
	/// An integer that indicates whether the first instance is older, the same as, or newer than the second instance.
	/// <list type="table">
	/// <listheader>
	/// <description>Value Type</description>
	/// <description>Condition</description>
	/// </listheader>
	/// <item>
	/// <description>Less than zero</description>
	/// <description><c>version1</c> is older than <c>version2</c>.</description>
	/// </item>
	/// <item>
	/// <description>Zero</description>
	/// <description><c>version1</c> is the same as <c>version2</c>.</description>
	/// </item>
	/// <item>
	/// <description>Greater than zero</description>
	/// <description><c>version1</c> is newer than <c>version2</c>.</description>
	/// </item>
	/// </list>
	/// </returns>
	public static int CompareBrowserVersions(string version1, string version2)
	{
		LoadWebView2LoaderDll();
		int result = 0;
		Marshal.ThrowExceptionForHR(CompareBrowserVersions(version1, version2, ref result));
		return result;
	}

	/// <summary>
	/// Creates a new <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions" /> object,
	/// which can be passed as a parameter in <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2CompositionControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)" /> function for multiple profiles
	/// support.
	/// </summary>
	/// <returns>
	/// A <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions" /> that can be
	/// passed when calling <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)" /> and <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2CompositionControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)" />.
	/// </returns>
	/// <remarks>
	/// The options is a settable property while the default for profile
	/// name is an empty string and the default value for <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions.IsInPrivateModeEnabled" /> is
	/// false. The profile will be created on disk or opened when calling
	/// CreateCoreWebView2ControllerWithOptions no matter InPrivate mode is
	/// enabled or not, and it will be released in memory when the
	/// corresponding <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Controller" /> is closed but
	/// still remain on disk. As WebView2 is built on top of Edge browser,
	/// it follows Edge's behavior pattern. To create an InPrivate WebView,
	/// we get an off-the-record profile (an InPrivate profile) from a
	/// regular profile, then create the WebView with the off-the-record
	/// profile. Also the profile name can be reused.
	/// </remarks>
	public CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions()
	{
		try
		{
			return new CoreWebView2ControllerOptions(_nativeICoreWebView2Environment10.CreateCoreWebView2ControllerOptions());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CreateCoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	private static ProcessorArchitecture GetArchitecture()
	{
		GetSystemInfo(out var lpSystemInfo);
		return (ProcessorArchitecture)lpSystemInfo.wProcessorArchitecture;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string dllToLoad);

	private static bool IsDirectorySeparator(char c)
	{
		if (c != '\\')
		{
			return c == '/';
		}
		return true;
	}

	internal static bool IsValidDriveChar(char value)
	{
		if (value < 'A' || value > 'Z')
		{
			if (value >= 'a')
			{
				return value <= 'z';
			}
			return false;
		}
		return true;
	}

	private static bool IsDotNetFramework()
	{
		return typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET Framework");
	}

	private static string GetAssemblyLocationDirectory()
	{
		try
		{
			return Path.GetDirectoryName(typeof(CoreWebView2Environment).Assembly.Location);
		}
		catch
		{
			return "";
		}
	}

	private static string GetAssemblyCodeBaseDirectory()
	{
		try
		{
			string text = typeof(CoreWebView2Environment).Assembly.CodeBase;
			if (text.StartsWith("file:///"))
			{
				text = Path.GetDirectoryName(text.Substring("file:///".Length));
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint GetModuleFileName([In] IntPtr hModule, [Out] StringBuilder lpFilename, [In][MarshalAs(UnmanagedType.U4)] int nSize);

	private static string GetCurrentDllRuningDirectory()
	{
		try
		{
			IntPtr moduleHandle = GetModuleHandle("Microsoft.Web.WebView2.Core.dll");
			StringBuilder stringBuilder = new StringBuilder(256);
			if (GetModuleFileName(moduleHandle, stringBuilder, stringBuilder.Capacity) == 0)
			{
				return "";
			}
			return Path.GetDirectoryName(stringBuilder.ToString());
		}
		catch
		{
			return "";
		}
	}

	private static string GetProcessArchSubFolder()
	{
		string text = "runtimes\\win-";
		return Path.Combine(GetArchitecture() switch
		{
			ProcessorArchitecture.x86 => text + "x86", 
			ProcessorArchitecture.x64 => text + "x64", 
			ProcessorArchitecture.ARM64 => text + "arm64", 
			_ => throw new NotSupportedException("Unknown Processor Architecture of WebView2Loader.dll is not supported"), 
		}, "native");
	}

	private static string GetAppDomainBaseDirectory()
	{
		try
		{
			return AppDomain.CurrentDomain.BaseDirectory;
		}
		catch
		{
			return "";
		}
	}

	/// <summary>
	/// Set the path of the folder containing the `WebView2Loader.dll`.
	/// </summary>
	/// <param name="folderPath">The path of the folder containing the `WebView2Loader.dll`.</param>
	/// <exception cref="T:System.InvalidOperationException">
	/// Thrown when `WebView2Loader.dll` has been successfully loaded.
	/// </exception>
	/// <remarks>
	/// This function allows you to set the path of the folder containing the `WebView2Loader.dll`. This should be the path of a folder containing `WebView2Loader.dll` and not a path to the `WebView2Loader.dll` file itself.
	/// Note that the WebView2 SDK contains multiple `WebView2Loader.dll` files for different CPU architectures. When specifying folder path, you must specify one containing a `WebView2Loader.dll` module with a CPU architecture matching the current process CPU architecture.
	/// This function is used to load the `WebView2Loader.dll` module during calls to any other static methods on `CoreWebView2Environment`. So, the path should be specified before any other API is called in `CoreWebView2Environment` class. Once `WebView2Loader.dll` is successfully loaded this function will throw an InvalidOperationException exception.
	/// The path can be relative or absolute. Relative paths are relative to the path of the `Microsoft.Web.WebView2.Core.dll` module.
	/// If the `WebView2Loader.dll` file does not exist in that path or LoadLibrary cannot load the file, or LoadLibrary fails for any other reason, an exception corresponding to the LoadLibrary failure is thrown when any other API is called in `CoreWebView2Environment` class. For instance, if the file cannot be found a `DllNotFoundException` exception will be thrown.
	/// </remarks>
	public static void SetLoaderDllFolderPath(string folderPath)
	{
		if (!webView2LoaderLoaded)
		{
			loaderDllFolderPath = folderPath;
			return;
		}
		throw new InvalidOperationException("The function should be called before before any other API is called in `CoreWebView2Environment` class.");
	}

	private static string TrimFormat(string path)
	{
		char[] trimChars = new char[2] { '/', '\\' };
		path = path.Trim(' ');
		path = path.TrimEnd(trimChars);
		return path;
	}

	private static void LoadWebView2LoaderDll()
	{
		if (webView2LoaderLoaded)
		{
			return;
		}
		string text = "";
		if (!string.IsNullOrEmpty(loaderDllFolderPath))
		{
			text = loaderDllFolderPath;
		}
		else if (IsDotNetFramework())
		{
			text = GetProcessArchSubFolder();
		}
		if (!string.IsNullOrEmpty(text))
		{
			text = TrimFormat(text);
			ArrayList arrayList = new ArrayList();
			if (Path.IsPathRooted(text))
			{
				arrayList.Add(text);
			}
			else
			{
				arrayList.Add(Path.Combine(GetAppDomainBaseDirectory(), text));
				arrayList.Add(Path.Combine(GetAssemblyLocationDirectory(), text));
				arrayList.Add(Path.Combine(GetAssemblyCodeBaseDirectory(), text));
				arrayList.Add(Path.Combine(GetCurrentDllRuningDirectory(), text));
			}
			arrayList.Add("");
			string text2 = "";
			foreach (string item in arrayList)
			{
				text2 = Path.Combine(item, "WebView2Loader.dll");
				if (LoadLibrary(text2) != IntPtr.Zero)
				{
					webView2LoaderLoaded = true;
					break;
				}
			}
			if (!webView2LoaderLoaded && !string.IsNullOrEmpty(loaderDllFolderPath))
			{
				int hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
				throw new DllNotFoundException($"Unable to load DLL '{text2}' or one of its dependencies: {new Win32Exception(hRForLastWin32Error).Message} (0x{hRForLastWin32Error:X})");
			}
		}
		webView2LoaderLoaded = true;
	}
}
