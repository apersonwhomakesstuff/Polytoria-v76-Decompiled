using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000070 RID: 112
	internal class RepeatStatement : Statement
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x0000D4F2 File Offset: 0x0000B6F2
		public RepeatStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000D4FB File Offset: 0x0000B6FB
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000290 RID: 656
		private Expression m_Condition;

		// Token: 0x04000291 RID: 657
		private Statement m_Block;

		// Token: 0x04000292 RID: 658
		private RuntimeScopeBlock m_StackFrame;

		// Token: 0x04000293 RID: 659
		private SourceRef m_Repeat;

		// Token: 0x04000294 RID: 660
		private SourceRef m_Until;
	}
}
