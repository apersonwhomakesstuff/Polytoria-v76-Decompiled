using System;
using System.Collections.Generic;
using System.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000028 RID: 40
	public sealed class CallbackFunction : RefIdObject
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000C90F File Offset: 0x0000AB0F
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0000C917 File Offset: 0x0000AB17
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000C920 File Offset: 0x0000AB20
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000C928 File Offset: 0x0000AB28
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback
		{
			get
			{
				return this.<ClrCallback>k__BackingField;
			}
			private set
			{
				this.<ClrCallback>k__BackingField = value;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000C931 File Offset: 0x0000AB31
		public CallbackFunction(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name = null)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000C939 File Offset: 0x0000AB39
		public DynValue Invoke(ScriptExecutionContext executionContext, IList<DynValue> args, bool isMethodCall = false)
		{
			return null;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00010190 File Offset: 0x0000E390
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000C93C File Offset: 0x0000AB3C
		public static InteropAccessMode DefaultAccessMode
		{
			get
			{
				return InteropAccessMode.Reflection;
			}
			set
			{
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000C93E File Offset: 0x0000AB3E
		public static CallbackFunction FromDelegate(Script script, Delegate del, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			return null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000C941 File Offset: 0x0000AB41
		public static CallbackFunction FromMethodInfo(Script script, MethodInfo mi, object obj = null, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			return null;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000C944 File Offset: 0x0000AB44
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000C94C File Offset: 0x0000AB4C
		public object AdditionalData
		{
			get
			{
				return this.<AdditionalData>k__BackingField;
			}
			set
			{
				this.<AdditionalData>k__BackingField = value;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000C955 File Offset: 0x0000AB55
		public static bool CheckCallbackSignature(MethodInfo mi, bool requirePublicVisibility)
		{
			return false;
		}

		// Token: 0x04000153 RID: 339
		private static InteropAccessMode m_DefaultAccessMode;

		// Token: 0x04000154 RID: 340
		private string <Name>k__BackingField;

		// Token: 0x04000155 RID: 341
		private Func<ScriptExecutionContext, CallbackArguments, DynValue> <ClrCallback>k__BackingField;

		// Token: 0x04000156 RID: 342
		private object <AdditionalData>k__BackingField;
	}
}
