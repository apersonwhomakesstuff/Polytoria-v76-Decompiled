using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000027 RID: 39
	public class CallbackArguments
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x0000C8DA File Offset: 0x0000AADA
		public CallbackArguments(IList<DynValue> args, bool isMethodCall)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000C8E2 File Offset: 0x0000AAE2
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000C8E5 File Offset: 0x0000AAE5
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000C8ED File Offset: 0x0000AAED
		public bool IsMethodCall
		{
			get
			{
				return this.<IsMethodCall>k__BackingField;
			}
			private set
			{
				this.<IsMethodCall>k__BackingField = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000C8F6 File Offset: 0x0000AAF6
		public DynValue Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000C8F9 File Offset: 0x0000AAF9
		public DynValue RawGet(int index, bool translateVoids)
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		public DynValue[] GetArray(int skip = 0)
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000C8FF File Offset: 0x0000AAFF
		public DynValue AsType(int argNum, string funcName, DataType type, bool allowNil = false)
		{
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00010178 File Offset: 0x0000E378
		public T AsUserData<T>(int argNum, string funcName, bool allowNil = false)
		{
			return default(T);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000C902 File Offset: 0x0000AB02
		public int AsInt(int argNum, string funcName)
		{
			return 0;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000C905 File Offset: 0x0000AB05
		public long AsLong(int argNum, string funcName)
		{
			return 0L;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000C909 File Offset: 0x0000AB09
		public string AsStringUsingMeta(ScriptExecutionContext executionContext, int argNum, string funcName)
		{
			return null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000C90C File Offset: 0x0000AB0C
		public CallbackArguments SkipMethodCall()
		{
			return null;
		}

		// Token: 0x0400014F RID: 335
		private IList<DynValue> m_Args;

		// Token: 0x04000150 RID: 336
		private int m_Count;

		// Token: 0x04000151 RID: 337
		private bool m_LastIsTuple;

		// Token: 0x04000152 RID: 338
		private bool <IsMethodCall>k__BackingField;
	}
}
