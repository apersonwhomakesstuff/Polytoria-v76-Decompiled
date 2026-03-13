using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A2 RID: 162
	public class AnonWrapper<T> : AnonWrapper
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x0000D936 File Offset: 0x0000BB36
		public AnonWrapper()
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0000D93E File Offset: 0x0000BB3E
		public AnonWrapper(T o)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0000D946 File Offset: 0x0000BB46
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x0000D94E File Offset: 0x0000BB4E
		public T Value
		{
			get
			{
				return this.<Value>k__BackingField;
			}
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x040002EA RID: 746
		private T <Value>k__BackingField;
	}
}
