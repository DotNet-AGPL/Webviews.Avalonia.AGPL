namespace Microsoft.Web.WebView2.Core;

/// <summary>Indicates the type of a permission request.</summary>
public enum CoreWebView2PermissionKind
{
	/// <summary>Indicates an unknown permission.</summary>
	UnknownPermission,
	/// <summary>Indicates permission to capture audio.</summary>
	Microphone,
	/// <summary>Indicates permission to capture video.</summary>
	Camera,
	/// <summary>Indicates permission to access geolocation.</summary>
	Geolocation,
	/// <summary>Indicates permission to send web notifications. Apps that would like to
	/// show notifications should handle `PermissionRequested` events
	/// and no browser permission prompt will be shown for notification requests.
	/// Note that push notifications are currently unavailable in WebView2.</summary>
	Notifications,
	/// <summary>Indicates permission to access generic sensor.  Generic Sensor covering
	/// ambient-light-sensor, accelerometer, gyroscope, and magnetometer.</summary>
	OtherSensors,
	/// <summary>Indicates permission to read the system clipboard without a user gesture.</summary>
	ClipboardRead,
	/// <summary>Indicates permission to automatically download multiple files. Permission
	/// is requested when multiple downloads are triggered in quick succession.</summary>
	MultipleAutomaticDownloads,
	/// <summary>Indicates permission to read and write to files or folders on the device.
	/// Permission is requested when developers use the [File System Access API](https://developer.mozilla.org/docs/Web/API/File_System_Access_API)
	/// to show the file or folder picker to the end user, and then request
	/// "readwrite" permission for the user's selection.</summary>
	FileReadWrite,
	/// <summary>Indicates permission to play audio and video automatically on sites. This
	/// permission affects the autoplay attribute and play method of the audio and
	/// video HTML elements, and the start method of the Web Audio API. See the
	/// [Autoplay guide for media and Web Audio APIs](https://developer.mozilla.org/docs/Web/Media/Autoplay_guide) for details.</summary>
	Autoplay,
	/// <summary>Indicates permission to use fonts on the device. Permission is requested
	/// when developers use the [Local Font Access API](https://wicg.github.io/local-font-access/)
	/// to query the system fonts available for styling web content.</summary>
	LocalFonts,
	/// <summary>Indicates permission to send and receive system exclusive messages to/from MIDI
	/// (Musical Instrument Digital Interface) devices. Permission is requested
	/// when developers use the [Web MIDI API](https://developer.mozilla.org/docs/Web/API/Web_MIDI_API)
	/// to request access to system exclusive MIDI messages.</summary>
	MidiSystemExclusiveMessages,
	/// <summary>Indicates permission to open and place windows on the screen. Permission is
	/// requested when developers use the [Multi-Screen Window Placement API](https://www.w3.org/TR/window-placement/)
	/// to get screen details.</summary>
	WindowManagement
}
