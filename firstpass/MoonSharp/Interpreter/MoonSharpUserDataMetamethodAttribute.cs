using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004A RID: 74
	public sealed class MoonSharpUserDataMetamethodAttribute : Attribute
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000CFDC File Offset: 0x0000B1DC
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

		// Token: 0x06000597 RID: 1431 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
		public MoonSharpUserDataMetamethodAttribute(string name)
		{
		}

		// Token: 0x040001BC RID: 444
		private string <Name>k__BackingField;
	}
}
