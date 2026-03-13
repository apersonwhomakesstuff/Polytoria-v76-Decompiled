using System;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x02000100 RID: 256
	public enum WatchType
	{
		// Token: 0x0400048F RID: 1167
		Watches,
		// Token: 0x04000490 RID: 1168
		VStack,
		// Token: 0x04000491 RID: 1169
		CallStack,
		// Token: 0x04000492 RID: 1170
		Coroutines,
		// Token: 0x04000493 RID: 1171
		Locals,
		// Token: 0x04000494 RID: 1172
		Threads,
		// Token: 0x04000495 RID: 1173
		MaxValue
	}
}
