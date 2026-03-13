using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002B RID: 43
	public enum CoroutineState
	{
		// Token: 0x04000160 RID: 352
		Main,
		// Token: 0x04000161 RID: 353
		NotStarted,
		// Token: 0x04000162 RID: 354
		Suspended,
		// Token: 0x04000163 RID: 355
		ForceSuspended,
		// Token: 0x04000164 RID: 356
		Running,
		// Token: 0x04000165 RID: 357
		Dead
	}
}
