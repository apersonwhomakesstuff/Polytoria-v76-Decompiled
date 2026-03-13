using System;
using System.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000050 RID: 80
	public static class ModuleRegister
	{
		// Token: 0x060005A5 RID: 1445 RVA: 0x0000D019 File Offset: 0x0000B219
		public static Table RegisterCoreModules(Table table, CoreModules modules)
		{
			return null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000D01C File Offset: 0x0000B21C
		public static Table RegisterConstants(Table table)
		{
			return null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000D01F File Offset: 0x0000B21F
		public static Table RegisterModuleType(Table gtable, Type t)
		{
			return null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000D022 File Offset: 0x0000B222
		private static void RegisterScriptFieldAsConst(FieldInfo fi, object o, Table table, Type t, string name)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000D024 File Offset: 0x0000B224
		private static void RegisterScriptField(FieldInfo fi, object o, Table table, Type t, string name)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000D026 File Offset: 0x0000B226
		private static Table CreateModuleNamespace(Table gtable, Type t)
		{
			return null;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000D029 File Offset: 0x0000B229
		public static Table RegisterModuleType<T>(Table table)
		{
			return null;
		}

		// Token: 0x02000189 RID: 393
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F2E RID: 3886 RVA: 0x0000F3DC File Offset: 0x0000D5DC
			internal bool <RegisterModuleType>b__2_0(MethodInfo __mi)
			{
				return false;
			}

			// Token: 0x06000F2F RID: 3887 RVA: 0x0000F3DF File Offset: 0x0000D5DF
			internal bool <RegisterModuleType>b__2_1(FieldInfo _mi)
			{
				return false;
			}

			// Token: 0x06000F30 RID: 3888 RVA: 0x0000F3E2 File Offset: 0x0000D5E2
			internal bool <RegisterModuleType>b__2_2(FieldInfo _mi)
			{
				return false;
			}

			// Token: 0x0400065C RID: 1628
			public static readonly ModuleRegister.<>c <>9;

			// Token: 0x0400065D RID: 1629
			public static Func<MethodInfo, bool> <>9__2_0;

			// Token: 0x0400065E RID: 1630
			public static Func<FieldInfo, bool> <>9__2_1;

			// Token: 0x0400065F RID: 1631
			public static Func<FieldInfo, bool> <>9__2_2;
		}
	}
}
