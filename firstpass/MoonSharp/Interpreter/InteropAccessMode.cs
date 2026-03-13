using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004B RID: 75
	public enum InteropAccessMode
	{
		// Token: 0x040001BE RID: 446
		Reflection,
		// Token: 0x040001BF RID: 447
		LazyOptimized,
		// Token: 0x040001C0 RID: 448
		Preoptimized,
		// Token: 0x040001C1 RID: 449
		BackgroundOptimized,
		// Token: 0x040001C2 RID: 450
		Hardwired,
		// Token: 0x040001C3 RID: 451
		HideMembers,
		// Token: 0x040001C4 RID: 452
		NoReflectionAllowed,
		// Token: 0x040001C5 RID: 453
		Default
	}
}
