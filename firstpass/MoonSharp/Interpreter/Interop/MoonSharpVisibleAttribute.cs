using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x02000099 RID: 153
	public sealed class MoonSharpVisibleAttribute : Attribute
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		public bool Visible
		{
			get
			{
				return this.<Visible>k__BackingField;
			}
			private set
			{
				this.<Visible>k__BackingField = value;
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000D8D9 File Offset: 0x0000BAD9
		public MoonSharpVisibleAttribute(bool visible)
		{
		}

		// Token: 0x040002E6 RID: 742
		private bool <Visible>k__BackingField;
	}
}
