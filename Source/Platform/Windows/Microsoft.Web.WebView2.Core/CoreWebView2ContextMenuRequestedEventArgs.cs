using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContextMenuRequested" /> event.
/// </summary><remarks>
/// Will contain the selection information and a collection of all of the default context menu items that the WebView would show. Allows the app to draw its own context menu or add/remove from the default context menu.
/// </remarks>
public class CoreWebView2ContextMenuRequestedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2ContextMenuRequestedEventArgs _nativeICoreWebView2ContextMenuRequestedEventArgsValue;

	internal ICoreWebView2ContextMenuRequestedEventArgs _nativeICoreWebView2ContextMenuRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2ContextMenuRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2ContextMenuRequestedEventArgsValue = (ICoreWebView2ContextMenuRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContextMenuRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ContextMenuRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2ContextMenuRequestedEventArgsValue = value;
		}
	}

	/// <summary>
	/// Gets the target information associated with the requested context menu.
	/// </summary><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget" />
	public CoreWebView2ContextMenuTarget ContextMenuTarget
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget == null) ? null : new CoreWebView2ContextMenuTarget(_nativeICoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets whether the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContextMenuRequested" /> event is handled by host after the event handler completes or after the deferral is completed if there is a taken Deferral.
	/// </summary><remarks>
	/// If Handled is set to <c>true</c> then WebView2 will not display a context menu and will instead use the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId" /> property to indicate which, if any, context menu item to invoke. If after the event handler or deferral completes, Handled is set to <c>false</c> then WebView will display a context menu based on the contents of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.MenuItems" /> property. The default value is <c>false</c>.
	/// </remarks>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuRequestedEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ContextMenuRequestedEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the coordinates where the context menu request occurred in relation to the upper left corner of the WebView bounds.</summary>
	public Point Location
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2ContextMenuRequestedEventArgs.Location);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the collection of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" /> objects.</summary>
	public IList<CoreWebView2ContextMenuItem> MenuItems
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.CoreWebView2ContextMenuItemCollectionCOMToNet(_nativeICoreWebView2ContextMenuRequestedEventArgs.MenuItems);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the selected <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />'s <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.CommandId" />.
	/// </summary><remarks>
	/// When the app handles the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContextMenuRequested" /> event, it can set this to report the selected command from the context menu. The default value is -1 which means that no selection occurred. The app can also set the command ID for a custom context menu item, which will cause the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.CustomItemSelected" /> event to be fired, however while command IDs for each custom context menu item is unique during a ContextMenuRequested event, WebView may reassign command ID values of deleted custom ContextMenuItems to new objects and the command ID assigned to the same custom item can be different between each app runtime. The command ID should always be obtained via the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.CommandId" /> property.
	/// </remarks>
	public int SelectedCommandId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ContextMenuRequestedEventArgs(object rawCoreWebView2ContextMenuRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2ContextMenuRequestedEventArgs;
	}

	/// <summary>
	/// Returns a Deferral object.
	/// </summary><remarks>
	/// Use this operation to complete the event when the custom context menu is closed.
	/// </remarks>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2ContextMenuRequestedEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2ContextMenuRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
