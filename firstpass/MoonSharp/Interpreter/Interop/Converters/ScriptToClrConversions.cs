using System;
using System.Reflection;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D1 RID: 209
	internal static class ScriptToClrConversions
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x0000E1F3 File Offset: 0x0000C3F3
		internal static object DynValueToObject(DynValue value)
		{
			return null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0000E1F6 File Offset: 0x0000C3F6
		public static MethodInfo HasImplicitConversion(Type baseType, Type targetType)
		{
			return null;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0000E1F9 File Offset: 0x0000C3F9
		internal static object DynValueToObjectOfType(DynValue value, Type desiredType, object defaultValue, bool isOptional)
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		internal static int DynValueToObjectOfTypeWeight(DynValue value, Type desiredType, bool isOptional)
		{
			return 0;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0000E1FF File Offset: 0x0000C3FF
		private static int GetNumericTypeWeight(Type desiredType)
		{
			return 0;
		}

		// Token: 0x0400038F RID: 911
		internal const int WEIGHT_MAX_VALUE = 100;

		// Token: 0x04000390 RID: 912
		internal const int WEIGHT_CUSTOM_CONVERTER_MATCH = 100;

		// Token: 0x04000391 RID: 913
		internal const int WEIGHT_EXACT_MATCH = 100;

		// Token: 0x04000392 RID: 914
		internal const int WEIGHT_STRING_TO_STRINGBUILDER = 99;

		// Token: 0x04000393 RID: 915
		internal const int WEIGHT_STRING_TO_CHAR = 98;

		// Token: 0x04000394 RID: 916
		internal const int WEIGHT_NIL_TO_NULLABLE = 100;

		// Token: 0x04000395 RID: 917
		internal const int WEIGHT_NIL_TO_REFTYPE = 100;

		// Token: 0x04000396 RID: 918
		internal const int WEIGHT_VOID_WITH_DEFAULT = 50;

		// Token: 0x04000397 RID: 919
		internal const int WEIGHT_VOID_WITHOUT_DEFAULT = 25;

		// Token: 0x04000398 RID: 920
		internal const int WEIGHT_NIL_WITH_DEFAULT = 25;

		// Token: 0x04000399 RID: 921
		internal const int WEIGHT_BOOL_TO_STRING = 5;

		// Token: 0x0400039A RID: 922
		internal const int WEIGHT_NUMBER_TO_STRING = 50;

		// Token: 0x0400039B RID: 923
		internal const int WEIGHT_NUMBER_TO_ENUM = 90;

		// Token: 0x0400039C RID: 924
		internal const int WEIGHT_USERDATA_TO_STRING = 5;

		// Token: 0x0400039D RID: 925
		internal const int WEIGHT_TABLE_CONVERSION = 90;

		// Token: 0x0400039E RID: 926
		internal const int WEIGHT_NUMBER_DOWNCAST = 99;

		// Token: 0x0400039F RID: 927
		internal const int WEIGHT_NO_MATCH = 0;

		// Token: 0x040003A0 RID: 928
		internal const int WEIGHT_NO_EXTRA_PARAMS_BONUS = 100;

		// Token: 0x040003A1 RID: 929
		internal const int WEIGHT_EXTRA_PARAMS_MALUS = 2;

		// Token: 0x040003A2 RID: 930
		internal const int WEIGHT_BYREF_BONUSMALUS = -10;

		// Token: 0x040003A3 RID: 931
		internal const int WEIGHT_VARARGS_MALUS = 1;

		// Token: 0x040003A4 RID: 932
		internal const int WEIGHT_VARARGS_EMPTY = 40;
	}
}
