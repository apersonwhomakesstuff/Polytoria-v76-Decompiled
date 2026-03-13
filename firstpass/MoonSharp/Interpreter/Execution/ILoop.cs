using System;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E1 RID: 225
	internal interface ILoop
	{
		// Token: 0x06000A34 RID: 2612
		void CompileBreak(ByteCode bc);

		// Token: 0x06000A35 RID: 2613
		bool IsBoundary();
	}
}
