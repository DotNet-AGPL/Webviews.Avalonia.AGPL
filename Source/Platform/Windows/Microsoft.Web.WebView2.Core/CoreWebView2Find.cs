using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Interface providing methods and properties for finding and navigating through text in the web view.
/// This interface allows for finding text, navigation between matches, and customization of the find UI.</summary>
public class CoreWebView2Find
{
	internal object _rawNative;

	internal ICoreWebView2Find _nativeICoreWebView2FindValue;

	private EventRegistrationToken _ActiveMatchIndexChangedToken;

	private EventHandler<object> privateActiveMatchIndexChanged;

	private EventRegistrationToken _MatchCountChangedToken;

	private EventHandler<object> privateMatchCountChanged;

	internal ICoreWebView2Find _nativeICoreWebView2Find
	{
		get
		{
			if (_nativeICoreWebView2FindValue == null)
			{
				try
				{
					_nativeICoreWebView2FindValue = (ICoreWebView2Find)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Find.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FindValue;
		}
		set
		{
			_nativeICoreWebView2FindValue = value;
		}
	}

	/// <summary>Retrieves the index of the currently active match in the find session. Returns the index of the currently active match, or -1 if there is no active match.
	/// The index starts at 1 for the first match.
	/// </summary>
	public int ActiveMatchIndex
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Find.ActiveMatchIndex;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Gets the total count of matches found in the current document based on the last find sessions criteria. Returns the total count of matches.
	/// </summary>
	public int MatchCount
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Find.MatchCount;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Registers an event handler for the ActiveMatchIndexChanged event. This event is raised when the index of the currently active match changes.
	/// This can happen when the user navigates to a different match or when the active match is changed programmatically.
	/// The parameter is the event handler to be added. Returns a token representing the added event handler.
	/// This token can be used to unregister the event handler.</summary>
	public event EventHandler<object> ActiveMatchIndexChanged
	{
		add
		{
			if (privateActiveMatchIndexChanged == null)
			{
				try
				{
					_nativeICoreWebView2Find.add_ActiveMatchIndexChanged(new CoreWebView2FindActiveMatchIndexChangedEventHandler(OnActiveMatchIndexChanged), out _ActiveMatchIndexChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateActiveMatchIndexChanged = (EventHandler<object>)Delegate.Combine(privateActiveMatchIndexChanged, value);
		}
		remove
		{
			privateActiveMatchIndexChanged = (EventHandler<object>)Delegate.Remove(privateActiveMatchIndexChanged, value);
			if (privateActiveMatchIndexChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Find.remove_ActiveMatchIndexChanged(_ActiveMatchIndexChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Registers an event handler for the MatchCountChanged event.
	/// This event is raised when the total count of matches in the document changes due to a new find session or changes in the document.
	/// The parameter is the event handler to be added. Returns a token representing the added event handler. This token can be used to unregister the event handler.</summary>
	public event EventHandler<object> MatchCountChanged
	{
		add
		{
			if (privateMatchCountChanged == null)
			{
				try
				{
					_nativeICoreWebView2Find.add_MatchCountChanged(new CoreWebView2FindMatchCountChangedEventHandler(OnMatchCountChanged), out _MatchCountChangedToken);
				}
				catch (InvalidCastException ex)
				{
					if (ex.HResult == -2147467262)
					{
						throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (COMException ex2)
				{
					if (ex2.HResult == -2147019873)
					{
						throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
			privateMatchCountChanged = (EventHandler<object>)Delegate.Combine(privateMatchCountChanged, value);
		}
		remove
		{
			privateMatchCountChanged = (EventHandler<object>)Delegate.Remove(privateMatchCountChanged, value);
			if (privateMatchCountChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Find.remove_MatchCountChanged(_MatchCountChangedToken);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2Find(object rawCoreWebView2Find)
	{
		_rawNative = rawCoreWebView2Find;
	}

	internal void OnActiveMatchIndexChanged(object args)
	{
		privateActiveMatchIndexChanged?.Invoke(this, args);
	}

	internal void OnMatchCountChanged(object args)
	{
		privateMatchCountChanged?.Invoke(this, args);
	}

	/// <summary>Initiates a find using the specified find options asynchronously.
	/// Displays the Find bar and starts the find session. If a find session was already ongoing, it will be stopped and replaced with this new instance.
	/// If called with an empty string, the Find bar is displayed but no finding occurs. Changing the FindOptions object after initiation won't affect the ongoing find session.
	/// To change the ongoing find session, Start must be called again with a new or modified FindOptions object.
	/// Start supports HTML and TXT document queries. In general, this API is designed for text-based find sessions.
	/// If you start a find session programmatically on another file format that doesn't have text fields, the find session will try to execute but will fail to find any matches. (It will silently fail)
	/// Note: The asynchronous action completes when the UI has been displayed with the find term in the UI bar, and the matches have populated on the counter on the find bar.
	/// There may be a slight latency between the UI display and the matches populating in the counter.
	/// The MatchCountChanged and ActiveMatchIndexChanged events are only raised after Start has completed; otherwise, they will have their default values (-1 for active match index and 0 for match count).
	/// To start a new find session (beginning the search from the first match), call `Stop` before invoking `Start`.
	/// If `Start` is called consecutively with the same options and without calling `Stop`, the find session
	/// will continue from the current position in the existing session.
	/// Calling `Start` without altering its parameters will behave either as `FindNext` or `FindPrevious`, depending on the most recent search action performed.
	/// Start will default to forward if neither have been called.
	/// However, calling Start again during an ongoing find session does not resume from the point
	/// of the current active match. For example, given the text "1 1 A 1 1" and initiating a find session for "A",
	/// then starting another find session for "1", it will start searching from the beginning of the document,
	/// regardless of the previous active match. This behavior indicates that changing the find query initiates a
	/// completely new find session, rather than continuing from the previous match index.
	/// </summary>
	public async Task StartAsync(CoreWebView2FindOptions options)
	{
		CoreWebView2FindStartCompletedHandler handler;
		try
		{
			handler = new CoreWebView2FindStartCompletedHandler();
			_nativeICoreWebView2Find.Start(options._nativeICoreWebView2FindOptions, handler);
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	/// <summary>Navigates to the next match in the document.
	/// If there are no matches to find, FindNext will wrap around to the first match's index.
	/// If called when there is no find session active, FindNext will silently fail.
	/// </summary>
	public void FindNext()
	{
		try
		{
			_nativeICoreWebView2Find.FindNext();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Navigates to the previous match in the document.
	/// If there are no matches to find, FindPrevious will wrap around to the last match's index.
	/// If called when there is no find session active, FindPrevious will silently fail.
	/// </summary>
	public void FindPrevious()
	{
		try
		{
			_nativeICoreWebView2Find.FindPrevious();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>Stops the current 'Find' session and hides the Find bar.
	/// If called with no Find session active, it will silently do nothing.
	/// </summary>
	public void Stop()
	{
		try
		{
			_nativeICoreWebView2Find.Stop();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Find members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Find members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
