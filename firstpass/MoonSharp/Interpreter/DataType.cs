using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002C RID: 44
	public enum DataType
	{
		// Token: 0x04000167 RID: 359
		Nil,
		// Token: 0x04000168 RID: 360
		Void,
		// Token: 0x04000169 RID: 361
		Boolean,
		// Token: 0x0400016A RID: 362
		Number,
		// Token: 0x0400016B RID: 363
		String,
		// Token: 0x0400016C RID: 364
		Function,
		// Token: 0x0400016D RID: 365
		Table,
		// Token: 0x0400016E RID: 366
		Tuple,
		// Token: 0x0400016F RID: 367
		UserData,
		// Token: 0x04000170 RID: 368
		Thread,
		// Token: 0x04000171 RID: 369
		ClrFunction,
		// Token: 0x04000172 RID: 370
		TailCallRequest,
		// Token: 0x04000173 RID: 371
		YieldRequest
	}
}
