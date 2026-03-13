using System;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors
{
	// Token: 0x020000C0 RID: 192
	internal class EventFacade : IUserDataType
	{
		// Token: 0x06000900 RID: 2304 RVA: 0x0000DF0B File Offset: 0x0000C10B
		public EventFacade(EventMemberDescriptor parent, object obj)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0000DF13 File Offset: 0x0000C113
		public EventFacade(Func<object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback, Func<object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback, object obj)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0000DF1B File Offset: 0x0000C11B
		public DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0000DF1E File Offset: 0x0000C11E
		public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return false;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0000DF21 File Offset: 0x0000C121
		public DynValue MetaIndex(Script script, string metaname)
		{
			return null;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0000DF24 File Offset: 0x0000C124
		private DynValue <Index>b__5_0(ScriptExecutionContext c, CallbackArguments a)
		{
			return null;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000DF27 File Offset: 0x0000C127
		private DynValue <Index>b__5_1(ScriptExecutionContext c, CallbackArguments a)
		{
			return null;
		}

		// Token: 0x04000371 RID: 881
		private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_AddCallback;

		// Token: 0x04000372 RID: 882
		private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_RemoveCallback;

		// Token: 0x04000373 RID: 883
		private object m_Object;
	}
}
