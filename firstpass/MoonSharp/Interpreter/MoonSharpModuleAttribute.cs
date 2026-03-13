using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000051 RID: 81
	public sealed class MoonSharpModuleAttribute : Attribute
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0000D02C File Offset: 0x0000B22C
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0000D034 File Offset: 0x0000B234
		public string Namespace
		{
			get
			{
				return this.<Namespace>k__BackingField;
			}
			set
			{
				this.<Namespace>k__BackingField = value;
			}
		}

		// Token: 0x040001DF RID: 479
		private string <Namespace>k__BackingField;
	}
}
