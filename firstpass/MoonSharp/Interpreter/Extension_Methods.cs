using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000026 RID: 38
	internal static class Extension_Methods
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x00010148 File Offset: 0x0000E348
		public static TValue GetOrDefault<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return default(TValue);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00010160 File Offset: 0x0000E360
		public static TValue GetOrCreate<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> creator)
		{
			return default(TValue);
		}
	}
}
