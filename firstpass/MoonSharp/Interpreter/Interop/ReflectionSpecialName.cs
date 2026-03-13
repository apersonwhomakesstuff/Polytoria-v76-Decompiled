using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AB RID: 171
	public struct ReflectionSpecialName
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0000D9B7 File Offset: 0x0000BBB7
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0000D9BF File Offset: 0x0000BBBF
		public ReflectionSpecialNameType Type
		{
			get
			{
				return this.<Type>k__BackingField;
			}
			private set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		public string Argument
		{
			get
			{
				return this.<Argument>k__BackingField;
			}
			private set
			{
				this.<Argument>k__BackingField = value;
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000103A0 File Offset: 0x0000E5A0
		public ReflectionSpecialName(ReflectionSpecialNameType type, string argument = null)
		{
			this.<Type>k__BackingField = ReflectionSpecialNameType.IndexGetter;
			this.<Argument>k__BackingField = null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000103C4 File Offset: 0x0000E5C4
		public ReflectionSpecialName(string name)
		{
			this.<Type>k__BackingField = ReflectionSpecialNameType.IndexGetter;
			this.<Argument>k__BackingField = null;
		}

		// Token: 0x04000313 RID: 787
		private ReflectionSpecialNameType <Type>k__BackingField;

		// Token: 0x04000314 RID: 788
		private string <Argument>k__BackingField;
	}
}
