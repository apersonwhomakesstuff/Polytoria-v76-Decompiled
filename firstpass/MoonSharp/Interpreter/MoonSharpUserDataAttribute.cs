using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000049 RID: 73
	public sealed class MoonSharpUserDataAttribute : Attribute
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000CFBB File Offset: 0x0000B1BB
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0000CFC3 File Offset: 0x0000B1C3
		public InteropAccessMode AccessMode
		{
			get
			{
				return this.<AccessMode>k__BackingField;
			}
			set
			{
				this.<AccessMode>k__BackingField = value;
			}
		}

		// Token: 0x040001BB RID: 443
		private InteropAccessMode <AccessMode>k__BackingField;
	}
}
