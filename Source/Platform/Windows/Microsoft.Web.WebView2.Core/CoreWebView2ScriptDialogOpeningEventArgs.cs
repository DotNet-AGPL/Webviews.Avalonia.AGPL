using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ScriptDialogOpening" /> event.</summary>
public class CoreWebView2ScriptDialogOpeningEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2ScriptDialogOpeningEventArgs _nativeICoreWebView2ScriptDialogOpeningEventArgsValue;

	internal ICoreWebView2ScriptDialogOpeningEventArgs _nativeICoreWebView2ScriptDialogOpeningEventArgs
	{
		get
		{
			if (_nativeICoreWebView2ScriptDialogOpeningEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2ScriptDialogOpeningEventArgsValue = (ICoreWebView2ScriptDialogOpeningEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ScriptDialogOpeningEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2ScriptDialogOpeningEventArgsValue = value;
		}
	}

	/// <summary>
	/// Gets the default value to use for the result of the <c>prompt</c> JavaScript function.
	/// </summary><remarks>
	/// This is the second parameter passed to the JavaScript prompt dialog.
	/// </remarks>
	public string DefaultText
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptDialogOpeningEventArgs.DefaultText;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the kind of JavaScript dialog box.
	/// </summary><seealso cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogKind" />
	public CoreWebView2ScriptDialogKind Kind
	{
		get
		{
			try
			{
				return (CoreWebView2ScriptDialogKind)_nativeICoreWebView2ScriptDialogOpeningEventArgs.Kind;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the message of the dialog box.
	/// </summary><remarks>
	/// From JavaScript this is the first parameter passed to <c>alert</c>, <c>confirm</c>, and <c>prompt</c> and is empty for <c>beforeunload</c>.
	/// </remarks>
	public string Message
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptDialogOpeningEventArgs.Message;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets or sets the return value from the JavaScript <c>prompt</c> function if <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs.Accept" /> is run.</summary><remarks>
	/// This value is ignored for <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs.Kind" />s other than <see cref="F:Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogKind.Prompt" />. If <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs.Accept" /> is not run, this value is ignored and <c>false</c> is returned from <c>prompt</c>.
	/// </remarks>
	public string ResultText
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptDialogOpeningEventArgs.ResultText;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ScriptDialogOpeningEventArgs.ResultText = value;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Gets the URI of the page that requested the dialog box.</summary>
	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ScriptDialogOpeningEventArgs.Uri;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ScriptDialogOpeningEventArgs(object rawCoreWebView2ScriptDialogOpeningEventArgs)
	{
		_rawNative = rawCoreWebView2ScriptDialogOpeningEventArgs;
	}

	/// <summary>
	/// Responds with **OK** to <c>confirm</c>, <c>prompt</c>, and <c>beforeunload</c> dialogs. Not run this method to indicate cancel.
	/// </summary><remarks>
	/// From JavaScript, this means that the <c>confirm</c> function and <c>beforeunload</c> event returns <c>true</c> if Accept is run. And for the <c>prompt</c> function it returns the value of <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs.ResultText" /> if Accept is run and otherwise returns <c>false</c>.
	/// </remarks>
	public void Accept()
	{
		try
		{
			_nativeICoreWebView2ScriptDialogOpeningEventArgs.Accept();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Gets a Deferral object.
	/// Use this to Complete the event at a later time.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2ScriptDialogOpeningEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2ScriptDialogOpeningEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
