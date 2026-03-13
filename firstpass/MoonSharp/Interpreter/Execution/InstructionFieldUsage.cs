using System;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DC RID: 220
	internal enum InstructionFieldUsage
	{
		// Token: 0x040003BC RID: 956
		None,
		// Token: 0x040003BD RID: 957
		Symbol,
		// Token: 0x040003BE RID: 958
		SymbolList,
		// Token: 0x040003BF RID: 959
		Name = 4,
		// Token: 0x040003C0 RID: 960
		Value = 8,
		// Token: 0x040003C1 RID: 961
		NumVal = 16,
		// Token: 0x040003C2 RID: 962
		NumVal2 = 32,
		// Token: 0x040003C3 RID: 963
		NumValAsCodeAddress = 32784
	}
}
