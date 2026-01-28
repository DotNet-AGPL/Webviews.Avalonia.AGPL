using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Represents a certificate and provides access to its metadata.</summary>
public class CoreWebView2Certificate
{
	internal object _rawNative;

	internal ICoreWebView2Certificate _nativeICoreWebView2CertificateValue;

	private static DateTime _unixEpoch = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);

	internal ICoreWebView2Certificate _nativeICoreWebView2Certificate
	{
		get
		{
			if (_nativeICoreWebView2CertificateValue == null)
			{
				try
				{
					_nativeICoreWebView2CertificateValue = (ICoreWebView2Certificate)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Certificate.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CertificateValue;
		}
		set
		{
			_nativeICoreWebView2CertificateValue = value;
		}
	}

	/// <summary>
	/// Base64 encoding of DER encoded serial number of the certificate. Read more about DER at [RFC 7468 DER](https://tools.ietf.org/html/rfc7468#appendix-B).</summary>
	public string DerEncodedSerialNumber
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Certificate.DerEncodedSerialNumber;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Display name for a certificate.
	/// </summary>
	public string DisplayName
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Certificate.DisplayName;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Name of the certificate authority that issued the certificate.</summary>
	public string Issuer
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Certificate.Issuer;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// Returns list of PEM encoded certificate issuer chain. In this list first element is the current certificate followed by intermediate1, intermediate2...intermediateN-1. Root certificate is the last element in the list.</summary>
	public IReadOnlyList<string> PemEncodedIssuerCertificateChain
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.stringCollectionCOMToNet(_nativeICoreWebView2Certificate.PemEncodedIssuerCertificateChain);
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>Subject of the certificate.</summary>
	public string Subject
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Certificate.Subject;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2Certificate members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	/// <summary>
	/// The valid date and time for the certificate since the UNIX epoc.
	/// </summary>
	public DateTime ValidFrom => SecondsSinceUnixEpochToDateTime(_nativeICoreWebView2Certificate.ValidFrom);

	/// <summary>
	/// The valid date and time for the certificate since the UNIX epoc.
	/// </summary>
	public DateTime ValidTo => SecondsSinceUnixEpochToDateTime(_nativeICoreWebView2Certificate.ValidTo);

	internal CoreWebView2Certificate(object rawCoreWebView2Certificate)
	{
		_rawNative = rawCoreWebView2Certificate;
	}

	/// <summary>
	/// PEM encoded data for the certificate. Returns Base64 encoding of DER encoded certificate. Read more about PEM at [RFC 1421 Privacy Enhanced Mail](https://tools.ietf.org/html/rfc1421).</summary>
	public string ToPemEncoding()
	{
		try
		{
			return _nativeICoreWebView2Certificate.ToPemEncoding();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2Certificate members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2Certificate members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	/// <summary>
	/// Converts this to a X509Certificate2.
	/// </summary>
	/// <returns>
	/// An object created using PEM encoded data from
	/// this <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Certificate" /> object.
	/// </returns>
	/// <seealso cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />
	public X509Certificate2 ToX509Certificate2()
	{
		X509Certificate2 x509Certificate = new X509Certificate2(Convert.FromBase64String(ToPemEncoding().Replace("-----BEGIN CERTIFICATE-----", string.Empty).Replace("-----END CERTIFICATE-----", string.Empty)));
		if (x509Certificate != null)
		{
			x509Certificate.FriendlyName = DisplayName;
		}
		return x509Certificate;
	}

	private DateTime SecondsSinceUnixEpochToDateTime(double seconds)
	{
		if (seconds < 0.0)
		{
			return DateTime.MinValue;
		}
		if (seconds * 10000000.0 + (double)_unixEpoch.Ticks > (double)DateTime.MaxValue.Ticks)
		{
			return DateTime.MaxValue;
		}
		return _unixEpoch.AddSeconds(seconds);
	}
}
