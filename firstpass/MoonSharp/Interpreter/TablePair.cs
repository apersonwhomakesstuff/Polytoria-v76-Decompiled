using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000037 RID: 55
	public struct TablePair
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000CBDB File Offset: 0x0000ADDB
		public DynValue Key
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000CBDD File Offset: 0x0000ADDD
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		public DynValue Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000CBE2 File Offset: 0x0000ADE2
		public TablePair(DynValue key, DynValue val)
		{
			this.key = null;
			this.value = null;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00010298 File Offset: 0x0000E498
		public static TablePair Nil
		{
			get
			{
				return default(TablePair);
			}
		}

		// Token: 0x04000196 RID: 406
		private static TablePair s_NilNode;

		// Token: 0x04000197 RID: 407
		private DynValue key;

		// Token: 0x04000198 RID: 408
		private DynValue value;
	}
}
