using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000073 RID: 115
	internal class WhileStatement : Statement
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x0000D51C File Offset: 0x0000B71C
		public WhileStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000D525 File Offset: 0x0000B725
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x0400029B RID: 667
		private Expression m_Condition;

		// Token: 0x0400029C RID: 668
		private Statement m_Block;

		// Token: 0x0400029D RID: 669
		private RuntimeScopeBlock m_StackFrame;

		// Token: 0x0400029E RID: 670
		private SourceRef m_Start;

		// Token: 0x0400029F RID: 671
		private SourceRef m_End;
	}
}
