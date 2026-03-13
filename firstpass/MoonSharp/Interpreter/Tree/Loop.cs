using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000060 RID: 96
	internal class Loop : ILoop
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x0000D321 File Offset: 0x0000B521
		public void CompileBreak(ByteCode bc)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000D323 File Offset: 0x0000B523
		public bool IsBoundary()
		{
			return false;
		}

		// Token: 0x04000259 RID: 601
		public RuntimeScopeBlock Scope;

		// Token: 0x0400025A RID: 602
		public List<Instruction> BreakJumps;
	}
}
