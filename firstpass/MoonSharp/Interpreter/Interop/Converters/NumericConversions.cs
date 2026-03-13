using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D0 RID: 208
	internal static class NumericConversions
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x0000E1E5 File Offset: 0x0000C3E5
		internal static object DoubleToType(Type type, double d)
		{
			return null;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		internal static double TypeToDouble(Type type, object d)
		{
			return 0.0;
		}

		// Token: 0x0400038D RID: 909
		internal static readonly HashSet<Type> NumericTypes;

		// Token: 0x0400038E RID: 910
		internal static readonly Type[] NumericTypesOrdered;
	}
}
