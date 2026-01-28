using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

/// <summary>
/// Represents the registration of a custom scheme with the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />.
/// </summary><remarks>
/// This allows the WebView2 app to be able to handle <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event for requests with the specified scheme and be able to navigate the WebView2 to the custom scheme. Once the environment is created, the registrations are valid and immutable throughout the lifetime of the associated WebView2s' browser process and any WebView2 environments sharing the browser process must be created with identical custom scheme registrations, otherwise the environment creation will fail.
/// Any further attempts to register the same scheme will fail during environment creation.
/// The URIs of registered custom schemes will be treated similar to http URIs for their origins.
/// They will have tuple origins for URIs with host and opaque origins for URIs without host as specified in [7.5 Origin - HTML Living Standard](https://html.spec.whatwg.org/multipage/origin.html).
///
/// Example:
///
/// `custom-scheme-with-host://hostname/path/to/resource` has origin of `custom-scheme-with-host://hostname`.
/// `custom-scheme-without-host:path/to/resource` has origin of `custom-scheme-without-host:path/to/resource`.
///
/// For <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event, the cases of request URIs and filter URIs with custom schemes will be normalized according to generic URI syntax rules. Any non-ASCII characters will be preserved.
/// The registered custom schemes also participate in [CORS](https://developer.mozilla.org/docs/Web/HTTP/CORS) and adheres to [CSP](https://developer.mozilla.org/docs/Web/HTTP/CSP).
/// The app needs to set the appropriate access headers in its <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event handler to allow CORS requests.
/// </remarks>
/// <summary>
/// Represents the registration of a custom scheme with the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2Environment" />.
/// </summary>
/// <remarks>
/// This allows the WebView2 app to be able to handle <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event for requests with the
/// specified scheme and be able to navigate the WebView2 to the custom
/// scheme. Once the environment is created, the registrations are valid and
/// immutable throughout the lifetime of the associated WebView2s' browser
/// process and any WebView2 environments sharing the browser process must be
/// created with identical custom scheme registrations, otherwise the
/// environment creation will fail. Any further attempts to register the same
/// scheme will fail during environment creation. The URIs of registered
/// custom schemes will be treated similar to http URIs for their origins.
/// They will have tuple origins for URIs with host and opaque origins for
/// URIs without host as specified in [7.5 Origin - HTML Living Standard](https://html.spec.whatwg.org/multipage/origin.html) For <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event, the cases of request
/// URIs and filter URIs with custom schemes will be normalized according to
/// generic URI syntax rules. Any non-ASCII characters will be preserved. The
/// registered custom schemes also participate in [CORS](https://developer.mozilla.org/docs/Web/HTTP/CORS) and adheres to
/// [CSP](https://developer.mozilla.org/docs/Web/HTTP/CSP). The app needs to
/// set the appropriate access headers in its <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested" /> event handler to allow CORS
/// requests.
/// </remarks>
/// <example>
/// <c>custom-scheme-with-host://hostname/path/to/resource</c> has origin of
/// <c>custom-scheme-with-host://hostname</c>.
/// <c>custom-scheme-without-host:path/to/resource</c> has origin of
/// <c>custom-scheme-without-host:path/to/resource</c>.
/// </example>
public class CoreWebView2CustomSchemeRegistration
{
	private class RawCustomSchemeRegistration : ICoreWebView2CustomSchemeRegistration
	{
		public string SchemeName { get; set; }

		public int TreatAsSecure { get; set; }

		public int HasAuthorityComponent { get; set; }

		private List<string> AllowedOrigins { get; } = new List<string>();

		public RawCustomSchemeRegistration(string schemeName, bool treatAsSecure, bool hasAuthorityComponent, List<string> allowedOrigins)
		{
			SchemeName = schemeName;
			TreatAsSecure = (treatAsSecure ? 1 : 0);
			HasAuthorityComponent = (hasAuthorityComponent ? 1 : 0);
			AllowedOrigins = allowedOrigins;
		}

		public void GetAllowedOrigins(out uint allowedOriginsCount, IntPtr allowedOriginsPtr)
		{
			allowedOriginsCount = (uint)AllowedOrigins.Count;
			if (allowedOriginsCount != 0)
			{
				IntPtr intPtr = Marshal.AllocCoTaskMem((int)allowedOriginsCount * Marshal.SizeOf<IntPtr>());
				for (int i = 0; i < allowedOriginsCount; i++)
				{
					Marshal.WriteIntPtr(intPtr + i * Marshal.SizeOf<IntPtr>(), Marshal.StringToCoTaskMemAuto(AllowedOrigins[i]));
				}
				Marshal.WriteIntPtr(allowedOriginsPtr, intPtr);
			}
		}

		public void SetAllowedOrigins(uint allowedOriginsCount, ref string allowedOrigins)
		{
			throw new NotImplementedException();
		}
	}

	internal object _rawNative;

	internal ICoreWebView2CustomSchemeRegistration _nativeICoreWebView2CustomSchemeRegistrationValue;

	internal ICoreWebView2CustomSchemeRegistration _nativeICoreWebView2CustomSchemeRegistration
	{
		get
		{
			if (_nativeICoreWebView2CustomSchemeRegistrationValue == null)
			{
				try
				{
					_nativeICoreWebView2CustomSchemeRegistrationValue = (ICoreWebView2CustomSchemeRegistration)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CustomSchemeRegistration.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CustomSchemeRegistrationValue;
		}
		set
		{
			_nativeICoreWebView2CustomSchemeRegistrationValue = value;
		}
	}

	/// <summary>
	/// The name of the custom scheme to register.
	/// </summary>
	public string SchemeName { get; }

	/// <summary>
	/// Whether the sites with this scheme will be treated as a [Secure
	/// Context](https://developer.mozilla.org/docs/Web/Security/Secure_Contexts)
	/// like an HTTPS site.
	/// </summary>
	public bool TreatAsSecure { get; set; }

	/// <summary>
	/// Set this property to <c>true</c> if the URIs with this custom scheme
	/// will have an authority component (a host for custom schemes).
	/// Specifically, if you have a URI of the following form you should set the
	/// <c>HasAuthorityComponent</c> value as listed.
	///
	/// <list type="table">
	/// <listheader>
	/// <description>URI</description>
	/// <description>Recommended HasAuthorityComponent value</description>
	/// </listheader>
	/// <item>
	/// <description><c>custom-scheme-with-authority://host/path</c></description>
	/// <description><c>true</c></description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme-without-authority:path</c></description>
	/// <description><c>false</c></description>
	/// </item>
	/// </list>
	/// </summary>
	/// <remarks>
	/// When this property is set to <c>true</c>, the URIs with this scheme will
	/// be interpreted as having a [scheme and
	/// host](https://html.spec.whatwg.org/multipage/origin.html#concept-origin-tuple)
	/// origin similar to an http URI. Note that the port and user information
	/// are never included in the computation of origins for custom schemes. If
	/// this property is set to <c>false</c>, URIs with this scheme will have an
	/// [opaque
	/// origin](https://html.spec.whatwg.org/multipage/origin.html#concept-origin-opaque)
	/// similar to a data URI. This property is <c>false</c> by default. Note:
	/// For custom schemes registered as having authority component, navigations
	/// to URIs without authority of such custom schemes will fail. However, if
	/// the content inside WebView2 references a subresource with a URI that
	/// does not have an authority component, but of a custom scheme that is
	/// registered as having authority component, the URI will be interpreted as
	/// a relative path as specified in
	/// [RFC3986](https://www.rfc-editor.org/rfc/rfc3986). For example,
	/// <c>custom-scheme-with-authority:path</c> will be interpreted as
	/// <c>custom-scheme-with-authority://host/path</c>. However, this behavior
	/// cannot be guaranteed to remain in future releases so it is recommended
	/// not to rely on this behavior.
	/// </remarks>
	public bool HasAuthorityComponent { get; set; }

	/// <summary>
	/// List of origins that are allowed to issue requests with the custom
	/// scheme, such as XHRs and subresource requests that have an Origin
	/// header.
	/// </summary>
	/// <remarks>
	/// The origin of any request (requests that have the [Origin
	/// header](https://developer.mozilla.org/docs/Web/HTTP/Headers/Origin)) to
	/// the custom scheme URI needs to be in this list. No-origin requests are
	/// requests that do not have an Origin header, such as link navigations,
	/// embedded images and are always allowed. Note that cross-origin
	/// restrictions still apply. From any opaque origin (Origin header is
	/// null), no cross-origin requests are allowed. If the list is empty, no
	/// cross-origin request to this scheme is allowed. Origins are specified as
	/// a string in the format of <c>scheme://host:port</c>. The origins are
	/// string pattern matched with <c>*</c> (matches 0 or more characters) and
	/// <c>?</c> (matches 0 or 1 character) wildcards just like the URI matching
	/// in the <see cref="M:Microsoft.Web.WebView2.Core.CoreWebView2.AddWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestSourceKinds)" />
	/// API. For example, <c>http://*.example.com:80</c>.
	///
	/// Here's a set of examples of what is allowed or not:
	///
	/// <list type="table">
	/// <listheader>
	/// <description>Request URI</description>
	/// <description>Originating URL</description>
	/// <description>AllowedOrigins</description>
	/// <description>Allowed</description>
	/// </listheader>
	/// <item>
	/// <description><c>custom-scheme:request</c></description>
	/// <description><c>https://www.example.com</c></description>
	/// <description>{"https://www.example.com"}</description>
	/// <description>Yes</description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme:request</c></description>
	/// <description><c>https://www.example.com</c></description>
	/// <description>{"https://*.example.com"}</description>
	/// <description>Yes</description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme:request</c></description>
	/// <description><c>https://www.example.com</c></description>
	/// <description>{"https://www.example2.com"}</description>
	/// <description>No</description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme-with-authority://host/path</c></description>
	/// <description><c>custom-scheme-with-authority://host2</c></description>
	/// <description>{""}</description>
	/// <description>No</description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme-with-authority://host/path</c></description>
	/// <description><c>custom-scheme-with-authority2://host</c></description>
	/// <description>{"custom-scheme-with-authority2://*"}</description>
	/// <description>Yes</description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme-without-authority:path</c></description>
	/// <description>custom-scheme-without-authority:path2</description>
	/// <description>{"custom-scheme-without-authority:*"}</description>
	/// <description>No</description>
	/// </item>
	/// <item>
	/// <description><c>custom-scheme-without-authority:path</c></description>
	/// <description>custom-scheme-without-authority:path2</description>
	/// <description>{"*"}</description>
	/// <description>Yes</description>
	/// </item>
	/// </list>
	/// </remarks>
	public List<string> AllowedOrigins { get; set; } = new List<string>();

	internal CoreWebView2CustomSchemeRegistration(object rawCoreWebView2CustomSchemeRegistration)
	{
		_rawNative = rawCoreWebView2CustomSchemeRegistration;
	}

	/// <summary>
	/// Initializes a new instance of the CoreWebView2CustomSchemeRegistration
	/// class.
	/// </summary>
	/// <param name="schemeName">
	/// The name of the custom scheme to register.
	/// </param>
	public CoreWebView2CustomSchemeRegistration(string schemeName)
	{
		SchemeName = schemeName;
	}

	internal IntPtr GetNative()
	{
		return Marshal.GetComInterfaceForObject(new RawCustomSchemeRegistration(SchemeName, TreatAsSecure, HasAuthorityComponent, AllowedOrigins), typeof(ICoreWebView2CustomSchemeRegistration));
	}
}
