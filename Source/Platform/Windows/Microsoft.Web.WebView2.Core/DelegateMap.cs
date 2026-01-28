using System;
using System.Collections.Generic;

namespace Microsoft.Web.WebView2.Core;

internal class DelegateMap
{
	private class tuple
	{
		public int count;

		public Delegate handler;

		public tuple(int count, Delegate handler)
		{
			this.count = count;
			this.handler = handler;
		}
	}

	private Dictionary<string, HashSet<int>> _RegisteredHandlerIdsMap = new Dictionary<string, HashSet<int>>();

	private Dictionary<int, tuple> _HandlerMap = new Dictionary<int, tuple>();

	public Delegate GetDelegate(int handlerId)
	{
		try
		{
			return _HandlerMap[handlerId].handler;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public bool InsertDelegate(string eventName, int handlerId, Delegate handler)
	{
		try
		{
			if (!_RegisteredHandlerIdsMap.ContainsKey(eventName))
			{
				_RegisteredHandlerIdsMap[eventName] = new HashSet<int>();
			}
			HashSet<int> hashSet = _RegisteredHandlerIdsMap[eventName];
			if (hashSet.Contains(handlerId))
			{
				return false;
			}
			hashSet.Add(handlerId);
			if (_HandlerMap.ContainsKey(handlerId))
			{
				_HandlerMap[handlerId].count++;
			}
			else
			{
				_HandlerMap[handlerId] = new tuple(1, handler);
			}
			return true;
		}
		catch (Exception ex)
		{
			if (ex.InnerException != null)
			{
				throw ex.InnerException;
			}
			throw ex;
		}
	}

	public Delegate RemoveDelegate(string eventName, int handlerId)
	{
		try
		{
			if (!_RegisteredHandlerIdsMap.ContainsKey(eventName))
			{
				return null;
			}
			HashSet<int> hashSet = _RegisteredHandlerIdsMap[eventName];
			if (!hashSet.Remove(handlerId))
			{
				return null;
			}
			if (hashSet.Count == 0)
			{
				_RegisteredHandlerIdsMap.Remove(eventName);
			}
			tuple obj = _HandlerMap[handlerId];
			obj.count--;
			if (obj.count == 0)
			{
				_HandlerMap.Remove(handlerId);
			}
			return obj.handler;
		}
		catch (Exception ex)
		{
			if (ex.InnerException != null)
			{
				throw ex.InnerException;
			}
			throw ex;
		}
	}

	public List<string> GetRegisteredEventNameById(int handlerId)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, HashSet<int>> item in _RegisteredHandlerIdsMap)
		{
			if (item.Value.Contains(handlerId))
			{
				list.Add(item.Key);
			}
		}
		return list;
	}
}
