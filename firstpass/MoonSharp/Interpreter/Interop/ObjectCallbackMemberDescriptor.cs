using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B0 RID: 176
	public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x0000DAF9 File Offset: 0x0000BCF9
		public ObjectCallbackMemberDescriptor(string funcName)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0000DB01 File Offset: 0x0000BD01
		public ObjectCallbackMemberDescriptor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0000DB09 File Offset: 0x0000BD09
		public ObjectCallbackMemberDescriptor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack, ParameterDescriptor[] parameters)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0000DB11 File Offset: 0x0000BD11
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x04000322 RID: 802
		private Func<object, ScriptExecutionContext, CallbackArguments, object> m_CallbackFunc;

		// Token: 0x0200019C RID: 412
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F66 RID: 3942 RVA: 0x0000F4D3 File Offset: 0x0000D6D3
			internal object <.ctor>b__1_0(object o, ScriptExecutionContext c, CallbackArguments a)
			{
				return null;
			}

			// Token: 0x0400069D RID: 1693
			public static readonly ObjectCallbackMemberDescriptor.<>c <>9;

			// Token: 0x0400069E RID: 1694
			public static Func<object, ScriptExecutionContext, CallbackArguments, object> <>9__1_0;
		}
	}
}
