using System;
using System.Collections.Concurrent;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009A RID: 154
	public class CustomConvertersCollection
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x0000D8E1 File Offset: 0x0000BAE1
		internal CustomConvertersCollection()
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0000D8E9 File Offset: 0x0000BAE9
		public void SetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType, Func<DynValue, object> converter = null, Func<DynValue, bool> canConvert = null)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0000D8EB File Offset: 0x0000BAEB
		public Func<DynValue, object> GetScriptToClrCustomConversion(DynValue scriptValue, Type clrDataType)
		{
			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000D8EE File Offset: 0x0000BAEE
		public void SetClrToScriptCustomConversion(Type clrDataType, Func<Script, object, DynValue> converter = null)
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		public void SetClrToScriptCustomConversion<T>(Func<Script, T, DynValue> converter = null)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
		public Func<Script, object, DynValue> GetClrToScriptCustomConversion(Type clrDataType)
		{
			return null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000D8F5 File Offset: 0x0000BAF5
		public void SetClrToScriptCustomConversion(Type clrDataType, Func<object, DynValue> converter = null)
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0000D8F7 File Offset: 0x0000BAF7
		public void SetClrToScriptCustomConversion<T>(Func<T, DynValue> converter = null)
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000D8F9 File Offset: 0x0000BAF9
		public void Clear()
		{
		}

		// Token: 0x040002E7 RID: 743
		private ConcurrentDictionary<Type, Func<DynValue, object>>[] m_Script2Clr;

		// Token: 0x040002E8 RID: 744
		private ConcurrentDictionary<Type, Func<Script, object, DynValue>> m_Clr2Script;

		// Token: 0x040002E9 RID: 745
		private ConcurrentDictionary<Type, Func<DynValue, bool>> m_conversionPredicates;

		// Token: 0x02000195 RID: 405
		private sealed class <>c__DisplayClass10_0<T>
		{
			// Token: 0x06000F4F RID: 3919 RVA: 0x0000F470 File Offset: 0x0000D670
			internal DynValue <SetClrToScriptCustomConversion>b__0(object o)
			{
				return null;
			}

			// Token: 0x0400068B RID: 1675
			public Func<T, DynValue> converter;
		}

		// Token: 0x02000196 RID: 406
		private sealed class <>c__DisplayClass7_0<T>
		{
			// Token: 0x06000F51 RID: 3921 RVA: 0x0000F47B File Offset: 0x0000D67B
			internal DynValue <SetClrToScriptCustomConversion>b__0(Script s, object o)
			{
				return null;
			}

			// Token: 0x0400068C RID: 1676
			public Func<Script, T, DynValue> converter;
		}

		// Token: 0x02000197 RID: 407
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000F53 RID: 3923 RVA: 0x0000F486 File Offset: 0x0000D686
			internal DynValue <SetClrToScriptCustomConversion>b__0(Script s, object o)
			{
				return null;
			}

			// Token: 0x0400068D RID: 1677
			public Func<object, DynValue> converter;
		}
	}
}
