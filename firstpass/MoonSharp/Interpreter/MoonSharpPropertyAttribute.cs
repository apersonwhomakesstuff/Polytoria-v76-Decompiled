using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000048 RID: 72
	public sealed class MoonSharpPropertyAttribute : Attribute
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0000CF9A File Offset: 0x0000B19A
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0000CFA2 File Offset: 0x0000B1A2
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000CFAB File Offset: 0x0000B1AB
		public MoonSharpPropertyAttribute()
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000CFB3 File Offset: 0x0000B1B3
		public MoonSharpPropertyAttribute(string name)
		{
		}

		// Token: 0x040001BA RID: 442
		private string <Name>k__BackingField;
	}
}
