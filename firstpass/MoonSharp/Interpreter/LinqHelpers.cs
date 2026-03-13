using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004D RID: 77
	public static class LinqHelpers
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x0000D00A File Offset: 0x0000B20A
		public static IEnumerable<T> Convert<T>(IEnumerable<DynValue> enumerable, DataType type)
		{
			return null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000D00D File Offset: 0x0000B20D
		public static IEnumerable<DynValue> OfDataType(IEnumerable<DynValue> enumerable, DataType type)
		{
			return null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000D010 File Offset: 0x0000B210
		public static IEnumerable<object> AsObjects(IEnumerable<DynValue> enumerable)
		{
			return null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000D013 File Offset: 0x0000B213
		public static IEnumerable<T> AsObjects<T>(IEnumerable<DynValue> enumerable)
		{
			return null;
		}

		// Token: 0x02000184 RID: 388
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F21 RID: 3873 RVA: 0x0000F3A5 File Offset: 0x0000D5A5
			internal object <AsObjects>b__2_0(DynValue v)
			{
				return null;
			}

			// Token: 0x04000654 RID: 1620
			public static readonly LinqHelpers.<>c <>9;

			// Token: 0x04000655 RID: 1621
			public static Func<DynValue, object> <>9__2_0;
		}

		// Token: 0x02000185 RID: 389
		[Serializable]
		private sealed class <>c__0<T>
		{
			// Token: 0x06000F24 RID: 3876 RVA: 0x00010BB0 File Offset: 0x0000EDB0
			internal T <Convert>b__0_1(DynValue v)
			{
				return default(T);
			}

			// Token: 0x04000656 RID: 1622
			public static readonly LinqHelpers.<>c__0<T> <>9;

			// Token: 0x04000657 RID: 1623
			public static Func<DynValue, T> <>9__0_1;
		}

		// Token: 0x02000186 RID: 390
		[Serializable]
		private sealed class <>c__3<T>
		{
			// Token: 0x06000F27 RID: 3879 RVA: 0x00010BC8 File Offset: 0x0000EDC8
			internal T <AsObjects>b__3_0(DynValue v)
			{
				return default(T);
			}

			// Token: 0x04000658 RID: 1624
			public static readonly LinqHelpers.<>c__3<T> <>9;

			// Token: 0x04000659 RID: 1625
			public static Func<DynValue, T> <>9__3_0;
		}

		// Token: 0x02000187 RID: 391
		private sealed class <>c__DisplayClass0_0<T>
		{
			// Token: 0x06000F29 RID: 3881 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
			internal bool <Convert>b__0(DynValue v)
			{
				return false;
			}

			// Token: 0x0400065A RID: 1626
			public DataType type;
		}

		// Token: 0x02000188 RID: 392
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06000F2B RID: 3883 RVA: 0x0000F3CF File Offset: 0x0000D5CF
			internal bool <OfDataType>b__0(DynValue v)
			{
				return false;
			}

			// Token: 0x0400065B RID: 1627
			public DataType type;
		}
	}
}
