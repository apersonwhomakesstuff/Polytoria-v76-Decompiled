using System;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E8 RID: 232
	internal enum CallStackItemFlags
	{
		// Token: 0x040003E5 RID: 997
		None,
		// Token: 0x040003E6 RID: 998
		EntryPoint,
		// Token: 0x040003E7 RID: 999
		ResumeEntryPoint = 3,
		// Token: 0x040003E8 RID: 1000
		CallEntryPoint = 5,
		// Token: 0x040003E9 RID: 1001
		TailCall = 16,
		// Token: 0x040003EA RID: 1002
		MethodCall = 32
	}
}
