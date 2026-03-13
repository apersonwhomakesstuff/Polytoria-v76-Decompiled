using System;

namespace MoonSharp.Interpreter.Serialization.Json
{
	// Token: 0x02000082 RID: 130
	public sealed class JsonNull
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x0000D670 File Offset: 0x0000B870
		public static bool isNull()
		{
			return false;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000D673 File Offset: 0x0000B873
		public static bool IsJsonNull(DynValue v)
		{
			return false;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0000D676 File Offset: 0x0000B876
		public static DynValue Create()
		{
			return null;
		}
	}
}
