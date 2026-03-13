using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CC RID: 204
	public class LuaState
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0000E171 File Offset: 0x0000C371
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x0000E179 File Offset: 0x0000C379
		public ScriptExecutionContext ExecutionContext
		{
			get
			{
				return this.<ExecutionContext>k__BackingField;
			}
			private set
			{
				this.<ExecutionContext>k__BackingField = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0000E182 File Offset: 0x0000C382
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x0000E18A File Offset: 0x0000C38A
		public string FunctionName
		{
			get
			{
				return this.<FunctionName>k__BackingField;
			}
			private set
			{
				this.<FunctionName>k__BackingField = value;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000E193 File Offset: 0x0000C393
		internal LuaState(ScriptExecutionContext executionContext, CallbackArguments args, string functionName)
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0000E19B File Offset: 0x0000C39B
		public DynValue Top(int pos = 0)
		{
			return null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0000E19E File Offset: 0x0000C39E
		public DynValue At(int pos)
		{
			return null;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0000E1A1 File Offset: 0x0000C3A1
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		public void Push(DynValue v)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0000E1A6 File Offset: 0x0000C3A6
		public DynValue Pop()
		{
			return null;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000E1A9 File Offset: 0x0000C3A9
		public DynValue[] GetTopArray(int num)
		{
			return null;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		public DynValue GetReturnValue(int retvals)
		{
			return null;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0000E1AF File Offset: 0x0000C3AF
		public void Discard(int nargs)
		{
		}

		// Token: 0x04000389 RID: 905
		private List<DynValue> m_Stack;

		// Token: 0x0400038A RID: 906
		private ScriptExecutionContext <ExecutionContext>k__BackingField;

		// Token: 0x0400038B RID: 907
		private string <FunctionName>k__BackingField;
	}
}
