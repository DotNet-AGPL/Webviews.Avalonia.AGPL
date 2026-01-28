using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Event args for the <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ClientCertificateRequested" /> event.</summary>
public class CoreWebView2ClientCertificateRequestedEventArgs : EventArgs
{
	internal object _rawNative;

	internal ICoreWebView2ClientCertificateRequestedEventArgs _nativeICoreWebView2ClientCertificateRequestedEventArgsValue;

	internal ICoreWebView2ClientCertificateRequestedEventArgs _nativeICoreWebView2ClientCertificateRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2ClientCertificateRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2ClientCertificateRequestedEventArgsValue = (ICoreWebView2ClientCertificateRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ClientCertificateRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ClientCertificateRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2ClientCertificateRequestedEventArgsValue = value;
		}
	}

	/// <summary>
	/// The list contains Base64 encoding of DER encoded distinguished names of certificate authorities allowed by the server.</summary>
	public IReadOnlyList<string> AllowedCertificateAuthorities
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.stringCollectionCOMToNet(_nativeICoreWebView2ClientCertificateRequestedEventArgs.AllowedCertificateAuthorities);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Indicates whether to cancel the certificate selection.
	/// </summary><remarks>
	/// If canceled, the request is aborted regardless of the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Handled" /> property. By default the value is false.
	/// </remarks>
	public bool Cancel
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ClientCertificateRequestedEventArgs.Cancel != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ClientCertificateRequestedEventArgs.Cancel = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Indicates whether the event has been handled by host.
	/// </summary><remarks>
	/// Set to true to respond to the server with or without a certificate. If this flag is true with a <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate" /> it responds to the server with the selected certificate otherwise respond to the server without a certificate. By default the value of <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Handled" /> and <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Cancel" /> are false and display default client certificate selection dialog prompt to allow the user to choose a certificate. The <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate" /> is ignored unless <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Handled" /> is set to true.
	/// </remarks>
	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ClientCertificateRequestedEventArgs.Handled != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ClientCertificateRequestedEventArgs.Handled = (value ? 1 : 0);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Host name of the server that requested client certificate authentication.
	/// </summary><remarks>
	/// Normalization rules applied to the hostname are:
	///
	/// <list type="bullet"><item><description>Convert to lowercase characters for ascii characters.</description></item><item><description>Punycode is used for representing non ascii characters.</description></item><item><description>Strip square brackets for IPV6 address.</description></item></list></remarks>
	public string Host
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ClientCertificateRequestedEventArgs.Host;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Returns true if the server that issued this request is an http proxy. Returns false if the server is the origin server.</summary>
	public bool IsProxy
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ClientCertificateRequestedEventArgs.IsProxy != 0;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns the list of <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate" /> when client certificate authentication is requested. The list contains mutually trusted CA certificate.</summary>
	public IReadOnlyList<CoreWebView2ClientCertificate> MutuallyTrustedCertificates
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.CoreWebView2ClientCertificateCollectionCOMToNet(_nativeICoreWebView2ClientCertificateRequestedEventArgs.MutuallyTrustedCertificates);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Port of the server that requested client certificate authentication.</summary>
	public int Port
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ClientCertificateRequestedEventArgs.Port;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Selected certificate to respond to the server.</summary>
	public CoreWebView2ClientCertificate SelectedCertificate
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate == null) ? null : new CoreWebView2ClientCertificate(_nativeICoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
		set
		{
			try
			{
				_nativeICoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate = value._nativeICoreWebView2ClientCertificate;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2ClientCertificateRequestedEventArgs(object rawCoreWebView2ClientCertificateRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2ClientCertificateRequestedEventArgs;
	}

	/// <summary>
	/// Gets a Deferral object.
	/// Use this to Complete the event at a later time.</summary>
	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2ClientCertificateRequestedEventArgs.GetDeferral());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2ClientCertificateRequestedEventArgs members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
