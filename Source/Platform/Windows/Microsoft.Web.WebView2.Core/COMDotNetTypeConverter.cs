using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal static class COMDotNetTypeConverter
{
	public static IReadOnlyList<string> stringCollectionCOMToNet(ICoreWebView2StringCollection rawCollection)
	{
		if (rawCollection == null)
		{
			return null;
		}
		List<string> list = new List<string>(Convert.ToInt32(rawCollection.Count));
		for (uint num = 0u; num < rawCollection.Count; num++)
		{
			list.Add(rawCollection.GetValueAtIndex(num));
		}
		return new ReadOnlyCollection<string>(list);
	}

	public static IReadOnlyList<CoreWebView2ClientCertificate> CoreWebView2ClientCertificateCollectionCOMToNet(ICoreWebView2ClientCertificateCollection rawCollection)
	{
		if (rawCollection == null)
		{
			return null;
		}
		List<CoreWebView2ClientCertificate> list = new List<CoreWebView2ClientCertificate>(Convert.ToInt32(rawCollection.Count));
		for (uint num = 0u; num < rawCollection.Count; num++)
		{
			list.Add(new CoreWebView2ClientCertificate(rawCollection.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<CoreWebView2ClientCertificate>(list);
	}

	public static IReadOnlyList<Rectangle> RectangleCollectionCOMToNet(ICoreWebView2RegionRectCollectionView rawCollection)
	{
		if (rawCollection == null)
		{
			return null;
		}
		List<Rectangle> list = new List<Rectangle>(Convert.ToInt32(rawCollection.Count));
		for (uint num = 0u; num < rawCollection.Count; num++)
		{
			list.Add(RectangleCOMToNet(rawCollection.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<Rectangle>(list);
	}

	public static IReadOnlyList<CoreWebView2ProcessExtendedInfo> CoreWebView2ProcessExtendedInfoCollectionCOMToNet(ICoreWebView2ProcessExtendedInfoCollection rawCollection)
	{
		if (rawCollection == null)
		{
			return null;
		}
		List<CoreWebView2ProcessExtendedInfo> list = new List<CoreWebView2ProcessExtendedInfo>(Convert.ToInt32(rawCollection.Count));
		for (uint num = 0u; num < rawCollection.Count; num++)
		{
			list.Add(new CoreWebView2ProcessExtendedInfo(rawCollection.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<CoreWebView2ProcessExtendedInfo>(list);
	}

	public static IReadOnlyList<CoreWebView2ProcessInfo> CoreWebView2ProcessInfoCollectionCOMToNet(ICoreWebView2ProcessInfoCollection rawCollection)
	{
		if (rawCollection == null)
		{
			return null;
		}
		List<CoreWebView2ProcessInfo> list = new List<CoreWebView2ProcessInfo>(Convert.ToInt32(rawCollection.Count));
		for (uint num = 0u; num < rawCollection.Count; num++)
		{
			list.Add(new CoreWebView2ProcessInfo(rawCollection.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<CoreWebView2ProcessInfo>(list);
	}

	public static IReadOnlyList<CoreWebView2BrowserExtension> CoreWebView2BrowserExtensionCollectionCOMToNet(ICoreWebView2BrowserExtensionList rawCollection)
	{
		if (rawCollection == null)
		{
			return null;
		}
		List<CoreWebView2BrowserExtension> list = new List<CoreWebView2BrowserExtension>(Convert.ToInt32(rawCollection.Count));
		for (uint num = 0u; num < rawCollection.Count; num++)
		{
			list.Add(new CoreWebView2BrowserExtension(rawCollection.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<CoreWebView2BrowserExtension>(list);
	}

	public static Rectangle RectangleCOMToNet(tagRECT rect)
	{
		int x = rect.left;
		int y = rect.top;
		int width = rect.right - rect.left;
		int height = rect.bottom - rect.top;
		return new Rectangle(x, y, width, height);
	}

	public static tagRECT RectangleNetToCOM(Rectangle dotNetRect)
	{
		return new tagRECT
		{
			top = dotNetRect.Top,
			left = dotNetRect.Left,
			right = dotNetRect.Right,
			bottom = dotNetRect.Bottom
		};
	}

	public static List<CoreWebView2Cookie> CoreWebView2CookieCollectionCOMToNet(ICoreWebView2CookieList rawCookieList)
	{
		List<CoreWebView2Cookie> list = new List<CoreWebView2Cookie>(Convert.ToInt32(rawCookieList.Count));
		for (uint num = 0u; num < rawCookieList.Count; num++)
		{
			list.Add(new CoreWebView2Cookie(rawCookieList.GetValueAtIndex(num)));
		}
		return list;
	}

	public static IReadOnlyList<CoreWebView2FrameInfo> CoreWebView2FrameInfoCollectionCOMToNet(ICoreWebView2FrameInfoCollection rawFrameInfoCollection)
	{
		if (rawFrameInfoCollection == null)
		{
			return null;
		}
		List<CoreWebView2FrameInfo> list = new List<CoreWebView2FrameInfo>();
		ICoreWebView2FrameInfoCollectionIterator iterator = rawFrameInfoCollection.GetIterator();
		while (iterator.HasCurrent != 0)
		{
			list.Add(new CoreWebView2FrameInfo(iterator.GetCurrent()));
			iterator.MoveNext();
		}
		return new ReadOnlyCollection<CoreWebView2FrameInfo>(list);
	}

	public static Color ColorCOMToNet(COREWEBVIEW2_COLOR color)
	{
		return Color.FromArgb(color.A, color.R, color.G, color.B);
	}

	public static COREWEBVIEW2_COLOR ColorNetToCOM(Color dotNetColor)
	{
		return new COREWEBVIEW2_COLOR
		{
			A = dotNetColor.A,
			R = dotNetColor.R,
			G = dotNetColor.G,
			B = dotNetColor.B
		};
	}

	public static Point PointCOMToNet(tagPOINT point)
	{
		return new Point(point.x, point.y);
	}

	public static tagPOINT PointNetToCOM(Point dotNetPoint)
	{
		return new tagPOINT
		{
			x = Convert.ToInt32(dotNetPoint.X),
			y = Convert.ToInt32(dotNetPoint.Y)
		};
	}

	public static TimeSpan ThrottlingIntervalCOMToNet(int intervalMs)
	{
		return new TimeSpan(0, 0, 0, 0, intervalMs);
	}

	public static int ThrottlingIntervalNetToCOM(TimeSpan timeSpan)
	{
		return timeSpan.Milliseconds;
	}

	public static IReadOnlyList<string> CoreWebView2StringCollectionCOMToNet(ICoreWebView2StringCollection rawStringCollection)
	{
		if (rawStringCollection == null)
		{
			return null;
		}
		List<string> list = new List<string>(Convert.ToInt32(rawStringCollection.Count));
		for (uint num = 0u; num < rawStringCollection.Count; num++)
		{
			list.Add(rawStringCollection.GetValueAtIndex(num));
		}
		return new ReadOnlyCollection<string>(list);
	}

	public static IReadOnlyList<object> objectCollectionCOMToNet(ICoreWebView2ObjectCollectionView rawObjectCollection)
	{
		if (rawObjectCollection == null)
		{
			return null;
		}
		List<object> list = new List<object>(Convert.ToInt32(rawObjectCollection.Count));
		for (uint num = 0u; num < rawObjectCollection.Count; num++)
		{
			object obj = rawObjectCollection.GetValueAtIndex(num);
			if (obj != null)
			{
				if (!(obj is ICoreWebView2File rawCoreWebView2File))
				{
					continue;
				}
				obj = new CoreWebView2File(rawCoreWebView2File);
			}
			list.Add(obj);
		}
		return new ReadOnlyCollection<object>(list);
	}

	public static IList<CoreWebView2ContextMenuItem> CoreWebView2ContextMenuItemCollectionCOMToNet(ICoreWebView2ContextMenuItemCollection rawContextMenuCollection)
	{
		if (rawContextMenuCollection == null)
		{
			return null;
		}
		List<CoreWebView2ContextMenuItem> list = new List<CoreWebView2ContextMenuItem>(Convert.ToInt32(rawContextMenuCollection.Count));
		for (uint num = 0u; num < rawContextMenuCollection.Count; num++)
		{
			list.Add(new CoreWebView2ContextMenuItem(rawContextMenuCollection.GetValueAtIndex(num)));
		}
		ObservableCollection<CoreWebView2ContextMenuItem> collection = new ObservableCollection<CoreWebView2ContextMenuItem>(list);
		collection.CollectionChanged += delegate(object sender, NotifyCollectionChangedEventArgs args)
		{
			switch (args.Action)
			{
			case NotifyCollectionChangedAction.Remove:
				rawContextMenuCollection.RemoveValueAtIndex((uint)args.OldStartingIndex);
				break;
			case NotifyCollectionChangedAction.Add:
				rawContextMenuCollection.InsertValueAtIndex((uint)args.NewStartingIndex, ((CoreWebView2ContextMenuItem)args.NewItems[0])._nativeICoreWebView2ContextMenuItem);
				break;
			case NotifyCollectionChangedAction.Replace:
				rawContextMenuCollection.RemoveValueAtIndex((uint)args.OldStartingIndex);
				rawContextMenuCollection.InsertValueAtIndex((uint)args.NewStartingIndex, ((CoreWebView2ContextMenuItem)args.NewItems[0])._nativeICoreWebView2ContextMenuItem);
				break;
			case NotifyCollectionChangedAction.Move:
			case NotifyCollectionChangedAction.Reset:
			{
				uint count = rawContextMenuCollection.Count;
				for (uint num2 = 0u; num2 < count; num2++)
				{
					rawContextMenuCollection.RemoveValueAtIndex(0u);
				}
				for (int i = 0; i < collection.Count; i++)
				{
					rawContextMenuCollection.InsertValueAtIndex((uint)i, collection[i]._nativeICoreWebView2ContextMenuItem);
				}
				break;
			}
			}
		};
		return collection;
	}

	public static IReadOnlyList<Rectangle> CoreWebView2RegionRectCollectionViewCOMToNet(ICoreWebView2RegionRectCollectionView regionList)
	{
		if (regionList == null)
		{
			return null;
		}
		List<Rectangle> list = new List<Rectangle>(Convert.ToInt32(regionList.Count));
		for (uint num = 0u; num < regionList.Count; num++)
		{
			list.Add(RectangleCOMToNet(regionList.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<Rectangle>(list);
	}

	public static COMStreamWrapper StreamCOMToNet(IStream stream)
	{
		if (stream == null)
		{
			return null;
		}
		return new COMStreamWrapper(stream);
	}

	public static IReadOnlyList<CoreWebView2PermissionSetting> CoreWebView2PermissionSettingCollectionCOMToNet(ICoreWebView2PermissionSettingCollectionView rawPermissionSettingCollectionView)
	{
		if (rawPermissionSettingCollectionView == null)
		{
			return null;
		}
		List<CoreWebView2PermissionSetting> list = new List<CoreWebView2PermissionSetting>(Convert.ToInt32(rawPermissionSettingCollectionView.Count));
		for (uint num = 0u; num < rawPermissionSettingCollectionView.Count; num++)
		{
			list.Add(new CoreWebView2PermissionSetting(rawPermissionSettingCollectionView.GetValueAtIndex(num)));
		}
		return new ReadOnlyCollection<CoreWebView2PermissionSetting>(list);
	}

	public static ICoreWebView2ObjectCollectionView CoreWebView2WebObjectCollectionViewNetToCOM(List<object> dotNetObjectCollection)
	{
		return new CoreWebView2WebObjectCollectionView(dotNetObjectCollection);
	}
}
