using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Represents a context menu item of a context menu displayed by WebView.</summary>
public class CoreWebView2ContextMenuItem
{
	internal object _rawNative;

	internal ICoreWebView2ContextMenuItem _nativeICoreWebView2ContextMenuItemValue;

	private EventRegistrationToken _CustomItemSelectedToken;

	private EventHandler<object> privateCustomItemSelected;

	internal ICoreWebView2ContextMenuItem _nativeICoreWebView2ContextMenuItem
	{
		get
		{
			if (_nativeICoreWebView2ContextMenuItemValue == null)
			{
				try
				{
					_nativeICoreWebView2ContextMenuItemValue = (ICoreWebView2ContextMenuItem)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContextMenuItem.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ContextMenuItemValue;
		}
		set
		{
			_nativeICoreWebView2ContextMenuItemValue = value;
		}
	}

	/// <summary>
	/// Gets the list of children menu items if the kind is <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItemKind.Submenu" />.
	/// </summary><remarks>
	/// If the kind is not <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItemKind.Submenu" />, will return <c>null</c>.
	/// </remarks>
	public IList<CoreWebView2ContextMenuItem> Children
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.CoreWebView2ContextMenuItemCollectionCOMToNet(_nativeICoreWebView2ContextMenuItem.Children);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the Command ID for the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
	/// </summary><remarks>
	/// Use this to report the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId" /> in <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContextMenuRequested" /> event.
	/// </remarks>
	public int CommandId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.CommandId;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the Icon for the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" /> in PNG, Bitmap or SVG formats in the form of an IStream.
	/// </summary><remarks>
	/// Stream will be rewound to the start of the image data before being read.
	/// </remarks>
	public Stream Icon
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.StreamCOMToNet(_nativeICoreWebView2ContextMenuItem.Icon);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the checked property of the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
	/// </summary><remarks>
	/// Must only be used for custom context menu items that are of kind <c>CoreWebView2ContextMenuItemKind.CheckBox</c> or <c>CoreWebView2ContextMenuItemKind.Radio</c>.
	/// </remarks>
	public bool IsChecked
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.IsChecked != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ContextMenuItem.IsChecked = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the enabled property of the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />. Must only be used in the case of a custom context menu item.
	/// </summary><remarks>
	/// The default value for this is <c>true</c>.
	/// </remarks>
	public bool IsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.IsEnabled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ContextMenuItem.IsEnabled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the kind of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" /> as <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItemKind" />.</summary>
	public CoreWebView2ContextMenuItemKind Kind
	{
		get
		{
			try
			{
				return (CoreWebView2ContextMenuItemKind)_nativeICoreWebView2ContextMenuItem.Kind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the localized label for the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />. Will contain an ampersand for characters to be used as keyboard accelerator.</summary>
	public string Label
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.Label;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the unlocalized name for the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
	/// </summary><remarks>
	/// Use this to distinguish between context menu item types. This will be the English label of the menu item in lower camel case. For example, the "Save as" menu item will be "saveAs". Extension menu items will be "extension", custom menu items will be "custom" and spellcheck items will be "spellCheck".
	/// Some example context menu item names are:
	///
	/// <list type="bullet"><item><description>
	/// "saveAs"
	/// </description></item><item><description>
	/// "copyImage"
	/// </description></item><item><description>
	/// "openLinkInNewWindow"
	/// </description></item></list></remarks>
	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.Name;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the localized keyboard shortcut for this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
	/// </summary><remarks>
	/// It will be the empty string if there is no keyboard shortcut. This is text intended to be displayed to the end user to show the keyboard shortcut. For example this property is Ctrl+Shift+I for the "Inspect" <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
	/// </remarks>
	public string ShortcutKeyDescription
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.ShortcutKeyDescription;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// CustomItemSelected event is raised when the user selects this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
	/// </summary><remarks>
	/// Will only be raised for end developer created context menu items.
	/// </remarks>
	public event EventHandler<object> CustomItemSelected
	{
		add
		{
			if (privateCustomItemSelected == null)
			{
				try
				{
					_nativeICoreWebView2ContextMenuItem.add_CustomItemSelected(new CoreWebView2CustomItemSelectedEventHandler(OnCustomItemSelected), out _CustomItemSelectedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateCustomItemSelected = (EventHandler<object>)Delegate.Combine(privateCustomItemSelected, value);
		}
		remove
		{
			privateCustomItemSelected = (EventHandler<object>)Delegate.Remove(privateCustomItemSelected, value);
			if (privateCustomItemSelected != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2ContextMenuItem.remove_CustomItemSelected(_CustomItemSelectedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ContextMenuItem members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ContextMenuItem(object rawCoreWebView2ContextMenuItem)
	{
		_rawNative = rawCoreWebView2ContextMenuItem;
	}

	internal void OnCustomItemSelected(object args)
	{
		privateCustomItemSelected?.Invoke(this, args);
	}
}
