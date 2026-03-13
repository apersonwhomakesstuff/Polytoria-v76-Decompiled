using System;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E3 RID: 227
	internal class RuntimeScopeBlock
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		public int From
		{
			get
			{
				return this.<From>k__BackingField;
			}
			internal set
			{
				this.<From>k__BackingField = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0000E3D1 File Offset: 0x0000C5D1
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0000E3D9 File Offset: 0x0000C5D9
		public int To
		{
			get
			{
				return this.<To>k__BackingField;
			}
			internal set
			{
				this.<To>k__BackingField = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0000E3E2 File Offset: 0x0000C5E2
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0000E3EA File Offset: 0x0000C5EA
		public int ToInclusive
		{
			get
			{
				return this.<ToInclusive>k__BackingField;
			}
			internal set
			{
				this.<ToInclusive>k__BackingField = value;
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040003C8 RID: 968
		private int <From>k__BackingField;

		// Token: 0x040003C9 RID: 969
		private int <To>k__BackingField;

		// Token: 0x040003CA RID: 970
		private int <ToInclusive>k__BackingField;
	}
}
