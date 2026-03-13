using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000052 RID: 82
	public sealed class MoonSharpModuleConstantAttribute : Attribute
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0000D045 File Offset: 0x0000B245
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000D04D File Offset: 0x0000B24D
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x040001E0 RID: 480
		private string <Name>k__BackingField;
	}
}
