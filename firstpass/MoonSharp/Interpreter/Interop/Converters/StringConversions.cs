using System;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D2 RID: 210
	internal static class StringConversions
	{
		// Token: 0x060009C1 RID: 2497 RVA: 0x000104A8 File Offset: 0x0000E6A8
		internal static StringConversions.StringSubtype GetStringSubtype(Type desiredType)
		{
			return StringConversions.StringSubtype.None;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0000E202 File Offset: 0x0000C402
		internal static object ConvertString(StringConversions.StringSubtype stringSubType, string str, Type desiredType, DataType dataType)
		{
			return null;
		}

		// Token: 0x020001BF RID: 447
		internal enum StringSubtype
		{
			// Token: 0x040006E8 RID: 1768
			None,
			// Token: 0x040006E9 RID: 1769
			String,
			// Token: 0x040006EA RID: 1770
			StringBuilder,
			// Token: 0x040006EB RID: 1771
			Char
		}
	}
}
