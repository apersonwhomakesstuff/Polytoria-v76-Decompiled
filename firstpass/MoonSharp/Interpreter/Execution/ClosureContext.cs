using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DF RID: 223
	internal class ClosureContext : List<DynValue>
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0000E397 File Offset: 0x0000C597
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0000E39F File Offset: 0x0000C59F
		public string[] Symbols
		{
			get
			{
				return this.<Symbols>k__BackingField;
			}
			private set
			{
				this.<Symbols>k__BackingField = value;
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		internal ClosureContext(SymbolRef[] symbols, IEnumerable<DynValue> values)
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		internal ClosureContext()
		{
		}

		// Token: 0x040003C6 RID: 966
		private string[] <Symbols>k__BackingField;

		// Token: 0x020001C5 RID: 453
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600101B RID: 4123 RVA: 0x0000F68E File Offset: 0x0000D88E
			internal string <.ctor>b__4_0(SymbolRef s)
			{
				return null;
			}

			// Token: 0x040006FE RID: 1790
			public static readonly ClosureContext.<>c <>9;

			// Token: 0x040006FF RID: 1791
			public static Func<SymbolRef, string> <>9__4_0;
		}
	}
}
