using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000038 RID: 56
	public class TailCallData
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		public DynValue Function
		{
			get
			{
				return this.<Function>k__BackingField;
			}
			set
			{
				this.<Function>k__BackingField = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000CC05 File Offset: 0x0000AE05
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x0000CC0D File Offset: 0x0000AE0D
		public DynValue[] Args
		{
			get
			{
				return this.<Args>k__BackingField;
			}
			set
			{
				this.<Args>k__BackingField = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000CC16 File Offset: 0x0000AE16
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0000CC1E File Offset: 0x0000AE1E
		public CallbackFunction Continuation
		{
			get
			{
				return this.<Continuation>k__BackingField;
			}
			set
			{
				this.<Continuation>k__BackingField = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0000CC27 File Offset: 0x0000AE27
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0000CC2F File Offset: 0x0000AE2F
		public CallbackFunction ErrorHandler
		{
			get
			{
				return this.<ErrorHandler>k__BackingField;
			}
			set
			{
				this.<ErrorHandler>k__BackingField = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0000CC38 File Offset: 0x0000AE38
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0000CC40 File Offset: 0x0000AE40
		public DynValue ErrorHandlerBeforeUnwind
		{
			get
			{
				return this.<ErrorHandlerBeforeUnwind>k__BackingField;
			}
			set
			{
				this.<ErrorHandlerBeforeUnwind>k__BackingField = value;
			}
		}

		// Token: 0x04000199 RID: 409
		private DynValue <Function>k__BackingField;

		// Token: 0x0400019A RID: 410
		private DynValue[] <Args>k__BackingField;

		// Token: 0x0400019B RID: 411
		private CallbackFunction <Continuation>k__BackingField;

		// Token: 0x0400019C RID: 412
		private CallbackFunction <ErrorHandler>k__BackingField;

		// Token: 0x0400019D RID: 413
		private DynValue <ErrorHandlerBeforeUnwind>k__BackingField;
	}
}
