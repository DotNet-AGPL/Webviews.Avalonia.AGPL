using System;

namespace Microsoft.Web.WebView2.Core;

/// <summary>Specifies the datatype for the
/// `ICoreWebView2Profile2::ClearBrowsingData` method.</summary>
[Flags]
public enum CoreWebView2BrowsingDataKinds
{
	/// <summary>Specifies file systems data.</summary>
	FileSystems = 1,
	/// <summary>Specifies data stored by the IndexedDB DOM feature.</summary>
	IndexedDb = 2,
	/// <summary>Specifies data stored by the localStorage DOM API.</summary>
	LocalStorage = 4,
	/// <summary>Specifies data stored by the Web SQL database DOM API.</summary>
	WebSql = 8,
	/// <summary>Specifies data stored by the CacheStorage DOM API.</summary>
	CacheStorage = 0x10,
	/// <summary>Specifies DOM storage data, now and future. This browsing data kind is
	/// inclusive of COREWEBVIEW2_BROWSING_DATA_KINDS_FILE_SYSTEMS,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_INDEXED_DB,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_LOCAL_STORAGE,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_WEB_SQL,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_SERVICE_WORKERS,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_CACHE_STORAGE,
	/// and some other data kinds not listed yet to keep consistent with
	/// [DOM-accessible storage](https://www.w3.org/TR/clear-site-data/#storage).</summary>
	AllDomStorage = 0x20,
	/// <summary>Specifies HTTP cookies data.</summary>
	Cookies = 0x40,
	/// <summary>Specifies all site data, now and future. This browsing data kind
	/// is inclusive of COREWEBVIEW2_BROWSING_DATA_KINDS_ALL_DOM_STORAGE and
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_COOKIES. New site data types
	/// may be added to this data kind in the future.</summary>
	AllSite = 0x80,
	/// <summary>Specifies disk cache.</summary>
	DiskCache = 0x100,
	/// <summary>Specifies download history data.</summary>
	DownloadHistory = 0x200,
	/// <summary>Specifies general autofill form data.
	/// This excludes password information and includes information like:
	/// names, street and email addresses, phone numbers, and arbitrary input.
	/// This also includes payment data.</summary>
	GeneralAutofill = 0x400,
	/// <summary>Specifies password autosave data.</summary>
	PasswordAutosave = 0x800,
	/// <summary>Specifies browsing history data.</summary>
	BrowsingHistory = 0x1000,
	/// <summary>Specifies settings data.</summary>
	Settings = 0x2000,
	/// <summary>Specifies profile data that should be wiped to make it look like a new profile.
	/// This does not delete account-scoped data like passwords but will remove access
	/// to account-scoped data by signing the user out.
	/// Specifies all profile data, now and future. New profile data types may be added
	/// to this data kind in the future.
	/// This browsing data kind is inclusive of COREWEBVIEW2_BROWSING_DATA_KINDS_ALL_SITE,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_DISK_CACHE,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_DOWNLOAD_HISTORY,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_GENERAL_AUTOFILL,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_PASSWORD_AUTOSAVE,
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_BROWSING_HISTORY, and
	/// COREWEBVIEW2_BROWSING_DATA_KINDS_SETTINGS.</summary>
	AllProfile = 0x4000,
	/// <summary>Specifies service workers registered for an origin, and clear will result in
	/// termination and deregistration of them.</summary>
	ServiceWorkers = 0x8000
}
