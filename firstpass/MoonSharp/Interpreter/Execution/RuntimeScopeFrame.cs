using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E4 RID: 228
	internal class RuntimeScopeFrame
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0000E3FE File Offset: 0x0000C5FE
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0000E406 File Offset: 0x0000C606
		public List<SymbolRef> DebugSymbols
		{
			get
			{
				return this.<DebugSymbols>k__BackingField;
			}
			private set
			{
				this.<DebugSymbols>k__BackingField = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0000E40F File Offset: 0x0000C60F
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0000E412 File Offset: 0x0000C612
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x0000E41A File Offset: 0x0000C61A
		public int ToFirstBlock
		{
			get
			{
				return this.<ToFirstBlock>k__BackingField;
			}
			internal set
			{
				this.<ToFirstBlock>k__BackingField = value;
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000E42B File Offset: 0x0000C62B
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040003CB RID: 971
		private List<SymbolRef> <DebugSymbols>k__BackingField;

		// Token: 0x040003CC RID: 972
		private int <ToFirstBlock>k__BackingField;
	}
}
