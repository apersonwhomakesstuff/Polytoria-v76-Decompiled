using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000029 RID: 41
	public class Closure : RefIdObject, IScriptPrivateResource
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000C95A File Offset: 0x0000AB5A
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000C962 File Offset: 0x0000AB62
		public int EntryPointByteCodeLocation
		{
			get
			{
				return this.<EntryPointByteCodeLocation>k__BackingField;
			}
			private set
			{
				this.<EntryPointByteCodeLocation>k__BackingField = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000C96B File Offset: 0x0000AB6B
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000C973 File Offset: 0x0000AB73
		public Script OwnerScript
		{
			get
			{
				return this.<OwnerScript>k__BackingField;
			}
			private set
			{
				this.<OwnerScript>k__BackingField = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000C97C File Offset: 0x0000AB7C
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000C984 File Offset: 0x0000AB84
		internal ClosureContext ClosureContext
		{
			get
			{
				return this.<ClosureContext>k__BackingField;
			}
			private set
			{
				this.<ClosureContext>k__BackingField = value;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000C98D File Offset: 0x0000AB8D
		internal Closure(Script script, int idx, SymbolRef[] symbols, IEnumerable<DynValue> resolvedLocals)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000C995 File Offset: 0x0000AB95
		public DynValue Call()
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000C998 File Offset: 0x0000AB98
		public DynValue Call(object[] args)
		{
			return null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000C99B File Offset: 0x0000AB9B
		public DynValue Call(DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000C99E File Offset: 0x0000AB9E
		public ScriptFunctionDelegate GetDelegate()
		{
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000C9A1 File Offset: 0x0000ABA1
		public ScriptFunctionDelegate<T> GetDelegate<T>()
		{
			return null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		public int GetUpvaluesCount()
		{
			return 0;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000C9A7 File Offset: 0x0000ABA7
		public string GetUpvalueName(int idx)
		{
			return null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000C9AA File Offset: 0x0000ABAA
		public DynValue GetUpvalue(int idx)
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000101A8 File Offset: 0x0000E3A8
		public Closure.UpvaluesType GetUpvaluesType()
		{
			return Closure.UpvaluesType.None;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000C9AF File Offset: 0x0000ABAF
		private object <GetDelegate>b__18_0(object[] args)
		{
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000101C0 File Offset: 0x0000E3C0
		private T <GetDelegate>b__19_0<T>(object[] args)
		{
			return default(T);
		}

		// Token: 0x04000157 RID: 343
		private int <EntryPointByteCodeLocation>k__BackingField;

		// Token: 0x04000158 RID: 344
		private Script <OwnerScript>k__BackingField;

		// Token: 0x04000159 RID: 345
		private static ClosureContext emptyClosure;

		// Token: 0x0400015A RID: 346
		private ClosureContext <ClosureContext>k__BackingField;

		// Token: 0x0200017B RID: 379
		public enum UpvaluesType
		{
			// Token: 0x0400062E RID: 1582
			None,
			// Token: 0x0400062F RID: 1583
			Environment,
			// Token: 0x04000630 RID: 1584
			Closure
		}
	}
}
