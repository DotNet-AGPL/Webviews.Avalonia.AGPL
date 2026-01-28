using System;
using System.Collections.Generic;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2WebObjectCollectionView : ICoreWebView2ObjectCollectionView
{
	private readonly List<object> _collection;

	uint ICoreWebView2ObjectCollectionView.Count => (uint)_collection.Count;

	internal CoreWebView2WebObjectCollectionView(List<object> collection)
	{
		_collection = collection;
	}

	object ICoreWebView2ObjectCollectionView.GetValueAtIndex(uint index)
	{
		if (index < _collection.Count)
		{
			if (_collection[(int)index] is CoreWebView2FileSystemHandle coreWebView2FileSystemHandle)
			{
				return coreWebView2FileSystemHandle._nativeICoreWebView2FileSystemHandle;
			}
			if (_collection[(int)index] is CoreWebView2File coreWebView2File)
			{
				return coreWebView2File._nativeICoreWebView2File;
			}
			return _collection[(int)index];
		}
		throw new IndexOutOfRangeException();
	}
}
