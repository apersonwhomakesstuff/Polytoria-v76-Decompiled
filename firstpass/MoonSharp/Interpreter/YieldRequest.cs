using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003C RID: 60
	public class YieldRequest
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000CCE1 File Offset: 0x0000AEE1
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0000CCE9 File Offset: 0x0000AEE9
		public bool Forced
		{
			get
			{
				return this.<Forced>k__BackingField;
			}
			internal set
			{
				this.<Forced>k__BackingField = value;
			}
		}

		// Token: 0x040001A9 RID: 425
		public DynValue[] ReturnValues;

		// Token: 0x040001AA RID: 426
		private bool <Forced>k__BackingField;
	}
}
