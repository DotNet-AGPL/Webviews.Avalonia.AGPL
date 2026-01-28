using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class EventConnector
{
	private DelegateMap _DelegatesMap = new DelegateMap();

	private object _originalHostObject;

	public EventConnector(object originalHostObject)
	{
		_originalHostObject = originalHostObject;
	}

	public void addEventListener(string eventName, object JSHandler)
	{
		try
		{
			CoreWebView2PrivateRemoteObjectProxy coreWebView2PrivateRemoteObjectProxy = new CoreWebView2PrivateRemoteObjectProxy(JSHandler);
			int id = coreWebView2PrivateRemoteObjectProxy.GetId();
			EventInfo eventInfo = CheckAndGetEventInfo(eventName);
			Delegate obj = _DelegatesMap.GetDelegate(id);
			if ((object)obj == null)
			{
				coreWebView2PrivateRemoteObjectProxy.Passivated += RemoteObjectPassivated;
				obj = new JSHandlerWrapper(JSHandler).CreateDelegate(eventInfo);
			}
			if (_DelegatesMap.InsertDelegate(eventName, id, obj))
			{
				eventInfo.AddEventHandler(_originalHostObject, obj);
			}
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public void removeEventListener(string eventName, object JSHandler)
	{
		try
		{
			Delegate obj = _DelegatesMap.RemoveDelegate(eventName, (JSHandler as ICoreWebView2PrivateRemoteObjectProxy).GetId());
			if ((object)obj != null)
			{
				CheckAndGetEventInfo(eventName).RemoveEventHandler(_originalHostObject, obj);
			}
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

	private void RemoteObjectPassivated(object sender, object args)
	{
		try
		{
			int id = (sender as CoreWebView2PrivateRemoteObjectProxy).GetId();
			List<string> registeredEventNameById = _DelegatesMap.GetRegisteredEventNameById(id);
			Delegate obj = _DelegatesMap.GetDelegate(id);
			if ((object)obj == null)
			{
				return;
			}
			foreach (string item in registeredEventNameById)
			{
				_DelegatesMap.RemoveDelegate(item, id);
				CheckAndGetEventInfo(item).RemoveEventHandler(_originalHostObject, obj);
			}
		}
		catch (Exception)
		{
		}
	}

	private EventInfo CheckAndGetEventInfo(string eventName)
	{
		EventInfo eventInfo = _originalHostObject.GetType().GetEvent(eventName, BindingFlags.Instance | BindingFlags.Public);
		if (eventInfo == null)
		{
			throw new Exception("No such event or it is not public, event's name:" + eventName + ".");
		}
		return eventInfo;
	}
}
