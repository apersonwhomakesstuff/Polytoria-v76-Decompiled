using System;
using System.Collections;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D3 RID: 211
	internal static class TableConversions
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x0000E205 File Offset: 0x0000C405
		internal static Table ConvertIListToTable(Script script, IList list)
		{
			return null;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0000E208 File Offset: 0x0000C408
		internal static Table ConvertIDictionaryToTable(Script script, IDictionary dict)
		{
			return null;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0000E20B File Offset: 0x0000C40B
		internal static bool CanConvertTableToType(Table table, Type t)
		{
			return false;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0000E20E File Offset: 0x0000C40E
		internal static object ConvertTableToType(Table table, Type t)
		{
			return null;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0000E211 File Offset: 0x0000C411
		internal static object ConvertTableToDictionaryOfGenericType(Type dictionaryType, Type keyType, Type valueType, Table table)
		{
			return null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0000E214 File Offset: 0x0000C414
		internal static object ConvertTableToArrayOfGenericType(Type arrayType, Type itemType, Table table)
		{
			return null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0000E217 File Offset: 0x0000C417
		internal static object ConvertTableToListOfGenericType(Type listType, Type itemType, Table table)
		{
			return null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0000E21A File Offset: 0x0000C41A
		internal static List<T> TableToList<T>(Table table, Func<DynValue, T> converter)
		{
			return null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0000E21D File Offset: 0x0000C41D
		internal static Dictionary<TK, TV> TableToDictionary<TK, TV>(Table table, Func<DynValue, TK> keyconverter, Func<DynValue, TV> valconverter)
		{
			return null;
		}

		// Token: 0x020001C0 RID: 448
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001009 RID: 4105 RVA: 0x0000F640 File Offset: 0x0000D840
			internal object <ConvertTableToType>b__3_0(DynValue v)
			{
				return null;
			}

			// Token: 0x0600100A RID: 4106 RVA: 0x0000F643 File Offset: 0x0000D843
			internal object <ConvertTableToType>b__3_1(DynValue v)
			{
				return null;
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x0000F646 File Offset: 0x0000D846
			internal DynValue <ConvertTableToType>b__3_2(DynValue v)
			{
				return null;
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x0000F649 File Offset: 0x0000D849
			internal DynValue <ConvertTableToType>b__3_3(DynValue v)
			{
				return null;
			}

			// Token: 0x0600100D RID: 4109 RVA: 0x0000F64C File Offset: 0x0000D84C
			internal object <ConvertTableToType>b__3_4(DynValue v)
			{
				return null;
			}

			// Token: 0x0600100E RID: 4110 RVA: 0x0000F64F File Offset: 0x0000D84F
			internal DynValue <ConvertTableToType>b__3_5(DynValue v)
			{
				return null;
			}

			// Token: 0x0600100F RID: 4111 RVA: 0x0000F652 File Offset: 0x0000D852
			internal object <ConvertTableToType>b__3_6(DynValue v)
			{
				return null;
			}

			// Token: 0x06001010 RID: 4112 RVA: 0x0000F655 File Offset: 0x0000D855
			internal DynValue <ConvertTableToType>b__3_7(DynValue v)
			{
				return null;
			}

			// Token: 0x040006EC RID: 1772
			public static readonly TableConversions.<>c <>9;

			// Token: 0x040006ED RID: 1773
			public static Func<DynValue, object> <>9__3_0;

			// Token: 0x040006EE RID: 1774
			public static Func<DynValue, object> <>9__3_1;

			// Token: 0x040006EF RID: 1775
			public static Func<DynValue, DynValue> <>9__3_2;

			// Token: 0x040006F0 RID: 1776
			public static Func<DynValue, DynValue> <>9__3_3;

			// Token: 0x040006F1 RID: 1777
			public static Func<DynValue, object> <>9__3_4;

			// Token: 0x040006F2 RID: 1778
			public static Func<DynValue, DynValue> <>9__3_5;

			// Token: 0x040006F3 RID: 1779
			public static Func<DynValue, object> <>9__3_6;

			// Token: 0x040006F4 RID: 1780
			public static Func<DynValue, DynValue> <>9__3_7;
		}
	}
}
