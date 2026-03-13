using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000072 RID: 114
	internal class ScopeBlockStatement : Statement
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x0000D511 File Offset: 0x0000B711
		public ScopeBlockStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000D51A File Offset: 0x0000B71A
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000297 RID: 663
		private Statement m_Block;

		// Token: 0x04000298 RID: 664
		private RuntimeScopeBlock m_StackFrame;

		// Token: 0x04000299 RID: 665
		private SourceRef m_Do;

		// Token: 0x0400029A RID: 666
		private SourceRef m_End;
	}
}
