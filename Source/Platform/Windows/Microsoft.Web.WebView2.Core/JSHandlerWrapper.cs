using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core;

internal class JSHandlerWrapper
{
	private object _JSHandler;

	public JSHandlerWrapper(object JSHandler)
	{
		_JSHandler = JSHandler;
	}

	[DllImport("oleaut32.dll", PreserveSig = false)]
	internal static extern void VariantClear(IntPtr variant);

	public void Invoke(params object[] args)
	{
		int num = Marshal.SizeOf(typeof(Variant));
		System.Runtime.InteropServices.ComTypes.DISPPARAMS dISPPARAMS = new System.Runtime.InteropServices.ComTypes.DISPPARAMS
		{
			cArgs = args.Length
		};
		try
		{
			if (!(_JSHandler is IDispatch dispatch))
			{
				throw new ArgumentException("The callback object is not an IDispatch's implement.");
			}
			if (dISPPARAMS.cArgs != 0)
			{
				dISPPARAMS.rgvarg = Marshal.AllocHGlobal(dISPPARAMS.cArgs * num);
				for (int i = 0; i < dISPPARAMS.cArgs; i++)
				{
					Marshal.GetNativeVariantForObject(args[dISPPARAMS.cArgs - 1 - i], dISPPARAMS.rgvarg + i * num);
				}
			}
			System.Runtime.InteropServices.ComTypes.EXCEPINFO eXCEPINFO = default(System.Runtime.InteropServices.ComTypes.EXCEPINFO);
			object pVarResult = null;
			uint pArgErr = 0u;
			Guid riid = Guid.Empty;
			System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams = dISPPARAMS;
			System.Runtime.InteropServices.ComTypes.EXCEPINFO pExcepInfo = eXCEPINFO;
			Marshal.ThrowExceptionForHR(dispatch.Invoke(-1, ref riid, 1024u, 1, ref pDispParams, out pVarResult, ref pExcepInfo, out pArgErr));
		}
		finally
		{
			try
			{
				if (dISPPARAMS.cArgs != 0)
				{
					for (int j = 0; j < dISPPARAMS.cArgs; j++)
					{
						VariantClear(dISPPARAMS.rgvarg + j * num);
					}
					Marshal.FreeHGlobal(dISPPARAMS.rgvarg);
				}
			}
			catch
			{
			}
		}
	}

	public Delegate CreateDelegate(EventInfo eventInfo)
	{
		try
		{
			MethodInfo method = eventInfo.EventHandlerType.GetMethod("Invoke");
			Type returnType = method.ReturnType;
			if (returnType != typeof(void))
			{
				throw new Exception("The" + eventInfo.Name + "'s return type should be void.");
			}
			Type[] array = method.GetParameters().Select((ParameterInfo p, int i) => p.ParameterType).ToArray();
			Type[] array2 = new Type[array.Length + 1];
			array2[0] = typeof(JSHandlerWrapper);
			array.CopyTo(array2, 1);
			DynamicMethod dynamicMethod = new DynamicMethod("DelegateHandler", MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, array2, typeof(JSHandlerWrapper).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.DeclareLocal(typeof(object).MakeArrayType());
			iLGenerator.Emit(OpCodes.Ldc_I4, array.Length);
			iLGenerator.Emit(OpCodes.Newarr, typeof(object));
			iLGenerator.Emit(OpCodes.Stloc_0);
			for (int num = 0; num < array.Length; num++)
			{
				iLGenerator.Emit(OpCodes.Ldloc_0);
				iLGenerator.Emit(OpCodes.Ldc_I4, num);
				iLGenerator.Emit(OpCodes.Ldarg_S, num + 1);
				if (array[num].IsValueType)
				{
					iLGenerator.Emit(OpCodes.Box, array[num]);
				}
				iLGenerator.Emit(OpCodes.Stelem_Ref);
			}
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Call, typeof(JSHandlerWrapper).GetMethod("Invoke"));
			iLGenerator.Emit(OpCodes.Ret);
			return dynamicMethod.CreateDelegate(eventInfo.EventHandlerType, this);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}
