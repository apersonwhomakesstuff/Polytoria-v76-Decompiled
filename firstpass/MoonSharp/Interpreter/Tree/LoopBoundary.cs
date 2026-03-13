using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000061 RID: 97
	internal class LoopBoundary : ILoop
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x0000D32E File Offset: 0x0000B52E
		public void CompileBreak(ByteCode bc)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000D330 File Offset: 0x0000B530
		public bool IsBoundary()
		{
			return false;
		}
	}
}
