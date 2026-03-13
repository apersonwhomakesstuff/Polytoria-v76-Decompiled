using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000053 RID: 83
	public sealed class MoonSharpModuleMethodAttribute : Attribute
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0000D05E File Offset: 0x0000B25E
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000D066 File Offset: 0x0000B266
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

		// Token: 0x040001E1 RID: 481
		private string <Name>k__BackingField;
	}
}
