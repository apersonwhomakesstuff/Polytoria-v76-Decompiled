using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000047 RID: 71
	public sealed class MoonSharpHideMemberAttribute : Attribute
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0000CF81 File Offset: 0x0000B181
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0000CF89 File Offset: 0x0000B189
		public string MemberName
		{
			get
			{
				return this.<MemberName>k__BackingField;
			}
			private set
			{
				this.<MemberName>k__BackingField = value;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000CF92 File Offset: 0x0000B192
		public MoonSharpHideMemberAttribute(string memberName)
		{
		}

		// Token: 0x040001B9 RID: 441
		private string <MemberName>k__BackingField;
	}
}
