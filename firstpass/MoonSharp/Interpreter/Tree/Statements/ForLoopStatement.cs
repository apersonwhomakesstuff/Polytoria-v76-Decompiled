using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006A RID: 106
	internal class ForLoopStatement : Statement
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x0000D3DD File Offset: 0x0000B5DD
		public ForLoopStatement(ScriptLoadingContext lcontext, Token nameToken, Token forToken) : base(null)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x0400026D RID: 621
		private RuntimeScopeBlock m_StackFrame;

		// Token: 0x0400026E RID: 622
		private Statement m_InnerBlock;

		// Token: 0x0400026F RID: 623
		private SymbolRef m_VarName;

		// Token: 0x04000270 RID: 624
		private Expression m_Start;

		// Token: 0x04000271 RID: 625
		private Expression m_End;

		// Token: 0x04000272 RID: 626
		private Expression m_Step;

		// Token: 0x04000273 RID: 627
		private SourceRef m_RefFor;

		// Token: 0x04000274 RID: 628
		private SourceRef m_RefEnd;
	}
}
